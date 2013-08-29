Imports System.Windows.Forms

Public Class FrmPrincipal
    Public objeto As Integer


    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
     
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
     
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

   

 

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
      
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub mnuPrincipalLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        FrmLogin.MdiParent = Me



        FrmLogin.Show()


    End Sub

    Private Sub mnuMaestrosClases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
   


    End Sub

    Private Sub mnuAcercaModulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        AboutBox1.MdiParent = Me




        AboutBox1.Show()


    End Sub

    Private Sub FrmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

  

 

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

 
    Private Sub mnuInventariosEntradas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuMaestrosEspecialidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub mnuMaestrosClases_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuMaestrosServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SeriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuMaestrosMedicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaestrosMedicos.Click

    End Sub

    Private Sub mnuMaestrosTerapeuticos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuMaestrosFarmacia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PresentacionesDeMedicamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuMaestrosMedicamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaestrosMedicamentos.Click
        FrmAnatomopatologia.Show()

    End Sub

    Private Sub ProcedenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuInventariosDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuInventariosGenconRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuRecetasRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExcel.Click
        Shell("calc", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWord.Click
        Shell("notepad", AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnuRecetaDevolu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
  
    End Sub

    Private Sub mnuPrincipalLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrincipalLogin.Click
           
    End Sub

    Private Sub mnuPrincipalSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrincipalSalir.Click
        Frmmedico.MdiParent = Me
        Frmmedico.Show()

    End Sub

    Private Sub mnuAcercaModulo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcercaModulo.Click
 
    End Sub

    Private Sub TiposDeDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrecuenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IngresosAlInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DevolucionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
  
    Private Sub mnuInventariosReportesExist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub mnuInventariosReportesKardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

 

    Private Sub mnuInventariosReportesMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuRecetaReportesMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub TurnosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub



    Private Sub mnuRecetasConsultasRec_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub mnuRecetasConsultasDev_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub mnuRecetasConsultasSol_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub ConsumosMensualesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)




    End Sub

    Private Sub DiivicionTerapeuticaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RegistroDeAnestesicosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ProcedenciasToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ProcedenciasToolStripMenuItem.Click
        FrmCitologiadeOrina.Show()
    End Sub

    Private Sub AreasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SubAreasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SeriesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TiposDeDocumentoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub FrecuenciasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MedicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TerapéuticoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SubTerapéuticoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PresentacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MedicamentosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TurnosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ProcedenciasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListaDeIngresDeMedicamentoInventarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListaDeEgresosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListaDeIngresoPorDevolucionDeServiciosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListaDeEgresosPorDevolucionDeServiciosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Sub ListaDePedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ReporteDeDemandaInsatisfechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub mnuRecetaUltimoDia_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CosolidadoDeCostosPorMedicamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MovimentosDelDiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ConsolidadoDeExistenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub ReporteAnestesicosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Forma3AToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub ReporteConsolidadoAnestesicosPorMedicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub IngresosYEgresosDeMedicamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub PresentacionesMedicasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

 
    Private Sub ExistenciasPorDiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AjusteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DemandaInsatisfechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub SalidasPorServiciosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub PedidosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ReporteDeMovimientosDeMedicamentosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ReporteNoPedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ReporteDeMinimosYMaximosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SeguridadMovimientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

 
  

  
    Private Sub ManualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManualToolStripMenuItem.Click
       
    End Sub

    Private Sub ProcedenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcedenciaToolStripMenuItem.Click

        Frmprocedencia.MdiParent = Me
        Frmprocedencia.Show()


    End Sub

    Private Sub MaterialesEnviadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaterialesEnviadosToolStripMenuItem.Click
        Frmmateriales.MdiParent = Me
        Frmmateriales.Show()


    End Sub

    Private Sub TipoDeInformesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoDeInformesToolStripMenuItem.Click
        Frminforme.MdiParent = Me
        Frminforme.Show()


    End Sub

    Private Sub TipoDeResultadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoDeResultadosToolStripMenuItem.Click
        Frmresultado.MdiParent = Me
        Frmresultado.Show()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Frmenfermedades.Show()


    End Sub

    Private Sub ColpocitologíaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColpocitologíaToolStripMenuItem.Click
        Frmcolpocitologia.Show()
    End Sub

    Private Sub ResultadosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ResultadosToolStripMenuItem1.Click
        Frmresultadoscolpocitologia.Show()
    End Sub

    Private Sub ResultadosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResultadosToolStripMenuItem.Click
        FrmCitologiadeotrasmuestras.Show()
    End Sub
End Class
