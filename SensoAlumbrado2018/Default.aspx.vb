Imports System.Data.SqlClient
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        todoTabla.Visible = False
        utilidades.listas.listaColonias(colonias)
        utilidades.listas.listaSector(sector)
    End Sub

    Protected Sub verTable_Click(sender As Object, e As EventArgs) Handles verTable.ServerClick
        todoTabla.Visible = True
        utilidades.tablas.sector1(tablaSector1)
        utilidades.tablas.sector2(tablaSector2)
        utilidades.tablas.sector3(tablaSector3)
        utilidades.tablas.sector4(tablaSector4)
        utilidades.tablas.sector5(tablaSector5)
        utilidades.tablas.sector6(tablaSector6)
    End Sub

End Class
