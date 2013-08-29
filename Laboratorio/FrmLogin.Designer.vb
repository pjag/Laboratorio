<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.fraLogin = New System.Windows.Forms.GroupBox()
        Me.cmbCodigoEmpresa = New System.Windows.Forms.ComboBox()
        Me.HGEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SEGURIDADDataSet = New Laboratorio.SEGURIDADDataSet()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtDepto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.HGUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HG_USUARIOSTableAdapter = New Laboratorio.SEGURIDADDataSetTableAdapters.HG_USUARIOSTableAdapter()
        Me.HG_EMPRESASTableAdapter = New Laboratorio.SEGURIDADDataSetTableAdapters.HG_EMPRESASTableAdapter()
        Me.fraLogin.SuspendLayout()
        CType(Me.HGEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEGURIDADDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "search.ico")
        Me.imageList1.Images.SetKeyName(1, "Loupe.png")
        Me.imageList1.Images.SetKeyName(2, "fileclose.ico")
        Me.imageList1.Images.SetKeyName(3, "Validé.png")
        Me.imageList1.Images.SetKeyName(4, "button_cancel.ico")
        Me.imageList1.Images.SetKeyName(5, "button_ok.ico")
        Me.imageList1.Images.SetKeyName(6, "filefind.ico")
        Me.imageList1.Images.SetKeyName(7, "filesave.ico")
        Me.imageList1.Images.SetKeyName(8, "filesave.png")
        Me.imageList1.Images.SetKeyName(9, "exit.png")
        '
        'fraLogin
        '
        Me.fraLogin.BackColor = System.Drawing.SystemColors.Control
        Me.fraLogin.Controls.Add(Me.cmbCodigoEmpresa)
        Me.fraLogin.Controls.Add(Me.txtPassword)
        Me.fraLogin.Controls.Add(Me.txtUsuario)
        Me.fraLogin.Controls.Add(Me.TxtDepto)
        Me.fraLogin.Controls.Add(Me.Label1)
        Me.fraLogin.Controls.Add(Me.Label2)
        Me.fraLogin.Controls.Add(Me.Label3)
        Me.fraLogin.Controls.Add(Me.Label4)
        Me.fraLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraLogin.Location = New System.Drawing.Point(23, 33)
        Me.fraLogin.Name = "fraLogin"
        Me.fraLogin.Padding = New System.Windows.Forms.Padding(0)
        Me.fraLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraLogin.Size = New System.Drawing.Size(452, 153)
        Me.fraLogin.TabIndex = 21
        Me.fraLogin.TabStop = False
        '
        'cmbCodigoEmpresa
        '
        Me.cmbCodigoEmpresa.DataSource = Me.HGEMPRESASBindingSource
        Me.cmbCodigoEmpresa.DisplayMember = "EMP_NOMBRE"
        Me.cmbCodigoEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodigoEmpresa.FormattingEnabled = True
        Me.cmbCodigoEmpresa.Location = New System.Drawing.Point(72, 16)
        Me.cmbCodigoEmpresa.Name = "cmbCodigoEmpresa"
        Me.cmbCodigoEmpresa.Size = New System.Drawing.Size(337, 25)
        Me.cmbCodigoEmpresa.TabIndex = 11
        Me.cmbCodigoEmpresa.ValueMember = "EMP_EMPRESA"
        '
        'HGEMPRESASBindingSource
        '
        Me.HGEMPRESASBindingSource.DataMember = "HG_EMPRESAS"
        Me.HGEMPRESASBindingSource.DataSource = Me.SEGURIDADDataSet
        '
        'SEGURIDADDataSet
        '
        Me.SEGURIDADDataSet.DataSetName = "SEGURIDADDataSet"
        Me.SEGURIDADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPassword.Location = New System.Drawing.Point(72, 80)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(337, 25)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.AcceptsReturn = True
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsuario.Location = New System.Drawing.Point(72, 48)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsuario.Size = New System.Drawing.Size(337, 25)
        Me.txtUsuario.TabIndex = 1
        '
        'TxtDepto
        '
        Me.TxtDepto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDepto.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.TxtDepto.Enabled = False
        Me.TxtDepto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDepto.Location = New System.Drawing.Point(72, 112)
        Me.TxtDepto.Name = "TxtDepto"
        Me.TxtDepto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDepto.Size = New System.Drawing.Size(337, 21)
        Me.TxtDepto.Sorted = True
        Me.TxtDepto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Depto.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Empresa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(161, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Ingreso de Usuarios"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalir.ImageIndex = 9
        Me.cmdSalir.ImageList = Me.imageList1
        Me.cmdSalir.Location = New System.Drawing.Point(300, 188)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(72, 48)
        Me.cmdSalir.TabIndex = 24
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdIngresar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdIngresar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdIngresar.ImageIndex = 5
        Me.cmdIngresar.ImageList = Me.imageList1
        Me.cmdIngresar.Location = New System.Drawing.Point(95, 188)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdIngresar.Size = New System.Drawing.Size(72, 48)
        Me.cmdIngresar.TabIndex = 23
        Me.cmdIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'HGUSUARIOSBindingSource
        '
        Me.HGUSUARIOSBindingSource.DataMember = "HG_USUARIOS"
        Me.HGUSUARIOSBindingSource.DataSource = Me.SEGURIDADDataSet
        '
        'HG_USUARIOSTableAdapter
        '
        Me.HG_USUARIOSTableAdapter.ClearBeforeFill = True
        '
        'HG_EMPRESASTableAdapter
        '
        Me.HG_EMPRESASTableAdapter.ClearBeforeFill = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(488, 269)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.fraLogin)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorio - Ingreso al Sistema"
        Me.fraLogin.ResumeLayout(False)
        Me.fraLogin.PerformLayout()
        CType(Me.HGEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEGURIDADDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cmdSalir As System.Windows.Forms.Button
    Public WithEvents cmdIngresar As System.Windows.Forms.Button
    Public WithEvents fraLogin As System.Windows.Forms.GroupBox

    Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents txtUsuario As System.Windows.Forms.TextBox
    Public WithEvents TxtDepto As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmbCodigoEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents SEGURIDADDataSet As Laboratorio.SEGURIDADDataSet
    Friend WithEvents HGUSUARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HG_USUARIOSTableAdapter As Laboratorio.SEGURIDADDataSetTableAdapters.HG_USUARIOSTableAdapter
    Friend WithEvents HGEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HG_EMPRESASTableAdapter As Laboratorio.SEGURIDADDataSetTableAdapters.HG_EMPRESASTableAdapter




End Class
