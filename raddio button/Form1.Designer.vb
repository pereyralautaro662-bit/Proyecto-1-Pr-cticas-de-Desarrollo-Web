<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.monto = New System.Windows.Forms.TextBox()
        Me.descuento = New System.Windows.Forms.TextBox()
        Me.montofinal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jubilado = New System.Windows.Forms.RadioButton()
        Me.empleado = New System.Windows.Forms.RadioButton()
        Me.monotributista = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'monto
        '
        Me.monto.Location = New System.Drawing.Point(92, 25)
        Me.monto.Name = "monto"
        Me.monto.Size = New System.Drawing.Size(100, 20)
        Me.monto.TabIndex = 0
        '
        'descuento
        '
        Me.descuento.Location = New System.Drawing.Point(92, 190)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(100, 20)
        Me.descuento.TabIndex = 1
        '
        'montofinal
        '
        Me.montofinal.Location = New System.Drawing.Point(92, 229)
        Me.montofinal.Name = "montofinal"
        Me.montofinal.Size = New System.Drawing.Size(100, 20)
        Me.montofinal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ingrese monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "monto final"
        '
        'jubilado
        '
        Me.jubilado.AutoSize = True
        Me.jubilado.Location = New System.Drawing.Point(92, 51)
        Me.jubilado.Name = "jubilado"
        Me.jubilado.Size = New System.Drawing.Size(61, 17)
        Me.jubilado.TabIndex = 6
        Me.jubilado.TabStop = True
        Me.jubilado.Text = "jubilado"
        Me.jubilado.UseVisualStyleBackColor = True
        '
        'empleado
        '
        Me.empleado.AutoSize = True
        Me.empleado.Location = New System.Drawing.Point(92, 74)
        Me.empleado.Name = "empleado"
        Me.empleado.Size = New System.Drawing.Size(71, 17)
        Me.empleado.TabIndex = 7
        Me.empleado.TabStop = True
        Me.empleado.Text = "empleado"
        Me.empleado.UseVisualStyleBackColor = True
        '
        'monotributista
        '
        Me.monotributista.AutoSize = True
        Me.monotributista.Location = New System.Drawing.Point(86, 97)
        Me.monotributista.Name = "monotributista"
        Me.monotributista.Size = New System.Drawing.Size(90, 17)
        Me.monotributista.TabIndex = 8
        Me.monotributista.TabStop = True
        Me.monotributista.Text = "monotributista"
        Me.monotributista.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.monotributista)
        Me.Controls.Add(Me.empleado)
        Me.Controls.Add(Me.jubilado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.montofinal)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.monto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents monto As System.Windows.Forms.TextBox
    Friend WithEvents descuento As System.Windows.Forms.TextBox
    Friend WithEvents montofinal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jubilado As System.Windows.Forms.RadioButton
    Friend WithEvents empleado As System.Windows.Forms.RadioButton
    Friend WithEvents monotributista As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
