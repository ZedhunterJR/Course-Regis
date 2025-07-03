CREATE TABLE [dbo].[table_user]
(
	[id] char(7) NOT NULL PRIMARY KEY,
	[name] char(50),
	[dob] date,
	[pob] char(50),
	[email] char(50),
	[pfp] VARBINARY(MAX),
	[des] char(200),
	[user_role] char(20),
	[password] char(20),
	[department_id] char(7) foreign key references table_department(id)
)
