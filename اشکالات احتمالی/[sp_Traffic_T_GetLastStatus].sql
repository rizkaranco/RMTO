USE [TBZRMTODB97]
GO
/****** Object:  StoredProcedure [dbo].[sp_Traffic_T_GetLastStatus]    Script Date: 8/25/2019 11:54:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




ALTER PROCEDURE [dbo].[sp_Traffic_T_GetLastStatus]
    @NumberPlate_nvc NVARCHAR(15) ,
    @SerialPlate_nvc NVARCHAR(3) ,
    @CarCardNumber_nvc NVARCHAR(10)
AS
    BEGIN
        DECLARE @HasTurn_bit BIT;
        DECLARE @TurnAccepted_bit BIT;
        DECLARE @TurnReturn_bit BIT;
        DECLARE @TurnCanceled_bit BIT;
        DECLARE @HasLadBillCredit_bit BIT;
        DECLARE @LadBillCreditCancel_bit BIT;
        DECLARE @LadBillCreditTurn_bit BIT;
        DECLARE @LastTrafficID_bint BIGINT;
        DECLARE @LastLadBillCreditID_int INT;
        DECLARE @AcceptedTurnNumber_bint BIGINT;

        SET @HasTurn_bit = 0;

        SELECT  @LastTrafficID_bint = MAX(T.TrafficID_bint)
        FROM    Traffic_T T
	--Left Outer Join LadBillCredit_T LBC On T.TrafficID_bint = LBC.TrafficID_bint
        WHERE   T.NumberPlate_nvc = @NumberPlate_nvc
                AND T.SerialPlate_nvc = @SerialPlate_nvc
                AND ( @CarCardNumber_nvc IS NULL
                      OR T.CarCardNumber_nvc = @CarCardNumber_nvc
                    )
                AND T.In_bit = 1
		--And (LBC.LadBillCreditID_int Is  Null
		--	 Or (LBC.LadBillCreditID_int Is Not Null And IsNull(LBC.Canceled_bit, 0) = 1 And IsNull(LBC.Turn_bit, 0) = 1))
        IF @LastTrafficID_bint IS  NULL
            BEGIN
                SELECT  @LastTrafficID_bint = MAX(T.TrafficID_bint)
                FROM    Traffic_T T
                        JOIN LadBillCredit_T LBC ON T.TrafficID_bint = LBC.TrafficID_bint
                WHERE   T.NumberPlate_nvc = @NumberPlate_nvc
                        AND T.SerialPlate_nvc = @SerialPlate_nvc
                        AND ( @CarCardNumber_nvc IS NULL
                              OR T.CarCardNumber_nvc = @CarCardNumber_nvc
                            )
                        AND T.In_bit = 1
		--and (LBC.LadBillCreditID_int Is not  Null And IsNull(LBC.Canceled_bit, 0) = 1 And IsNull(LBC.Turn_bit, 0) = 1)
            END

        IF @LastTrafficID_bint IS NOT NULL
            BEGIN
                SET @HasTurn_bit = 1;
                SET @AcceptedTurnNumber_bint = ( SELECT AcceptedTurnNumber_bint
                                                 FROM   Traffic_T
                                                 WHERE  TrafficID_bint = @LastTrafficID_bint
                                               )

                SELECT  @TurnAccepted_bit = ISNULL(TurnAccepted_bit, 0)
                FROM    Traffic_T
                WHERE   TrafficID_bint = @LastTrafficID_bint
		
                SET @TurnReturn_bit = ISNULL(( SELECT TOP 1
                                                        Return_bit
                                               FROM     TurnManagement_T
                                               WHERE    TrafficID_bint = @LastTrafficID_bint
                                               ORDER BY TurnManagementID_int DESC
                                             ), 0)
                SET @TurnCanceled_bit = ISNULL(( SELECT TOP 1
                                                        ISNULL(TurnCancelCommantID_int,
                                                              0)
                                                 FROM   TurnManagement_T
                                                 WHERE  TrafficID_bint = @LastTrafficID_bint
                                                 ORDER BY TurnManagementID_int DESC
                                               ), 0)
                IF @TurnAccepted_bit = 1
                    AND @TurnCanceled_bit = 0
                    BEGIN
                        SET @LastLadBillCreditID_int = ( SELECT
                                                              MAX(LadBillCreditID_int)
                                                         FROM LadBillCredit_T
                                                         WHERE
                                                              TrafficID_bint = @LastTrafficID_bint  --and Canceled_bit != 0 //added by Parsa-  اگر مجوز لغو شده است نباید دارای مجوز نشان دهد

                                                       )
                        SET @HasLadBillCredit_bit = ISNULL(@LastLadBillCreditID_int,
                                                           0);
                        IF @HasLadBillCredit_bit = 1
                            BEGIN
                                SET @LadBillCreditCancel_bit = ( SELECT
                                                              ISNULL(Canceled_bit,
                                                              0)
                                                              FROM
                                                              LadBillCredit_T
                                                              WHERE
                                                              LadBillCreditID_int = @LastLadBillCreditID_int
                                                              )
                                IF @LadBillCreditCancel_bit = 1
                                    BEGIN
                                        SET @LadBillCreditTurn_bit = ( SELECT
                                                              ISNULL(Turn_bit,
                                                              0)
                                                              FROM
                                                              LadBillCredit_T
                                                              WHERE
                                                              LadBillCreditID_int = @LastLadBillCreditID_int
                                                              )
                                    END
                            END
                    END
            END


        SELECT  @HasTurn_bit AS HasTurn_bit ,
                @LastTrafficID_bint AS TrafficID_bint ,
                @AcceptedTurnNumber_bint AS AcceptedTurnNumber_bint ,
                @TurnAccepted_bit AS TurnAccepted_bit ,
                @TurnReturn_bit AS TurnReturn_bit ,
                @TurnCanceled_bit AS TurnCanceled_bit ,
                @HasLadBillCredit_bit AS HasLadBillCredit_bit ,
                @LastLadBillCreditID_int AS LastLadBillCreditID_int ,
                @LadBillCreditCancel_bit AS LadBillCreditCancel_bit ,
                @LadBillCreditTurn_bit AS LadBillCreditTurn_bit
    END





