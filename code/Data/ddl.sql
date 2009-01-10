IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Contracts_Customers') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Contracts DROP CONSTRAINT FK_Contracts_Customers;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Contracts_Quarters') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Contracts DROP CONSTRAINT FK_Contracts_Quarters;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Quarters_Tenements') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Quarters DROP CONSTRAINT FK_Quarters_Tenements;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Contracts') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Sales DROP CONSTRAINT FK_Sales_Contracts;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Customers') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Sales DROP CONSTRAINT FK_Sales_Customers;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Quarters') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE TVMS_Sales DROP CONSTRAINT FK_Sales_Quarters;


IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('TVMS_Contracts') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Contracts;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('TVMS_Customers') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Customers;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('TVMS_Quarters') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Quarters;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('TVMS_Sales') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Sales;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('TVMS_Tenements') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE TVMS_Tenements;




CREATE TABLE TVMS_Contracts ( 
	ContractId int identity(300000,1)  NOT NULL,
	Sn nvarchar(30),
	ContractType int,
	SigningDate datetime,
	CustomerId int,
	QuartersId int
);

CREATE TABLE TVMS_Customers ( 
	CustomerId int identity(200000,1)  NOT NULL,
	Name nvarchar(20) NOT NULL,
	Address nvarchar(60),
	Tel nvarchar(20)
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
	ContractId int,
	CustomerId int
);

CREATE TABLE TVMS_Tenements ( 
	TenementId int identity(100000,1)  NOT NULL,
	Name nvarchar(20) NOT NULL
);


ALTER TABLE TVMS_Contracts ADD CONSTRAINT PK_Contracts 
	PRIMARY KEY CLUSTERED (ContractId);

ALTER TABLE TVMS_Customers ADD CONSTRAINT PK_Customers 
	PRIMARY KEY CLUSTERED (CustomerId);

ALTER TABLE TVMS_Quarters ADD CONSTRAINT PK_Quarters 
	PRIMARY KEY CLUSTERED (QuartersId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT PK_Sales 
	PRIMARY KEY CLUSTERED (SaleId);

ALTER TABLE TVMS_Tenements ADD CONSTRAINT PK_Tenements 
	PRIMARY KEY CLUSTERED (TenementId);




ALTER TABLE TVMS_Contracts ADD CONSTRAINT FK_Contracts_Customers 
	FOREIGN KEY (CustomerId) REFERENCES TVMS_Customers (CustomerId);

ALTER TABLE TVMS_Contracts ADD CONSTRAINT FK_Contracts_Quarters 
	FOREIGN KEY (QuartersId) REFERENCES TVMS_Quarters (QuartersId);

ALTER TABLE TVMS_Quarters ADD CONSTRAINT FK_Quarters_Tenements 
	FOREIGN KEY (TenementId) REFERENCES TVMS_Tenements (TenementId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT FK_Sales_Contracts 
	FOREIGN KEY (ContractId) REFERENCES TVMS_Contracts (ContractId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT FK_Sales_Customers 
	FOREIGN KEY (CustomerId) REFERENCES TVMS_Customers (CustomerId);

ALTER TABLE TVMS_Sales ADD CONSTRAINT FK_Sales_Quarters 
	FOREIGN KEY (QuartersId) REFERENCES TVMS_Quarters (QuartersId);
