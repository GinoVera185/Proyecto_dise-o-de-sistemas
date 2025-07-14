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
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Numero1
        '
        Me.Numero1.AutoSize = True
        Me.Numero1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero1.Location = New System.Drawing.Point(224, 80)
        Me.Numero1.Name = "Numero1"
        Me.Numero1.Size = New System.Drawing.Size(175, 42)
        Me.Numero1.TabIndex = 0
        Me.Numero1.Text = "Numero1:"
        '
        'Numero2
        '
        Me.Numero2.AutoSize = True
        Me.Numero2.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero2.Location = New System.Drawing.Point(224, 134)
        Me.Numero2.Name = "Numero2"
        Me.Numero2.Size = New System.Drawing.Size(175, 42)
        Me.Numero2.TabIndex = 1
        Me.Numero2.Text = "Numero2:"
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(224, 302)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(188, 42)
        Me.Resultado.TabIndex = 2
        Me.Resultado.Text = "Resultado:"
        '
        'txtNumero1
        '
        Me.txtNumero1.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero1.Location = New System.Drawing.Point(414, 77)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(85, 45)
        Me.txtNumero1.TabIndex = 3
        '
        'txtNumero2
        '
        Me.txtNumero2.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero2.Location = New System.Drawing.Point(414, 134)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(85, 45)
        Me.txtNumero2.TabIndex = 4
        '
        'btnSumar
        '
        Me.btnSumar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumar.Location = New System.Drawing.Point(231, 201)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(121, 46)
        Me.btnSumar.TabIndex = 5
        Me.btnSumar.Text = "Suma (+)"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.Location = New System.Drawing.Point(358, 201)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(122, 46)
        Me.btnRestar.TabIndex = 6
        Me.btnRestar.Text = "Resta (-)"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(231, 253)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(175, 46)
        Me.btnMultiplicar.TabIndex = 7
        Me.btnMultiplicar.Text = "Multiplicar (*)"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(418, 314)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(118, 27)
        Me.lblResultado.TabIndex = 8
        Me.lblResultado.Text = "resultado"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(414, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "División (/)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSumar)
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
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents Button1 As Button
End Class
