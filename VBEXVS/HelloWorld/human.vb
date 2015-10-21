''' <summary>
''' 人クラス
''' </summary>
Public Class human
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Birthday As Date
    Public Property height As Double
    Public Property weight As Double
    Public Property sex As SexType

    Public Enum SexType
        man
        woman
    End Enum
End Class
