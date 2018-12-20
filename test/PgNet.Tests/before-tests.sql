
drop schema "public" cascade;

create schema "public";

create table "public"."test1" (
	test_id serial,
	test_name1 varchar(255) not null,
	test_name2 varchar(255),
	test_date1 date not null,
	test_date2 date,
	test_timestamp1 timestamp not null,
	test_timestamp2 timestamp,
	test_boolean1 boolean not null,
	test_boolean2 boolean,
  test_integer1 integer,
  test_integer2 integer not NULL,
  test_bigint1 bigint,
  test_bigint2 bigint not NULL,
  test_text1 text,
  test_text2 text not NULL,
  test_real1 real,
  test_real2 real not NULL,
  test_double1 double precision,
  test_double2 double precision NOT NULL,
  test_char1 char,
  test_char2 char NOT NULL,

	primary key (test_id)
);

CREATE TABLE "public"."test2" (
  test_id serial,
  test_name text NOT NULL,
  test_date timestamp NOT NULL,
  PRIMARY KEY (test_id)
);

DROP view if exists "public"."view1";

create or REPLACE view "public"."view1" as select
   test_name1,
   test_name2,
   test_date1,
   test_date2,
   test_timestamp1,
   test_timestamp2,
   test_boolean1,
   test_boolean2,
   test_integer1,
   test_integer2,
   test_bigint1,
   test_bigint2,
   test_text1,
   test_text2,
   test_real1,
   test_real2,
   test_double1,
   test_double2,
   test_char1,
   test_char2,
   test_name,
   test_date
from test1 JOIN test2 on test1.test_id = test2.test_id;

drop view if exists "public"."db_columns";

create view "public"."db_columns" as
  ((SELECT
      t.tablename as TableName,
      n.nspname AS TableSchema,
      a.attname as ColumnName,
      pg_catalog.format_type(a.atttypid, NULL) AS DbDataType,
      pg_catalog.col_description(a.attrelid, a.attnum) AS ColumnComment,
      (a.attnotnull = FALSE) AS IsNullable,
      p.conname AS PrimaryKeyConstraintName,
      f.conname AS ForeignKeyConstraintName,
      fc.relname as ForeignKeyReferenceTableName,
      CASE WHEN pg_catalog.pg_get_constraintdef(f.oid) LIKE 'FOREIGN KEY %'
              THEN substring(pg_catalog.pg_get_constraintdef(f.oid),
                  position('(' in substring(pg_catalog.pg_get_constraintdef(f.oid), 14))+14, position(')'
                  in substring(pg_catalog.pg_get_constraintdef(f.oid), position('(' in
                  substring(pg_catalog.pg_get_constraintdef(f.oid), 14))+14))-1) END AS ForeignKeyReferenceColumnName,
      fn.nspname as ForeignKeyReferenceSchemaName,
      FALSE as IsViewColumn

      FROM pg_catalog.pg_class c
      JOIN pg_catalog.pg_tables t ON c.relname = t.tablename
      JOIN pg_catalog.pg_attribute a ON c.oid = a.attrelid AND a.attnum > 0
      JOIN pg_catalog.pg_namespace n ON n.oid = c.relnamespace
      LEFT JOIN pg_catalog.pg_constraint p ON p.contype = 'p'::char AND p.conrelid = c.oid AND (a.attnum = ANY (p.conkey))
      LEFT JOIN pg_catalog.pg_constraint f ON f.contype = 'f'::char AND f.conrelid = c.oid AND (a.attnum = ANY (f.conkey))
      LEFT JOIN pg_catalog.pg_class fc on fc.oid = f.confrelid
      LEFT JOIN pg_catalog.pg_namespace fn on fn.oid = fc.relnamespace

      WHERE a.atttypid <> 0::oid AND (n.nspname != 'information_schema' AND n.nspname NOT LIKE 'pg_%') AND c.relkind = 'r')
  UNION
  (SELECT
      t.viewname as TableName,
      n.nspname AS TableSchema,
      a.attname as ColumnName,
      pg_catalog.format_type(a.atttypid, NULL) AS DbDataType,
      pg_catalog.col_description(a.attrelid, a.attnum) AS ColumnComment,
      (a.attnotnull = FALSE) AS IsNullable,
      null AS PrimaryKeyConstraintName,
      null AS ForeignKeyConstraintName,
      null as ForeignKeyReferenceTableName,
      null as ForeignKeyReferenceColumnName,
      null as ForeignKeyReferenceSchemaName,
      true as IsViewColumn

      FROM pg_catalog.pg_class c
      JOIN pg_catalog.pg_views t ON c.relname = t.viewname
      JOIN pg_catalog.pg_attribute a ON c.oid = a.attrelid AND a.attnum > 0
      JOIN pg_catalog.pg_namespace n ON n.oid = c.relnamespace

      WHERE a.atttypid <> 0::oid
        AND (n.nspname != 'information_schema' AND n.nspname NOT LIKE 'pg_%')
        and not (n.nspname = 'public' and t.viewname = 'db_columns')
  )) ORDER BY TableSchema, IsViewColumn, TableName, ColumnName;
