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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCiclos = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnFichar = New System.Windows.Forms.Button()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.lblTitHoras = New System.Windows.Forms.Label()
        Me.lblTitDias = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DataGridViewJornadas = New System.Windows.Forms.DataGridView()
        Me.ID_JORNADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasRestantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerTareas = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TimerRecargarJornadas = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewJornadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnCiclos)
        Me.Panel1.Controls.Add(Me.btnVolver)
        Me.Panel1.Controls.Add(Me.btnFichar)
        Me.Panel1.Controls.Add(Me.btnDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 568)
        Me.Panel1.TabIndex = 0
        '
        'btnCiclos
        '
        Me.btnCiclos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCiclos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCiclos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnCiclos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCiclos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiclos.ForeColor = System.Drawing.Color.Black
        Me.btnCiclos.Location = New System.Drawing.Point(0, 100)
        Me.btnCiclos.Name = "btnCiclos"
        Me.btnCiclos.Size = New System.Drawing.Size(200, 50)
        Me.btnCiclos.TabIndex = 4
        Me.btnCiclos.Text = "Ciclos"
        Me.btnCiclos.UseVisualStyleBackColor = True
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
        Me.btnDatos.Text = "Alumnos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.lblNombre)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtBuscarNombre)
        Me.Panel2.Controls.Add(Me.lblHoras)
        Me.Panel2.Controls.Add(Me.lblDias)
        Me.Panel2.Controls.Add(Me.lblTitHoras)
        Me.Panel2.Controls.Add(Me.lblTitDias)
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Controls.Add(Me.DataGridViewJornadas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(932, 568)
        Me.Panel2.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(17, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 16)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Bueno Dias,"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar alumno"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Location = New System.Drawing.Point(3, 147)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(156, 22)
        Me.txtBuscarNombre.TabIndex = 6
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(678, 89)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(48, 16)
        Me.lblHoras.TabIndex = 5
        Me.lblHoras.Text = "Label2"
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(191, 89)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(48, 16)
        Me.lblDias.TabIndex = 4
        Me.lblDias.Text = "Label1"
        '
        'lblTitHoras
        '
        Me.lblTitHoras.AutoSize = True
        Me.lblTitHoras.Location = New System.Drawing.Point(639, 50)
        Me.lblTitHoras.Name = "lblTitHoras"
        Me.lblTitHoras.Size = New System.Drawing.Size(87, 16)
        Me.lblTitHoras.TabIndex = 2
        Me.lblTitHoras.Text = "Horas totales"
        '
        'lblTitDias
        '
        Me.lblTitDias.AutoSize = True
        Me.lblTitDias.Location = New System.Drawing.Point(160, 50)
        Me.lblTitDias.Name = "lblTitDias"
        Me.lblTitDias.Size = New System.Drawing.Size(109, 16)
        Me.lblTitDias.TabIndex = 1
        Me.lblTitDias.Text = "Dias Trabajados"
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(325, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(240, 40)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Jornadas Trabajadas"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewJornadas
        '
        Me.DataGridViewJornadas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewJornadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJornadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_JORNADA, Me.DNI, Me.NombreAlumno, Me.HoraEntrada, Me.HorasRestantes, Me.Estado, Me.VerTareas})
        Me.DataGridViewJornadas.Location = New System.Drawing.Point(0, 175)
        Me.DataGridViewJornadas.Name = "DataGridViewJornadas"
        Me.DataGridViewJornadas.RowHeadersVisible = False
        Me.DataGridViewJornadas.RowHeadersWidth = 51
        Me.DataGridViewJornadas.RowTemplate.Height = 24
        Me.DataGridViewJornadas.Size = New System.Drawing.Size(920, 390)
        Me.DataGridViewJornadas.TabIndex = 0
        '
        'ID_JORNADA
        '
        Me.ID_JORNADA.HeaderText = "Id"
        Me.ID_JORNADA.MinimumWidth = 6
        Me.ID_JORNADA.Name = "ID_JORNADA"
        Me.ID_JORNADA.ReadOnly = True
        Me.ID_JORNADA.Visible = False
        Me.ID_JORNADA.Width = 125
        '
        'DNI
        '
        Me.DNI.HeaderText = "Dni"
        Me.DNI.MinimumWidth = 6
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        Me.DNI.Visible = False
        Me.DNI.Width = 125
        '
        'NombreAlumno
        '
        Me.NombreAlumno.HeaderText = "Alumno"
        Me.NombreAlumno.MinimumWidth = 6
        Me.NombreAlumno.Name = "NombreAlumno"
        Me.NombreAlumno.ReadOnly = True
        Me.NombreAlumno.Width = 125
        '
        'HoraEntrada
        '
        Me.HoraEntrada.HeaderText = "Hora entrada"
        Me.HoraEntrada.MinimumWidth = 6
        Me.HoraEntrada.Name = "HoraEntrada"
        Me.HoraEntrada.ReadOnly = True
        Me.HoraEntrada.Width = 125
        '
        'HorasRestantes
        '
        Me.HorasRestantes.HeaderText = "Horas restantes"
        Me.HorasRestantes.MinimumWidth = 6
        Me.HorasRestantes.Name = "HorasRestantes"
        Me.HorasRestantes.ReadOnly = True
        Me.HorasRestantes.Width = 125
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 125
        '
        'VerTareas
        '
        Me.VerTareas.HeaderText = "Tareas"
        Me.VerTareas.MinimumWidth = 6
        Me.VerTareas.Name = "VerTareas"
        Me.VerTareas.ReadOnly = True
        Me.VerTareas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VerTareas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VerTareas.Text = "Ver/Añadir"
        Me.VerTareas.UseColumnTextForButtonValue = True
        Me.VerTareas.Width = 125
        '
        'TimerRecargarJornadas
        '
        Me.TimerRecargarJornadas.Enabled = True
        Me.TimerRecargarJornadas.Interval = 5000
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 568)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMenu"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewJornadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnFichar As Button
    Friend WithEvents btnDatos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTitHoras As Label
    Friend WithEvents lblTitDias As Label
    Friend WithEvents lblHoras As Label
    Friend WithEvents lblDias As Label
    Friend WithEvents DataGridViewJornadas As DataGridView
    Friend WithEvents TimerRecargarJornadas As Timer
    Friend WithEvents ID_JORNADA As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents NombreAlumno As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntrada As DataGridViewTextBoxColumn
    Friend WithEvents HorasRestantes As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents VerTareas As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnCiclos As Button
End Class
