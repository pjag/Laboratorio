﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCitologiadeOrina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCitologiadeOrina))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(620, 108)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 85
        Me.DateTimePicker2.Value = New Date(2013, 8, 20, 0, 19, 55, 0)
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(519, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 47)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "Fecha Obtencion"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(140, 147)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox2.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Medico Solicitante"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(316, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox1.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Procedencia"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(65, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 24)
        Me.Label8.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Edad"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(522, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 24)
        Me.Label7.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(485, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(126, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(353, 24)
        Me.Label5.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Nombre Paciente"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(566, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 70
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(327, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Numero de Informe"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 66
        Me.DateTimePicker1.Value = New Date(2013, 8, 20, 0, 19, 55, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Fecha Informe"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(328, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(353, 24)
        Me.Label14.TabIndex = 89
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(150, 185)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Codigo Resumen"
        '
        'Button11
        '
        Me.Button11.ImageKey = "editdelete.png"
        Me.Button11.ImageList = Me.imageList1
        Me.Button11.Location = New System.Drawing.Point(178, 298)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(86, 55)
        Me.Button11.TabIndex = 94
        Me.Button11.Text = "Cancelar"
        Me.Button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.ImageKey = "button_cancel.ico"
        Me.Button10.ImageList = Me.imageList1
        Me.Button10.Location = New System.Drawing.Point(104, 298)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 55)
        Me.Button10.TabIndex = 93
        Me.Button10.Text = "Borrar"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.ImageList = Me.imageList1
        Me.Button9.Location = New System.Drawing.Point(28, 298)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 55)
        Me.Button9.TabIndex = 92
        Me.Button9.Text = "Guardar"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ImageKey = "Txt.png"
        Me.Button5.ImageList = Me.imageList1
        Me.Button5.Location = New System.Drawing.Point(65, 241)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 51)
        Me.Button5.TabIndex = 91
        Me.Button5.Text = "Informe Orina"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.ImageKey = "16 (Edit-2).ico"
        Me.Button8.ImageList = Me.imageList1
        Me.Button8.Location = New System.Drawing.Point(150, 241)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 51)
        Me.Button8.TabIndex = 90
        Me.Button8.Text = "Nota"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ImageIndex = 1
        Me.Button4.ImageList = Me.imageList1
        Me.Button4.Location = New System.Drawing.Point(262, 174)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 40)
        Me.Button4.TabIndex = 88
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ImageIndex = 1
        Me.Button3.ImageList = Me.imageList1
        Me.Button3.Location = New System.Drawing.Point(338, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 40)
        Me.Button3.TabIndex = 83
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.imageList1
        Me.Button1.Location = New System.Drawing.Point(684, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 40)
        Me.Button1.TabIndex = 72
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageIndex = 1
        Me.Button2.ImageList = Me.imageList1
        Me.Button2.Location = New System.Drawing.Point(433, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 40)
        Me.Button2.TabIndex = 71
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCitologiadeOrina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 359)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCitologiadeOrina"
        Me.Text = "Citología de Orina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
