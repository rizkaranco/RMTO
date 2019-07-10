Namespace Common

    Public Class MyDateTime
        Private _Date As Date

        Public Property MyDate() As Date
            Get
                Return Me._Date
            End Get
            Set(ByVal value As Date)
                Me._Date = value
            End Set
        End Property

        Public ReadOnly Property Time() As String
            Get
                Return DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
            End Get
        End Property

        Public Sub New(ByVal _Date As Date)
            Me._Date = Me.CorrectDateFormat(_Date)
        End Sub

        Public Sub New(ByVal PersianDate As String)
            If PersianDate.Length = 10 AndAlso PersianDate.Split("/").Length = 3 Then
                Me._Date = (New System.Globalization.PersianCalendar()).ToDateTime(Int32.Parse(PersianDate.Split("/")(0)), Int32.Parse(PersianDate.Split("/")(1)), Int32.Parse(PersianDate.Split("/")(2)), 0, 0, 0, 0)
            Else
                Me._Date = Nothing
            End If
        End Sub

        Public Function ConvertToPersianLongDate() As String
            Dim Result As New System.Text.StringBuilder
            Dim Month() As String = {"", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"}
            Dim Day() As String = {"یکشنبه", "دوشنبه", "سه شنبه", "چهار شنبه", "پنج شنبه", "جمعه", "شنبه"}
            Dim Persian As New Globalization.PersianCalendar
            Result.Append(Day(MyDate.DayOfWeek) + " " + Persian.GetDayOfMonth(MyDate).ToString + " " + Month(Persian.GetMonth(MyDate)) + " " + Persian.GetYear(MyDate).ToString)
            Return Result.ToString
        End Function

        Public Function ConvertToPersianShortDate() As String
            Dim Result As New System.Text.StringBuilder
            Dim Persian As New Globalization.PersianCalendar
            Dim day, month, year As String
            day = Persian.GetDayOfMonth(MyDate)
            month = Persian.GetMonth(MyDate)
            year = Persian.GetYear(MyDate)
            If day.Length < 2 Then
                day = String.Format("0{0}", day)
            End If
            If month.Length < 2 Then
                month = String.Format("0{0}", month)
            End If

            Result.Append(String.Format("{0}/{1}/{2}", year, month, day))
            Return Result.ToString
        End Function

        Public Function CorrectDateFormat(ByVal DateObject As Date) As Date
            Dim Year, Month, Day, Hour, Minute, Second As Integer
            Dim dt As Date
            If TypeOf (System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar) Is System.Globalization.PersianCalendar Then
                Dim pc As New System.Globalization.PersianCalendar
                Year = pc.GetYear(DateObject)
                Month = pc.GetMonth(DateObject)
                Day = pc.GetDayOfMonth(DateObject)
                Hour = pc.GetHour(DateObject)
                Minute = pc.GetMinute(DateObject)
                Second = pc.GetSecond(DateObject)
                dt = pc.ToDateTime(Year, Month, Day, Hour, Minute, Second, 0)
            ElseIf TypeOf (System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar) Is System.Globalization.HijriCalendar Then
                Dim hc As New System.Globalization.HijriCalendar
                Year = hc.GetYear(DateObject)
                Month = hc.GetMonth(DateObject)
                Day = hc.GetDayOfMonth(DateObject)
                Hour = hc.GetHour(DateObject)
                Minute = hc.GetMinute(DateObject)
                Second = hc.GetSecond(DateObject)
                dt = hc.ToDateTime(Year, Month, Day, Hour, Minute, Second, 0)
            Else
                dt = DateObject
            End If
            Return dt
        End Function

    End Class

End Namespace
