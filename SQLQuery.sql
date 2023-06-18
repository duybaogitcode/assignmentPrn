create database CoffeeManagement
go

use CoffeeManagement
go

create table TableCoffee
(
	ID nvarchar(50) primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	Status bit not null default 0
)

create table AccountType
(
	ID nvarchar(50) primary key,
	TypeName nvarchar(50) not null
)
go

create table Account
(
	UserName varchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Name',
	Password varchar(500) not null default 0,
	TypeID nvarchar(50) not null

	foreign key (TypeID) references AccountType(ID)
)
go

create table CategoryFood
(
	ID nvarchar(50) not null primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên'
)
go

create table Food
(
	ID nvarchar(50) primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	CategoryID nvarchar(50) not null,
	Price int not null default 0

	foreign key (CategoryID) references CategoryFood(id)
)
go

create table Bill
(
	ID nvarchar(50) primary key,
	CheckIn Date not null default GETDATE(),
	CheckOut Date,
	TableID nvarchar(50) not null,
	Discount int not null default 0,
	TotalPrice int default 0,
	Status int not null default 0 -- 1: Da thanh toan, 0: Chua thanh toan

	foreign key (TableID) references TableCoffee(ID)
)
go

create table BillInfo
(
	ID int identity primary key,
	BillID nvarchar(50) not null,
	FoodID nvarchar(50) not null,
	Amount int not null default 0

	foreign key (BillID) references Bill(ID),
	foreign key (FoodID) references Food(ID)
)
go

