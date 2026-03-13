Imports System.Net.NetworkInformation
Public Class Form1

    Function HasInternet() As Boolean
        Try
            Dim PingSender As New Ping()
            Dim Reply = PingSender.Send("8.8.8.8", 1000)

            If Reply.Status = IPStatus.Success Then
                Return True
            End If
        Catch
        End Try

        Return False
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not HasInternet() Then
            MsgBox("Please ensure you have a valid internet connection and try again.", 0 + 16, "ERROR")
            Me.Close()
        Else
            WebView21.Source = New Uri("https://securepass.bitdefender.com/index.html") 'Literally the only fucking line of code that matters here btw I added some extra bullshit because I felt like it.
        End If
    End Sub

    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click 'ts this empty fucking function is necessary trust.

    End Sub
End Class
