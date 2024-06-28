<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAltaAnimales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreAnimal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEdadAnimal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPesoAnimal = New System.Windows.Forms.TextBox()
        Me.Btn_SeleccionarImagen = New System.Windows.Forms.Button()
        Me.Btn_AgregarAnimal = New System.Windows.Forms.Button()
        Me.CBAnimal = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EspecieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspecieBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecieBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(38, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al Alta de Animales "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Por favor ingrese la siguiente informacion solicitada"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 184)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(170, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre del animal"
        '
        'TxtNombreAnimal
        '
        Me.TxtNombreAnimal.Location = New System.Drawing.Point(142, 80)
        Me.TxtNombreAnimal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreAnimal.Name = "TxtNombreAnimal"
        Me.TxtNombreAnimal.Size = New System.Drawing.Size(196, 20)
        Me.TxtNombreAnimal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(170, 120)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Edad del animal"
        '
        'TxtEdadAnimal
        '
        Me.TxtEdadAnimal.Location = New System.Drawing.Point(142, 143)
        Me.TxtEdadAnimal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEdadAnimal.Name = "TxtEdadAnimal"
        Me.TxtEdadAnimal.Size = New System.Drawing.Size(196, 20)
        Me.TxtEdadAnimal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(195, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Peso animal"
        '
        'TxtPesoAnimal
        '
        Me.TxtPesoAnimal.Location = New System.Drawing.Point(142, 203)
        Me.TxtPesoAnimal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPesoAnimal.Name = "TxtPesoAnimal"
        Me.TxtPesoAnimal.Size = New System.Drawing.Size(196, 20)
        Me.TxtPesoAnimal.TabIndex = 8
        '
        'Btn_SeleccionarImagen
        '
        Me.Btn_SeleccionarImagen.Location = New System.Drawing.Point(12, 248)
        Me.Btn_SeleccionarImagen.Name = "Btn_SeleccionarImagen"
        Me.Btn_SeleccionarImagen.Size = New System.Drawing.Size(125, 45)
        Me.Btn_SeleccionarImagen.TabIndex = 9
        Me.Btn_SeleccionarImagen.Text = "Adjuntar Imagen"
        Me.Btn_SeleccionarImagen.UseVisualStyleBackColor = True
        '
        'Btn_AgregarAnimal
        '
        Me.Btn_AgregarAnimal.Location = New System.Drawing.Point(12, 299)
        Me.Btn_AgregarAnimal.Name = "Btn_AgregarAnimal"
        Me.Btn_AgregarAnimal.Size = New System.Drawing.Size(326, 62)
        Me.Btn_AgregarAnimal.TabIndex = 10
        Me.Btn_AgregarAnimal.Text = "Agregar Animal"
        Me.Btn_AgregarAnimal.UseVisualStyleBackColor = True
        '
        'CBAnimal
        '
        Me.CBAnimal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EspecieBindingSource, "Nombre", True))
        Me.CBAnimal.FormattingEnabled = True
        Me.CBAnimal.Location = New System.Drawing.Point(153, 265)
        Me.CBAnimal.Name = "CBAnimal"
        Me.CBAnimal.Size = New System.Drawing.Size(181, 21)
        Me.CBAnimal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(219, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo"
        '
        'EspecieBindingSource
        '
        Me.EspecieBindingSource.DataSource = GetType(ServiciosVet.Models.Especie)
        '
        'EspecieBindingSource1
        '
        Me.EspecieBindingSource1.DataSource = GetType(ServiciosVet.Models.Especie)
        '
        'FormularioAltaAnimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 385)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBAnimal)
        Me.Controls.Add(Me.Btn_AgregarAnimal)
        Me.Controls.Add(Me.Btn_SeleccionarImagen)
        Me.Controls.Add(Me.TxtPesoAnimal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtEdadAnimal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNombreAnimal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormularioAltaAnimales"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecieBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreAnimal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEdadAnimal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPesoAnimal As TextBox
    Friend WithEvents Btn_SeleccionarImagen As Button
    Friend WithEvents Btn_AgregarAnimal As Button
    Friend WithEvents CBAnimal As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EspecieBindingSource As BindingSource
    Friend WithEvents EspecieBindingSource1 As BindingSource
End Class
