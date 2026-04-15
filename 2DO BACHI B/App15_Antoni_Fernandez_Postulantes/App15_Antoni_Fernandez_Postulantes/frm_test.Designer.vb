<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_test))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_postulante = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.nud_cantPreg = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nud_cantResp = New System.Windows.Forms.NumericUpDown()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_cantPreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_cantResp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(135, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESULTADO DE TEST DE POSTULACION"
        '
        'txt_postulante
        '
        Me.txt_postulante.BackColor = System.Drawing.Color.Navy
        Me.txt_postulante.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_postulante.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_postulante.Location = New System.Drawing.Point(205, 79)
        Me.txt_postulante.Name = "txt_postulante"
        Me.txt_postulante.Size = New System.Drawing.Size(286, 28)
        Me.txt_postulante.TabIndex = 1
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.Navy
        Me.btn_calcular.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_calcular.Location = New System.Drawing.Point(247, 219)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(127, 54)
        Me.btn_calcular.TabIndex = 3
        Me.btn_calcular.Text = "Calcular Porcentaje"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.txt_mensaje)
        Me.GroupBox1.Controls.Add(Me.txt_porcentaje)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(55, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 152)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'txt_mensaje
        '
        Me.txt_mensaje.BackColor = System.Drawing.Color.Navy
        Me.txt_mensaje.Enabled = False
        Me.txt_mensaje.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_mensaje.Location = New System.Drawing.Point(84, 88)
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(223, 28)
        Me.txt_mensaje.TabIndex = 3
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.BackColor = System.Drawing.Color.Navy
        Me.txt_porcentaje.Enabled = False
        Me.txt_porcentaje.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_porcentaje.Location = New System.Drawing.Point(126, 38)
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.Size = New System.Drawing.Size(110, 28)
        Me.txt_porcentaje.TabIndex = 2
        '
        'nud_cantPreg
        '
        Me.nud_cantPreg.BackColor = System.Drawing.Color.Navy
        Me.nud_cantPreg.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_cantPreg.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.nud_cantPreg.Location = New System.Drawing.Point(446, 123)
        Me.nud_cantPreg.Name = "nud_cantPreg"
        Me.nud_cantPreg.Size = New System.Drawing.Size(120, 28)
        Me.nud_cantPreg.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(50, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Postulante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(51, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad De Preguntas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(50, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cantidad De Respuestas Acertadas:"
        '
        'nud_cantResp
        '
        Me.nud_cantResp.BackColor = System.Drawing.Color.Navy
        Me.nud_cantResp.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_cantResp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.nud_cantResp.Location = New System.Drawing.Point(446, 174)
        Me.nud_cantResp.Name = "nud_cantResp"
        Me.nud_cantResp.Size = New System.Drawing.Size(120, 28)
        Me.nud_cantResp.TabIndex = 9
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.Navy
        Me.btn_nuevo.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_nuevo.Location = New System.Drawing.Point(510, 334)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(115, 40)
        Me.btn_nuevo.TabIndex = 10
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Navy
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_salir.Location = New System.Drawing.Point(510, 391)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(115, 40)
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(433, 208)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frm_test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(673, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.nud_cantResp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nud_cantPreg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_postulante)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEST POSTULACION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_cantPreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_cantResp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_postulante As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents txt_porcentaje As System.Windows.Forms.TextBox
    Friend WithEvents nud_cantPreg As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nud_cantResp As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
