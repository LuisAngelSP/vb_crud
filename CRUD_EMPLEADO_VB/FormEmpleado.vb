Imports System.Data.SqlClient



Public Class FormEmpleado

    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Abrir_Conexion()
        Mostrar()

        'MessageBox.Show("Conexion Creada", "Sistema Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Close()
    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ex = e.X
            ey = e.Y
            Arrastre = True
        End If
    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub PanelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        PanelDatos.Visible = True
        BtnAdd.Enabled = True
        BtnActualizar.Enabled = False
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        BtnAdd.Enabled = True
        BtnActualizar.Enabled = True
        PanelDatos.Visible = False
        limpiar()
    End Sub

    Private Sub Limpiar()
        TxtNombre.Clear()
        TextApellido.Clear()
        txtId.Clear()
        TxtSalario.Clear()
        TxtEdad.Clear()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim cmd As New SqlCommand
        If TxtNombre.Text <> "" And TxtSalario.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("INSERTAR", conexion)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text.ToString)
                cmd.Parameters.AddWithValue("@Apellido", TextApellido.Text.ToString)
                cmd.Parameters.AddWithValue("@Edad", TxtEdad.Text.ToString)
                cmd.Parameters.AddWithValue("@Salario", TxtSalario.Text.ToString)

                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                PanelDatos.Visible = False
                Limpiar()
                Mostrar()
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("LOS CAMPOS NOMBRES SON OBLIGATORIO", "Sistema Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("MOSTRAR", conexion)
            da.Fill(dt)
            DataList.DataSource = dt
            Cerrar_Conexion()

            DataList.Columns(0).Width = 20
            DataList.Columns(1).Width = 120
            DataList.Columns(2).Width = 120
            DataList.Columns(3).Width = 50
            DataList.Columns(4).Width = 100

        Catch ex As Exception

        End Try
    End Sub


    Sub Buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("BUSCAR", conexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@busqueda", TxtBuscar.Text)
            da.Fill(dt)
            DataList.DataSource = dt
            Cerrar_Conexion()

            DataList.Columns(0).Width = 20
            DataList.Columns(1).Width = 140
            DataList.Columns(2).Width = 140
            DataList.Columns(3).Width = 70
            DataList.Columns(3).Width = 100

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Buscar()
        PanelDatos.Visible = False
    End Sub

    Private Sub DataList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataList.CellContentDoubleClick
        PanelDatos.Visible = True
        Try
            Dim selectedRow As DataGridViewRow = DataList.Rows(e.RowIndex)

            txtId.Text = selectedRow.Cells(0).Value.ToString()
            TxtNombre.Text = selectedRow.Cells(1).Value.ToString()
            TextApellido.Text = selectedRow.Cells(2).Value.ToString()
            TxtEdad.Text = selectedRow.Cells(3).Value.ToString()
            TxtSalario.Text = selectedRow.Cells(4).Value.ToString()

            BtnAdd.Enabled = False
            BtnActualizar.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim cmd As New SqlCommand
        If TxtNombre.Text <> "" And TxtSalario.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("ACTUALIZAR", conexion)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Id", txtId.Text.ToString)
                cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text.ToString)
                cmd.Parameters.AddWithValue("@Apellido", TextApellido.Text.ToString)
                cmd.Parameters.AddWithValue("@Edad", TxtEdad.Text.ToString)
                cmd.Parameters.AddWithValue("@Salario", TxtSalario.Text.ToString)


                cmd.ExecuteNonQuery()
                Cerrar_Conexion()
                PanelDatos.Visible = False
                Limpiar()
                Mostrar()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("LOS CAMPOS NOMBRES SON OBLIGATORIO", "Sistema Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PanelDatos_Paint(sender As Object, e As PaintEventArgs) Handles PanelDatos.Paint

    End Sub
End Class
