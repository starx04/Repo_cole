<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb_4 = New System.Windows.Forms.RadioButton()
        Me.rbd_3 = New System.Windows.Forms.RadioButton()
        Me.rbd_2 = New System.Windows.Forms.RadioButton()
        Me.rbd_1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INCRESE EL TEXTO:"
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(226, 32)
        Me.txt_1.Multiline = True
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(272, 70)
        Me.txt_1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rdb_4)
        Me.GroupBox1.Controls.Add(Me.rbd_3)
        Me.GroupBox1.Controls.Add(Me.rbd_2)
        Me.GroupBox1.Controls.Add(Me.rbd_1)
        Me.GroupBox1.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 166)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'rdb_4
        '
        Me.rdb_4.AutoSize = True
        Me.rdb_4.Location = New System.Drawing.Point(6, 128)
        Me.rdb_4.Name = "rdb_4"
        Me.rdb_4.Size = New System.Drawing.Size(95, 24)
        Me.rdb_4.TabIndex = 3
        Me.rdb_4.TabStop = True
        Me.rdb_4.Text = "Mayuscula"
        Me.rdb_4.UseVisualStyleBackColor = True
        '
        'rbd_3
        '
        Me.rbd_3.AutoSize = True
        Me.rbd_3.Location = New System.Drawing.Point(6, 90)
        Me.rbd_3.Name = "rbd_3"
        Me.rbd_3.Size = New System.Drawing.Size(92, 24)
        Me.rbd_3.TabIndex = 2
        Me.rbd_3.TabStop = True
        Me.rbd_3.Text = "Minuscula"
        Me.rbd_3.UseVisualStyleBackColor = True
        '
        'rbd_2
        '
        Me.rbd_2.AutoSize = True
        Me.rbd_2.Location = New System.Drawing.Point(6, 53)
        Me.rbd_2.Name = "rbd_2"
        Me.rbd_2.Size = New System.Drawing.Size(74, 24)
        Me.rbd_2.TabIndex = 1
        Me.rbd_2.TabStop = True
        Me.rbd_2.Text = "Cursiva"
        Me.rbd_2.UseVisualStyleBackColor = True
        '
        'rbd_1
        '
        Me.rbd_1.AutoSize = True
        Me.rbd_1.Location = New System.Drawing.Point(6, 19)
        Me.rbd_1.Name = "rbd_1"
        Me.rbd_1.Size = New System.Drawing.Size(78, 24)
        Me.rbd_1.TabIndex = 0
        Me.rbd_1.TabStop = True
        Me.rbd_1.Text = "Negrilla"
        Me.rbd_1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txt_1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(-24, -15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 426)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(205, 31)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 24)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "subrayado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 397)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbd_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbd_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbd_1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
