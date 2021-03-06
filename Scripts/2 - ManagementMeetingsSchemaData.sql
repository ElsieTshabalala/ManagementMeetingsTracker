USE [Management_Meetings]
GO
/****** Object:  Schema [Meeting]    Script Date: 2018/09/06 07:57:14 ******/
CREATE SCHEMA [Meeting]
GO
/****** Object:  Table [Meeting].[Meeting]    Script Date: 2018/09/06 07:57:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Meeting].[MeetingItem]    Script Date: 2018/09/06 07:57:14 ******/
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
/****** Object:  Table [Meeting].[MeetingItemStatus]    Script Date: 2018/09/06 07:57:14 ******/
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
/****** Object:  Table [Meeting].[MeetingType]    Script Date: 2018/09/06 07:57:14 ******/
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
SET IDENTITY_INSERT [Meeting].[Meeting] ON 

GO
INSERT [Meeting].[Meeting] ([MeetingId], [MeetingTypeId], [MeetingNumber], [StartDate], [CreatedDate], [CreatedBy]) VALUES (1, 1, NULL, CAST(N'2018-10-20T14:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [Meeting].[Meeting] OFF
GO
SET IDENTITY_INSERT [Meeting].[MeetingType] ON 

GO
INSERT [Meeting].[MeetingType] ([MeetingTypeId], [MeetingTypeCode], [MeetingType], [Description]) VALUES (1, NULL, N'MANCO', NULL)
GO
INSERT [Meeting].[MeetingType] ([MeetingTypeId], [MeetingTypeCode], [MeetingType], [Description]) VALUES (2, NULL, N'FINANCE', NULL)
GO
INSERT [Meeting].[MeetingType] ([MeetingTypeId], [MeetingTypeCode], [MeetingType], [Description]) VALUES (3, NULL, N'Project Team Leaders', NULL)
GO
SET IDENTITY_INSERT [Meeting].[MeetingType] OFF
GO
/****** Object:  Index [UQ__Meeting__D161C3E29645EF16]    Script Date: 2018/09/06 07:57:14 ******/
ALTER TABLE [Meeting].[Meeting] ADD  CONSTRAINT [UQ__Meeting__D161C3E29645EF16] UNIQUE NONCLUSTERED 
(
	[MeetingTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
