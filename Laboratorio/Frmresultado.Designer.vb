<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmresultado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmresultado))
        Dim ClaseResLabel As System.Windows.Forms.Label
        Dim CodigoRes1Label As System.Windows.Forms.Label
        Dim CodigoRes2Label As System.Windows.Forms.Label
        Dim CodigoRes3Label As System.Windows.Forms.Label
        Dim NombreRes1Label As System.Windows.Forms.Label
        Dim NombreRes2Label As System.Windows.Forms.Label
        Dim NombreRes3Label As System.Windows.Forms.Label
        Dim TIPOINFORMELabel As System.Windows.Forms.Label
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TIPORESULTADOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPORESULTADOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TIPORESULTADOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClaseResTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoRes2TextBox = New System.Windows.Forms.TextBox()
        Me.CodigoRes3TextBox = New System.Windows.Forms.TextBox()
        Me.NombreRes1TextBox = New System.Windows.Forms.TextBox()
        Me.NombreRes2TextBox = New System.Windows.Forms.TextBox()
        Me.NombreRes3TextBox = New System.Windows.Forms.TextBox()
        Me.CodigoRes1ComboBox = New System.Windows.Forms.ComboBox()
        ClaseResLabel = New System.Windows.Forms.Label()
        CodigoRes1Label = New System.Windows.Forms.Label()
        CodigoRes2Label = New System.Windows.Forms.Label()
        CodigoRes3Label = New System.Windows.Forms.Label()
        NombreRes1Label = New System.Windows.Forms.Label()
        NombreRes2Label = New System.Windows.Forms.Label()
        NombreRes3Label = New System.Windows.Forms.Label()
        TIPOINFORMELabel = New System.Windows.Forms.Label()
        CType(Me.TIPORESULTADOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPORESULTADOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TIPORESULTADOBindingNavigator.SuspendLayout()
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
        Me.imageList1.Images.SetKeyName(10, "16 (Minus).ico")
        Me.imageList1.Images.SetKeyName(11, "16 (Plus).ico")
        Me.imageList1.Images.SetKeyName(12, "16 (Repeat).ico")
        Me.imageList1.Images.SetKeyName(13, "Txt.png")
        Me.imageList1.Images.SetKeyName(14, "Xls.png")
        Me.imageList1.Images.SetKeyName(15, "new window.png")
        Me.imageList1.Images.SetKeyName(16, "newfont.png")
        Me.imageList1.Images.SetKeyName(17, "16 (Edit-2).ico")
        Me.imageList1.Images.SetKeyName(18, "Macroscopia.png")
        Me.imageList1.Images.SetKeyName(19, "kwix-fg-page3_1_1.png")
        Me.imageList1.Images.SetKeyName(20, "editdelete.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Clase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Informe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Nombre"
        '
        'Button11
        '
        Me.Button11.ImageKey = "editdelete.png"
        Me.Button11.ImageList = Me.imageList1
        Me.Button11.Location = New System.Drawing.Point(165, 217)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(86, 55)
        Me.Button11.TabIndex = 35
        Me.Button11.Text = "Cancelar"
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Button10
        '
        Me.Button10.ImageKey = "button_cancel.ico"
        Me.Button10.ImageList = Me.imageList1
        Me.Button10.Location = New System.Drawing.Point(91, 217)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 55)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Borrar"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.ImageList = Me.imageList1
        Me.Button9.Location = New System.Drawing.Point(15, 217)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 55)
        Me.Button9.TabIndex = 33
        Me.Button9.Text = "Guardar"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.imageList1
        Me.Button1.Location = New System.Drawing.Point(257, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 40)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TIPORESULTADOBindingSource
        '
        Me.TIPORESULTADOBindingSource.DataSource = GetType(Laboratorio.TIPORESULTADO)
        '
        'TIPORESULTADOBindingNavigator
        '
        Me.TIPORESULTADOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TIPORESULTADOBindingNavigator.BindingSource = Me.TIPORESULTADOBindingSource
        Me.TIPORESULTADOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TIPORESULTADOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TIPORESULTADOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TIPORESULTADOBindingNavigatorSaveItem})
        Me.TIPORESULTADOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TIPORESULTADOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TIPORESULTADOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TIPORESULTADOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TIPORESULTADOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TIPORESULTADOBindingNavigator.Name = "TIPORESULTADOBindingNavigator"
        Me.TIPORESULTADOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TIPORESULTADOBindingNavigator.Size = New System.Drawing.Size(1100, 25)
        Me.TIPORESULTADOBindingNavigator.TabIndex = 45
        Me.TIPORESULTADOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TIPORESULTADOBindingNavigatorSaveItem
        '
        Me.TIPORESULTADOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TIPORESULTADOBindingNavigatorSaveItem.Image = CType(resources.GetObject("TIPORESULTADOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TIPORESULTADOBindingNavigatorSaveItem.Name = "TIPORESULTADOBindingNavigatorSaveItem"
        Me.TIPORESULTADOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TIPORESULTADOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClaseResLabel
        '
        ClaseResLabel.AutoSize = True
        ClaseResLabel.Location = New System.Drawing.Point(577, 49)
        ClaseResLabel.Name = "ClaseResLabel"
        ClaseResLabel.Size = New System.Drawing.Size(58, 13)
        ClaseResLabel.TabIndex = 45
        ClaseResLabel.Text = "Clase Res:"
        '
        'ClaseResTextBox
        '
        Me.ClaseResTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "ClaseRes", True))
        Me.ClaseResTextBox.Location = New System.Drawing.Point(91, 186)
        Me.ClaseResTextBox.Name = "ClaseResTextBox"
        Me.ClaseResTextBox.Size = New System.Drawing.Size(259, 20)
        Me.ClaseResTextBox.TabIndex = 46
        '
        'CodigoRes1Label
        '
        CodigoRes1Label.AutoSize = True
        CodigoRes1Label.Location = New System.Drawing.Point(577, 75)
        CodigoRes1Label.Name = "CodigoRes1Label"
        CodigoRes1Label.Size = New System.Drawing.Size(71, 13)
        CodigoRes1Label.TabIndex = 47
        CodigoRes1Label.Text = "Codigo Res1:"
        '
        'CodigoRes2Label
        '
        CodigoRes2Label.AutoSize = True
        CodigoRes2Label.Location = New System.Drawing.Point(577, 101)
        CodigoRes2Label.Name = "CodigoRes2Label"
        CodigoRes2Label.Size = New System.Drawing.Size(71, 13)
        CodigoRes2Label.TabIndex = 49
        CodigoRes2Label.Text = "Codigo Res2:"
        '
        'CodigoRes2TextBox
        '
        Me.CodigoRes2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "CodigoRes2", True))
        Me.CodigoRes2TextBox.Location = New System.Drawing.Point(197, 53)
        Me.CodigoRes2TextBox.Name = "CodigoRes2TextBox"
        Me.CodigoRes2TextBox.Size = New System.Drawing.Size(80, 20)
        Me.CodigoRes2TextBox.TabIndex = 50
        '
        'CodigoRes3Label
        '
        CodigoRes3Label.AutoSize = True
        CodigoRes3Label.Location = New System.Drawing.Point(577, 127)
        CodigoRes3Label.Name = "CodigoRes3Label"
        CodigoRes3Label.Size = New System.Drawing.Size(71, 13)
        CodigoRes3Label.TabIndex = 51
        CodigoRes3Label.Text = "Codigo Res3:"
        '
        'CodigoRes3TextBox
        '
        Me.CodigoRes3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "CodigoRes3", True))
        Me.CodigoRes3TextBox.Location = New System.Drawing.Point(293, 54)
        Me.CodigoRes3TextBox.Name = "CodigoRes3TextBox"
        Me.CodigoRes3TextBox.Size = New System.Drawing.Size(80, 20)
        Me.CodigoRes3TextBox.TabIndex = 52
        '
        'NombreRes1Label
        '
        NombreRes1Label.AutoSize = True
        NombreRes1Label.Location = New System.Drawing.Point(577, 153)
        NombreRes1Label.Name = "NombreRes1Label"
        NombreRes1Label.Size = New System.Drawing.Size(75, 13)
        NombreRes1Label.TabIndex = 53
        NombreRes1Label.Text = "Nombre Res1:"
        '
        'NombreRes1TextBox
        '
        Me.NombreRes1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "NombreRes1", True))
        Me.NombreRes1TextBox.Location = New System.Drawing.Point(91, 111)
        Me.NombreRes1TextBox.Name = "NombreRes1TextBox"
        Me.NombreRes1TextBox.Size = New System.Drawing.Size(259, 20)
        Me.NombreRes1TextBox.TabIndex = 54
        '
        'NombreRes2Label
        '
        NombreRes2Label.AutoSize = True
        NombreRes2Label.Location = New System.Drawing.Point(577, 179)
        NombreRes2Label.Name = "NombreRes2Label"
        NombreRes2Label.Size = New System.Drawing.Size(75, 13)
        NombreRes2Label.TabIndex = 55
        NombreRes2Label.Text = "Nombre Res2:"
        '
        'NombreRes2TextBox
        '
        Me.NombreRes2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "NombreRes2", True))
        Me.NombreRes2TextBox.Location = New System.Drawing.Point(91, 134)
        Me.NombreRes2TextBox.Name = "NombreRes2TextBox"
        Me.NombreRes2TextBox.Size = New System.Drawing.Size(259, 20)
        Me.NombreRes2TextBox.TabIndex = 56
        '
        'NombreRes3Label
        '
        NombreRes3Label.AutoSize = True
        NombreRes3Label.Location = New System.Drawing.Point(577, 205)
        NombreRes3Label.Name = "NombreRes3Label"
        NombreRes3Label.Size = New System.Drawing.Size(75, 13)
        NombreRes3Label.TabIndex = 57
        NombreRes3Label.Text = "Nombre Res3:"
        '
        'NombreRes3TextBox
        '
        Me.NombreRes3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "NombreRes3", True))
        Me.NombreRes3TextBox.Location = New System.Drawing.Point(91, 160)
        Me.NombreRes3TextBox.Name = "NombreRes3TextBox"
        Me.NombreRes3TextBox.Size = New System.Drawing.Size(259, 20)
        Me.NombreRes3TextBox.TabIndex = 58
        '
        'TIPOINFORMELabel
        '
        TIPOINFORMELabel.AutoSize = True
        TIPOINFORMELabel.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TIPORESULTADOBindingSource, "TIPOINFORME", True))
        TIPOINFORMELabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "TIPOINFORME", True))
        TIPOINFORMELabel.Location = New System.Drawing.Point(568, 231)
        TIPOINFORMELabel.Name = "TIPOINFORMELabel"
        TIPOINFORMELabel.Size = New System.Drawing.Size(84, 13)
        TIPOINFORMELabel.TabIndex = 58
        TIPOINFORMELabel.Text = "TIPOINFORME:"
        '
        'CodigoRes1ComboBox
        '
        Me.CodigoRes1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TIPORESULTADOBindingSource, "CodigoRes1", True))
        Me.CodigoRes1ComboBox.FormattingEnabled = True
        Me.CodigoRes1ComboBox.Location = New System.Drawing.Point(91, 52)
        Me.CodigoRes1ComboBox.Name = "CodigoRes1ComboBox"
        Me.CodigoRes1ComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CodigoRes1ComboBox.TabIndex = 59
        '
        'Frmresultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 295)
        Me.Controls.Add(Me.CodigoRes1ComboBox)
        Me.Controls.Add(TIPOINFORMELabel)
        Me.Controls.Add(ClaseResLabel)
        Me.Controls.Add(Me.ClaseResTextBox)
        Me.Controls.Add(CodigoRes1Label)
        Me.Controls.Add(CodigoRes2Label)
        Me.Controls.Add(Me.CodigoRes2TextBox)
        Me.Controls.Add(CodigoRes3Label)
        Me.Controls.Add(Me.CodigoRes3TextBox)
        Me.Controls.Add(NombreRes1Label)
        Me.Controls.Add(Me.NombreRes1TextBox)
        Me.Controls.Add(NombreRes2Label)
        Me.Controls.Add(Me.NombreRes2TextBox)
        Me.Controls.Add(NombreRes3Label)
        Me.Controls.Add(Me.NombreRes3TextBox)
        Me.Controls.Add(Me.TIPORESULTADOBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Name = "Frmresultado"
        Me.Text = "Resultados"
        CType(Me.TIPORESULTADOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPORESULTADOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TIPORESULTADOBindingNavigator.ResumeLayout(False)
        Me.TIPORESULTADOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TIPORESULTADOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPORESULTADOBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TIPORESULTADOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClaseResTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoRes2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoRes3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreRes1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreRes2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreRes3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoRes1ComboBox As System.Windows.Forms.ComboBox
End Class
