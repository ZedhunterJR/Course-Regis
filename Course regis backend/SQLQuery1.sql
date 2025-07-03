
update table_user 
set department_id = '000001d'
where id = 't43924';

update table_course set lecturer_id = 't43924' where 0 = 0;

select * from table_user

select * from table_student_course

select * from table_course

delete from table_course where 0 = 0;
insert into table_course
values ('a123456', '1', '3', '000001d', 10, 't280372', 1, 'meh'),
	('b123456', '2', '3', '000001d', 10, 't280372', 1, 'meh'),
	('c123456', '3', '3', '000001d', 10, 't280372', 1, 'meh'),
	('d123456', '4', '3', '000123a', 10, 't280372', 1, 'meh'),
	('e123456', '5', '3', '000123a', 10, 't280372', 1, 'meh'),
	('f123456', '6', '3', '000123a', 10, 't280372', 2, 'meh'),
	('g123456', '7', '3', '230012b', 10, 't280372', 2, 'meh'),
	('h123456', '8', '3', '230012b', 10, 't280372', 2, 'meh'),
	('j123456', '9', '3', '382322c', 10, 't280372', 2, 'meh'),
	('k123456', '10', '3', '382322c', 10, 't280372', 2, 'meh');

update table_user
set pfp = 
(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\kiana.png', Single_Blob) as img)
where id = 'k12345';

delete from table_course where 0 = 0;
delete from table_user where 0 = 0;
insert into table_user values
('b180800', 'Bronya Zaychik', '2000-8-18', 'Siberia', 'bronya@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\bronya.png', Single_Blob) as img),
	'CEO of Studio Reason. Buy our newest Arahato game.',
	'admin', '123456', '000001d'),
('t280372', 'Theresa Apocalypse', '1972-3-28', 'Europe', 'theresa@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\theresa.png', Single_Blob) as img),
	'Schickal overseer, principal of St. Freya.',
	'faculty', '123456', '000001d'),
('h170690', 'Himeko Murata', '1990-6-17', 'Siberia', 'himeko@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\himeko.png', Single_Blob) as img),
	'St. Freya instructor, definitely not alcoholic.',
	'lecturer', '123456', '000001d'),
('m130497', 'Raiden Mei', '1997-4-13', 'Japan', 'mei@worldserpent.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\mei.png', Single_Blob) as img),
	'Former Hersscher of Thunder. Also Kiana babysitter.',
	'lecturer', '123456', '000001d'),
('b010198', 'Bianka Ataegina', '1998-1-1', 'Japan', 'durandal@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\bianka.png', Single_Blob) as img),
	'Its a pleasure to meet you.',
	'lecturer', '123456', '000001d'),
('e111100', 'Elysia', '1000-11-11', 'Vladivostok 51, Previous Era', 'misspinkelf@worldserpent.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\elysia.png', Single_Blob) as img),
	'Hello, I am a friendly elf. Nice to meet you.',
	'lecturer', '123456', '000001d'),
('k120798', 'Kiana Kaslana', '1998-12-7', 'Japan', 'kiana@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\kiana.png', Single_Blob) as img),
	'Goddess of Earth, Hersscher of the Void, Hersscher of Finality, Hersscher of Flamecsion',
	'student', '123456', '230012b'),
('c230803', 'Carole Pepper', '2004-8-23', 'Europe', 'carole@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\carole.png', Single_Blob) as img),
	'Nice to meet you!',
	'student', '123456', '230012b'),
('g211200', 'Griseo', '1000-12-21', 'Mu, Previous Era', 'griseo@worldserpent.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\griseo.png', Single_Blob) as img),
	'Nice to meet you! What is your color?',
	'student', '123456', '230012b'),
('l040381', 'Li Shushang', '1481-4-3', 'Shenzou', 'shushang@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\li.png', Single_Blob) as img),
	'I think I pressed something I should not have...',
	'student', '123456', '230012b'),
('l280300', 'Luna Kindred', '1000-3-28', 'Sapphire City', 'luna@hyperion.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\luna.png', Single_Blob) as img),
	'Hello, can I meet Theresa?',
	'student', '123456', '382322c'),
('m000000', 'Misteln Schariac', null, 'Siberia', 'misteln@worldserpent.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\misteln.png', Single_Blob) as img),
	'This world sure is curious...',
	'student', '123456', '000123a'),
('p000000', 'Prometheus', null, 'Previous Era', 'no17@worldserpent.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\no17.png', Single_Blob) as img),
	'Yes, I am an AI. No. 17 - Prometheus at your service.',
	'student', '123456', '000123a'),
('s181020', 'Seele Vollerei', '2000-10-18', 'Estonia', 'seele@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\seele_0.png', Single_Blob) as img),
	'Nice to meet you.',
	'student', '123456', '382322c'),
('v181020', 'Seele Vollerei', '2000-10-18', 'Estonia', 'veliona@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\seele_1.png', Single_Blob) as img),
	'Do not talk to me. Talk to other me instead.',
	'student', '123456', '382322c'),
('l230600', 'Sirin', '1000-6-23', 'Lone Star city', 'sirin@hyperion.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\luna.png', Single_Blob) as img),
	'I am not short!',
	'student', '123456', '382322c'),
('s291000', 'Susannah Manatt', '2000-10-29', 'West Asia', 'susannah@schickal.org', 
	(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\susannah.png', Single_Blob) as img),
	'Nice to meet you!',
	'student', '123456', '000123a')

insert into table_department
values ('000001d', 'General', 'meh', null),
	('000123a', 'Natural Science' , 'meh', null),
	('230012b', 'Social Science', 'meh', null),
	('382322c', 'Physical Ed', 'meh', null);

delete from table_student_course where 0 = 0;

select * from table_student_course;
select * from table_department;
select * from appdata;

insert into appdata
values (1, '000001d', 
(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\PSY_29.png', Single_Blob) as img),
(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\MECH_29.png', Single_Blob) as img),
(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\IMG_29.png', Single_Blob) as img),
(select * FROM Openrowset( Bulk 'C:\Users\Acer\Desktop\java crap\c#\ref img\QUA_29.png', Single_Blob) as img));

update appdata set current_term = 2 where 0 = 0

select table_course.*, table_department.name from table_course, table_department
where table_course.department_id = table_department.id and
(table_course.name like '%psy%' or table_department.name like '%psy%')

UPDATE table_department 
SET cover_p = (SELECT * FROM OPENROWSET(BULK 'C:\Users\Acer\Desktop\java crap\c#\ref img\PSY_29.png', SINGLE_BLOB) AS img)
WHERE id = '000001d';

UPDATE table_department 
SET cover_p = (SELECT * FROM OPENROWSET(BULK 'C:\Users\Acer\Desktop\java crap\c#\ref img\MECH_29.png', SINGLE_BLOB) AS img)
WHERE id = '000123a';

UPDATE table_department 
SET cover_p = (SELECT * FROM OPENROWSET(BULK 'C:\Users\Acer\Desktop\java crap\c#\ref img\IMG_29.png', SINGLE_BLOB) AS img)
WHERE id = '230012b';

UPDATE table_department 
SET cover_p = (SELECT * FROM OPENROWSET(BULK 'C:\Users\Acer\Desktop\java crap\c#\ref img\QUA_29.png', SINGLE_BLOB) AS img)
WHERE id = '382322c';