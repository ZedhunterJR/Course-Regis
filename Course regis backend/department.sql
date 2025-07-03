CREATE TABLE [dbo].[table_department]
(
	[id] char(7) NOT NULL PRIMARY KEY,
	[name] char(50),
	[description] char(100), 
    [cover_p] VARBINARY(MAX) NULL,
)
