IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Contracts_Customers') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Contracts DROP CONSTRAINT FK_Contracts_Customers;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Contracts_Quarters') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Contracts DROP CONSTRAINT FK_Contracts_Quarters;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Quarters_Tenements') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Quarters DROP CONSTRAINT FK_Quarters_Tenements;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Contracts') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Sales DROP CONSTRAINT FK_Sales_Contracts;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Customers') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Sales DROP CONSTRAINT FK_Sales_Customers;

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('FK_Sales_Quarters') AND OBJECTPROPERTY(id, 'IsForeignKey') = 1)
ALTER TABLE Sales DROP CONSTRAINT FK_Sales_Quarters;


IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Contracts') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Contracts;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Customers') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Customers;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Quarters') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Quarters;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Sales') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Sales;

IF EXISTS (SELECT * FROM dbo.SYSOBJECTS WHERE id = object_id('Tenements') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
DROP TABLE Tenements;




CREATE TABLE Contracts ( 
	ContractId long identity(300000,1)  NOT NULL,
	Sn nvarchar(30),
	Type int,
	SigningDate datetime,
	CustomerId long,
	QuartersId long
);

CREATE TABLE Customers ( 
	Id long identity(200000,1)  NOT NULL,
	Name nvarchar(20) NOT NULL,
	Address nvarchar(60),
	Tel nvarchar(20)
);

CREATE TABLE Quarters ( 
	QuartersId long identity(500000,1)  NOT NULL,
	Model int,
	BuiltUpArea real,
	MarketPrice money,
	Doorplate nvarchar(30),
	Property int,
	Code nvarchar(20),
	Quantity int,
	TenementId long
);

CREATE TABLE Sales ( 
	SaleId long identity(400000,1)  NOT NULL,
	SalePrice money,
	PayingDate datetime,
	Deposit money,
	DepositDate datetime,
	Cjk money,
	Cjmj real,
	Cjts int,
	Cjyy real,
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
	QuartersId long,
	ContractId long,
	CustomerId long
);

CREATE TABLE Tenements ( 
	Id long identity(100000,1)  NOT NULL,
	Name nvarchar(20) NOT NULL
);


ALTER TABLE Contracts ADD CONSTRAINT PK_Contracts 
	PRIMARY KEY CLUSTERED (ContractId);

ALTER TABLE Customers ADD CONSTRAINT PK_Customers 
	PRIMARY KEY CLUSTERED (Id);

ALTER TABLE Quarters ADD CONSTRAINT PK_Quarters 
	PRIMARY KEY CLUSTERED (QuartersId);

ALTER TABLE Sales ADD CONSTRAINT PK_Sales 
	PRIMARY KEY CLUSTERED (SaleId);

ALTER TABLE Tenements ADD CONSTRAINT PK_Tenements 
	PRIMARY KEY CLUSTERED (Id);




ALTER TABLE Contracts ADD CONSTRAINT FK_Contracts_Customers 
	FOREIGN KEY (CustomerId) REFERENCES Customers (Id);

ALTER TABLE Contracts ADD CONSTRAINT FK_Contracts_Quarters 
	FOREIGN KEY (QuartersId) REFERENCES Quarters (QuartersId);

ALTER TABLE Quarters ADD CONSTRAINT FK_Quarters_Tenements 
	FOREIGN KEY (TenementId) REFERENCES Tenements (Id);

ALTER TABLE Sales ADD CONSTRAINT FK_Sales_Contracts 
	FOREIGN KEY (ContractId) REFERENCES Contracts (ContractId);

ALTER TABLE Sales ADD CONSTRAINT FK_Sales_Customers 
	FOREIGN KEY (CustomerId) REFERENCES Customers (Id);

ALTER TABLE Sales ADD CONSTRAINT FK_Sales_Quarters 
	FOREIGN KEY (QuartersId) REFERENCES Quarters (QuartersId);
