<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSettings = New System.Windows.Forms.TextBox()
        Me.btnDBTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSettings
        '
        Me.txtSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSettings.Location = New System.Drawing.Point(12, 12)
        Me.txtSettings.Multiline = True
        Me.txtSettings.Name = "txtSettings"
        Me.txtSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSettings.Size = New System.Drawing.Size(268, 430)
        Me.txtSettings.TabIndex = 0
        '
        'btnDBTest
        '
        Me.btnDBTest.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnDBTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBTest.Location = New System.Drawing.Point(12, 448)
        Me.btnDBTest.Name = "btnDBTest"
        Me.btnDBTest.Size = New System.Drawing.Size(267, 23)
        Me.btnDBTest.TabIndex = 16
        Me.btnDBTest.Text = "Alle Einstellungen löschen"
        Me.btnDBTest.UseVisualStyleBackColor = False
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 475)
        Me.Controls.Add(Me.btnDBTest)
        Me.Controls.Add(Me.txtSettings)
        Me.Name = "frmDebug"
        Me.Text = "Debug"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSettings As System.Windows.Forms.TextBox
    Friend WithEvents btnDBTest As System.Windows.Forms.Button
End Class
