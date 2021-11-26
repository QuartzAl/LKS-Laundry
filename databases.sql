CREATE TABLE Job(
Id int identity(1, 1) primary key,
Name varchar(50) not null);


CREATE TABLE Category(
Id int identity(1, 1) primary key,
Name varchar(50) not null);


CREATE TABLE Customer(
Id int identity(1, 1) primary key,
Name varchar(50) not null,
Phonenumber varchar(20) not null,
Address varchar(200) not null,);


CREATE TABLE Unit(
Id int identity(1, 1) primary key,
Name varchar(50) not null);


CREATE TABLE Employee(
Id int identity(1, 1) primary key,
Password varchar(50) not null,
Name varchar(50) not null,
Email varchar(50),
Address varchar(200) not null,
PhoneNumber varchar(20) not null,
DateOfBirth date not null,
IdJob int not null foreign key references Job(Id),
Salary money not null);


CREATE TABLE HeaderDeposit(
Id int identity(1, 1) primary key,
Idcustomer int not null foreign key references Customer(Id),
Idemployee int not null foreign key references Employee(Id),
TransactionDatetime datetime not null,
CompleteEstimationDatetime datetime);

CREATE TABLE Service(	
Id int identity(1, 1) primary key,
Name varchar(50) not null,
IdCategory int not null foreign key references Category(Id),
IdUnit int not null foreign key references Unit(Id),
PriceUnit int not null,
EstimationDuration int not null);

CREATE TABLE Package(
Id int identity(1, 1) primary key,
IdService int not null foreign key references Service(Id),
Totalunit int not null,
Price int not null);

CREATE TABLE PrepaidPackage(
Id int identity(1, 1) primary key,
IdCustomer int not null foreign key references Customer(Id),
IdPackage int not null foreign key references Package(Id),
Price int not null,
StartDatetime datetime not null,
CompletedDatetime datetime);

CREATE TABLE DetailDeposit(
Id int identity(1, 1) primary key,
IdDeposit int not null foreign key references HeaderDeposit(Id),
IdService int not null foreign key references Service(Id),
IdPrepaidPackage int foreign key references PrepaidPackage(Id),
PriceUnit int not null,
TotalUnit float not null,
CompletedDatetime datetime);