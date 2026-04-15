<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.btn_simple = New System.Windows.Forms.Button()
        Me.btn_doble = New System.Windows.Forms.Button()
        Me.btn_multiple = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_simple
        '
        Me.btn_simple.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_simple.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simple.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simple.Location = New System.Drawing.Point(225, 73)
        Me.btn_simple.Name = "btn_simple"
        Me.btn_simple.Size = New System.Drawing.Size(203, 74)
        Me.btn_simple.TabIndex = 0
        Me.btn_simple.Text = "Simple"
        Me.btn_simple.UseVisualStyleBackColor = False
        '
        'btn_doble
        '
        Me.btn_doble.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_doble.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_doble.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_doble.Location = New System.Drawing.Point(225, 177)
        Me.btn_doble.Name = "btn_doble"
        Me.btn_doble.Size = New System.Drawing.Size(203, 74)
        Me.btn_doble.TabIndex = 1
        Me.btn_doble.Text = "Doble"
        Me.btn_doble.UseVisualStyleBackColor = False
        '
        'btn_multiple
        '
        Me.btn_multiple.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_multiple.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiple.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_multiple.Location = New System.Drawing.Point(225, 271)
        Me.btn_multiple.Name = "btn_multiple"
        Me.btn_multiple.Size = New System.Drawing.Size(203, 74)
        Me.btn_multiple.TabIndex = 2
        Me.btn_multiple.Text = "Multiple"
        Me.btn_multiple.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_salir.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_salir.Location = New System.Drawing.Point(541, 349)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(82, 61)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "X"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(47, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elaborado por Antoni Fernandez"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(653, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_multiple)
        Me.Controls.Add(Me.btn_doble)
        Me.Controls.Add(Me.btn_simple)
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estructuras Condicionales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_simple As System.Windows.Forms.Button
    Friend WithEvents btn_doble As System.Windows.Forms.Button
    Friend WithEvents btn_multiple As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
