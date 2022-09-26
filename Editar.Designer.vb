<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar
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
        Me.txtNombreEdit = New System.Windows.Forms.TextBox()
        Me.txtApellidoEdit = New System.Windows.Forms.TextBox()
        Me.txtEdadEdit = New System.Windows.Forms.TextBox()
        Me.txtDniEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreEdit
        '
        Me.txtNombreEdit.Location = New System.Drawing.Point(264, 54)
        Me.txtNombreEdit.Name = "txtNombreEdit"
        Me.txtNombreEdit.Size = New System.Drawing.Size(274, 20)
        Me.txtNombreEdit.TabIndex = 0
        '
        'txtApellidoEdit
        '
        Me.txtApellidoEdit.Location = New System.Drawing.Point(264, 105)
        Me.txtApellidoEdit.Name = "txtApellidoEdit"
        Me.txtApellidoEdit.Size = New System.Drawing.Size(274, 20)
        Me.txtApellidoEdit.TabIndex = 1
        '
        'txtEdadEdit
        '
        Me.txtEdadEdit.Location = New System.Drawing.Point(264, 154)
        Me.txtEdadEdit.Name = "txtEdadEdit"
        Me.txtEdadEdit.Size = New System.Drawing.Size(274, 20)
        Me.txtEdadEdit.TabIndex = 2
        '
        'txtDniEdit
        '
        Me.txtDniEdit.Location = New System.Drawing.Point(264, 196)
        Me.txtDniEdit.Name = "txtDniEdit"
        Me.txtDniEdit.Size = New System.Drawing.Size(274, 20)
        Me.txtDniEdit.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DNI"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(264, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(274, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Actualizar usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDniEdit)
        Me.Controls.Add(Me.txtEdadEdit)
        Me.Controls.Add(Me.txtApellidoEdit)
        Me.Controls.Add(Me.txtNombreEdit)
        Me.Name = "Editar"
        Me.Text = "Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtNombreEdit As TextBox
    Public WithEvents txtApellidoEdit As TextBox
    Public WithEvents txtEdadEdit As TextBox
    Public WithEvents txtDniEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
