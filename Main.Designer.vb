<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Open = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.OpenT = New System.Windows.Forms.TextBox()
        Me.SaveT = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Open
        '
        Me.Open.Location = New System.Drawing.Point(12, 58)
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(75, 23)
        Me.Open.TabIndex = 0
        Me.Open.Text = "Open"
        Me.Open.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(12, 127)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(12, 95)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Save to"
        Me.Save.UseVisualStyleBackColor = True
        '
        'OpenT
        '
        Me.OpenT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OpenT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OpenT.Location = New System.Drawing.Point(93, 61)
        Me.OpenT.Name = "OpenT"
        Me.OpenT.Size = New System.Drawing.Size(327, 20)
        Me.OpenT.TabIndex = 3
        '
        'SaveT
        '
        Me.SaveT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SaveT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaveT.Location = New System.Drawing.Point(93, 98)
        Me.SaveT.Name = "SaveT"
        Me.SaveT.Size = New System.Drawing.Size(327, 20)
        Me.SaveT.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(95, 127)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(327, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Windows Command Prompt", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FuzzyBlack"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Windows Command Prompt", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 11)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "By Peter Kowalsky (Acheloos)"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(434, 162)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.SaveT)
        Me.Controls.Add(Me.OpenT)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Open)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(450, 200)
        Me.MinimumSize = New System.Drawing.Size(450, 200)
        Me.Name = "Main"
        Me.Text = "FuzzyBlack"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Open As System.Windows.Forms.Button
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents OpenT As System.Windows.Forms.TextBox
    Friend WithEvents SaveT As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
