<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogIn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnacceder = New System.Windows.Forms.Button()
        Me.lbliniciar = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnacceder
        '
        Me.btnacceder.Location = New System.Drawing.Point(94, 191)
        Me.btnacceder.Name = "btnacceder"
        Me.btnacceder.Size = New System.Drawing.Size(94, 23)
        Me.btnacceder.TabIndex = 3
        Me.btnacceder.Text = "Iniciar sesion"
        Me.btnacceder.UseVisualStyleBackColor = True
        '
        'lbliniciar
        '
        Me.lbliniciar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliniciar.ForeColor = System.Drawing.Color.Black
        Me.lbliniciar.Location = New System.Drawing.Point(48, 107)
        Me.lbliniciar.Name = "lbliniciar"
        Me.lbliniciar.Size = New System.Drawing.Size(211, 35)
        Me.lbliniciar.TabIndex = 1
        Me.lbliniciar.Text = "Inicia sesión con el DNI"
        Me.lbliniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(52, 154)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbllogin
        '
        Me.lbllogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.Location = New System.Drawing.Point(87, 54)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(118, 41)
        Me.lbllogin.TabIndex = 0
        Me.lbllogin.Text = "LOG IN"
        Me.lbllogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbllogin)
        Me.Panel1.Controls.Add(Me.btnacceder)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lbliniciar)
        Me.Panel1.Location = New System.Drawing.Point(256, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 273)
        Me.Panel1.TabIndex = 4
        '
        'FrmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 426)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmLogIn"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnacceder As Button
    Friend WithEvents lbliniciar As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbllogin As Label
    Friend WithEvents Panel1 As Panel
End Class
