﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtreg = New System.Windows.Forms.TextBox()
        Me.lblreg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NUEVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtreg)
        Me.GroupBox1.Controls.Add(Me.lblreg)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.Lblid)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 222)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, -83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "N D REGIS"
        '
        'txtreg
        '
        Me.txtreg.BackColor = System.Drawing.Color.White
        Me.txtreg.Location = New System.Drawing.Point(655, 127)
        Me.txtreg.Name = "txtreg"
        Me.txtreg.Size = New System.Drawing.Size(100, 29)
        Me.txtreg.TabIndex = 13
        '
        'lblreg
        '
        Me.lblreg.AutoSize = True
        Me.lblreg.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblreg.Location = New System.Drawing.Point(226, 37)
        Me.lblreg.Name = "lblreg"
        Me.lblreg.Size = New System.Drawing.Size(50, 17)
        Me.lblreg.TabIndex = 12
        Me.lblreg.Text = "C0000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(388, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "FECHA DE REGISTRO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(563, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "EMAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(549, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DIRECCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(121, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "APELLIDOS"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblnombre.Location = New System.Drawing.Point(121, 135)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(86, 17)
        Me.lblnombre.TabIndex = 7
        Me.lblnombre.Text = "NOMBRES"
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lblid.Location = New System.Drawing.Point(121, 92)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(28, 17)
        Me.Lblid.TabIndex = 4
        Me.Lblid.Text = "ID"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(655, 76)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 29)
        Me.txtemail.TabIndex = 6
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.Location = New System.Drawing.Point(226, 127)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 29)
        Me.txtnombre.TabIndex = 5
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.White
        Me.txtapellido.Location = New System.Drawing.Point(226, 175)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(100, 29)
        Me.txtapellido.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.White
        Me.txtdireccion.Location = New System.Drawing.Point(655, 29)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 29)
        Me.txtdireccion.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Forte", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(570, 180)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(226, 89)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 29)
        Me.txtID.TabIndex = 1
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblcodigo.Location = New System.Drawing.Point(121, 37)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(87, 17)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "COD_INTE"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(786, 184)
        Me.DataGridView1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem, Me.MODIFICARToolStripMenuItem, Me.REGISTRARToolStripMenuItem, Me.ELIMINARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NUEVOToolStripMenuItem
        '
        Me.NUEVOToolStripMenuItem.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NUEVOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NUEVOToolStripMenuItem.Name = "NUEVOToolStripMenuItem"
        Me.NUEVOToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.NUEVOToolStripMenuItem.Text = "NUEVO"
        '
        'MODIFICARToolStripMenuItem
        '
        Me.MODIFICARToolStripMenuItem.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MODIFICARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MODIFICARToolStripMenuItem.Name = "MODIFICARToolStripMenuItem"
        Me.MODIFICARToolStripMenuItem.Size = New System.Drawing.Size(116, 21)
        Me.MODIFICARToolStripMenuItem.Text = "MODIFICAR"
        '
        'REGISTRARToolStripMenuItem
        '
        Me.REGISTRARToolStripMenuItem.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.REGISTRARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.REGISTRARToolStripMenuItem.Name = "REGISTRARToolStripMenuItem"
        Me.REGISTRARToolStripMenuItem.Size = New System.Drawing.Size(107, 21)
        Me.REGISTRARToolStripMenuItem.Text = "REGISTRAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ELIMINARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(106, 21)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtreg As TextBox
    Friend WithEvents lblreg As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Lblid As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NUEVOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
End Class
