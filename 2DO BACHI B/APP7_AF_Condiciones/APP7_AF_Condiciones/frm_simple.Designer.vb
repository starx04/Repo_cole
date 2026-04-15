<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_simple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_simple))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_mensaje = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.nud_edad = New System.Windows.Forms.NumericUpDown()
        CType(Me.nud_edad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(90, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la Edad"
        '
        'btn_mensaje
        '
        Me.btn_mensaje.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_mensaje.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_mensaje.Location = New System.Drawing.Point(210, 174)
        Me.btn_mensaje.Name = "btn_mensaje"
        Me.btn_mensaje.Size = New System.Drawing.Size(178, 88)
        Me.btn_mensaje.TabIndex = 1
        Me.btn_mensaje.Text = "Mensaje"
        Me.btn_mensaje.UseVisualStyleBackColor = False
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_menu.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_menu.Location = New System.Drawing.Point(50, 333)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(163, 78)
        Me.btn_menu.TabIndex = 2
        Me.btn_menu.Text = "Menu"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'nud_edad
        '
        Me.nud_edad.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nud_edad.Font = New System.Drawing.Font("NSimSun", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_edad.ForeColor = System.Drawing.SystemColors.Window
        Me.nud_edad.Location = New System.Drawing.Point(348, 54)
        Me.nud_edad.Name = "nud_edad"
        Me.nud_edad.Size = New System.Drawing.Size(124, 31)
        Me.nud_edad.TabIndex = 11
        '
        'frm_simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.nud_edad)
        Me.Controls.Add(Me.btn_menu)
        Me.Controls.Add(Me.btn_mensaje)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_simple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estructuras Condicionales simple"
        CType(Me.nud_edad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_mensaje As System.Windows.Forms.Button
    Friend WithEvents btn_menu As System.Windows.Forms.Button
    Friend WithEvents nud_edad As System.Windows.Forms.NumericUpDown
End Class
