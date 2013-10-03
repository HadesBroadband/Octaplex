Public Class Octaplex1

    Dim opWindows As Integer = 0
    Dim mainMenu As Boolean = True

    Private Sub optionButton_Click(sender As System.Object, e As System.EventArgs) Handles optionButton.Click
        Dim resOpt As New ListBox
        Dim optionX As Integer = optionButton.Top
        Dim optionY As Integer = optionButton.Left
        Dim optionW As Integer = optionButton.Width
        Dim font As New System.Drawing.Font("Eras Medium ITC", 20)

        resOpt.Left = optionY + optionW + 20
        resOpt.Top = optionX + 1
        resOpt.Font = font
        resOpt.Height = 166
        resOpt.Width = 135
        resOpt.Items.Add("906:1200")
        resOpt.Items.Add("1408:792")
        resOpt.Items.Add("1536:864")
        resOpt.Items.Add("1665:936")
        resOpt.Items.Add("1792:1008")
        resOpt.Items.Add("1920:1080")

        AddHandler resOpt.DoubleClick, Function() resolutionsList(resOpt)
        opWindows = 1
        Me.Controls.Add(resOpt)
    End Sub

    'Options Menu - Resolution
    Public Function resolutionsList(ByVal resOpt As ListBox) As String
        Dim s As String = ""

        s = resOpt.SelectedItem

        Select Case s 'low resolution needed
            Case "906:1200"
                Me.Height = 906
                Me.Width = 1200
            Case "1408:792"
                Me.Height = 792
                Me.Width = 1408
            Case "1536:864"
                Me.Height = 864
                Me.Width = 1536
            Case "1665:936"
                Me.Height = 936
                Me.Width = 1665
            Case "1792:1008"
                Me.Height = 1008
                Me.Width = 1792
            Case "1920:1080"
                Me.Height = 1080
                Me.Width = 1920
        End Select
        Return 0
    End Function

    'Play game
    Private Sub playButton_Click(sender As System.Object, e As System.EventArgs) Handles playButton.Click
        mainGame.Show()
        Me.Hide()
    End Sub

    Private Sub quitButton_Click(sender As System.Object, e As System.EventArgs) Handles quitButton.Click
        Me.Close()
    End Sub

    Private Sub deckButton_Click(sender As System.Object, e As System.EventArgs) Handles deckButton.Click
        deckBuilder.Show()
        Me.Hide()
    End Sub

    Private Sub Octaplex1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
