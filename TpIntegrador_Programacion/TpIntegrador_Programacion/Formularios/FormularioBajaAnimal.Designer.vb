<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioBajaAnimal
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
        Me.DataGridAnimales = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridAnimales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDarDeBaja
        '
        Me.BtnDarDeBaja.Location = New System.Drawing.Point(278, 287)
        Me.BtnDarDeBaja.Name = "BtnDarDeBaja"
        Me.BtnDarDeBaja.Size = New System.Drawing.Size(133, 73)
        Me.BtnDarDeBaja.TabIndex = 8
        Me.BtnDarDeBaja.Text = "Baja"
        Me.BtnDarDeBaja.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ingrese ID :"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(307, 245)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxId.TabIndex = 6
        '
        'DataGridAnimales
        '
        Me.DataGridAnimales.AllowUserToAddRows = False
        Me.DataGridAnimales.AllowUserToDeleteRows = False
        Me.DataGridAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAnimales.Location = New System.Drawing.Point(22, 12)
        Me.DataGridAnimales.Name = "DataGridAnimales"
        Me.DataGridAnimales.ReadOnly = True
        Me.DataGridAnimales.Size = New System.Drawing.Size(677, 183)
        Me.DataGridAnimales.TabIndex = 5
        '
        'FormularioBajaAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 373)
        Me.Controls.Add(Me.BtnDarDeBaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.DataGridAnimales)
        Me.Name = "FormularioBajaAnimal"
        Me.Text = "FormularioBajaAnimal"
        CType(Me.DataGridAnimales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDarDeBaja As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents DataGridAnimales As DataGridView
End Class
