<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.cbo_operaciones = New System.Windows.Forms.ComboBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.txt_n2 = New System.Windows.Forms.TextBox()
        Me.txt_n1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_limpiar.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_limpiar.Location = New System.Drawing.Point(176, 258)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(131, 52)
        Me.btn_limpiar.TabIndex = 10
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'cbo_operaciones
        '
        Me.cbo_operaciones.BackColor = System.Drawing.SystemColors.Control
        Me.cbo_operaciones.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_operaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbo_operaciones.FormattingEnabled = True
        Me.cbo_operaciones.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cbo_operaciones.Location = New System.Drawing.Point(213, 128)
        Me.cbo_operaciones.Name = "cbo_operaciones"
        Me.cbo_operaciones.Size = New System.Drawing.Size(55, 21)
        Me.cbo_operaciones.TabIndex = 9
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_salir.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Location = New System.Drawing.Point(410, 258)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(131, 52)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.txt_resultado)
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.cbo_operaciones)
        Me.GroupBox1.Controls.Add(Me.txt_n2)
        Me.GroupBox1.Controls.Add(Me.txt_n1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 429)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(443, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "="
        '
        'txt_resultado
        '
        Me.txt_resultado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_resultado.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_resultado.Location = New System.Drawing.Point(492, 102)
        Me.txt_resultado.Multiline = True
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.ReadOnly = True
        Me.txt_resultado.Size = New System.Drawing.Size(105, 74)
        Me.txt_resultado.TabIndex = 6
        '
        'txt_n2
        '
        Me.txt_n2.BackColor = System.Drawing.SystemColors.Control
        Me.txt_n2.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_n2.Location = New System.Drawing.Point(305, 103)
        Me.txt_n2.Multiline = True
        Me.txt_n2.Name = "txt_n2"
        Me.txt_n2.Size = New System.Drawing.Size(116, 73)
        Me.txt_n2.TabIndex = 5
        '
        'txt_n1
        '
        Me.txt_n1.BackColor = System.Drawing.SystemColors.Control
        Me.txt_n1.Font = New System.Drawing.Font("MS PGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_n1.Location = New System.Drawing.Point(72, 103)
        Me.txt_n1.Multiline = True
        Me.txt_n1.Name = "txt_n1"
        Me.txt_n1.Size = New System.Drawing.Size(100, 73)
        Me.txt_n1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents cbo_operaciones As System.Windows.Forms.ComboBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_resultado As System.Windows.Forms.TextBox
    Friend WithEvents txt_n2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_n1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
