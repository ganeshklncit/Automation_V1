CREATE TABLE tbllogin (Personid int IDENTITY(1,1) PRIMARY KEY, userid varchar(255) NOT NULL, password varchar(255), status int);

insert into tbllogin values ('admin','admin',1);

create table tblcompany (id int, companyname varchar(255) not null, status int);

create table tblcontract (contractid int, contactname varchar(255), emailid varchar(150), amount float, agreement int, 
documentupload int, createdat smalldatetime,updatedat smalldatetime, status int);

create table tblcontractdetails (contractdetailsid int, contractid int, contractselected varchar(100), 
createdat smalldatetime,updatedat smalldatetime, status int);

create table tblcontractdocument (contractdetailsid int, contractid int, documentid int,documenturl varchar(255),
createdat smalldatetime,updatedat smalldatetime, status int);