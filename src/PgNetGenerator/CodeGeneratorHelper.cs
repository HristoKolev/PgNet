using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;
using NpgsqlTypes;

namespace PgNetGenerator
{
    public static class CodeGeneratorHelper
    {
        private static Dictionary<string, string> ClrTypesByDatabaseTypes { get; }

        private static Dictionary<string, string> Linq2DbDataTypesByDbDataTypes { get; }

        private static Dictionary<string, NpgsqlDbType> NpgsTypesByDatabaseTypes { get; }
        
        private static Dictionary<string, string> PostgreSqlTypeAliases { get; }
        
        private static List<string> TypesThatCanBeNullable { get; }
        
        static CodeGeneratorHelper()
        {
            ClrTypesByDatabaseTypes = new Dictionary<string, string>
            {
                { "smallint", "short" },
                { "integer", "int" },
                { "bigint", "long" },
                { "real", "float" },
                { "double precision", "double" },
                { "boolean", "bool" },
                { "text", "string" },
                { "xml", "string" },
                { "date", "DateTime" },
                { "bytea", "byte[]" },
                { "uuid", "string" },
                { "json", "string" },
                { "jsonb", "string" },
                { "character varying", "string" },
                { "character", "string" },
                { "numeric", "decimal" },
                { "timestamp with time zone", "DateTimeOffset" },
                { "timestamp without time zone", "DateTime" },
                
                { "_int8", "long[]" },
                { "bigint[]", "long[]" },
            };

            Linq2DbDataTypesByDbDataTypes = new Dictionary<string, string>
            {
                { "character", "DataType.NChar" },
                { "text", "DataType.Text" },
                { "smallint", "DataType.Int16" },
                { "integer", "DataType.Int32" },
                { "bigint", "DataType.Int64" },
                { "real", "DataType.Single" },
                { "double precision", "DataType.Double" },
                { "bytea", "DataType.Binary" },
                { "boolean", "DataType.Boolean" },
                { "numeric", "DataType.Decimal" },
                { "money", "DataType.Money" },
                { "uuid", "DataType.Guid" },
                { "character varying", "DataType.NVarChar" },
                { "timestamp with time zone", "DataType.DateTimeOffset" },
                { "timestamp without time zone", "DataType.DateTime2" },
                { "time with time zone", "DataType.Time" },
                { "time without time zone", "DataType.Time" },
                { "interval", "DataType.Time" },
                { "date", "DataType.Date" },
                { "xml", "DataType.Xml" },
                { "point", "DataType.Udt" },
                { "lseg", "DataType.Udt" },
                { "box", "DataType.Udt" },
                { "circle", "DataType.Udt" },
                { "path", "DataType.Udt" },
                { "line", "DataType.Udt" },
                { "polygon", "DataType.Udt" },
                { "macaddr", "DataType.Udt" },
                { "USER-DEFINED", "DataType.Udt" },
                { "bit", "DataType.BitArray" },
                { "bit varying", "DataType.BitArray" },
                { "hstore", "DataType.Dictionary" },
                { "json", "DataType.Json" },
                { "jsonb", "DataType.BinaryJson" },
                
                { "_int8", "DataType.Undefined" },
                { "bigint[]", "DataType.Undefined" },
            };

            NpgsTypesByDatabaseTypes = new Dictionary<string, NpgsqlDbType>
            {
                { "bigint", NpgsqlDbType.Bigint },
                { "boolean", NpgsqlDbType.Boolean },
                { "box", NpgsqlDbType.Box },
                { "bytea", NpgsqlDbType.Bytea },
                { "circle", NpgsqlDbType.Circle },
                { "bpchar", NpgsqlDbType.Char },
                { "date", NpgsqlDbType.Date },
                { "double precision", NpgsqlDbType.Double },
                { "integer", NpgsqlDbType.Integer },
                { "line", NpgsqlDbType.Line },
                { "lseg", NpgsqlDbType.LSeg },
                { "money", NpgsqlDbType.Money },
                { "numeric", NpgsqlDbType.Numeric },
                { "path", NpgsqlDbType.Path },
                { "point", NpgsqlDbType.Point },
                { "polygon", NpgsqlDbType.Polygon },
                { "real", NpgsqlDbType.Real },
                { "smallint", NpgsqlDbType.Smallint },
                { "text", NpgsqlDbType.Text },
                { "time without time zone", NpgsqlDbType.Time },
                { "timestamp without time zone", NpgsqlDbType.Timestamp },
                { "character varying", NpgsqlDbType.Varchar },
                { "refcursor", NpgsqlDbType.Refcursor },
                { "inet", NpgsqlDbType.Inet },
                { "bit", NpgsqlDbType.Bit },
                { "uuid", NpgsqlDbType.Uuid },
                { "xml", NpgsqlDbType.Xml },
                { "oidvector", NpgsqlDbType.Oidvector },
                { "interval", NpgsqlDbType.Interval },
                { "time with time zone", NpgsqlDbType.TimeTz },
                { "timestamp with time zone", NpgsqlDbType.TimestampTz },
                { "name", NpgsqlDbType.Name },
                { "macaddr", NpgsqlDbType.MacAddr },
                { "json", NpgsqlDbType.Json },
                { "jsonb", NpgsqlDbType.Jsonb },
                { "character", NpgsqlDbType.Char },
                { "bit varying", NpgsqlDbType.Varbit },
                { "unknown", NpgsqlDbType.Unknown },
                { "oid", NpgsqlDbType.Oid },
                { "xid", NpgsqlDbType.Xid },
                { "cid", NpgsqlDbType.Cid },
                { "cidr", NpgsqlDbType.Cidr },
                { "tsvector", NpgsqlDbType.TsVector },
                { "tsquery", NpgsqlDbType.TsQuery },
                { "regtype", NpgsqlDbType.Regtype },
                { "int2vector", NpgsqlDbType.Int2Vector },
                { "tid", NpgsqlDbType.Tid },
                { "macaddr8", NpgsqlDbType.MacAddr8 },
                
                { "_int8", NpgsqlDbType.Bigint | NpgsqlDbType.Array },
                { "bigint[]", NpgsqlDbType.Bigint | NpgsqlDbType.Array },
            };
            
            TypesThatCanBeNullable = new List<string>
            {
                "short",
                "int",
                "long",
                "char",

                "bool",

                "double",
                "float",
                "decimal",

                "DateTime",
                "DateTimeOffset",
            };
            
            PostgreSqlTypeAliases = new Dictionary<string, string>()
            {
                { "int8", "bigint" },
                { "serial8", "bigserial" },
                { "varbit", "bit varying" },
                { "bool", "boolean" },
                { "char", "character" },
                { "varchar", "character varying" },
                { "float8", "double precision" },
                { "int", "integer" },
                { "int4", "integer" },
                { "decimal", "numeric" },
                { "float4", "real" },
                { "int2", "smallint" },
                { "serial2", "smallserial" },
                { "serial4", "serial" },
                { "timetz", "time with time zone" },
                { "timestamptz", "timestamp with time zone" },
            };
            
            ApplyAliases(ClrTypesByDatabaseTypes);
            ApplyAliases(Linq2DbDataTypesByDbDataTypes);
            ApplyAliases(NpgsTypesByDatabaseTypes);
        }

        private static void ApplyAliases<T>(Dictionary<string, T> dictionary)
        {
            foreach (var alias in PostgreSqlTypeAliases)
            {
                if (dictionary.ContainsKey(alias.Value))
                {
                    var value = dictionary[alias.Value];
                    
                    dictionary.Add(alias.Key, value);
                }
            }
        }

        public static string GetClassName(string tableName)
        {
            var parts = tableName.Split('_')
                                 .Select(Singularize)
                                 .Select(x => char.ToUpper(x.First()) + x.Substring(1).ToLower());

            return string.Join(string.Empty, parts);
        }

        public static string GetLinq2DbDataType(string dbDataType)
        {
            return Linq2DbDataTypesByDbDataTypes[dbDataType];
        }

        public static NpgsqlDbType GetNpgsqlDbType(string dbDataType)
        {
            return NpgsTypesByDatabaseTypes[dbDataType];
        }

        public static string GetPluralClassName(string tableName)
        {
            var parts = tableName.Split('_').Select(x => char.ToUpper(x.First()) + x.Substring(1).ToLower());

            return string.Join(string.Empty, parts);
        }

        public static string GetPropertyName(string name)
        {
            var parts = name.Split('_')
                            .Select(x =>
                            {
                                if (x.ToLower() == "id")
                                {
                                    return "ID";
                                }

                                return char.ToUpper(x.First()) + x.Substring(1).ToLower();
                            });

            return string.Join(string.Empty, parts);
        }

        public static string GetClrType(string dbDataType, bool isNullable)
        {
            string clrType = ClrTypesByDatabaseTypes[dbDataType];

            if (isNullable && TypesThatCanBeNullable.Contains(clrType))
            {
                clrType += "?";
            }

            return clrType;
        }

        public static string GetNullablePropertyType(string dbDataType)
        {
            string clrType = ClrTypesByDatabaseTypes[dbDataType];

            if (TypesThatCanBeNullable.Contains(clrType))
            {
                clrType += "?";
            }

            return clrType;
        }

        private static string Singularize(string word) => word.Singularize(false);
    }

    public static class TypeExtensions
    {
        public static string GetLiteral<T>(this T obj) where T : Enum
        {
            var objType = obj.GetType();
            
            var result = new List<T>();
            
            foreach (Enum value in Enum.GetValues(objType))
            {
                if (obj.HasFlag(value))
                {
                    result.Add((T)value);
                }
            }

            return string.Join(" | ", result.Select(x => $"{objType.Name}.{x.ToString()}"));
        }
    }
}