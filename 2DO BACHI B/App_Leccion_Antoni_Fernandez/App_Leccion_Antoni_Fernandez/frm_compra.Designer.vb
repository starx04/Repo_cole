<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_compra))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.nud_compra = New System.Windows.Forms.NumericUpDown()
        Me.nud_descuento = New System.Windows.Forms.NumericUpDown()
        Me.nud_total = New System.Windows.Forms.NumericUpDown()
        CType(Me.nud_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_descuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(60, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESAR LA COMPRA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkBlue
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(62, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DESCUENTO DE LA COMPRA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkBlue
        Me.Label3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(61, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TOTAL A PAGAR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkBlue
        Me.Label4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(164, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(397, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "INGRESO Y CALCULO DE LA COMPRA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkBlue
        Me.Label5.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(12, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(305, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Elaborado por: Antoni Fernandez"
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_calcular.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_calcular.Location = New System.Drawing.Point(245, 318)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(142, 62)
        Me.btn_calcular.TabIndex = 8
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_salir.Location = New System.Drawing.Point(64, 318)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(108, 46)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_limpiar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_limpiar.Location = New System.Drawing.Point(441, 312)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(159, 75)
        Me.btn_limpiar.TabIndex = 10
        Me.btn_limpiar.Text = "INGRESO DE OTRA COMPRA"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'nud_compra
        '
        Me.nud_compra.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nud_compra.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_compra.ForeColor = System.Drawing.SystemColors.Window
        Me.nud_compra.Location = New System.Drawing.Point(441, 121)
        Me.nud_compra.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_compra.Name = "nud_compra"
        Me.nud_compra.Size = New System.Drawing.Size(120, 28)
        Me.nud_compra.TabIndex = 11
        '
        'nud_descuento
        '
        Me.nud_descuento.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nud_descuento.Enabled = False
        Me.nud_descuento.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_descuento.ForeColor = System.Drawing.SystemColors.Window
        Me.nud_descuento.Location = New System.Drawing.Point(441, 172)
        Me.nud_descuento.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_descuento.Name = "nud_descuento"
        Me.nud_descuento.Size = New System.Drawing.Size(120, 28)
        Me.nud_descuento.TabIndex = 12
        '
        'nud_total
        '
        Me.nud_total.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.nud_total.Enabled = False
        Me.nud_total.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_total.ForeColor = System.Drawing.SystemColors.Window
        Me.nud_total.Location = New System.Drawing.Point(441, 239)
        Me.nud_total.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_total.Name = "nud_total"
        Me.nud_total.Size = New System.Drawing.Size(120, 28)
        Me.nud_total.TabIndex = 13
        '
        'frm_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(651, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.nud_total)
        Me.Controls.Add(Me.nud_descuento)
        Me.Controls.Add(Me.nud_compra)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRESO DE LA COMPRA"
        CType(Me.nud_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_descuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents nud_compra As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_descuento As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_total As System.Windows.Forms.NumericUpDown

End Class
