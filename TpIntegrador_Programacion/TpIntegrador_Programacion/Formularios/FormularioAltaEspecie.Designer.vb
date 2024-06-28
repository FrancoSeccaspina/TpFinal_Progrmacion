<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaEspecie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreEspecie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregarEspecie = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEdadMadurez = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPesoPromedio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar Especie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Especie"
        '
        'txtNombreEspecie
        '
        Me.txtNombreEspecie.Location = New System.Drawing.Point(115, 85)
        Me.txtNombreEspecie.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEspecie.Name = "txtNombreEspecie"
        Me.txtNombreEspecie.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreEspecie.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre"
        '
        'btnAgregarEspecie
        '
        Me.btnAgregarEspecie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAgregarEspecie.Location = New System.Drawing.Point(76, 266)
        Me.btnAgregarEspecie.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarEspecie.Name = "btnAgregarEspecie"
        Me.btnAgregarEspecie.Size = New System.Drawing.Size(196, 32)
        Me.btnAgregarEspecie.TabIndex = 20
        Me.btnAgregarEspecie.Text = "Agregar Especie"
        Me.btnAgregarEspecie.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Madurez"
        '
        'txtEdadMadurez
        '
        Me.txtEdadMadurez.Location = New System.Drawing.Point(115, 134)
        Me.txtEdadMadurez.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEdadMadurez.Name = "txtEdadMadurez"
        Me.txtEdadMadurez.Size = New System.Drawing.Size(200, 20)
        Me.txtEdadMadurez.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Edad de"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(27, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Promedio"
        '
        'txtPesoPromedio
        '
        Me.txtPesoPromedio.Location = New System.Drawing.Point(115, 199)
        Me.txtPesoPromedio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPesoPromedio.Name = "txtPesoPromedio"
        Me.txtPesoPromedio.Size = New System.Drawing.Size(200, 20)
        Me.txtPesoPromedio.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(26, 199)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Peso"
        '
        'FormularioAltaEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 333)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPesoPromedio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEdadMadurez)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAgregarEspecie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNombreEspecie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormularioAltaEspecie"
        Me.Text = "FormularioAltaEspecie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreEspecie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregarEspecie As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEdadMadurez As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPesoPromedio As TextBox
    Friend WithEvents Label7 As Label
End Class
