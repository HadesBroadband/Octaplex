<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deckBuilder
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
        Me.buildDeck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buildDeck
        '
        Me.buildDeck.Font = New System.Drawing.Font("Eras Medium ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buildDeck.Location = New System.Drawing.Point(12, 12)
        Me.buildDeck.Name = "buildDeck"
        Me.buildDeck.Size = New System.Drawing.Size(401, 103)
        Me.buildDeck.TabIndex = 2
        Me.buildDeck.Text = "BUILD NEW DECK"
        Me.buildDeck.UseVisualStyleBackColor = True
        '
        'deckBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 868)
        Me.Controls.Add(Me.buildDeck)
        Me.Name = "deckBuilder"
        Me.Text = "deckBuilder"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buildDeck As System.Windows.Forms.Button
End Class
