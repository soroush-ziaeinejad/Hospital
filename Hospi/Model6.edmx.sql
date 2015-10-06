
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/30/2014 07:17:03
-- Generated from EDMX file: C:\Users\Soroush\documents\visual studio 2012\Projects\Hospi\Hospi\Model6.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Hospital];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Accountants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Accountants];
GO
IF OBJECT_ID(N'[dbo].[Ambulance_service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ambulance_service];
GO
IF OBJECT_ID(N'[dbo].[Ambulances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ambulances];
GO
IF OBJECT_ID(N'[dbo].[Appoinments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Appoinments];
GO
IF OBJECT_ID(N'[dbo].[Bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bills];
GO
IF OBJECT_ID(N'[dbo].[Carriers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carriers];
GO
IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO
IF OBJECT_ID(N'[dbo].[Doctors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctors];
GO
IF OBJECT_ID(N'[dbo].[Drivers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drivers];
GO
IF OBJECT_ID(N'[dbo].[Drugstore_Bill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drugstore_Bill];
GO
IF OBJECT_ID(N'[dbo].[Drugstore_cashier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drugstore_cashier];
GO
IF OBJECT_ID(N'[dbo].[Drugstores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drugstores];
GO
IF OBJECT_ID(N'[dbo].[Logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Logins];
GO
IF OBJECT_ID(N'[dbo].[Medicines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medicines];
GO
IF OBJECT_ID(N'[dbo].[Nurses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nurses];
GO
IF OBJECT_ID(N'[dbo].[Nursing_service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nursing_service];
GO
IF OBJECT_ID(N'[dbo].[Operations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operations];
GO
IF OBJECT_ID(N'[dbo].[Patients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patients];
GO
IF OBJECT_ID(N'[dbo].[Payments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payments];
GO
IF OBJECT_ID(N'[dbo].[Prescriptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prescriptions];
GO
IF OBJECT_ID(N'[dbo].[Receptionists]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receptionists];
GO
IF OBJECT_ID(N'[dbo].[Rooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rooms];
GO
IF OBJECT_ID(N'[dbo].[securities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[securities];
GO
IF OBJECT_ID(N'[dbo].[servants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[servants];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Tests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tests];
GO
IF OBJECT_ID(N'[dbo].[Warrants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Warrants];
GO
IF OBJECT_ID(N'[dbo].[Warrants1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Warrants1];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Accountants'
CREATE TABLE [dbo].[Accountants] (
    [Act_id] int  NOT NULL,
    [Act_name] nvarchar(max)  NULL,
    [Act_LName] nvarchar(50)  NULL,
    [Act_age] int  NULL,
    [working_time] time  NULL,
    [Address] nvarchar(max)  NULL,
    [mobile_number] nvarchar(max)  NULL,
    [National_Code] int  NULL,
    [Gender] nvarchar(50)  NULL,
    [IsLogin] binary(1)  NULL
);
GO

-- Creating table 'Ambulance_service'
CREATE TABLE [dbo].[Ambulance_service] (
    [AS_id] int  NOT NULL,
    [AS_time] time  NULL,
    [AS_date] datetime  NULL,
    [PID] int  NULL,
    [Amb_id] int  NULL,
    [Driver_id] int  NULL
);
GO

-- Creating table 'Ambulances'
CREATE TABLE [dbo].[Ambulances] (
    [Amb_ID] int  NOT NULL,
    [Amb_Number] int  NOT NULL,
    [isFree] binary(1)  NOT NULL
);
GO

-- Creating table 'Appoinments'
CREATE TABLE [dbo].[Appoinments] (
    [Ap_id] int  NOT NULL,
    [Ap_time] time  NULL,
    [Ap_date] datetime  NULL,
    [PID] int  NULL,
    [DID] int  NULL,
    [Rcp_id] int  NULL
);
GO

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [Bill_ID] int  NOT NULL,
    [Bill_Total] decimal(19,4)  NULL,
    [Bill_purpose] nchar(10)  NULL
);
GO

-- Creating table 'Carriers'
CREATE TABLE [dbo].[Carriers] (
    [Carrier_id] int  NOT NULL,
    [Salary] decimal(19,4)  NULL,
    [DeptID] int  NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Dept_ID] int  NOT NULL,
    [Dept_Name] nvarchar(max)  NULL,
    [Manager_ID] int  NULL
);
GO

-- Creating table 'Doctors'
CREATE TABLE [dbo].[Doctors] (
    [DID] int  NOT NULL,
    [Doc_name] nvarchar(max)  NULL,
    [Doc_Lname] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Gender] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [NationalCode] nvarchar(50)  NULL,
    [Specialization] nvarchar(max)  NULL,
    [Employment_date] datetime  NULL,
    [Salary] int  NULL,
    [Dept_ID] int  NULL,
    [IsLogin] binary(1)  NULL
);
GO

-- Creating table 'Drivers'
CREATE TABLE [dbo].[Drivers] (
    [Driver_id] int  NOT NULL,
    [Driver_name] nvarchar(max)  NULL,
    [Driver_number] nvarchar(50)  NULL,
    [Working_time] time  NULL,
    [salary] decimal(19,4)  NULL,
    [Amb_id] int  NULL
);
GO

-- Creating table 'Drugstore_Bill'
CREATE TABLE [dbo].[Drugstore_Bill] (
    [DS_Bill_id] int  NOT NULL,
    [DS_Bill_total] decimal(19,4)  NULL
);
GO

-- Creating table 'Drugstore_cashier'
CREATE TABLE [dbo].[Drugstore_cashier] (
    [DSC_id] int  NOT NULL,
    [DSC_name] nvarchar(max)  NULL,
    [salary] decimal(19,4)  NULL,
    [DSC_number] nvarchar(50)  NULL,
    [Working_shift] varchar(max)  NULL,
    [DS_id] int  NULL
);
GO

-- Creating table 'Drugstores'
CREATE TABLE [dbo].[Drugstores] (
    [DS_id] int  NOT NULL,
    [DS_name] nvarchar(max)  NULL,
    [DS_number] nvarchar(50)  NULL
);
GO

-- Creating table 'Logins'
CREATE TABLE [dbo].[Logins] (
    [LID] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [access] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Medicines'
CREATE TABLE [dbo].[Medicines] (
    [Mdcn_ID] int  NOT NULL,
    [Mdcn_Name] nvarchar(max)  NULL,
    [Company] nvarchar(max)  NULL,
    [m_date] datetime  NULL,
    [e_date] datetime  NULL,
    [Price] decimal(19,4)  NULL
);
GO

-- Creating table 'Nurses'
CREATE TABLE [dbo].[Nurses] (
    [NID] int  NOT NULL,
    [Nurse_name] nvarchar(50)  NULL,
    [Nurse_Lname] nvarchar(50)  NULL,
    [Birth_date] datetime  NULL,
    [City] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL,
    [Number] nvarchar(50)  NULL,
    [National_Code] nvarchar(50)  NULL,
    [Gender] nvarchar(10)  NULL,
    [Marrige] nvarchar(50)  NULL,
    [Employment_date] datetime  NULL,
    [Salary] int  NULL,
    [DeptID] int  NULL,
    [Shift] nvarchar(max)  NULL
);
GO

-- Creating table 'Nursing_service'
CREATE TABLE [dbo].[Nursing_service] (
    [NID] int  NOT NULL,
    [PID] int  NOT NULL,
    [RID] int  NOT NULL,
    [date] datetime  NULL,
    [time] time  NULL
);
GO

-- Creating table 'Operations'
CREATE TABLE [dbo].[Operations] (
    [op_id] int  NOT NULL,
    [op_date] datetime  NULL,
    [op_time] time  NULL,
    [op_room_number] int  NULL,
    [PID] int  NULL,
    [DID] int  NULL
);
GO

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [PID] int  NOT NULL,
    [Patient_Name] nvarchar(max)  NULL,
    [Disease_type] nvarchar(50)  NULL,
    [Date_of_Birth] datetime  NULL,
    [Phone_Number] nvarchar(max)  NULL,
    [Blood_Type] nvarchar(50)  NULL,
    [Weight] int  NULL,
    [Height] int  NULL,
    [Description] nvarchar(max)  NULL,
    [Gender] nvarchar(50)  NULL,
    [Address] nvarchar(max)  NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [pay_id] int  NOT NULL,
    [pay_type] nvarchar(max)  NOT NULL,
    [pay_date] datetime  NOT NULL
);
GO

-- Creating table 'Prescriptions'
CREATE TABLE [dbo].[Prescriptions] (
    [prs_id] int  NOT NULL,
    [date] datetime  NULL,
    [time] time  NULL,
    [PID] int  NULL,
    [DID] int  NULL,
    [Mdcn_ID] int  NULL
);
GO

-- Creating table 'Receptionists'
CREATE TABLE [dbo].[Receptionists] (
    [Rcp_id] int  NOT NULL,
    [RcpName] nvarchar(50)  NULL,
    [RcpLname] nvarchar(50)  NULL,
    [gender] nvarchar(50)  NULL,
    [national_code] nvarchar(50)  NULL,
    [Salary] int  NULL,
    [DeptID] int  NULL,
    [isLogin] binary(1)  NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [RID] int  NOT NULL,
    [Room_number] int  NULL,
    [type] nvarchar(max)  NULL,
    [DeptID] int  NULL,
    [Cost] decimal(19,4)  NULL
);
GO

-- Creating table 'securities'
CREATE TABLE [dbo].[securities] (
    [sec_ID] int  NOT NULL,
    [sec_name] nvarchar(max)  NULL,
    [sec_Lname] nvarchar(50)  NULL,
    [sec_number] nvarchar(50)  NULL,
    [Working_time] time  NULL,
    [salary] decimal(19,4)  NULL,
    [Dept_ID] nchar(10)  NULL,
    [national_code] nvarchar(50)  NULL
);
GO

-- Creating table 'servants'
CREATE TABLE [dbo].[servants] (
    [servant_id] int  NOT NULL,
    [servant_name] nvarchar(max)  NULL,
    [servant_Lname] nvarchar(50)  NULL,
    [servant_number] nvarchar(50)  NULL,
    [Working_time] nvarchar(50)  NULL,
    [salary] decimal(19,4)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [Test_id] int  NOT NULL,
    [Test_name] nchar(10)  NULL,
    [Test_date] datetime  NULL,
    [Test_cost] decimal(19,4)  NULL,
    [Reply_date] datetime  NULL
);
GO

-- Creating table 'Warrants'
CREATE TABLE [dbo].[Warrants] (
    [WID] int  NOT NULL,
    [Base_Salary] int  NULL,
    [Reg_Date] datetime  NULL,
    [LastChange] datetime  NULL,
    [Premium] int  NULL,
    [tax] float  NULL,
    [Premium_Sdate] datetime  NULL,
    [Premium_Fdate] datetime  NULL
);
GO

-- Creating table 'Warrants1'
CREATE TABLE [dbo].[Warrants1] (
    [WID] int  NOT NULL,
    [Base_Salary] int  NULL,
    [Reg_Date] datetime  NULL,
    [LastChange] datetime  NULL,
    [Premium] int  NULL,
    [tax] float  NULL,
    [Premium_Sdate] datetime  NULL,
    [Premium_Fdate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Act_id] in table 'Accountants'
ALTER TABLE [dbo].[Accountants]
ADD CONSTRAINT [PK_Accountants]
    PRIMARY KEY CLUSTERED ([Act_id] ASC);
GO

-- Creating primary key on [AS_id] in table 'Ambulance_service'
ALTER TABLE [dbo].[Ambulance_service]
ADD CONSTRAINT [PK_Ambulance_service]
    PRIMARY KEY CLUSTERED ([AS_id] ASC);
GO

-- Creating primary key on [Amb_ID] in table 'Ambulances'
ALTER TABLE [dbo].[Ambulances]
ADD CONSTRAINT [PK_Ambulances]
    PRIMARY KEY CLUSTERED ([Amb_ID] ASC);
GO

-- Creating primary key on [Ap_id] in table 'Appoinments'
ALTER TABLE [dbo].[Appoinments]
ADD CONSTRAINT [PK_Appoinments]
    PRIMARY KEY CLUSTERED ([Ap_id] ASC);
GO

-- Creating primary key on [Bill_ID] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([Bill_ID] ASC);
GO

-- Creating primary key on [Carrier_id] in table 'Carriers'
ALTER TABLE [dbo].[Carriers]
ADD CONSTRAINT [PK_Carriers]
    PRIMARY KEY CLUSTERED ([Carrier_id] ASC);
GO

-- Creating primary key on [Dept_ID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Dept_ID] ASC);
GO

-- Creating primary key on [DID] in table 'Doctors'
ALTER TABLE [dbo].[Doctors]
ADD CONSTRAINT [PK_Doctors]
    PRIMARY KEY CLUSTERED ([DID] ASC);
GO

-- Creating primary key on [Driver_id] in table 'Drivers'
ALTER TABLE [dbo].[Drivers]
ADD CONSTRAINT [PK_Drivers]
    PRIMARY KEY CLUSTERED ([Driver_id] ASC);
GO

-- Creating primary key on [DS_Bill_id] in table 'Drugstore_Bill'
ALTER TABLE [dbo].[Drugstore_Bill]
ADD CONSTRAINT [PK_Drugstore_Bill]
    PRIMARY KEY CLUSTERED ([DS_Bill_id] ASC);
GO

-- Creating primary key on [DSC_id] in table 'Drugstore_cashier'
ALTER TABLE [dbo].[Drugstore_cashier]
ADD CONSTRAINT [PK_Drugstore_cashier]
    PRIMARY KEY CLUSTERED ([DSC_id] ASC);
GO

-- Creating primary key on [DS_id] in table 'Drugstores'
ALTER TABLE [dbo].[Drugstores]
ADD CONSTRAINT [PK_Drugstores]
    PRIMARY KEY CLUSTERED ([DS_id] ASC);
GO

-- Creating primary key on [LID] in table 'Logins'
ALTER TABLE [dbo].[Logins]
ADD CONSTRAINT [PK_Logins]
    PRIMARY KEY CLUSTERED ([LID] ASC);
GO

-- Creating primary key on [Mdcn_ID] in table 'Medicines'
ALTER TABLE [dbo].[Medicines]
ADD CONSTRAINT [PK_Medicines]
    PRIMARY KEY CLUSTERED ([Mdcn_ID] ASC);
GO

-- Creating primary key on [NID] in table 'Nurses'
ALTER TABLE [dbo].[Nurses]
ADD CONSTRAINT [PK_Nurses]
    PRIMARY KEY CLUSTERED ([NID] ASC);
GO

-- Creating primary key on [NID], [PID], [RID] in table 'Nursing_service'
ALTER TABLE [dbo].[Nursing_service]
ADD CONSTRAINT [PK_Nursing_service]
    PRIMARY KEY CLUSTERED ([NID], [PID], [RID] ASC);
GO

-- Creating primary key on [op_id] in table 'Operations'
ALTER TABLE [dbo].[Operations]
ADD CONSTRAINT [PK_Operations]
    PRIMARY KEY CLUSTERED ([op_id] ASC);
GO

-- Creating primary key on [PID] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([PID] ASC);
GO

-- Creating primary key on [pay_id] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([pay_id] ASC);
GO

-- Creating primary key on [prs_id] in table 'Prescriptions'
ALTER TABLE [dbo].[Prescriptions]
ADD CONSTRAINT [PK_Prescriptions]
    PRIMARY KEY CLUSTERED ([prs_id] ASC);
GO

-- Creating primary key on [Rcp_id] in table 'Receptionists'
ALTER TABLE [dbo].[Receptionists]
ADD CONSTRAINT [PK_Receptionists]
    PRIMARY KEY CLUSTERED ([Rcp_id] ASC);
GO

-- Creating primary key on [RID] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([RID] ASC);
GO

-- Creating primary key on [sec_ID] in table 'securities'
ALTER TABLE [dbo].[securities]
ADD CONSTRAINT [PK_securities]
    PRIMARY KEY CLUSTERED ([sec_ID] ASC);
GO

-- Creating primary key on [servant_id] in table 'servants'
ALTER TABLE [dbo].[servants]
ADD CONSTRAINT [PK_servants]
    PRIMARY KEY CLUSTERED ([servant_id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Test_id] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([Test_id] ASC);
GO

-- Creating primary key on [WID] in table 'Warrants'
ALTER TABLE [dbo].[Warrants]
ADD CONSTRAINT [PK_Warrants]
    PRIMARY KEY CLUSTERED ([WID] ASC);
GO

-- Creating primary key on [WID] in table 'Warrants1'
ALTER TABLE [dbo].[Warrants1]
ADD CONSTRAINT [PK_Warrants1]
    PRIMARY KEY CLUSTERED ([WID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------