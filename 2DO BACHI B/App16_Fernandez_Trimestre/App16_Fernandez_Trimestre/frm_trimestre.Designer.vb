<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_trimestre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_trimestre))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nud_dia = New System.Windows.Forms.NumericUpDown()
        Me.btn_comprobar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nud_anio = New System.Windows.Forms.NumericUpDown()
        Me.nud_mes = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        CType(Me.nud_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_anio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(113, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ingresa el dia:"
        '
        'nud_dia
        '
        Me.nud_dia.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_dia.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_dia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nud_dia.Location = New System.Drawing.Point(307, 93)
        Me.nud_dia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nud_dia.Name = "nud_dia"
        Me.nud_dia.Size = New System.Drawing.Size(62, 35)
        Me.nud_dia.TabIndex = 1
        '
        'btn_comprobar
        '
        Me.btn_comprobar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_comprobar.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprobar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_comprobar.Location = New System.Drawing.Point(204, 322)
        Me.btn_comprobar.Name = "btn_comprobar"
        Me.btn_comprobar.Size = New System.Drawing.Size(163, 50)
        Me.btn_comprobar.TabIndex = 2
        Me.btn_comprobar.Text = "Comprobar"
        Me.btn_comprobar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Elaborado por:  Antoni Fernandez"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(113, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ingresa el año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Turquoise
        Me.Label4.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(114, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ingresa el mes:"
        '
        'nud_anio
        '
        Me.nud_anio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_anio.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_anio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nud_anio.Location = New System.Drawing.Point(307, 204)
        Me.nud_anio.Maximum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.nud_anio.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nud_anio.Name = "nud_anio"
        Me.nud_anio.Size = New System.Drawing.Size(91, 35)
        Me.nud_anio.TabIndex = 7
        Me.nud_anio.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'nud_mes
        '
        Me.nud_mes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_mes.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_mes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nud_mes.Location = New System.Drawing.Point(307, 151)
        Me.nud_mes.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nud_mes.Name = "nud_mes"
        Me.nud_mes.Size = New System.Drawing.Size(62, 35)
        Me.nud_mes.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 282)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(433, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(445, 282)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(84, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(84, 90)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_salir.Location = New System.Drawing.Point(181, 267)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(96, 49)
        Me.btn_salir.TabIndex = 13
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_limpiar.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_limpiar.Location = New System.Drawing.Point(307, 267)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(132, 45)
        Me.btn_limpiar.TabIndex = 14
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'frm_trimestre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 421)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nud_mes)
        Me.Controls.Add(Me.nud_anio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_comprobar)
        Me.Controls.Add(Me.nud_dia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_trimestre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIMESTRE"
        CType(Me.nud_dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_anio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nud_dia As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_comprobar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nud_anio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_mes As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button

End Class
