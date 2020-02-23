using CommandLine;

namespace PgNetGenerator
{
    public class CliOptions
    {
        private const string DefaultPocoClassName = "DbPocos";

        private const string DefaultMetadataClassName = "DbMetadata";

        private const string DefaultNamespace = "PgNet.Generated";

        [Option(shortName: 'm', longName: "metadataClassName",
            Required = false,
            Default = DefaultMetadataClassName,
            HelpText = "The name of the metadata class."
        )]
        public string MetadataClassName { get; set; }

        [Option(shortName:'n', longName: "namespace",
            Required = false,
            Default = DefaultNamespace,
            HelpText = "The namespace that is passed to the template."
        )]
        public string Namespace { get; set; }
       
        [Option(shortName: 'p', longName: "poco-class-name",
            Required = false,
            Default = DefaultPocoClassName,
            HelpText = "The name of the poco class."
        )]
        public string PocoClassName { get; set; }
        
        [Option('o', "output", HelpText = "The output file location.", Required = true)]
        public string Output { get; set; }

        [Option('t', "template-file", HelpText = "The razor template file location.", Required = false)]
        public string TemplateFile { get; set; }
        
        [Option('c', "connection-string", HelpText = "The PostgreSQL connection string.", Required = false)]
        public string ConnectionString { get; set; }

        [Option(shortName: 'r', longName: "get-relations-sql",
            Required = false,
            HelpText = "The sql that returns the db relations."
        )]
        public string GetRelationsSql { get; set; }

        [Option(shortName: 'f', longName: "get-functions-sql",
            Required = false,
            HelpText = "The sql that returns the db functions."
        )]
        public string GetFunctionsSql { get; set; }

        public static CliOptions ReadFromArgs(string[] args)
        {
            CliOptions cliArgs = default;

            Parser.Default.ParseArguments<CliOptions>(args)
                  .WithParsed(x => cliArgs = x);

            return cliArgs;
        }
    }
}