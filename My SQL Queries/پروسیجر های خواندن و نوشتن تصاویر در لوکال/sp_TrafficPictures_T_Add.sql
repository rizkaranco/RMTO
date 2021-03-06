
ALTER PROCEDURE [dbo].[sp_TrafficPictures_T_Add]
	 @TrafficID_bint bigint,
	 @Picture_vbnry varbinary(MAX)
	 --,@PicturePath_vc VARCHAR(400)
As
BEGIN
	Insert 
	Into [TrafficPictures_T]
		(
			[TrafficID_bint],
			[Picture_vbnry],
			IsExtracted
			--,PicturePath_vc
		)
	Values
		(
			@TrafficID_bint,
			@Picture_vbnry,
			1
			--,@PicturePath_vc
		)
		declare @path nvarchar(200) =  Concat('e:\img\',@TrafficID_bint,'.jpg')
	exec sp_TrafficPicture_T_SaveFile @path,@Picture_vbnry

END