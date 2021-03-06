

ALTER PROCEDURE [dbo].[sp_TrafficPictures_T_SelectByPrimaryKey]
	 @TrafficID_bint bigint
As
BEGIN


	declare @path nvarchar(200) = Concat('e:\img\',@TrafficID_bint,'.jpg');

	declare @tsql nvarchar(3000) = 'Select [TrafficPictures_T].[TrafficID_bint],
	(SELECT * FROM Openrowset( Bulk '''+@path +''', Single_Blob) as x) as Picture_vbnry
	From [TrafficPictures_T] 
	Where 
	[TrafficPictures_T].[TrafficID_bint] = ' + Cast(@TrafficID_bint as varchar(200))

	Begin try
	Exec (@tsql)
	End try

	Begin catch
	 
	 Select [TrafficPictures_T].[TrafficID_bint],0xfff as Picture_vbnry
	
	From [TrafficPictures_T] 
	Where 
	[TrafficPictures_T].[TrafficID_bint] = @TrafficID_bint

	 End Catch
END



