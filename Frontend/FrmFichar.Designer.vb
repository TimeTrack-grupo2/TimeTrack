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
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Timer1
        '
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
        Me.txtDNI.Location = New System.Drawing.Point(78, 100)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(116, 22)
        Me.txtDNI.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(78, 132)
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
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 201)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 22)
        Me.TextBox1.TabIndex = 19
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 21
        '
        'FrmFichar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 491)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
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
    Friend WithEvents btnEntrada As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Dia As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
