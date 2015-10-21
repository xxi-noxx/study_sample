Namespace drink

    Public Class item
        Sub New()
            Dim ino As New human
            Dim rita As New human

            ino.FirstName = "kousuke"
            ino.LastName = "takaoka"
            ino.sex = human.SexType.man

            rita.FirstName = ""
            rita.LastName = ""
            rita.sex = human.SexType.man
        End Sub
    End Class

End Namespace
