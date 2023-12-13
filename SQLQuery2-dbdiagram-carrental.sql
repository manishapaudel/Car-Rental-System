create table login(
logid int primary key identity(1,1),
username nvarchar(200),
password nvarchar(200),
)
 create table customer(
customerid int primary key identity(1,1),
name nvarchar(200),
gender varchar(50),
contact nvarchar(200),
address varchar(200),
citizenshipid varchar(200),
logid int references login(logid),
)
create table location(
locid int primary key identity(1,1),
name nvarchar(200),
address nvarchar(200)
)
create table car(

locid int references location(locid),
carid int primary key identity(1,1),
carname nvarchar(200),
carbrand nvarchar(100),
carmodel nvarchar(100),
features nvarchar(200),
price real
)
create table scheme(
schemeid int primary key identity(1,1),
hourly nvarchar(200),
daily nvarchar(200),
monthly nvarchar(100),
yearly nvarchar(10)
)
create table payment(
carid int references car(carid),
paymentid int primary key identity(1,1),
name nvarchar(200),
discount real,
advance real,
totalamount real,
billdate date,
fine real,
schemeid int references scheme(schemeid),
)

create table rentalorder(
customerid int references customer(customerid),
orderid int primary key identity(1,1),
carid int references car(carid),
rentstartdate date,
rentenddate date,
booktype nvarchar(200)
)
create table admin(
logid int references login(logid),
adminid int primary key identity(1,1),
adname nvarchar(200),
address nvarchar(200),
contact nvarchar(15)
)


