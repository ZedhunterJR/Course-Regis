CREATE TABLE [dbo].[table_student_course]
(
	[student_id] char(7) not null foreign key references table_user(id),
	[course_id] char(7) not null foreign key references table_course(id)
)
