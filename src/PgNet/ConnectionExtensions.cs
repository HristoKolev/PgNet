namespace PgNet
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;
    using System.Threading.Tasks;

    using Npgsql;

    using NpgsqlTypes;

    public static class ConnectionExtensions
    {
        /// <summary>
        /// The default parameter type map that is used when creating parameters without specifying the NpgsqlDbType explicitly.
        /// </summary>
        // ReSharper disable once StaticMemberInGenericType
        private static readonly Dictionary<Type, NpgsqlDbType> DefaultNpgsqlDbTypeMap = new Dictionary<Type, NpgsqlDbType>
        {
            { typeof(int), NpgsqlDbType.Integer },
            { typeof(long), NpgsqlDbType.Bigint },
            { typeof(bool), NpgsqlDbType.Boolean },
            { typeof(float), NpgsqlDbType.Real },
            { typeof(double), NpgsqlDbType.Double },
            { typeof(short), NpgsqlDbType.Smallint },
            { typeof(decimal), NpgsqlDbType.Numeric },
            { typeof(string), NpgsqlDbType.Text },
            { typeof(DateTime), NpgsqlDbType.Timestamp },
            { typeof(byte[]), NpgsqlDbType.Bytea },
            { typeof(int?), NpgsqlDbType.Integer },
            { typeof(long?), NpgsqlDbType.Bigint },
            { typeof(bool?), NpgsqlDbType.Boolean },
            { typeof(float?), NpgsqlDbType.Real },
            { typeof(double?), NpgsqlDbType.Double },
            { typeof(short?), NpgsqlDbType.Smallint },
            { typeof(decimal?), NpgsqlDbType.Numeric },
            { typeof(DateTime?), NpgsqlDbType.Timestamp },
            // ReSharper disable BitwiseOperatorOnEnumWithoutFlags
            { typeof(string[]), NpgsqlDbType.Array   | NpgsqlDbType.Text },
            { typeof(int[]), NpgsqlDbType.Array      | NpgsqlDbType.Integer },
            { typeof(DateTime[]), NpgsqlDbType.Array | NpgsqlDbType.Timestamp },
            // ReSharper restore BitwiseOperatorOnEnumWithoutFlags
        };
        
        public static async Task<int> ExecuteNonQuery(
            this NpgsqlConnection connection, 
            string sql, 
            IEnumerable<NpgsqlParameter> parameters, 
            CancellationToken cancellationToken = default)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            
            if (sql == null)
            {
                throw new ArgumentNullException(nameof(sql));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            await VerifyConnectionState(connection, cancellationToken);

            using (var command = CreateCommand(connection, sql, parameters))
            {
                await command.PrepareAsync(cancellationToken);

                return await command.ExecuteNonQueryAsync(cancellationToken);
            }
        }

        public static async Task<T> ExecuteScalar<T>(
            this NpgsqlConnection connection, 
            string sql, 
            IEnumerable<NpgsqlParameter> parameters,
            CancellationToken cancellationToken = default)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            
            if (sql == null)
            {
                throw new ArgumentNullException(nameof(sql));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            await VerifyConnectionState(connection, cancellationToken);

            using (var command = CreateCommand(connection, sql, parameters))
            {
                await command.PrepareAsync(cancellationToken);

                await using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                {
                    if (reader.FieldCount == 0)
                    {
                        throw new ApplicationException("No columns returned for query that expected exactly one column.");
                    }

                    if (reader.FieldCount > 1)
                    {
                        throw new ApplicationException("More than one column returned for query that expected exactly one column.");
                    }

                    bool hasRow = await reader.ReadAsync(cancellationToken);

                    if (!hasRow)
                    {
                        throw new ApplicationException("No rows returned for query that expected exactly one row.");
                    }

                    var value = reader.GetValue(0);

                    bool hasMoreRows = await reader.ReadAsync(cancellationToken);

                    if (hasMoreRows)
                    {
                        throw new ApplicationException("More than one row returned for query that expected exactly one row.");
                    }

                    if (value is DBNull)
                    {
                        if (default(T) == null)
                        {
                            value = null;
                        }
                        else
                        {
                            throw new ApplicationException("Cannot cast DBNull value to a value type parameter.");
                        }
                    }

                    return (T)value;
                }
            }
        }

        public static async Task<List<T>> Query<T>(
            this NpgsqlConnection connection,
            string sql, 
            IEnumerable<NpgsqlParameter> parameters, 
            CancellationToken cancellationToken = default) 
            where T : new()
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            
            if (sql == null)
            {
                throw new ArgumentNullException(nameof(sql));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
           
            await VerifyConnectionState(connection, cancellationToken);

            var result = new List<T>();

            using (var command = CreateCommand(connection, sql, parameters))
            {
                await command.PrepareAsync(cancellationToken);

                await using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                {
                    var setters = DbCodeGenerator.GenerateSetters<T>();

                    // cached field count - I know it pointless, but I feel better by having it cached here.
                    int fieldCount = reader.FieldCount;

                    // cached setters for the result type
                    var settersByColumnOrder = new Action<T, object>[fieldCount];

                    for (int i = 0; i < fieldCount; i++)
                    {
                        settersByColumnOrder[i] = setters[reader.GetName(i)];
                    }

                    while (await reader.ReadAsync(cancellationToken))
                    {
                        var instance = new T();

                        for (int i = 0; i < fieldCount; i++)
                        {
                            // ReSharper disable once AsyncConverter.CanBeUseAsyncMethodHighlighting
                            if (reader.IsDBNull(i))
                            {
                                settersByColumnOrder[i](instance, null);
                            }
                            else
                            {
                                settersByColumnOrder[i](instance, reader.GetValue(i));
                            }
                        }

                        result.Add(instance);
                    }
                }
            }

            return result;
        }

        public static async Task<T> QueryOne<T>(
            this NpgsqlConnection connection,
            string sql,
            IEnumerable<NpgsqlParameter> parameters, 
            CancellationToken cancellationToken = default)
            where T : class, new()
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
            
            if (sql == null)
            {
                throw new ArgumentNullException(nameof(sql));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            
            await VerifyConnectionState(connection, cancellationToken);

            using (var command = CreateCommand(connection, sql, parameters))
            {
                await command.PrepareAsync(cancellationToken);

                await using (var reader = await command.ExecuteReaderAsync(cancellationToken))
                {
                    var instance = new T();

                    var setters = DbCodeGenerator.GenerateSetters<T>();

                    bool hasRow = await reader.ReadAsync(cancellationToken);

                    if (!hasRow)
                    {
                        return null;
                    }

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var setter = setters[reader.GetName(i)];

                        // ReSharper disable once AsyncConverter.CanBeUseAsyncMethodHighlighting
                        if (reader.IsDBNull(i))
                        {
                            setter(instance, null);
                        }
                        else
                        {
                            setter(instance, reader.GetValue(i));
                        }
                    }

                    bool hasMoreRows = await reader.ReadAsync(cancellationToken);

                    if (hasMoreRows)
                    {
                        throw new ApplicationException("More than one row returned for query that expected only one row.");
                    }

                    return instance;
                }
            }
        }
       
        public static async Task ExecuteInTransaction(
            this NpgsqlConnection connection,
            Func<NpgsqlTransaction, Task> body, 
            CancellationToken cancellationToken = default)
        {
            await VerifyConnectionState(connection, cancellationToken);

            await using (var transaction = connection.BeginTransaction())
            {
                if (cancellationToken == default)
                {
                    await body(transaction);
                }
                else
                {
                    var canceledTask = cancellationToken.AsTask();
                    var transactionTask = body(transaction);

                    var completedTask = await Task.WhenAny(transactionTask, canceledTask);

                    if (completedTask == canceledTask)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    await transactionTask;
                }
            }
        }

        public static Task ExecuteInTransactionAndCommit(
            this NpgsqlConnection connection,
            Func<Task> body, CancellationToken cancellationToken = default)
        {
            return ExecuteInTransactionAndCommit(connection,tr => body(), cancellationToken);
        }

        public static async Task ExecuteInTransactionAndCommit(
            this NpgsqlConnection connection, 
            Func<NpgsqlTransaction, Task> body, 
            CancellationToken cancellationToken = default)
        {
            await VerifyConnectionState(connection, cancellationToken);

            await using (var transaction = connection.BeginTransaction())
            {
                if (cancellationToken == default)
                {
                    await body(transaction);
                }
                else
                {
                    var canceledTask = cancellationToken.AsTask();
                    var transactionTask = body(transaction);

                    var completedTask = await Task.WhenAny(transactionTask, canceledTask);

                    if (completedTask == canceledTask)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    await transactionTask;
                }

                if (!transaction.IsCompleted)
                {
                    await transaction.CommitAsync(cancellationToken);
                }
            }
        }
        
        public static NpgsqlParameter CreateParameter<T>(
            this NpgsqlConnection connection,
            string parameterName, 
            T value)
        {
            NpgsqlDbType dbType;

            var type = typeof(T);

            if (DefaultNpgsqlDbTypeMap.ContainsKey(type))
            {
                dbType = DefaultNpgsqlDbTypeMap[type];
            }
            else
            {
                throw new ApplicationException(
                    "Parameter type is not mapped to any \'NpgsqlDbType\'. Please specify a \'NpgsqlDbType\' explicitly.");
            }

            return connection.CreateParameter(parameterName, value, dbType);
        }

        public static NpgsqlParameter CreateParameter<T>(this NpgsqlConnection connection, string parameterName, T value, NpgsqlDbType dbType)
        {
            if (value == null)
            {
                return new NpgsqlParameter(parameterName, DBNull.Value);
            }

            return new NpgsqlParameter<T>(parameterName, dbType)
            {
                TypedValue = value
            };
        }

        public static NpgsqlParameter CreateParameter(this NpgsqlConnection connection, string parameterName, object value)
        {
            return new NpgsqlParameter(parameterName, value);
        }
        
        /// <summary>
        /// Opens the connection if it's closed.
        /// </summary>
        private static Task VerifyConnectionState(NpgsqlConnection connection, CancellationToken cancellationToken = default)
        {
            if (connection.State == ConnectionState.Closed)
            {
                return connection.OpenAsync(cancellationToken);
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Creates a command.
        /// </summary>
        private static NpgsqlCommand CreateCommand(NpgsqlConnection connection, string sql, IEnumerable<NpgsqlParameter> parameters)
        {
            var command = connection.CreateCommand();
            
            command.CommandText = sql;

            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }

            return command;
        }
    }
}