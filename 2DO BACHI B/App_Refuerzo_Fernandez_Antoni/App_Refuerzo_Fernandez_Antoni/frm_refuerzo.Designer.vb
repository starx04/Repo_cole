<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_refuerzo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_refuerzo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_trabajador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_antiguedad = New System.Windows.Forms.ComboBox()
        Me.txt_pago = New System.Windows.Forms.TextBox()
        Me.txt_hora = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_STotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bono = New System.Windows.Forms.TextBox()
        Me.txt_SParcial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Refuerzo Del Cuarto Parcial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pago por Horas:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txt_trabajador)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbo_antiguedad)
        Me.GroupBox1.Controls.Add(Me.txt_pago)
        Me.GroupBox1.Controls.Add(Me.txt_hora)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 217)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'txt_trabajador
        '
        Me.txt_trabajador.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_trabajador.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txt_trabajador.Location = New System.Drawing.Point(313, 34)
        Me.txt_trabajador.Name = "txt_trabajador"
        Me.txt_trabajador.Size = New System.Drawing.Size(146, 32)
        Me.txt_trabajador.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(15, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(279, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Nombre del Trabajador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Seleccione la Antiguedad:"
        '
        'cbo_antiguedad
        '
        Me.cbo_antiguedad.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbo_antiguedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_antiguedad.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.cbo_antiguedad.FormattingEnabled = True
        Me.cbo_antiguedad.Items.AddRange(New Object() {"1 - 10 años", "11 - 20 años", "21 - 30 años", "31 - 40 años", "Mayor a 40"})
        Me.cbo_antiguedad.Location = New System.Drawing.Point(313, 178)
        Me.cbo_antiguedad.Name = "cbo_antiguedad"
        Me.cbo_antiguedad.Size = New System.Drawing.Size(152, 33)
        Me.cbo_antiguedad.TabIndex = 4
        '
        'txt_pago
        '
        Me.txt_pago.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_pago.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txt_pago.Location = New System.Drawing.Point(313, 127)
        Me.txt_pago.Name = "txt_pago"
        Me.txt_pago.Size = New System.Drawing.Size(100, 32)
        Me.txt_pago.TabIndex = 4
        '
        'txt_hora
        '
        Me.txt_hora.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_hora.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txt_hora.Location = New System.Drawing.Point(313, 79)
        Me.txt_hora.Name = "txt_hora"
        Me.txt_hora.Size = New System.Drawing.Size(100, 32)
        Me.txt_hora.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.txt_STotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_bono)
        Me.GroupBox2.Controls.Add(Me.txt_SParcial)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 195)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida de Datos"
        '
        'txt_STotal
        '
        Me.txt_STotal.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_STotal.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txt_STotal.Location = New System.Drawing.Point(313, 148)
        Me.txt_STotal.Name = "txt_STotal"
        Me.txt_STotal.ReadOnly = True
        Me.txt_STotal.Size = New System.Drawing.Size(100, 32)
        Me.txt_STotal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(15, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sueldo Total:"
        '
        'txt_bono
        '
        Me.txt_bono.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_bono.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txt_bono.Location = New System.Drawing.Point(313, 97)
        Me.txt_bono.Name = "txt_bono"
        Me.txt_bono.ReadOnly = True
        Me.txt_bono.Size = New System.Drawing.Size(100, 32)
        Me.txt_bono.TabIndex = 4
        '
        'txt_SParcial
        '
        Me.txt_SParcial.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_SParcial.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txt_SParcial.Location = New System.Drawing.Point(313, 49)
        Me.txt_SParcial.Name = "txt_SParcial"
        Me.txt_SParcial.ReadOnly = True
        Me.txt_SParcial.Size = New System.Drawing.Size(100, 32)
        Me.txt_SParcial.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Bono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(15, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sueldo Parcial:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(12, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Elaborado por: Antoni Fernandez"
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_calcular.Location = New System.Drawing.Point(526, 273)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(147, 43)
        Me.btn_calcular.TabIndex = 8
        Me.btn_calcular.Text = "Comprobar"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_limpiar.Location = New System.Drawing.Point(544, 333)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(118, 43)
        Me.btn_limpiar.TabIndex = 9
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Location = New System.Drawing.Point(544, 402)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(118, 43)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(544, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frm_refuerzo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(703, 499)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Elephant", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.Name = "frm_refuerzo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "****Refuerzo****"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_trabajador As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_antiguedad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pago As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_STotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_bono As System.Windows.Forms.TextBox
    Friend WithEvents txt_SParcial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
