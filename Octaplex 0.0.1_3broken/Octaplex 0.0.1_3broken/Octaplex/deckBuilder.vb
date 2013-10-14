Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class deckBuilder
    Dim midX As Integer = (Me.Height / 2)
    Dim midY As Integer = (Me.Width / 2)

    Public Sub deckBuilder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = Octaplex1.WindowState
        Me.FormBorderStyle = Octaplex1.FormBorderStyle
        Me.Width = Octaplex1.Width
        Me.Height = Octaplex1.Height
        Me.Top = Me.Top
        Me.Left = Me.Left
    End Sub

    Public Sub pause_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            pauseDeck(midX, midY)
        End If
    End Sub

    Private Sub pauseMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Octaplex1.Show()
        Me.Close()
    End Sub

    Private Sub pauseQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Octaplex1.Close()
        Me.Close()
    End Sub

    Private Sub buildDeck_Click(sender As Object, e As EventArgs) Handles buildDeck.Click
        Me.Controls.Remove(buildDeck)
        Dim xLimit As Integer = 10
        Dim yLimit As Integer = 20
        Dim cards As DataTable = cardData("./Resources", "CardCSV.csv")
        deckBuilder_cardGenerator(cards)
    End Sub

    Public Function pauseDeck(midXForm, midYForm) As Integer
        Dim pauseMainMenu As New Button
        pauseMainMenu.Text = "Main Menu"
        pauseMainMenu.Left = midXForm
        pauseMainMenu.Top = midYForm
        pauseMainMenu.Width = 401
        pauseMainMenu.Height = 103
        pauseMainMenu.Font = Font
        pauseMainMenu.BackColor = SystemColors.ButtonFace


        Dim pauseQuit As New Button
        pauseQuit.Text = "Quit"
        pauseQuit.Left = midXForm
        pauseQuit.Top = midYForm + 113
        pauseQuit.Width = 401
        pauseQuit.Height = 103
        pauseQuit.Font = Font
        pauseQuit.BackColor = SystemColors.ButtonFace

        AddHandler pauseMainMenu.Click, AddressOf pauseMainMenu_Click
        Me.Controls.Add(pauseMainMenu)
        AddHandler pauseQuit.Click, AddressOf pauseQuit_Click
        pauseMainMenu.BringToFront()
        Me.Controls.Add(pauseQuit)
        pauseQuit.BringToFront()
        Return 0
    End Function

    Public Function cardData(ByVal folderPath As String, ByVal fileName As String) As DataTable

        Dim folderConnection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & folderPath & ";Extended Properties=Text;"
        Dim connection As New OleDbConnection(folderConnection)

        Try
            connection.Open()
            Dim dataCmd As New OleDbCommand("SELECT * FROM [" & fileName & "]", connection)
            Dim dataAd As New OleDbDataAdapter()

            dataAd.SelectCommand = dataCmd

            Dim cardDataSet As New DataSet()

            dataAd.Fill(cardDataSet)
            dataAd.Dispose()

            Return cardDataSet.Tables(0)
        Catch
            Return Nothing
        Finally
            connection.Close()
        End Try

    End Function

    Private Function deckBuilder_cardGenerator(ByVal data As DataTable)
        Dim r As Integer = 0
        Dim c As Integer = 0
        Dim leftPos As Integer = 20
        Dim topPos As Integer = 240
        Dim rM As Integer = data.Rows.Count
        While r <= rM - 1
            Dim cardBack As New PictureBox
            cardBack.Height = 200
            cardBack.Width = 140
            cardBack.Left = leftPos
            cardBack.Top = topPos
            cardBack.SendToBack()
            If data.Rows(r).Item(1) = "Oct" Then
                cardBack.BackColor = Color.Black
            Else
                cardBack.BackColor = Color.Blue
            End If
            Me.Controls.Add(cardBack)

            cardBuilder(r, leftPos, topPos, cardBack.Height, cardBack.Width)

            leftPos = leftPos + 20 + cardBack.Width

            If leftPos + cardBack.Width + 20 > Me.Width Then
                leftPos = 20
                topPos = topPos + 20 + cardBack.Height
            End If

            If (cardBack.Location.Y > Me.Location.Y) Then
                Me.AutoScroll = True
                If r = 18 Then
                    Dim spacer As New PictureBox
                    spacer.Height = 20
                    spacer.Top = topPos + cardBack.Height
                    spacer.BackColor = Color.Transparent
                    Me.Controls.Add(spacer)
                End If
            End If

            r += 1
        End While
        Return Nothing
    End Function

    Private Function cardBuilder(ByVal currentCard As Integer, ByVal xPos As Integer, ByVal yPos As Integer, ByVal height As Integer, ByVal width As Integer)
        Dim db As DataTable = cardData("./Resources", "CardCSV.csv")
        Dim dbr As DataRow = db.Rows(currentCard)
        Dim title As String = dbr.Item(2)
        'Title
        Dim cardTitle As New Label
        cardTitle.Height = height / 10
        cardTitle.Width = width - 5
        cardTitle.Top = yPos + 1
        cardTitle.Left = xPos + 2.5
        cardTitle.Text = title
        cardTitle.BackColor = Color.Coral
        Me.Controls.Add(cardTitle)
        cardTitle.BringToFront()

        Return Nothing
    End Function
End Class