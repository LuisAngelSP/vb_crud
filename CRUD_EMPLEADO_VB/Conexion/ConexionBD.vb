Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Module ConexionBD
    Public conexion As New SqlConnection("Server=DESKTOP-DUJGV0C\SQLMASTER; Database = TB_PLANTILLA; Integrated Security=True;")

    Sub Abrir_Conexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    Sub Cerrar_Conexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub


End Module
