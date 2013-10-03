Imports System.IO

Public Class deckBuilder

    Private Sub deckBuilder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = Octaplex1.Width
        Me.Height = Octaplex1.Height
        Me.Top = Me.Top
        Me.Left = Me.Left
    End Sub

    Function importCards(ByVal path As String) As System.Data.DataTable
        Dim dt As New DataTable()
        Dim line As String = Nothing
        Dim i As Integer = 0

        Using sr As StreamReader = File.OpenText("c:\temp\table1.csv")
            line = sr.ReadLine()
            Do While line IsNot Nothing
                Dim data() As String = line.Split(","c)
                If data.Length > 0 Then
                    If i = 0 Then
                        For Each item In data
                            dt.Columns.Add(New DataColumn())
                        Next item
                        i += 1
                    End If
                    Dim row As DataRow = dt.NewRow()
                    row.ItemArray = data
                    dt.Rows.Add(row)
                End If
                line = sr.ReadLine()
            Loop
        End Using
    End Function

End Class