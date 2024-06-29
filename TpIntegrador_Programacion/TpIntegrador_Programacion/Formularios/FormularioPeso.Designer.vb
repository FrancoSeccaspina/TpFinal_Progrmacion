<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPeso
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
        Me.DG_Peso = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBAnimal = New System.Windows.Forms.ComboBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.DG_Peso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_Peso
        '
        Me.DG_Peso.AllowUserToAddRows = False
        Me.DG_Peso.AllowUserToDeleteRows = False
        Me.DG_Peso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Peso.Location = New System.Drawing.Point(61, 188)
        Me.DG_Peso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DG_Peso.Name = "DG_Peso"
        Me.DG_Peso.ReadOnly = True
        Me.DG_Peso.RowHeadersWidth = 51
        Me.DG_Peso.RowTemplate.Height = 24
        Me.DG_Peso.Size = New System.Drawing.Size(537, 305)
        Me.DG_Peso.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(112, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista Busqueda por Peso:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(78, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tipo"
        '
        'CBAnimal
        '
        Me.CBAnimal.FormattingEnabled = True
        Me.CBAnimal.Location = New System.Drawing.Point(12, 107)
        Me.CBAnimal.Name = "CBAnimal"
        Me.CBAnimal.Size = New System.Drawing.Size(181, 21)
        Me.CBAnimal.TabIndex = 13
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(258, 94)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(100, 20)
        Me.txtMin.TabIndex = 15
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(417, 94)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(100, 20)
        Me.txtMax.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(283, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(442, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Max"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(349, 142)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 19
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'FormularioPeso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 581)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBAnimal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_Peso)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormularioPeso"
        Me.Text = "FormularioListadoUsuarios"
        CType(Me.DG_Peso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_Peso As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBAnimal As ComboBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcular As Button
End Class
