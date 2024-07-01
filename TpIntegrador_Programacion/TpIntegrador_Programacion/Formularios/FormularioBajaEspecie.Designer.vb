<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioBajaEspecie
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
        Me.BtnDarDeBaja = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.DataGridEspecies = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridEspecies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDarDeBaja
        '
        Me.BtnDarDeBaja.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDarDeBaja.Location = New System.Drawing.Point(264, 337)
        Me.BtnDarDeBaja.Name = "BtnDarDeBaja"
        Me.BtnDarDeBaja.Size = New System.Drawing.Size(133, 73)
        Me.BtnDarDeBaja.TabIndex = 8
        Me.BtnDarDeBaja.Text = "Baja"
        Me.BtnDarDeBaja.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ingrese DNI :"
        '
        'TextBoxId
        '
        Me.TextBoxId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxId.Location = New System.Drawing.Point(293, 295)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxId.TabIndex = 6
        '
        'DataGridEspecies
        '
        Me.DataGridEspecies.AllowUserToAddRows = False
        Me.DataGridEspecies.AllowUserToDeleteRows = False
        Me.DataGridEspecies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEspecies.Location = New System.Drawing.Point(12, 12)
        Me.DataGridEspecies.Name = "DataGridEspecies"
        Me.DataGridEspecies.ReadOnly = True
        Me.DataGridEspecies.Size = New System.Drawing.Size(659, 236)
        Me.DataGridEspecies.TabIndex = 5
        '
        'FormularioBajaEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 450)
        Me.Controls.Add(Me.BtnDarDeBaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.DataGridEspecies)
        Me.Name = "FormularioBajaEspecie"
        Me.Text = "FormularioBajaEspecie"
        CType(Me.DataGridEspecies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDarDeBaja As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents DataGridEspecies As DataGridView
End Class
