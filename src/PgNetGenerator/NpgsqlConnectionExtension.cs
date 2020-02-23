using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Npgsql;

namespace PgNetGenerator
{
    public static class NpgsqlConnectionExtension
    {
        private static readonly ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>> PropertiesCache =
            new ConcurrentDictionary<Type, Dictionary<string, PropertyInfo>>();

        public static async Task<List<T>> Execute<T>(this NpgsqlConnection connection, string sql, params NpgsqlParameter[] parameters)
            where T : new()
        {
            if (connection.State == ConnectionState.Closed)
            {
                await connection.OpenAsync();
            }

            using (var command = connection.CreateCommand())
            {
                command.Parameters.AddRange(parameters);
                command.CommandText = sql;

                var properties = PropertiesCache.GetOrAdd(
                    typeof(T), 
                    t => t.GetProperties().ToDictionary(x => x.Name.ToLower(), x => x)
                );

                using (var reader = await command.ExecuteReaderAsync())
                {
                    var list = new List<T>();

                    while (await reader.ReadAsync())
                    {
                        var instance = new T();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var property = properties[reader.GetName(i)];

                            if (await reader.IsDBNullAsync(i))
                            {
                                property.SetValue(instance, null);
                            }
                            else
                            {
                                property.SetValue(instance, reader.GetValue(i));
                            }
                        }

                        list.Add(instance);
                    }

                    return list;
                }
            }
        }
    }
}