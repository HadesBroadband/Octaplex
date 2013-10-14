Public Class mainGame
    Dim midX As Integer = (Me.Height / 2) + 200
    Dim midY As Integer = (Me.Width / 2) + 200

    Private Sub mainGame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.playboard
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub pause_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            pauseGame(midX, midY)
        End If
    End Sub

    Public Function pauseGame(midXForm, midYForm) As Integer
        Dim pauseMainMenu As New Button
        AddHandler pauseMainMenu.Click, AddressOf pauseMainMenu_Click
        Me.Controls.Add(pauseMainMenu)
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
        AddHandler pauseQuit.Click, AddressOf pauseQuit_Click
        Me.Controls.Add(pauseQuit)
        Return 0
    End Function

    Private Sub pauseMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Octaplex1.Show()
        Me.Close()
    End Sub

    Private Sub pauseQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Octaplex1.Close()
        Me.Close()
    End Sub
End Class