USE [Management_Meetings]
GO
/****** Object:  Schema [Meeting]    Script Date: 2018/09/06 07:56:09 ******/
CREATE SCHEMA [Meeting]
GO
/****** Object:  Table [Meeting].[Meeting]    Script Date: 2018/09/06 07:56:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Meeting].[Meeting](
	[MeetingId] [int] IDENTITY(1,1) NOT NULL,
	[MeetingTypeId] [int] NOT NULL,
	[MeetingNumber] [int] NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_Meeting] PRIMARY KEY CLUSTERED 
(
	[MeetingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Meeting__D161C3E29645EF16] UNIQUE NONCLUSTERED 
(
	[MeetingTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Meeting].[MeetingItem]    Script Date: 2018/09/06 07:56:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Meeting].[MeetingItem](
	[MeetingItemId] [int] IDENTITY(1,1) NOT NULL,
	[MeetingId] [int] NOT NULL,
	[ActionBy] [varchar](50) NOT NULL,
	[MeetingItemStatusId] [int] NOT NULL,
	[MeetingItem] [varchar](255) NOT NULL,
	[Remark] [varchar](255) NULL,
 CONSTRAINT [PK_MeetingItem] PRIMARY KEY CLUSTERED 
(
	[MeetingItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Meeting].[MeetingItemStatus]    Script Date: 2018/09/06 07:56:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Meeting].[MeetingItemStatus](
	[MeetigItemStatusId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](255) NOT NULL,
 CONSTRAINT [PK_MeetingItemStatus] PRIMARY KEY CLUSTERED 
(
	[MeetigItemStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Meeting].[MeetingType]    Script Date: 2018/09/06 07:56:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Meeting].[MeetingType](
	[MeetingTypeId] [int] IDENTITY(1,1) NOT NULL,
	[MeetingTypeCode] [varchar](50) NULL,
	[MeetingType] [varchar](50) NOT NULL,
	[Description] [varchar](255) NULL,
 CONSTRAINT [PK_MeetingType] PRIMARY KEY CLUSTERED 
(
	[MeetingTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [Meeting].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_MeetingType] FOREIGN KEY([MeetingTypeId])
REFERENCES [Meeting].[MeetingType] ([MeetingTypeId])
GO
ALTER TABLE [Meeting].[Meeting] CHECK CONSTRAINT [FK_Meeting_MeetingType]
GO
ALTER TABLE [Meeting].[MeetingItem]  WITH CHECK ADD  CONSTRAINT [FK_MeetingItem_Meeting] FOREIGN KEY([MeetingId])
REFERENCES [Meeting].[Meeting] ([MeetingId])
GO
ALTER TABLE [Meeting].[MeetingItem] CHECK CONSTRAINT [FK_MeetingItem_Meeting]
GO
ALTER TABLE [Meeting].[MeetingItem]  WITH CHECK ADD  CONSTRAINT [FK_MeetingItem_MeetingItemStatus] FOREIGN KEY([MeetingItemStatusId])
REFERENCES [Meeting].[MeetingItemStatus] ([MeetigItemStatusId])
GO
ALTER TABLE [Meeting].[MeetingItem] CHECK CONSTRAINT [FK_MeetingItem_MeetingItemStatus]
GO
