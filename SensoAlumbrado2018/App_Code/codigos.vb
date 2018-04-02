Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Namespace utilidades

    Public Class listas

        Public Shared Sub listaColonias(colonias As DropDownList)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim adapter As SqlDataAdapter
            Dim dt As DataTable = New DataTable

            Try
                conn.Open()
                query = "SELECT DISTINCT colonia FROM datosColonias ORDER BY colonia asc"
                cmd = New SqlCommand(query, conn)
                adapter = New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error con la conexion a la base de datos.", MsgBoxStyle.Critical, "Error en la conexion")
            Finally
                conn.Close()
            End Try

            colonias.DataTextField = "colonia"
            colonias.DataSource = dt
            colonias.DataBind()
            colonias.Items.Insert(0, New ListItem("SELECCIONE UNA POBLACION...", "0"))

        End Sub

        Public Shared Sub listaSector(sector As DropDownList)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim adapter As SqlDataAdapter
            Dim dt As DataTable = New DataTable

            Try
                conn.Open()
                query = "SELECT idSector, nombreSector FROM sectores"
                cmd = New SqlCommand(query, conn)
                adapter = New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            Catch ex As Exception
                MsgBox("Ha ocurrido un error con la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try

            sector.DataTextField = "nombreSector"
            sector.DataValueField = "idSector"
            sector.DataSource = dt
            sector.DataBind()
            sector.Items.Insert(0, New ListItem("SELECCIONE UN SECTOR...", "0"))
        End Sub
    End Class

    Public Class tablas

        Public Shared Sub sector1(tablaSector1 As GridView)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            Dim dt As DataTable = New DataTable

            query = "SELECT colonia AS 'COLONIA', sector AS 'SECTOR', tension AS 'TENSIÓN', periodoEjecucionCenso AS 'PERIODO DE EJECUCIÓN', "
            query += " cantidadLamparas AS 'CANTIDAD DE LAMPARAS', lugares AS 'LUGAR' FROM datosColonias WHERE sector = 1 "
            Try
                conn.Open()
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    dt.Load(reader)
                    tablaSector1.DataSource = dt
                    tablaSector1.DataBind()
                    tablaSector1.Visible = True
                Else
                    MsgBox("No se han encontrado resultados.", MsgBoxStyle.Information, "Error en la conexion")
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try
        End Sub

        Public Shared Sub sector2(tablaSector2 As GridView)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            Dim dt As DataTable = New DataTable

            query = "SELECT colonia AS 'COLONIA', sector AS 'SECTOR', tension AS 'TENSIÓN', periodoEjecucionCenso AS 'PERIODO DE EJECUCIÓN', "
            query += " cantidadLamparas AS 'CANTIDAD DE LAMPARAS', lugares AS 'LUGAR' FROM datosColonias WHERE sector = 2 "
            Try
                conn.Open()
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    dt.Load(reader)
                    tablaSector2.DataSource = dt
                    tablaSector2.DataBind()
                    tablaSector2.Visible = True
                Else
                    MsgBox("No se han encontrado resultados.", MsgBoxStyle.Information, "Error en la conexion")
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try
        End Sub

        Public Shared Sub sector3(tablaSector3 As GridView)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            Dim dt As DataTable = New DataTable

            query = "SELECT colonia AS 'COLONIA', sector AS 'SECTOR', tension AS 'TENSIÓN', periodoEjecucionCenso AS 'PERIODO DE EJECUCIÓN', "
            query += " cantidadLamparas AS 'CANTIDAD DE LAMPARAS', lugares AS 'LUGAR' FROM datosColonias WHERE sector = 3 "
            Try
                conn.Open()
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    dt.Load(reader)
                    tablaSector3.DataSource = dt
                    tablaSector3.DataBind()
                    tablaSector3.Visible = True
                Else
                    MsgBox("No se han encontrado resultados.", MsgBoxStyle.Information, "Error en la conexion")
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try
        End Sub

        Public Shared Sub sector4(tablaSector4 As GridView)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            Dim dt As DataTable = New DataTable

            query = "SELECT colonia AS 'COLONIA', sector AS 'SECTOR', tension AS 'TENSIÓN', periodoEjecucionCenso AS 'PERIODO DE EJECUCIÓN', "
            query += " cantidadLamparas AS 'CANTIDAD DE LAMPARAS', lugares AS 'LUGAR' FROM datosColonias WHERE sector = 4 "
            Try
                conn.Open()
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    dt.Load(reader)
                    tablaSector4.DataSource = dt
                    tablaSector4.DataBind()
                    tablaSector4.Visible = True
                Else
                    MsgBox("No se han encontrado resultados.", MsgBoxStyle.Information, "Error en la conexion")
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try
        End Sub

        Public Shared Sub sector5(tablaSector5 As GridView)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            Dim dt As DataTable = New DataTable

            query = "SELECT colonia AS 'COLONIA', sector AS 'SECTOR', tension AS 'TENSIÓN', periodoEjecucionCenso AS 'PERIODO DE EJECUCIÓN', "
            query += " cantidadLamparas AS 'CANTIDAD DE LAMPARAS', lugares AS 'LUGAR' FROM datosColonias WHERE sector = 5 "
            Try
                conn.Open()
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    dt.Load(reader)
                    tablaSector5.DataSource = dt
                    tablaSector5.DataBind()
                    tablaSector5.Visible = True
                Else
                    MsgBox("No se han encontrado resultados.", MsgBoxStyle.Information, "Error en la conexion")
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try
        End Sub

        Public Shared Sub sector6(tablaSector6 As GridView)
            Dim conString As String = ConfigurationManager.ConnectionStrings("DBConn").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(conString)
            Dim query As String
            Dim cmd As SqlCommand
            Dim reader As SqlDataReader
            Dim dt As DataTable = New DataTable

            query = "SELECT colonia AS 'COLONIA', sector AS 'SECTOR', tension AS 'TENSIÓN', periodoEjecucionCenso AS 'PERIODO DE EJECUCIÓN', "
            query += " cantidadLamparas AS 'CANTIDAD DE LAMPARAS', lugares AS 'LUGAR' FROM datosColonias WHERE sector = 6 "
            Try
                conn.Open()
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    dt.Load(reader)
                    tablaSector6.DataSource = dt
                    tablaSector6.DataBind()
                    tablaSector6.Visible = True
                Else
                    MsgBox("No se han encontrado resultados.", MsgBoxStyle.Information, "Error en la conexion")
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error en la conexion a la base de datos.", MsgBoxStyle.Critical, "Error con conexion")
            Finally
                conn.Close()
            End Try
        End Sub

    End Class

End Namespace


