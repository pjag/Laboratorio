Public Class FrmLogin

    Private Sub cmdIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click
        Try
            Dim resul As Object

            resul = Me.HG_USUARIOSTableAdapter.FillBy2(Me.SEGURIDADDataSet.HG_USUARIOS, txtUsuario.Text.ToUpper, txtPassword.Text.ToUpper, cmbCodigoEmpresa.SelectedValue)
            If resul = 1 Then

                Empresa = cmbCodigoEmpresa.SelectedValue
                usuario = txtUsuario.Text.ToUpper
                FrmPrincipal.Show()
                Servidor = "(Local)"
                
                Me.Hide()
            Else
                Me.txtPassword.Text = ""
                Me.txtPassword.Focus()
                MessageBox.Show("El password no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        End
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmLogin_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDADDataSet.HG_EMPRESAS' Puede moverla o quitarla según sea necesario.
        Me.HG_EMPRESASTableAdapter.Fill(Me.SEGURIDADDataSet.HG_EMPRESAS)
        'TODO: esta línea de código carga datos en la tabla 'SEGURIDADDataSet.HG_USUARIOS' Puede moverla o quitarla según sea necesario.
        Me.HG_USUARIOSTableAdapter.Fill(Me.SEGURIDADDataSet.HG_USUARIOS)


     


    End Sub

    Private Sub txtUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.LostFocus
        Try
            Dim resul As Object
            Dim result As Object
            resul = Me.HG_USUARIOSTableAdapter.FillBy1(Me.SEGURIDADDataSet.HG_USUARIOS, cmbCodigoEmpresa.SelectedValue, txtUsuario.Text.ToUpper)
            If resul = 1 Then

                result = Me.SEGURIDADDataSet.HG_USUARIOS.FindByUSR_EMPRESAUSR_USUARIO(cmbCodigoEmpresa.SelectedValue, txtUsuario.Text).Item(4)
                TxtDepto.Text = result.ToString
            Else
                TxtDepto.Text = ""
                MessageBox.Show("Usuario no esta registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en Conexion favor verificar con su administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

 
   


End Class
