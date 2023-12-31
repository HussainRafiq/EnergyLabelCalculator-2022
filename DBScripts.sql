USE [EnergyCalculator]
GO
/****** Object:  Table [dbo].[CompanyTable]    Script Date: 08/08/2021 7:12:29 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NULL,
	[CompanyLogo] [varchar](max) NULL,
	[IsDeleted] [int] NULL,
 CONSTRAINT [PK_CompanyTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GenericInformation]    Script Date: 08/08/2021 7:12:30 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenericInformation](
	[ParameterKey] [varchar](100) NOT NULL,
	[Value] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/08/2021 7:12:30 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NULL,
	[Role] [nvarchar](50) NULL,
	[CompanyID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[Email] ASC,
	[IsDeleted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Hussain_Fiver].[Token]    Script Date: 08/08/2021 7:12:30 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Hussain_Fiver].[Token](
	[Token] [nvarchar](100) NULL,
	[UserID] [int] NULL,
	[IsDeleted] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CompanyTable] ON 

INSERT [dbo].[CompanyTable] ([ID], [CompanyName], [CompanyLogo], [IsDeleted]) VALUES (1, N'Charity Wise', N'IMAGES\CompanyLogo_CharityWise\d0a74655-cc01-4a44-b091-8886e941d331_Screenshot_20210731-170818_Chrome.jpg', 1)
INSERT [dbo].[CompanyTable] ([ID], [CompanyName], [CompanyLogo], [IsDeleted]) VALUES (2, N'Charity Wise', N'IMAGES\CompanyLogo_CharityWise\18e38bb5-d0bc-441d-80ae-14e9b6c9a813_charity_logo_peview-.jpg', 0)
SET IDENTITY_INSERT [dbo].[CompanyTable] OFF
INSERT [dbo].[GenericInformation] ([ParameterKey], [Value]) VALUES (N'AverageElectric', N'65')
INSERT [dbo].[GenericInformation] ([ParameterKey], [Value]) VALUES (N'AverageGas', N'30')
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [Password], [Role], [CompanyID], [CreatedAt], [IsDeleted]) VALUES (1, N'ADMIN', N'', N'ADMIN@GMAIL.COM', N'1234', N'Admin', NULL, NULL, 0)
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [Password], [Role], [CompanyID], [CreatedAt], [IsDeleted]) VALUES (2, N'farooq', N'ahmad', N'farooq.ahmad35202@gmail.com', N'Look123?', N'User', 2, CAST(N'2021-08-08T18:11:44.100' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'c9aa8faf-6f77-4460-b049-d0b001cd1af0', 2, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'4b16ad17-c7d3-43d1-a883-0d4e072c49ea', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'6cf5f266-d34e-404b-8091-d6a72da811eb', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'9b3fce9d-e03e-4265-9938-8d2f666e8bdd', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'9a68f075-1db1-421e-8078-6dc510c98c29', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'0196e010-a537-4097-9d84-b27ec9187942', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'f8ed2433-f4e4-4db2-98dd-4e17790e3313', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'7552f50f-c820-48ff-9461-ca3a1af1ea4e', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'85672fda-c3a7-4506-b0c4-3b4f0971b4b4', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'6ab423df-dbc8-435d-899b-0539306c1369', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'6b5eaf47-5052-4274-a9ce-69dcee0ad782', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'3b2d4b55-6aab-4423-98b0-124053c63809', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'905f1387-e6b2-496a-9adb-ba55b7015522', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'7ae70821-de3e-4a1e-8e8a-867b4eb0967f', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'4a916567-152a-48b1-b340-1fbbb1c60520', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'a6cb3395-222a-451f-93dd-947a10b6bbf2', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'4ea61611-c25f-4cf0-b08d-b3ecaf030464', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'b0d4c1dd-2d6c-438c-8181-e94495b45322', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'224305fe-c1e7-4691-9819-b7ac3b2251f9', 2, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'dbd812cf-3138-47a9-8a4c-1d5db78686c4', 3, 0)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'7cbc74cf-d61f-4833-a010-ce7a0139fb8b', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'2b49a9c8-7afe-4a1f-9af4-d0e8e32815bf', 3, 1)
INSERT [Hussain_Fiver].[Token] ([Token], [UserID], [IsDeleted]) VALUES (N'75961ed7-0fba-4811-b1cd-4c12729bcab5', 2, 1)
/****** Object:  StoredProcedure [dbo].[DeleteCompany]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteCompany]
	@ID INT
AS
BEGIN
	
UPDATE CompanyTable SET IsDeleted=1 WHERE ID=@ID
SELECT @ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteUser]
	@ID INT
AS
BEGIN
	
UPDATE Users SET IsDeleted=1 WHERE ID=@ID
SELECT @ID
END
GO
/****** Object:  StoredProcedure [dbo].[GetCompany]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCompany]
	
AS
BEGIN
	Select ID,CompanyName,CompanyLogo from CompanyTable Where IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[GetGenericValue]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetGenericValue]

AS
BEGIN
	
	SELECT * from GenericInformation
END
GO
/****** Object:  StoredProcedure [dbo].[GetToken]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetToken]
@Token NVARCHAR(100)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM Token WHERE Token=@Token and isDeleted=0

   
END
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetUser]
 @ID int,
 @Email varchar(100),
 @Role varchar(100),
 @CompanyID int

AS
BEGIN
	SELECT U.*,C.CompanyName,C.CompanyLogo FROM Users U
	lEFT JOIN CompanyTable C ON C.ID=U.CompanyID
	WHERE U.ID=COALESCE(@ID,U.ID) AND U.Email=COALESCE(@Email,U.Email) AND U.[Role]=COALESCE(@Role,U.[Role]) AND(U.CompanyID IS Null OR U.CompanyID=COALESCE(@CompanyID,U.CompanyID)) AND U.IsDeleted=0
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCompany]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertCompany]
@CompanyTitle nvarchar(100),
@CompanyLogo  nvarchar(max)
AS
BEGIN
	INSERT INTO CompanyTable (CompanyName,CompanyLogo,IsDeleted) VALUES(@CompanyTitle,@CompanyLogo,0)
	SELECT SCOPE_IDENTITY(); 
END
GO
/****** Object:  StoredProcedure [dbo].[InsertToken]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertToken]
@Token NVARCHAR(100),
@UserID INT
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO Token VALUES(@Token,@UserID,0)

   
END
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertUser]
@ID int,
@FirstName nvarchar(100),
@LastName nvarchar(100),
@Email nvarchar(100),
@Password nvarchar(100),
@Role nvarchar(100),
@CompanyID INT
	
AS
BEGIN
   if(@ID IS NULL)
   BEGIN
   IF NOT EXISTS(SELECT * FROM Users WHERE Email=@Email)
   BEGIN
  	Insert into Users ([FirstName],[LastName],[Email],[Password],[Role],[CompanyID],[CreatedAt],[IsDeleted]) 
	values(@FirstName,@LastName,@Email,@Password,@Role,@CompanyID,GETDATE(),0)
	SELECT SCOPE_IDENTITY()
   END
   END
   ELSE
   BEGIN
   UPDATE Users SET FirstName=COALESCE(@FirstName,FirstName),LastName=COALESCE(@LastName,LastName),Email=COALESCE(@Email,Email),[Password]=COALESCE(@Password,[Password]),CompanyID=COALESCE(@CompanyID,CompanyID) WHERE ID=@ID
   SELECT @ID
   END
END
GO
/****** Object:  StoredProcedure [dbo].[RedeemedToken]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RedeemedToken]
@UserID NVARCHAR(100)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE Token SET IsDeleted=1 where UserID=@UserID
   
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateGenericVlaue]    Script Date: 08/08/2021 7:12:33 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateGenericVlaue]
	@AverageElectric int,
	@AverageGas int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE GenericInformation set [Value]=@AverageElectric WHERE [ParameterKey]='AverageElectric'
	UPDATE GenericInformation set [Value]=@AverageGas WHERE [ParameterKey]='AverageGas'
	SELECT 1
END
GO
