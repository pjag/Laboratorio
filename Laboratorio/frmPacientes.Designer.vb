<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacientes))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(125, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 24)
        Me.Label8.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Edad"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(125, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 24)
        Me.Label7.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(125, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(353, 24)
        Me.Label5.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Nombre Paciente"
        '
        'Button1
        '
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.imageList1
        Me.Button1.Location = New System.Drawing.Point(194, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 40)
        Me.Button1.TabIndex = 81
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(76, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Codigo"
        '
        'Button2
        '
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.imageList1
        Me.Button2.Location = New System.Drawing.Point(32, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 50)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Aceptar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ImageKey = "exit.png"
        Me.Button3.ImageList = Me.imageList1
        Me.Button3.Location = New System.Drawing.Point(177, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 50)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "Salir"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 262)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmPacientes"
        Me.Text = "frmPacientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
