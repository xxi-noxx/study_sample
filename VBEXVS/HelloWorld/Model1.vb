Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class Model1
    Inherits DbContext

    ' コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'Model1' 
    ' 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
    ' の 'HelloWorld.Model1' データベースを対象としています。 
    ' 
    ' 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
    ' アプリケーション構成ファイルで 'Model1' 接続文字列を変更してください。
    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    ' モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
    ' 詳細については、http:'go.microsoft.com/fwlink/?LinkId=390109 を参照してください。
    Public Overridable Property MyEntities() As DbSet(Of myentity)

End Class

Public Class myentity
    Public Property id() As Int32
    Public Property name() As String
End Class
