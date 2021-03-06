USE [master]
GO
/****** Object:  Database [AIS_Database]    Script Date: 6/17/2016 6:15:15 AM ******/
CREATE DATABASE [AIS_Database] ON  PRIMARY 
( NAME = N'AIS_Database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AIS_Database.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AIS_Database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AIS_Database_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AIS_Database] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AIS_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AIS_Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AIS_Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AIS_Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AIS_Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AIS_Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [AIS_Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AIS_Database] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AIS_Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AIS_Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AIS_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AIS_Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AIS_Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AIS_Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AIS_Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AIS_Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AIS_Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AIS_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AIS_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AIS_Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AIS_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AIS_Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AIS_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AIS_Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AIS_Database] SET RECOVERY FULL 
GO
ALTER DATABASE [AIS_Database] SET  MULTI_USER 
GO
ALTER DATABASE [AIS_Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AIS_Database] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AIS_Database', N'ON'
GO
USE [AIS_Database]
GO
/****** Object:  StoredProcedure [dbo].[p_equipment_masterlist_add]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_equipment_masterlist_add]
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

		INSERT tbl_equipments(owner_id,type_id,brand_id,model,cr_no,motor_no,serial_no,mv_file_no,si_no,dr_no,others,date_proof,acquisition_cost,status,date_created) 
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
/****** Object:  StoredProcedure [dbo].[p_equipment_masterlist_delete]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_equipment_masterlist_delete]
@id int
AS

BEGIN
	BEGIN TRAN
		DELETE FROM tbl_equipments WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1		
END

GO
/****** Object:  StoredProcedure [dbo].[p_equipment_masterlist_update]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_equipment_masterlist_update]
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
		UPDATE tbl_equipments SET owner_id=@owner_id,type_id=@type_id,brand_id=@brand_id,model=@model,cr_no=@cr_no,motor_no=@motor_no,
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
/****** Object:  StoredProcedure [dbo].[p_implement_masterlist_add]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_implement_masterlist_add]
@owner_id int,
@lists_id int,
@code nvarchar(50),
@desc varchar(50)

AS

BEGIN
	BEGIN TRAN

		INSERT tbl_implements(owner_id,list_id,code,description,created_date,status) VALUES(@owner_id,@lists_id,@code,@desc,GETDATE(),'0')
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END

GO
/****** Object:  StoredProcedure [dbo].[p_implement_masterlist_delete]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_implement_masterlist_delete]
@id int
AS

BEGIN
	BEGIN TRAN
		DELETE FROM tbl_implements WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1		
END

GO
/****** Object:  StoredProcedure [dbo].[p_implement_masterlist_update]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_implement_masterlist_update]
@owner_id int,
@list_id int,
@code nvarchar(50),
@desc varchar(50),
@id int
AS

BEGIN
	BEGIN TRAN
		UPDATE tbl_implements SET owner_id=@owner_id,list_id=@list_id,code=@code,description=@desc,modify_date=GETDATE()
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
/****** Object:  StoredProcedure [dbo].[p_insert_location_info_update_main_location]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_insert_location_info_update_main_location](
---INSERT tbl_location_info
@lot_id int,
@date_planted datetime,
@ownership varchar(50),
@variety_id int,
@association_id int,
@water_source bit,
@fiscal_year varchar(50),
---UPDATE tbl_location
@id int
)
AS

BEGIN
	DECLARE @info_id int;
	BEGIN TRAN
	---INSERT tbl_location_info
		INSERT tbl_location_info(lot_id,date_planted,ownership,variety_id,association_id,water_source,fiscal_year,date_create)
		VALUES (@lot_id,@date_planted,@ownership,@variety_id,@association_id,@water_source,@fiscal_year,GETDATE())
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	SELECT TOP 1 @info_id = id FROM tbl_location_info ORDER by id DESC
	
	---UPDATE tbl_location
		UPDATE tbl_location SET info_id = @info_id WHERE id=@id

	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END

GO
/****** Object:  StoredProcedure [dbo].[p_location_info_delete]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[p_location_info_delete](
@id int
)
AS
BEGIN
	BEGIN TRAN
		DELETE FROM tbl_location_info WHERE id = @id		
				
		IF (@@ERROR <> 0) GOTO ERR_HANDLER

		UPDATE tbl_location SET info_id = NULL WHERE info_id = @id	

		IF (@@ERROR <> 0) GOTO ERR_HANDLER

	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1
END

GO
/****** Object:  StoredProcedure [dbo].[p_location_info_update]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[p_location_info_update](
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
			UPDATE tbl_location_info SET date_planted=@date_planted,ownership=@ownership,
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
/****** Object:  StoredProcedure [dbo].[p_main_location_add]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_main_location_add]
	@code varchar(50),
	@loc_id int,
	@area nvarchar(50),
	@soiltype varchar(50),
	@owner_name varchar(50)
AS

BEGIN
	BEGIN TRAN
	---INSERT tbl_location_info
		INSERT INTO tbl_location(code,location_id,area,soil_type,owner_name,date_created) 
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
/****** Object:  StoredProcedure [dbo].[p_main_location_update]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_main_location_update]
	@loc_id int,
	@code varchar(50),
	@area nvarchar(50),
	@soiltype varchar(50),
	@id int,
	@owner_name varchar(50)
AS

BEGIN
	BEGIN TRAN
	---UPDATE tbl_location_info
		UPDATE tbl_location SET location_id=@loc_id,code =@code, 
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
/****** Object:  StoredProcedure [dbo].[p_trip_ticket_approval_add]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_trip_ticket_approval_add](
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

	SET @count = (SELECT COUNT(id) FROM tbl_trip_ticket_schedule_hdr WHERE reg_no = @reg_no)

	IF @count = 0
		BEGIN
		
			SELECT TOP 1 @owner_equip = B.owner_name FROM tbl_equipments A INNER JOIN tbl_owner_name B 
			ON A.owner_id=B.id INNER JOIN tbl_equipment_type C 
			ON A.type_id=C.id WHERE A.model=@equip_no AND C.equipment_type=@equip_type
			
  
			SELECT TOP 1 @owner_imple = B.owner_name FROM tbl_implements A INNER JOIN tbl_owner_name B 
			ON A.owner_id=B.id WHERE A.code	=@imple_code AND A.description=@imple_desc
			

			SELECT top 1 @trip_ticket_no= trip_ticket_no FROM tbl_trip_ticket_schedule_hdr WHERE trip_ticket_no IS NOT NULL ORDER BY trip_ticket_no DESC

			SET @trip_ticket_no += 1

			-----HEADER INSERTION
			INSERT tbl_trip_ticket_schedule_hdr(
				reg_no,trip_ticket_no,trip_date,equip_type,equip_no,imple_desc,imple_code,driver,purpose,need_date,need_time,requested_by,approved_by,
				equip_timeout,equip_timein,jobsite_arrival_time,jobsite_departure_time,remarks,work_accepted_by,noted_by,jtmo_no,check_jtmo_by,status,
				create_date,user_id,owner_equip,owner_imple
			) VALUES(
				@reg_no,@trip_ticket_no,@trip_date,@equip_type,@equip_no,@imple_desc,@imple_code,@driver,@purpose,@need_date,@need_time,@requested_by,@approved_by,
				'','','','','','','','','','0',GETDATE(),@user_id,@owner_equip,@owner_imple
			)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

			-------SELECT LAST INSERT HEADER ID
			SELECT TOP 1 @hdr_id_insert = id FROM tbl_trip_ticket_schedule_hdr WHERE reg_no = @reg_no

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
			 FROM v_location_maindata WHERE id=@lot_id			

			-------DETAIL INSERTION
			INSERT tbl_trip_ticket_schedule_dtl(
				hdr_id,lot_no,work_operation,location,current_area,soill_type,date_planted,ownership,lot_owner_name,association_desc,variety,fiscal_year,created_date,dtl_stats,
				driver_id,equip_id,imple_id,post_status
			) VALUES(
				@hdr_id_insert,@lot_no,@work_operation,@location,@current_area,@soil_type,@date_planted,@ownership,@owner_name,@sub_desc,@variety,@fiscal_year,GETDATE(),'0',
				@driver_id,@approval_equip_id,@approval_imple_id,'0'
			)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

				
			UPDATE tbl_trip_ticket_request_dtl SET status=1 WHERE id=@dtl_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER			
			UPDATE tbl_implements SET status=1 WHERE id=@approval_imple_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			UPDATE tbl_equipments SET status=1 WHERE id=@approval_equip_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			UPDATE tbl_equipment_driver SET status=1 WHERE id=@driver_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

			SELECT @cc_dtl=COUNT(id) FROM tbl_trip_ticket_request_dtl WHERE req_hdr_id=@hdr_id AND status <> 1

			if @cc_dtl = 0
				BEGIN
					UPDATE tbl_trip_ticket_request_hdr SET stats= 1 WHERE id = @hdr_id
					IF (@@ERROR <> 0) GOTO ERR_HANDLER
				END
		END
	ELSE
		BEGIN

			-------SELECT LAST INSERT HEADER ID
			SELECT TOP 1 @hdr_id_insert = id FROM tbl_trip_ticket_schedule_hdr WHERE reg_no = @reg_no

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
			 FROM v_location_maindata WHERE id=@lot_id			

			-------DETAIL INSERTION
			INSERT tbl_trip_ticket_schedule_dtl(
				hdr_id,lot_no,work_operation,location,current_area,soill_type,date_planted,ownership,lot_owner_name,association_desc,variety,fiscal_year,created_date,dtl_stats,
				driver_id,equip_id,imple_id,post_status
			) VALUES(
				@hdr_id_insert,@lot_no,@work_operation,@location,@current_area,@soil_type,@date_planted,@ownership,@owner_name,@sub_desc,@variety,@fiscal_year,GETDATE(),'0',
				@driver_id,@approval_equip_id,@approval_imple_id,'0'
			)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

				
			UPDATE tbl_trip_ticket_request_dtl SET status=1 WHERE id=@dtl_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER			
			UPDATE tbl_implements SET status=1 WHERE id=@approval_imple_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			UPDATE tbl_equipments SET status=1 WHERE id=@approval_equip_id
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
			--UPDATE tbl_equipment_driver SET status=1 WHERE id=@driver_id
			--	IF (@@ERROR <> 0) GOTO ERR_HANDLER

			SELECT @cc_dtl=COUNT(id) FROM tbl_trip_ticket_request_dtl WHERE req_hdr_id=@hdr_id AND status <> 1

			if @cc_dtl = 0
				BEGIN
					UPDATE tbl_trip_ticket_request_hdr SET stats= 1 WHERE id = @hdr_id
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
/****** Object:  StoredProcedure [dbo].[p_trip_ticket_request_form_add]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_trip_ticket_request_form_add](
---INSERT tbl_trip_ticket_hdr
@date_req Datetime,
@lot_id int,
@req_order_id nvarchar(50),

---INSERT tbl_trip_ticket_dtl
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

	SET @count = (SELECT COUNT(id) FROM tbl_trip_ticket_request_hdr WHERE lot_id = @lot_id AND req_order_int = @req_order_id AND date_req=@date_req)

	IF @count = 0
		BEGIN
			INSERT tbl_trip_ticket_request_hdr(date_req,lot_id,req_order_int,date_created,user_id,stats,time_needed,purpose) VALUES(@date_req,@lot_id,@req_order_id,GETDATE(),@user_id,@stats,@time_needed,@purpose)			
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

			SELECT TOP 1 @hdr_id = id FROM tbl_trip_ticket_request_hdr WHERE lot_id = @lot_id AND req_order_int = @req_order_id AND date_req=@date_req ORDER by id DESC
			INSERT tbl_trip_ticket_request_dtl(req_hdr_id,work_ope_id,date_created,status) VALUES(@hdr_id,@work_ope_id,GETDATE(),'0')
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END
	ELSE
		BEGIN
			SELECT TOP 1 @hdr_id = id FROM tbl_trip_ticket_request_hdr WHERE lot_id = @lot_id AND req_order_int = @req_order_id AND date_req=@date_req ORDER by id DESC
			INSERT tbl_trip_ticket_request_dtl(req_hdr_id,work_ope_id,date_created,status) VALUES(@hdr_id,@work_ope_id,GETDATE(),'0')
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
/****** Object:  StoredProcedure [dbo].[p_trip_ticket_request_form_confirm]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_trip_ticket_request_form_confirm](  
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
   SELECT ROW_NUMBER() over (ORDER BY id ASC) as #,id,req_order_int FROM v_trip_ticket_request_form   
   WHERE user_id =@userid AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()  
   --SELECT * FROM @tbl
  
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   SELECT @counter_max = Count(id) FROM v_trip_ticket_request_form   
   WHERE user_id =@userid AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()  
  
   IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
   SELECT TOP 1 @Series_start = req_no FROM tbl_trip_ticket_request_hdr GROUP BY req_no ORDER BY req_no DESC  
  
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
    
     --UPDATE tbl_trip_ticket_request_hdr SET req_no=@Series_start WHERE req_order_int = @id  
     -- IF (@@ERROR <> 0) GOTO ERR_HANDLER  
  
    END  
         SET @Series_start += 1  

      SELECT @id = req_order FROM @tbl WHERE count = @counter_minimum  
    
     UPDATE tbl_trip_ticket_request_hdr SET req_no=@Series_start WHERE req_order_int = @id  
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
/****** Object:  StoredProcedure [dbo].[p_trip_ticket_request_form_delete]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_trip_ticket_request_form_delete](
---INSERT tbl_trip_ticket_hdr
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
				SELECT id FROM tbl_trip_ticket_request_hdr WHERE user_id =@userid AND req_no IS NULL AND stats = '0'
						 AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
				

				--SELECT * FROM @tbl

				DELETE FROM tbl_trip_ticket_request_dtl WHERE req_hdr_id IN(SELECT * FROM @tbl)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER

				DELETE FROM tbl_trip_ticket_request_hdr WHERE id IN(SELECT * FROM @tbl)
				IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END
	ELSE IF @count = 1
		BEGIN		
				DECLARE @ctr int= 0;
				SET @ctr =(SELECT COUNT(id) FROM tbl_trip_ticket_request_dtl WHERE req_hdr_id =@hdr_id AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE())

				WHILE (@ctr >= 0) 
					BEGIN					
						IF (@ctr <> 0)							
							BEGIN
							SET @ctr +=1
								--PRINT 'DELETE DTL'
								DELETE FROM tbl_trip_ticket_request_dtl WHERE id = @dtl_id AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
								IF (@@ERROR <> 0) GOTO ERR_HANDLER

							SET @ctr = 0							
							END
						ELSE
							BEGIN
								SET @ctr =(SELECT COUNT(id) FROM tbl_trip_ticket_request_dtl WHERE req_hdr_id =@hdr_id AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE())
								
									IF (@ctr = 0)
										BEGIN
											DELETE FROM tbl_trip_ticket_request_hdr WHERE id = @hdr_id AND user_id=@userid AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
											IF (@@ERROR <> 0) GOTO ERR_HANDLER
										END
								--DELETE FROM tbl_trip_ticket_request_hdr WHERE id = @hdr_id AND user_id=@userid AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()
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
/****** Object:  StoredProcedure [dbo].[p_trip_ticket_schedule_process]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_trip_ticket_schedule_process](  
@userid INT,  
@hdr_id INT,
---TBL_SCHEDU:E_HDR
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

---TBL_SCHEDULE_DTL
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
    
		SELECT @counting_dtl = COUNT(*) FROM v_trip_ticket_schedule_form WHERE dtl_stats <> '2' AND accomplished_by IS NULL AND hdr_id=@v_hdr_id
		
		---TBL_SCHEDULE_HEADER
			IF @counting_dtl = 0
				BEGIN
					UPDATE tbl_trip_ticket_schedule_hdr SET equip_timeout = @equip_timeout,equip_timein = @equip_timein,jobsite_arrival_time=@jobsite_arrival,jobsite_departure_time=@jobsite_departure,
								remarks=@remarks,work_accepted_by=@work_accepted,noted_by=@noted_by,accomplished_by=@noted_by,accomplished_date=GETDATE(),status='1' WHERE id=@v_hdr_id
						  IF (@@ERROR <> 0) GOTO ERR_HANDLER  
				END
			ELSE
				BEGIN
					UPDATE tbl_trip_ticket_schedule_hdr SET equip_timeout = @equip_timeout,equip_timein = @equip_timein,jobsite_arrival_time=@jobsite_arrival,jobsite_departure_time=@jobsite_departure,
								remarks=@remarks,work_accepted_by=@work_accepted,noted_by=@noted_by  WHERE id=@v_hdr_id
						  IF (@@ERROR <> 0) GOTO ERR_HANDLER  
				END
	  
		---TBL_SCHEDULE_DETAILS

		SELECT @time_start=time_started,@time_stopped=time_stopped,@operate_hrs=operate_hours,@area_done=area_done FROM tbl_trip_ticket_schedule_dtl WHERE id=@v_dtl_id

		
		DECLARE @r_cost DECIMAL(19,2)
		DECLARE @result DECIMAL(19,2)
		SELECT @r_cost= rate_cost FROM tbl_work_operations WHERE operation=@operation

		SET @result =( @area_done*@r_cost)

		UPDATE tbl_trip_ticket_schedule_dtl SET time_started=@time_start,time_stopped=@time_stopped,operate_hours=@operate_hrs,area_done=@area_done,
				rate_per_area=@r_cost,amount=@result,dtl_stats=2 WHERE id=@v_dtl_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER  

		 UPDATE tbl_equipment_driver SET status='0' WHERE id=@v_driver_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER

		  UPDATE tbl_equipments SET status='0' WHERE id=@v_equip_id
		 IF (@@ERROR <> 0) GOTO ERR_HANDLER

		  UPDATE tbl_implements SET status='0' WHERE id=@v_imple_id
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



--SELECT * FROM v_trip_ticket_schedule_form

--SELECT * FROM tbl_equipment_driver WHERE id = 4
--SELECT * FROM tbl_equipments WHERE id = 5
--SELECT * FROM tbl_implements WHERE id = 6

GO
/****** Object:  StoredProcedure [dbo].[p_usercontrol_add_modify]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_usercontrol_add_modify]
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
			INSERT INTO tbl_user_account(username,password,user_fname,user_mname,user_lname,user_type,who_save,save_date,type_index) 
				VALUES(@username,@password,@fname,@mname,@lname,@usertype,@encodername,GETDATE(),@index_type)
			
			IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END

	if @flag = 2
		BEGIN
			UPDATE tbl_user_account SET username=@username,password=@password,user_fname=@fname,user_mname=@mname,user_lname=@lname
										,user_type=@usertype,who_modify=@encodername,modify_date=GETDATE(),type_index=@index_type FROM tbl_user_account WHERE id=@D_id
			
			IF (@@ERROR <> 0) GOTO ERR_HANDLER
		END
	if @flag = 3 
		BEGIN
			DELETE FROM tbl_user_account WHERE id =@D_id
		END
					
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END

GO
/****** Object:  StoredProcedure [dbo].[p_usercontrol_permission_list]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_usercontrol_permission_list]
	@USERID AS INT = NULL,
	@ID AS INT = NULL,
	@FLAG AS INT = NULL
AS

BEGIN
	BEGIN TRAN
	DECLARE @user_id AS INT;

	SELECT @user_id= useid FROM tbl_usercontrol_permission WHERE useid = @USERID

			IF @FLAG = 0 ---MENU ACCESS
				BEGIN
					IF @user_id <> 0 
						BEGIN
							  SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.menu_name,useid,menuid
							  FROM tbl_useraccestlist_menu A LEFT OUTER JOIN tbl_usercontrol_permission B ON A.id=B.menuid
							  WHERE useid = @USERID OR useid IS NULL GROUP BY A.id,A.menu_name,useid,menuid

							-- IF (@@ERROR <> 0) GOTO ERR_HANDLER
						END
					ELSE
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,menu_name,useid=NULL,menuid=NULL FROM tbl_useraccestlist_menu
						END			
				END
			IF @FLAG = 1 ---SUB MENU ACCESS
				BEGIN
					IF @user_id <> 0
						BEGIN
						
							 SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.sub_menu_name,b.useid,b.submenuid
							 FROM tbl_useraccesslist_sub_menu A LEFT OUTER JOIN tbl_usercontrol_permission B ON A.id=B.submenuid
							 WHERE (B.useid = @USERID OR B.useid IS NULL) AND (A.menu_id = @ID AND A.menu_id IS NOT NULL)  ---OR B.submenuid IS NULL
							 GROUP BY A.id,A.sub_menu_name,b.useid,b.submenuid
						END
				
					ELSE
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,sub_menu_name,useid=NULL,submenuid=NULL FROM tbl_useraccesslist_sub_menu WHERE menu_id = @ID
						END
				END
			IF @FLAG = 2 ---SUB CHILD MENU ACCESS
				BEGIN
					IF @user_id <> 0
						BEGIN
							SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.child_menu_name,useid,subchildmenuid
							FROM tbl_useraccesslist_sub_child A LEFT OUTER JOIN tbl_usercontrol_permission B ON A.id=B.subchildmenuid
							WHERE (B.useid = @USERID OR B.useid IS NULL) AND (A.sub_menu_id = @ID AND A.sub_menu_id IS NOT NULL) ---OR B.subchildmenuid IS NULL
							GROUP BY A.id,A.child_menu_name,useid,subchildmenuid
						END
					ELSE
						BEGIN
							SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,child_menu_name,useid=NULL,subchildmenuid=NULL FROM tbl_useraccesslist_sub_child WHERE sub_menu_id = @ID
						END
				END
			IF @FLAG = 3 ---ACCESS MAINTENANCE
				BEGIN	
					IF @user_id <> 0 
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY A.id ASC) as #, A.id,A.maintenace_name,useid,maintenanceid
							 FROM tbl_useraccesslist_maintenance A LEFT OUTER JOIN tbl_usercontrol_permission B ON A.id=B.maintenanceid
							 WHERE (B.useid = @USERID OR B.useid IS NULL) AND (B.menuid = @ID OR B.maintenanceid IS NULL)
							 GROUP BY A.id,A.maintenace_name,useid,maintenanceid
						END
					ELSE
						BEGIN
							 SELECT ROW_NUMBER() over (ORDER BY id ASC) as #, id,maintenace_name,useid=NULL,maintenanceid=NULL FROM tbl_useraccesslist_maintenance
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
/****** Object:  StoredProcedure [dbo].[p_workoperation_masterlist_add]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_workoperation_masterlist_add]
@categ_id int,
@operation varchar(50),
@unit nvarchar(20),
@rate decimal(19,4)

AS

BEGIN
	BEGIN TRAN

		INSERT tbl_work_operations(cat_id,operation,unit_measure,rate_cost,date_created) VALUES(@categ_id,@operation,@unit,@rate,GETDATE())
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END

GO
/****** Object:  StoredProcedure [dbo].[p_workoperation_masterlist_delete]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_workoperation_masterlist_delete]
@id int

AS

BEGIN
	BEGIN TRAN

		DELETE FROM tbl_work_operations WHERE id=@id
			
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
				
	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:
	PRINT 'Unexpected error occurred!'
	ROLLBACK TRAN
	RETURN 1				
END

GO
/****** Object:  StoredProcedure [dbo].[p_workoperation_masterlist_update]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[p_workoperation_masterlist_update]
@categ_id int,
@operation varchar(50),
@unit nvarchar(20),
@rate decimal(19,4),
@id int

AS

BEGIN
	BEGIN TRAN

		UPDATE tbl_work_operations SET cat_id=@categ_id,operation=@operation,unit_measure=@unit,rate_cost=@rate,date_modify=GETDATE()
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
/****** Object:  Table [dbo].[tbl_equipment_brand]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_equipment_brand](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[equipment_brand] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_equipment_brand] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_equipment_driver]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_equipment_driver](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[driver_name] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_equipment_driver] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_equipment_type]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_equipment_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[equipment_type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_equipment_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_equipments]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_equipments](
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
 CONSTRAINT [PK_tbl_equipments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_form_type]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_form_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_form_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_implement_list]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_implement_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_implements]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_implements](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[owner_id] [int] NOT NULL,
	[list_id] [int] NOT NULL,
	[code] [varchar](50) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
	[created_date] [datetime] NULL,
	[modify_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_implements] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_location]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_location](
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
 CONSTRAINT [PK_tbl_location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_location_association]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_location_association](
	[id] [int] NOT NULL,
	[sub_desc] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_location_association] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_location_info]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_location_info](
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
 CONSTRAINT [PK_tbl_location_info] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_location_list]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_location_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[location] [varchar](50) NOT NULL,
	[municipality] [varchar](50) NOT NULL,
	[province] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_location_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_location_variety]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_location_variety](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[variety] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_location_variety] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_operation_category]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_operation_category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_desc] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_operation_category] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_owner_name]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_owner_name](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_name] [int] NOT NULL,
	[owner_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_equipment_ownername] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_trip_ticket_request_dtl]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_trip_ticket_request_dtl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[req_hdr_id] [int] NOT NULL,
	[work_ope_id] [int] NOT NULL,
	[date_created] [datetime] NULL,
	[date_modified] [datetime] NULL,
	[date_deleted] [datetime] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_tbl_trip_ticket_request_dtl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_trip_ticket_request_hdr]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_trip_ticket_request_hdr](
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
 CONSTRAINT [PK_tbl_trip_ticket_request_hdr] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_trip_ticket_schedule_dtl]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_trip_ticket_schedule_dtl](
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
 CONSTRAINT [PK_tbl_trip_ticket_schedule_dtl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_trip_ticket_schedule_hdr]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_trip_ticket_schedule_hdr](
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
 CONSTRAINT [PK_tbl_trip_ticket_schedule_hdr] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_user_account]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_user_account](
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
 CONSTRAINT [PK_tbl_user_account] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_useraccesslist_maintenance]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_useraccesslist_maintenance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maintenace_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_useraccesslist_maintenance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_useraccesslist_sub_child]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_useraccesslist_sub_child](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sub_menu_id] [int] NOT NULL,
	[child_menu_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_useraccesslist_sub_child] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_useraccesslist_sub_menu]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_useraccesslist_sub_menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[menu_id] [int] NOT NULL,
	[sub_menu_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_useraccesslist_sub_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_useraccestlist_menu]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_useraccestlist_menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[menu_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_useraccestlist_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_usercontrol_permission]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usercontrol_permission](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[useid] [int] NULL,
	[menuid] [int] NULL,
	[submenuid] [int] NULL,
	[subchildmenuid] [int] NULL,
	[maintenanceid] [int] NULL,
	[econdoderid] [int] NULL,
 CONSTRAINT [PK_tbl_usercontrol_permission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_work_operations]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_work_operations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cat_id] [int] NOT NULL,
	[operation] [varchar](50) NOT NULL,
	[unit_measure] [varchar](20) NOT NULL,
	[rate_cost] [decimal](19, 4) NOT NULL,
	[date_created] [datetime] NULL,
	[date_modify] [datetime] NULL,
	[date_delete] [datetime] NULL,
 CONSTRAINT [PK_tbl_work_operations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_trip_ticket_request_form]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_trip_ticket_request_form]
AS
SELECT     TOP (100) PERCENT A.id, B.id AS dtl_id, B.work_ope_id, D.category_id, D.cat_desc, C.operation, C.unit_measure, C.rate_cost, A.date_req, REPLICATE('0', 6 - LEN(A.req_no)) 
                      + CAST(A.req_no AS varchar) AS req_no, A.lot_id, E.code, E.location_id, F.location, E.area, E.soil_type, E.owner_name, A.req_order_int, A.user_id, A.stats, A.date_created, G.user_lname, 
                      G.user_fname, G.user_mname, G.user_type, CONVERT(VARCHAR(8), A.time_needed, 108) + ' ' + RIGHT(CONVERT(varchar(30), A.time_needed, 9), 2) AS time_needed, A.purpose, 
                      B.status AS dtl_status
FROM         dbo.tbl_trip_ticket_request_hdr AS A INNER JOIN
                      dbo.tbl_trip_ticket_request_dtl AS B ON A.id = B.req_hdr_id INNER JOIN
                      dbo.tbl_location AS E ON A.lot_id = E.id INNER JOIN
                      dbo.tbl_work_operations AS C ON B.work_ope_id = C.id INNER JOIN
                      dbo.tbl_operation_category AS D ON C.cat_id = D.category_id INNER JOIN
                      dbo.tbl_location_list AS F ON E.location_id = F.id INNER JOIN
                      dbo.tbl_user_account AS G ON A.user_id = G.id
WHERE     (A.stats <> 1)

GO
/****** Object:  View [dbo].[v_trip_ticket_request_form_presentation]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_trip_ticket_request_form_presentation]
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
               FROM v_trip_ticket_request_form
                     WHERE req_no IS NOT NULL AND stats = '0'

GO
/****** Object:  UserDefinedFunction [dbo].[fnSplit]    Script Date: 6/17/2016 6:15:15 AM ******/
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
/****** Object:  View [dbo].[v_equipment_masterlist]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_equipment_masterlist]
AS
SELECT     A.id, A.owner_id, A.type_id, A.brand_id, B.owner_name, C.equipment_type, D.equipment_brand, A.model, A.cr_no, A.motor_no, A.serial_no, A.mv_file_no, A.si_no, A.dr_no, A.others, A.date_proof, 
                      A.acquisition_cost, A.status
FROM         dbo.tbl_equipments AS A INNER JOIN
                      dbo.tbl_owner_name AS B ON A.owner_id = B.id INNER JOIN
                      dbo.tbl_equipment_type AS C ON A.type_id = C.id INNER JOIN
                      dbo.tbl_equipment_brand AS D ON A.brand_id = D.id

GO
/****** Object:  View [dbo].[v_implement_masterlist]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_implement_masterlist]
AS
SELECT     A.id, A.owner_id, C.id_name, C.owner_name, A.list_id, B.description, A.code, A.description AS imple_desc, A.status
FROM         dbo.tbl_implements AS A INNER JOIN
                      dbo.tbl_implement_list AS B ON A.list_id = B.id INNER JOIN
                      dbo.tbl_owner_name AS C ON A.owner_id = C.id

GO
/****** Object:  View [dbo].[v_location_maindata]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_location_maindata]
AS
SELECT     E.id, E.code, E.location_id, D.location, D.municipality, D.province, E.area, E.soil_type, B.date_planted, B.ownership, E.owner_name, B.association_id, C.sub_desc, B.variety_id, A.variety, E.info_id, 
                      B.water_source, B.fiscal_year
FROM         dbo.tbl_location_variety AS A INNER JOIN
                      dbo.tbl_location_info AS B INNER JOIN
                      dbo.tbl_location_association AS C ON B.association_id = C.id ON A.id = B.variety_id RIGHT OUTER JOIN
                      dbo.tbl_location_list AS D INNER JOIN
                      dbo.tbl_location AS E ON D.id = E.location_id ON B.lot_id = E.id

GO
/****** Object:  View [dbo].[v_trip_ticket_schedule_form]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_trip_ticket_schedule_form]
AS
SELECT     A.id AS hdr_id, B.id AS dtl_id, A.reg_no, A.trip_ticket_no, A.trip_date, A.equip_type, A.equip_no, A.imple_desc, A.imple_code, A.driver, A.purpose, A.need_date, A.need_time, A.requested_by, 
                      A.approved_by, A.equip_timeout, A.equip_timein, A.jobsite_arrival_time, A.jobsite_departure_time, A.remarks, A.work_accepted_by, A.noted_by, A.jtmo_no, A.check_jtmo_by, A.status, 
                      A.create_date AS hdr_create_date, B.lot_no, B.time_started, B.time_stopped, B.operate_hours, B.work_operation, B.area_done, B.rate_per_area, B.amount, B.location, B.current_area, B.soill_type, 
                      B.date_planted, B.ownership, B.lot_owner_name, B.association_desc, B.variety, B.fiscal_year, B.created_date AS dtl_create_date, B.dtl_stats, A.accomplished_date, A.posted_date, B.driver_id, 
                      B.equip_id, B.imple_id, A.user_id, A.accomplished_by, A.posted_by, B.post_status, A.owner_equip, A.owner_imple
FROM         dbo.tbl_trip_ticket_schedule_hdr AS A INNER JOIN
                      dbo.tbl_trip_ticket_schedule_dtl AS B ON A.id = B.hdr_id

GO
/****** Object:  View [dbo].[v_usercontrol_permission]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_usercontrol_permission]
AS
SELECT     dbo.tbl_useraccestlist_menu.menu_name, dbo.tbl_useraccesslist_sub_menu.sub_menu_name, dbo.tbl_usercontrol_permission.useid, dbo.tbl_usercontrol_permission.menuid, 
                      dbo.tbl_usercontrol_permission.submenuid, dbo.tbl_usercontrol_permission.subchildmenuid, dbo.tbl_usercontrol_permission.maintenanceid, dbo.tbl_usercontrol_permission.econdoderid, 
                      dbo.tbl_useraccesslist_sub_child.child_menu_name
FROM         dbo.tbl_user_account INNER JOIN
                      dbo.tbl_usercontrol_permission ON dbo.tbl_user_account.id = dbo.tbl_usercontrol_permission.useid LEFT OUTER JOIN
                      dbo.tbl_useraccesslist_sub_menu ON dbo.tbl_usercontrol_permission.submenuid = dbo.tbl_useraccesslist_sub_menu.id LEFT OUTER JOIN
                      dbo.tbl_useraccesslist_sub_child ON dbo.tbl_usercontrol_permission.subchildmenuid = dbo.tbl_useraccesslist_sub_child.id LEFT OUTER JOIN
                      dbo.tbl_useraccesslist_maintenance ON dbo.tbl_usercontrol_permission.maintenanceid = dbo.tbl_useraccesslist_maintenance.id FULL OUTER JOIN
                      dbo.tbl_useraccestlist_menu ON dbo.tbl_usercontrol_permission.menuid = dbo.tbl_useraccestlist_menu.id

GO
/****** Object:  View [dbo].[v_work_operation]    Script Date: 6/17/2016 6:15:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_work_operation]
AS
SELECT     A.id, A.cat_id, B.cat_desc, A.operation, A.unit_measure, A.rate_cost
FROM         dbo.tbl_work_operations AS A INNER JOIN
                      dbo.tbl_operation_category AS B ON A.cat_id = B.category_id

GO
SET IDENTITY_INSERT [dbo].[tbl_equipment_brand] ON 

INSERT [dbo].[tbl_equipment_brand] ([id], [equipment_brand]) VALUES (1, N'FORD')
INSERT [dbo].[tbl_equipment_brand] ([id], [equipment_brand]) VALUES (2, N'NEW HOLLAND')
SET IDENTITY_INSERT [dbo].[tbl_equipment_brand] OFF
SET IDENTITY_INSERT [dbo].[tbl_equipment_driver] ON 

INSERT [dbo].[tbl_equipment_driver] ([id], [driver_name], [status]) VALUES (3, N'JEROME MACA', 1)
INSERT [dbo].[tbl_equipment_driver] ([id], [driver_name], [status]) VALUES (4, N'IAN SARMIENTO', 1)
INSERT [dbo].[tbl_equipment_driver] ([id], [driver_name], [status]) VALUES (5, N'MARK DANGANAN', 0)
INSERT [dbo].[tbl_equipment_driver] ([id], [driver_name], [status]) VALUES (8, N'MARK PLACIDO', 0)
SET IDENTITY_INSERT [dbo].[tbl_equipment_driver] OFF
SET IDENTITY_INSERT [dbo].[tbl_equipment_type] ON 

INSERT [dbo].[tbl_equipment_type] ([id], [equipment_type]) VALUES (1, N'TRACTOR')
INSERT [dbo].[tbl_equipment_type] ([id], [equipment_type]) VALUES (2, N'VALTRA')
INSERT [dbo].[tbl_equipment_type] ([id], [equipment_type]) VALUES (3, N'CARGO TRUCK')
SET IDENTITY_INSERT [dbo].[tbl_equipment_type] OFF
SET IDENTITY_INSERT [dbo].[tbl_equipments] ON 

INSERT [dbo].[tbl_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (3, 2, 3, 1, N'ASD1269', N'1234', N'1234', N'1234', N'1234', N'1234', N'1234', N'1234', CAST(0x0000A57C00000000 AS DateTime), CAST(500000.0000 AS Decimal(19, 4)), 0, CAST(0x0000A5F600D207A7 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (4, 2, 3, 1, N'ASD1270', N'1234', N'12345', N'12346', N'12347', N'12348', N'12349', N'123410', CAST(0x0000A56300000000 AS DateTime), CAST(700000.0000 AS Decimal(19, 4)), 0, CAST(0x0000A5F600D2696D AS DateTime), CAST(0x0000A5F600EF790C AS DateTime), NULL)
INSERT [dbo].[tbl_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (5, 3, 3, 2, N'ASD1111', N'1145345', N'2546', N'33456', N'356344', N'36345', N'67567862', N'723532', CAST(0x0000A57C00000000 AS DateTime), CAST(225000.0000 AS Decimal(19, 4)), 1, CAST(0x0000A5F700B53541 AS DateTime), CAST(0x0000A61900BB23CF AS DateTime), NULL)
INSERT [dbo].[tbl_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (6, 4, 1, 2, N'VJA 1234', N'1423', N'4123', N'1342', N'6346', N'3466', N'6789', N'97897', CAST(0x0000A60200000000 AS DateTime), CAST(15000.0000 AS Decimal(19, 4)), 1, CAST(0x0000A60F00D2C12C AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_equipments] ([id], [owner_id], [type_id], [brand_id], [model], [cr_no], [motor_no], [serial_no], [mv_file_no], [si_no], [dr_no], [others], [date_proof], [acquisition_cost], [status], [date_created], [date_modify], [date_delete]) VALUES (7, 3, 2, 1, N'FEJ 786', N'89078', N'09789', N'45675', N'24555', N'123412', N'565677', N'243424', CAST(0x0000A60F00D75050 AS DateTime), CAST(15000.0000 AS Decimal(19, 4)), 0, CAST(0x0000A60F00D781CF AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_equipments] OFF
SET IDENTITY_INSERT [dbo].[tbl_form_type] ON 

INSERT [dbo].[tbl_form_type] ([id], [description]) VALUES (1, N'TRIP TICKET')
INSERT [dbo].[tbl_form_type] ([id], [description]) VALUES (2, N'JOB TICKET')
INSERT [dbo].[tbl_form_type] ([id], [description]) VALUES (3, N'CANE POINT RECEIPT')
INSERT [dbo].[tbl_form_type] ([id], [description]) VALUES (4, N'REQUISITION AND ISSUANCE SLIP')
SET IDENTITY_INSERT [dbo].[tbl_form_type] OFF
SET IDENTITY_INSERT [dbo].[tbl_implement_list] ON 

INSERT [dbo].[tbl_implement_list] ([id], [description]) VALUES (2, N'BIG HARROW')
INSERT [dbo].[tbl_implement_list] ([id], [description]) VALUES (3, N'LIGHT HARROW')
INSERT [dbo].[tbl_implement_list] ([id], [description]) VALUES (4, N'FIVE TYNES PLOW')
SET IDENTITY_INSERT [dbo].[tbl_implement_list] OFF
SET IDENTITY_INSERT [dbo].[tbl_implements] ON 

INSERT [dbo].[tbl_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (1, 2, 2, N'AIBH - 1', N'AGRIKULTO IMPLEMENT BIG HARROW-1', 0, CAST(0x0000A5FA00AD3DC7 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (2, 2, 2, N'AIBH  - 2', N'AGRIKULTO IMPLEMENT BIG HARROW-2', 0, CAST(0x0000A5FA00ADBD78 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (3, 2, 3, N'AIFT - 6', N'AGRIKULTO IMPLEMENT FIVE TYNES-6', 0, CAST(0x0000A5FA00B5CA7E AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (5, 2, 4, N'AILH - 5', N'AGRIKULTO IMPLEMENT LIGHT HARROW-5', 1, CAST(0x0000A5FA00B693F8 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_implements] ([id], [owner_id], [list_id], [code], [description], [status], [created_date], [modify_date], [delete_date]) VALUES (6, 3, 4, N'AIFT - 7', N'AGRIKULTO IMPLIMENT FIVE TYNES-7', 1, CAST(0x0000A5FA00BF2066 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_implements] OFF
SET IDENTITY_INSERT [dbo].[tbl_location] ON 

INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (1, N'ANGELES001', 5, N'0.400', N'Soil Type 1', 7, N'JEROME 4', NULL, CAST(0x0000A5FC00EDD178 AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (2, N'ANGELES002', 5, N'0.440', N'Soil Type 3', 6, N'JEROME 3', NULL, CAST(0x0000A5FC00EDC680 AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (3, N'ANGELES003', 5, N'5.500000', N'Soil Type 2', 21, N'JEROME 2', NULL, CAST(0x0000A5FC00EDBCED AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (4, N'LUISITA001', 16, N'4.4000', N'Soil Type 2', 27, N'MARC SAMZON', NULL, CAST(0x0000A5FD0093C89A AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (5, N'LUISITA002', 16, N'400.0000', N'Soil Type 2', NULL, N'MARC SAMZON', NULL, CAST(0x0000A5FD0093DA8B AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (7, N'LUISITA003', 16, N'0.222', N'Soil Type 1', NULL, N'MARC SAMZON', NULL, CAST(0x0000A5FD0093EF74 AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (8, N'LUISITA004', 16, N'0.8', N'Soil Type 3', NULL, N'MARC SAMZON', NULL, CAST(0x0000A5FD0093F86D AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (11, N'MABURAK002', 6, N'1.8000', N'Soil Type 2', 17, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (14, N'TABLANG001', 11, N'2.0000', N'Soil Type 3', 15, N'KARL CLARETE', NULL, CAST(0x0000A5FE00D0C74F AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (15, N'TABLANG002', 11, N'2.0000', N'Soil Type 3', 16, N'KARL CLARETE', NULL, CAST(0x0000A5FE00D0D067 AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (16, N'TABLANG003', 11, N'2.0000', N'Soil Type 2', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (17, N'TABLANG004', 11, N'5.0000', N'Soil Type 1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (19, N'SAN JOSE001', 8, N'0.2000', N'Soil Type 1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (20, N'ANGELES004', 5, N'0.02', N'Soil Type 1', 26, N'JEROME 1', NULL, CAST(0x0000A5FC00EDB032 AS DateTime), NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (21, N'SAN JOSE002', 8, N'2.0000', N'Soil Type 2', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (22, N'SAN JOSE003', 8, N'0.3', N'Soil Type 1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (24, N'MABURAK001', 6, N'10.0000', N'Soil Type 1', 20, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (25, N'MABURAK003', 6, N'0.100000', N'Soil Type 2', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_location] ([id], [code], [location_id], [area], [soil_type], [info_id], [owner_name], [date_created], [date_modify], [date_delete]) VALUES (26, N'ANGELES005', 5, N'1.0000000', N'Soil Type 1', 25, N'Jerome MACA', CAST(0x0000A5F500DB34E2 AS DateTime), CAST(0x0000A5FB0115E690 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[tbl_location] OFF
INSERT [dbo].[tbl_location_association] ([id], [sub_desc]) VALUES (1, N'CATPA')
INSERT [dbo].[tbl_location_association] ([id], [sub_desc]) VALUES (2, N'ASUCAL')
INSERT [dbo].[tbl_location_association] ([id], [sub_desc]) VALUES (3, N'NCPAT')
INSERT [dbo].[tbl_location_association] ([id], [sub_desc]) VALUES (4, N'BISPMPC')
INSERT [dbo].[tbl_location_association] ([id], [sub_desc]) VALUES (5, N'INDEPENDENT')
SET IDENTITY_INSERT [dbo].[tbl_location_info] ON 

INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (6, 2, CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'Jerome Maca', 2, 2, 1, N'2016-2017', NULL, NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (7, 1, CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'Jerome Maca', 2, 2, 1, N'2016-2017', NULL, CAST(0x0000A62100DF7A1E AS DateTime), NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (15, 14, CAST(0x0000A58800000000 AS DateTime), N'Leased', N'ART', 2, 4, 0, N'2016-2017', NULL, NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (16, 15, CAST(0x0000A58000000000 AS DateTime), N'Owned by Planter', N'ART1', 4, 3, 1, N'2016-2017', NULL, NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (17, 11, CAST(0x0000A59D00000000 AS DateTime), N'Leased', N'PACMAN', 5, 5, 0, N'2016-2017', NULL, NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (20, 24, CAST(0x0000A58000000000 AS DateTime), N'Owned by Planter', N'MARC', 2, 3, 1, N'2016-2017', NULL, NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (21, 3, CAST(0x0000A57C00000000 AS DateTime), N'Joint Venture', N'Samuel RAIN', 4, 5, 1, N'2016-2017', CAST(0x0000A5F500C14853 AS DateTime), CAST(0x0000A5F500C25F03 AS DateTime), NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (25, 26, CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', NULL, 6, 4, 1, N'2016-2017', CAST(0x0000A60F00D5E627 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (26, 20, CAST(0x0000A57C00000000 AS DateTime), N'Joint Venture', NULL, 6, 4, 0, N'2016-2017', CAST(0x0000A60F00D61942 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_location_info] ([id], [lot_id], [date_planted], [ownership], [ownername], [variety_id], [association_id], [water_source], [fiscal_year], [date_create], [date_modify], [date_delete]) VALUES (27, 4, CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', NULL, 6, 2, 1, N'2016-2017', CAST(0x0000A61200EDDC6D AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_location_info] OFF
SET IDENTITY_INSERT [dbo].[tbl_location_list] ON 

INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (4, N'MARGOT', N'ANGELES', N'PAMPANGA')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (5, N'ANGELES', N'ANGELES', N'PAMPANGA')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (6, N'MABURAK', N'GAPAN', N'NUEVA ECIJA')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (8, N'SAN JOSE', N'GAPAN', N'NUEVA ECIJA')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (11, N'TABLANG', N'PANIQUI', N'TARLAC')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (12, N'SAMPUT', N'PANIQUI', N'TARLAC')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (13, N'SALOMAGUE', N'PANIQUI', N'TARLAC')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (14, N'RANGAYAN', N'PANIQUI', N'TARLAC')
INSERT [dbo].[tbl_location_list] ([id], [location], [municipality], [province]) VALUES (16, N'LUISITA', N'TARLAC', N'TARLAC')
SET IDENTITY_INSERT [dbo].[tbl_location_list] OFF
SET IDENTITY_INSERT [dbo].[tbl_location_variety] ON 

INSERT [dbo].[tbl_location_variety] ([id], [variety]) VALUES (2, N'RATOON 1')
INSERT [dbo].[tbl_location_variety] ([id], [variety]) VALUES (4, N'RATOON 2')
INSERT [dbo].[tbl_location_variety] ([id], [variety]) VALUES (5, N'RATOON 3')
INSERT [dbo].[tbl_location_variety] ([id], [variety]) VALUES (6, N'PLANT CANE')
SET IDENTITY_INSERT [dbo].[tbl_location_variety] OFF
SET IDENTITY_INSERT [dbo].[tbl_operation_category] ON 

INSERT [dbo].[tbl_operation_category] ([category_id], [cat_desc]) VALUES (2, N'WEEDING')
INSERT [dbo].[tbl_operation_category] ([category_id], [cat_desc]) VALUES (3, N'LAND PREPARATION')
INSERT [dbo].[tbl_operation_category] ([category_id], [cat_desc]) VALUES (4, N'CULTIVATION')
INSERT [dbo].[tbl_operation_category] ([category_id], [cat_desc]) VALUES (5, N'FERTILIZATION')
INSERT [dbo].[tbl_operation_category] ([category_id], [cat_desc]) VALUES (6, N'OTHERS')
SET IDENTITY_INSERT [dbo].[tbl_operation_category] OFF
SET IDENTITY_INSERT [dbo].[tbl_owner_name] ON 

INSERT [dbo].[tbl_owner_name] ([id], [id_name], [owner_name]) VALUES (1, 1, N'NONE')
INSERT [dbo].[tbl_owner_name] ([id], [id_name], [owner_name]) VALUES (2, 2, N'CENTRAL AZUCARERA DE TARLAC')
INSERT [dbo].[tbl_owner_name] ([id], [id_name], [owner_name]) VALUES (3, 3, N'AGRIKULTO INC.')
INSERT [dbo].[tbl_owner_name] ([id], [id_name], [owner_name]) VALUES (4, 4, N'JEROME MACA')
SET IDENTITY_INSERT [dbo].[tbl_owner_name] OFF
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_request_dtl] ON 

INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (227, 195, 1, CAST(0x0000A62100DC3382 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (228, 196, 3, CAST(0x0000A62100DC5329 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (231, 197, 2, CAST(0x0000A62100DC9330 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (233, 199, 3, CAST(0x0000A62100DF99A9 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (234, 200, 1, CAST(0x0000A62100DFABB7 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (235, 201, 2, CAST(0x0000A62100DFBF7A AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (236, 202, 1, CAST(0x0000A62200D1658E AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (237, 203, 1, CAST(0x0000A62200F746CB AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (238, 204, 2, CAST(0x0000A6240094D152 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (239, 205, 1, CAST(0x0000A62400B2CC44 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (240, 206, 3, CAST(0x0000A62400B2DAF9 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (241, 207, 2, CAST(0x0000A62400B2E519 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (242, 208, 1, CAST(0x0000A62600A05D15 AS DateTime), NULL, NULL, 0)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (243, 209, 2, CAST(0x0000A62600A067E0 AS DateTime), NULL, NULL, 0)
INSERT [dbo].[tbl_trip_ticket_request_dtl] ([id], [req_hdr_id], [work_ope_id], [date_created], [date_modified], [date_deleted], [status]) VALUES (244, 210, 3, CAST(0x0000A627008971B0 AS DateTime), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_request_dtl] OFF
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_request_hdr] ON 

INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (195, CAST(0x0000A62100DC224C AS DateTime), CAST(0x0700B864D9450000 AS Time), 1, 1, N'2016061013213010', 1, 1, N'DC', CAST(0x0000A62100DC3382 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (196, CAST(0x0000A62100DC224C AS DateTime), CAST(0x0700B864D9450000 AS Time), 2, 1, N'2016061013215810', 1, 1, N'FWCA', CAST(0x0000A62100DC5328 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (197, CAST(0x0000A62100DC224C AS DateTime), CAST(0x0700B864D9450000 AS Time), 3, 1, N'2016061013225810', 1, 1, N'RST', CAST(0x0000A62100DC9330 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (199, CAST(0x0000A62100DF857C AS DateTime), CAST(0x0700B864D9450000 AS Time), 4, 1, N'2016061013334910', 1, 1, N'FWCA', CAST(0x0000A62100DF99A9 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (200, CAST(0x0000A62100DF857C AS DateTime), CAST(0x0700B864D9450000 AS Time), 5, 1, N'2016061013341410', 1, 1, N'DC', CAST(0x0000A62100DFABB7 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (201, CAST(0x0000A62100DF857C AS DateTime), CAST(0x0700B864D9450000 AS Time), 6, 1, N'2016061013342410', 1, 1, N'RST', CAST(0x0000A62100DFBF7A AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (202, CAST(0x0000A62200D15A88 AS DateTime), CAST(0x0700B864D9450000 AS Time), 7, 2, N'2016061112421511', 1, 1, N'DC', CAST(0x0000A62200D1658E AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (203, CAST(0x0000A62200F7371C AS DateTime), CAST(0x0700B864D9450000 AS Time), 8, 14, N'2016061115000611', 1, 1, N'DC', CAST(0x0000A62200F746CB AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (204, CAST(0x0000A6240094C140 AS DateTime), CAST(0x0700B864D9450000 AS Time), 9, 1, N'2016061309013713', 1, 1, N'rst', CAST(0x0000A6240094D152 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (205, CAST(0x0000A62400B2BD08 AS DateTime), CAST(0x0700B864D9450000 AS Time), 10, 1, N'2016061310504713', 1, 1, N'DC', CAST(0x0000A62400B2CC44 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (206, CAST(0x0000A62400B2BD08 AS DateTime), CAST(0x0700B864D9450000 AS Time), 10, 2, N'2016061310504713', 1, 1, N'FWCA', CAST(0x0000A62400B2DAF9 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (207, CAST(0x0000A62400B2BD08 AS DateTime), CAST(0x0700B864D9450000 AS Time), 10, 3, N'2016061310504713', 1, 1, N'RST', CAST(0x0000A62400B2E519 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (208, CAST(0x0000A62600A04F10 AS DateTime), CAST(0x0700B864D9450000 AS Time), 11, 14, N'2016061509434115', 1, 0, N'DC', CAST(0x0000A62600A05D15 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (209, CAST(0x0000A62600A04F10 AS DateTime), CAST(0x0700B864D9450000 AS Time), 11, 15, N'2016061509434115', 1, 0, N'RST', CAST(0x0000A62600A067E0 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_request_hdr] ([id], [date_req], [time_needed], [req_no], [lot_id], [req_order_int], [user_id], [stats], [purpose], [date_created], [date_modified], [date_deleted]) VALUES (210, CAST(0x0000A627008964A8 AS DateTime), CAST(0x0700B864D9450000 AS Time), 12, 1, N'2016061608201516', 1, 0, N'FWCA', CAST(0x0000A627008971B0 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_request_hdr] OFF
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ON 

INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (15, 73, N'ANGELES001', CAST(0x070040230E430000 AS Time), CAST(0x070080461C860000 AS Time), CAST(0x070040230E430000 AS Time), N'RIPPING SIX TYNES
', CAST(2.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(4000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'PLANT CANE', N'2016-2017', 2, CAST(0x0000A62100DCAB1A AS DateTime), NULL, NULL, 4, 5, 6, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (16, 74, N'ANGELES001', CAST(0x070040230E430000 AS Time), CAST(0x070050CFDF960000 AS Time), CAST(0x070010ACD1530000 AS Time), N'FERTILIZER WITH CUT AWAY
', CAST(1.000 AS Decimal(19, 3)), CAST(2500.00 AS Decimal(19, 2)), CAST(2500.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'PLANT CANE', N'2016-2017', 2, CAST(0x0000A62100DCBEB5 AS DateTime), NULL, NULL, 5, 3, 3, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (17, 75, N'ANGELES001', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x070010ACD1530000 AS Time), N'DISC CULTIVATION', CAST(2.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(4000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'PLANT CANE', N'2016-2017', 2, CAST(0x0000A62100DCFA0D AS DateTime), NULL, NULL, 8, 6, 1, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (18, 76, N'ANGELES001', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x070010ACD1530000 AS Time), N'RIPPING SIX TYNES
', CAST(1.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(2000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'RATOON 1', N'2016-2017', 2, CAST(0x0000A62100DFDE65 AS DateTime), NULL, NULL, 4, 4, 5, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (19, 77, N'ANGELES001', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x070010ACD1530000 AS Time), N'DISC CULTIVATION', CAST(2.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(4000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'RATOON 1', N'2016-2017', 2, CAST(0x0000A62100DFF1D9 AS DateTime), NULL, NULL, 3, 7, 1, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (20, 78, N'ANGELES001', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x070010ACD1530000 AS Time), N'FERTILIZER WITH CUT AWAY
', CAST(1.000 AS Decimal(19, 3)), CAST(2500.00 AS Decimal(19, 2)), CAST(2500.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'RATOON 1', N'2016-2017', 2, CAST(0x0000A62100E00377 AS DateTime), NULL, NULL, 8, 3, 6, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (22, 80, N'ANGELES002', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x070010ACD1530000 AS Time), N'DISC CULTIVATION', CAST(1.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(2000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.440 AS Decimal(19, 3)), N'Soil Type 3', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 3', N'ASUCAL', N'RATOON 1', N'2016-2017', 2, CAST(0x0000A62200D19848 AS DateTime), NULL, NULL, 4, 5, 6, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (23, 81, N'TABLANG001', NULL, NULL, NULL, N'DISC CULTIVATION', NULL, NULL, NULL, N'TABLANG', CAST(2.000 AS Decimal(19, 3)), N'Soil Type 3', CAST(0x0000A58800000000 AS DateTime), N'Leased', N'KARL CLARETE', N'BISPMPC', N'RATOON 1', N'2016-2017', 0, CAST(0x0000A62200F76033 AS DateTime), NULL, NULL, 3, 5, 6, 0)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (24, 82, N'ANGELES001', NULL, NULL, NULL, N'RIPPING SIX TYNES
', NULL, NULL, NULL, N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'RATOON 1', N'2016-2017', 0, CAST(0x0000A6240094E9E8 AS DateTime), NULL, NULL, 4, 6, 5, 0)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (25, 83, N'ANGELES001', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700448E02580000 AS Time), CAST(0x07006C2F561D0000 AS Time), N'DISC CULTIVATION', CAST(2.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(4000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.400 AS Decimal(19, 3)), N'Soil Type 1', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 4', N'ASUCAL', N'RATOON 1', N'2016-2017', 2, CAST(0x0000A62400B2FAD2 AS DateTime), NULL, NULL, 5, 3, 1, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (26, 83, N'ANGELES003', CAST(0x0700B0BD58750000 AS Time), CAST(0x07001CEDAE920000 AS Time), CAST(0x07006C2F561D0000 AS Time), N'RIPPING SIX TYNES
', CAST(2.000 AS Decimal(19, 3)), CAST(2000.00 AS Decimal(19, 2)), CAST(4000.00 AS Decimal(19, 2)), N'ANGELES', CAST(5.500 AS Decimal(19, 3)), N'Soil Type 2', CAST(0x0000A57C00000000 AS DateTime), N'Joint Venture', N'JEROME 2', N'INDEPENDENT', N'RATOON 2', N'2016-2017', 2, CAST(0x0000A62400B30B61 AS DateTime), NULL, NULL, 0, 4, 2, 1)
INSERT [dbo].[tbl_trip_ticket_schedule_dtl] ([id], [hdr_id], [lot_no], [time_started], [time_stopped], [operate_hours], [work_operation], [area_done], [rate_per_area], [amount], [location], [current_area], [soill_type], [date_planted], [ownership], [lot_owner_name], [association_desc], [variety], [fiscal_year], [dtl_stats], [created_date], [modify_date], [delete_date], [driver_id], [equip_id], [imple_id], [post_status]) VALUES (27, 83, N'ANGELES002', CAST(0x0700448E02580000 AS Time), CAST(0x0700B0BD58750000 AS Time), CAST(0x07006C2F561D0000 AS Time), N'FERTILIZER WITH CUT AWAY
', CAST(2.000 AS Decimal(19, 3)), CAST(2500.00 AS Decimal(19, 2)), CAST(5000.00 AS Decimal(19, 2)), N'ANGELES', CAST(0.440 AS Decimal(19, 3)), N'Soil Type 3', CAST(0x0000A57C00000000 AS DateTime), N'Owned by Planter', N'JEROME 3', N'ASUCAL', N'RATOON 1', N'2016-2017', 2, CAST(0x0000A62400B31E21 AS DateTime), NULL, NULL, 0, 7, 3, 1)
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_schedule_dtl] OFF
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ON 

INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (73, 3, 1, CAST(0x0000A62100000000 AS DateTime), N'AGRIKULTO INC.', N'CARGO TRUCK', N'ASD1111', N'AGRIKULTO INC.', N'AGRIKULTO IMPLIMENT FIVE TYNES-7', N'AIFT - 7', N'IAN SARMIENTO', N'RST', CAST(0x0000A62100000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 1', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62100DCAB1A AS DateTime), NULL, NULL, CAST(0x0000A62100DD3BC5 AS DateTime), CAST(0x0000A62100DF1AC2 AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (74, 2, 2, CAST(0x0000A62100000000 AS DateTime), N'CENTRAL AZUCARERA DE TARLAC', N'CARGO TRUCK', N'ASD1269', N'CENTRAL AZUCARERA DE TARLAC', N'AGRIKULTO IMPLEMENT FIVE TYNES-6', N'AIFT - 6', N'MARK DANGANAN', N'FWCA', CAST(0x0000A62100000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 2', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62100DCBEB5 AS DateTime), NULL, NULL, CAST(0x0000A62100DD585F AS DateTime), CAST(0x0000A62100DDB451 AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (75, 1, 3, CAST(0x0000A62100000000 AS DateTime), N'JEROME MACA', N'TRACTOR', N'VJA 1234', N'CENTRAL AZUCARERA DE TARLAC', N'AGRIKULTO IMPLEMENT BIG HARROW-1', N'AIBH - 1', N'MARK PLACIDO', N'DC', CAST(0x0000A62100000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 3', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62100DCFA0D AS DateTime), NULL, NULL, CAST(0x0000A62100DD9B35 AS DateTime), CAST(0x0000A62100DDB11F AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (76, 6, 4, CAST(0x0000A62100000000 AS DateTime), N'CENTRAL AZUCARERA DE TARLAC', N'CARGO TRUCK', N'ASD1270', N'CENTRAL AZUCARERA DE TARLAC', N'AGRIKULTO IMPLEMENT LIGHT HARROW-5', N'AILH - 5', N'IAN SARMIENTO', N'RST', CAST(0x0000A62100000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 4', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62100DFDE65 AS DateTime), NULL, NULL, CAST(0x0000A62100E02566 AS DateTime), CAST(0x0000A62100E0AAC0 AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (77, 5, 5, CAST(0x0000A62100000000 AS DateTime), N'AGRIKULTO INC.', N'VALTRA', N'FEJ 786', N'CENTRAL AZUCARERA DE TARLAC', N'AGRIKULTO IMPLEMENT BIG HARROW-1', N'AIBH - 1', N'JEROME MACA', N'DC', CAST(0x0000A62100000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 5', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62100DFF1D9 AS DateTime), NULL, NULL, CAST(0x0000A62100E04F9E AS DateTime), CAST(0x0000A62100E0A82C AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (78, 4, 6, CAST(0x0000A62100000000 AS DateTime), N'CENTRAL AZUCARERA DE TARLAC', N'CARGO TRUCK', N'ASD1269', N'AGRIKULTO INC.', N'AGRIKULTO IMPLIMENT FIVE TYNES-7', N'AIFT - 7', N'MARK PLACIDO', N'FWCA', CAST(0x0000A62100000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 6', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62100E00377 AS DateTime), NULL, NULL, CAST(0x0000A62100E03A9C AS DateTime), CAST(0x0000A62100E08E45 AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (80, 7, 7, CAST(0x0000A62200000000 AS DateTime), N'AGRIKULTO INC.', N'CARGO TRUCK', N'ASD1111', N'AGRIKULTO INC.', N'AGRIKULTO IMPLIMENT FIVE TYNES-7', N'AIFT - 7', N'IAN SARMIENTO', N'DC', CAST(0x0000A62200000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAM', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62200D19837 AS DateTime), NULL, NULL, CAST(0x0000A62200D1D59A AS DateTime), CAST(0x0000A62200D1E71C AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (81, 8, 8, CAST(0x0000A62200000000 AS DateTime), N'AGRIKULTO INC.', N'CARGO TRUCK', N'ASD1111', N'AGRIKULTO INC.', N'AGRIKULTO IMPLIMENT FIVE TYNES-7', N'AIFT - 7', N'JEROME MACA', N'DC', CAST(0x0000A62200000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), N'', N'', N'', N'', N'', 0, CAST(0x0000A62200F76033 AS DateTime), NULL, NULL, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (82, 9, 9, CAST(0x0000A62400000000 AS DateTime), N'JEROME MACA', N'TRACTOR', N'VJA 1234', N'CENTRAL AZUCARERA DE TARLAC', N'AGRIKULTO IMPLEMENT LIGHT HARROW-5', N'AILH - 5', N'IAN SARMIENTO', N'rst', CAST(0x0000A62400000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), CAST(0x0700000000000000 AS Time), N'', N'', N'', N'', N'', 0, CAST(0x0000A6240094E9E3 AS DateTime), NULL, NULL, NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[tbl_trip_ticket_schedule_hdr] ([id], [reg_no], [trip_ticket_no], [trip_date], [owner_equip], [equip_type], [equip_no], [owner_imple], [imple_desc], [imple_code], [driver], [purpose], [need_date], [need_time], [requested_by], [approved_by], [equip_timeout], [equip_timein], [jobsite_arrival_time], [jobsite_departure_time], [remarks], [work_accepted_by], [noted_by], [jtmo_no], [check_jtmo_by], [status], [create_date], [modify_date], [delete_date], [accomplished_date], [posted_date], [user_id], [accomplished_by], [posted_by]) VALUES (83, 10, 10, CAST(0x0000A62400000000 AS DateTime), N'CENTRAL AZUCARERA DE TARLAC', N'CARGO TRUCK', N'ASD1269', N'CENTRAL AZUCARERA DE TARLAC', N'AGRIKULTO IMPLEMENT BIG HARROW-1', N'AIBH - 1', N'MARK DANGANAN', N'DC', CAST(0x0000A62400000000 AS DateTime), CAST(0x0700B864D9450000 AS Time), N'MACA, JEROME B', N'MACA, JEROME B', CAST(0x0700709A4A320000 AS Time), CAST(0x070050CFDF960000 AS Time), CAST(0x0700D85EAC3A0000 AS Time), CAST(0x0700E80A7E8E0000 AS Time), N'SAMPLE 1', N'', N'MACA, JEROME B', N'', N'', 1, CAST(0x0000A62400B2FAD2 AS DateTime), NULL, NULL, CAST(0x0000A62400B3C10D AS DateTime), CAST(0x0000A62400C0BB22 AS DateTime), 1, N'MACA, JEROME B', N'MACA, JEROME B')
SET IDENTITY_INSERT [dbo].[tbl_trip_ticket_schedule_hdr] OFF
SET IDENTITY_INSERT [dbo].[tbl_user_account] ON 

INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (1, N'admin', N'DwN1hMmef9T0+MWVUPj1Bw==', N'MACA', N'JEROME', N'B', 1, N'ADMINISTRATOR', NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (4, N'user', N'DwN1hMmef9T0+MWVUPj1Bw==', N'Macadangdang', N'Jerome', N'B', 2, N'MANAGER', NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (6, N'Jerome', N'1234', N'Berjuega', N'Jerome', N'Macadangdang', 1, N'ADMINISTRATOR', N'MACA, JEROME B', CAST(0x0000A627008D5F47 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (7, N'User', N'1234', N'mis', N'User 1', N'Admin', 6, N'BASIC USER', N'MACA, JEROME B', CAST(0x0000A627008DDD3F AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (8, N'Jerome', N'DwN1hMmef9T0+MWVUPj1Bw==', N'Ber', N'Je', N'Maca', 4, N'FARM MANAGER', N'MACA, JEROME B', CAST(0x0000A627008EC869 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (9, N'SampleUser', N'DwN1hMmef9T0+MWVUPj1Bw==', N'user', N'Sample', N'jer', 3, N'FINANCE', N'MACA, JEROME B', CAST(0x0000A6270099C85B AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_user_account] ([id], [username], [password], [user_lname], [user_fname], [user_mname], [type_index], [user_type], [who_save], [save_date], [who_modify], [modify_date]) VALUES (10, N'1', N'BtSWMsncm8tirq75lhK6aw==', N'1', N'1', N'1', 6, N'BASIC USER', N'MACA, JEROME B', CAST(0x0000A62700A1BF2F AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_user_account] OFF
SET IDENTITY_INSERT [dbo].[tbl_useraccesslist_maintenance] ON 

INSERT [dbo].[tbl_useraccesslist_maintenance] ([id], [maintenace_name]) VALUES (1, N'REFRESH DATA')
INSERT [dbo].[tbl_useraccesslist_maintenance] ([id], [maintenace_name]) VALUES (2, N'CREATE NEW DATA')
INSERT [dbo].[tbl_useraccesslist_maintenance] ([id], [maintenace_name]) VALUES (3, N'MODIFY EXISTING DATA')
INSERT [dbo].[tbl_useraccesslist_maintenance] ([id], [maintenace_name]) VALUES (4, N'REMOVE DATA')
INSERT [dbo].[tbl_useraccesslist_maintenance] ([id], [maintenace_name]) VALUES (5, N'REVIEW DATA')
SET IDENTITY_INSERT [dbo].[tbl_useraccesslist_maintenance] OFF
SET IDENTITY_INSERT [dbo].[tbl_useraccesslist_sub_child] ON 

INSERT [dbo].[tbl_useraccesslist_sub_child] ([id], [sub_menu_id], [child_menu_name]) VALUES (1, 5, N'REQUEST FORM')
INSERT [dbo].[tbl_useraccesslist_sub_child] ([id], [sub_menu_id], [child_menu_name]) VALUES (2, 5, N'TRIP TICKET SCHEDULE')
INSERT [dbo].[tbl_useraccesslist_sub_child] ([id], [sub_menu_id], [child_menu_name]) VALUES (3, 5, N'ACCOMPLISHMENT')
SET IDENTITY_INSERT [dbo].[tbl_useraccesslist_sub_child] OFF
SET IDENTITY_INSERT [dbo].[tbl_useraccesslist_sub_menu] ON 

INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (1, 1, N'HOME')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (2, 1, N'LOGOUT')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (3, 1, N'EXIT')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (5, 2, N'TRIP TICKET SCHEDULE')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (6, 2, N'JOB TICKET OPERATION')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (7, 2, N'REQUISITION AND ISSUANCE SLIP')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (9, 2, N'CANE POINT RECEIPT')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (10, 3, N'WORK OPERATION MASTERLIST')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (11, 3, N'LOCATION MASTERLIST')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (12, 3, N'EQUIPMENT MASTERLIST')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (13, 3, N'IMPLEMENT MASTERLIST')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (14, 3, N'OTHER ITEM MASTERLIST')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (15, 4, N'LOCATION LOT STATUS')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (16, 4, N'TRIP TICKET STATUS')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (17, 4, N'CANE POINT STATUS')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (18, 4, N'FARMING INVENTORY')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (19, 4, N'EQUIPMENT')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (20, 4, N'IMPLEMENT')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (21, 5, N'USER ACCOUNT')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (22, 5, N'USER ACCESS')
INSERT [dbo].[tbl_useraccesslist_sub_menu] ([id], [menu_id], [sub_menu_name]) VALUES (23, 5, N'USER SETTING')
SET IDENTITY_INSERT [dbo].[tbl_useraccesslist_sub_menu] OFF
SET IDENTITY_INSERT [dbo].[tbl_useraccestlist_menu] ON 

INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (1, N'FILE')
INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (2, N'FARMING OPERATION')
INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (3, N'DATA MAINTENANCE')
INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (4, N'OPERATION MONITORING')
INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (5, N'USER CONTROL')
INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (6, N'PRINT REPORT')
INSERT [dbo].[tbl_useraccestlist_menu] ([id], [menu_name]) VALUES (7, N'ABOUT')
SET IDENTITY_INSERT [dbo].[tbl_useraccestlist_menu] OFF
SET IDENTITY_INSERT [dbo].[tbl_usercontrol_permission] ON 

INSERT [dbo].[tbl_usercontrol_permission] ([id], [useid], [menuid], [submenuid], [subchildmenuid], [maintenanceid], [econdoderid]) VALUES (1, 1, 1, NULL, NULL, NULL, 1)
INSERT [dbo].[tbl_usercontrol_permission] ([id], [useid], [menuid], [submenuid], [subchildmenuid], [maintenanceid], [econdoderid]) VALUES (5, 1, 2, 5, 1, NULL, 1)
INSERT [dbo].[tbl_usercontrol_permission] ([id], [useid], [menuid], [submenuid], [subchildmenuid], [maintenanceid], [econdoderid]) VALUES (6, 1, 2, 6, 1, NULL, 1)
INSERT [dbo].[tbl_usercontrol_permission] ([id], [useid], [menuid], [submenuid], [subchildmenuid], [maintenanceid], [econdoderid]) VALUES (7, 4, 1, NULL, NULL, NULL, 1)
INSERT [dbo].[tbl_usercontrol_permission] ([id], [useid], [menuid], [submenuid], [subchildmenuid], [maintenanceid], [econdoderid]) VALUES (8, 4, 2, 5, 1, NULL, 1)
INSERT [dbo].[tbl_usercontrol_permission] ([id], [useid], [menuid], [submenuid], [subchildmenuid], [maintenanceid], [econdoderid]) VALUES (9, 4, 2, 6, 1, NULL, 1)
SET IDENTITY_INSERT [dbo].[tbl_usercontrol_permission] OFF
SET IDENTITY_INSERT [dbo].[tbl_work_operations] ON 

INSERT [dbo].[tbl_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (1, 4, N'DISC CULTIVATION', N'HA', CAST(2000.0000 AS Decimal(19, 4)), CAST(0x0000A5FB008515C2 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (2, 4, N'RIPPING SIX TYNES
', N'HA', CAST(2000.0000 AS Decimal(19, 4)), CAST(0x0000A5FB008E1B00 AS DateTime), NULL, NULL)
INSERT [dbo].[tbl_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (3, 5, N'FERTILIZER WITH CUT AWAY
', N'HA', CAST(2500.0000 AS Decimal(19, 4)), CAST(0x0000A5FB008E545C AS DateTime), CAST(0x0000A5FB00A8E4A5 AS DateTime), NULL)
INSERT [dbo].[tbl_work_operations] ([id], [cat_id], [operation], [unit_measure], [rate_cost], [date_created], [date_modify], [date_delete]) VALUES (5, 5, N'SAMPLE', N'HC', CAST(2000.0000 AS Decimal(19, 4)), CAST(0x0000A627008A961A AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_work_operations] OFF
ALTER TABLE [dbo].[tbl_equipments]  WITH CHECK ADD  CONSTRAINT [FK_tbl_equipments_tbl_equipment_brand] FOREIGN KEY([brand_id])
REFERENCES [dbo].[tbl_equipment_brand] ([id])
GO
ALTER TABLE [dbo].[tbl_equipments] CHECK CONSTRAINT [FK_tbl_equipments_tbl_equipment_brand]
GO
ALTER TABLE [dbo].[tbl_equipments]  WITH CHECK ADD  CONSTRAINT [FK_tbl_equipments_tbl_equipment_type] FOREIGN KEY([type_id])
REFERENCES [dbo].[tbl_equipment_type] ([id])
GO
ALTER TABLE [dbo].[tbl_equipments] CHECK CONSTRAINT [FK_tbl_equipments_tbl_equipment_type]
GO
ALTER TABLE [dbo].[tbl_equipments]  WITH CHECK ADD  CONSTRAINT [FK_tbl_equipments_tbl_owner_name] FOREIGN KEY([owner_id])
REFERENCES [dbo].[tbl_owner_name] ([id])
GO
ALTER TABLE [dbo].[tbl_equipments] CHECK CONSTRAINT [FK_tbl_equipments_tbl_owner_name]
GO
ALTER TABLE [dbo].[tbl_location]  WITH CHECK ADD  CONSTRAINT [FK_tbl_location_tbl_location_list] FOREIGN KEY([location_id])
REFERENCES [dbo].[tbl_location_list] ([id])
GO
ALTER TABLE [dbo].[tbl_location] CHECK CONSTRAINT [FK_tbl_location_tbl_location_list]
GO
ALTER TABLE [dbo].[tbl_location_info]  WITH CHECK ADD  CONSTRAINT [FK_tbl_location_info_tbl_location] FOREIGN KEY([lot_id])
REFERENCES [dbo].[tbl_location] ([id])
GO
ALTER TABLE [dbo].[tbl_location_info] CHECK CONSTRAINT [FK_tbl_location_info_tbl_location]
GO
ALTER TABLE [dbo].[tbl_location_info]  WITH CHECK ADD  CONSTRAINT [FK_tbl_location_info_tbl_location_association] FOREIGN KEY([association_id])
REFERENCES [dbo].[tbl_location_association] ([id])
GO
ALTER TABLE [dbo].[tbl_location_info] CHECK CONSTRAINT [FK_tbl_location_info_tbl_location_association]
GO
ALTER TABLE [dbo].[tbl_location_info]  WITH CHECK ADD  CONSTRAINT [FK_tbl_location_info_tbl_location_variety] FOREIGN KEY([variety_id])
REFERENCES [dbo].[tbl_location_variety] ([id])
GO
ALTER TABLE [dbo].[tbl_location_info] CHECK CONSTRAINT [FK_tbl_location_info_tbl_location_variety]
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_dtl]  WITH CHECK ADD  CONSTRAINT [FK_tbl_trip_ticket_request_dtl_tbl_trip_ticket_request_hdr] FOREIGN KEY([req_hdr_id])
REFERENCES [dbo].[tbl_trip_ticket_request_hdr] ([id])
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_dtl] CHECK CONSTRAINT [FK_tbl_trip_ticket_request_dtl_tbl_trip_ticket_request_hdr]
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_dtl]  WITH CHECK ADD  CONSTRAINT [FK_tbl_trip_ticket_request_dtl_tbl_work_operations] FOREIGN KEY([work_ope_id])
REFERENCES [dbo].[tbl_work_operations] ([id])
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_dtl] CHECK CONSTRAINT [FK_tbl_trip_ticket_request_dtl_tbl_work_operations]
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_hdr]  WITH CHECK ADD  CONSTRAINT [FK_tbl_trip_ticket_request_hdr_tbl_location] FOREIGN KEY([lot_id])
REFERENCES [dbo].[tbl_location] ([id])
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_hdr] CHECK CONSTRAINT [FK_tbl_trip_ticket_request_hdr_tbl_location]
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_hdr]  WITH CHECK ADD  CONSTRAINT [FK_tbl_trip_ticket_request_hdr_tbl_user_account] FOREIGN KEY([user_id])
REFERENCES [dbo].[tbl_user_account] ([id])
GO
ALTER TABLE [dbo].[tbl_trip_ticket_request_hdr] CHECK CONSTRAINT [FK_tbl_trip_ticket_request_hdr_tbl_user_account]
GO
ALTER TABLE [dbo].[tbl_useraccesslist_sub_child]  WITH CHECK ADD  CONSTRAINT [FK_tbl_useraccesslist_sub_child_tbl_useraccesslist_sub_menu] FOREIGN KEY([sub_menu_id])
REFERENCES [dbo].[tbl_useraccesslist_sub_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_useraccesslist_sub_child] CHECK CONSTRAINT [FK_tbl_useraccesslist_sub_child_tbl_useraccesslist_sub_menu]
GO
ALTER TABLE [dbo].[tbl_useraccesslist_sub_menu]  WITH CHECK ADD  CONSTRAINT [FK_tbl_useraccesslist_sub_menu_tbl_useraccestlist_menu] FOREIGN KEY([menu_id])
REFERENCES [dbo].[tbl_useraccestlist_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_useraccesslist_sub_menu] CHECK CONSTRAINT [FK_tbl_useraccesslist_sub_menu_tbl_useraccestlist_menu]
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usercontrol_permission_tbl_user_account] FOREIGN KEY([useid])
REFERENCES [dbo].[tbl_user_account] ([id])
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_usercontrol_permission_tbl_user_account]
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccesslist_maintenance] FOREIGN KEY([maintenanceid])
REFERENCES [dbo].[tbl_useraccesslist_maintenance] ([id])
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccesslist_maintenance]
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccesslist_sub_child] FOREIGN KEY([subchildmenuid])
REFERENCES [dbo].[tbl_useraccesslist_sub_child] ([id])
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccesslist_sub_child]
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccesslist_sub_menu] FOREIGN KEY([submenuid])
REFERENCES [dbo].[tbl_useraccesslist_sub_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccesslist_sub_menu]
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission]  WITH CHECK ADD  CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccestlist_menu] FOREIGN KEY([menuid])
REFERENCES [dbo].[tbl_useraccestlist_menu] ([id])
GO
ALTER TABLE [dbo].[tbl_usercontrol_permission] CHECK CONSTRAINT [FK_tbl_usercontrol_permission_tbl_useraccestlist_menu]
GO
ALTER TABLE [dbo].[tbl_work_operations]  WITH CHECK ADD  CONSTRAINT [FK_tbl_work_operations_tbl_operation_category] FOREIGN KEY([cat_id])
REFERENCES [dbo].[tbl_operation_category] ([category_id])
GO
ALTER TABLE [dbo].[tbl_work_operations] CHECK CONSTRAINT [FK_tbl_work_operations_tbl_operation_category]
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
         Append = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_equipment_masterlist'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_equipment_masterlist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_equipment_masterlist'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_implement_masterlist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_implement_masterlist'
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
         Width = 150' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_location_maindata'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_location_maindata'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_location_maindata'
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
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_request_form'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_request_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_request_form'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_request_form_presentation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_request_form_presentation'
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
         W' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_schedule_form'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_schedule_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_trip_ticket_schedule_form'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[2] 2[1] 3) )"
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
         Begin Table = "tbl_user_account"
            Begin Extent = 
               Top = 16
               Left = 951
               Bottom = 303
               Right = 1154
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_useraccestlist_menu"
            Begin Extent = 
               Top = 1
               Left = 5
               Bottom = 146
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_useraccesslist_sub_menu"
            Begin Extent = 
               Top = 152
               Left = 7
               Bottom = 275
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_usercontrol_permission"
            Begin Extent = 
               Top = 0
               Left = 566
               Bottom = 219
               Right = 727
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_useraccesslist_sub_child"
            Begin Extent = 
               Top = 226
               Left = 250
               Bottom = 331
               Right = 536
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_useraccesslist_maintenance"
            Begin Extent = 
               Top = 240
               Left = 757
               Bottom = 330
               Right = 933
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_usercontrol_permission'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_usercontrol_permission'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_usercontrol_permission'
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_work_operation'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_work_operation'
GO
USE [master]
GO
ALTER DATABASE [AIS_Database] SET  READ_WRITE 
GO
