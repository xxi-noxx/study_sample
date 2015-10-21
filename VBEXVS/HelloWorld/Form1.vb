Imports System.Configuration
Imports System.Data.Entity

Public Class Form1
    Sub main()
        Dim aaa As New List(Of String)
        'Database.SetInitializer(New CreateDatabaseIfNotExists(Of Model1))
        'Dim hoge As New myentity
        'hoge.id = 1
        'hoge.name = "hoge"
        'Dim ef As New Model1
        'ef.MyEntities.Add(hoge)
        'ef.SaveChanges()

        Call hoge()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call hoge()
    End Sub

    Private Sub hoge()
        Dim day As Date = Now

        Do Until (LeapYearCheck(day.Year))
            day = day.AddYears(1)
        Loop


        'Console.WriteLine(day.Year)
        Dim twogatu As Date = DateSerial(day.Year, 2, 1)
        Dim lastDay As Date = twogatu.AddMonths(1).AddDays(-1)
        'Console.WriteLine(twogatu.DayOfWeek.ToString("F"))
        'Console.WriteLine(lastDay.DayOfWeek)

        Dim week As Integer = 0
        For nowday As Integer = twogatu.Day To lastDay.Day
            Dim nowDate As Date = DateSerial(twogatu.Year, twogatu.Month, nowday)

            If nowDate.Day = 1 OrElse nowDate.DayOfWeek = DayOfWeek.Sunday Then
                week += 1
            End If
            Console.WriteLine(String.Format("{0} 第{1}週 {2}", nowDate.ToShortDateString, week, nowDate.DayOfWeek.ToString("F")))
        Next
    End Sub

    Private Function LeapYearCheck(ByVal year As Integer) As Boolean
        If year Mod 400 = 0 Then
            Return True
        End If

        If year Mod 4 = 0 AndAlso Not year Mod 100 = 0 Then
            Return True
        End If

        Return False
    End Function

    Private Sub hoge2()
        Call TelCall(Of Integer)(1234)

    End Sub

    Private Sub TelCall(Of T)(ByVal obj As T)

    End Sub
End Class
