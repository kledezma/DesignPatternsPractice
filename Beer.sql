USE [Testing]
GO

/****** Object:  Table [dbo].[Beer]    Script Date: 8/20/2025 10:29:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Beer](
	[BeerId] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Style] [varchar](50) NOT NULL,
	[BrandId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Beer] PRIMARY KEY CLUSTERED 
(
	[BeerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Beer] ADD  CONSTRAINT [DF_Beer_BeerId]  DEFAULT (newid()) FOR [BeerId]
GO

ALTER TABLE [dbo].[Beer]  WITH CHECK ADD  CONSTRAINT [FK_Beer_Brand] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brand] ([BrandId])
GO

ALTER TABLE [dbo].[Beer] CHECK CONSTRAINT [FK_Beer_Brand]
GO

