using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace PgNetGenerator
{
    public class DbSchemaRepository
    {
        private NpgsqlConnection Connection { get; }
        
        public DbSchemaRepository(NpgsqlConnection connection)
        {
            this.Connection = connection;
        }
        
        public async Task<List<TableMetadataModel>> GetTables(string sql)
        {
            var columns = await this.Connection.Execute<ColumnMetadataModel>(sql);

            var tables = columns.GroupBy(model => model.TableName)
                                .Select(group => new TableMetadataModel
                                {
                                    TableName = group.Key,
                                    Columns = group.ToList(),
                                })
                                .OrderBy(x => x.IsView)
                                .ThenBy(t => t.TableName)
                                .ToList();

            foreach (var table in tables)
            {
                table.ClassName = CodeGeneratorHelper.GetClassName(table.TableName);
                table.PluralClassName = CodeGeneratorHelper.GetPluralClassName(table.TableName);
                table.TableSchema = table.Columns.First().TableSchema;
                table.IsView = table.Columns.Any(x => x.IsViewColumn);

                foreach (var column in table.Columns)
                {
                    column.PropertyType = new SimpleType(column.DbDataType, column.IsNullable);
                    column.PropertyName = CodeGeneratorHelper.GetPropertyName(column.ColumnName);
                    column.IsPrimaryKey = column.PrimaryKeyConstraintName != null;
                    column.IsForeignKey = column.ForeignKeyConstraintName != null;
                    column.Comments = (column.ColumnComment ?? string.Empty)
                        .Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                }

                if (!table.IsView)
                {
                    var pkColumn = table.Columns.Single(c => c.IsPrimaryKey);
                    
                    table.PrimaryKeyColumnName = pkColumn.ColumnName;
                    table.PrimaryKeyPropertyName = CodeGeneratorHelper.GetPropertyName(pkColumn.ColumnName);
                }
            }

            return tables.ToList();
        }

        public async Task<List<FunctionMetadataModel>> GetFunctions(string sql)
        {
            var functions = await this.Connection.Execute<FunctionMetadataModel>(sql);

            foreach (var function in functions)
            {
                function.FunctionReturnType = new SimpleType(function.FunctionReturnTypeName, true);
                function.MethodName = CodeGeneratorHelper.GetPropertyName(function.FunctionName);
                function.Comments = (function.FunctionComment ?? string.Empty)
                    .Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            return functions;
        }
    }

    /// <summary>
    /// Represents a table in PostgreSQL
    /// </summary>
    public class TableMetadataModel
    {
        public string ClassName { get; set; }

        public List<ColumnMetadataModel> Columns { get; set; }

        public string PluralClassName { get; set; }

        public string PrimaryKeyColumnName { get; set; }

        public string TableName { get; set; }

        public string TableSchema { get; set; }

        public string PrimaryKeyPropertyName { get; set; }

        public bool IsView { get; set; }
    }

    /// <summary>
    /// Represents a column in PostgreSQL
    /// </summary>
    public class ColumnMetadataModel
    {
        public string ColumnComment { get; set; }

        public string ColumnName { get; set; }

        public string[] Comments { get; set; }

        public bool IsPrimaryKey { get; set; }

        public string PrimaryKeyConstraintName { get; set; }

        public string ForeignKeyConstraintName { get; set; }

        public string TableName { get; set; }

        public string TableSchema { get; set; }
        
        public string DbDataType { get; set; }

        public bool IsNullable { get; set; }
        
        public string PropertyName { get; set; }

        public string ForeignKeyReferenceTableName { get; set; }

        public string ForeignKeyReferenceColumnName { get; set; }

        public string ForeignKeyReferenceSchemaName { get; set; }

        public bool IsForeignKey { get; set; }

        public bool IsViewColumn { get; set; }

        public SimpleType PropertyType { get; set; }
    }

    public class FunctionMetadataModel
    {
        public string SchemaName { get; set; }

        public string FunctionName { get; set; }

        public string MethodName { get; set; }

        public string FunctionDefinition { get; set; }

        public string FunctionReturnTypeName { get; set; }
        
        public SimpleType FunctionReturnType { get; set; }

        public string FunctionComment { get; set; }
        
        public string FunctionArgumentsAsString { get; set; }

        public Dictionary<string, SimpleType> FunctionArguments
        {
            get
            {
                return this.FunctionArgumentsAsString.Split(',', StringSplitOptions.RemoveEmptyEntries).ToDictionary(
                    x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0].Trim(),
                    x => new SimpleType(string.Join(" ", x.Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1)), true));
            }
        }

        public string[] Comments { get; set; }
    }

    public class SimpleType
    {
        public SimpleType(string dbDataType, bool isNullable)
        {
            this.DbDataType = dbDataType;
            this.IsNullable = isNullable;
            this.ClrTypeName = CodeGeneratorHelper.GetClrType(dbDataType, isNullable);
            this.ClrNonNullableTypeName = this.ClrTypeName.Trim('?');
            this.ClrNullableTypeName = CodeGeneratorHelper.GetNullablePropertyType(dbDataType);
            this.Linq2DbDataTypeName = CodeGeneratorHelper.GetLinq2DbDataType(dbDataType);
            this.NpgsqlDbTypeName = CodeGeneratorHelper.GetNpgsqlDbType(dbDataType).ToString();
            
            this.IsClrValueType = this.ClrTypeName != "string";
            this.IsClrNullableType = this.ClrTypeName != "string" && isNullable;
            this.IsClrReferenceType = this.ClrTypeName == "string" || isNullable;
        }
        
        public string Linq2DbDataTypeName { get; set; }        

        public string ClrTypeName { get; set; }

        public string DbDataType { get; set; }

        public bool IsNullable { get; set; }

        public string NpgsqlDbTypeName { get; set; }

        public string ClrNonNullableTypeName { get; set; }

        public string ClrNullableTypeName { get; set; }

        public bool IsClrValueType { get; set; }

        public bool IsClrNullableType { get; set; }

        public bool IsClrReferenceType { get; set; }
    }
}