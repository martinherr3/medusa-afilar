DROP DATABASE [Afilar]
GO
CREATE DATABASE [Afilar]
GO
USE [Afilar]
GO
/****** Objeto:  Table [dbo].[tipodocumento]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipodocumento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipodocumento](
	[idtipodocumento] [int] NOT NULL,
	[nombre] [char](10) NULL,
	[descipcion] [char](10) NULL,
 CONSTRAINT [PK_tipodocumento] PRIMARY KEY CLUSTERED 
(
	[idtipodocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[cargo]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cargo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[cargo](
	[idcargo] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](20) NULL,
 CONSTRAINT [PK_cargo] PRIMARY KEY CLUSTERED 
(
	[idcargo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[tipoacabado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipoacabado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipoacabado](
	[nombre] [char](40) NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_tipoacabado] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[mododeavance]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mododeavance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mododeavance](
	[nombre] [char](40) NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_mododeavance] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[empresatransporte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empresatransporte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[empresatransporte](
	[nombre] [char](30) NULL,
	[direccion] [char](50) NULL,
	[telefono] [char](15) NULL,
	[idempresa] [int] NOT NULL,
 CONSTRAINT [PK_empresatransporte] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[materialatrabajar]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[materialatrabajar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[materialatrabajar](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_materialatrabajar] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[gradodificultad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gradodificultad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gradodificultad](
	[idgradodificultad] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_gradodificultad] PRIMARY KEY CLUSTERED 
(
	[idgradodificultad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[tipoparte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipoparte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipoparte](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_tipoparte] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[tipomaquina]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipomaquina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipomaquina](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
	[idtipo] [int] NULL,
 CONSTRAINT [PK_tipomaquina] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[modulo]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modulo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[modulo](
	[idmodulo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED 
(
	[idmodulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[unidaddemedida]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[unidaddemedida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[unidaddemedida](
	[idunidadmedida] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](20) NULL,
	[abreviacion] [char](20) NULL,
	[escala] [char](20) NULL,
 CONSTRAINT [PK_unidaddemedida] PRIMARY KEY CLUSTERED 
(
	[idunidadmedida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[menupadre]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[menupadre]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[menupadre](
	[idmenu] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_menupadre] PRIMARY KEY CLUSTERED 
(
	[idmenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[ordencompramp]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ordencompramp]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ordencompramp](
	[fecharealizacion] [datetime] NULL,
	[plazodeentrega] [datetime] NULL,
	[idordencompra] [int] NOT NULL,
	[nroorden] [int] NULL,
	[condicionesdepago] [char](40) NULL,
	[causa] [char](40) NULL,
	[idestado] [int] NULL,
	[idproveedor] [int] NULL,
 CONSTRAINT [PK_ordencompramp] PRIMARY KEY CLUSTERED 
(
	[idordencompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[hojaderuta]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hojaderuta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hojaderuta](
	[idhojaderuta] [int] NOT NULL,
	[fechainicioproduccion] [datetime] NULL,
 CONSTRAINT [PK_hojaderuta] PRIMARY KEY CLUSTERED 
(
	[idhojaderuta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[tipodesperfecto]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipodesperfecto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipodesperfecto](
	[idtipodesperfecto] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
 CONSTRAINT [PK_tipodesperfecto] PRIMARY KEY CLUSTERED 
(
	[idtipodesperfecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  StoredProcedure [dbo].[sp_generate_inserts]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_generate_inserts]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
--Turn system object marking on
--EXEC master.dbo.sp_MS_upd_sysobj_category 1
--GO

CREATE PROC [dbo].[sp_generate_inserts]
(
	@table_name varchar(776),  		-- The table/view for which the INSERT statements will be generated using the existing data
	@target_table varchar(776) = NULL, 	-- Use this parameter to specify a different table name into which the data will be inserted
	@include_column_list bit = 1,		-- Use this parameter to include/ommit column list in the generated INSERT statement
	@from varchar(800) = NULL, 		-- Use this parameter to filter the rows based on a filter condition (using WHERE)
	@include_timestamp bit = 0, 		-- Specify 1 for this parameter, if you want to include the TIMESTAMP/ROWVERSION column''s data in the INSERT statement
	@debug_mode bit = 0,			-- If @debug_mode is set to 1, the SQL statements constructed by this procedure will be printed for later examination
	@owner varchar(64) = NULL,		-- Use this parameter if you are not the owner of the table
	@ommit_images bit = 0,			-- Use this parameter to generate INSERT statements by omitting the ''image'' columns
	@ommit_identity bit = 0,		-- Use this parameter to ommit the identity columns
	@top int = NULL,			-- Use this parameter to generate INSERT statements only for the TOP n rows
	@cols_to_include varchar(8000) = NULL,	-- List of columns to be included in the INSERT statement
	@cols_to_exclude varchar(8000) = NULL,	-- List of columns to be excluded from the INSERT statement
	@disable_constraints bit = 0,		-- When 1, disables foreign key constraints and enables them after the INSERT statements
	@ommit_computed_cols bit = 0		-- When 1, computed columns will not be included in the INSERT statement
	
)
AS
BEGIN

/***********************************************************************************************************
Procedure:	sp_generate_inserts  (Build 22) 
		(Copyright © 2002 Narayana Vyas Kondreddi. All rights reserved.)
                                          
Purpose:	To generate INSERT statements from existing data. 
		These INSERTS can be executed to regenerate the data at some other location.
		This procedure is also useful to create a database setup, where in you can 
		script your data along with your table definitions.

Written by:	Narayana Vyas Kondreddi
	        http://vyaskn.tripod.com

Acknowledgements:
		Divya Kalra	-- For beta testing
		Mark Charsley	-- For reporting a problem with scripting uniqueidentifier columns with NULL values
		Artur Zeygman	-- For helping me simplify a bit of code for handling non-dbo owned tables
		Joris Laperre   -- For reporting a regression bug in handling text/ntext columns

Tested on: 	SQL Server 7.0 and SQL Server 2000

Date created:	January 17th 2001 21:52 GMT

Date modified:	May 1st 2002 19:50 GMT

Email: 		vyaskn@hotmail.com

NOTE:		This procedure may not work with tables with too many columns.
		Results can be unpredictable with huge text columns or SQL Server 2000''s sql_variant data types
		Whenever possible, Use @include_column_list parameter to ommit column list in the INSERT statement, for better results
		IMPORTANT: This procedure is not tested with internation data (Extended characters or Unicode). If needed
		you might want to convert the datatypes of character variables in this procedure to their respective unicode counterparts
		like nchar and nvarchar
		

Example 1:	To generate INSERT statements for table ''titles'':
		
		EXEC sp_generate_inserts ''titles''

Example 2: 	To ommit the column list in the INSERT statement: (Column list is included by default)
		IMPORTANT: If you have too many columns, you are advised to ommit column list, as shown below,
		to avoid erroneous results
		
		EXEC sp_generate_inserts ''titles'', @include_column_list = 0

Example 3:	To generate INSERT statements for ''titlesCopy'' table from ''titles'' table:

		EXEC sp_generate_inserts ''titles'', ''titlesCopy''

Example 4:	To generate INSERT statements for ''titles'' table for only those titles 
		which contain the word ''Computer'' in them:
		NOTE: Do not complicate the FROM or WHERE clause here. It''s assumed that you are good with T-SQL if you are using this parameter

		EXEC sp_generate_inserts ''titles'', @from = "from titles where title like ''%Computer%''"

Example 5: 	To specify that you want to include TIMESTAMP column''s data as well in the INSERT statement:
		(By default TIMESTAMP column''s data is not scripted)

		EXEC sp_generate_inserts ''titles'', @include_timestamp = 1

Example 6:	To print the debug information:
  
		EXEC sp_generate_inserts ''titles'', @debug_mode = 1

Example 7: 	If you are not the owner of the table, use @owner parameter to specify the owner name
		To use this option, you must have SELECT permissions on that table

		EXEC sp_generate_inserts Nickstable, @owner = ''Nick''

Example 8: 	To generate INSERT statements for the rest of the columns excluding images
		When using this otion, DO NOT set @include_column_list parameter to 0.

		EXEC sp_generate_inserts imgtable, @ommit_images = 1

Example 9: 	To generate INSERT statements excluding (ommiting) IDENTITY columns:
		(By default IDENTITY columns are included in the INSERT statement)

		EXEC sp_generate_inserts mytable, @ommit_identity = 1

Example 10: 	To generate INSERT statements for the TOP 10 rows in the table:
		
		EXEC sp_generate_inserts mytable, @top = 10

Example 11: 	To generate INSERT statements with only those columns you want:
		
		EXEC sp_generate_inserts titles, @cols_to_include = "''title'',''title_id'',''au_id''"

Example 12: 	To generate INSERT statements by omitting certain columns:
		
		EXEC sp_generate_inserts titles, @cols_to_exclude = "''title'',''title_id'',''au_id''"

Example 13:	To avoid checking the foreign key constraints while loading data with INSERT statements:
		
		EXEC sp_generate_inserts titles, @disable_constraints = 1

Example 14: 	To exclude computed columns from the INSERT statement:
		EXEC sp_generate_inserts MyTable, @ommit_computed_cols = 1
***********************************************************************************************************/

SET NOCOUNT ON

--Making sure user only uses either @cols_to_include or @cols_to_exclude
IF ((@cols_to_include IS NOT NULL) AND (@cols_to_exclude IS NOT NULL))
	BEGIN
		RAISERROR(''Use either @cols_to_include or @cols_to_exclude. Do not use both the parameters at once'',16,1)
		RETURN -1 --Failure. Reason: Both @cols_to_include and @cols_to_exclude parameters are specified
	END

--Making sure the @cols_to_include and @cols_to_exclude parameters are receiving values in proper format
IF ((@cols_to_include IS NOT NULL) AND (PATINDEX(''''''%'''''',@cols_to_include) = 0))
	BEGIN
		RAISERROR(''Invalid use of @cols_to_include property'',16,1)
		PRINT ''Specify column names surrounded by single quotes and separated by commas''
		PRINT ''Eg: EXEC sp_generate_inserts titles, @cols_to_include = "''''title_id'''',''''title''''"''
		RETURN -1 --Failure. Reason: Invalid use of @cols_to_include property
	END

IF ((@cols_to_exclude IS NOT NULL) AND (PATINDEX(''''''%'''''',@cols_to_exclude) = 0))
	BEGIN
		RAISERROR(''Invalid use of @cols_to_exclude property'',16,1)
		PRINT ''Specify column names surrounded by single quotes and separated by commas''
		PRINT ''Eg: EXEC sp_generate_inserts titles, @cols_to_exclude = "''''title_id'''',''''title''''"''
		RETURN -1 --Failure. Reason: Invalid use of @cols_to_exclude property
	END


--Checking to see if the database name is specified along wih the table name
--Your database context should be local to the table for which you want to generate INSERT statements
--specifying the database name is not allowed
IF (PARSENAME(@table_name,3)) IS NOT NULL
	BEGIN
		RAISERROR(''Do not specify the database name. Be in the required database and just specify the table name.'',16,1)
		RETURN -1 --Failure. Reason: Database name is specified along with the table name, which is not allowed
	END

--Checking for the existence of ''user table'' or ''view''
--This procedure is not written to work on system tables
--To script the data in system tables, just create a view on the system tables and script the view instead

IF @owner IS NULL
	BEGIN
		IF ((OBJECT_ID(@table_name,''U'') IS NULL) AND (OBJECT_ID(@table_name,''V'') IS NULL)) 
			BEGIN
				RAISERROR(''User table or view not found.'',16,1)
				PRINT ''You may see this error, if you are not the owner of this table or view. In that case use @owner parameter to specify the owner name.''
				PRINT ''Make sure you have SELECT permission on that table or view.''
				RETURN -1 --Failure. Reason: There is no user table or view with this name
			END
	END
ELSE
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @table_name AND (TABLE_TYPE = ''BASE TABLE'' OR TABLE_TYPE = ''VIEW'') AND TABLE_SCHEMA = @owner)
			BEGIN
				RAISERROR(''User table or view not found.'',16,1)
				PRINT ''You may see this error, if you are not the owner of this table. In that case use @owner parameter to specify the owner name.''
				PRINT ''Make sure you have SELECT permission on that table or view.''
				RETURN -1 --Failure. Reason: There is no user table or view with this name		
			END
	END

--Variable declarations
DECLARE		@Column_ID int, 		
		@Column_List varchar(8000), 
		@Column_Name varchar(128), 
		@Start_Insert varchar(786), 
		@Data_Type varchar(128), 
		@Actual_Values varchar(8000),	--This is the string that will be finally executed to generate INSERT statements
		@IDN varchar(128)		--Will contain the IDENTITY column''s name in the table

--Variable Initialization
SET @IDN = ''''
SET @Column_ID = 0
SET @Column_Name = ''''
SET @Column_List = ''''
SET @Actual_Values = ''''

IF @owner IS NULL 
	BEGIN
		SET @Start_Insert = ''INSERT INTO '' + ''['' + RTRIM(COALESCE(@target_table,@table_name)) + '']'' 
	END
ELSE
	BEGIN
		SET @Start_Insert = ''INSERT '' + ''['' + LTRIM(RTRIM(@owner)) + ''].'' + ''['' + RTRIM(COALESCE(@target_table,@table_name)) + '']'' 		
	END


--To get the first column''s ID

SELECT	@Column_ID = MIN(ORDINAL_POSITION) 	
FROM	INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
WHERE 	TABLE_NAME = @table_name AND
(@owner IS NULL OR TABLE_SCHEMA = @owner)



--Loop through all the columns of the table, to get the column names and their data types
WHILE @Column_ID IS NOT NULL
	BEGIN
		SELECT 	@Column_Name = QUOTENAME(COLUMN_NAME), 
		@Data_Type = DATA_TYPE 
		FROM 	INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
		WHERE 	ORDINAL_POSITION = @Column_ID AND 
		TABLE_NAME = @table_name AND
		(@owner IS NULL OR TABLE_SCHEMA = @owner)



		IF @cols_to_include IS NOT NULL --Selecting only user specified columns
		BEGIN
			IF CHARINDEX( '''''''' + SUBSTRING(@Column_Name,2,LEN(@Column_Name)-2) + '''''''',@cols_to_include) = 0 
			BEGIN
				GOTO SKIP_LOOP
			END
		END

		IF @cols_to_exclude IS NOT NULL --Selecting only user specified columns
		BEGIN
			IF CHARINDEX( '''''''' + SUBSTRING(@Column_Name,2,LEN(@Column_Name)-2) + '''''''',@cols_to_exclude) <> 0 
			BEGIN
				GOTO SKIP_LOOP
			END
		END

		--Making sure to output SET IDENTITY_INSERT ON/OFF in case the table has an IDENTITY column
		IF (SELECT COLUMNPROPERTY( OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + ''.'' + @table_name),SUBSTRING(@Column_Name,2,LEN(@Column_Name) - 2),''IsIdentity'')) = 1 
		BEGIN
			IF @ommit_identity = 0 --Determing whether to include or exclude the IDENTITY column
				SET @IDN = @Column_Name
			ELSE
				GOTO SKIP_LOOP			
		END
		
		--Making sure whether to output computed columns or not
		IF @ommit_computed_cols = 1
		BEGIN
			IF (SELECT COLUMNPROPERTY( OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + ''.'' + @table_name),SUBSTRING(@Column_Name,2,LEN(@Column_Name) - 2),''IsComputed'')) = 1 
			BEGIN
				GOTO SKIP_LOOP					
			END
		END
		
		--Tables with columns of IMAGE data type are not supported for obvious reasons
		IF(@Data_Type in (''image''))
			BEGIN
				IF (@ommit_images = 0)
					BEGIN
						RAISERROR(''Tables with image columns are not supported.'',16,1)
						PRINT ''Use @ommit_images = 1 parameter to generate INSERTs for the rest of the columns.''
						PRINT ''DO NOT ommit Column List in the INSERT statements. If you ommit column list using @include_column_list=0, the generated INSERTs will fail.''
						RETURN -1 --Failure. Reason: There is a column with image data type
					END
				ELSE
					BEGIN
					GOTO SKIP_LOOP
					END
			END

		--Determining the data type of the column and depending on the data type, the VALUES part of
		--the INSERT statement is generated. Care is taken to handle columns with NULL values. Also
		--making sure, not to lose any data from flot, real, money, smallmomey, datetime columns
		SET @Actual_Values = @Actual_Values  +
		CASE 
			WHEN @Data_Type IN (''char'',''varchar'',''nchar'',''nvarchar'') 
				THEN 
					''COALESCE('''''''''''''''' + REPLACE(RTRIM('' + @Column_Name + ''),'''''''''''''''','''''''''''''''''''''''')+'''''''''''''''',''''NULL'''')''
			WHEN @Data_Type IN (''datetime'',''smalldatetime'') 
				THEN 
					''COALESCE('''''''''''''''' + RTRIM(CONVERT(char,'' + @Column_Name + '',109))+'''''''''''''''',''''NULL'''')''
			WHEN @Data_Type IN (''uniqueidentifier'') 
				THEN  
					''COALESCE('''''''''''''''' + REPLACE(CONVERT(char(255),RTRIM('' + @Column_Name + '')),'''''''''''''''','''''''''''''''''''''''')+'''''''''''''''',''''NULL'''')''
			WHEN @Data_Type IN (''text'',''ntext'') 
				THEN  
					''COALESCE('''''''''''''''' + REPLACE(CONVERT(char(8000),'' + @Column_Name + ''),'''''''''''''''','''''''''''''''''''''''')+'''''''''''''''',''''NULL'''')''					
			WHEN @Data_Type IN (''binary'',''varbinary'') 
				THEN  
					''COALESCE(RTRIM(CONVERT(char,'' + ''CONVERT(int,'' + @Column_Name + ''))),''''NULL'''')''  
			WHEN @Data_Type IN (''timestamp'',''rowversion'') 
				THEN  
					CASE 
						WHEN @include_timestamp = 0 
							THEN 
								''''''DEFAULT'''''' 
							ELSE 
								''COALESCE(RTRIM(CONVERT(char,'' + ''CONVERT(int,'' + @Column_Name + ''))),''''NULL'''')''  
					END
			WHEN @Data_Type IN (''float'',''real'',''money'',''smallmoney'')
				THEN
					''COALESCE(LTRIM(RTRIM('' + ''CONVERT(char, '' +  @Column_Name  + '',2)'' + '')),''''NULL'''')'' 
			ELSE 
				''COALESCE(LTRIM(RTRIM('' + ''CONVERT(char, '' +  @Column_Name  + '')'' + '')),''''NULL'''')'' 
		END   + ''+'' +  '''''','''''' + '' + ''
		
		--Generating the column list for the INSERT statement
		SET @Column_List = @Column_List +  @Column_Name + '',''	

		SKIP_LOOP: --The label used in GOTO

		SELECT 	@Column_ID = MIN(ORDINAL_POSITION) 
		FROM 	INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
		WHERE 	TABLE_NAME = @table_name AND 
		ORDINAL_POSITION > @Column_ID AND
		(@owner IS NULL OR TABLE_SCHEMA = @owner)


	--Loop ends here!
	END

--To get rid of the extra characters that got concatenated during the last run through the loop
SET @Column_List = LEFT(@Column_List,len(@Column_List) - 1)
SET @Actual_Values = LEFT(@Actual_Values,len(@Actual_Values) - 6)

IF LTRIM(@Column_List) = '''' 
	BEGIN
		RAISERROR(''No columns to select. There should at least be one column to generate the output'',16,1)
		RETURN -1 --Failure. Reason: Looks like all the columns are ommitted using the @cols_to_exclude parameter
	END

--Forming the final string that will be executed, to output the INSERT statements
IF (@include_column_list <> 0)
	BEGIN
		SET @Actual_Values = 
			''SELECT '' +  
			CASE WHEN @top IS NULL OR @top < 0 THEN '''' ELSE '' TOP '' + LTRIM(STR(@top)) + '' '' END + 
			'''''''' + RTRIM(@Start_Insert) + 
			'' ''''+'' + ''''''('' + RTRIM(@Column_List) +  ''''''+'' + '''''')'''''' + 
			'' +''''VALUES(''''+ '' +  @Actual_Values  + ''+'''')'''''' + '' '' + 
			COALESCE(@from,'' FROM '' + CASE WHEN @owner IS NULL THEN '''' ELSE ''['' + LTRIM(RTRIM(@owner)) + ''].'' END + ''['' + rtrim(@table_name) + '']'' + ''(NOLOCK)'')
	END
ELSE IF (@include_column_list = 0)
	BEGIN
		SET @Actual_Values = 
			''SELECT '' + 
			CASE WHEN @top IS NULL OR @top < 0 THEN '''' ELSE '' TOP '' + LTRIM(STR(@top)) + '' '' END + 
			'''''''' + RTRIM(@Start_Insert) + 
			'' '''' +''''VALUES(''''+ '' +  @Actual_Values + ''+'''')'''''' + '' '' + 
			COALESCE(@from,'' FROM '' + CASE WHEN @owner IS NULL THEN '''' ELSE ''['' + LTRIM(RTRIM(@owner)) + ''].'' END + ''['' + rtrim(@table_name) + '']'' + ''(NOLOCK)'')
	END	

--Determining whether to ouput any debug information
IF @debug_mode =1
	BEGIN
		PRINT ''/*****START OF DEBUG INFORMATION*****''
		PRINT ''Beginning of the INSERT statement:''
		PRINT @Start_Insert
		PRINT ''''
		PRINT ''The column list:''
		PRINT @Column_List
		PRINT ''''
		PRINT ''The SELECT statement executed to generate the INSERTs''
		PRINT @Actual_Values
		PRINT ''''
		PRINT ''*****END OF DEBUG INFORMATION*****/''
		PRINT ''''
	END
		
PRINT ''--INSERTs generated by ''''sp_generate_inserts'''' stored procedure written by Vyas''
PRINT ''--Build number: 22''
PRINT ''--Problems/Suggestions? Contact Vyas @ vyaskn@hotmail.com''
PRINT ''--http://vyaskn.tripod.com''
PRINT ''''
PRINT ''SET NOCOUNT ON''
PRINT ''''


--Determining whether to print IDENTITY_INSERT or not
IF (@IDN <> '''')
	BEGIN
		PRINT ''SET IDENTITY_INSERT '' + QUOTENAME(COALESCE(@owner,USER_NAME())) + ''.'' + QUOTENAME(@table_name) + '' ON''
		PRINT ''GO''
		PRINT ''''
	END


IF @disable_constraints = 1 AND (OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + ''.'' + @table_name, ''U'') IS NOT NULL)
	BEGIN
		IF @owner IS NULL
			BEGIN
				SELECT 	''ALTER TABLE '' + QUOTENAME(COALESCE(@target_table, @table_name)) + '' NOCHECK CONSTRAINT ALL'' AS ''--Code to disable constraints temporarily''
			END
		ELSE
			BEGIN
				SELECT 	''ALTER TABLE '' + QUOTENAME(@owner) + ''.'' + QUOTENAME(COALESCE(@target_table, @table_name)) + '' NOCHECK CONSTRAINT ALL'' AS ''--Code to disable constraints temporarily''
			END

		PRINT ''GO''
	END

PRINT ''''
PRINT ''PRINT ''''Inserting values into '' + ''['' + RTRIM(COALESCE(@target_table,@table_name)) + '']'' + ''''''''


--All the hard work pays off here!!! You''ll get your INSERT statements, when the next line executes!
EXEC (@Actual_Values)

PRINT ''PRINT ''''Done''''''
PRINT ''''


IF @disable_constraints = 1 AND (OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + ''.'' + @table_name, ''U'') IS NOT NULL)
	BEGIN
		IF @owner IS NULL
			BEGIN
				SELECT 	''ALTER TABLE '' + QUOTENAME(COALESCE(@target_table, @table_name)) + '' CHECK CONSTRAINT ALL''  AS ''--Code to enable the previously disabled constraints''
			END
		ELSE
			BEGIN
				SELECT 	''ALTER TABLE '' + QUOTENAME(@owner) + ''.'' + QUOTENAME(COALESCE(@target_table, @table_name)) + '' CHECK CONSTRAINT ALL'' AS ''--Code to enable the previously disabled constraints''
			END

		PRINT ''GO''
	END

PRINT ''''
IF (@IDN <> '''')
	BEGIN
		PRINT ''SET IDENTITY_INSERT '' + QUOTENAME(COALESCE(@owner,USER_NAME())) + ''.'' + QUOTENAME(@table_name) + '' OFF''
		PRINT ''GO''
	END

PRINT ''SET NOCOUNT OFF''


SET NOCOUNT OFF
RETURN 0 --Success. We are done!
END

' 
END
GO
/****** Objeto:  Table [dbo].[app_param]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[app_param]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[app_param](
	[id] [int] NOT NULL,
	[label] [varchar](50) NULL,
	[numeric_value] [decimal](18, 4) NULL,
	[string_value] [nvarchar](max) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[formadeentrega]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formadeentrega]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formadeentrega](
	[idformadeentrega] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_formadeentrega] PRIMARY KEY CLUSTERED 
(
	[idformadeentrega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[maquinaFresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[maquinaFresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[maquinaFresa](
	[idmaquina] [int] NOT NULL,
	[nombre] [text] NOT NULL,
	[potencia] [float] NULL,
	[rpmdeleje] [float] NULL,
	[sentidodegiro] [char](30) NULL,
	[caracteristicas] [text] NULL,
	[estado] [char](25) NULL,
 CONSTRAINT [PK_maquinaFresa] PRIMARY KEY CLUSTERED 
(
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[objetodelservicio]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[objetodelservicio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[objetodelservicio](
	[idobjetodelservicio] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
	[nroserie] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_objetodelservicio] PRIMARY KEY CLUSTERED 
(
	[idobjetodelservicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[estado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[estado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[estado](
	[idestado] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[descripcion] [char](40) NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[provincia]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[provincia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[provincia](
	[idprovincia] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
 CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED 
(
	[idprovincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[tornero]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tornero]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tornero](
	[idtornero] [int] NOT NULL,
	[nombre] [char](50) NULL,
	[apellido] [char](50) NULL,
	[domicilio] [char](50) NULL,
	[telefono] [char](25) NULL,
	[celular] [char](25) NULL,
	[cantidadtorneados] [int] NULL,
	[efectividad] [float] NULL,
	[observaciones] [text] NULL,
 CONSTRAINT [PK_tornero] PRIMARY KEY CLUSTERED 
(
	[idtornero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[cliente]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] NOT NULL,
	[nombre] [char](50) NOT NULL,
	[apellido] [char](50) NULL,
	[idtipodocumento] [int] NULL,
	[direccion] [char](50) NULL,
	[localidad] [int] NULL,
	[mail] [char](50) NULL,
	[telefono] [char](20) NULL,
	[documento] [numeric](18, 0) NULL,
	[celular] [char](20) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empleado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[empleado](
	[idlegajo] [int] NOT NULL,
	[nombre] [char](50) NULL,
	[apellido] [char](50) NULL,
	[direccion] [char](20) NULL,
	[telefono] [char](20) NULL,
	[idcargo] [int] NULL,
	[email] [char](30) NULL,
	[titulo] [char](30) NULL,
	[idlocalidad] [int] NULL,
	[turno] [char](30) NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[idlegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[modelofresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modelofresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[modelofresa](
	[idmodelo] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[grupomodelo] [char](50) NULL,
	[descripcion] [text] NULL,
	[materialatrabajar] [char](40) NULL,
	[mododeavance] [char](40) NULL,
	[tipoacabado] [char](40) NULL,
	[velocidaddeavance] [float] NULL,
	[tipomodelo] [char](40) NULL,
	[precio] [float] NULL,
	[estado] [char](15) NULL,
 CONSTRAINT [PK_modelofresa] PRIMARY KEY CLUSTERED 
(
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[Pedido]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pedido]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pedido](
	[idpedido] [numeric](18, 0) NOT NULL,
	[fechaentrega] [datetime] NULL,
	[fecharealizacion] [datetime] NULL,
	[idestado] [int] NULL,
	[prioridad] [int] NULL,
	[idcliente] [int] NULL,
	[idvendedor] [int] NULL,
	[idformadeentrega] [int] NULL,
	[idempresa] [int] NULL,
	[idviajante] [int] NULL,
	[fecharealentrega] [datetime] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[empresaxlocalidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empresaxlocalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[empresaxlocalidad](
	[idempresa] [int] NOT NULL,
	[idlocalidad] [int] NOT NULL,
 CONSTRAINT [PK_empresaxlocalidad] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC,
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[operacion]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[operacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[operacion](
	[idoperacion] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[maquina] [char](40) NULL,
	[duracionpromedio] [float] NULL,
	[idgradodificultad] [int] NULL,
	[tolerancia] [float] NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_operacion] PRIMARY KEY CLUSTERED 
(
	[idoperacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[MPxTP]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MPxTP]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MPxTP](
	[nombre] [char](40) NOT NULL,
	[idmp] [int] NOT NULL,
 CONSTRAINT [PK_MPxTP] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC,
	[idmp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[parte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parte](
	[idmodelo] [int] NOT NULL,
	[idtipofresa] [int] NOT NULL,
	[idparte] [int] NOT NULL,
	[cantidad] [float] NULL,
	[nombre] [char](40) NULL,
	[descripcion] [text] NULL,
	[idtipomateriaprima] [int] NULL,
 CONSTRAINT [PK_parte] PRIMARY KEY CLUSTERED 
(
	[idtipofresa] ASC,
	[idparte] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[maquina]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[maquina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[maquina](
	[idmaquina] [int] NOT NULL,
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
	[numerodeserie] [char](20) NULL,
	[potencia] [char](20) NULL,
	[costodecompra] [decimal](18, 0) NULL,
	[estadodeadquisicion] [char](20) NULL,
	[idestado] [int] NULL,
	[horasdeuso] [datetime] NULL,
	[tipomaquina] [char](40) NULL,
 CONSTRAINT [PK_maquina] PRIMARY KEY CLUSTERED 
(
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[formulario]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formulario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formulario](
	[idformulario] [int] NOT NULL,
	[descripcion] [char](50) NULL,
	[idmodulo] [int] NULL,
	[nombre] [varchar](50) NOT NULL,
	[idmenu] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_formulario] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[tipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipomateriaprima]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipomateriaprima](
	[idtipomateriaprima] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[direccion] [char](40) NULL,
	[stockactual] [int] NULL,
	[stockminimo] [int] NULL,
	[stockseguridad] [int] NULL,
	[loteeconomico] [int] NULL,
	[idunidadmedida] [int] NULL,
 CONSTRAINT [PK_tipomateriaprima] PRIMARY KEY CLUSTERED 
(
	[idtipomateriaprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[mprecibida]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mprecibida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mprecibida](
	[idmprecibida] [int] NOT NULL,
	[fecharecepcion] [char](20) NULL,
	[numremito] [int] NULL,
	[idordencompramp] [int] NULL,
 CONSTRAINT [PK_mprecibida] PRIMARY KEY CLUSTERED 
(
	[idmprecibida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[pago]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pago]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pago](
	[monto] [float] NULL,
	[fechadepago] [datetime] NULL,
	[formadepago] [char](10) NULL,
	[idordencompra] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[detalleordencompra]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detalleordencompra]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detalleordencompra](
	[idordencompra] [int] NOT NULL,
	[idtipomateriaprima] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio] [money] NULL,
	[idestado] [int] NOT NULL,
 CONSTRAINT [PK_detalleordencompra] PRIMARY KEY CLUSTERED 
(
	[idordencompra] ASC,
	[idtipomateriaprima] ASC,
	[idestado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[fresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[fresa](
	[nroserie] [int] NOT NULL,
	[fechafinfabricacion] [datetime] NULL,
	[costofabricacion] [decimal](18, 0) NULL,
	[estado] [int] NULL,
	[nropedido] [numeric](18, 0) NOT NULL,
	[controlcalidad] [int] NULL,
	[idhojaderuta] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[idtipo] [int] NULL,
	[idmodelo] [int] NULL,
 CONSTRAINT [PK_fresa] PRIMARY KEY CLUSTERED 
(
	[nroserie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[detallehojaderuta]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detallehojaderuta](
	[idhojaderuta] [int] NOT NULL,
	[idetapadefabricacion] [int] NOT NULL,
	[idlegajo] [int] NULL,
	[idtorneado] [int] NULL,
	[fechahorainicioreal] [datetime] NULL,
	[fechahorainicioplanificada] [datetime] NULL,
	[fechahorafinreal] [datetime] NULL,
	[fechahorafinplanificada] [datetime] NULL,
	[observaciones] [char](30) NULL,
 CONSTRAINT [PK_detallehojaderuta] PRIMARY KEY CLUSTERED 
(
	[idhojaderuta] ASC,
	[idetapadefabricacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[detalleordenservicio]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detalleordenservicio](
	[idpedido] [numeric](18, 0) NOT NULL,
	[idoperacion] [int] NOT NULL,
	[idobjetodelservicio] [int] NOT NULL,
	[preciodeservicio] [decimal](18, 0) NULL,
	[observacion] [char](30) NULL,
	[idhojaderuta] [int] NULL,
	[precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_detalleordenservicio] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC,
	[idoperacion] ASC,
	[idobjetodelservicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[desperfecto]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[desperfecto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[desperfecto](
	[iddesperfecto] [int] NOT NULL,
	[idtipodesperfecto] [int] NULL,
	[fecharotura] [datetime] NULL,
	[causa] [char](30) NULL,
	[fechareparacion] [datetime] NULL,
	[costo] [decimal](18, 0) NULL,
	[idmaquina] [int] NULL,
 CONSTRAINT [PK_desperfecto] PRIMARY KEY CLUSTERED 
(
	[iddesperfecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[fresaxmaquina]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fresaxmaquina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[fresaxmaquina](
	[idmodelo] [int] NOT NULL,
	[idmaquina] [int] NOT NULL,
 CONSTRAINT [PK_fresaxmaquina] PRIMARY KEY CLUSTERED 
(
	[idmodelo] ASC,
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[controlcalidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[controlcalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[controlcalidad](
	[idcontrol] [int] NOT NULL,
	[observaciones] [char](250) NULL,
	[medidas] [char](10) NULL,
	[pintura] [char](10) NULL,
	[soldadura] [char](10) NULL,
	[torneado] [char](10) NULL,
	[idfresa] [int] NULL,
	[fechahoracontrol] [nvarchar](50) NULL,
 CONSTRAINT [PK_controlcalidad] PRIMARY KEY CLUSTERED 
(
	[idcontrol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[partepedido]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[partepedido]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[partepedido](
	[idpedido] [numeric](18, 0) NOT NULL,
	[idpartepedida] [int] NOT NULL,
	[idmodelo] [int] NULL,
	[idadicional] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_partepedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC,
	[idpartepedida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[proveedor]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proveedor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[proveedor](
	[idproveedor] [int] NOT NULL,
	[nombre] [char](80) NULL,
	[direccion] [char](80) NULL,
	[telefono] [char](20) NULL,
	[mail] [char](80) NULL,
	[nombrecontacto] [char](80) NULL,
	[idlocalidad] [int] NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[viajantexlocalidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[viajantexlocalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[viajantexlocalidad](
	[idviajante] [int] NOT NULL,
	[idlocalidad] [int] NOT NULL,
 CONSTRAINT [PK_viajantexlocalidad] PRIMARY KEY CLUSTERED 
(
	[idviajante] ASC,
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[presupuesto]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[presupuesto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[presupuesto](
	[idpresupuesto] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[idcliente] [int] NULL,
	[idempleado] [int] NULL,
 CONSTRAINT [PK_presupuesto] PRIMARY KEY CLUSTERED 
(
	[idpresupuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[formxempleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formxempleado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formxempleado](
	[idformulario] [int] NOT NULL,
	[idlegajo] [int] NOT NULL,
 CONSTRAINT [PK_formxempleado] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC,
	[idlegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[cuentausuario]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cuentausuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[cuentausuario](
	[usuario] [char](6) NOT NULL,
	[contraseña] [char](100) NOT NULL,
	[creacion] [datetime] NULL,
	[idlegajo] [int] NOT NULL,
 CONSTRAINT [PK_cuentausuario] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[perfil]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[perfil]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[perfil](
	[idperfil] [int] NOT NULL,
	[descripcion] [char](50) NULL,
	[idlegajo] [int] NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[idperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[tipofresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipofresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipofresa](
	[idtipo] [int] NOT NULL,
	[idmodelo] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[diametroexterior] [decimal](18, 0) NULL,
	[diametroagujero] [decimal](18, 0) NULL,
	[cantidaddientes] [int] NULL,
	[plano] [char](80) NULL,
	[posiciondetrabajo] [char](40) NULL,
	[caracteristicas] [text] NULL,
	[costo] [decimal](18, 0) NULL,
	[precio] [decimal](18, 0) NULL,
	[estado] [char](15) NULL,
 CONSTRAINT [PK_tipofresa] PRIMARY KEY CLUSTERED 
(
	[idtipo] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[parteadicional]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parteadicional]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parteadicional](
	[idadicional] [int] NOT NULL,
	[idmodelo] [int] NOT NULL,
	[nombre] [char](60) NULL,
	[plano] [char](80) NULL,
	[imagen] [image] NULL,
	[idmateriaprima] [int] NULL,
	[cantidad] [float] NULL,
	[descripcion] [text] NULL,
	[tiempo] [float] NULL,
	[costo] [float] NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_parteadicional] PRIMARY KEY CLUSTERED 
(
	[idadicional] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[etapadefabricacion]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[etapadefabricacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[etapadefabricacion](
	[idetapafabricacion] [int] NOT NULL,
	[idmodelo] [int] NOT NULL,
	[idtipofresa] [int] NOT NULL,
	[idoperacion] [int] NULL,
	[orden] [int] NULL,
	[tiempoadicional] [float] NULL,
	[detalle] [text] NULL,
 CONSTRAINT [PK_etapadefabricacion] PRIMARY KEY CLUSTERED 
(
	[idetapafabricacion] ASC,
	[idtipofresa] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[formxperfil]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formxperfil]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formxperfil](
	[idformulario] [int] NOT NULL,
	[idperfil] [int] NOT NULL,
 CONSTRAINT [PK_formxperfil] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC,
	[idperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[proveedorxtipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proveedorxtipomateriaprima]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[proveedorxtipomateriaprima](
	[idproveedor] [int] NOT NULL,
	[idtipomateriaprima] [int] NOT NULL,
 CONSTRAINT [PK_proveedorxtipomateriaprima] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC,
	[idtipomateriaprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[detallemprecibida]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallemprecibida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detallemprecibida](
	[idmprecibida] [int] NOT NULL,
	[cantidad] [int] NULL,
	[preciol] [float] NULL,
	[causarechazo] [char](20) NULL,
	[idestado] [int] NULL,
	[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[detallepresupuesto]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallepresupuesto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detallepresupuesto](
	[iddetpre] [int] NOT NULL,
	[idpresupuesto] [int] NOT NULL,
	[idmodelo] [int] NULL,
	[idproducto] [int] NULL,
	[tipo] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_detallepresupuesto] PRIMARY KEY CLUSTERED 
(
	[idpresupuesto] ASC,
	[iddetpre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  Table [dbo].[localidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[localidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[localidad](
	[idlocalidad] [int] NOT NULL,
	[codigopostal] [int] NULL,
	[zona] [char](20) NULL,
	[provincia] [char](20) NULL,
	[distancia] [char](20) NULL,
	[nombre] [char](20) NULL,
	[idprovincia] [int] NULL,
 CONSTRAINT [PK_localidad] PRIMARY KEY CLUSTERED 
(
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Objeto:  Table [dbo].[torneado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[torneado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[torneado](
	[idtorneado] [int] NOT NULL,
	[fechasalidad] [datetime] NULL,
	[fecharecepcion] [datetime] NULL,
	[idtornero] [int] NULL,
	[costo] [float] NULL,
 CONSTRAINT [PK_torneado] PRIMARY KEY CLUSTERED 
(
	[idtorneado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Objeto:  ForeignKey [FK_cliente_localidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_cliente_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[cliente]'))
ALTER TABLE [dbo].[cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_cliente_localidad] FOREIGN KEY([localidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_localidad]
GO
/****** Objeto:  ForeignKey [FK_cliente_tipodocumento]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_cliente_tipodocumento]') AND parent_object_id = OBJECT_ID(N'[dbo].[cliente]'))
ALTER TABLE [dbo].[cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_cliente_tipodocumento] FOREIGN KEY([idtipodocumento])
REFERENCES [dbo].[tipodocumento] ([idtipodocumento])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_tipodocumento]
GO
/****** Objeto:  ForeignKey [FK_controlcalidad_fresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_controlcalidad_fresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[controlcalidad]'))
ALTER TABLE [dbo].[controlcalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_controlcalidad_fresa] FOREIGN KEY([idfresa])
REFERENCES [dbo].[fresa] ([nroserie])
GO
ALTER TABLE [dbo].[controlcalidad] CHECK CONSTRAINT [FK_controlcalidad_fresa]
GO
/****** Objeto:  ForeignKey [FK_cuentausuario_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_cuentausuario_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[cuentausuario]'))
ALTER TABLE [dbo].[cuentausuario]  WITH NOCHECK ADD  CONSTRAINT [FK_cuentausuario_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[cuentausuario] CHECK CONSTRAINT [FK_cuentausuario_empleado]
GO
/****** Objeto:  ForeignKey [FK_desperfecto_maquina]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_desperfecto_maquina]') AND parent_object_id = OBJECT_ID(N'[dbo].[desperfecto]'))
ALTER TABLE [dbo].[desperfecto]  WITH NOCHECK ADD  CONSTRAINT [FK_desperfecto_maquina] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquina] ([idmaquina])
GO
ALTER TABLE [dbo].[desperfecto] CHECK CONSTRAINT [FK_desperfecto_maquina]
GO
/****** Objeto:  ForeignKey [FK_desperfecto_tipodesperfecto]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_desperfecto_tipodesperfecto]') AND parent_object_id = OBJECT_ID(N'[dbo].[desperfecto]'))
ALTER TABLE [dbo].[desperfecto]  WITH NOCHECK ADD  CONSTRAINT [FK_desperfecto_tipodesperfecto] FOREIGN KEY([idtipodesperfecto])
REFERENCES [dbo].[tipodesperfecto] ([idtipodesperfecto])
GO
ALTER TABLE [dbo].[desperfecto] CHECK CONSTRAINT [FK_desperfecto_tipodesperfecto]
GO
/****** Objeto:  ForeignKey [FK_detallehojaderuta_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallehojaderuta_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]'))
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_empleado]
GO
/****** Objeto:  ForeignKey [FK_detallehojaderuta_hojaderuta]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallehojaderuta_hojaderuta]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]'))
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_hojaderuta]
GO
/****** Objeto:  ForeignKey [FK_detallehojaderuta_torneado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallehojaderuta_torneado]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]'))
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_torneado] FOREIGN KEY([idtorneado])
REFERENCES [dbo].[torneado] ([idtorneado])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_torneado]
GO
/****** Objeto:  ForeignKey [FK_detallemprecibida_estado1]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_estado1]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_estado1] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_estado1]
GO
/****** Objeto:  ForeignKey [FK_detallemprecibida_mprecibida]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_mprecibida]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_mprecibida] FOREIGN KEY([idmprecibida])
REFERENCES [dbo].[mprecibida] ([idmprecibida])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_mprecibida]
GO
/****** Objeto:  ForeignKey [FK_detallemprecibida_mprecibida1]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_mprecibida1]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_mprecibida1] FOREIGN KEY([idmprecibida])
REFERENCES [dbo].[mprecibida] ([idmprecibida])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_mprecibida1]
GO
/****** Objeto:  ForeignKey [FK_detallemprecibida_tipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_tipomateriaprima]
GO
/****** Objeto:  ForeignKey [FK_detalleordencompra_estado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordencompra_estado]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordencompra]'))
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_estado] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_estado]
GO
/****** Objeto:  ForeignKey [FK_detalleordencompra_ordencompramp1]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordencompra_ordencompramp1]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordencompra]'))
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_ordencompramp1] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_ordencompramp1]
GO
/****** Objeto:  ForeignKey [FK_detalleordencompra_tipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordencompra_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordencompra]'))
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_tipomateriaprima]
GO
/****** Objeto:  ForeignKey [FK_detalleordenservicio_hojaderuta]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_hojaderuta]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_hojaderuta]
GO
/****** Objeto:  ForeignKey [FK_detalleordenservicio_objetodelservicio]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_objetodelservicio]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_objetodelservicio] FOREIGN KEY([idobjetodelservicio])
REFERENCES [dbo].[objetodelservicio] ([idobjetodelservicio])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_objetodelservicio]
GO
/****** Objeto:  ForeignKey [FK_detalleordenservicio_operacion]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_operacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_operacion] FOREIGN KEY([idoperacion])
REFERENCES [dbo].[operacion] ([idoperacion])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_operacion]
GO
/****** Objeto:  ForeignKey [FK_detalleordenservicio_Pedido]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_Pedido] FOREIGN KEY([idpedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_Pedido]
GO
/****** Objeto:  ForeignKey [FK_detallepresupuesto_presupuesto]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallepresupuesto_presupuesto]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallepresupuesto]'))
ALTER TABLE [dbo].[detallepresupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_detallepresupuesto_presupuesto] FOREIGN KEY([idpresupuesto])
REFERENCES [dbo].[presupuesto] ([idpresupuesto])
GO
ALTER TABLE [dbo].[detallepresupuesto] CHECK CONSTRAINT [FK_detallepresupuesto_presupuesto]
GO
/****** Objeto:  ForeignKey [FK_empleado_cargo]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empleado_cargo]') AND parent_object_id = OBJECT_ID(N'[dbo].[empleado]'))
ALTER TABLE [dbo].[empleado]  WITH NOCHECK ADD  CONSTRAINT [FK_empleado_cargo] FOREIGN KEY([idcargo])
REFERENCES [dbo].[cargo] ([idcargo])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_cargo]
GO
/****** Objeto:  ForeignKey [FK_empleado_localidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empleado_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[empleado]'))
ALTER TABLE [dbo].[empleado]  WITH NOCHECK ADD  CONSTRAINT [FK_empleado_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_localidad]
GO
/****** Objeto:  ForeignKey [FK_empresaxlocalidad_empresatransporte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empresaxlocalidad_empresatransporte]') AND parent_object_id = OBJECT_ID(N'[dbo].[empresaxlocalidad]'))
ALTER TABLE [dbo].[empresaxlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_empresaxlocalidad_empresatransporte] FOREIGN KEY([idempresa])
REFERENCES [dbo].[empresatransporte] ([idempresa])
GO
ALTER TABLE [dbo].[empresaxlocalidad] CHECK CONSTRAINT [FK_empresaxlocalidad_empresatransporte]
GO
/****** Objeto:  ForeignKey [FK_empresaxlocalidad_localidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empresaxlocalidad_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[empresaxlocalidad]'))
ALTER TABLE [dbo].[empresaxlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_empresaxlocalidad_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[empresaxlocalidad] CHECK CONSTRAINT [FK_empresaxlocalidad_localidad]
GO
/****** Objeto:  ForeignKey [FK_etapadefabricacion_operacion]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_etapadefabricacion_operacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[etapadefabricacion]'))
ALTER TABLE [dbo].[etapadefabricacion]  WITH NOCHECK ADD  CONSTRAINT [FK_etapadefabricacion_operacion] FOREIGN KEY([idoperacion])
REFERENCES [dbo].[operacion] ([idoperacion])
GO
ALTER TABLE [dbo].[etapadefabricacion] CHECK CONSTRAINT [FK_etapadefabricacion_operacion]
GO
/****** Objeto:  ForeignKey [FK_etapadefabricacion_tipofresa1]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_etapadefabricacion_tipofresa1]') AND parent_object_id = OBJECT_ID(N'[dbo].[etapadefabricacion]'))
ALTER TABLE [dbo].[etapadefabricacion]  WITH NOCHECK ADD  CONSTRAINT [FK_etapadefabricacion_tipofresa1] FOREIGN KEY([idtipofresa], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[etapadefabricacion] CHECK CONSTRAINT [FK_etapadefabricacion_tipofresa1]
GO
/****** Objeto:  ForeignKey [FK_formulario_menupadre]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formulario_menupadre]') AND parent_object_id = OBJECT_ID(N'[dbo].[formulario]'))
ALTER TABLE [dbo].[formulario]  WITH NOCHECK ADD  CONSTRAINT [FK_formulario_menupadre] FOREIGN KEY([idmenu])
REFERENCES [dbo].[menupadre] ([idmenu])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_menupadre]
GO
/****** Objeto:  ForeignKey [FK_formulario_modulo]    Fecha de la secuencia de comandos: 08/13/2007 21:57:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formulario_modulo]') AND parent_object_id = OBJECT_ID(N'[dbo].[formulario]'))
ALTER TABLE [dbo].[formulario]  WITH NOCHECK ADD  CONSTRAINT [FK_formulario_modulo] FOREIGN KEY([idmodulo])
REFERENCES [dbo].[modulo] ([idmodulo])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_modulo]
GO
/****** Objeto:  ForeignKey [FK_formxempleado_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxempleado_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxempleado]'))
ALTER TABLE [dbo].[formxempleado]  WITH NOCHECK ADD  CONSTRAINT [FK_formxempleado_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[formxempleado] CHECK CONSTRAINT [FK_formxempleado_empleado]
GO
/****** Objeto:  ForeignKey [FK_formxempleado_formulario]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxempleado_formulario]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxempleado]'))
ALTER TABLE [dbo].[formxempleado]  WITH NOCHECK ADD  CONSTRAINT [FK_formxempleado_formulario] FOREIGN KEY([idformulario])
REFERENCES [dbo].[formulario] ([idformulario])
GO
ALTER TABLE [dbo].[formxempleado] CHECK CONSTRAINT [FK_formxempleado_formulario]
GO
/****** Objeto:  ForeignKey [FK_formxperfil_formulario]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxperfil_formulario]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxperfil]'))
ALTER TABLE [dbo].[formxperfil]  WITH NOCHECK ADD  CONSTRAINT [FK_formxperfil_formulario] FOREIGN KEY([idformulario])
REFERENCES [dbo].[formulario] ([idformulario])
GO
ALTER TABLE [dbo].[formxperfil] CHECK CONSTRAINT [FK_formxperfil_formulario]
GO
/****** Objeto:  ForeignKey [FK_formxperfil_perfil]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxperfil_perfil]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxperfil]'))
ALTER TABLE [dbo].[formxperfil]  WITH NOCHECK ADD  CONSTRAINT [FK_formxperfil_perfil] FOREIGN KEY([idperfil])
REFERENCES [dbo].[perfil] ([idperfil])
GO
ALTER TABLE [dbo].[formxperfil] CHECK CONSTRAINT [FK_formxperfil_perfil]
GO
/****** Objeto:  ForeignKey [FK_fresa_estado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_estado]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_estado]
GO
/****** Objeto:  ForeignKey [FK_fresa_hojaderuta]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_hojaderuta]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_hojaderuta]
GO
/****** Objeto:  ForeignKey [FK_fresa_Pedido]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_Pedido] FOREIGN KEY([nropedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_Pedido]
GO
/****** Objeto:  ForeignKey [FK_fresa_tipofresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_tipofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_tipofresa] FOREIGN KEY([idtipo], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_tipofresa]
GO
/****** Objeto:  ForeignKey [FK_fresaxmaquina_maquinaFresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresaxmaquina_maquinaFresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresaxmaquina]'))
ALTER TABLE [dbo].[fresaxmaquina]  WITH NOCHECK ADD  CONSTRAINT [FK_fresaxmaquina_maquinaFresa] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquinaFresa] ([idmaquina])
GO
ALTER TABLE [dbo].[fresaxmaquina] CHECK CONSTRAINT [FK_fresaxmaquina_maquinaFresa]
GO
/****** Objeto:  ForeignKey [FK_fresaxmaquina_modelofresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresaxmaquina_modelofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresaxmaquina]'))
ALTER TABLE [dbo].[fresaxmaquina]  WITH NOCHECK ADD  CONSTRAINT [FK_fresaxmaquina_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[fresaxmaquina] CHECK CONSTRAINT [FK_fresaxmaquina_modelofresa]
GO
/****** Objeto:  ForeignKey [FK_localidad_provincia]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_localidad_provincia]') AND parent_object_id = OBJECT_ID(N'[dbo].[localidad]'))
ALTER TABLE [dbo].[localidad]  WITH NOCHECK ADD  CONSTRAINT [FK_localidad_provincia] FOREIGN KEY([idprovincia])
REFERENCES [dbo].[provincia] ([idprovincia])
GO
ALTER TABLE [dbo].[localidad] CHECK CONSTRAINT [FK_localidad_provincia]
GO
/****** Objeto:  ForeignKey [FK_maquina_tipomaquina]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_maquina_tipomaquina]') AND parent_object_id = OBJECT_ID(N'[dbo].[maquina]'))
ALTER TABLE [dbo].[maquina]  WITH NOCHECK ADD  CONSTRAINT [FK_maquina_tipomaquina] FOREIGN KEY([tipomaquina])
REFERENCES [dbo].[tipomaquina] ([nombre])
GO
ALTER TABLE [dbo].[maquina] CHECK CONSTRAINT [FK_maquina_tipomaquina]
GO
/****** Objeto:  ForeignKey [FK_modelofresa_materialatrabajar]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelofresa_materialatrabajar]') AND parent_object_id = OBJECT_ID(N'[dbo].[modelofresa]'))
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_materialatrabajar] FOREIGN KEY([materialatrabajar])
REFERENCES [dbo].[materialatrabajar] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_materialatrabajar]
GO
/****** Objeto:  ForeignKey [FK_modelofresa_mododeavance]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelofresa_mododeavance]') AND parent_object_id = OBJECT_ID(N'[dbo].[modelofresa]'))
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_mododeavance] FOREIGN KEY([mododeavance])
REFERENCES [dbo].[mododeavance] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_mododeavance]
GO
/****** Objeto:  ForeignKey [FK_modelofresa_tipoacabado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelofresa_tipoacabado]') AND parent_object_id = OBJECT_ID(N'[dbo].[modelofresa]'))
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_tipoacabado] FOREIGN KEY([tipoacabado])
REFERENCES [dbo].[tipoacabado] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_tipoacabado]
GO
/****** Objeto:  ForeignKey [FK_mprecibida_ordencompramp]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mprecibida_ordencompramp]') AND parent_object_id = OBJECT_ID(N'[dbo].[mprecibida]'))
ALTER TABLE [dbo].[mprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_mprecibida_ordencompramp] FOREIGN KEY([idordencompramp])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[mprecibida] CHECK CONSTRAINT [FK_mprecibida_ordencompramp]
GO
/****** Objeto:  ForeignKey [FK_MPxTP_tipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MPxTP_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[MPxTP]'))
ALTER TABLE [dbo].[MPxTP]  WITH NOCHECK ADD  CONSTRAINT [FK_MPxTP_tipomateriaprima] FOREIGN KEY([idmp])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[MPxTP] CHECK CONSTRAINT [FK_MPxTP_tipomateriaprima]
GO
/****** Objeto:  ForeignKey [FK_MPxTP_tipoparte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MPxTP_tipoparte]') AND parent_object_id = OBJECT_ID(N'[dbo].[MPxTP]'))
ALTER TABLE [dbo].[MPxTP]  WITH NOCHECK ADD  CONSTRAINT [FK_MPxTP_tipoparte] FOREIGN KEY([nombre])
REFERENCES [dbo].[tipoparte] ([nombre])
GO
ALTER TABLE [dbo].[MPxTP] CHECK CONSTRAINT [FK_MPxTP_tipoparte]
GO
/****** Objeto:  ForeignKey [FK_operacion_gradodificultad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_operacion_gradodificultad]') AND parent_object_id = OBJECT_ID(N'[dbo].[operacion]'))
ALTER TABLE [dbo].[operacion]  WITH NOCHECK ADD  CONSTRAINT [FK_operacion_gradodificultad] FOREIGN KEY([idgradodificultad])
REFERENCES [dbo].[gradodificultad] ([idgradodificultad])
GO
ALTER TABLE [dbo].[operacion] CHECK CONSTRAINT [FK_operacion_gradodificultad]
GO
/****** Objeto:  ForeignKey [FK_operacion_tipomaquina]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_operacion_tipomaquina]') AND parent_object_id = OBJECT_ID(N'[dbo].[operacion]'))
ALTER TABLE [dbo].[operacion]  WITH NOCHECK ADD  CONSTRAINT [FK_operacion_tipomaquina] FOREIGN KEY([maquina])
REFERENCES [dbo].[tipomaquina] ([nombre])
GO
ALTER TABLE [dbo].[operacion] CHECK CONSTRAINT [FK_operacion_tipomaquina]
GO
/****** Objeto:  ForeignKey [FK_pago_ordencompramp]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pago_ordencompramp]') AND parent_object_id = OBJECT_ID(N'[dbo].[pago]'))
ALTER TABLE [dbo].[pago]  WITH NOCHECK ADD  CONSTRAINT [FK_pago_ordencompramp] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[pago] CHECK CONSTRAINT [FK_pago_ordencompramp]
GO
/****** Objeto:  ForeignKey [FK_parte_tipofresa1]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parte_tipofresa1]') AND parent_object_id = OBJECT_ID(N'[dbo].[parte]'))
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipofresa1] FOREIGN KEY([idtipofresa], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipofresa1]
GO
/****** Objeto:  ForeignKey [FK_parte_tipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parte_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[parte]'))
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipomateriaprima]
GO
/****** Objeto:  ForeignKey [FK_parte_tipoparte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parte_tipoparte]') AND parent_object_id = OBJECT_ID(N'[dbo].[parte]'))
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipoparte] FOREIGN KEY([nombre])
REFERENCES [dbo].[tipoparte] ([nombre])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipoparte]
GO
/****** Objeto:  ForeignKey [FK_parteadicional_modelofresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parteadicional_modelofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[parteadicional]'))
ALTER TABLE [dbo].[parteadicional]  WITH NOCHECK ADD  CONSTRAINT [FK_parteadicional_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[parteadicional] CHECK CONSTRAINT [FK_parteadicional_modelofresa]
GO
/****** Objeto:  ForeignKey [FK_partepedido_parteadicional]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_partepedido_parteadicional]') AND parent_object_id = OBJECT_ID(N'[dbo].[partepedido]'))
ALTER TABLE [dbo].[partepedido]  WITH NOCHECK ADD  CONSTRAINT [FK_partepedido_parteadicional] FOREIGN KEY([idadicional], [idmodelo])
REFERENCES [dbo].[parteadicional] ([idadicional], [idmodelo])
GO
ALTER TABLE [dbo].[partepedido] CHECK CONSTRAINT [FK_partepedido_parteadicional]
GO
/****** Objeto:  ForeignKey [FK_partepedido_Pedido]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_partepedido_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[partepedido]'))
ALTER TABLE [dbo].[partepedido]  WITH NOCHECK ADD  CONSTRAINT [FK_partepedido_Pedido] FOREIGN KEY([idpedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[partepedido] CHECK CONSTRAINT [FK_partepedido_Pedido]
GO
/****** Objeto:  ForeignKey [FK_Pedido_cliente]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_cliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_cliente]
GO
/****** Objeto:  ForeignKey [FK_Pedido_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_empleado] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_empleado]
GO
/****** Objeto:  ForeignKey [FK_Pedido_empresatransporte]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_empresatransporte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_empresatransporte] FOREIGN KEY([idempresa])
REFERENCES [dbo].[empresatransporte] ([idempresa])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_empresatransporte]
GO
/****** Objeto:  ForeignKey [FK_Pedido_estado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_estado]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_estado] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_estado]
GO
/****** Objeto:  ForeignKey [FK_Pedido_formadeentrega]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_formadeentrega]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_formadeentrega] FOREIGN KEY([idformadeentrega])
REFERENCES [dbo].[formadeentrega] ([idformadeentrega])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_formadeentrega]
GO
/****** Objeto:  ForeignKey [FK_perfil_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_perfil_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[perfil]'))
ALTER TABLE [dbo].[perfil]  WITH NOCHECK ADD  CONSTRAINT [FK_perfil_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[perfil] CHECK CONSTRAINT [FK_perfil_empleado]
GO
/****** Objeto:  ForeignKey [FK_presupuesto_cliente]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_presupuesto_cliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[presupuesto]'))
ALTER TABLE [dbo].[presupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_presupuesto_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[presupuesto] CHECK CONSTRAINT [FK_presupuesto_cliente]
GO
/****** Objeto:  ForeignKey [FK_presupuesto_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_presupuesto_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[presupuesto]'))
ALTER TABLE [dbo].[presupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_presupuesto_empleado] FOREIGN KEY([idempleado])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[presupuesto] CHECK CONSTRAINT [FK_presupuesto_empleado]
GO
/****** Objeto:  ForeignKey [FK_proveedor_localidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_proveedor_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[proveedor]'))
ALTER TABLE [dbo].[proveedor]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedor_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_localidad]
GO
/****** Objeto:  ForeignKey [FK_proveedorxtipomateriaprima_proveedor]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_proveedorxtipomateriaprima_proveedor]') AND parent_object_id = OBJECT_ID(N'[dbo].[proveedorxtipomateriaprima]'))
ALTER TABLE [dbo].[proveedorxtipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] CHECK CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor]
GO
/****** Objeto:  ForeignKey [FK_proveedorxtipomateriaprima_tipomateriaprima]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_proveedorxtipomateriaprima_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[proveedorxtipomateriaprima]'))
ALTER TABLE [dbo].[proveedorxtipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] CHECK CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima]
GO
/****** Objeto:  ForeignKey [FK_tipofresa_modelofresa]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tipofresa_modelofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[tipofresa]'))
ALTER TABLE [dbo].[tipofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_tipofresa_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[tipofresa] CHECK CONSTRAINT [FK_tipofresa_modelofresa]
GO
/****** Objeto:  ForeignKey [FK_tipomateriaprima_unidaddemedida]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tipomateriaprima_unidaddemedida]') AND parent_object_id = OBJECT_ID(N'[dbo].[tipomateriaprima]'))
ALTER TABLE [dbo].[tipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_tipomateriaprima_unidaddemedida] FOREIGN KEY([idunidadmedida])
REFERENCES [dbo].[unidaddemedida] ([idunidadmedida])
GO
ALTER TABLE [dbo].[tipomateriaprima] CHECK CONSTRAINT [FK_tipomateriaprima_unidaddemedida]
GO
/****** Objeto:  ForeignKey [FK_torneado_tornero]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_torneado_tornero]') AND parent_object_id = OBJECT_ID(N'[dbo].[torneado]'))
ALTER TABLE [dbo].[torneado]  WITH NOCHECK ADD  CONSTRAINT [FK_torneado_tornero] FOREIGN KEY([idtornero])
REFERENCES [dbo].[tornero] ([idtornero])
GO
ALTER TABLE [dbo].[torneado] CHECK CONSTRAINT [FK_torneado_tornero]
GO
/****** Objeto:  ForeignKey [FK_viajantexlocalidad_empleado]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_viajantexlocalidad_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[viajantexlocalidad]'))
ALTER TABLE [dbo].[viajantexlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_viajantexlocalidad_empleado] FOREIGN KEY([idviajante])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[viajantexlocalidad] CHECK CONSTRAINT [FK_viajantexlocalidad_empleado]
GO
/****** Objeto:  ForeignKey [FK_viajantexlocalidad_localidad]    Fecha de la secuencia de comandos: 08/13/2007 21:57:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_viajantexlocalidad_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[viajantexlocalidad]'))
ALTER TABLE [dbo].[viajantexlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_viajantexlocalidad_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[viajantexlocalidad] CHECK CONSTRAINT [FK_viajantexlocalidad_localidad]
GO
