<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PartesPC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PartesPC))
        Me.pic_evaluacion = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_mouse = New System.Windows.Forms.Label()
        Me.lbl_cpu = New System.Windows.Forms.Label()
        Me.lbl_teclado = New System.Windows.Forms.Label()
        Me.lbl_monitor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_partes = New System.Windows.Forms.Label()
        CType(Me.pic_evaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pic_evaluacion
        '
        Me.pic_evaluacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_evaluacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_evaluacion.Image = CType(resources.GetObject("pic_evaluacion.Image"), System.Drawing.Image)
        Me.pic_evaluacion.Location = New System.Drawing.Point(565, 301)
        Me.pic_evaluacion.Name = "pic_evaluacion"
        Me.pic_evaluacion.Size = New System.Drawing.Size(167, 187)
        Me.pic_evaluacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_evaluacion.TabIndex = 0
        Me.pic_evaluacion.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(104, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PARTES DE LA COMPUTADORA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.lbl_mouse)
        Me.GroupBox1.Controls.Add(Me.lbl_cpu)
        Me.GroupBox1.Controls.Add(Me.lbl_teclado)
        Me.GroupBox1.Controls.Add(Me.lbl_monitor)
        Me.GroupBox1.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(26, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 369)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dale click para conocer sus partes"
        '
        'lbl_mouse
        '
        Me.lbl_mouse.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mouse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_mouse.Location = New System.Drawing.Point(312, 302)
        Me.lbl_mouse.Name = "lbl_mouse"
        Me.lbl_mouse.Size = New System.Drawing.Size(66, 44)
        Me.lbl_mouse.TabIndex = 3
        '
        'lbl_cpu
        '
        Me.lbl_cpu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cpu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_cpu.Location = New System.Drawing.Point(324, 30)
        Me.lbl_cpu.Name = "lbl_cpu"
        Me.lbl_cpu.Size = New System.Drawing.Size(156, 263)
        Me.lbl_cpu.TabIndex = 2
        '
        'lbl_teclado
        '
        Me.lbl_teclado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_teclado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_teclado.Location = New System.Drawing.Point(47, 272)
        Me.lbl_teclado.Name = "lbl_teclado"
        Me.lbl_teclado.Size = New System.Drawing.Size(241, 60)
        Me.lbl_teclado.TabIndex = 1
        '
        'lbl_monitor
        '
        Me.lbl_monitor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_monitor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_monitor.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor.Location = New System.Drawing.Point(131, 16)
        Me.lbl_monitor.Name = "lbl_monitor"
        Me.lbl_monitor.Size = New System.Drawing.Size(175, 195)
        Me.lbl_monitor.TabIndex = 0
        Me.lbl_monitor.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(66, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Elaborado por: Antoni Fernandez"
        '
        'lbl_partes
        '
        Me.lbl_partes.BackColor = System.Drawing.Color.Black
        Me.lbl_partes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_partes.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_partes.Location = New System.Drawing.Point(594, 128)
        Me.lbl_partes.Name = "lbl_partes"
        Me.lbl_partes.Size = New System.Drawing.Size(116, 46)
        Me.lbl_partes.TabIndex = 4
        Me.lbl_partes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_PartesPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 500)
        Me.Controls.Add(Me.lbl_partes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_evaluacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_PartesPC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APRENDE COMPUTACION"
        CType(Me.pic_evaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_evaluacion As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_monitor As System.Windows.Forms.Label
    Friend WithEvents lbl_mouse As System.Windows.Forms.Label
    Friend WithEvents lbl_cpu As System.Windows.Forms.Label
    Friend WithEvents lbl_teclado As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_partes As System.Windows.Forms.Label

End Class
