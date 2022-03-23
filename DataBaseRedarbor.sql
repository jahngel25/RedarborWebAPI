CREATE DATABASE [Redarbor]
GO
USE [Redarbor]
GO
CREATE TABLE [ROLE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NULL,
	[UpdatedOn] [datetime] NULL	
CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [STATUS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NULL,
	[UpdatedOn] [datetime] NULL	
CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [COMPANY](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NULL,
	[UpdatedOn] [datetime] NULL	
CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [PORTAL](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NULL,
	[UpdatedOn] [datetime] NULL	
CONSTRAINT [PK_Potal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [EMPLOYEE] (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NULL,
	[Email] [varchar](100) NOT NULL,
	[Fax] [varchar](15) NULL,
	[Name] [varchar](100) NOT NULL,
	[Lastlogin] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[PortalId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[Telephone] [varchar](15) NOT NULL,
	[UpdatedOn] [datetime] NULL,
	[Username] [varchar](100) NOT  NULL
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeCompany] FOREIGN KEY([CompanyId])
REFERENCES [COMPANY] ([Id])
GO
ALTER TABLE [EMPLOYEE] CHECK CONSTRAINT [FK_EmployeeCompany]

GO

ALTER TABLE [EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeRole] FOREIGN KEY([RoleId])
REFERENCES [ROLE] ([Id])
GO
ALTER TABLE [EMPLOYEE] CHECK CONSTRAINT [FK_EmployeeRole]

GO
ALTER TABLE [EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeStatus] FOREIGN KEY([StatusId])
REFERENCES [STATUS] ([Id])
GO
ALTER TABLE [EMPLOYEE] CHECK CONSTRAINT [FK_EmployeeStatus]

GO
ALTER TABLE [EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePortal] FOREIGN KEY([PortalId])
REFERENCES [PORTAL] ([Id])
GO
ALTER TABLE [EMPLOYEE] CHECK CONSTRAINT [FK_EmployeePortal]
GO
INSERT INTO [dbo].[COMPANY] VALUES ('Computrabajo',GETDATE(), NULL, NULL)
INSERT INTO [dbo].[PORTAL] VALUES ('Redarbor 1', GETDATE(), NULL, NULL)
INSERT INTO [dbo].[ROLE] VALUES ('Admin', GETDATE(), NULL, NULL)
INSERT INTO [dbo].[STATUS] VALUES ('Activo', GETDATE(), NULL, NULL)
GO
CREATE Procedure Sp_Empleado_Delete
@Id				Int
AS
	DELETE FROM [EMPLOYEE]
	WHERE [Id] = @Id
GO
CREATE PROCEDURE Sp_Employee_Filter
@Id INT
AS
	SELECT 
		[Id],
		[CompanyId],
		[CreatedOn],
		[DeletedOn],
		[Email],
		[Fax],
		[Name],
		[Lastlogin],
		[Password],
		[PortalId],
		[RoleId],
		[StatusId],
		[Telephone],
		[UpdatedOn],
		[Username]					
	FROM [EMPLOYEE]
	WHERE [Id] = @Id
GO
CREATE PROCEDURE Sp_Employee_List
AS
	SELECT 
		[Id],
		[CompanyId],
		[CreatedOn],
		[DeletedOn],
		[Email],
		[Fax],
		[Name],
		[Lastlogin],
		[Password],
		[PortalId],
		[RoleId],
		[StatusId],
		[Telephone],
		[UpdatedOn],
		[Username]
	FROM [EMPLOYEE]
GO
CREATE PROCEDURE Sp_Employee_Register
@CompanyId int,
@CreatedOn datetime,
@DeletedOn datetime,
@Email varchar(100),
@Fax varchar(15),
@Name varchar(100),
@Lastlogin varchar(100),
@Password varchar(100),
@PortalId int,
@RoleId int,
@StatusId int,
@Telephone varchar(15),
@UpdatedOn datetime,
@Username varchar(100)
AS
 
	INSERT INTO [EMPLOYEE]
	(
		[CompanyId],
		[CreatedOn],
		[DeletedOn],
		[Email],
		[Fax],
		[Name],
		[Lastlogin],
		[Password],
		[PortalId],
		[RoleId],
		[StatusId],
		[Telephone],
		[UpdatedOn],
		[Username]	
	)
	VALUES
	(
		@CompanyId,
		@CreatedOn,
		@DeletedOn,
		@Email,
		@Fax,
		@Name,
		@Lastlogin,
		@Password,
		@PortalId,
		@RoleId,
		@StatusId,
		@Telephone,
		@UpdatedOn,
		@Username							
	)
GO
GO
CREATE PROCEDURE Sp_Employee_Update
@Id int,
@CompanyId int,
@CreatedOn datetime,
@DeletedOn datetime,
@Email varchar(100),
@Fax varchar(15),
@Name varchar(100),
@Lastlogin varchar(100),
@Password varchar(100),
@PortalId int,
@RoleId int,
@StatusId int,
@Telephone varchar(15),
@UpdatedOn datetime,
@Username varchar(100)
AS
 
	UPDATE [EMPLOYEE]
	SET
		[CompanyId] = @CompanyId,
		[CreatedOn] = @CreatedOn,
		[DeletedOn] = @DeletedOn,
		[Email] = @Email,
		[Fax] = @Fax,
		[Name] = @Name,
		[Lastlogin] = @Lastlogin,
		[Password] = @Password,
		[PortalId] = @PortalId,
		[RoleId] = @RoleId,
		[StatusId] = @StatusId,
		[Telephone] = @Telephone,
		[UpdatedOn] = @UpdatedOn,
		[Username] = @Username
	WHERE [Id] = @Id
GO