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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GRILLA = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LEER ARCHIVO DE TEXTO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GRILLA
        '
        Me.GRILLA.AllowUserToAddRows = False
        Me.GRILLA.AllowUserToDeleteRows = False
        Me.GRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRILLA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NOMBRE, Me.SEXO, Me.MARCA})
        Me.GRILLA.Location = New System.Drawing.Point(31, 32)
        Me.GRILLA.Name = "GRILLA"
        Me.GRILLA.ReadOnly = True
        Me.GRILLA.Size = New System.Drawing.Size(671, 316)
        Me.GRILLA.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 200
        '
        'SEXO
        '
        Me.SEXO.HeaderText = "SEXO"
        Me.SEXO.Name = "SEXO"
        Me.SEXO.ReadOnly = True
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        Me.MARCA.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 459)
        Me.Controls.Add(Me.GRILLA)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GRILLA As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents SEXO As DataGridViewTextBoxColumn
    Friend WithEvents MARCA As DataGridViewTextBoxColumn
End Class
