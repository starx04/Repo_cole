<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_semana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_semana))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_presentar = New System.Windows.Forms.Button()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.nud_dia = New System.Windows.Forms.NumericUpDown()
        CType(Me.nud_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Aqua
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciona un Numero:"
        '
        'btn_presentar
        '
        Me.btn_presentar.BackColor = System.Drawing.Color.Aqua
        Me.btn_presentar.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_presentar.Location = New System.Drawing.Point(312, 209)
        Me.btn_presentar.Name = "btn_presentar"
        Me.btn_presentar.Size = New System.Drawing.Size(148, 41)
        Me.btn_presentar.TabIndex = 1
        Me.btn_presentar.Text = "Presentar"
        Me.btn_presentar.UseVisualStyleBackColor = False
        '
        'txt_mensaje
        '
        Me.txt_mensaje.BackColor = System.Drawing.Color.Aqua
        Me.txt_mensaje.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mensaje.Location = New System.Drawing.Point(139, 312)
        Me.txt_mensaje.Multiline = True
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.ReadOnly = True
        Me.txt_mensaje.Size = New System.Drawing.Size(506, 79)
        Me.txt_mensaje.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Elaborado por: Antoni Fernandez"
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.Aqua
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(69, 209)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(148, 41)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.Aqua
        Me.btn_limpiar.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(566, 209)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(148, 41)
        Me.btn_limpiar.TabIndex = 6
        Me.btn_limpiar.Text = "Nuevo"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'nud_dia
        '
        Me.nud_dia.BackColor = System.Drawing.Color.Aqua
        Me.nud_dia.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_dia.Location = New System.Drawing.Point(491, 107)
        Me.nud_dia.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nud_dia.Name = "nud_dia"
        Me.nud_dia.ReadOnly = True
        Me.nud_dia.Size = New System.Drawing.Size(120, 28)
        Me.nud_dia.TabIndex = 7
        '
        'frm_semana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.nud_dia)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_mensaje)
        Me.Controls.Add(Me.btn_presentar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_semana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENSAJES PARA LA SEMANA"
        CType(Me.nud_dia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_presentar As System.Windows.Forms.Button
    Friend WithEvents txt_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents nud_dia As System.Windows.Forms.NumericUpDown

End Class
