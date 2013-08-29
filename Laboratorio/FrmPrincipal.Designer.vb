<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuPrincipal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipalSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcedenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialesEnviadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaestros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuMaestrosMedicos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColpocitologíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaestrosMedicamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProcedenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUtilidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWord = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorMedicoSolicitanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorInformesRealizadosPorPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportePorDiagnosticosRealizadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAcercaModulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPrincipalLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(769, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincipalLogin, Me.mnuPrincipalSalir, Me.ProcedenciaToolStripMenuItem, Me.MaterialesEnviadosToolStripMenuItem, Me.TipoDeInformesToolStripMenuItem, Me.TipoDeResultadosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.mnuPrincipal.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(65, 20)
        Me.mnuPrincipal.Text = "&Principal"
        '
        'mnuPrincipalSalir
        '
        Me.mnuPrincipalSalir.Name = "mnuPrincipalSalir"
        Me.mnuPrincipalSalir.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuPrincipalSalir.Size = New System.Drawing.Size(310, 22)
        Me.mnuPrincipalSalir.Text = "Medicos Solicitantes"
        '
        'ProcedenciaToolStripMenuItem
        '
        Me.ProcedenciaToolStripMenuItem.Name = "ProcedenciaToolStripMenuItem"
        Me.ProcedenciaToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.ProcedenciaToolStripMenuItem.Text = "Procedencia"
        '
        'MaterialesEnviadosToolStripMenuItem
        '
        Me.MaterialesEnviadosToolStripMenuItem.Name = "MaterialesEnviadosToolStripMenuItem"
        Me.MaterialesEnviadosToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.MaterialesEnviadosToolStripMenuItem.Text = "Materiales Enviados"
        '
        'TipoDeInformesToolStripMenuItem
        '
        Me.TipoDeInformesToolStripMenuItem.Name = "TipoDeInformesToolStripMenuItem"
        Me.TipoDeInformesToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.TipoDeInformesToolStripMenuItem.Text = "Tipo de Informes"
        '
        'TipoDeResultadosToolStripMenuItem
        '
        Me.TipoDeResultadosToolStripMenuItem.Name = "TipoDeResultadosToolStripMenuItem"
        Me.TipoDeResultadosToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.TipoDeResultadosToolStripMenuItem.Text = "Tipo de Resultados"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(310, 22)
        Me.SalirToolStripMenuItem.Text = "Clasificación Internacional de Enfermedades "
        '
        'mnuMaestros
        '
        Me.mnuMaestros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.mnuMaestrosMedicos, Me.mnuMaestrosMedicamentos, Me.ToolStripMenuItem2, Me.ProcedenciasToolStripMenuItem, Me.ResultadosToolStripMenuItem})
        Me.mnuMaestros.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuMaestros.Name = "mnuMaestros"
        Me.mnuMaestros.Size = New System.Drawing.Size(66, 20)
        Me.mnuMaestros.Text = "&Informes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 6)
        '
        'mnuMaestrosMedicos
        '
        Me.mnuMaestrosMedicos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColpocitologíaToolStripMenuItem, Me.ResultadosToolStripMenuItem1})
        Me.mnuMaestrosMedicos.Name = "mnuMaestrosMedicos"
        Me.mnuMaestrosMedicos.Size = New System.Drawing.Size(211, 22)
        Me.mnuMaestrosMedicos.Text = "Colpocitología"
        '
        'ColpocitologíaToolStripMenuItem
        '
        Me.ColpocitologíaToolStripMenuItem.Name = "ColpocitologíaToolStripMenuItem"
        Me.ColpocitologíaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColpocitologíaToolStripMenuItem.Text = "Colpocitología"
        '
        'ResultadosToolStripMenuItem1
        '
        Me.ResultadosToolStripMenuItem1.Name = "ResultadosToolStripMenuItem1"
        Me.ResultadosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ResultadosToolStripMenuItem1.Text = "Resultados"
        '
        'mnuMaestrosMedicamentos
        '
        Me.mnuMaestrosMedicamentos.Name = "mnuMaestrosMedicamentos"
        Me.mnuMaestrosMedicamentos.Size = New System.Drawing.Size(211, 22)
        Me.mnuMaestrosMedicamentos.Text = "Anatomapatologia"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(208, 6)
        '
        'ProcedenciasToolStripMenuItem
        '
        Me.ProcedenciasToolStripMenuItem.Name = "ProcedenciasToolStripMenuItem"
        Me.ProcedenciasToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ProcedenciasToolStripMenuItem.Text = "Citologia de Orina"
        '
        'ResultadosToolStripMenuItem
        '
        Me.ResultadosToolStripMenuItem.Name = "ResultadosToolStripMenuItem"
        Me.ResultadosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ResultadosToolStripMenuItem.Text = "Citologia de Otro Material"
        '
        'mnuUtilidades
        '
        Me.mnuUtilidades.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExcel, Me.mnuWord, Me.ReportePorMedicoSolicitanteToolStripMenuItem, Me.ReportePorInformesRealizadosPorPacientesToolStripMenuItem, Me.ReportePorDiagnosticosRealizadosToolStripMenuItem})
        Me.mnuUtilidades.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuUtilidades.Name = "mnuUtilidades"
        Me.mnuUtilidades.Size = New System.Drawing.Size(71, 20)
        Me.mnuUtilidades.Text = "Consultas"
        '
        'mnuExcel
        '
        Me.mnuExcel.Name = "mnuExcel"
        Me.mnuExcel.Size = New System.Drawing.Size(315, 22)
        Me.mnuExcel.Text = "Reportes por tipo de Informe"
        '
        'mnuWord
        '
        Me.mnuWord.Name = "mnuWord"
        Me.mnuWord.Size = New System.Drawing.Size(315, 22)
        Me.mnuWord.Text = "Reporte por Procedencia del Paciente"
        '
        'ReportePorMedicoSolicitanteToolStripMenuItem
        '
        Me.ReportePorMedicoSolicitanteToolStripMenuItem.Name = "ReportePorMedicoSolicitanteToolStripMenuItem"
        Me.ReportePorMedicoSolicitanteToolStripMenuItem.Size = New System.Drawing.Size(315, 22)
        Me.ReportePorMedicoSolicitanteToolStripMenuItem.Text = "Reporte por Medico Solicitante"
        '
        'ReportePorInformesRealizadosPorPacientesToolStripMenuItem
        '
        Me.ReportePorInformesRealizadosPorPacientesToolStripMenuItem.Name = "ReportePorInformesRealizadosPorPacientesToolStripMenuItem"
        Me.ReportePorInformesRealizadosPorPacientesToolStripMenuItem.Size = New System.Drawing.Size(315, 22)
        Me.ReportePorInformesRealizadosPorPacientesToolStripMenuItem.Text = "Reporte por Informes realizados por Pacientes"
        '
        'ReportePorDiagnosticosRealizadosToolStripMenuItem
        '
        Me.ReportePorDiagnosticosRealizadosToolStripMenuItem.Name = "ReportePorDiagnosticosRealizadosToolStripMenuItem"
        Me.ReportePorDiagnosticosRealizadosToolStripMenuItem.Size = New System.Drawing.Size(315, 22)
        Me.ReportePorDiagnosticosRealizadosToolStripMenuItem.Text = "Reporte por Diagnosticos realizados"
        '
        'mnuAcercaDe
        '
        Me.mnuAcercaDe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcercaModulo, Me.ManualToolStripMenuItem})
        Me.mnuAcercaDe.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuAcercaDe.Name = "mnuAcercaDe"
        Me.mnuAcercaDe.Size = New System.Drawing.Size(72, 20)
        Me.mnuAcercaDe.Text = "&Acerca De"
        '
        'mnuAcercaModulo
        '
        Me.mnuAcercaModulo.Name = "mnuAcercaModulo"
        Me.mnuAcercaModulo.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuAcercaModulo.Size = New System.Drawing.Size(270, 22)
        Me.mnuAcercaModulo.Text = "Acerca de &Módulo de Laboratorio"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'MainMenu1
        '
        Me.MainMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincipal, Me.mnuMaestros, Me.mnuUtilidades, Me.mnuAcercaDe})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu1.ShowItemToolTips = True
        Me.MainMenu1.Size = New System.Drawing.Size(769, 24)
        Me.MainMenu1.TabIndex = 11
        '
        'mnuPrincipalLogin
        '
        Me.mnuPrincipalLogin.Name = "mnuPrincipalLogin"
        Me.mnuPrincipalLogin.Size = New System.Drawing.Size(310, 22)
        Me.mnuPrincipalLogin.Text = "&Pacientes"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Laboratorio.My.Resources.Resources.fondo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 453)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.Text = "Hospital General San Juan de Dios - Sistemas de Informacion en Medicamentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents mnuPrincipal As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuPrincipalSalir As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuMaestros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuMaestrosMedicos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuMaestrosMedicamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcedenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuUtilidades As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuExcel As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuWord As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAcercaModulo As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcedenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaterialesEnviadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeInformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeResultadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColpocitologíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorMedicoSolicitanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorInformesRealizadosPorPacientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportePorDiagnosticosRealizadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuPrincipalLogin As System.Windows.Forms.ToolStripMenuItem

End Class
