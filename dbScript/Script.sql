--Create database TMS_V1

IF EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID('[User]')) 
BEGIN
	DROP TABLE [User]
END
CREATE TABLE [dbo].[User](
	[userId] [bigint] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](100) NOT NULL,
	[firstName] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[password] [nvarchar](500) NOT NULL,
	[role] [nvarchar](20) NULL,
	[createdOn] [datetime] NULL,
	[createdBy] [nvarchar](100) NULL,
	[updatedOn] [datetime] NULL,
	[updatedBy] [nvarchar](100) NULL,
	[isActive] [bit] NULL,	
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] OFF 
GO
INSERT [dbo].[User] ([userName], [password], [role], [createdOn], [createdBy], [updatedOn], [updatedBy], [isActive], [firstName], [email]) 
VALUES (N'superadmin', N'2AOs9z85GWuQlmL2qJwH5daSGT61ouXNmsnmQXFqjd4=', N'Admin', GETDATE(), N'sumit.patel', NULL, NULL, 1, 'admin', 'sumitpatel4988@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
