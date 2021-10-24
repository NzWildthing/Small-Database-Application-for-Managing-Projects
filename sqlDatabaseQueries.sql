use bj54_Deliverable2;

drop table workson;
drop table task;
drop table programmer;
drop table manage;
drop table project;
drop table customer;
drop table manager;


create table customer(

username varchar(32) not null,
password varchar(32),
fname  varchar(32),
lname varchar(32),
email varchar(32),
phone varchar(13),
addressline1 varchar(32),
addressline2 varchar(32),
addressline3 varchar(32),
bankaccount decimal,
primary key(username))

insert into customer values('cpilbrow', 'Q!e3R$5tY^', 'Colin', 'Pilbrow', 'cpilbrow@waikato.ac.nz', '', '220 Seddul Bahr Road', 'Akatarawa', 'Upper Hutt', 8588268673); 
insert into customer values('anna', 'password', 'Anna', 'Smith', 'annasmith@gmail.com', '755-2099', '42 Ngaio Street', 'Macandrew Bay', 'Dunedin', 8524546400912);
insert into customer values('bob', '123456', 'Bob', 'Johnson', 'bobby@gmail.com', '634-5789', '', '', '', 10266563210016        
);
insert into customer values('clint', 'picture1', 'Clint', 'Brown', 'browner@hotmail.com', '867-5309', '131 Forres Street', 'Aramoho', 'Wanganui', 684915015503483        
);
insert into customer values('dave', 'qwerty', 'Dave', 'Jones', 'dj123@students.waikato.ac.nz', '', '', '', '', 419534544        
);
insert into customer values('emma', 'abc123', 'Emma', 'Miller', 'emabc123@yahoo.com', '273-9164', '168 Seddon Road', 'Waikato Hospital', 'Hamilton', 329906149290        
);

create table manager(

username varchar(32) not null,
password varchar(32),
fname varchar(32),
lname varchar(32),
DOB date,
salary decimal,
phone varchar(15),
addressline1 varchar(32),
addressline2 varchar(32),
addressline3 varchar(32),
primary key(username))

insert into manager values('swu', 'uws', 'Shaoqun', 'Wu', null , null, '4782', 'The University of Waikato', 'Te Whare Wananga o Waikato', 'Gate 1, Knighton Road');
insert into manager values('nilesh', 'million2', 'Nilesh', 'Kanji', null , null, '5047', 'The University of Waikato', 'Te Whare Wananga o Waikato', 'Gate 1, Knighton Road');
insert into manager values('admin', 'admin', 'Admin', 'Admin', null , null, '', '1 Admin Road', 'Admin', 'Admin');


create table project(

projectid int not null,
title varchar(MAX),
startdate date,
enddate date,
status varchar(32),
budget decimal,
description varchar(MAX),
username varchar(32),
primary key(projectid),
foreign key(username) references customer)

insert into project values(1, 'Attention: Database', '2021-01-01', NULL, 'development', 10000,	'Video game', 'Bob');
insert into project values(2, 'Essential Database Smartphone App','2021-01-02', NULL, 'development', 200000,	'All in one application', 'Anna');
insert into project values(3, 'Database Adventures','2020-02-06', '2021-04-15', 'live', 5200, 'VRMMO', 'Bob');
insert into project values(4, 'Database Expert Interview', '2019-04-10', '2020-06-06', 'complete', 30,	'Interview with university students', 'Dave');
insert into project values(5, 'COMPX223 Project', '2020-03-01', NULL, 'development', 0,	'What youre doing now', 'cpilbrow');
insert into project values(6, 'Database Iphone App','2019-04-25', '2020-08-24', 'complete', 123000,	'The essential database app ported to iPhone', 'Anna');
insert into project values(7, 'Database May Not Exist!', '2020-06-01', NULL, 'testing', 999999,	'Unknown', 'Clint');
insert into project values(8, 'The Philosophy Of Database', '2019-09-26', '2020-12-27', 'testing', 1000000,	'We have no idea what this is but the client is paying heaps for it', 'Emma');
insert into project values(9, 'Warning: Database', '2018-12-25', '2019-01-04', 'shutdown', 100,	'Video game', 'Bob');

create table manage(

projectid int not null, 
username varchar(32) not null,
primary key(projectid, username),
foreign key(projectid) references project, 
foreign key(username) references manager)

insert into manage values(1, 'swu');
insert into manage values(2, 'swu');
insert into manage values(3, 'nilesh');
insert into manage values(4, 'swu');
insert into manage values(4, 'nilesh');
insert into manage values(5, 'swu');
insert into manage values(6, 'swu');
insert into manage values(6, 'nilesh');
insert into manage values(7, 'nilesh');
insert into manage values(8, 'nilesh');
insert into manage values(9, 'swu');

create table programmer(

username varchar(32) not null,
password varchar(32),
fname varchar(32),
lname varchar(32),
DOB date,
salary decimal,
phone varchar(15),
addressline1 varchar(32),
addressline2 varchar(32),
addressline3 varchar(32),
primary key(username))

insert into programmer values('jk1234', 'lol', 'jack', 'hughes', '1998-12-25', 54524543, '0201232111', '12 down pl', 'bethlehem', 'tauranga');
insert into programmer values('jooms', 'crypto$#%', 'netsky', 'wilky', '1995-10-13', 90, '233456532', '12 fame rd', 'bristol', 'United Kingdom');
insert into programmer values('andyamc', 'willmavvsburnzy', 'sublime', 'turno', '1967-02-05', 5432535342535234, '543254352', '567 private yard', 'princeton', 'madagascar');

create table task(

taskid int not null,
description varchar(32),
priority varchar(32),
startdate date,
completeddate date,
name varchar(32),
projectid int,
primary key(taskid),
foreign key(projectid) references project)

insert into task values(1, 'my first task', 'very important', '2019-10-30', '2020-10-30', 'test', 3);
insert into task values(2, 'my second task', 'slightly important', '2019-11-20', '2020-11-20', 'thetask', 1);
insert into task values(3, 'my third task', 'hardly important', '2019-12-30', '2020-12-10', 'bigone', 2);
insert into task values(4, 'nah im done now', 'not important', '2020-01-01', '2020-01-02', 'netsky', 6);
insert into task values(5, 'or am i', 'chill', '2020-02-02', '2020-02-03', 'thebigdayout', 8);
insert into task values(6, 'my sixth task', 'extremely important', '2020-10-31', '2020-10-31', 'awn', 3);
insert into task values(7, 'nah ceebs now', 'low', '2021-01-02', '2021-01-04', 'dayforit', 7);
insert into task values(8, 'a very big project ', 'high', '2021-02-24', '2021-05-05', 'compxisawn', 1);
insert into task values(9, 'big things coming', 'medium', '2021-03-30', NULL, 'chemical', 9);
insert into task values(10, 'apology', 'medium', '2021-05-30', NULL, 'bread', 4);

create table workson(

taskid int not null,
username varchar(32) not null,
primary key(taskid, username),
foreign key(taskid) references task,
foreign key(username) references programmer)

insert into workson values(3, 'jooms');
insert into workson values(4, 'jk1234');
insert into workson values(9, 'jk1234');
insert into workson values(10, 'andyamc');
insert into workson values(1, 'jooms');
insert into workson values(5, 'jooms');
insert into workson values(7, 'jooms');
insert into workson values(8, 'andyamc');
insert into workson values(2, 'andyamc');
insert into workson values(6, 'andyamc');

select projectid from manage where username like 'nilesh' AND
			EXISTS (select title from project
			WHERE projectid like projectid);

select projectid 
from manage
where manage.projectid in (select projectid
							from project 
							where title = 'Warning:Database');

select * from customer;
select * from manager;
select * from project;
select * from manage;
select * from programmer;
select * from workson;
select * from task;



