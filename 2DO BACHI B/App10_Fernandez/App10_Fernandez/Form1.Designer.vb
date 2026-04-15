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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud_n1 = New System.Windows.Forms.NumericUpDown()
        Me.nud_n2 = New System.Windows.Forms.NumericUpDown()
        Me.nud_n3 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_presentar = New System.Windows.Forms.Button()
        Me.txt_mayor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_menor = New System.Windows.Forms.TextBox()
        CType(Me.nud_n1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_n2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_n3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(32, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESE EL PRIMER NUMERO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(31, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INGRESE EL SEGUNDO NUMERO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(31, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "INGRESE EL TERECER NUMERO"
        '
        'nud_n1
        '
        Me.nud_n1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_n1.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_n1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nud_n1.Location = New System.Drawing.Point(461, 31)
        Me.nud_n1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nud_n1.Name = "nud_n1"
        Me.nud_n1.Size = New System.Drawing.Size(58, 32)
        Me.nud_n1.TabIndex = 3
        '
        'nud_n2
        '
        Me.nud_n2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_n2.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_n2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nud_n2.Location = New System.Drawing.Point(461, 84)
        Me.nud_n2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nud_n2.Name = "nud_n2"
        Me.nud_n2.Size = New System.Drawing.Size(58, 32)
        Me.nud_n2.TabIndex = 4
        '
        'nud_n3
        '
        Me.nud_n3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_n3.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_n3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nud_n3.Location = New System.Drawing.Point(475, 153)
        Me.nud_n3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nud_n3.Name = "nud_n3"
        Me.nud_n3.Size = New System.Drawing.Size(58, 32)
        Me.nud_n3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(37, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(353, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Elaborado por: Antoni Fernandez"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(37, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "EL NUMNERO MAYOR ES:"
        '
        'btn_presentar
        '
        Me.btn_presentar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_presentar.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_presentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_presentar.Location = New System.Drawing.Point(108, 209)
        Me.btn_presentar.Name = "btn_presentar"
        Me.btn_presentar.Size = New System.Drawing.Size(201, 71)
        Me.btn_presentar.TabIndex = 8
        Me.btn_presentar.Text = "PRESENTAR"
        Me.btn_presentar.UseVisualStyleBackColor = False
        '
        'txt_mayor
        '
        Me.txt_mayor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_mayor.Enabled = False
        Me.txt_mayor.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mayor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_mayor.Location = New System.Drawing.Point(401, 340)
        Me.txt_mayor.Name = "txt_mayor"
        Me.txt_mayor.Size = New System.Drawing.Size(100, 32)
        Me.txt_mayor.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(37, 399)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(322, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "EL NUMNERO MENOR ES:"
        '
        'txt_menor
        '
        Me.txt_menor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_menor.Enabled = False
        Me.txt_menor.Font = New System.Drawing.Font("Elephant", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_menor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_menor.Location = New System.Drawing.Point(401, 399)
        Me.txt_menor.Name = "txt_menor"
        Me.txt_menor.Size = New System.Drawing.Size(100, 32)
        Me.txt_menor.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(702, 496)
        Me.Controls.Add(Me.txt_menor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_mayor)
        Me.Controls.Add(Me.btn_presentar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nud_n3)
        Me.Controls.Add(Me.nud_n2)
        Me.Controls.Add(Me.nud_n1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAYOR DE TRES NUMEROS"
        CType(Me.nud_n1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_n2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_n3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nud_n1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_n2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nud_n3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_presentar As System.Windows.Forms.Button
    Friend WithEvents txt_mayor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_menor As System.Windows.Forms.TextBox

End Class
