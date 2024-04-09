CREATE TABLE [dbo].[Clients]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](50) NOT NULL, 
    [LastName] [varchar](100) NULL, 
    [Mail] [varchar](100) NULL, 
    [CreateDate] [datetime] NULL, 
    [UpdateDate] [datetime] NULL, 
    [Active] [bit] NOT NULL DEFAULT 1
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

