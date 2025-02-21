CREATE TABLE tbllogin (Personid int IDENTITY(1,1) PRIMARY KEY, userid varchar(255) NOT NULL, password varchar(255), status int);

insert into tbllogin values ('admin','admin',1);

create table tblcompany (id int, companyname varchar(255) not null, status int);

create table tblcontract (contractid int, contactname varchar(255), emailid varchar(150), amount float, agreement int, 
documentupload int, createdat smalldatetime,updatedat smalldatetime, status int);

create table tblcontractdetails (contractdetailsid int, contractid int, contractselected varchar(100), 
createdat smalldatetime,updatedat smalldatetime, status int);

create table tblcontractdocument (contractdocumentid int, contractid int not null, documenttype varchar(255),documenturl varchar(255),document varbinary(max) not null, 
createdat smalldatetime,updatedat smalldatetime, status int);

alter table tblcontract add companyid int