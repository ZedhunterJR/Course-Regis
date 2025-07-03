CREATE TABLE [dbo].[table_course]
(
	[id] char(7) NOT NULL PRIMARY KEY,
	[name] char(50),
	[credit] int,
	[department_id] char(7) foreign key references table_department(id),
	[entry_limit] int,
	[lecturer_id] char(7) foreign key references table_user(id),
	[term_num] int, 
    [des] CHAR(100) NULL,
)
