<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmprocedencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmprocedencia))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ORIGENPACIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORIGENPACIENTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ORIGENPACIENTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ORIGENPACIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORIGENPACIENTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ORIGENPACIENTEBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Procedencia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Código"
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
        'Button15
        '
        Me.Button15.ImageKey = "editdelete.png"
        Me.Button15.ImageList = Me.imageList1
        Me.Button15.Location = New System.Drawing.Point(257, 109)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(86, 55)
        Me.Button15.TabIndex = 46
        Me.Button15.Text = "Cancelar"
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button15.UseVisualStyleBackColor = True
        Me.Button15.Visible = False
        '
        'Button14
        '
        Me.Button14.ImageKey = "button_cancel.ico"
        Me.Button14.ImageList = Me.imageList1
        Me.Button14.Location = New System.Drawing.Point(183, 109)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(68, 55)
        Me.Button14.TabIndex = 45
        Me.Button14.Text = "Borrar"
        Me.Button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button14.UseVisualStyleBackColor = True
        Me.Button14.Visible = False
        '
        'Button13
        '
        Me.Button13.ImageIndex = 7
        Me.Button13.ImageList = Me.imageList1
        Me.Button13.Location = New System.Drawing.Point(107, 109)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(68, 55)
        Me.Button13.TabIndex = 44
        Me.Button13.Text = "Guardar"
        Me.Button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button13.UseVisualStyleBackColor = True
        Me.Button13.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.imageList1
        Me.Button1.Location = New System.Drawing.Point(28, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 40)
        Me.Button1.TabIndex = 47
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'ORIGENPACIENTEBindingSource
        '
        Me.ORIGENPACIENTEBindingSource.DataSource = GetType(Laboratorio.ORIGENPACIENTE)
        '
        'ORIGENPACIENTEBindingNavigator
        '
        Me.ORIGENPACIENTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ORIGENPACIENTEBindingNavigator.BindingSource = Me.ORIGENPACIENTEBindingSource
        Me.ORIGENPACIENTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ORIGENPACIENTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ORIGENPACIENTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ORIGENPACIENTEBindingNavigatorSaveItem})
        Me.ORIGENPACIENTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ORIGENPACIENTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ORIGENPACIENTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ORIGENPACIENTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ORIGENPACIENTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ORIGENPACIENTEBindingNavigator.Name = "ORIGENPACIENTEBindingNavigator"
        Me.ORIGENPACIENTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ORIGENPACIENTEBindingNavigator.Size = New System.Drawing.Size(354, 25)
        Me.ORIGENPACIENTEBindingNavigator.TabIndex = 48
        Me.ORIGENPACIENTEBindingNavigator.Text = "BindingNavigator1"
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
        'ORIGENPACIENTEBindingNavigatorSaveItem
        '
        Me.ORIGENPACIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ORIGENPACIENTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("ORIGENPACIENTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ORIGENPACIENTEBindingNavigatorSaveItem.Name = "ORIGENPACIENTEBindingNavigatorSaveItem"
        Me.ORIGENPACIENTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ORIGENPACIENTEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORIGENPACIENTEBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(107, 52)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoTextBox.TabIndex = 49
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ORIGENPACIENTEBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(107, 85)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(162, 20)
        Me.NombreTextBox.TabIndex = 51
        '
        'Frmprocedencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 184)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.ORIGENPACIENTEBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmprocedencia"
        Me.Text = "Procedencia"
        CType(Me.ORIGENPACIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORIGENPACIENTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ORIGENPACIENTEBindingNavigator.ResumeLayout(False)
        Me.ORIGENPACIENTEBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ORIGENPACIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ORIGENPACIENTEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ORIGENPACIENTEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
End Class
