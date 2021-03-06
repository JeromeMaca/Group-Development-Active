USE [master]
GO
/****** Object:  Database [agrikulto]    Script Date: 06/21/2016 16:54:40 ******/
CREATE DATABASE [agrikulto] ON  PRIMARY 
( NAME = N'agrikulto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\agrikulto.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'agrikulto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\agrikulto_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [agrikulto] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [agrikulto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [agrikulto] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [agrikulto] SET ANSI_NULLS OFF
GO
ALTER DATABASE [agrikulto] SET ANSI_PADDING OFF
GO
ALTER DATABASE [agrikulto] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [agrikulto] SET ARITHABORT OFF
GO
ALTER DATABASE [agrikulto] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [agrikulto] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [agrikulto] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [agrikulto] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [agrikulto] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [agrikulto] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [agrikulto] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [agrikulto] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [agrikulto] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [agrikulto] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [agrikulto] SET  DISABLE_BROKER
GO
ALTER DATABASE [agrikulto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [agrikulto] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [agrikulto] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [agrikulto] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [agrikulto] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [agrikulto] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [agrikulto] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [agrikulto] SET  READ_WRITE
GO
ALTER DATABASE [agrikulto] SET RECOVERY FULL
GO
ALTER DATABASE [agrikulto] SET  MULTI_USER
GO
ALTER DATABASE [agrikulto] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [agrikulto] SET DB_CHAINING OFF
GO
USE [agrikulto]
GO
/****** Object:  Table [dbo].[tbl_ais_useraccesslist_maintenance]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_useraccesslist_maintenance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maintenace_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_useraccesslist_maintenance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ais_user_account]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_user_account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[user_lname] [varchar](50) NOT NULL,
	[user_fname] [varchar](50) NOT NULL,
	[user_mname] [varchar](50) NOT NULL,
	[type_index] [int] NULL,
	[user_type] [varchar](50) NOT NULL,
	[who_save] [varchar](50) NULL,
	[save_date] [datetime] NULL,
	[who_modify] [varchar](50) NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_user_account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_user_account] ON
INSERT [dbo].[tbl_ais_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (1, N'admin', N'DwN1hMmef9T0+MWVUPj1Bw==', N'Maca', N'Jerome', N'Ber', 1, N'ADMINISTRATOR', N'JEROME MACA', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_user_account] OFF
/****** Object:  Table [dbo].[tbl_ais_trip_ticket_schedule_hdr]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_trip_ticket_schedule_hdr](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reg_no] [bigint] NOT NULL,
	[trip_ticket_no] [bigint] NOT NULL,
	[trip_date] [datetime] NOT NULL,
	[owner_equip] [varchar](50) NULL,
	[equip_type] [varchar](50) NOT NULL,
	[equip_no] [varchar](50) NOT NULL,
	[owner_imple] [varchar](50) NULL,
	[imple_desc] [varchar](50) NOT NULL,
	[imple_code] [varchar](50) NOT NULL,
	[driver] [varchar](50) NOT NULL,
	[purpose] [varchar](max) NOT NULL,
	[need_date] [datetime] NOT NULL,
	[need_time] [time](7) NOT NULL,
	[requested_by] [varchar](50) NOT NULL,
	[approved_by] [varchar](50) NOT NULL,
	[equip_timeout] [time](7) NULL,
	[equip_timein] [time](7) NULL,
	[jobsite_arrival_time] [time](7) NULL,
	[jobsite_departure_time] [time](7) NULL,
	[remarks] [varchar](max) NULL,
	[work_accepted_by] [varchar](50) NULL,
	[noted_by] [varchar](50) NULL,
	[jtmo_no] [nvarchar](50) NULL,
	[check_jtmo_by] [varchar](50) NULL,
	[status] [int] NULL,
	[create_date] [datetime] NULL,
	[modify_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
	[accomplished_date] [datetime] NULL,
	[posted_date] [datetime] NULL,
	[user_id] [int] NULL,
	[accomplished_by] [varchar](50) NULL,
	[posted_by] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_ais_trip_ticket_schedule_hdr] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_schedule_hdr] ON
INSERT [dbo].[tbl_ais_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (1, 1, 1, CAST(0x0000A62C00000000 AS DateTime), N'AGRIKULTO INC.', N'TRACTOR', N'TW25 - 001', N'AGRIKULTO INC.', N'AGRIKULTO BI HARROW - 1', N'ABH - 1', N'JEROME MACA', N'DC', CAST(0x0000A62D00000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'Maca, Jerome Ber', N'Maca, Jerome Ber', CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), N'', N'', N'', N'', N'', 0, CAST(0x0000A62C0105AFEA AS DateTime), NULL, NULL, NULL, NULL, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_schedule_hdr] OFF
/****** Object:  Table [dbo].[tbl_ais_trip_ticket_schedule_dtl]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_trip_ticket_schedule_dtl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hdr_id] [int] NOT NULL,
	[lot_no] [varchar](50) NOT NULL,
	[time_started] [time](7) NULL,
	[time_stopped] [time](7) NULL,
	[operate_hours] [time](7) NULL,
	[work_operation] [varchar](50) NOT NULL,
	[area_done] [decimal](19, 3) NULL,
	[rate_per_area] [decimal](19, 2) NULL,
	[amount] [decimal](19, 2) NULL,
	[location] [varchar](50) NOT NULL,
	[current_area] [decimal](19, 3) NOT NULL,
	[soill_type] [varchar](50) NOT NULL,
	[date_planted] [datetime] NOT NULL,
	[ownership] [varchar](50) NOT NULL,
	[lot_owner_name] [varchar](50) NOT NULL,
	[association_desc] [varchar](50) NOT NULL,
	[variety] [varchar](50) NOT NULL,
	[fiscal_year] [varchar](50) NOT NULL,
	[dtl_stats] [int] NULL,
	[created_date] [datetime] NULL,
	[modify_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
	[driver_id] [int] NULL,
	[equip_id] [int] NULL,
	[imple_id] [int] NULL,
	[post_status] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_ais_trip_ticket_schedule_dtl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_schedule_dtl] ON
INSERT [dbo].[tbl_ais_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (1, 1, N'TABLANG001', NULL, NULL, NULL, N'DISC CULTIVATION', NULL, NULL, NULL, N'TABLANG', CAST(2.000 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME MACA', N'ASUCAL', N'PLANT CANE', N'2016-2017', 0, CAST(0x0000A62C0105AFEA AS DateTime), NULL, NULL, 1, 2, 1, 0)
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_schedule_dtl] OFF
/****** Object:  Table [dbo].[tbl_ais_owner_name]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_owner_name](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_name] [int] NOT NULL,
	[owner_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_equipment_ownername] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_owner_name] ON
INSERT [dbo].[tbl_ais_owner_name] ([id], [id_name], [owner_name]) VALUES (1, 4, N'CENTRAL AZUCARERA DE TARLAC')
INSERT [dbo].[tbl_ais_owner_name] ([id], [id_name], [owner_name]) VALUES (2, 4, N'AGRIKULTO INC.')
INSERT [dbo].[tbl_ais_owner_name] ([id], [id_name], [owner_name]) VALUES (3, 4, N'JEROME MACADANGDANG')
SET IDENTITY_INSERT [dbo].[tbl_ais_owner_name] OFF
/****** Object:  Table [dbo].[tbl_ais_operation_category]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_operation_category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_desc] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_ais_operation_category] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_operation_category] ON
INSERT [dbo].[tbl_ais_operation_category] ([category_id], [cat_desc]) VALUES (1, N'LAND PREPARATION')
INSERT [dbo].[tbl_ais_operation_category] ([category_id], [cat_desc]) VALUES (2, N'CULTIVATION')
INSERT [dbo].[tbl_ais_operation_category] ([category_id], [cat_desc]) VALUES (3, N'PLANTING')
SET IDENTITY_INSERT [dbo].[tbl_ais_operation_category] OFF
/****** Object:  Table [dbo].[tbl_ais_main_useraccess_list]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_main_useraccess_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](45) NOT NULL,
	[hierarchy1] [int] NOT NULL,
	[hierarchy2] [int] NOT NULL,
	[hierarchy3] [int] NOT NULL,
	[hierarchy4] [int] NOT NULL,
	[can_add] [bit] NOT NULL,
	[can_edit] [bit] NOT NULL,
	[can_delete] [bit] NOT NULL,
	[can_cancel] [bit] NOT NULL,
	[can_print] [bit] NOT NULL,
	[can_edit_posted] [bit] NOT NULL,
	[hierarchy_end] [bit] NOT NULL,
	[frm_level1] [bit] NOT NULL,
	[frm_level2] [bit] NOT NULL,
 CONSTRAINT [pk_tbl_ais_tbl_ais_inv_useraccess_list] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_main_useraccess_list] ON
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (1, N'FILE', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (2, N'FARMING OPERATION', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (3, N'DATA MAINTENANCE', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (4, N'OPERATION MONITORING', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (5, N'USER CONTROL', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (6, N'PRINT REPORT', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (7, N'ABOUT', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (8, N'TRIP TICKET SCHEDULE', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (9, N'JOB TICKET OPERATION', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (10, N'REQUISITION AND ISSUANCE SLIP', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (11, N'CANE POINT RECEIPT', 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (12, N'WORK OPERATION MASTERLIST', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (13, N'LOCATION MASTERLIST', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (14, N'EQUIPMENT MASTERLIST', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (15, N'IMPLEMENT MASTERLIST', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (16, N'OTHER ITEM MASTERLIST', 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (17, N'LOCATION LOT STATUS', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (18, N'TRIP TICKET', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (19, N'CANE POINT', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (20, N'FARMING INVENTORY', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (21, N'EQUIPMENT', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (22, N'IMPLEMENT', 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (23, N'USER ACCOUNT AND PERMISSIONS', 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (24, N'MY USER SETTING', 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (27, N'HOME', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (28, N'LOGOUT', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[tbl_ais_main_useraccess_list] ([id], [description], [hierarchy1], [hierarchy2], [hierarchy3], [hierarchy4], [can_add], [can_edit], [can_delete], [can_cancel], [can_print], [can_edit_posted], [hierarchy_end], [frm_level1], [frm_level2]) VALUES (30, N'EXIT', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[tbl_ais_main_useraccess_list] OFF
/****** Object:  Table [dbo].[tbl_ais_main_useraccess_account]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ais_main_useraccess_account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username_id] [int] NOT NULL,
	[access_list_id] [int] NOT NULL,
	[encoder_id] [int] NOT NULL,
	[can_add] [bit] NOT NULL,
	[can_edit] [bit] NOT NULL,
	[can_delete] [bit] NOT NULL,
	[can_cancel] [bit] NOT NULL,
	[can_print] [bit] NOT NULL,
	[can_edit_review] [bit] NOT NULL,
	[can_edit_posted] [bit] NOT NULL,
	[frm_level1] [bit] NOT NULL,
	[frm_level2] [bit] NOT NULL,
 CONSTRAINT [pk_tbl_ais_main_useraccess_account] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ais_location_variety]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_location_variety](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[variety] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_location_variety] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_location_variety] ON
INSERT [dbo].[tbl_ais_location_variety] ([id], [variety]) VALUES (1, N'PLANT CANE')
INSERT [dbo].[tbl_ais_location_variety] ([id], [variety]) VALUES (2, N'RATOON 1')
INSERT [dbo].[tbl_ais_location_variety] ([id], [variety]) VALUES (3, N'RATOON 2')
INSERT [dbo].[tbl_ais_location_variety] ([id], [variety]) VALUES (4, N'RATOON 3')
SET IDENTITY_INSERT [dbo].[tbl_ais_location_variety] OFF
/****** Object:  Table [dbo].[tbl_ais_location_list]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_location_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[location] [varchar](50) NOT NULL,
	[municipality] [varchar](50) NOT NULL,
	[province] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_location_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_location_list] ON
INSERT [dbo].[tbl_ais_location_list] ([id], [location], [municipality], [province]) VALUES (1, N'TABLANG', N'PANIQUI', N'TARLAC')
SET IDENTITY_INSERT [dbo].[tbl_ais_location_list] OFF
/****** Object:  Table [dbo].[tbl_ais_equipment_type]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_equipment_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[equipment_type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_equipment_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_equipment_type] ON
INSERT [dbo].[tbl_ais_equipment_type] ([id], [equipment_type]) VALUES (1, N'TRACTOR')
SET IDENTITY_INSERT [dbo].[tbl_ais_equipment_type] OFF
/****** Object:  Table [dbo].[tbl_ais_equipment_driver]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_equipment_driver](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[driver_name] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_ais_equipment_driver] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_equipment_driver] ON
INSERT [dbo].[tbl_ais_equipment_driver] ([id], [driver_name], [status]) VALUES (1, N'JEROME MACA', 1)
SET IDENTITY_INSERT [dbo].[tbl_ais_equipment_driver] OFF
/****** Object:  Table [dbo].[tbl_ais_equipment_brand]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_equipment_brand](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[equipment_brand] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_equipment_brand] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_equipment_brand] ON
INSERT [dbo].[tbl_ais_equipment_brand] ([id], [equipment_brand]) VALUES (1, N'FORD')
SET IDENTITY_INSERT [dbo].[tbl_ais_equipment_brand] OFF
/****** Object:  Table [dbo].[tbl_ais_implements]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_implements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[owner_id] [int] NOT NULL,
	[list_id] [int] NOT NULL,
	[code] [varchar](50) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
	[created_date] [datetime] NULL,
	[modify_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_implements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_implements] ON
INSERT [dbo].[tbl_ais_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (1, 2, 1, N'ABH - 1', N'AGRIKULTO BI HARROW - 1', 1, CAST(0x0000A62800E92CD7 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_ais_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (2, 1, 1, N'CBH - 1', N'CAT BIG HARROW - 1', 0, CAST(0x0000A62800E94D6C AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_implements] OFF
/****** Object:  Table [dbo].[tbl_ais_implement_list]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_implement_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_implement_list] ON
INSERT [dbo].[tbl_ais_implement_list] ([id], [description]) VALUES (1, N'BIG HARROW')
INSERT [dbo].[tbl_ais_implement_list] ([id], [description]) VALUES (2, N'LIGHT HARROW')
SET IDENTITY_INSERT [dbo].[tbl_ais_implement_list] OFF
/****** Object:  Table [dbo].[tbl_ais_form_type]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_form_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_form_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ais_useraccestlist_menu]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_useraccestlist_menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[menu_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_useraccestlist_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ais_location_association]    Script Date: 06/21/2016 16:54:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_location_association](
	[id] [int] NOT NULL,
	[sub_desc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_location_association] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_ais_location_association] ([id], [sub_desc]) VALUES (1, N'CATPA')
INSERT [dbo].[tbl_ais_location_association] ([id], [sub_desc]) VALUES (2, N'ASUCAL')
INSERT [dbo].[tbl_ais_location_association] ([id], [sub_desc]) VALUES (3, N'NORTH CLUSTER PRODUCERS COOP')
INSERT [dbo].[tbl_ais_location_association] ([id], [sub_desc]) VALUES (4, N'BISPMPC')
INSERT [dbo].[tbl_ais_location_association] ([id], [sub_desc]) VALUES (5, N'INDEPENDENT')
/****** Object:  UserDefinedFunction [dbo].[fnSplit]    Script Date: 06/21/2016 16:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fnSplit] ( @sep CHAR(1), @str VARCHAR(512) )
 RETURNS TABLE AS
 RETURN (
           WITH Pieces(pn, start, stop) AS (
           SELECT 1, 1, CHARINDEX(@sep, @str)
           UNION ALL
           SELECT pn + 1, stop + 1, CHARINDEX(@sep, @str, stop + 1)
           FROM Pieces
           WHERE stop > 0
      )

      SELECT
           pn AS Id,
           SUBSTRING(@str, start, CASE WHEN stop > 0 THEN stop - start ELSE 512 END) AS Data
      FROM
           Pieces
 )
GO
/****** Object:  View [dbo].[v_ais_trip_ticket_schedule_form]    Script Date: 06/21/2016 16:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_trip_ticket_schedule_form]
AS
SELECT     A.id AS hdr_id, B.id AS dtl_id, A.reg_no, A.trip_ticket_no, A.trip_date, A.equip_type, A.equip_no, A.imple_desc, A.imple_code, A.driver, A.purpose, A.need_date, A.need_time, A.requested_by, 
                      A.approved_by, A.equip_timeout, A.equip_timein, A.jobsite_arrival_time, A.jobsite_departure_time, A.remarks, A.work_accepted_by, A.noted_by, A.jtmo_no, A.check_jtmo_by, A.status, 
                      A.create_date AS hdr_create_date, B.lot_no, B.time_started, B.time_stopped, B.operate_hours, B.work_operation, B.area_done, B.rate_per_area, B.amount, B.location, B.current_area, B.soill_type, 
                      B.date_planted, B.ownership, B.lot_owner_name, B.association_desc, B.variety, B.fiscal_year, B.created_date AS dtl_create_date, B.dtl_stats, A.accomplished_date, A.posted_date, B.driver_id, 
                      B.equip_id, B.imple_id, A.user_id, A.accomplished_by, A.posted_by, B.post_status, A.owner_equip, A.owner_imple
FROM         dbo.tbl_ais_trip_ticket_schedule_hdr AS A INNER JOIN
                      dbo.tbl_ais_trip_ticket_schedule_dtl AS B ON A.id = B.hdr_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[60] 4[1] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 0
               Left = 38
               Bottom = 556
               Right = 239
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 0
               Left = 297
               Bottom = 483
               Right = 467
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 55
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2160
         Width = 1500
         Width = 1500
         Width = 3000
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         W' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_schedule_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'idth = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_schedule_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_schedule_form'
GO
/****** Object:  Table [dbo].[tbl_ais_work_operations]    Script Date: 06/21/2016 16:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_work_operations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cat_id] [int] NOT NULL,
	[operation] [varchar](50) NOT NULL,
	[unit_measure] [varchar](20) NOT NULL,
	[rate_cost] [decimal](19, 4) NOT NULL,
	[date_created] [datetime] NULL,
	[date_modify] [datetime] NULL,
	[date_delete] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_work_operations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_work_operations] ON
INSERT [dbo].[tbl_ais_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (1, 2, N'DISC CULTIVATION', N'HA', CAST(2000.0000 AS Decimal(19, 4)), CAST(0x0000A62800E4302C AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_ais_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (2, 1, N'HEAVY HARROWING', N'HA', CAST(2500.0000 AS Decimal(19, 4)), CAST(0x0000A62800E44EA7 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_ais_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (3, 1, N'HEAVY HARROWING AP', N'HA', CAST(2500.0000 AS Decimal(19, 4)), CAST(0x0000A62800E46F8A AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_work_operations] OFF
/****** Object:  View [dbo].[v_ais_implement_masterlist]    Script Date: 06/21/2016 16:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_implement_masterlist]
AS
SELECT     A.id, A.owner_id, C.id_name, C.owner_name, A.list_id, B.description, A.code, A.description AS imple_desc, A.status
FROM         dbo.tbl_ais_implements AS A INNER JOIN
                      dbo.tbl_ais_implement_list AS B ON A.list_id = B.id INNER JOIN
                      dbo.tbl_ais_owner_name AS C ON A.owner_id = C.id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "B"
            Begin Extent = 
               Top = 155
               Left = 228
               Bottom = 245
               Right = 388
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 21
               Left = 276
               Bottom = 126
               Right = 436
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 166
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_implement_masterlist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_implement_masterlist'
GO
/****** Object:  StoredProcedure [dbo].[p_ais_usercontrol_add_modify]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_usercontrol_add_modify]
@username as VARCHAR(20) = NULL,
@password as VARCHAR(50) = NULL,
@fname AS VARCHAR(30) = NULL,
@lname AS VARCHAR(30) = NULL,
@mname AS VARCHAR(30) = NULL,
@usertype AS VARCHAR(20) = NULL,
@encodername AS VARCHAR(50) = NULL,
@flag AS INT = NULL,
@D_id AS INT = NULL,
@index_type AS INT = NULL
AS

BEGIN
	BEGIN TRAN

	if @flag = 1 
		BEGIN
			INSERT INTO tbl_ais_user_account(username,password,user_fname,user_mname,user_lname,user_type,who_save,save_date,type_index) 
				VALUES(@username,@password,@fname,@mname,@lname,@usertype,@encodername,GETDATE(),@index_type)
			
			IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END

	if @flag = 2
		BEGIN
			UPDATE tbl_ais_user_account SET username=@username,password=@password,user_fname=@fname,user_mname=@mname,user_lname=@lname
										,user_type=@usertype,who_modify=@encodername,modify_date=GETDATE(),type_index=@index_type FROM tbl_ais_user_account WHERE id=@D_id
			
			IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END
	if @flag = 3 
		BEGIN
			DELETE FROM tbl_ais_user_account WHERE id =@D_id
		END
					
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  Table [dbo].[tbl_ais_location]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_location](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](50) NOT NULL,
	[location_id] [int] NOT NULL,
	[area] [nvarchar](50) NOT NULL,
	[soil_type] [varchar](50) NOT NULL,
	[info_id] [int] NULL,
	[owner_name] [varchar](50) NULL,
	[date_created] [datetime] NULL,
	[date_modify] [datetime] NULL,
	[date_delete] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_location] ON
INSERT [dbo].[tbl_ais_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (1, N'TABLANG001', 1, N'2.0000', N'Soil Type 1', 1, N'JEROME MACA', CAST(0x0000A62800E97FC2 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_ais_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (2, N'TABLANG002', 1, N'4.0000', N'Soil Type 1', NULL, N'MARK DANGANAN', CAST(0x0000A62B00F954D0 AS DateTime), CAST(0x0000A62B00FA1C34 AS DateTime), NULL)
INSERT [dbo].[tbl_ais_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (3, N'TABLANG003', 1, N'2.0000', N'Soil Type 1', NULL, N'IAN SARMIENTO', CAST(0x0000A62B00FA46CD AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_location] OFF
/****** Object:  Table [dbo].[tbl_ais_useraccesslist_sub_menu]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_useraccesslist_sub_menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[menu_id] [int] NOT NULL,
	[sub_menu_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_useraccesslist_sub_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ais_equipments]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_equipments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[owner_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[brand_id] [int] NOT NULL,
	[model] [varchar](50) NOT NULL,
	[cr_no] [nvarchar](50) NULL,
	[motor_no] [nvarchar](50) NULL,
	[serial_no] [nvarchar](50) NULL,
	[mv_file_no] [nvarchar](50) NULL,
	[si_no] [nvarchar](50) NULL,
	[dr_no] [nvarchar](50) NULL,
	[others] [varchar](50) NULL,
	[date_proof] [datetime] NULL,
	[acquisition_cost] [decimal](19, 4) NULL,
	[status] [bit] NOT NULL,
	[date_created] [datetime] NULL,
	[date_modify] [datetime] NULL,
	[date_delete] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_equipments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_equipments] ON
INSERT [dbo].[tbl_ais_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (1, 1, 1, 1, N'RLZ 385', N'', N'', N'', N'', N'', N'', N'', CAST(0x0000A62800000000 AS DateTime), CAST(0.0000 AS Decimal(19, 4)), 0, CAST(0x0000A62800E52FA5 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_ais_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (2, 2, 1, 1, N'TW25 - 001', N'', N'', N'', N'', N'', N'', N'', CAST(0x0000A62800E53BFC AS DateTime), CAST(0.0000 AS Decimal(19, 4)), 1, CAST(0x0000A62800E565F6 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_equipments] OFF
/****** Object:  StoredProcedure [dbo].[p_ais_implement_masterlist_update]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_implement_masterlist_update]
@owner_id int,
@list_id int,
@code nvarchar(50),
@desc varchar(50),
@id int
AS

BEGIN
	BEGIN TRAN
		UPDATE tbl_ais_implements SET owner_id=@owner_id,list_id=@list_id,code=@code,description=@desc,modify_date=GETDATE()
		WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1		
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_implement_masterlist_delete]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_implement_masterlist_delete]
@id int
AS

BEGIN
	BEGIN TRAN
		DELETE FROM tbl_ais_implements WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1		
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_implement_masterlist_add]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_implement_masterlist_add]
@owner_id int,
@lists_id int,
@code nvarchar(50),
@desc varchar(50)

AS

BEGIN
	BEGIN TRAN

		INSERT tbl_ais_implements(owner_id,list_id,code,description,created_date,status) VALUES(@owner_id,@lists_id,@code,@desc,GETDATE(),'0')
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_workoperation_masterlist_update]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_workoperation_masterlist_update]
@categ_id int,
@operation varchar(50),
@unit nvarchar(20),
@rate decimal(19,4),
@id int

AS

BEGIN
	BEGIN TRAN

		UPDATE tbl_ais_work_operations SET cat_id=@categ_id,operation=@operation,unit_measure=@unit,rate_cost=@rate,date_modify=GETDATE()
		WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_workoperation_masterlist_delete]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_workoperation_masterlist_delete]
@id int

AS

BEGIN
	BEGIN TRAN

		DELETE FROM tbl_ais_work_operations WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_workoperation_masterlist_add]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_workoperation_masterlist_add]
@categ_id int,
@operation varchar(50),
@unit nvarchar(20),
@rate decimal(19,4)

AS

BEGIN
	BEGIN TRAN

		INSERT tbl_ais_work_operations(cat_id,operation,unit_measure,rate_cost,date_created) VALUES(@categ_id,@operation,@unit,@rate,GETDATE())
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_equipment_masterlist_update]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_equipment_masterlist_update]
@owner_id int,
@type_id int,
@brand_id int,
@model varchar(50),
@cr_no nvarchar(50),
@motor_no nvarchar(50),
@serial_no nvarchar(50),
@mv_file_no nvarchar(50),
@si_no nvarchar(50),
@dr_no nvarchar(50),
@others varchar(50),
@date_proof datetime,
@acquisition_cost money,
@id int
AS

BEGIN
	BEGIN TRAN
		UPDATE tbl_ais_equipments SET owner_id=@owner_id,type_id=@type_id,brand_id=@brand_id,model=@model,cr_no=@cr_no,motor_no=@motor_no,
			serial_no=@serial_no,mv_file_no=@mv_file_no,si_no=@si_no,dr_no=@dr_no,others=@others,date_proof=@date_proof,acquisition_cost=@acquisition_cost,
			date_modify=GETDATE()
		WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1		
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_equipment_masterlist_delete]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_equipment_masterlist_delete]
@id int
AS

BEGIN
	BEGIN TRAN
		DELETE FROM tbl_ais_equipments WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1		
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_equipment_masterlist_add]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_equipment_masterlist_add]
@owner_id int,
@type_id int,
@brand_id int,
@model varchar(50),
@cr_no nvarchar(50),
@motor_no nvarchar(50),
@serial_no nvarchar(50),
@mv_file_no nvarchar(50),
@si_no nvarchar(50),
@dr_no nvarchar(50),
@others varchar(50),
@date_proof datetime,
@acquisition_cost money
AS

BEGIN
	BEGIN TRAN

		INSERT tbl_ais_equipments(owner_id,type_id,brand_id,model,cr_no,motor_no,serial_no,mv_file_no,si_no,dr_no,others,date_proof,acquisition_cost,status,date_created) 
			VALUES(@owner_id,@type_id,@brand_id,@model,@cr_no,@motor_no,@serial_no,@mv_file_no,@si_no,@dr_no,@others,@date_proof,@acquisition_cost,'0',GETDATE())
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_main_location_update]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_main_location_update]
	@loc_id int,
	@code varchar(50),
	@area nvarchar(50),
	@soiltype varchar(50),
	@id int,
	@owner_name varchar(50)
AS

BEGIN
	BEGIN TRAN
	---UPDATE tbl_ais_location_info
		UPDATE tbl_ais_location SET location_id=@loc_id,code =@code, 
				area=@area,soil_type=@soiltype,owner_name=@owner_name,date_modify=GETDATE()
				WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_main_location_add]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_main_location_add]
	@code varchar(50),
	@loc_id int,
	@area nvarchar(50),
	@soiltype varchar(50),
	@owner_name varchar(50)
AS

BEGIN
	BEGIN TRAN
	---INSERT tbl_ais_location_info
		INSERT INTO tbl_ais_location(code,location_id,area,soil_type,owner_name,date_created) 
		VALUES(@code,@loc_id,@area,@soiltype,@owner_name,getdate())
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  Table [dbo].[tbl_ais_location_info]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_location_info](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lot_id] [int] NOT NULL,
	[date_planted] [datetime] NOT NULL,
	[ownership] [varchar](50) NOT NULL,
	[ownername] [varchar](50) NULL,
	[variety_id] [int] NOT NULL,
	[association_id] [int] NOT NULL,
	[water_source] [bit] NOT NULL,
	[fiscal_year] [varchar](50) NOT NULL,
	[date_create] [datetime] NULL,
	[date_modify] [datetime] NULL,
	[date_delete] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_location_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_location_info] ON
INSERT [dbo].[tbl_ais_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (1, 1, CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', NULL, 1, 2, 1, N'2016-2017', CAST(0x0000A62800E9E40F AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_location_info] OFF
/****** Object:  Table [dbo].[tbl_ais_trip_ticket_request_hdr]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_trip_ticket_request_hdr](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_req] [datetime] NOT NULL,
	[time_needed] [time](7) NULL,
	[req_no] [bigint] NULL,
	[lot_id] [int] NOT NULL,
	[req_order_int] [nvarchar](20) NOT NULL,
	[user_id] [int] NULL,
	[stats] [int] NULL,
	[purpose] [varchar](max) NULL,
	[date_created] [datetime] NULL,
	[date_modified] [datetime] NULL,
	[date_deleted] [datetime] NULL,
 CONSTRAINT [PK_tbl_ais_trip_ticket_request_hdr] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_request_hdr] ON
INSERT [dbo].[tbl_ais_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (1, CAST(0x0000A62D00000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), 1, 1, N'2016062115513121', 1, 1, N'DC', CAST(0x0000A62C01056C5C AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_request_hdr] OFF
/****** Object:  Table [dbo].[tbl_ais_useraccesslist_sub_child]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ais_useraccesslist_sub_child](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sub_menu_id] [int] NOT NULL,
	[child_menu_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ais_useraccesslist_sub_child] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[p_ais_trip_ticket_schedule_process]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_trip_ticket_schedule_process](  
@userid INT,  
@hdr_id INT,
---tbl_ais_SCHEDU:E_HDR
@equip_timeout TIME(7),
@equip_timein TIME(7),
@jobsite_arrival TIME(7),
@jobsite_departure TIME(7),
@remarks VARCHAR(MAX),
@work_accepted VARCHAR(50) = NULL,
@noted_by VARCHAR(50) = NULL
)  
AS  
  
BEGIN  

---tbl_ais_SCHEDULE_DTL
DECLARE @time_start TIME(7) = NULL
DECLARE @time_stopped TIME(7) = NULL
DECLARE @operate_hrs TIME(7) = NULL
DECLARE @area_done DECIMAL(19,1) = NULL
DECLARE @rate_per_area DECIMAL(19,1) = NULL
DECLARE @amount DECIMAL(19, 2) = NULL

 BEGIN TRAN  
   DECLARE @tbl TABLE(count INT,hdr_id INT,dtl_id INT,driver_id INT,equip_id INT,imple_id INT,work_ope VARCHAR(50))  
   DECLARE @counter_max INT  
   DECLARE @counter_minimum INT = 0  
   DECLARE @Series_start INT  
   DECLARE @v_hdr_id INT
   DECLARE @v_dtl_id INT
   DECLARE @v_driver_id INT
   DECLARE @v_equip_id INT
   DECLARE @v_imple_id INT
   DECLARE @operation VARCHAR(30)

   DECLARE @counting_dtl INT ---COUNT iF DTL DATA IS ALREADY UPDATED TO UPDATE HDR
  
  INSERT INTO @tbl  
  SELECT ROW_NUMBER() over (ORDER BY lot_no) as #,hdr_id,dtl_id,driver_id,equip_id,imple_id,work_operation FROM v_trip_ticket_schedule_form WHERE hdr_id = @hdr_id AND dtl_stats = '1' AND status <> '1'
  
   --SELECT * FROM @tbl

   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   SELECT @counter_max = Count(*) FROM @tbl

   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   
   WHILE @counter_minimum <= @counter_max  
    BEGIN     
		 SET @counter_minimum +=1   
       
		 SELECT @v_hdr_id = hdr_id,@v_dtl_id = dtl_id,@v_driver_id = driver_id,@v_equip_id = equip_id,@v_imple_id = imple_id,@operation=work_ope FROM @tbl WHERE count = @counter_minimum  
    
		SELECT @counting_dtl = COUNT(*) FROM v_ais_trip_ticket_schedule_form WHERE dtl_stats <> '2' AND accomplished_by IS NULL AND hdr_id=@v_hdr_id
		
		---tbl_ais_SCHEDULE_HEADER
			IF @counting_dtl = 0
				BEGIN
					UPDATE tbl_ais_trip_ticket_schedule_hdr SET equip_timeout = @equip_timeout,equip_timein = @equip_timein,jobsite_arrival_time=@jobsite_arrival,jobsite_departure_time=@jobsite_departure,
								remarks=@remarks,work_accepted_by=@work_accepted,noted_by=@noted_by,accomplished_by=@noted_by,accomplished_date=GETDATE(),status='1' WHERE id=@v_hdr_id
						  IF (@@ERROR <> 0) GOTO ERR_HANDLER  
				END
			ELSE
				BEGIN
					UPDATE tbl_ais_trip_ticket_schedule_hdr SET equip_timeout = @equip_timeout,equip_timein = @equip_timein,jobsite_arrival_time=@jobsite_arrival,jobsite_departure_time=@jobsite_departure,
								remarks=@remarks,work_accepted_by=@work_accepted,noted_by=@noted_by  WHERE id=@v_hdr_id
						  IF (@@ERROR <> 0) GOTO ERR_HANDLER  
				END
	  
		---tbl_ais_SCHEDULE_DETAILS

		SELECT @time_start=time_started,@time_stopped=time_stopped,@operate_hrs=operate_hours,@area_done=area_done FROM tbl_ais_trip_ticket_schedule_dtl WHERE id=@v_dtl_id

		
		DECLARE @r_cost DECIMAL(19,2)
		DECLARE @result DECIMAL(19,2)
		SELECT @r_cost= rate_cost FROM tbl_ais_work_operations WHERE operation=@operation

		SET @result =( @area_done*@r_cost)

		UPDATE tbl_ais_trip_ticket_schedule_dtl SET time_started=@time_start,time_stopped=@time_stopped,operate_hours=@operate_hrs,area_done=@area_done,
				rate_per_area=@r_cost,amount=@result,dtl_stats=2 WHERE id=@v_dtl_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER  

		 UPDATE tbl_ais_equipment_driver SET status='0' WHERE id=@v_driver_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER

		  UPDATE tbl_ais_equipments SET status='0' WHERE id=@v_equip_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER

		  UPDATE tbl_ais_implements SET status='0' WHERE id=@v_imple_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER
    END  
      
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
 COMMIT TRAN  
  
 RETURN 0  
  
 ERR_HANDLER:  
 PRINT 'Unexpected error occurred!'  
 ROLLBACK TRAN  
 RETURN 1      
END



--SELECT * FROM v_ais_trip_ticket_schedule_form

--SELECT * FROM tbl_ais_equipment_driver WHERE id = 4
--SELECT * FROM tbl_ais_equipments WHERE id = 5
--SELECT * FROM tbl_ais_implements WHERE id = 6
GO
/****** Object:  View [dbo].[v_ais_equipment_masterlist]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_equipment_masterlist]
AS
SELECT     A.id, A.owner_id, A.type_id, A.brand_id, B.owner_name, C.equipment_type, D.equipment_brand, A.model, A.cr_no, A.motor_no, A.serial_no, A.mv_file_no, A.si_no, A.dr_no, A.others, A.date_proof, 
                      A.acquisition_cost, A.status
FROM         dbo.tbl_ais_equipments AS A INNER JOIN
                      dbo.tbl_ais_owner_name AS B ON A.owner_id = B.id INNER JOIN
                      dbo.tbl_ais_equipment_type AS C ON A.type_id = C.id INNER JOIN
                      dbo.tbl_ais_equipment_brand AS D ON A.brand_id = D.id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[15] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 336
               Right = 203
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 5
               Left = 409
               Bottom = 118
               Right = 569
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 150
               Left = 482
               Bottom = 275
               Right = 649
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 221
               Left = 233
               Bottom = 311
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 19
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1800
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_equipment_masterlist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_equipment_masterlist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_equipment_masterlist'
GO
/****** Object:  View [dbo].[v_ais_work_operation]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_work_operation]
AS
SELECT     A.id, A.cat_id, B.cat_desc, A.operation, A.unit_measure, A.rate_cost
FROM         dbo.tbl_ais_work_operations AS A INNER JOIN
                      dbo.tbl_ais_operation_category AS B ON A.cat_id = B.category_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 205
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 21
               Left = 329
               Bottom = 154
               Right = 489
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_work_operation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_work_operation'
GO
/****** Object:  View [dbo].[v_ais_location_maindata]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_location_maindata]
AS
SELECT     E.id, E.code, E.location_id, D.location, D.municipality, D.province, E.area, E.soil_type, B.date_planted, B.ownership, E.owner_name, B.association_id, C.sub_desc, B.variety_id, A.variety, E.info_id, 
                      B.water_source, B.fiscal_year
FROM         dbo.tbl_ais_location_variety AS A INNER JOIN
                      dbo.tbl_ais_location_info AS B INNER JOIN
                      dbo.tbl_ais_location_association AS C ON B.association_id = C.id ON A.id = B.variety_id RIGHT OUTER JOIN
                      dbo.tbl_ais_location_list AS D INNER JOIN
                      dbo.tbl_ais_location AS E ON D.id = E.location_id ON B.lot_id = E.id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[50] 4[4] 2[24] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 84
               Left = 839
               Bottom = 174
               Right = 1083
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 224
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 238
               Left = 229
               Bottom = 328
               Right = 451
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 210
               Left = 584
               Bottom = 330
               Right = 796
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 21
               Left = 310
               Bottom = 219
               Right = 498
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 150' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_location_maindata'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_location_maindata'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_location_maindata'
GO
/****** Object:  Table [dbo].[tbl_ais_usercontrol_permission]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ais_usercontrol_permission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[useid] [int] NULL,
	[menuid] [int] NULL,
	[submenuid] [int] NULL,
	[subchildmenuid] [int] NULL,
	[maintenanceid] [int] NULL,
	[econdoderid] [int] NULL,
 CONSTRAINT [PK_tbl_ais_usercontrol_permission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ais_trip_ticket_request_dtl]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ais_trip_ticket_request_dtl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[req_hdr_id] [int] NOT NULL,
	[work_ope_id] [int] NOT NULL,
	[date_created] [datetime] NULL,
	[date_modified] [datetime] NULL,
	[date_deleted] [datetime] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_tbl_ais_trip_ticket_request_dtl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_request_dtl] ON
INSERT [dbo].[tbl_ais_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (1, 1, 1, CAST(0x0000A62C01056C5C AS DateTime), NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tbl_ais_trip_ticket_request_dtl] OFF
/****** Object:  StoredProcedure [dbo].[p_ais_location_info_update]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[p_ais_location_info_update](
@date_planted datetime,
@ownership varchar(50),
@variety_id int,
@asso_id int,
@water_source bit,
@fiscal_year varchar(50),
@id int
)
AS
BEGIN
	BEGIN TRAN
			UPDATE tbl_ais_location_info SET date_planted=@date_planted,ownership=@ownership,
		variety_id=@variety_id,association_id=@asso_id,water_source=@water_source,
			fiscal_year=@fiscal_year,date_modify=GETDATE() WHERE id=@id
			
		IF (@@ERROR <> 0) GOTO ERR_HANDLER

		--INSERT titleauthor(au_id, title_id)
		--VALUES (@au_id, @title_id)

		--IF (@@ERROR <> 0) GOTO ERR_HANDLER

	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_location_info_delete]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[p_ais_location_info_delete](
@id int
)
AS
BEGIN
	BEGIN TRAN
		DELETE FROM tbl_ais_location_info WHERE id = @id		
				
		IF (@@ERROR <> 0) GOTO ERR_HANDLER

		UPDATE tbl_ais_location SET info_id = NULL WHERE info_id = @id	

		IF (@@ERROR <> 0) GOTO ERR_HANDLER

	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_insert_location_info_update_main_location]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_insert_location_info_update_main_location](
---INSERT tbl_ais_location_info
@lot_id int,
@date_planted datetime,
@ownership varchar(50),
@variety_id int,
@association_id int,
@water_source bit,
@fiscal_year varchar(50),
---UPDATE tbl_ais_location
@id int
)
AS

BEGIN
	DECLARE @info_id int;
	BEGIN TRAN
	---INSERT tbl_ais_location_info
		INSERT tbl_ais_location_info(lot_id,date_planted,ownership,variety_id,association_id,water_source,fiscal_year,date_create)
		VALUES (@lot_id,@date_planted,@ownership,@variety_id,@association_id,@water_source,@fiscal_year,GETDATE())
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	SELECT TOP 1 @info_id = id FROM tbl_ais_location_info ORDER by id DESC
	
	---UPDATE tbl_ais_location
		UPDATE tbl_ais_location SET info_id = @info_id WHERE id=@id

	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_usercontrol_permission_list]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_usercontrol_permission_list]
	@USERID AS INT = NULL,
	@ID AS INT = NULL,
	@FLAG AS INT = NULL
AS

BEGIN
	BEGIN TRAN
	DECLARE @user_id AS INT;

	SELECT @user_id= B.useid FROM tbl_ais_useraccestlist_menu A LEFT OUTER JOIN tbl_ais_usercontrol_permission B ON A.id=B.menuid WHERE B.useid = @USERID

			IF @FLAG = 0 ---MENU ACCESS
				BEGIN
					IF @user_id <> 0 
						BEGIN
							  SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.menu_name,useid,menuid
							  FROM tbl_ais_useraccestlist_menu A LEFT OUTER JOIN tbl_ais_usercontrol_permission B ON A.id=B.menuid
							  WHERE useid = @USERID OR useid IS NULL GROUP BY A.id,A.menu_name,useid,menuid

							  IF (@@ERROR <> 0) GOTO ERR_HANDLER
						END
					ELSE
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,menu_name,useid=NULL,menuid=NULL FROM tbl_ais_useraccestlist_menu
						END			
				END
			IF @FLAG = 1 ---SUB MENU ACCESS
				BEGIN
					IF @user_id <> 0
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.sub_menu_name,b.useid,b.submenuid
							 FROM tbl_ais_useraccesslist_sub_menu A LEFT OUTER JOIN tbl_ais_usercontrol_permission B ON A.id=B.submenuid
							 WHERE (B.useid = @USERID OR B.useid IS NULL) AND (B.menuid = @ID AND B.menuid IS NOT NULL)  ---OR B.submenuid IS NULL
							 GROUP BY A.id,A.sub_menu_name,b.useid,b.submenuid
						END
					ELSE
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,sub_menu_name,useid=NULL,submenuid=NULL FROM tbl_ais_useraccesslist_sub_menu WHERE menu_id = @ID
						END
				END
			IF @FLAG = 2 ---SUB CHILD MENU ACCESS
				BEGIN
					IF @user_id <> 0
						BEGIN
							SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.child_menu_name,useid,subchildmenuid
							FROM tbl_ais_useraccesslist_sub_child A LEFT OUTER JOIN tbl_ais_usercontrol_permission B ON A.id=B.subchildmenuid
							WHERE (B.useid = @USERID OR B.useid IS NULL) AND (B.subchildmenuid = @ID AND B.subchildmenuid IS NOT NULL) ---OR B.subchildmenuid IS NULL
							GROUP BY A.id,A.child_menu_name,useid,subchildmenuid
						END
					ELSE
						BEGIN
							SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,child_menu_name,useid=NULL,subchildmenuid=NULL FROM tbl_ais_useraccesslist_sub_child WHERE sub_menu_id = @ID
						END
				END
			IF @FLAG = 3 ---ACCESS MAINTENANCE
				BEGIN	
					IF @user_id <> 0 
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.maintenace_name,useid,maintenanceid
							 FROM tbl_ais_useraccesslist_maintenance A LEFT OUTER JOIN tbl_ais_usercontrol_permission B ON A.id=B.maintenanceid
							 WHERE (B.useid = @USERID OR B.useid IS NULL) AND (B.menuid = @ID OR B.maintenanceid IS NULL)
							 GROUP BY A.id,A.maintenace_name,useid,maintenanceid
						END
					ELSE
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,maintenace_name,useid=NULL,maintenanceid=NULL FROM tbl_ais_useraccesslist_maintenance
						END	  
					
				END

			IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_trip_ticket_request_form_add]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_trip_ticket_request_form_add](
---INSERT tbl_ais_trip_ticket_hdr
@date_req Datetime,
@lot_id int,
@req_order_id nvarchar(50),

---INSERT tbl_ais_trip_ticket_dtl
@work_ope_id int,
@user_id int,
@stats int,
@time_needed time(7),
@purpose varchar(max)
)
AS

BEGIN
	DECLARE @hdr_id int;
	DECLARE @count int;
	BEGIN TRAN

	SET @count = (SELECT COUNT(id) FROM tbl_ais_trip_ticket_request_hdr WHERE lot_id = @lot_id AND req_order_int = @req_order_id AND date_req=@date_req)

	IF @count = 0
		BEGIN
			INSERT tbl_ais_trip_ticket_request_hdr(date_req,lot_id,req_order_int,date_created,user_id,stats,time_needed,purpose) VALUES(@date_req,@lot_id,@req_order_id,GETDATE(),@user_id,@stats,@time_needed,@purpose)			
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

			SELECT TOP 1 @hdr_id = id FROM tbl_ais_trip_ticket_request_hdr WHERE lot_id = @lot_id AND req_order_int = @req_order_id AND date_req=@date_req ORDER by id DESC
			INSERT tbl_ais_trip_ticket_request_dtl(req_hdr_id,work_ope_id,date_created,status) VALUES(@hdr_id,@work_ope_id,GETDATE(),'0')
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END
	ELSE
		BEGIN
			SELECT TOP 1 @hdr_id = id FROM tbl_ais_trip_ticket_request_hdr WHERE lot_id = @lot_id AND req_order_int = @req_order_id AND date_req=@date_req ORDER by id DESC
			INSERT tbl_ais_trip_ticket_request_dtl(req_hdr_id,work_ope_id,date_created,status) VALUES(@hdr_id,@work_ope_id,GETDATE(),'0')
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END		
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_trip_ticket_approval_add]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_trip_ticket_approval_add](
@hdr_id int,
@dtl_id int,
@lot_id int,
@reg_no int,
@trip_ticket_no int,
@trip_date datetime,
@equip_type varchar(50),
@equip_no varchar(50),
@imple_desc varchar(50),
@imple_code varchar(50),
@driver varchar(50) = NULL,
@purpose varchar(max),
@need_date datetime,
@need_time time(7),
@requested_by varchar(50),
@approved_by varchar(50),
@lot_no varchar(50),
@work_operation varchar(50),
@approval_equip_id int,
@approval_imple_id int,
@driver_id int,
@user_id int
)
AS
BEGIN
	DECLARE @hdr_id_insert int;
	DECLARE @count int;
	DECLARE @location varchar(50);
	DECLARE @current_area decimal(19,3);
	DECLARE @soil_type varchar(50) ;
	DECLARE @date_planted datetime;
	DECLARE @ownership varchar(50);
	DECLARE @owner_name varchar(50);
	DECLARE @sub_desc varchar(50);
	DECLARE @variety varchar(50);
	DECLARE @fiscal_year nvarchar(50);
	DECLARE @cc_dtl int;
	DECLARE @owner_equip NVARCHAR(50);
	DECLARE @owner_imple NVARCHAR(50);

	BEGIN TRAN

	SET @count = (SELECT COUNT(id) FROM tbl_ais_trip_ticket_schedule_hdr WHERE reg_no = @reg_no)

	IF @count = 0
		BEGIN
		
			SELECT TOP 1 @owner_equip = B.owner_name FROM tbl_ais_equipments A INNER JOIN tbl_ais_owner_name B 
			ON A.owner_id=B.id INNER JOIN tbl_ais_equipment_type C 
			ON A.type_id=C.id WHERE A.model=@equip_no AND C.equipment_type=@equip_type
			
  
			SELECT TOP 1 @owner_imple = B.owner_name FROM tbl_ais_implements A INNER JOIN tbl_ais_owner_name B 
			ON A.owner_id=B.id WHERE A.code	=@imple_code AND A.description=@imple_desc
			

			SELECT top 1 @trip_ticket_no= trip_ticket_no FROM tbl_ais_trip_ticket_schedule_hdr WHERE trip_ticket_no IS NOT NULL ORDER BY trip_ticket_no DESC

			SET @trip_ticket_no += 1

			-----HEADER INSERTION
			INSERT tbl_ais_trip_ticket_schedule_hdr(
				reg_no,trip_ticket_no,trip_date,equip_type,equip_no,imple_desc,imple_code,driver,purpose,need_date,need_time,requested_by,approved_by,
				equip_timeout,equip_timein,jobsite_arrival_time,jobsite_departure_time,remarks,work_accepted_by,noted_by,jtmo_no,check_jtmo_by,status,
				create_date,user_id,owner_equip,owner_imple
			) VALUES(
				@reg_no,@trip_ticket_no,@trip_date,@equip_type,@equip_no,@imple_desc,@imple_code,@driver,@purpose,@need_date,@need_time,@requested_by,@approved_by,
				'','','','','','','','','','0',GETDATE(),@user_id,@owner_equip,@owner_imple
			)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

			-------SELECT LAST INSERT HEADER ID
			SELECT TOP 1 @hdr_id_insert = id FROM tbl_ais_trip_ticket_schedule_hdr WHERE reg_no = @reg_no

			------SELECT PARTIAL LOT DATA
			SELECT TOP 1 
				@location = location,
				@current_area = area,
				@soil_type = soil_type,
				@date_planted = date_planted,
				@ownership = ownership,
				@owner_name = owner_name,
				@sub_desc = sub_desc,
				@variety = variety,
				@fiscal_year = fiscal_year
			 FROM v_ais_location_maindata WHERE id=@lot_id			

			-------DETAIL INSERTION
			INSERT tbl_ais_trip_ticket_schedule_dtl(
				hdr_id,lot_no,work_operation,location,current_area,soill_type,date_planted,ownership,lot_owner_name,association_desc,variety,fiscal_year,created_date,dtl_stats,
				driver_id,equip_id,imple_id,post_status
			) VALUES(
				@hdr_id_insert,@lot_no,@work_operation,@location,@current_area,@soil_type,@date_planted,@ownership,@owner_name,@sub_desc,@variety,@fiscal_year,GETDATE(),'0',
				@driver_id,@approval_equip_id,@approval_imple_id,'0'
			)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

				
			UPDATE tbl_ais_trip_ticket_request_dtl SET status=1 WHERE id=@dtl_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER			
			UPDATE tbl_ais_implements SET status=1 WHERE id=@approval_imple_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			UPDATE tbl_ais_equipments SET status=1 WHERE id=@approval_equip_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			UPDATE tbl_ais_equipment_driver SET status=1 WHERE id=@driver_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

			SELECT @cc_dtl=COUNT(id) FROM tbl_ais_trip_ticket_request_dtl WHERE req_hdr_id=@hdr_id AND status <> 1

			if @cc_dtl = 0
				BEGIN
					UPDATE tbl_ais_trip_ticket_request_hdr SET stats= 1 WHERE id = @hdr_id
					IF (@@ERROR <> 0) GOTO ERR_HANDLER
				END
		END
	ELSE
		BEGIN

			-------SELECT LAST INSERT HEADER ID
			SELECT TOP 1 @hdr_id_insert = id FROM tbl_ais_trip_ticket_schedule_hdr WHERE reg_no = @reg_no

			------SELECT PARTIAL LOT DATA
			SELECT TOP 1 
				@location = location,
				@current_area = area,
				@soil_type = soil_type,
				@date_planted = date_planted,
				@ownership = ownership,
				@owner_name = owner_name,
				@sub_desc = sub_desc,
				@variety = variety,
				@fiscal_year = fiscal_year
			 FROM v_ais_location_maindata WHERE id=@lot_id			

			-------DETAIL INSERTION
			INSERT tbl_ais_trip_ticket_schedule_dtl(
				hdr_id,lot_no,work_operation,location,current_area,soill_type,date_planted,ownership,lot_owner_name,association_desc,variety,fiscal_year,created_date,dtl_stats,
				driver_id,equip_id,imple_id,post_status
			) VALUES(
				@hdr_id_insert,@lot_no,@work_operation,@location,@current_area,@soil_type,@date_planted,@ownership,@owner_name,@sub_desc,@variety,@fiscal_year,GETDATE(),'0',
				@driver_id,@approval_equip_id,@approval_imple_id,'0'
			)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

				
			UPDATE tbl_ais_trip_ticket_request_dtl SET status=1 WHERE id=@dtl_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER			
			UPDATE tbl_ais_implements SET status=1 WHERE id=@approval_imple_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			UPDATE tbl_ais_equipments SET status=1 WHERE id=@approval_equip_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			--UPDATE tbl_ais_equipment_driver SET status=1 WHERE id=@driver_id
			--	IF (@@ERROR <> 0) GOTO ERR_HANDLER

			SELECT @cc_dtl=COUNT(id) FROM tbl_ais_trip_ticket_request_dtl WHERE req_hdr_id=@hdr_id AND status <> 1

			if @cc_dtl = 0
				BEGIN
					UPDATE tbl_ais_trip_ticket_request_hdr SET stats= 1 WHERE id = @hdr_id
					IF (@@ERROR <> 0) GOTO ERR_HANDLER
				END
		END		
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  StoredProcedure [dbo].[p_ais_trip_ticket_request_form_delete]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_trip_ticket_request_form_delete](
---INSERT tbl_ais_trip_ticket_hdr
@count int,
@hdr_id int,
@dtl_id int,
@userid int
)
AS

BEGIN
	BEGIN TRAN

	IF @count = 0
		BEGIN		
				DECLARE @tbl table(id int);
				INSERT INTO @tbl
				SELECT id FROM tbl_ais_trip_ticket_request_hdr WHERE user_id =@userid AND req_no IS NULL AND stats = '0'
						 AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
				

				--SELECT * FROM @tbl

				DELETE FROM tbl_ais_trip_ticket_request_dtl WHERE req_hdr_id IN(SELECT * FROM @tbl)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

				DELETE FROM tbl_ais_trip_ticket_request_hdr WHERE id IN(SELECT * FROM @tbl)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END
	ELSE IF @count = 1
		BEGIN		
				DECLARE @ctr int= 0;
				SET @ctr =(SELECT COUNT(id) FROM tbl_ais_trip_ticket_request_dtl WHERE req_hdr_id =@hdr_id AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE())

				WHILE (@ctr >= 0) 
					BEGIN					
						IF (@ctr <> 0)							
							BEGIN
							SET @ctr +=1
								--PRINT 'DELETE DTL'
								DELETE FROM tbl_ais_trip_ticket_request_dtl WHERE id = @dtl_id AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
								IF (@@ERROR <> 0) GOTO ERR_HANDLER

							SET @ctr = 0							
							END
						ELSE
							BEGIN
								SET @ctr =(SELECT COUNT(id) FROM tbl_ais_trip_ticket_request_dtl WHERE req_hdr_id =@hdr_id AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE())
								
									IF (@ctr = 0)
										BEGIN
											DELETE FROM tbl_ais_trip_ticket_request_hdr WHERE id = @hdr_id AND user_id=@userid AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
											IF (@@ERROR <> 0) GOTO ERR_HANDLER
										END
								--DELETE FROM tbl_ais_trip_ticket_request_hdr WHERE id = @hdr_id AND user_id=@userid AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
								--IF (@@ERROR <> 0) GOTO ERR_HANDLER
								BREAK
							END							
					END
		END		
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END
GO
/****** Object:  View [dbo].[v_ais_trip_ticket_request_form]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_trip_ticket_request_form]
AS
SELECT     TOP (100) PERCENT A.id, B.id AS dtl_id, B.work_ope_id, D.category_id, D.cat_desc, C.operation, C.unit_measure, C.rate_cost, A.date_req, REPLICATE('0', 6 - LEN(A.req_no)) 
                      + CAST(A.req_no AS varchar) AS req_no, A.lot_id, E.code, E.location_id, F.location, E.area, E.soil_type, E.owner_name, A.req_order_int, A.user_id, A.stats, A.date_created, G.user_lname, 
                      G.user_fname, G.user_mname, G.user_type, CONVERT(VARCHAR(8), A.time_needed, 108) + ' ' + RIGHT(CONVERT(varchar(30), A.time_needed, 9), 2) AS time_needed, A.purpose, 
                      B.status AS dtl_status
FROM         dbo.tbl_ais_trip_ticket_request_hdr AS A INNER JOIN
                      dbo.tbl_ais_trip_ticket_request_dtl AS B ON A.id = B.req_hdr_id INNER JOIN
                      dbo.tbl_ais_location AS E ON A.lot_id = E.id INNER JOIN
                      dbo.tbl_ais_work_operations AS C ON B.work_ope_id = C.id INNER JOIN
                      dbo.tbl_ais_operation_category AS D ON C.cat_id = D.category_id INNER JOIN
                      dbo.tbl_ais_location_list AS F ON E.location_id = F.id INNER JOIN
                      dbo.tbl_ais_user_account AS G ON A.user_id = G.id
WHERE     (A.stats <> 1)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[5] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 14
               Left = 0
               Bottom = 242
               Right = 160
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 0
               Left = 227
               Bottom = 168
               Right = 387
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "E"
            Begin Extent = 
               Top = 167
               Left = 190
               Bottom = 363
               Right = 350
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "C"
            Begin Extent = 
               Top = 31
               Left = 494
               Bottom = 196
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "D"
            Begin Extent = 
               Top = 46
               Left = 743
               Bottom = 148
               Right = 903
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "F"
            Begin Extent = 
               Top = 197
               Left = 494
               Bottom = 317
               Right = 654
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "G"
            Begin Extent = 
               Top = 90
               Left = 996
               Bottom = 278
               Right = 1156
            End
            DisplayFlags = 280
            TopColumn = 0
         End
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_request_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'     End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 30
         Width = 284
         Width = 1500
         Width = 1500
         Width = 2955
         Width = 1500
         Width = 1500
         Width = 2190
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_request_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_request_form'
GO
/****** Object:  View [dbo].[v_ais_usercontrol_permission]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_usercontrol_permission]
AS
SELECT     dbo.tbl_ais_useraccestlist_menu.menu_name, dbo.tbl_ais_useraccesslist_sub_menu.sub_menu_name, dbo.tbl_ais_usercontrol_permission.useid, dbo.tbl_ais_usercontrol_permission.menuid, 
                      dbo.tbl_ais_usercontrol_permission.submenuid, dbo.tbl_ais_usercontrol_permission.subchildmenuid, dbo.tbl_ais_usercontrol_permission.maintenanceid, dbo.tbl_ais_usercontrol_permission.econdoderid, 
                      dbo.tbl_ais_useraccesslist_sub_child.child_menu_name
FROM         dbo.tbl_ais_user_account INNER JOIN
                      dbo.tbl_ais_usercontrol_permission ON dbo.tbl_ais_user_account.id = dbo.tbl_ais_usercontrol_permission.useid LEFT OUTER JOIN
                      dbo.tbl_ais_useraccesslist_sub_menu ON dbo.tbl_ais_usercontrol_permission.submenuid = dbo.tbl_ais_useraccesslist_sub_menu.id LEFT OUTER JOIN
                      dbo.tbl_ais_useraccesslist_sub_child ON dbo.tbl_ais_usercontrol_permission.subchildmenuid = dbo.tbl_ais_useraccesslist_sub_child.id LEFT OUTER JOIN
                      dbo.tbl_ais_useraccesslist_maintenance ON dbo.tbl_ais_usercontrol_permission.maintenanceid = dbo.tbl_ais_useraccesslist_maintenance.id FULL OUTER JOIN
                      dbo.tbl_ais_useraccestlist_menu ON dbo.tbl_ais_usercontrol_permission.menuid = dbo.tbl_ais_useraccestlist_menu.id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
      Begin ColumnWidths = 17
         Width = 284
         Width = 3375
         Width = 2250
         Width = 1500
         Width = 2370
         Width = 3720
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_usercontrol_permission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_usercontrol_permission'
GO
/****** Object:  View [dbo].[v_ais_trip_ticket_request_form_presentation]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ais_trip_ticket_request_form_presentation]
AS
SELECT  ROW_NUMBER() over (PARTITION BY CONVERT(VARCHAR(12), date_req, 107) ORDER BY req_no,code ASC,date_req DESC,operation,Owner_name ASC) as #
                   ,id,req_no,
                    CASE WHEN ROW_NUMBER() OVER(PARTITION BY CONVERT(VARCHAR(12), date_req, 107) ORDER BY CONVERT(VARCHAR(12), date_created, 107 )) = 1 THEN CONVERT(VARCHAR(12), date_created, 107 ) 
						 ELSE NULL END AS 'date_created',
					CASE WHEN ROW_NUMBER() OVER(PARTITION BY CONVERT(VARCHAR(12), date_req, 107) ORDER BY CONVERT(VARCHAR(12), date_req, 107 )) = 1 THEN CONVERT(VARCHAR(12), date_req, 107) 
						 ELSE NULL END AS 'date_req',
					CASE WHEN ROW_NUMBER() OVER(PARTITION BY CONVERT(VARCHAR(12), date_req, 107) ORDER BY time_needed) = 1 THEN time_needed 
						 ELSE NULL END AS 'time_needed',
					CASE WHEN ROW_NUMBER() OVER(PARTITION BY location,code,CONVERT(VARCHAR(12), date_req, 107) ORDER BY location) = 1 THEN location 
						 ELSE NULL END AS 'location',
					CASE WHEN ROW_NUMBER() OVER(PARTITION BY code,operation,CONVERT(VARCHAR(12), date_req, 107) ORDER BY code) = 1 THEN code 
						 ELSE NULL END AS 'code',
					CASE WHEN ROW_NUMBER() OVER(PARTITION BY operation,CONVERT(VARCHAR(12), date_req, 107) ORDER BY operation) = 1 THEN operation 
						 ELSE NULL END AS 'operation',
					--CASE WHEN ROW_NUMBER() OVER(PARTITION BY  (user_lname + ', ' + user_fname + ' ' + user_mname) ORDER BY  (user_lname + ', ' + user_fname + ' ' + user_mname)) = 1 THEN  (user_lname + ', ' + user_fname + ' ' + user_mname) 
					--	 ELSE NULL END AS 'Fullname'
						 (user_lname + ', ' + user_fname + ' ' + user_mname) as fullname
               FROM v_ais_trip_ticket_request_form
                     WHERE req_no IS NOT NULL AND stats = '0'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_request_form_presentation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ais_trip_ticket_request_form_presentation'
GO
/****** Object:  StoredProcedure [dbo].[p_ais_trip_ticket_request_form_confirm]    Script Date: 06/21/2016 16:54:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_ais_trip_ticket_request_form_confirm](  
@userid int  
)  
AS  
  
BEGIN  
 BEGIN TRAN  
   DECLARE @tbl TABLE(count INT,ID INT,req_order VARCHAR(50))  
   DECLARE @counter_max INT  
   DECLARE @counter_minimum INT = 0  
   DECLARE @Series_start INT  
   DECLARE @id VARCHAR(50) 
  
   INSERT INTO @tbl  
   SELECT ROW_NUMBER() over (ORDER BY id ASC) as #,id,req_order_int FROM v_ais_trip_ticket_request_form   
   WHERE user_id =@userid AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()  
   --SELECT * FROM @tbl
  
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   SELECT @counter_max = Count(id) FROM v_ais_trip_ticket_request_form   
   WHERE user_id =@userid AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()  
  
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   SELECT TOP 1 @Series_start = req_no FROM tbl_ais_trip_ticket_request_hdr GROUP BY req_no ORDER BY req_no DESC  
  
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   WHILE @counter_minimum < @counter_max  
    BEGIN     
     SET @counter_minimum +=1   
      IF (@Series_start IS NULL)  
       BEGIN  
        SET @Series_start = 0  
       END  
     --SET @Series_start += 1  
  
     --SELECT @id = req_order FROM @tbl WHERE count = @counter_minimum  
    
     --UPDATE tbl_ais_trip_ticket_request_hdr SET req_no=@Series_start WHERE req_order_int = @id  
     -- IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
    END  
         SET @Series_start += 1  

      SELECT @id = req_order FROM @tbl WHERE count = @counter_minimum  
    
     UPDATE tbl_ais_trip_ticket_request_hdr SET req_no=@Series_start WHERE req_order_int = @id  
      IF (@@ERROR <> 0) GOTO ERR_HANDLER
      
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
 COMMIT TRAN  
  
 RETURN 0  
  
 ERR_HANDLER:  
 PRINT 'Unexpected error occurred!'  
 ROLLBACK TRAN  
 RETURN 1      
END
GO
/****** Object:  ForeignKey [FK_tbl_ais_work_operations_tbl_ais_operation_category]    Script Date: 06/21/2016 16:54:43 ******/
ALTER TABLE [dbo].[tbl_ais_work_operations]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_work_operations_tbl_ais_operation_category] FOREIGN KEY([cat_id])
REFERENCES [dbo].[tbl_ais_operation_category] ([category_id])
GO
ALTER TABLE [dbo].[tbl_ais_work_operations] CHECK CONSTRAINT [FK_tbl_ais_work_operations_tbl_ais_operation_category]
GO
/****** Object:  ForeignKey [FK_tbl_ais_location_tbl_ais_location_list]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_location]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_location_tbl_ais_location_list] FOREIGN KEY([location_id])
REFERENCES [dbo].[tbl_ais_location_list] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_location] CHECK CONSTRAINT [FK_tbl_ais_location_tbl_ais_location_list]
GO
/****** Object:  ForeignKey [FK_tbl_ais_useraccesslist_sub_menu_tbl_ais_useraccestlist_menu]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_useraccesslist_sub_menu]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_useraccesslist_sub_menu_tbl_ais_useraccestlist_menu] FOREIGN KEY([menu_id])
REFERENCES [dbo].[tbl_ais_useraccestlist_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_useraccesslist_sub_menu] CHECK CONSTRAINT [FK_tbl_ais_useraccesslist_sub_menu_tbl_ais_useraccestlist_menu]
GO
/****** Object:  ForeignKey [FK_tbl_ais_equipments_tbl_ais_equipment_brand]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_equipments]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_equipments_tbl_ais_equipment_brand] FOREIGN KEY([brand_id])
REFERENCES [dbo].[tbl_ais_equipment_brand] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_equipments] CHECK CONSTRAINT [FK_tbl_ais_equipments_tbl_ais_equipment_brand]
GO
/****** Object:  ForeignKey [FK_tbl_ais_equipments_tbl_ais_equipment_type]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_equipments]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_equipments_tbl_ais_equipment_type] FOREIGN KEY([type_id])
REFERENCES [dbo].[tbl_ais_equipment_type] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_equipments] CHECK CONSTRAINT [FK_tbl_ais_equipments_tbl_ais_equipment_type]
GO
/****** Object:  ForeignKey [FK_tbl_ais_equipments_tbl_ais_owner_name]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_equipments]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_equipments_tbl_ais_owner_name] FOREIGN KEY([owner_id])
REFERENCES [dbo].[tbl_ais_owner_name] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_equipments] CHECK CONSTRAINT [FK_tbl_ais_equipments_tbl_ais_owner_name]
GO
/****** Object:  ForeignKey [FK_tbl_ais_location_info_tbl_ais_location]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_location_info]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_location_info_tbl_ais_location] FOREIGN KEY([lot_id])
REFERENCES [dbo].[tbl_ais_location] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_location_info] CHECK CONSTRAINT [FK_tbl_ais_location_info_tbl_ais_location]
GO
/****** Object:  ForeignKey [FK_tbl_ais_location_info_tbl_ais_location_association]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_location_info]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_location_info_tbl_ais_location_association] FOREIGN KEY([association_id])
REFERENCES [dbo].[tbl_ais_location_association] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_location_info] CHECK CONSTRAINT [FK_tbl_ais_location_info_tbl_ais_location_association]
GO
/****** Object:  ForeignKey [FK_tbl_ais_location_info_tbl_ais_location_variety]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_location_info]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_location_info_tbl_ais_location_variety] FOREIGN KEY([variety_id])
REFERENCES [dbo].[tbl_ais_location_variety] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_location_info] CHECK CONSTRAINT [FK_tbl_ais_location_info_tbl_ais_location_variety]
GO
/****** Object:  ForeignKey [FK_tbl_ais_trip_ticket_request_hdr_tbl_ais_location]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_hdr]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_trip_ticket_request_hdr_tbl_ais_location] FOREIGN KEY([lot_id])
REFERENCES [dbo].[tbl_ais_location] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_hdr] CHECK CONSTRAINT [FK_tbl_ais_trip_ticket_request_hdr_tbl_ais_location]
GO
/****** Object:  ForeignKey [FK_tbl_ais_trip_ticket_request_hdr_tbl_ais_user_account]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_hdr]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_trip_ticket_request_hdr_tbl_ais_user_account] FOREIGN KEY([user_id])
REFERENCES [dbo].[tbl_ais_user_account] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_hdr] CHECK CONSTRAINT [FK_tbl_ais_trip_ticket_request_hdr_tbl_ais_user_account]
GO
/****** Object:  ForeignKey [FK_tbl_ais_useraccesslist_sub_child_tbl_ais_useraccesslist_sub_menu]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_useraccesslist_sub_child]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_useraccesslist_sub_child_tbl_ais_useraccesslist_sub_menu] FOREIGN KEY([sub_menu_id])
REFERENCES [dbo].[tbl_ais_useraccesslist_sub_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_useraccesslist_sub_child] CHECK CONSTRAINT [FK_tbl_ais_useraccesslist_sub_child_tbl_ais_useraccesslist_sub_menu]
GO
/****** Object:  ForeignKey [FK_tbl_ais_usercontrol_permission_tbl_ais_user_account]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_user_account] FOREIGN KEY([useid])
REFERENCES [dbo].[tbl_ais_user_account] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_user_account]
GO
/****** Object:  ForeignKey [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_maintenance]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_maintenance] FOREIGN KEY([maintenanceid])
REFERENCES [dbo].[tbl_ais_useraccesslist_maintenance] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_maintenance]
GO
/****** Object:  ForeignKey [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_sub_child]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_sub_child] FOREIGN KEY([subchildmenuid])
REFERENCES [dbo].[tbl_ais_useraccesslist_sub_child] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_sub_child]
GO
/****** Object:  ForeignKey [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_sub_menu]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_sub_menu] FOREIGN KEY([submenuid])
REFERENCES [dbo].[tbl_ais_useraccesslist_sub_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccesslist_sub_menu]
GO
/****** Object:  ForeignKey [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccestlist_menu]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccestlist_menu] FOREIGN KEY([menuid])
REFERENCES [dbo].[tbl_ais_useraccestlist_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_ais_usercontrol_permission_tbl_ais_useraccestlist_menu]
GO
/****** Object:  ForeignKey [FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_trip_ticket_request_hdr]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_dtl]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_trip_ticket_request_hdr] FOREIGN KEY([req_hdr_id])
REFERENCES [dbo].[tbl_ais_trip_ticket_request_hdr] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_dtl] CHECK CONSTRAINT [FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_trip_ticket_request_hdr]
GO
/****** Object:  ForeignKey [FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_work_operations]    Script Date: 06/21/2016 16:54:46 ******/
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_dtl]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_work_operations] FOREIGN KEY([work_ope_id])
REFERENCES [dbo].[tbl_ais_work_operations] ([id])
GO
ALTER TABLE [dbo].[tbl_ais_trip_ticket_request_dtl] CHECK CONSTRAINT [FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_work_operations]
GO
