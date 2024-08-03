CREATE TABLE tbllogin (Personid int IDENTITY(1,1) PRIMARY KEY, userid varchar(255) NOT NULL, password varchar(255), status int);

insert into tbllogin values ('admin','admin',1);