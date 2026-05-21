<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCiclos
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
        Me.DataGridViewCiclos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cboCiclo = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblCiclos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboModulo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewCiclos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewCiclos
        '
        Me.DataGridViewCiclos.AllowUserToAddRows = False
        Me.DataGridViewCiclos.AllowUserToDeleteRows = False
        Me.DataGridViewCiclos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCiclos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewCiclos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewCiclos.ColumnHeadersHeight = 29
        Me.DataGridViewCiclos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewCiclos.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewCiclos.Location = New System.Drawing.Point(217, 0)
        Me.DataGridViewCiclos.Name = "DataGridViewCiclos"
        Me.DataGridViewCiclos.ReadOnly = True
        Me.DataGridViewCiclos.RowHeadersVisible = False
        Me.DataGridViewCiclos.RowHeadersWidth = 51
        Me.DataGridViewCiclos.RowTemplate.Height = 24
        Me.DataGridViewCiclos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCiclos.Size = New System.Drawing.Size(583, 450)
        Me.DataGridViewCiclos.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.cboModulo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.cboCiclo)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lblCiclos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 450)
        Me.Panel1.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(64, 362)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 30)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'cboCiclo
        '
        Me.cboCiclo.FormattingEnabled = True
        Me.cboCiclo.Location = New System.Drawing.Point(45, 143)
        Me.cboCiclo.Name = "cboCiclo"
        Me.cboCiclo.Size = New System.Drawing.Size(121, 24)
        Me.cboCiclo.TabIndex = 17
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(112, 398)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 30)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(17, 398)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblCiclos
        '
        Me.lblCiclos.AutoSize = True
        Me.lblCiclos.Location = New System.Drawing.Point(42, 124)
        Me.lblCiclos.Name = "lblCiclos"
        Me.lblCiclos.Size = New System.Drawing.Size(40, 16)
        Me.lblCiclos.TabIndex = 2
        Me.lblCiclos.Text = "Ciclo:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestión de ciclos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboModulo
        '
        Me.cboModulo.FormattingEnabled = True
        Me.cboModulo.Location = New System.Drawing.Point(45, 203)
        Me.cboModulo.Name = "cboModulo"
        Me.cboModulo.Size = New System.Drawing.Size(121, 24)
        Me.cboModulo.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Módulo:"
        '
        'FrmCiclos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewCiclos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCiclos"
        Me.Text = "FrmCiclos"
        CType(Me.DataGridViewCiclos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewCiclos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblCiclos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCiclo As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cboModulo As ComboBox
    Friend WithEvents Label2 As Label
End Class
