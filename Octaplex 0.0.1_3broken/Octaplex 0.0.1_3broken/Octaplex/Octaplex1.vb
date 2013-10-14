Public Class Octaplex1

    Dim opWindows As Integer = 0
    Dim mainMenu As Boolean = True

    Public Sub optionButton_Click(sender As System.Object, e As System.EventArgs) Handles optionButton.Click
        Dim resOpt As New ListBox
        Dim optionX As Integer = optionButton.Top
        Dim optionY As Integer = optionButton.Left
        Dim optionW As Integer = optionButton.Width
        Dim font As New System.Drawing.Font("Eras Medium ITC", 20)

        Me.playButton.Left = 12
        Me.optionButton.Left = 12
        Me.deckButton.Left = 12

        resOpt.Left = optionY + optionW + 20
        resOpt.Top = optionX + 1
        resOpt.Font = font
        resOpt.Height = 166
        resOpt.Width = 150
        resOpt.Items.Add("906:1200")
        resOpt.Items.Add("1408:792")
        resOpt.Items.Add("1536:864")
        resOpt.Items.Add("1665:936")
        resOpt.Items.Add("1792:1008")
        resOpt.Items.Add("1920:1080")

        AddHandler resOpt.DoubleClick, Function() resolutionsList(resOpt)
        opWindows = 1

        Dim height1 As Integer = resOpt.Height + resOpt.Top

        Dim bLessOpt As New Button
        bLessOpt.Left = resOpt.Left
        bLessOpt.Top = height1
        bLessOpt.Height = 50
        bLessOpt.Width = 150
        bLessOpt.Text = "Borderless Window"
        bLessOpt.BackColor = Color.Aqua

        Dim wBarOpt As New Button
        wBarOpt.Left = resOpt.Left
        wBarOpt.Top = height1
        wBarOpt.Height = 50
        wBarOpt.Width = 150
        wBarOpt.Text = "Windowed"
        wBarOpt.BackColor = Color.Aqua

        AddHandler bLessOpt.Click, Function() borderlessOption_Clicked(bLessOpt, wBarOpt)
        AddHandler wBarOpt.Click, Function() windowsBarOption_Clicked(bLessOpt, wBarOpt)

        Me.Controls.Add(resOpt)

        buttonSwitching(bLessOpt, wBarOpt)
    End Sub

    'Options Menu - Resolution
    Public Function resolutionsList(ByVal resOpt As ListBox) As String
        Dim s As String = ""

        s = resOpt.SelectedItem

        Select Case s 'low resolution needed
            Case "906:1200"
                Me.Height = 906
                Me.Width = 1200
                Me.quitButton.Left = 1200 - 27 - quitButton.Width
            Case "1408:792"
                Me.Height = 792
                Me.Width = 1408
                Me.quitButton.Left = 1408 - 27 - quitButton.Width
            Case "1536:864"
                Me.Height = 864
                Me.Width = 1536
                Me.quitButton.Left = 1536 - 27 - quitButton.Width
            Case "1665:936"
                Me.Height = 936
                Me.Width = 1665
                Me.quitButton.Left = 1665 - 27 - quitButton.Width
            Case "1792:1008"
                Me.Height = 1008
                Me.Width = 1792
                Me.quitButton.Left = 1792 - 27 - quitButton.Width
            Case "1920:1080"
                Me.Height = 1080
                Me.Width = 1920
                Me.quitButton.Left = 1920 - 27 - quitButton.Width
        End Select
        Return 0
    End Function

    Private Function borderlessOption_Clicked(alt1, alt2)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        buttonSwitching(alt2, alt1)
        Return Nothing
    End Function

    Private Function windowsBarOption_Clicked(alt1, alt2)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.WindowState = FormWindowState.Normal
        buttonSwitching(alt1, alt2)
        Return Nothing
    End Function

    Private Function buttonSwitching(button1, button2)
        Dim border As Boolean = True
        If border = True Then
            Me.Controls.Add(button1)
            Me.Controls.Remove(button2)
        ElseIf border = False Then
            Me.Controls.Add(button2)
            Me.Controls.Remove(button1)
        End If
        Return Nothing
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
