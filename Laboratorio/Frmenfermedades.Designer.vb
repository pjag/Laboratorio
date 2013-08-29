<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmenfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmenfermedades))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enfermedad Grado I"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enfermedad Grado III"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enfermedad Grado II"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(164, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(316, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(316, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(164, 105)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(316, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Button11
        '
        Me.Button11.ImageKey = "editdelete.png"
        Me.Button11.ImageList = Me.imageList1
        Me.Button11.Location = New System.Drawing.Point(387, 208)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(86, 55)
        Me.Button11.TabIndex = 35
        Me.Button11.Text = "Cancelar"
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.ImageKey = "button_cancel.ico"
        Me.Button10.ImageList = Me.imageList1
        Me.Button10.Location = New System.Drawing.Point(313, 208)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 55)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Borrar"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.ImageList = Me.imageList1
        Me.Button9.Location = New System.Drawing.Point(237, 208)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 55)
        Me.Button9.TabIndex = 33
        Me.Button9.Text = "Guardar"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = True
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
        'Button4
        '
        Me.Button4.ImageIndex = 1
        Me.Button4.ImageList = Me.imageList1
        Me.Button4.Location = New System.Drawing.Point(497, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 40)
        Me.Button4.TabIndex = 36
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.imageList1
        Me.Button1.Location = New System.Drawing.Point(497, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 40)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageIndex = 1
        Me.Button2.ImageList = Me.imageList1
        Me.Button2.Location = New System.Drawing.Point(497, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 40)
        Me.Button2.TabIndex = 38
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Observaciones"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(164, 145)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(446, 54)
        Me.TextBox4.TabIndex = 40
        '
        'Frmenfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 275)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmenfermedades"
        Me.Text = "Frmenfermedades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
