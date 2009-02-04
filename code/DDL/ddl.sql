IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Glossary_Glossary') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Glossary DROP CONSTRAINT FK_Glossary_Glossary;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Quarters_Tenements') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Quarters DROP CONSTRAINT FK_Quarters_Tenements;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Customers') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Sales DROP CONSTRAINT FK_Sales_Customers;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Employees') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Sales DROP CONSTRAINT FK_Sales_Employees;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Quarters') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Sales DROP CONSTRAINT FK_Sales_Quarters;


IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Customers') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Customers;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Employees') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Employees;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Glossary') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Glossary;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Quarters') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Quarters;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Sales') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Sales;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Tenements') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Tenements;




CREATE TABLE TVMS_Customers ( 
	CustomerId int identity(200000,1)  NOT NULL,
	Name nvarchar(20) NOT NULL,
	Address nvarchar(60),
	Tel nvarchar(20)
);

CREATE TABLE TVMS_Employees ( 
	EmployeeId int identity(300000,1)  NOT NULL,
	Name nvarchar(20),
	HireDate datetime,
	Tel nvarchar(20),
	Address nvarchar(60)
);

CREATE TABLE TVMS_Glossary ( 
	TermId int identity(900000,1)  NOT NULL,
	TermKey nvarchar(20),
	TermValue nvarchar(50),
	ParentTermId int
);

CREATE TABLE TVMS_Quarters ( 
	QuartersId int identity(500000,1)  NOT NULL,
	Model int,
	BuiltUpArea float,
	MarketPrice money,
	Doorplate nvarchar(30),
	Property int,
	Code nvarchar(20),
	Quantity int,
	TenementId int
);

CREATE TABLE TVMS_Sales ( 
	SaleId int identity(400000,1)  NOT NULL,
	ContractSn nvarchar(30),
	ContractType int,
	ContractSigningDate datetime,
	SalePrice money,
	PayingDate datetime,
	Deposit money,
	DepositDate datetime,
	Cjk money,
	Cjmj float,
	Cjts int,
	Cjyy float,
	Imprest1 money,
	Imprest1Date datetime,
	Imprest1State int,
	Imprest2 money,
	Imprest2Date datetime,
	Imprest2State int,
	Imprest3 money,
	Imprest3Date datetime,
	Imprest3State int,
	Imprest4 money,
	Imprest4Date datetime,
	Imprest4State int,
	Imprest5 money,
	Imprest5Date datetime,
	Imprest5State int,
	Remark nvarchar(100),
	QuartersId int,
	CustomerId int,
	EmployeeId int
);

CREATE TABLE TVMS_Tenements ( 
	TenementId int identity(100000,1)  NOT NULL,
	Name nvarchar(20) NOT NULL
);


ALTER TABLE TVMS_Customers ADD CONSTRAINT PK_Customers 
	PRIMARY KEY CLUSTERED (CustomerId);

ALTER TABLE TVMS_Employees ADD CONSTRAINT PK_Employees 
	PRIMARY KEY CLUSTERED (EmployeeId);

ALTER TABLE TVMS_Glossary ADD CONSTRAINT PK_Glossary 
	PRIMARY KEY CLUSTERED (TermId);

ALTER TABLE TVMS_Quarters ADD CONSTRAINT PK_Quarters 
	PRIMARY KEY CLUSTERED (QuartersId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT PK_Sales 
	PRIMARY KEY CLUSTERED (SaleId);

ALTER TABLE TVMS_Tenements ADD CONSTRAINT PK_Tenements 
	PRIMARY KEY CLUSTERED (TenementId);




ALTER TABLE TVMS_Glossary ADD CONSTRAINT FK_Glossary_Glossary 
	FOREIGN KEY (ParentTermId) REFERENCES TVMS_Glossary (TermId);

ALTER TABLE TVMS_Quarters ADD CONSTRAINT FK_Quarters_Tenements 
	FOREIGN KEY (TenementId) REFERENCES TVMS_Tenements (TenementId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT FK_Sales_Customers 
	FOREIGN KEY (CustomerId) REFERENCES TVMS_Customers (CustomerId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT FK_Sales_Employees 
	FOREIGN KEY (EmployeeId) REFERENCES TVMS_Employees (EmployeeId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT FK_Sales_Quarters 
	FOREIGN KEY (QuartersId) REFERENCES TVMS_Quarters (QuartersId);
