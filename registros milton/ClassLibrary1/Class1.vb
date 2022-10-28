Imports System.Data.SqlClient

Public Class Class1
    Dim hack As New SqlConnection("server=localhost\SQLEXPRESS;integrated security=true;Database=usermilton")
    Public Function Listintegrantes() As DataTable
        Dim a As New SqlDataAdapter("pb_listas", hack)
        Dim b As New DataTable
        a.Fill(b)
        Return b

    End Function

    REM funcion para registrar 
    Public Function Insertar(id_a As String, nom As String, ape As String, dire As String, ema As String, fecha_ing As Date, regist As Char)
        Dim ha As New SqlCommand("pb_nuevo", hack)
        ha.CommandType = CommandType.StoredProcedure
        ha.Parameters.AddWithValue("@id", id_a)
        ha.Parameters.AddWithValue("@nombre", nom)
        ha.Parameters.AddWithValue("@apellido", ape)
        ha.Parameters.AddWithValue("@direccion", dire)
        ha.Parameters.AddWithValue("@email", ema)
        ha.Parameters.AddWithValue("@fechaing", fecha_ing)
        ha.Parameters.AddWithValue("@reg", regist)
        hack.Open()
        Dim resp As Integer
        Try
            resp = ha.ExecuteNonQuery
            hack.Close()

        Catch ex As Exception
            MsgBox("Error al registrar usuario")

        End Try
        Return resp

    End Function
    Public Function Eliminar(codigo As String)
        Dim elim As New SqlCommand("pb_eliminar", hack)
        elim.CommandType = CommandType.StoredProcedure
        elim.Parameters.AddWithValue("@codigo", codigo)
        hack.Open()
        Dim elim1 As String = elim.ExecuteNonQuery
        hack.Close()
        Return elim1
    End Function
    Public Function Modificar(codigo As String, id As String, nombre As String, apellido As String, direccion As String, email As String, fechaing As Date, reg As Char) As Integer

        REM
        Dim lo As New SqlCommand("pb_modificar", hack)
        lo.CommandType = CommandType.StoredProcedure
        lo.Parameters.AddWithValue("@codigo", codigo)
        lo.Parameters.AddWithValue("@id", id)
        lo.Parameters.AddWithValue("@nombre", nombre)
        lo.Parameters.AddWithValue("@apellido", apellido)
        lo.Parameters.AddWithValue("@direccion", direccion)
        lo.Parameters.AddWithValue("@email", email)
        lo.Parameters.AddWithValue("@fechaing", fechaing)
        lo.Parameters.AddWithValue("@reg", reg)
        hack.Open()
        Dim actu1 As String = lo.ExecuteNonQuery
        hack.Close()
        Return actu1
    End Function

End Class
