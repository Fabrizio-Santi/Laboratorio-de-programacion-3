<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.btnPuntitos1 = New System.Windows.Forms.Button()
        Me.btnPuntitos2 = New System.Windows.Forms.Button()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen"
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(81, 84)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.ReadOnly = True
        Me.txtOrigen.Size = New System.Drawing.Size(598, 20)
        Me.txtOrigen.TabIndex = 1
        '
        'btnPuntitos1
        '
        Me.btnPuntitos1.Location = New System.Drawing.Point(702, 84)
        Me.btnPuntitos1.Name = "btnPuntitos1"
        Me.btnPuntitos1.Size = New System.Drawing.Size(75, 23)
        Me.btnPuntitos1.TabIndex = 2
        Me.btnPuntitos1.Text = "..."
        Me.btnPuntitos1.UseVisualStyleBackColor = True
        '
        'btnPuntitos2
        '
        Me.btnPuntitos2.Location = New System.Drawing.Point(702, 159)
        Me.btnPuntitos2.Name = "btnPuntitos2"
        Me.btnPuntitos2.Size = New System.Drawing.Size(75, 23)
        Me.btnPuntitos2.TabIndex = 5
        Me.btnPuntitos2.Text = "..."
        Me.btnPuntitos2.UseVisualStyleBackColor = True
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(81, 159)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(598, 20)
        Me.txtDestino.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Destino"
        '
        'btnCopiar
        '
        Me.btnCopiar.Location = New System.Drawing.Point(373, 211)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(306, 66)
        Me.btnCopiar.TabIndex = 6
        Me.btnCopiar.Tag = ""
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'FBD
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 318)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.btnPuntitos2)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPuntitos1)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents btnPuntitos1 As Button
    Friend WithEvents btnPuntitos2 As Button
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCopiar As Button
    Friend WithEvents FBD As FolderBrowserDialog
End Class
