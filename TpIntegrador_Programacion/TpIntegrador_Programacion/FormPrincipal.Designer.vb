﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaAnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoVerdurasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerCarga = New System.Windows.Forms.Timer(Me.components)
        Me.NuevaEspecieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.InformesToolStripMenuItem, Me.BajaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 0, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(124, 509)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaUsuarioToolStripMenuItem, Me.AltaAnimalesToolStripMenuItem, Me.AltaClienToolStripMenuItem, Me.NuevaEspecieToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 0)
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(115, 39)
        Me.UsuariosToolStripMenuItem.Text = "Agregar"
        '
        'AltaUsuarioToolStripMenuItem
        '
        Me.AltaUsuarioToolStripMenuItem.Name = "AltaUsuarioToolStripMenuItem"
        Me.AltaUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'AltaAnimalesToolStripMenuItem
        '
        Me.AltaAnimalesToolStripMenuItem.Name = "AltaAnimalesToolStripMenuItem"
        Me.AltaAnimalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaAnimalesToolStripMenuItem.Text = "Nuevo Animal"
        '
        'AltaClienToolStripMenuItem
        '
        Me.AltaClienToolStripMenuItem.Name = "AltaClienToolStripMenuItem"
        Me.AltaClienToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaClienToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoUsuariosToolStripMenuItem, Me.ListadoVerdurasToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 0)
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(98, 39)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ListadoUsuariosToolStripMenuItem
        '
        Me.ListadoUsuariosToolStripMenuItem.Name = "ListadoUsuariosToolStripMenuItem"
        Me.ListadoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ListadoUsuariosToolStripMenuItem.Text = "Lista Busqueda por Peso"
        '
        'ListadoVerdurasToolStripMenuItem
        '
        Me.ListadoVerdurasToolStripMenuItem.Name = "ListadoVerdurasToolStripMenuItem"
        Me.ListadoVerdurasToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ListadoVerdurasToolStripMenuItem.Text = "Lista Cantidad de Animales por dueño"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.AnimalToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.EspecieToolStripMenuItem1})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 0)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(98, 39)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'AnimalToolStripMenuItem
        '
        Me.AnimalToolStripMenuItem.Name = "AnimalToolStripMenuItem"
        Me.AnimalToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AnimalToolStripMenuItem.Text = "Animal"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'EspecieToolStripMenuItem1
        '
        Me.EspecieToolStripMenuItem1.Name = "EspecieToolStripMenuItem1"
        Me.EspecieToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.EspecieToolStripMenuItem1.Text = "Especie"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 0)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(98, 39)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblInfo2)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(385, 123)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 258)
        Me.Panel1.TabIndex = 3
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Location = New System.Drawing.Point(42, 136)
        Me.lblInfo2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(10, 13)
        Me.lblInfo2.TabIndex = 9
        Me.lblInfo2.Text = "."
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(42, 58)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(10, 13)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 168)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.MarqueeAnimationSpeed = 50
        Me.ProgressBar1.Maximum = 250
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(236, 19)
        Me.ProgressBar1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button1.Location = New System.Drawing.Point(128, 208)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(44, 116)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(185, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 38)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese Contraseña de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(40, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Nombre de Usuario"
        '
        'TimerCarga
        '
        '
        'NuevaEspecieToolStripMenuItem
        '
        Me.NuevaEspecieToolStripMenuItem.Name = "NuevaEspecieToolStripMenuItem"
        Me.NuevaEspecieToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevaEspecieToolStripMenuItem.Text = "Nueva Especie"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.TpIntegrador_Programacion.My.Resources.Resources.FondoProgama
        Me.ClientSize = New System.Drawing.Size(985, 509)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "VETERINARIA"
        Me.TransparencyKey = System.Drawing.Color.Yellow
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaAnimalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoVerdurasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerCarga As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents AltaClienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecieToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevaEspecieToolStripMenuItem As ToolStripMenuItem
End Class
