<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Octaplex1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.optionButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.deckButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Octaplex.My.Resources.Resources.Title
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1156, 249)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'playButton
        '
        Me.playButton.Font = New System.Drawing.Font("Eras Medium ITC", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playButton.Location = New System.Drawing.Point(12, 278)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(401, 103)
        Me.playButton.TabIndex = 1
        Me.playButton.Text = "PLAY"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'optionButton
        '
        Me.optionButton.Font = New System.Drawing.Font("Eras Medium ITC", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionButton.Location = New System.Drawing.Point(12, 428)
        Me.optionButton.Name = "optionButton"
        Me.optionButton.Size = New System.Drawing.Size(401, 103)
        Me.optionButton.TabIndex = 2
        Me.optionButton.Text = "OPTIONS"
        Me.optionButton.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.Font = New System.Drawing.Font("Eras Medium ITC", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitButton.Location = New System.Drawing.Point(12, 747)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(401, 103)
        Me.quitButton.TabIndex = 3
        Me.quitButton.Text = "QUIT"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'deckButton
        '
        Me.deckButton.Font = New System.Drawing.Font("Eras Medium ITC", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deckButton.Location = New System.Drawing.Point(12, 591)
        Me.deckButton.Name = "deckButton"
        Me.deckButton.Size = New System.Drawing.Size(401, 103)
        Me.deckButton.TabIndex = 4
        Me.deckButton.Text = "DECK BUILDER"
        Me.deckButton.UseVisualStyleBackColor = True
        '
        'Octaplex1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Octaplex.My.Resources.Resources.BackgroundMain
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 953)
        Me.Controls.Add(Me.deckButton)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.optionButton)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Octaplex1"
        Me.Text = "Octaplex V0_0.0.5"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents playButton As System.Windows.Forms.Button
    Friend WithEvents optionButton As System.Windows.Forms.Button
    Friend WithEvents quitButton As System.Windows.Forms.Button
    Friend WithEvents deckButton As System.Windows.Forms.Button

End Class
