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
        Me.TimerFecha = New System.Windows.Forms.Timer(Me.components)
        Me.lvlFecha1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewMovimientos = New System.Windows.Forms.DataGridView()
        Me.Dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasJornada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.DataGridViewMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblFecha.Location = New System.Drawing.Point(307, 34)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 16)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'TimerFecha
        '
        Me.TimerFecha.Interval = 1000
        '
        'lvlFecha1
        '
        Me.lvlFecha1.AutoSize = True
        Me.lvlFecha1.Location = New System.Drawing.Point(253, 34)
        Me.lvlFecha1.Name = "lvlFecha1"
        Me.lvlFecha1.Size = New System.Drawing.Size(48, 16)
        Me.lvlFecha1.TabIndex = 3
        Me.lvlFecha1.Text = "Fecha:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(86, 100)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(116, 22)
        Me.txtDNI.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(86, 132)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 22)
        Me.txtNombre.TabIndex = 6
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(21, 103)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(33, 16)
        Me.lblDNI.TabIndex = 7
        Me.lblDNI.Text = "DNI:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(21, 135)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 16)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(21, 167)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(45, 16)
        Me.lblCurso.TabIndex = 9
        Me.lblCurso.Text = "Curso:"
        '
        'btnEntrada
        '
        Me.btnEntrada.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEntrada.FlatAppearance.BorderSize = 4
        Me.btnEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEntrada.Location = New System.Drawing.Point(402, 135)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(89, 34)
        Me.btnEntrada.TabIndex = 13
        Me.btnEntrada.Text = "Fichar"
        Me.btnEntrada.UseVisualStyleBackColor = False
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
        'DataGridViewMovimientos
        '
        Me.DataGridViewMovimientos.AllowUserToAddRows = False
        Me.DataGridViewMovimientos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Dia, Me.Hora, Me.HorasJornada})
        Me.DataGridViewMovimientos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewMovimientos.Location = New System.Drawing.Point(0, 341)
        Me.DataGridViewMovimientos.Name = "DataGridViewMovimientos"
        Me.DataGridViewMovimientos.RowHeadersVisible = False
        Me.DataGridViewMovimientos.RowHeadersWidth = 51
        Me.DataGridViewMovimientos.RowTemplate.Height = 24
        Me.DataGridViewMovimientos.Size = New System.Drawing.Size(658, 150)
        Me.DataGridViewMovimientos.TabIndex = 18
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
        'HorasJornada
        '
        Me.HorasJornada.HeaderText = "Horas de jornada"
        Me.HorasJornada.MinimumWidth = 6
        Me.HorasJornada.Name = "HorasJornada"
        Me.HorasJornada.ReadOnly = True
        Me.HorasJornada.Width = 125
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(140, 204)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(125, 22)
        Me.txtHoras.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Horas realizadas:"
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(86, 164)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(100, 22)
        Me.txtCurso.TabIndex = 21
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(564, 307)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(82, 28)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FrmFichar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 491)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.DataGridViewMovimientos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lvlFecha1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Name = "FrmFichar"
        Me.Text = "Fichajes"
        CType(Me.DataGridViewMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents TimerFecha As Timer
    Friend WithEvents lvlFecha1 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCurso As Label
    Friend WithEvents btnEntrada As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewMovimientos As DataGridView
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Dia As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents HorasJornada As DataGridViewTextBoxColumn
End Class
