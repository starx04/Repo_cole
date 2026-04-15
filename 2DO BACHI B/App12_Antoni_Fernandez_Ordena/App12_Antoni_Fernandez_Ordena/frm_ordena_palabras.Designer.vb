<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ordena_palabras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ordena_palabras))
        Me.cbo_1 = New System.Windows.Forms.ComboBox()
        Me.cbo_2 = New System.Windows.Forms.ComboBox()
        Me.cbo_3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_1
        '
        Me.cbo_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_1.Font = New System.Drawing.Font("Elephant", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbo_1.FormattingEnabled = True
        Me.cbo_1.Items.AddRange(New Object() {"LOS", "NIÑOS", "COMEN"})
        Me.cbo_1.Location = New System.Drawing.Point(75, 325)
        Me.cbo_1.Name = "cbo_1"
        Me.cbo_1.Size = New System.Drawing.Size(146, 35)
        Me.cbo_1.TabIndex = 0
        '
        'cbo_2
        '
        Me.cbo_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbo_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_2.Font = New System.Drawing.Font("Elephant", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbo_2.FormattingEnabled = True
        Me.cbo_2.Items.AddRange(New Object() {"LOS", "NIÑOS", "COMEN"})
        Me.cbo_2.Location = New System.Drawing.Point(236, 325)
        Me.cbo_2.Name = "cbo_2"
        Me.cbo_2.Size = New System.Drawing.Size(151, 35)
        Me.cbo_2.TabIndex = 1
        '
        'cbo_3
        '
        Me.cbo_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbo_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_3.Font = New System.Drawing.Font("Elephant", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cbo_3.FormattingEnabled = True
        Me.cbo_3.Items.AddRange(New Object() {"LOS", "NIÑOS", "COMEN"})
        Me.cbo_3.Location = New System.Drawing.Point(393, 325)
        Me.cbo_3.Name = "cbo_3"
        Me.cbo_3.Size = New System.Drawing.Size(150, 35)
        Me.cbo_3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Elephant", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(659, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ordena las palabras para formar la oracion"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Elephant", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(216, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Comprobar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salir.Location = New System.Drawing.Point(523, 379)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(153, 60)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Finalizar"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(474, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frm_ordena_palabras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(688, 467)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_3)
        Me.Controls.Add(Me.cbo_2)
        Me.Controls.Add(Me.cbo_1)
        Me.Name = "frm_ordena_palabras"
        Me.Text = "frm_ordena_palabras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
