<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaCliente
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
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAgregarCliente.Location = New System.Drawing.Point(82, 250)
        Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(196, 32)
        Me.btnAgregarCliente.TabIndex = 22
        Me.btnAgregarCliente.Text = "Agregar Usuario"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(57, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Por favor ingrese los siguientes datos"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(124, 76)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(200, 20)
        Me.txtDNI.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(124, 128)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(40, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Dni"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(39, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Bienvenido al alta de Cliente"
        '
        'FormularioAltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 350)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioAltaCliente"
        Me.Text = "FormularioAltaCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
