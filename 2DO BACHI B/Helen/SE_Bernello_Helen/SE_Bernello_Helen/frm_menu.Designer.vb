
Public Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.btn_tema1 = New System.Windows.Forms.Button()
        Me.btn_tema2 = New System.Windows.Forms.Button()
        Me.btn_tema3 = New System.Windows.Forms.Button()
        Me.btn_tema4 = New System.Windows.Forms.Button()
        Me.btn_tema5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tema1
        '
        Me.btn_tema1.BackColor = System.Drawing.Color.LightCoral
        Me.btn_tema1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tema1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_tema1.Location = New System.Drawing.Point(308, 215)
        Me.btn_tema1.Name = "btn_tema1"
        Me.btn_tema1.Size = New System.Drawing.Size(117, 45)
        Me.btn_tema1.TabIndex = 0
        Me.btn_tema1.Text = "Tema 1"
        Me.btn_tema1.UseVisualStyleBackColor = False
        Me.btn_tema1.Visible = False
        '
        'btn_tema2
        '
        Me.btn_tema2.BackColor = System.Drawing.Color.LightCoral
        Me.btn_tema2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tema2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_tema2.Location = New System.Drawing.Point(421, 156)
        Me.btn_tema2.Name = "btn_tema2"
        Me.btn_tema2.Size = New System.Drawing.Size(117, 45)
        Me.btn_tema2.TabIndex = 1
        Me.btn_tema2.Text = "Tema 2"
        Me.btn_tema2.UseVisualStyleBackColor = False
        Me.btn_tema2.Visible = False
        '
        'btn_tema3
        '
        Me.btn_tema3.BackColor = System.Drawing.Color.LightCoral
        Me.btn_tema3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tema3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_tema3.Location = New System.Drawing.Point(536, 215)
        Me.btn_tema3.Name = "btn_tema3"
        Me.btn_tema3.Size = New System.Drawing.Size(117, 45)
        Me.btn_tema3.TabIndex = 3
        Me.btn_tema3.Text = "Tema 3"
        Me.btn_tema3.UseVisualStyleBackColor = False
        Me.btn_tema3.Visible = False
        '
        'btn_tema4
        '
        Me.btn_tema4.BackColor = System.Drawing.Color.LightCoral
        Me.btn_tema4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tema4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_tema4.Location = New System.Drawing.Point(487, 286)
        Me.btn_tema4.Name = "btn_tema4"
        Me.btn_tema4.Size = New System.Drawing.Size(117, 45)
        Me.btn_tema4.TabIndex = 4
        Me.btn_tema4.Text = "Tema 4"
        Me.btn_tema4.UseVisualStyleBackColor = False
        Me.btn_tema4.Visible = False
        '
        'btn_tema5
        '
        Me.btn_tema5.BackColor = System.Drawing.Color.LightCoral
        Me.btn_tema5.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tema5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_tema5.Location = New System.Drawing.Point(351, 286)
        Me.btn_tema5.Name = "btn_tema5"
        Me.btn_tema5.Size = New System.Drawing.Size(117, 45)
        Me.btn_tema5.TabIndex = 5
        Me.btn_tema5.Text = "Tema 5"
        Me.btn_tema5.UseVisualStyleBackColor = False
        Me.btn_tema5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Iniciemos nuestro aprendizaje escogiendo un tema"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(5, 300)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(287, 179)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.LightCoral
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Location = New System.Drawing.Point(472, 417)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(117, 45)
        Me.btn_salir.TabIndex = 12
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        Me.btn_salir.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 63)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "elijamos el tema a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aprender para ello " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "da click en mi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(699, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_tema5)
        Me.Controls.Add(Me.btn_tema4)
        Me.Controls.Add(Me.btn_tema3)
        Me.Controls.Add(Me.btn_tema2)
        Me.Controls.Add(Me.btn_tema1)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_menu"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
