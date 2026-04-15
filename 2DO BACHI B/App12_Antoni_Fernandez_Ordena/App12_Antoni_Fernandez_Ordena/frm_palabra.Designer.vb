<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_palabra
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_palabra))
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.ldl_palabra = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.btn_comprobar = New System.Windows.Forms.Button()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.txt_o = New System.Windows.Forms.TextBox()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_titulo.Font = New System.Drawing.Font("Elephant", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(25, 32)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(672, 38)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Ordena las letras para formar la palabra:"
        '
        'ldl_palabra
        '
        Me.ldl_palabra.AutoSize = True
        Me.ldl_palabra.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ldl_palabra.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldl_palabra.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ldl_palabra.Location = New System.Drawing.Point(233, 82)
        Me.ldl_palabra.Name = "ldl_palabra"
        Me.ldl_palabra.Size = New System.Drawing.Size(71, 25)
        Me.ldl_palabra.TabIndex = 1
        Me.ldl_palabra.Text = "o c b a"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(109, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txt_b
        '
        Me.txt_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_b.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_b.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_b.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_b.Location = New System.Drawing.Point(172, 323)
        Me.txt_b.MaxLength = 1
        Me.txt_b.Multiline = True
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(40, 40)
        Me.txt_b.TabIndex = 1
        '
        'btn_comprobar
        '
        Me.btn_comprobar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_comprobar.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comprobar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_comprobar.Location = New System.Drawing.Point(199, 381)
        Me.btn_comprobar.Name = "btn_comprobar"
        Me.btn_comprobar.Size = New System.Drawing.Size(143, 52)
        Me.btn_comprobar.TabIndex = 5
        Me.btn_comprobar.Text = "Comprobar"
        Me.btn_comprobar.UseVisualStyleBackColor = False
        '
        'btn_siguiente
        '
        Me.btn_siguiente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_siguiente.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_siguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_siguiente.Location = New System.Drawing.Point(508, 350)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(156, 83)
        Me.btn_siguiente.TabIndex = 6
        Me.btn_siguiente.Text = "Siquiente Juego"
        Me.btn_siguiente.UseVisualStyleBackColor = False
        '
        'txt_o
        '
        Me.txt_o.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_o.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_o.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_o.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_o.Location = New System.Drawing.Point(227, 323)
        Me.txt_o.MaxLength = 1
        Me.txt_o.Multiline = True
        Me.txt_o.Name = "txt_o"
        Me.txt_o.Size = New System.Drawing.Size(40, 40)
        Me.txt_o.TabIndex = 2
        '
        'txt_c
        '
        Me.txt_c.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_c.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_c.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_c.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_c.Location = New System.Drawing.Point(284, 323)
        Me.txt_c.MaxLength = 1
        Me.txt_c.Multiline = True
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(40, 40)
        Me.txt_c.TabIndex = 3
        '
        'txt_a
        '
        Me.txt_a.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_a.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_a.Font = New System.Drawing.Font("Elephant", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_a.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_a.Location = New System.Drawing.Point(339, 323)
        Me.txt_a.MaxLength = 1
        Me.txt_a.Multiline = True
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(40, 40)
        Me.txt_a.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Elaborado por: Antoni Fernandez"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_palabra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 487)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_a)
        Me.Controls.Add(Me.txt_c)
        Me.Controls.Add(Me.txt_o)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.btn_comprobar)
        Me.Controls.Add(Me.txt_b)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ldl_palabra)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_palabra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDENA LETRAS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents ldl_palabra As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_b As System.Windows.Forms.TextBox
    Friend WithEvents btn_comprobar As System.Windows.Forms.Button
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents txt_o As System.Windows.Forms.TextBox
    Friend WithEvents txt_c As System.Windows.Forms.TextBox
    Friend WithEvents txt_a As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
