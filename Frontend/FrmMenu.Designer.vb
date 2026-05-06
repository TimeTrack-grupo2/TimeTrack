<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.btnFichar = New System.Windows.Forms.Button()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnVolver)
        Me.Panel1.Controls.Add(Me.btnTareas)
        Me.Panel1.Controls.Add(Me.btnFichar)
        Me.Panel1.Controls.Add(Me.btnDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 568)
        Me.Panel1.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Black
        Me.btnVolver.Location = New System.Drawing.Point(0, 518)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(200, 50)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnTareas
        '
        Me.btnTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.ForeColor = System.Drawing.Color.Black
        Me.btnTareas.Location = New System.Drawing.Point(0, 100)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(200, 50)
        Me.btnTareas.TabIndex = 2
        Me.btnTareas.Text = "Tareas"
        Me.btnTareas.UseVisualStyleBackColor = True
        '
        'btnFichar
        '
        Me.btnFichar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFichar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnFichar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnFichar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFichar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichar.ForeColor = System.Drawing.Color.Black
        Me.btnFichar.Location = New System.Drawing.Point(0, 50)
        Me.btnFichar.Name = "btnFichar"
        Me.btnFichar.Size = New System.Drawing.Size(200, 50)
        Me.btnFichar.TabIndex = 1
        Me.btnFichar.Text = "Fichar"
        Me.btnFichar.UseVisualStyleBackColor = True
        '
        'btnDatos
        '
        Me.btnDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatos.ForeColor = System.Drawing.Color.Black
        Me.btnDatos.Location = New System.Drawing.Point(0, 0)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(200, 50)
        Me.btnDatos.TabIndex = 0
        Me.btnDatos.Text = "Base de Datos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 568)
        Me.Panel2.TabIndex = 1
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 568)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMenu"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnTareas As Button
    Friend WithEvents btnFichar As Button
    Friend WithEvents btnDatos As Button
    Friend WithEvents Panel2 As Panel
End Class
