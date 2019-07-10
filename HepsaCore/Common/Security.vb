Namespace Common

    Public Class Security

        Public Shared Function MD5(ByVal Input As String) As String
            Dim StringBuilder As New System.Text.StringBuilder
            Dim MD5Sevice As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim UTF8Encoder As New System.Text.UTF8Encoding
            Dim StringBuffer() As Byte = UTF8Encoder.GetBytes(Input)
            Dim Hash() As Byte = MD5Sevice.ComputeHash(StringBuffer)
            For Each b As Byte In Hash
                StringBuilder.Append(b.ToString("x2"))
            Next
            Return StringBuilder.ToString
        End Function

    End Class

End Namespace
