namespace PgNet
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;
    using System.Threading.Tasks;

    using Npgsql;

    using NpgsqlTypes;

    public partial class DbService<TPocos>
    {
        public async Task<NpgsqlTransaction> BeginTransaction()
        {
            if (this.connection.State == ConnectionState.Closed)
            {
                await this.connection.OpenAsync();
            }

            return this.connection.BeginTransaction();
        }

        public Task ExecuteInTransaction(Func<NpgsqlTransaction, Task> body, CancellationToken cancellationToken = default) => 
            this.connection.ExecuteInTransaction(body, cancellationToken);

        public Task ExecuteInTransactionAndCommit(Func<Task> body, CancellationToken cancellationToken = default) => 
            this.connection.ExecuteInTransactionAndCommit(body, cancellationToken);

        public Task ExecuteInTransactionAndCommit(Func<NpgsqlTransaction, Task> body, CancellationToken cancellationToken = default) => 
            this.connection.ExecuteInTransactionAndCommit(body, cancellationToken);

        public Task<int> ExecuteNonQuery(string sql, params NpgsqlParameter[] parameters) => 
            this.connection.ExecuteNonQuery(sql, parameters);

        public Task<T> ExecuteScalar<T>(string sql, params NpgsqlParameter[] parameters) => 
            this.connection.ExecuteScalar<T>(sql, parameters);

        public NpgsqlParameter CreateParameter<T>(string parameterName, T value) => 
            this.connection.CreateParameter(parameterName, value);

        public NpgsqlParameter CreateParameter<T>(string parameterName, T value, NpgsqlDbType dbType) => 
            this.connection.CreateParameter(parameterName, value, dbType);

        public Task<List<T>> Query<T>(string sql, params NpgsqlParameter[] parameters)
            where T : new() => this.connection.Query<T>(sql, parameters);

        public Task<T> QueryOne<T>(string sql, params NpgsqlParameter[] parameters)
            where T : class, new() => this.connection.QueryOne<T>(sql, parameters);
    }
}