<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmedico))
        Dim CodMedicoLabel As System.Windows.Forms.Label
        Dim ColegiadoLabel As System.Windows.Forms.Label
        Dim NombreMedicoLabel As System.Windows.Forms.Label
        Dim TeMedicoLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MEDICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MEDICOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.ColegiadoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreMedicoTextBox = New System.Windows.Forms.TextBox()
        Me.TeMedicoTextBox = New System.Windows.Forms.TextBox()
        CodMedicoLabel = New System.Windows.Forms.Label()
        ColegiadoLabel = New System.Windows.Forms.Label()
        NombreMedicoLabel = New System.Windows.Forms.Label()
        TeMedicoLabel = New System.Windows.Forms.Label()
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MEDICOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre y Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Colegiado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Especialidad"
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
        'Button3
        '
        Me.Button3.ImageKey = "editdelete.png"
        Me.Button3.ImageList = Me.imageList1
        Me.Button3.Location = New System.Drawing.Point(183, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 55)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageKey = "button_cancel.ico"
        Me.Button2.ImageList = Me.imageList1
        Me.Button2.Location = New System.Drawing.Point(109, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 55)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Borrar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageIndex = 7
        Me.Button1.ImageList = Me.imageList1
        Me.Button1.Location = New System.Drawing.Point(33, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 55)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Guardar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ImageIndex = 1
        Me.Button4.ImageList = Me.imageList1
        Me.Button4.Location = New System.Drawing.Point(275, 225)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 40)
        Me.Button4.TabIndex = 36
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ImageIndex = 1
        Me.Button5.ImageList = Me.imageList1
        Me.Button5.Location = New System.Drawing.Point(275, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 40)
        Me.Button5.TabIndex = 37
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MEDICOBindingSource
        '
        Me.MEDICOBindingSource.DataSource = GetType(Laboratorio.MEDICO)
        '
        'MEDICOBindingNavigator
        '
        Me.MEDICOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MEDICOBindingNavigator.BindingSource = Me.MEDICOBindingSource
        Me.MEDICOBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MEDICOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MEDICOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MEDICOBindingNavigatorSaveItem})
        Me.MEDICOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MEDICOBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MEDICOBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MEDICOBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MEDICOBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MEDICOBindingNavigator.Name = "MEDICOBindingNavigator"
        Me.MEDICOBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MEDICOBindingNavigator.Size = New System.Drawing.Size(669, 25)
        Me.MEDICOBindingNavigator.TabIndex = 38
        Me.MEDICOBindingNavigator.Text = "BindingNavigator1"
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
        'MEDICOBindingNavigatorSaveItem
        '
        Me.MEDICOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MEDICOBindingNavigatorSaveItem.Enabled = False
        Me.MEDICOBindingNavigatorSaveItem.Image = CType(resources.GetObject("MEDICOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MEDICOBindingNavigatorSaveItem.Name = "MEDICOBindingNavigatorSaveItem"
        Me.MEDICOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MEDICOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodMedicoLabel
        '
        CodMedicoLabel.AutoSize = True
        CodMedicoLabel.Location = New System.Drawing.Point(398, 57)
        CodMedicoLabel.Name = "CodMedicoLabel"
        CodMedicoLabel.Size = New System.Drawing.Size(67, 13)
        CodMedicoLabel.TabIndex = 38
        CodMedicoLabel.Text = "Cod Medico:"
        '
        'CodMedicoTextBox
        '
        Me.CodMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "CodMedico", True))
        Me.CodMedicoTextBox.Location = New System.Drawing.Point(128, 30)
        Me.CodMedicoTextBox.Name = "CodMedicoTextBox"
        Me.CodMedicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodMedicoTextBox.TabIndex = 39
        '
        'ColegiadoLabel
        '
        ColegiadoLabel.AutoSize = True
        ColegiadoLabel.Location = New System.Drawing.Point(398, 83)
        ColegiadoLabel.Name = "ColegiadoLabel"
        ColegiadoLabel.Size = New System.Drawing.Size(57, 13)
        ColegiadoLabel.TabIndex = 40
        ColegiadoLabel.Text = "Colegiado:"
        '
        'ColegiadoTextBox
        '
        Me.ColegiadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "Colegiado", True))
        Me.ColegiadoTextBox.Location = New System.Drawing.Point(128, 57)
        Me.ColegiadoTextBox.Name = "ColegiadoTextBox"
        Me.ColegiadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColegiadoTextBox.TabIndex = 41
        '
        'NombreMedicoLabel
        '
        NombreMedicoLabel.AutoSize = True
        NombreMedicoLabel.Location = New System.Drawing.Point(398, 109)
        NombreMedicoLabel.Name = "NombreMedicoLabel"
        NombreMedicoLabel.Size = New System.Drawing.Size(85, 13)
        NombreMedicoLabel.TabIndex = 42
        NombreMedicoLabel.Text = "Nombre Medico:"
        '
        'NombreMedicoTextBox
        '
        Me.NombreMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "NombreMedico", True))
        Me.NombreMedicoTextBox.Location = New System.Drawing.Point(128, 94)
        Me.NombreMedicoTextBox.Name = "NombreMedicoTextBox"
        Me.NombreMedicoTextBox.Size = New System.Drawing.Size(191, 20)
        Me.NombreMedicoTextBox.TabIndex = 43
        '
        'TeMedicoLabel
        '
        TeMedicoLabel.AutoSize = True
        TeMedicoLabel.Location = New System.Drawing.Point(398, 135)
        TeMedicoLabel.Name = "TeMedicoLabel"
        TeMedicoLabel.Size = New System.Drawing.Size(61, 13)
        TeMedicoLabel.TabIndex = 44
        TeMedicoLabel.Text = "Te Medico:"
        '
        'TeMedicoTextBox
        '
        Me.TeMedicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MEDICOBindingSource, "TeMedico", True))
        Me.TeMedicoTextBox.Location = New System.Drawing.Point(128, 142)
        Me.TeMedicoTextBox.Name = "TeMedicoTextBox"
        Me.TeMedicoTextBox.Size = New System.Drawing.Size(191, 20)
        Me.TeMedicoTextBox.TabIndex = 45
        '
        'Frmmedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 285)
        Me.Controls.Add(CodMedicoLabel)
        Me.Controls.Add(Me.CodMedicoTextBox)
        Me.Controls.Add(ColegiadoLabel)
        Me.Controls.Add(Me.ColegiadoTextBox)
        Me.Controls.Add(NombreMedicoLabel)
        Me.Controls.Add(Me.NombreMedicoTextBox)
        Me.Controls.Add(TeMedicoLabel)
        Me.Controls.Add(Me.TeMedicoTextBox)
        Me.Controls.Add(Me.MEDICOBindingNavigator)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmmedico"
        Me.Text = "Medico"
        CType(Me.MEDICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MEDICOBindingNavigator.ResumeLayout(False)
        Me.MEDICOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents MEDICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICOBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MEDICOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodMedicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColegiadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreMedicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeMedicoTextBox As System.Windows.Forms.TextBox
End Class
