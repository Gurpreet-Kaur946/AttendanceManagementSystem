create table MstTeacher(
	TeacherId int,
	TeacherName varchar(20),
	class varchar(5),
	sub varchar(20), 
);
insert into MstTeacher(TeacherId,TeacherName,class,sub) values (1,'akanksha','2nd','english');
insert into MstTeacher(TeacherId,TeacherName,class,sub) values (2,'sumit','5th','hindi');
insert into MstTeacher(TeacherId,TeacherName,class,sub) values (3,'shalini','4th','science');
select * from MstTeacher
create table MstStud(
	StudId int,
	StudName varchar(20),
	class varchar(5),
	sub varchar(20),
	TeacherName varchar(20),
);
insert into MstStud(StudId,StudName,class,sub,TeacherName) values (200,'aman','2nd','english','akanksha')
insert into MstStud(StudId,StudName,class,sub,TeacherName) values (201,'neha','5th','hindi','sumit')
insert into MstStud(StudId,StudName,class,sub,TeacherName) values (202,'simran','4th','science','shalini')
select * from MstTeacher



create table attendance(
	StudId int,
	StudName varchar(20),
	class varchar(5),
	sub varchar(20),
	TeacherName varchar(20),
	attendStts char(1),
	DateDay date,
);
insert into attendance values(201,'neha','5th','hindi','sumit','P','2019-02-12')
insert into attendance values(202,'simran','4th','science','shalini','A','2019-02-13')
select * from attendance