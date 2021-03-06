USE [MYDB1]
GO

/****** Object:  Table [dbo].[UserTable]    Script Date: 2020-06-24 오후 3:28:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserTable](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](7) NOT NULL,
 CONSTRAINT [PK_TB_Users_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

