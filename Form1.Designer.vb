<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Numero1 = New System.Windows.Forms.Label()
        Me.Numero2 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Numero1
        '
        Me.Numero1.AutoSize = True
        Me.Numero1.Location = New System.Drawing.Point(127, 53)
        Me.Numero1.Name = "Numero1"
        Me.Numero1.Size = New System.Drawing.Size(68, 16)
        Me.Numero1.TabIndex = 0
        Me.Numero1.Text = "Numero 1:"
        '
        'Numero2
        '
        Me.Numero2.AutoSize = True
        Me.Numero2.Location = New System.Drawing.Point(127, 86)
        Me.Numero2.Name = "Numero2"
        Me.Numero2.Size = New System.Drawing.Size(65, 16)
        Me.Numero2.TabIndex = 1
        Me.Numero2.Text = "Numero2:"
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Location = New System.Drawing.Point(123, 119)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(72, 16)
        Me.Resultado.TabIndex = 2
        Me.Resultado.Text = "Resultado:"
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(201, 50)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(108, 22)
        Me.txtNumero1.TabIndex = 3
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(201, 86)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(108, 22)
        Me.txtNumero2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Numero2)
        Me.Controls.Add(Me.Numero1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Numero1 As Label
    Friend WithEvents Numero2 As Label
    Friend WithEvents Resultado As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
End Class
