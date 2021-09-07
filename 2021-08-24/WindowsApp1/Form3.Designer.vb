<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SAPITO = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.SAPITO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LEER 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SAPITO
        '
        Me.SAPITO.AllowUserToAddRows = False
        Me.SAPITO.AllowUserToDeleteRows = False
        Me.SAPITO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SAPITO.Location = New System.Drawing.Point(24, 25)
        Me.SAPITO.Name = "SAPITO"
        Me.SAPITO.ReadOnly = True
        Me.SAPITO.Size = New System.Drawing.Size(670, 338)
        Me.SAPITO.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(271, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "LEER 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(500, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "PROBAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 456)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SAPITO)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.SAPITO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents SAPITO As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
