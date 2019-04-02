namespace PgNet.Generated
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LinqToDB;
    using LinqToDB.Mapping;

    using NpgsqlTypes;

    using PgNet;

    /// <summary>
    /// <para>Table name: 'test1'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    [Table(Schema="public", Name = "test1")]
    public class Test1Poco : IPoco<Test1Poco>
    {
        /// <summary>
        /// <para>Column name: 'test_bigint1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'bigint'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Bigint'.</para>
        /// <para>CLR type: 'long?'.</para>
        /// <para>linq2db data type: 'DataType.Int64'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_bigint1", DataType = DataType.Int64)]
        public long? TestBigint1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_bigint2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'bigint'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Bigint'.</para>
        /// <para>CLR type: 'long'.</para>
        /// <para>linq2db data type: 'DataType.Int64'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_bigint2", DataType = DataType.Int64)]
        public long TestBigint2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_boolean1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'boolean'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Boolean'.</para>
        /// <para>CLR type: 'bool'.</para>
        /// <para>linq2db data type: 'DataType.Boolean'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_boolean1", DataType = DataType.Boolean)]
        public bool TestBoolean1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_boolean2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'boolean'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Boolean'.</para>
        /// <para>CLR type: 'bool?'.</para>
        /// <para>linq2db data type: 'DataType.Boolean'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_boolean2", DataType = DataType.Boolean)]
        public bool? TestBoolean2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_char1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Char'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NChar'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_char1", DataType = DataType.NChar)]
        public string TestChar1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_char2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'character'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Char'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NChar'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_char2", DataType = DataType.NChar)]
        public string TestChar2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'date'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Date'.</para>
        /// <para>CLR type: 'DateTime'.</para>
        /// <para>linq2db data type: 'DataType.Date'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_date1", DataType = DataType.Date)]
        public DateTime TestDate1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'date'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Date'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.Date'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_date2", DataType = DataType.Date)]
        public DateTime? TestDate2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_decimal1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'numeric'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Numeric'.</para>
        /// <para>CLR type: 'decimal?'.</para>
        /// <para>linq2db data type: 'DataType.Decimal'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_decimal1", DataType = DataType.Decimal)]
        public decimal? TestDecimal1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_decimal2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'numeric'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Numeric'.</para>
        /// <para>CLR type: 'decimal'.</para>
        /// <para>linq2db data type: 'DataType.Decimal'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_decimal2", DataType = DataType.Decimal)]
        public decimal TestDecimal2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_double1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'double precision'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Double'.</para>
        /// <para>CLR type: 'double?'.</para>
        /// <para>linq2db data type: 'DataType.Double'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_double1", DataType = DataType.Double)]
        public double? TestDouble1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_double2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'double precision'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Double'.</para>
        /// <para>CLR type: 'double'.</para>
        /// <para>linq2db data type: 'DataType.Double'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_double2", DataType = DataType.Double)]
        public double TestDouble2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_id'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>Primary key of table: 'test1'.</para>
        /// <para>Primary key constraint name: 'test1_pkey'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [PrimaryKey, Identity]
        [Column(Name = "test_id", DataType = DataType.Int32)]
        public int TestID { get; set; }

        /// <summary>
        /// <para>Column name: 'test_integer1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_integer1", DataType = DataType.Int32)]
        public int? TestInteger1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_integer2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_integer2", DataType = DataType.Int32)]
        public int TestInteger2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'character varying'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Varchar'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NVarChar'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_name1", DataType = DataType.NVarChar)]
        public string TestName1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character varying'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Varchar'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NVarChar'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_name2", DataType = DataType.NVarChar)]
        public string TestName2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_real1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'real'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Real'.</para>
        /// <para>CLR type: 'float?'.</para>
        /// <para>linq2db data type: 'DataType.Single'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_real1", DataType = DataType.Single)]
        public float? TestReal1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_real2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'real'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Real'.</para>
        /// <para>CLR type: 'float'.</para>
        /// <para>linq2db data type: 'DataType.Single'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_real2", DataType = DataType.Single)]
        public float TestReal2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_text1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_text1", DataType = DataType.Text)]
        public string TestText1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_text2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_text2", DataType = DataType.Text)]
        public string TestText2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_timestamp1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_timestamp1", DataType = DataType.DateTime2)]
        public DateTime TestTimestamp1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_timestamp2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_timestamp2", DataType = DataType.DateTime2)]
        public DateTime? TestTimestamp2 { get; set; }

        public static TableMetadataModel<Test1Poco> Metadata => DbMetadata.Test1PocoMetadata;

        public Test1BM ToBm()
        {
            return new Test1BM
            {
                TestBigint1 = this.TestBigint1,
                TestBigint2 = this.TestBigint2,
                TestBoolean1 = this.TestBoolean1,
                TestBoolean2 = this.TestBoolean2,
                TestChar1 = this.TestChar1,
                TestChar2 = this.TestChar2,
                TestDate1 = this.TestDate1,
                TestDate2 = this.TestDate2,
                TestDecimal1 = this.TestDecimal1,
                TestDecimal2 = this.TestDecimal2,
                TestDouble1 = this.TestDouble1,
                TestDouble2 = this.TestDouble2,
                TestID = this.TestID,
                TestInteger1 = this.TestInteger1,
                TestInteger2 = this.TestInteger2,
                TestName1 = this.TestName1,
                TestName2 = this.TestName2,
                TestReal1 = this.TestReal1,
                TestReal2 = this.TestReal2,
                TestText1 = this.TestText1,
                TestText2 = this.TestText2,
                TestTimestamp1 = this.TestTimestamp1,
                TestTimestamp2 = this.TestTimestamp2,
            };
        }
    }

    /// <summary>
    /// <para>Table name: 'test2'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    [Table(Schema="public", Name = "test2")]
    public class Test2Poco : IPoco<Test2Poco>
    {
        /// <summary>
        /// <para>Column name: 'test_date'.</para>
        /// <para>Table name: 'test2'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_date", DataType = DataType.DateTime2)]
        public DateTime TestDate { get; set; }

        /// <summary>
        /// <para>Column name: 'test_id'.</para>
        /// <para>Table name: 'test2'.</para>
        /// <para>Primary key of table: 'test2'.</para>
        /// <para>Primary key constraint name: 'test2_pkey'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [PrimaryKey, Identity]
        [Column(Name = "test_id", DataType = DataType.Int32)]
        public int TestID { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name'.</para>
        /// <para>Table name: 'test2'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        [NotNull]
        [Column(Name = "test_name", DataType = DataType.Text)]
        public string TestName { get; set; }

        public static TableMetadataModel<Test2Poco> Metadata => DbMetadata.Test2PocoMetadata;

        public Test2BM ToBm()
        {
            return new Test2BM
            {
                TestDate = this.TestDate,
                TestID = this.TestID,
                TestName = this.TestName,
            };
        }
    }

    /// <summary>
    /// <para>Table name: 'v_generate_series'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    [Table(Schema="public", Name = "v_generate_series")]
    public class VGenerateSeriesPoco : IReadOnlyPoco<VGenerateSeriesPoco>
    {
        /// <summary>
        /// <para>Column name: 'num'.</para>
        /// <para>Table name: 'v_generate_series'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "num", DataType = DataType.Int32)]
        public int? Num { get; set; }

        public static TableMetadataModel<VGenerateSeriesPoco> Metadata => DbMetadata.VGenerateSeriesPocoMetadata;

    }

    /// <summary>
    /// <para>Table name: 'view1'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    [Table(Schema="public", Name = "view1")]
    public class View1Poco : IReadOnlyPoco<View1Poco>
    {
        /// <summary>
        /// <para>Column name: 'test1_test_id'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test1_test_id", DataType = DataType.Int32)]
        public int? Test1TestID { get; set; }

        /// <summary>
        /// <para>Column name: 'test2_test_id'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test2_test_id", DataType = DataType.Int32)]
        public int? Test2TestID { get; set; }

        /// <summary>
        /// <para>Column name: 'test_bigint1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'bigint'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Bigint'.</para>
        /// <para>CLR type: 'long?'.</para>
        /// <para>linq2db data type: 'DataType.Int64'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_bigint1", DataType = DataType.Int64)]
        public long? TestBigint1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_bigint2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'bigint'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Bigint'.</para>
        /// <para>CLR type: 'long?'.</para>
        /// <para>linq2db data type: 'DataType.Int64'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_bigint2", DataType = DataType.Int64)]
        public long? TestBigint2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_boolean1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'boolean'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Boolean'.</para>
        /// <para>CLR type: 'bool?'.</para>
        /// <para>linq2db data type: 'DataType.Boolean'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_boolean1", DataType = DataType.Boolean)]
        public bool? TestBoolean1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_boolean2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'boolean'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Boolean'.</para>
        /// <para>CLR type: 'bool?'.</para>
        /// <para>linq2db data type: 'DataType.Boolean'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_boolean2", DataType = DataType.Boolean)]
        public bool? TestBoolean2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_char1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Char'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NChar'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_char1", DataType = DataType.NChar)]
        public string TestChar1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_char2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Char'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NChar'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_char2", DataType = DataType.NChar)]
        public string TestChar2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_date", DataType = DataType.DateTime2)]
        public DateTime? TestDate { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'date'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Date'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.Date'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_date1", DataType = DataType.Date)]
        public DateTime? TestDate1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'date'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Date'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.Date'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_date2", DataType = DataType.Date)]
        public DateTime? TestDate2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_decimal1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'numeric'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Numeric'.</para>
        /// <para>CLR type: 'decimal?'.</para>
        /// <para>linq2db data type: 'DataType.Decimal'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_decimal1", DataType = DataType.Decimal)]
        public decimal? TestDecimal1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_decimal2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'numeric'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Numeric'.</para>
        /// <para>CLR type: 'decimal?'.</para>
        /// <para>linq2db data type: 'DataType.Decimal'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_decimal2", DataType = DataType.Decimal)]
        public decimal? TestDecimal2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_double1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'double precision'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Double'.</para>
        /// <para>CLR type: 'double?'.</para>
        /// <para>linq2db data type: 'DataType.Double'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_double1", DataType = DataType.Double)]
        public double? TestDouble1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_double2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'double precision'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Double'.</para>
        /// <para>CLR type: 'double?'.</para>
        /// <para>linq2db data type: 'DataType.Double'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_double2", DataType = DataType.Double)]
        public double? TestDouble2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_integer1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_integer1", DataType = DataType.Int32)]
        public int? TestInteger1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_integer2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_integer2", DataType = DataType.Int32)]
        public int? TestInteger2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_name", DataType = DataType.Text)]
        public string TestName { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character varying'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Varchar'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NVarChar'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_name1", DataType = DataType.NVarChar)]
        public string TestName1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character varying'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Varchar'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NVarChar'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_name2", DataType = DataType.NVarChar)]
        public string TestName2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_real1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'real'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Real'.</para>
        /// <para>CLR type: 'float?'.</para>
        /// <para>linq2db data type: 'DataType.Single'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_real1", DataType = DataType.Single)]
        public float? TestReal1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_real2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'real'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Real'.</para>
        /// <para>CLR type: 'float?'.</para>
        /// <para>linq2db data type: 'DataType.Single'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_real2", DataType = DataType.Single)]
        public float? TestReal2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_text1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_text1", DataType = DataType.Text)]
        public string TestText1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_text2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_text2", DataType = DataType.Text)]
        public string TestText2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_timestamp1'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_timestamp1", DataType = DataType.DateTime2)]
        public DateTime? TestTimestamp1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_timestamp2'.</para>
        /// <para>Table name: 'view1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        [Nullable]
        [Column(Name = "test_timestamp2", DataType = DataType.DateTime2)]
        public DateTime? TestTimestamp2 { get; set; }

        public static TableMetadataModel<View1Poco> Metadata => DbMetadata.View1PocoMetadata;

    }


    /// <summary>
    /// <para>Table name: 'test1'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    public class Test1FM : IFilterModel<Test1Poco>
    {
        [FilterOperator(QueryOperatorType.Equal, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public bool? TestBigint1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public bool? TestBigint1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long[] TestBigint1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long[] TestBigint1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long[] TestBigint2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long[] TestBigint2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool? TestBoolean1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool? TestBoolean1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool[] TestBoolean1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool[] TestBoolean1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool[] TestBoolean2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool[] TestBoolean2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public bool? TestChar1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public bool? TestChar1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string[] TestChar1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string[] TestChar1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string[] TestChar2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string[] TestChar2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime[] TestDate1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime[] TestDate1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public bool? TestDate2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public bool? TestDate2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime[] TestDate2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime[] TestDate2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public bool? TestDecimal1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public bool? TestDecimal1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal[] TestDecimal1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal[] TestDecimal1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal[] TestDecimal2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal[] TestDecimal2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public bool? TestDouble1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public bool? TestDouble1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double[] TestDouble1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double[] TestDouble1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double[] TestDouble2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double[] TestDouble2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int[] TestID_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int[] TestID_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public bool? TestInteger1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public bool? TestInteger1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int[] TestInteger1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int[] TestInteger1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int[] TestInteger2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int[] TestInteger2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string[] TestName1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string[] TestName1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public bool? TestName2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public bool? TestName2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string[] TestName2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string[] TestName2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public bool? TestReal1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public bool? TestReal1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float[] TestReal1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float[] TestReal1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float[] TestReal2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float[] TestReal2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public bool? TestText1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public bool? TestText1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string[] TestText1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string[] TestText1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string[] TestText2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string[] TestText2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime[] TestTimestamp1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime[] TestTimestamp1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public bool? TestTimestamp2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public bool? TestTimestamp2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime[] TestTimestamp2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime[] TestTimestamp2_IsNotIn { get; set; }

    }

    /// <summary>
    /// <para>Table name: 'test2'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    public class Test2FM : IFilterModel<Test2Poco>
    {
        [FilterOperator(QueryOperatorType.Equal, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime[] TestDate_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime[] TestDate_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int? TestID_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int[] TestID_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestID", NpgsqlDbType.Integer, "test_id")]
        public int[] TestID_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestName", NpgsqlDbType.Text, "test_name")]
        public string[] TestName_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestName", NpgsqlDbType.Text, "test_name")]
        public string[] TestName_IsNotIn { get; set; }

    }

    /// <summary>
    /// <para>Table name: 'v_generate_series'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    public class VGenerateSeriesFM : IFilterModel<VGenerateSeriesPoco>
    {
        [FilterOperator(QueryOperatorType.Equal, "Num", NpgsqlDbType.Integer, "num")]
        public int? Num { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "Num", NpgsqlDbType.Integer, "num")]
        public int? Num_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "Num", NpgsqlDbType.Integer, "num")]
        public int? Num_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "Num", NpgsqlDbType.Integer, "num")]
        public int? Num_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "Num", NpgsqlDbType.Integer, "num")]
        public int? Num_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "Num", NpgsqlDbType.Integer, "num")]
        public int? Num_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "Num", NpgsqlDbType.Integer, "num")]
        public bool? Num_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "Num", NpgsqlDbType.Integer, "num")]
        public bool? Num_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "Num", NpgsqlDbType.Integer, "num")]
        public int[] Num_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "Num", NpgsqlDbType.Integer, "num")]
        public int[] Num_IsNotIn { get; set; }

    }

    /// <summary>
    /// <para>Table name: 'view1'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    public class View1FM : IFilterModel<View1Poco>
    {
        [FilterOperator(QueryOperatorType.Equal, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int? Test1TestID { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int? Test1TestID_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int? Test1TestID_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int? Test1TestID_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int? Test1TestID_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int? Test1TestID_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public bool? Test1TestID_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public bool? Test1TestID_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int[] Test1TestID_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "Test1TestID", NpgsqlDbType.Integer, "test1_test_id")]
        public int[] Test1TestID_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int? Test2TestID { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int? Test2TestID_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int? Test2TestID_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int? Test2TestID_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int? Test2TestID_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int? Test2TestID_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public bool? Test2TestID_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public bool? Test2TestID_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int[] Test2TestID_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "Test2TestID", NpgsqlDbType.Integer, "test2_test_id")]
        public int[] Test2TestID_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long? TestBigint1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public bool? TestBigint1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public bool? TestBigint1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long[] TestBigint1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBigint1", NpgsqlDbType.Bigint, "test_bigint1")]
        public long[] TestBigint1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long? TestBigint2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public bool? TestBigint2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public bool? TestBigint2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long[] TestBigint2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBigint2", NpgsqlDbType.Bigint, "test_bigint2")]
        public long[] TestBigint2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool? TestBoolean1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool? TestBoolean1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool? TestBoolean1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool? TestBoolean1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool[] TestBoolean1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBoolean1", NpgsqlDbType.Boolean, "test_boolean1")]
        public bool[] TestBoolean1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool? TestBoolean2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool[] TestBoolean2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestBoolean2", NpgsqlDbType.Boolean, "test_boolean2")]
        public bool[] TestBoolean2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string TestChar1_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public bool? TestChar1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public bool? TestChar1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string[] TestChar1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestChar1", NpgsqlDbType.Char, "test_char1")]
        public string[] TestChar1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string TestChar2_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public bool? TestChar2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public bool? TestChar2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string[] TestChar2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestChar2", NpgsqlDbType.Char, "test_char2")]
        public string[] TestChar2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime? TestDate_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public bool? TestDate_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public bool? TestDate_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime[] TestDate_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDate", NpgsqlDbType.Timestamp, "test_date")]
        public DateTime[] TestDate_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime? TestDate1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public bool? TestDate1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public bool? TestDate1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime[] TestDate1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDate1", NpgsqlDbType.Date, "test_date1")]
        public DateTime[] TestDate1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime? TestDate2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public bool? TestDate2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public bool? TestDate2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime[] TestDate2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDate2", NpgsqlDbType.Date, "test_date2")]
        public DateTime[] TestDate2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal? TestDecimal1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public bool? TestDecimal1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public bool? TestDecimal1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal[] TestDecimal1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDecimal1", NpgsqlDbType.Numeric, "test_decimal1")]
        public decimal[] TestDecimal1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal? TestDecimal2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public bool? TestDecimal2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public bool? TestDecimal2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal[] TestDecimal2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDecimal2", NpgsqlDbType.Numeric, "test_decimal2")]
        public decimal[] TestDecimal2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double? TestDouble1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public bool? TestDouble1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public bool? TestDouble1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double[] TestDouble1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDouble1", NpgsqlDbType.Double, "test_double1")]
        public double[] TestDouble1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double? TestDouble2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public bool? TestDouble2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public bool? TestDouble2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double[] TestDouble2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestDouble2", NpgsqlDbType.Double, "test_double2")]
        public double[] TestDouble2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int? TestInteger1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public bool? TestInteger1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public bool? TestInteger1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int[] TestInteger1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestInteger1", NpgsqlDbType.Integer, "test_integer1")]
        public int[] TestInteger1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int? TestInteger2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public bool? TestInteger2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public bool? TestInteger2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int[] TestInteger2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestInteger2", NpgsqlDbType.Integer, "test_integer2")]
        public int[] TestInteger2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestName", NpgsqlDbType.Text, "test_name")]
        public string TestName_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestName", NpgsqlDbType.Text, "test_name")]
        public bool? TestName_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestName", NpgsqlDbType.Text, "test_name")]
        public bool? TestName_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestName", NpgsqlDbType.Text, "test_name")]
        public string[] TestName_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestName", NpgsqlDbType.Text, "test_name")]
        public string[] TestName_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string TestName1_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public bool? TestName1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public bool? TestName1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string[] TestName1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestName1", NpgsqlDbType.Varchar, "test_name1")]
        public string[] TestName1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string TestName2_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public bool? TestName2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public bool? TestName2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string[] TestName2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestName2", NpgsqlDbType.Varchar, "test_name2")]
        public string[] TestName2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float? TestReal1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public bool? TestReal1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public bool? TestReal1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float[] TestReal1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestReal1", NpgsqlDbType.Real, "test_real1")]
        public float[] TestReal1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float? TestReal2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public bool? TestReal2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public bool? TestReal2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float[] TestReal2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestReal2", NpgsqlDbType.Real, "test_real2")]
        public float[] TestReal2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string TestText1_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public bool? TestText1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public bool? TestText1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string[] TestText1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestText1", NpgsqlDbType.Text, "test_text1")]
        public string[] TestText1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.StartsWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_StartsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotStartWith { get; set; }

        [FilterOperator(QueryOperatorType.EndsWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_EndsWith { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWith, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotEndWith { get; set; }

        [FilterOperator(QueryOperatorType.Contains, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_Contains { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContain, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotContain { get; set; }

        [FilterOperator(QueryOperatorType.StartsWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_StartsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotStartWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotStartWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.EndsWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_EndsWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotEndWithCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotEndWithCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.ContainsCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_ContainsCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.DoesNotContainCaseSensitive, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string TestText2_DoesNotContainCaseSensitive { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public bool? TestText2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public bool? TestText2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string[] TestText2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestText2", NpgsqlDbType.Text, "test_text2")]
        public string[] TestText2_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime? TestTimestamp1_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public bool? TestTimestamp1_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public bool? TestTimestamp1_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime[] TestTimestamp1_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestTimestamp1", NpgsqlDbType.Timestamp, "test_timestamp1")]
        public DateTime[] TestTimestamp1_IsNotIn { get; set; }

        [FilterOperator(QueryOperatorType.Equal, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2 { get; set; }

        [FilterOperator(QueryOperatorType.NotEqual, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_NotEqual { get; set; }

        [FilterOperator(QueryOperatorType.LessThan, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_LessThan { get; set; }

        [FilterOperator(QueryOperatorType.LessThanOrEqual, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_LessThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThan, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_GreaterThan { get; set; }

        [FilterOperator(QueryOperatorType.GreaterThanOrEqual, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime? TestTimestamp2_GreaterThanOrEqual { get; set; }

        [FilterOperator(QueryOperatorType.IsNull, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public bool? TestTimestamp2_IsNull { get; set; }

        [FilterOperator(QueryOperatorType.IsNotNull, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public bool? TestTimestamp2_IsNotNull { get; set; }

        [FilterOperator(QueryOperatorType.IsIn, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime[] TestTimestamp2_IsIn { get; set; }

        [FilterOperator(QueryOperatorType.IsNotIn, "TestTimestamp2", NpgsqlDbType.Timestamp, "test_timestamp2")]
        public DateTime[] TestTimestamp2_IsNotIn { get; set; }

    }

    /// <summary>
    /// <para>Table name: 'test1'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    public partial class Test1BM : IBusinessModel<Test1Poco>
    {
        /// <summary>
        /// <para>Column name: 'test_bigint1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'bigint'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Bigint'.</para>
        /// <para>CLR type: 'long?'.</para>
        /// <para>linq2db data type: 'DataType.Int64'.</para>
        /// </summary>
        public long? TestBigint1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_bigint2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'bigint'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Bigint'.</para>
        /// <para>CLR type: 'long'.</para>
        /// <para>linq2db data type: 'DataType.Int64'.</para>
        /// </summary>
        public long TestBigint2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_boolean1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'boolean'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Boolean'.</para>
        /// <para>CLR type: 'bool'.</para>
        /// <para>linq2db data type: 'DataType.Boolean'.</para>
        /// </summary>
        public bool TestBoolean1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_boolean2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'boolean'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Boolean'.</para>
        /// <para>CLR type: 'bool?'.</para>
        /// <para>linq2db data type: 'DataType.Boolean'.</para>
        /// </summary>
        public bool? TestBoolean2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_char1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Char'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NChar'.</para>
        /// </summary>
        public string TestChar1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_char2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'character'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Char'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NChar'.</para>
        /// </summary>
        public string TestChar2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'date'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Date'.</para>
        /// <para>CLR type: 'DateTime'.</para>
        /// <para>linq2db data type: 'DataType.Date'.</para>
        /// </summary>
        public DateTime TestDate1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_date2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'date'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Date'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.Date'.</para>
        /// </summary>
        public DateTime? TestDate2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_decimal1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'numeric'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Numeric'.</para>
        /// <para>CLR type: 'decimal?'.</para>
        /// <para>linq2db data type: 'DataType.Decimal'.</para>
        /// </summary>
        public decimal? TestDecimal1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_decimal2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'numeric'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Numeric'.</para>
        /// <para>CLR type: 'decimal'.</para>
        /// <para>linq2db data type: 'DataType.Decimal'.</para>
        /// </summary>
        public decimal TestDecimal2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_double1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'double precision'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Double'.</para>
        /// <para>CLR type: 'double?'.</para>
        /// <para>linq2db data type: 'DataType.Double'.</para>
        /// </summary>
        public double? TestDouble1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_double2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'double precision'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Double'.</para>
        /// <para>CLR type: 'double'.</para>
        /// <para>linq2db data type: 'DataType.Double'.</para>
        /// </summary>
        public double TestDouble2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_id'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>Primary key of table: 'test1'.</para>
        /// <para>Primary key constraint name: 'test1_pkey'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        public int TestID { get; set; }

        /// <summary>
        /// <para>Column name: 'test_integer1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int?'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        public int? TestInteger1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_integer2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        public int TestInteger2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'character varying'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Varchar'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NVarChar'.</para>
        /// </summary>
        public string TestName1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'character varying'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Varchar'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.NVarChar'.</para>
        /// </summary>
        public string TestName2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_real1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'real'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Real'.</para>
        /// <para>CLR type: 'float?'.</para>
        /// <para>linq2db data type: 'DataType.Single'.</para>
        /// </summary>
        public float? TestReal1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_real2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'real'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Real'.</para>
        /// <para>CLR type: 'float'.</para>
        /// <para>linq2db data type: 'DataType.Single'.</para>
        /// </summary>
        public float TestReal2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_text1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        public string TestText1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_text2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        public string TestText2 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_timestamp1'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        public DateTime TestTimestamp1 { get; set; }

        /// <summary>
        /// <para>Column name: 'test_timestamp2'.</para>
        /// <para>Table name: 'test1'.</para>
        /// <para>This column is nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime?'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        public DateTime? TestTimestamp2 { get; set; }

        public Test1Poco ToPoco()
        {
            return new Test1Poco
            {
                TestBigint1 = this.TestBigint1,
                TestBigint2 = this.TestBigint2,
                TestBoolean1 = this.TestBoolean1,
                TestBoolean2 = this.TestBoolean2,
                TestChar1 = this.TestChar1,
                TestChar2 = this.TestChar2,
                TestDate1 = this.TestDate1,
                TestDate2 = this.TestDate2,
                TestDecimal1 = this.TestDecimal1,
                TestDecimal2 = this.TestDecimal2,
                TestDouble1 = this.TestDouble1,
                TestDouble2 = this.TestDouble2,
                TestID = this.TestID,
                TestInteger1 = this.TestInteger1,
                TestInteger2 = this.TestInteger2,
                TestName1 = this.TestName1,
                TestName2 = this.TestName2,
                TestReal1 = this.TestReal1,
                TestReal2 = this.TestReal2,
                TestText1 = this.TestText1,
                TestText2 = this.TestText2,
                TestTimestamp1 = this.TestTimestamp1,
                TestTimestamp2 = this.TestTimestamp2,
            };
        }
    }

    /// <summary>
    /// <para>Table name: 'test2'.</para>
    /// <para>Table schema: 'public'.</para>
    /// </summary>
    public partial class Test2BM : IBusinessModel<Test2Poco>
    {
        /// <summary>
        /// <para>Column name: 'test_date'.</para>
        /// <para>Table name: 'test2'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'timestamp without time zone'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Timestamp'.</para>
        /// <para>CLR type: 'DateTime'.</para>
        /// <para>linq2db data type: 'DataType.DateTime2'.</para>
        /// </summary>
        public DateTime TestDate { get; set; }

        /// <summary>
        /// <para>Column name: 'test_id'.</para>
        /// <para>Table name: 'test2'.</para>
        /// <para>Primary key of table: 'test2'.</para>
        /// <para>Primary key constraint name: 'test2_pkey'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'integer'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Integer'.</para>
        /// <para>CLR type: 'int'.</para>
        /// <para>linq2db data type: 'DataType.Int32'.</para>
        /// </summary>
        public int TestID { get; set; }

        /// <summary>
        /// <para>Column name: 'test_name'.</para>
        /// <para>Table name: 'test2'.</para>
        /// <para>This column is not nullable.</para>
        /// <para>PostgreSQL data type: 'text'.</para>
        /// <para>NpgsqlDbType: 'NpgsqlDbType.Text'.</para>
        /// <para>CLR type: 'string'.</para>
        /// <para>linq2db data type: 'DataType.Text'.</para>
        /// </summary>
        public string TestName { get; set; }

        public Test2Poco ToPoco()
        {
            return new Test2Poco
            {
                TestDate = this.TestDate,
                TestID = this.TestID,
                TestName = this.TestName,
            };
        }
    }

    public class DbPocos : IDbPocos<DbPocos>
    {
        /// <summary>
        /// <para>Database table 'test1'.</para>
        /// </summary>
        public IQueryable<Test1Poco> Test1 => this.LinqProvider.GetTable<Test1Poco>();

        /// <summary>
        /// <para>Database table 'test2'.</para>
        /// </summary>
        public IQueryable<Test2Poco> Test2 => this.LinqProvider.GetTable<Test2Poco>();

        /// <summary>
        /// <para>Database table 'v_generate_series'.</para>
        /// </summary>
        public IQueryable<VGenerateSeriesPoco> VGenerateSeries => this.LinqProvider.GetTable<VGenerateSeriesPoco>();

        /// <summary>
        /// <para>Database table 'view1'.</para>
        /// </summary>
        public IQueryable<View1Poco> View1 => this.LinqProvider.GetTable<View1Poco>();


        /// <summary>
        /// <para>Database function 'increment_by_one'.</para>
        /// </summary>
        [Sql.Function(ServerSideOnly = true, Name = "increment_by_one")]
        public static int? IncrementByOne(int? num) => throw new NotImplementedException();        

        public ILinqProvider LinqProvider { private get; set; }
    }

    public class DbMetadata : IDbMetadata
    {
        internal static TableMetadataModel<Test1Poco> Test1PocoMetadata;

        internal static TableMetadataModel<Test2Poco> Test2PocoMetadata;

        internal static TableMetadataModel<VGenerateSeriesPoco> VGenerateSeriesPocoMetadata;

        internal static TableMetadataModel<View1Poco> View1PocoMetadata;

        internal static readonly List<FunctionMetadataModel> Functions = new List<FunctionMetadataModel>(); 
            
        private static readonly object InitLock = new object();

        private static bool Initialized;

        // ReSharper disable once FunctionComplexityOverflow
        // ReSharper disable once CyclomaticComplexity
        private static void InitializeInternal()
        {
            Test1PocoMetadata = new TableMetadataModel<Test1Poco>
            {
                ClassName = "Test1",
                PluralClassName = "Test1",
                TableName = "test1",
                TableSchema = "public",
                PrimaryKeyColumnName = "test_id",
                PrimaryKeyPropertyName = "TestID",
                GetPrimaryKey = (instance) => instance.TestID,
                SetPrimaryKey = (instance, val) => instance.TestID = val,
                IsNew = (instance) => instance.TestID == default,
                Columns = new List<ColumnMetadataModel>
                {
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_bigint1",
                        DbDataType = "bigint",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBigint1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "long?",
                            ClrType = typeof(long?),
                            ClrNonNullableTypeName = "long",
                            ClrNonNullableType = typeof(long),
                            ClrNullableTypeName = "long?",
                            ClrNullableType = typeof(long?),
                            DbDataType = "bigint",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int64",
                            Linq2DbDataType = DataType.Int64,
                            NpgsqlDbTypeName = "NpgsqlDbType.Bigint",
                            NpgsqlDbType = NpgsqlDbType.Bigint,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_bigint2",
                        DbDataType = "bigint",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBigint2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "long",
                            ClrType = typeof(long),
                            ClrNonNullableTypeName = "long",
                            ClrNonNullableType = typeof(long),
                            ClrNullableTypeName = "long?",
                            ClrNullableType = typeof(long?),
                            DbDataType = "bigint",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Int64",
                            Linq2DbDataType = DataType.Int64,
                            NpgsqlDbTypeName = "NpgsqlDbType.Bigint",
                            NpgsqlDbType = NpgsqlDbType.Bigint,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_boolean1",
                        DbDataType = "boolean",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBoolean1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "bool",
                            ClrType = typeof(bool),
                            ClrNonNullableTypeName = "bool",
                            ClrNonNullableType = typeof(bool),
                            ClrNullableTypeName = "bool?",
                            ClrNullableType = typeof(bool?),
                            DbDataType = "boolean",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Boolean",
                            Linq2DbDataType = DataType.Boolean,
                            NpgsqlDbTypeName = "NpgsqlDbType.Boolean",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_boolean2",
                        DbDataType = "boolean",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBoolean2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "bool?",
                            ClrType = typeof(bool?),
                            ClrNonNullableTypeName = "bool",
                            ClrNonNullableType = typeof(bool),
                            ClrNullableTypeName = "bool?",
                            ClrNullableType = typeof(bool?),
                            DbDataType = "boolean",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Boolean",
                            Linq2DbDataType = DataType.Boolean,
                            NpgsqlDbTypeName = "NpgsqlDbType.Boolean",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_char1",
                        DbDataType = "character",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestChar1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NChar",
                            Linq2DbDataType = DataType.NChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Char",
                            NpgsqlDbType = NpgsqlDbType.Char,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_char2",
                        DbDataType = "character",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestChar2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NChar",
                            Linq2DbDataType = DataType.NChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Char",
                            NpgsqlDbType = NpgsqlDbType.Char,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_date1",
                        DbDataType = "date",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDate1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime",
                            ClrType = typeof(DateTime),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "date",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Date",
                            Linq2DbDataType = DataType.Date,
                            NpgsqlDbTypeName = "NpgsqlDbType.Date",
                            NpgsqlDbType = NpgsqlDbType.Date,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_date2",
                        DbDataType = "date",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDate2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "date",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Date",
                            Linq2DbDataType = DataType.Date,
                            NpgsqlDbTypeName = "NpgsqlDbType.Date",
                            NpgsqlDbType = NpgsqlDbType.Date,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_decimal1",
                        DbDataType = "numeric",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDecimal1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "decimal?",
                            ClrType = typeof(decimal?),
                            ClrNonNullableTypeName = "decimal",
                            ClrNonNullableType = typeof(decimal),
                            ClrNullableTypeName = "decimal?",
                            ClrNullableType = typeof(decimal?),
                            DbDataType = "numeric",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Decimal",
                            Linq2DbDataType = DataType.Decimal,
                            NpgsqlDbTypeName = "NpgsqlDbType.Numeric",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_decimal2",
                        DbDataType = "numeric",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDecimal2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "decimal",
                            ClrType = typeof(decimal),
                            ClrNonNullableTypeName = "decimal",
                            ClrNonNullableType = typeof(decimal),
                            ClrNullableTypeName = "decimal?",
                            ClrNullableType = typeof(decimal?),
                            DbDataType = "numeric",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Decimal",
                            Linq2DbDataType = DataType.Decimal,
                            NpgsqlDbTypeName = "NpgsqlDbType.Numeric",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_double1",
                        DbDataType = "double precision",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDouble1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "double?",
                            ClrType = typeof(double?),
                            ClrNonNullableTypeName = "double",
                            ClrNonNullableType = typeof(double),
                            ClrNullableTypeName = "double?",
                            ClrNullableType = typeof(double?),
                            DbDataType = "double precision",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Double",
                            Linq2DbDataType = DataType.Double,
                            NpgsqlDbTypeName = "NpgsqlDbType.Double",
                            NpgsqlDbType = NpgsqlDbType.Double,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_double2",
                        DbDataType = "double precision",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDouble2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "double",
                            ClrType = typeof(double),
                            ClrNonNullableTypeName = "double",
                            ClrNonNullableType = typeof(double),
                            ClrNullableTypeName = "double?",
                            ClrNullableType = typeof(double?),
                            DbDataType = "double precision",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Double",
                            Linq2DbDataType = DataType.Double,
                            NpgsqlDbTypeName = "NpgsqlDbType.Double",
                            NpgsqlDbType = NpgsqlDbType.Double,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_id",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("True"),
                        PrimaryKeyConstraintName = "test1_pkey" == string.Empty ? null : "test1_pkey",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestID",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int",
                            ClrType = typeof(int),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_integer1",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestInteger1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int?",
                            ClrType = typeof(int?),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_integer2",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestInteger2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int",
                            ClrType = typeof(int),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_name1",
                        DbDataType = "character varying",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestName1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character varying",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NVarChar",
                            Linq2DbDataType = DataType.NVarChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Varchar",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_name2",
                        DbDataType = "character varying",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestName2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character varying",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NVarChar",
                            Linq2DbDataType = DataType.NVarChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Varchar",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_real1",
                        DbDataType = "real",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestReal1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "float?",
                            ClrType = typeof(float?),
                            ClrNonNullableTypeName = "float",
                            ClrNonNullableType = typeof(float),
                            ClrNullableTypeName = "float?",
                            ClrNullableType = typeof(float?),
                            DbDataType = "real",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Single",
                            Linq2DbDataType = DataType.Single,
                            NpgsqlDbTypeName = "NpgsqlDbType.Real",
                            NpgsqlDbType = NpgsqlDbType.Real,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_real2",
                        DbDataType = "real",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestReal2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "float",
                            ClrType = typeof(float),
                            ClrNonNullableTypeName = "float",
                            ClrNonNullableType = typeof(float),
                            ClrNullableTypeName = "float?",
                            ClrNullableType = typeof(float?),
                            DbDataType = "real",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Single",
                            Linq2DbDataType = DataType.Single,
                            NpgsqlDbTypeName = "NpgsqlDbType.Real",
                            NpgsqlDbType = NpgsqlDbType.Real,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_text1",
                        DbDataType = "text",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestText1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "text",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Text",
                            Linq2DbDataType = DataType.Text,
                            NpgsqlDbTypeName = "NpgsqlDbType.Text",
                            NpgsqlDbType = NpgsqlDbType.Text,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_text2",
                        DbDataType = "text",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestText2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "text",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Text",
                            Linq2DbDataType = DataType.Text,
                            NpgsqlDbTypeName = "NpgsqlDbType.Text",
                            NpgsqlDbType = NpgsqlDbType.Text,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_timestamp1",
                        DbDataType = "timestamp without time zone",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestTimestamp1",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime",
                            ClrType = typeof(DateTime),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "timestamp without time zone",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.DateTime2",
                            Linq2DbDataType = DataType.DateTime2,
                            NpgsqlDbTypeName = "NpgsqlDbType.Timestamp",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_timestamp2",
                        DbDataType = "timestamp without time zone",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestTimestamp2",
                        TableName = "test1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "timestamp without time zone",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.DateTime2",
                            Linq2DbDataType = DataType.DateTime2,
                            NpgsqlDbTypeName = "NpgsqlDbType.Timestamp",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                        }
                    },
                }
            };

            Test1PocoMetadata.Clone = DbCodeGenerator.GetClone<Test1Poco>();
            Test1PocoMetadata.GenerateParameters = DbCodeGenerator.GetGenerateParameters(Test1PocoMetadata);
            Test1PocoMetadata.WriteToImporter = DbCodeGenerator.GetWriteToImporter(Test1PocoMetadata);
            Test1PocoMetadata.GetColumnChanges = DbCodeGenerator.GetGetColumnChanges(Test1PocoMetadata);
            Test1PocoMetadata.GetAllColumns = DbCodeGenerator.GetGetAllColumns(Test1PocoMetadata);
            Test1PocoMetadata.ParseFm = DbCodeGenerator.GetParseFm(Test1PocoMetadata, typeof(Test1FM));

            Test2PocoMetadata = new TableMetadataModel<Test2Poco>
            {
                ClassName = "Test2",
                PluralClassName = "Test2",
                TableName = "test2",
                TableSchema = "public",
                PrimaryKeyColumnName = "test_id",
                PrimaryKeyPropertyName = "TestID",
                GetPrimaryKey = (instance) => instance.TestID,
                SetPrimaryKey = (instance, val) => instance.TestID = val,
                IsNew = (instance) => instance.TestID == default,
                Columns = new List<ColumnMetadataModel>
                {
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_date",
                        DbDataType = "timestamp without time zone",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDate",
                        TableName = "test2",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime",
                            ClrType = typeof(DateTime),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "timestamp without time zone",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.DateTime2",
                            Linq2DbDataType = DataType.DateTime2,
                            NpgsqlDbTypeName = "NpgsqlDbType.Timestamp",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_id",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("True"),
                        PrimaryKeyConstraintName = "test2_pkey" == string.Empty ? null : "test2_pkey",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestID",
                        TableName = "test2",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int",
                            ClrType = typeof(int),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("False"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_name",
                        DbDataType = "text",
                        IsNullable = bool.Parse("False"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestName",
                        TableName = "test2",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "text",
                            IsNullable = bool.Parse("False"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Text",
                            Linq2DbDataType = DataType.Text,
                            NpgsqlDbTypeName = "NpgsqlDbType.Text",
                            NpgsqlDbType = NpgsqlDbType.Text,
                        }
                    },
                }
            };

            Test2PocoMetadata.Clone = DbCodeGenerator.GetClone<Test2Poco>();
            Test2PocoMetadata.GenerateParameters = DbCodeGenerator.GetGenerateParameters(Test2PocoMetadata);
            Test2PocoMetadata.WriteToImporter = DbCodeGenerator.GetWriteToImporter(Test2PocoMetadata);
            Test2PocoMetadata.GetColumnChanges = DbCodeGenerator.GetGetColumnChanges(Test2PocoMetadata);
            Test2PocoMetadata.GetAllColumns = DbCodeGenerator.GetGetAllColumns(Test2PocoMetadata);
            Test2PocoMetadata.ParseFm = DbCodeGenerator.GetParseFm(Test2PocoMetadata, typeof(Test2FM));

            VGenerateSeriesPocoMetadata = new TableMetadataModel<VGenerateSeriesPoco>
            {
                ClassName = "VGenerateSeries",
                PluralClassName = "VGenerateSeries",
                TableName = "v_generate_series",
                TableSchema = "public",
                Columns = new List<ColumnMetadataModel>
                {
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "num",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "Num",
                        TableName = "v_generate_series",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int?",
                            ClrType = typeof(int?),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                }
            };

            VGenerateSeriesPocoMetadata.Clone = DbCodeGenerator.GetClone<VGenerateSeriesPoco>();
            VGenerateSeriesPocoMetadata.ParseFm = DbCodeGenerator.GetParseFm(VGenerateSeriesPocoMetadata, typeof(VGenerateSeriesFM));

            View1PocoMetadata = new TableMetadataModel<View1Poco>
            {
                ClassName = "View1",
                PluralClassName = "View1",
                TableName = "view1",
                TableSchema = "public",
                Columns = new List<ColumnMetadataModel>
                {
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test1_test_id",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "Test1TestID",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int?",
                            ClrType = typeof(int?),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test2_test_id",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "Test2TestID",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int?",
                            ClrType = typeof(int?),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_bigint1",
                        DbDataType = "bigint",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBigint1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "long?",
                            ClrType = typeof(long?),
                            ClrNonNullableTypeName = "long",
                            ClrNonNullableType = typeof(long),
                            ClrNullableTypeName = "long?",
                            ClrNullableType = typeof(long?),
                            DbDataType = "bigint",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int64",
                            Linq2DbDataType = DataType.Int64,
                            NpgsqlDbTypeName = "NpgsqlDbType.Bigint",
                            NpgsqlDbType = NpgsqlDbType.Bigint,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_bigint2",
                        DbDataType = "bigint",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBigint2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "long?",
                            ClrType = typeof(long?),
                            ClrNonNullableTypeName = "long",
                            ClrNonNullableType = typeof(long),
                            ClrNullableTypeName = "long?",
                            ClrNullableType = typeof(long?),
                            DbDataType = "bigint",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int64",
                            Linq2DbDataType = DataType.Int64,
                            NpgsqlDbTypeName = "NpgsqlDbType.Bigint",
                            NpgsqlDbType = NpgsqlDbType.Bigint,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_boolean1",
                        DbDataType = "boolean",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBoolean1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "bool?",
                            ClrType = typeof(bool?),
                            ClrNonNullableTypeName = "bool",
                            ClrNonNullableType = typeof(bool),
                            ClrNullableTypeName = "bool?",
                            ClrNullableType = typeof(bool?),
                            DbDataType = "boolean",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Boolean",
                            Linq2DbDataType = DataType.Boolean,
                            NpgsqlDbTypeName = "NpgsqlDbType.Boolean",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_boolean2",
                        DbDataType = "boolean",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestBoolean2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "bool?",
                            ClrType = typeof(bool?),
                            ClrNonNullableTypeName = "bool",
                            ClrNonNullableType = typeof(bool),
                            ClrNullableTypeName = "bool?",
                            ClrNullableType = typeof(bool?),
                            DbDataType = "boolean",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Boolean",
                            Linq2DbDataType = DataType.Boolean,
                            NpgsqlDbTypeName = "NpgsqlDbType.Boolean",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_char1",
                        DbDataType = "character",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestChar1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NChar",
                            Linq2DbDataType = DataType.NChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Char",
                            NpgsqlDbType = NpgsqlDbType.Char,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_char2",
                        DbDataType = "character",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestChar2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NChar",
                            Linq2DbDataType = DataType.NChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Char",
                            NpgsqlDbType = NpgsqlDbType.Char,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_date",
                        DbDataType = "timestamp without time zone",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDate",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "timestamp without time zone",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.DateTime2",
                            Linq2DbDataType = DataType.DateTime2,
                            NpgsqlDbTypeName = "NpgsqlDbType.Timestamp",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_date1",
                        DbDataType = "date",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDate1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "date",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Date",
                            Linq2DbDataType = DataType.Date,
                            NpgsqlDbTypeName = "NpgsqlDbType.Date",
                            NpgsqlDbType = NpgsqlDbType.Date,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_date2",
                        DbDataType = "date",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDate2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "date",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Date",
                            Linq2DbDataType = DataType.Date,
                            NpgsqlDbTypeName = "NpgsqlDbType.Date",
                            NpgsqlDbType = NpgsqlDbType.Date,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_decimal1",
                        DbDataType = "numeric",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDecimal1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "decimal?",
                            ClrType = typeof(decimal?),
                            ClrNonNullableTypeName = "decimal",
                            ClrNonNullableType = typeof(decimal),
                            ClrNullableTypeName = "decimal?",
                            ClrNullableType = typeof(decimal?),
                            DbDataType = "numeric",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Decimal",
                            Linq2DbDataType = DataType.Decimal,
                            NpgsqlDbTypeName = "NpgsqlDbType.Numeric",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_decimal2",
                        DbDataType = "numeric",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDecimal2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "decimal?",
                            ClrType = typeof(decimal?),
                            ClrNonNullableTypeName = "decimal",
                            ClrNonNullableType = typeof(decimal),
                            ClrNullableTypeName = "decimal?",
                            ClrNullableType = typeof(decimal?),
                            DbDataType = "numeric",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Decimal",
                            Linq2DbDataType = DataType.Decimal,
                            NpgsqlDbTypeName = "NpgsqlDbType.Numeric",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_double1",
                        DbDataType = "double precision",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDouble1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "double?",
                            ClrType = typeof(double?),
                            ClrNonNullableTypeName = "double",
                            ClrNonNullableType = typeof(double),
                            ClrNullableTypeName = "double?",
                            ClrNullableType = typeof(double?),
                            DbDataType = "double precision",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Double",
                            Linq2DbDataType = DataType.Double,
                            NpgsqlDbTypeName = "NpgsqlDbType.Double",
                            NpgsqlDbType = NpgsqlDbType.Double,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_double2",
                        DbDataType = "double precision",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestDouble2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "double?",
                            ClrType = typeof(double?),
                            ClrNonNullableTypeName = "double",
                            ClrNonNullableType = typeof(double),
                            ClrNullableTypeName = "double?",
                            ClrNullableType = typeof(double?),
                            DbDataType = "double precision",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Double",
                            Linq2DbDataType = DataType.Double,
                            NpgsqlDbTypeName = "NpgsqlDbType.Double",
                            NpgsqlDbType = NpgsqlDbType.Double,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_integer1",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestInteger1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int?",
                            ClrType = typeof(int?),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_integer2",
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestInteger2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "int?",
                            ClrType = typeof(int?),
                            ClrNonNullableTypeName = "int",
                            ClrNonNullableType = typeof(int),
                            ClrNullableTypeName = "int?",
                            ClrNullableType = typeof(int?),
                            DbDataType = "integer",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Int32",
                            Linq2DbDataType = DataType.Int32,
                            NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_name",
                        DbDataType = "text",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestName",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "text",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Text",
                            Linq2DbDataType = DataType.Text,
                            NpgsqlDbTypeName = "NpgsqlDbType.Text",
                            NpgsqlDbType = NpgsqlDbType.Text,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_name1",
                        DbDataType = "character varying",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestName1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character varying",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NVarChar",
                            Linq2DbDataType = DataType.NVarChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Varchar",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_name2",
                        DbDataType = "character varying",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestName2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "character varying",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.NVarChar",
                            Linq2DbDataType = DataType.NVarChar,
                            NpgsqlDbTypeName = "NpgsqlDbType.Varchar",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_real1",
                        DbDataType = "real",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestReal1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "float?",
                            ClrType = typeof(float?),
                            ClrNonNullableTypeName = "float",
                            ClrNonNullableType = typeof(float),
                            ClrNullableTypeName = "float?",
                            ClrNullableType = typeof(float?),
                            DbDataType = "real",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Single",
                            Linq2DbDataType = DataType.Single,
                            NpgsqlDbTypeName = "NpgsqlDbType.Real",
                            NpgsqlDbType = NpgsqlDbType.Real,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_real2",
                        DbDataType = "real",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestReal2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "float?",
                            ClrType = typeof(float?),
                            ClrNonNullableTypeName = "float",
                            ClrNonNullableType = typeof(float),
                            ClrNullableTypeName = "float?",
                            ClrNullableType = typeof(float?),
                            DbDataType = "real",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Single",
                            Linq2DbDataType = DataType.Single,
                            NpgsqlDbTypeName = "NpgsqlDbType.Real",
                            NpgsqlDbType = NpgsqlDbType.Real,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_text1",
                        DbDataType = "text",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestText1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "text",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Text",
                            Linq2DbDataType = DataType.Text,
                            NpgsqlDbTypeName = "NpgsqlDbType.Text",
                            NpgsqlDbType = NpgsqlDbType.Text,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_text2",
                        DbDataType = "text",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestText2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "string",
                            ClrType = typeof(string),
                            ClrNonNullableTypeName = "string",
                            ClrNonNullableType = typeof(string),
                            ClrNullableTypeName = "string",
                            ClrNullableType = typeof(string),
                            DbDataType = "text",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("False"),
                            IsClrNullableType = bool.Parse("False"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.Text",
                            Linq2DbDataType = DataType.Text,
                            NpgsqlDbTypeName = "NpgsqlDbType.Text",
                            NpgsqlDbType = NpgsqlDbType.Text,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_timestamp1",
                        DbDataType = "timestamp without time zone",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestTimestamp1",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "timestamp without time zone",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.DateTime2",
                            Linq2DbDataType = DataType.DateTime2,
                            NpgsqlDbTypeName = "NpgsqlDbType.Timestamp",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                        }
                    },
                    new ColumnMetadataModel
                    {
                        ColumnComment = "" == string.Empty ? null : "",
                        Comments = "".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries),
                        ColumnName = "test_timestamp2",
                        DbDataType = "timestamp without time zone",
                        IsNullable = bool.Parse("True"),
                        IsPrimaryKey = bool.Parse("False"),
                        PrimaryKeyConstraintName = "" == string.Empty ? null : "",
                        IsForeignKey = bool.Parse("False"),
                        ForeignKeyConstraintName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceColumnName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceSchemaName = "" == string.Empty ? null : "",
                        ForeignKeyReferenceTableName = "" == string.Empty ? null : "",
                        PropertyName = "TestTimestamp2",
                        TableName = "view1",
                        TableSchema = "public",
                        PropertyType = new SimpleType
                        {
                            ClrTypeName = "DateTime?",
                            ClrType = typeof(DateTime?),
                            ClrNonNullableTypeName = "DateTime",
                            ClrNonNullableType = typeof(DateTime),
                            ClrNullableTypeName = "DateTime?",
                            ClrNullableType = typeof(DateTime?),
                            DbDataType = "timestamp without time zone",
                            IsNullable = bool.Parse("True"),
                            IsClrValueType = bool.Parse("True"),
                            IsClrNullableType = bool.Parse("True"),
                            IsClrReferenceType = bool.Parse("True"),
                            Linq2DbDataTypeName = "DataType.DateTime2",
                            Linq2DbDataType = DataType.DateTime2,
                            NpgsqlDbTypeName = "NpgsqlDbType.Timestamp",
                            NpgsqlDbType = NpgsqlDbType.Timestamp,
                        }
                    },
                }
            };

            View1PocoMetadata.Clone = DbCodeGenerator.GetClone<View1Poco>();
            View1PocoMetadata.ParseFm = DbCodeGenerator.GetParseFm(View1PocoMetadata, typeof(View1FM));


            Functions.Add(new FunctionMetadataModel
            {
                SchemaName = "public" == string.Empty ? null : "public",
                FunctionName = "increment_by_one" == string.Empty ? null : "increment_by_one",
                MethodName = "IncrementByOne" == string.Empty ? null : "IncrementByOne",
                FunctionReturnTypeName = "int4" == string.Empty ? null : "int4",
                FunctionComment = "" == string.Empty ? null : "",
                FunctionArgumentsAsString = "num integer" == string.Empty ? null : "num integer",
                FunctionReturnType = new SimpleType
                {
                    ClrTypeName = "int?",
                    ClrType = typeof(int?),
                    ClrNonNullableTypeName = "int",
                    ClrNonNullableType = typeof(int),
                    ClrNullableTypeName = "int?",
                    ClrNullableType = typeof(int?),
                    DbDataType = "int4",
                    IsNullable = bool.Parse("True"),
                    IsClrValueType = bool.Parse("True"),
                    IsClrNullableType = bool.Parse("True"),
                    IsClrReferenceType = bool.Parse("True"),
                    Linq2DbDataTypeName = "DataType.Int32",
                    Linq2DbDataType = DataType.Int32,
                    NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                    NpgsqlDbType = NpgsqlDbType.Integer,
                },
                FunctionArguments = new Dictionary<string, SimpleType>
                {
                    { "num", new SimpleType 
                    {
                        ClrTypeName = "int?",
                        ClrType = typeof(int?),
                        ClrNonNullableTypeName = "int",
                        ClrNonNullableType = typeof(int),
                        ClrNullableTypeName = "int?",
                        ClrNullableType = typeof(int?),
                        DbDataType = "integer",
                        IsNullable = bool.Parse("True"),
                        IsClrValueType = bool.Parse("True"),
                        IsClrNullableType = bool.Parse("True"),
                        IsClrReferenceType = bool.Parse("True"),
                        Linq2DbDataTypeName = "DataType.Int32",
                        Linq2DbDataType = DataType.Int32,
                        NpgsqlDbTypeName = "NpgsqlDbType.Integer",
                        NpgsqlDbType = NpgsqlDbType.Integer,
                    }},
                },
            });
        }

        public static void Initialize()
        {
            if(Initialized)
            {
                return;
            }

            lock(InitLock)
            {
                if(Initialized)
                {
                    return;
                }

                InitializeInternal();

                Initialized = true;
            }
        }

        static DbMetadata()
        {
            Initialize();
        }
    }
}
