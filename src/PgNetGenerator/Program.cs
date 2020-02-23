using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using RenderRazor;

namespace PgNetGenerator
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var options = CliOptions.ReadFromArgs(args);

            if (options == null)
            {
                return 1;
            }

            string getRelationsSql = options.GetRelationsSql ??
                                     await ResourceHelper.GetString("get-relations.sql");
            
            string getFunctionsSql = options.GetFunctionsSql ??
                                     await ResourceHelper.GetString("get-functions.sql");

            using (var connection = new NpgsqlConnection(options.ConnectionString))
            {
                var schemaRepository = new DbSchemaRepository(connection);

                var tables = await schemaRepository.GetTables(getRelationsSql);

                var functions = await schemaRepository.GetFunctions(getFunctionsSql);

                var context = new PocoTemplateContext
                {
                    Tables = tables,
                    Functions = functions,
                    Namespace = options.Namespace,
                    PocoClassName = options.PocoClassName,
                    MetadataClassName = options.MetadataClassName,
                };

                string templateString = options.TemplateFile != null ?
                    await File.ReadAllTextAsync(options.TemplateFile) :
                    await ResourceHelper.GetString("relations-template.txt");

                var render = new RazorRenderer<PocoTemplateContext>(templateString, new []
                {
                    typeof(Enumerable).Assembly
                });
                
                render.Compile();

                string contents = await render.Render(context);

                if (options.Output == "-")
                {
                    Console.Out.Write(contents);
                }
                else
                {
                    await File.WriteAllTextAsync(options.Output, contents);
                }
            }

            return 0;
        }
    }

    public class PocoTemplateContext
    {
        public List<TableMetadataModel> Tables { get; set; }

        public string Namespace { get; set; }

        public string PocoClassName { get; set; }

        public string MetadataClassName { get; set; }

        public List<FunctionMetadataModel> Functions { get; set; }
    }
}