<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Counter
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Counter))
        Me.Counter_btn = New System.Windows.Forms.Button()
        Me.Counter_txt = New System.Windows.Forms.TextBox()
        Me.Save_txt = New System.Windows.Forms.TextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.Open_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_countup = New System.Windows.Forms.TextBox()
        Me.New_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Counter_btn
        '
        Me.Counter_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Counter_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Counter_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Counter_btn.Location = New System.Drawing.Point(12, 189)
        Me.Counter_btn.Name = "Counter_btn"
        Me.Counter_btn.Size = New System.Drawing.Size(776, 249)
        Me.Counter_btn.TabIndex = 0
        Me.Counter_btn.Text = "Count up!"
        Me.Counter_btn.UseVisualStyleBackColor = False
        '
        'Counter_txt
        '
        Me.Counter_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Counter_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Counter_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Counter_txt.Location = New System.Drawing.Point(12, 101)
        Me.Counter_txt.Multiline = True
        Me.Counter_txt.Name = "Counter_txt"
        Me.Counter_txt.ReadOnly = True
        Me.Counter_txt.Size = New System.Drawing.Size(776, 88)
        Me.Counter_txt.TabIndex = 1
        Me.Counter_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save_txt
        '
        Me.Save_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Save_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Save_txt.Location = New System.Drawing.Point(12, 79)
        Me.Save_txt.Name = "Save_txt"
        Me.Save_txt.ReadOnly = True
        Me.Save_txt.Size = New System.Drawing.Size(776, 26)
        Me.Save_txt.TabIndex = 2
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.save_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.save_btn.Location = New System.Drawing.Point(12, 11)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(55, 68)
        Me.save_btn.TabIndex = 3
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'Open_btn
        '
        Me.Open_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Open_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Open_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Open_btn.Location = New System.Drawing.Point(66, 11)
        Me.Open_btn.Name = "Open_btn"
        Me.Open_btn.Size = New System.Drawing.Size(55, 68)
        Me.Open_btn.TabIndex = 4
        Me.Open_btn.Text = "Open"
        Me.Open_btn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(625, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 68)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "+1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(679, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 68)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "+5"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(733, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 68)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "+10"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_countup
        '
        Me.txt_countup.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txt_countup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_countup.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_countup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txt_countup.Location = New System.Drawing.Point(20, 338)
        Me.txt_countup.Name = "txt_countup"
        Me.txt_countup.Size = New System.Drawing.Size(760, 28)
        Me.txt_countup.TabIndex = 8
        Me.txt_countup.Text = "+1"
        Me.txt_countup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'New_btn
        '
        Me.New_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.New_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.New_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.New_btn.Location = New System.Drawing.Point(120, 11)
        Me.New_btn.Name = "New_btn"
        Me.New_btn.Size = New System.Drawing.Size(55, 68)
        Me.New_btn.TabIndex = 9
        Me.New_btn.Text = "New"
        Me.New_btn.UseVisualStyleBackColor = False
        '
        'Counter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.Controls.Add(Me.New_btn)
        Me.Controls.Add(Me.txt_countup)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Open_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.Save_txt)
        Me.Controls.Add(Me.Counter_txt)
        Me.Controls.Add(Me.Counter_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Counter"
        Me.Text = "Shiny Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Counter_btn As Button
    Friend WithEvents Counter_txt As TextBox
    Friend WithEvents Save_txt As TextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents Open_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_countup As TextBox
    Friend WithEvents New_btn As Button
End Class
