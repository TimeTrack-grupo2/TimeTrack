<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFichar
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lvlFecha1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.cmbGrupo = New System.Windows.Forms.ComboBox()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(658, 34)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "SISTEMA DE FICHAJES"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(308, 34)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 16)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'Timer1
        '
        '
        'lvlFecha1
        '
        Me.lvlFecha1.AutoSize = True
        Me.lvlFecha1.Location = New System.Drawing.Point(257, 34)
        Me.lvlFecha1.Name = "lvlFecha1"
        Me.lvlFecha1.Size = New System.Drawing.Size(48, 16)
        Me.lvlFecha1.TabIndex = 3
        Me.lvlFecha1.Text = "Fecha:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(91, 88)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 22)
        Me.txtDNI.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 120)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(148, 22)
        Me.txtNombre.TabIndex = 6
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(34, 91)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(33, 16)
        Me.lblDNI.TabIndex = 7
        Me.lblDNI.Text = "DNI:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(34, 123)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 16)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(34, 155)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(45, 16)
        Me.lblCurso.TabIndex = 9
        Me.lblCurso.Text = "Curso:"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(34, 185)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(47, 16)
        Me.lblGrupo.TabIndex = 10
        Me.lblGrupo.Text = "Grupo:"
        '
        'cmbCurso
        '
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(91, 152)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(70, 24)
        Me.cmbCurso.TabIndex = 11
        '
        'cmbGrupo
        '
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(91, 182)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(46, 24)
        Me.cmbGrupo.TabIndex = 12
        '
        'btnEntrada
        '
        Me.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEntrada.FlatAppearance.BorderSize = 4
        Me.btnEntrada.Location = New System.Drawing.Point(238, 200)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(89, 34)
        Me.btnEntrada.TabIndex = 13
        Me.btnEntrada.Text = "Entrada"
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnSalida
        '
        Me.btnSalida.Location = New System.Drawing.Point(344, 200)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(89, 34)
        Me.btnSalida.TabIndex = 14
        Me.btnSalida.Text = "Salida"
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(293, 240)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 34)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Registro de Movimientos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dia, Me.Hora})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(658, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'Dia
        '
        Me.Dia.HeaderText = "Dia"
        Me.Dia.MinimumWidth = 6
        Me.Dia.Name = "Dia"
        Me.Dia.Width = 125
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.MinimumWidth = 6
        Me.Hora.Name = "Hora"
        Me.Hora.Width = 125
        '
        'FrmFichar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 491)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.cmbCurso)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lvlFecha1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "FrmFichar"
        Me.Text = "FrmFichar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lvlFecha1 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCurso As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents cmbCurso As ComboBox
    Friend WithEvents cmbGrupo As ComboBox
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnSalida As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Dia As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
End Class
