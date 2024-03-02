
create table Person(
	Id int primary key,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Birthdate date,
	Address nvarchar(150)
);

create table User(
	Id nvarchar(70) Primary key,
	Email nvarchar(150),
	Password nvarchar(80),
	PersonId int,
	constraint users_person_Fk Foreign key (PersonId) references Person(Id)
);

create table Client(
	Id int primary key,
	UserId nvarchar(70),
	Identification nvarchar(13)
	constraint client_users_FK foreign key(UserId) references User(Id)
);

create table Service(
	Id int primary key,
	ServiceName nvarchar(120),
	Mbps numeric(18,2)
	Price numeric(18,2)
);

create table Contract(
	Id int primary key,
	ContractDate date,
	ClientId int,
	IsVigent bit,
	ServiceId int
	constraint contract_client_FK foreign key(ClientId) references Client(Id),
	constraint contract_services_FK foreign key(ServiceId) references Service(Id)
);

create table OperationType(
	Id int primary key,
	Type nvarchar(50)
);

create table Cash(
	Id int primary key,
	CashDescription nvarchar(50),
	UserId nvarchar(70),
	constraint cash_users_FK foreign key(users_userid) references User(Id)
);

create table Operation(
	Id int primary key,
	OperationDate date,
	OperationTypeId int,
	CashId int,
	ClientId int,
	constraint operations_operationtype_FK foreign key(OperationTypeId) references OperationType(Id),
	constraint operations_cash_FK foreign key(CashId) references Cash(Id),
	constraint operations_client_FK foreign key(ClientId) references Client(Id)
);


create table PaymentMethod(
	Id int primary key,
	TypePaymentMethod nvarchar(50)
);

create table PaymentDetail(
	Id int,
	PaymentDate date,
	PaymentValue numeric(18,2),
	PaymentId int,
	PaymentMethodId int,
	constraint paymentdetail_payment_FK foreign key(PaymentId) references payment(paymentid),
	constraint paymentdetail_paymentmethod_FK foreign key(PaymentMethodId) references PaymentMethod(Id)
);

create table Payment(
	Id int primary key,
	MaxPaymentDate date,
	ClientId int
	constraint payment_client_FK foreign key(ClientId) references Client(Id)
);

