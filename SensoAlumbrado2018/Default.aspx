<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Censo Alumbrado Publico 2018</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="Content/bootstrap-grid.css" type="text/css" rel="stylesheet" />
    <link href="Content/bootstrap-grid.min.css" type="text/css" rel="stylesheet" />
    <link href="Content/bootstrap-reboot.css" type="text/css" rel="stylesheet" />
    <link href="Content/bootstrap-reboot.min.css" type="text/css" rel="stylesheet" />
    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" type="text/css" rel="stylesheet" />
    <link href="Content/font-awesome.css" type="text/css" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" type="text/css" rel="stylesheet" />

    <script src="bootstrap.js"></script>
    <script src="bootstrap.min.js"></script>
    <script src="bootstrap.bundle.js"></script>
    <script src="bootstrap.bundle.min.js"></script>
    
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</head>
<body style="background-color: white;">
    <form id="form1" runat="server">

        <div class="container">
            <header>
                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xl-12">
                        <div class="jumbotron text-center">
                            <h1>Censo de Alumbrado Publico 2018</h1>
                        </div>
                    </div>
                </div>
            </header>
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-6 col-12-6 col-xl-6">
                        <div class="input-group">
                            <button runat="server" id="verTable" class="btn btn-block btn-success"><i class="fa fa-play"></i> Ver todo</button>
                        </div>
                    </div>

                    <div class="col-md-6 col-sm-12 col-xl-6">
                        <div class="input-group">
                            <button runat="server" id="addNew" class="btn btn-block btn-info"><i class="fa fa-plus"></i> Agregar</button>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="card border-dark">
                <div class="card-header bg-light">
                    <h4><i class="fa fa-filter"></i> Filtrar por </h4>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <asp:DropDownList runat="server" CssClass="form-control" ID="colonias"></asp:DropDownList>
                        </div>
                        <div class="col-md-4 col-sm-4 col-xs-12">
                            <asp:DropDownList runat="server" CssClass="form-control" ID="sector"></asp:DropDownList>
                        </div>
                        <div class="col-md-2 col-sm-2 col-xs-12 align-content-center">
                            <asp:Button runat="server" ID="llamarTabla" Text="Filtrar" CssClass="btn btn-success" />
                        </div>
                        <div class="col-md-2 col-sm-2 col-xs-12 align-content-center">
                            <asp:Button runat="server" ID="clear" Text="Limpiar" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="card" id="todoTabla" runat="server">
                <div class="card-header bg-success text-center">
                    <h2>Comisión Federal de Electricidad</h2>
                    <h3>División Golfo Centro</h3>
                    <h4>Resumen del censo de Alumbrado Publico 2018</h4>
                </div>
                <div class="card-body">
                    
                    <ul class="nav nav-tabs" role="tablist">
                        <li class="nav-item">
                            <a class="nav-link active" data-toggle="tab" href="#sector1">Sector 1</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" data-toggle="tab" href="#sector2">Sector 2</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" data-toggle="tab" href="#sector3">Sector 3</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" data-toggle="tab" href="#sector4">Sector 4</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" data-toggle="tab" href="#sector5">Sector 5</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" data-toggle="tab" href="#sector6">Sector 6</a>
                        </li>
                    </ul>
                    <br />
                    <div class="tab-content">
                        <div id="sector1" class="container tab-pane active">
                            <asp:GridView runat="server" CssClass="table" ID="tablaSector1">
                                <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                                <FooterStyle CssClass="text-center bg-light" />
                            </asp:GridView>
                        </div>
                        <div id="sector2" class="container tab-pane fade">
                            <asp:GridView runat="server" CssClass="table" ID="tablaSector2">
                                <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                                <FooterStyle CssClass="text-center bg-light" />
                            </asp:GridView>
                        </div>
                        <div id="sector3" class="container tab-pane fade">
                            <asp:GridView runat="server" CssClass="table" ID="tablaSector3">
                                <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                                <FooterStyle CssClass="text-center bg-light" />
                            </asp:GridView>
                        </div>
                        <div id="sector4" class="container tab-pane fade">
                            <asp:GridView runat="server" CssClass="table" ID="tablaSector4">
                                <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                                <FooterStyle CssClass="text-center bg-light" />
                            </asp:GridView>
                        </div>
                        <div id="sector5" class="container tab-pane fade">
                            <asp:GridView runat="server" CssClass="table" ID="tablaSector5">
                                <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                                <FooterStyle CssClass="text-center bg-light" />
                            </asp:GridView>
                        </div>
                        <div id="sector6" class="container tab-pane fade">
                            <asp:GridView runat="server" CssClass="table" ID="tablaSector6">
                                <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                                <FooterStyle CssClass="text-center bg-light" />
                            </asp:GridView>
                        </div>
                    </div>

                    <%--<div>
                        <asp:GridView runat="server" CssClass="table table-responsive" AllowPaging="true" PageSize="20" ID="datos">
                            <HeaderStyle CssClass="text-center bg-light" Wrap="false" />
                            <FooterStyle CssClass="text-center bg-light" />
                        </asp:GridView>
                        
                    </div>--%>
                </div>
            </div>
        </div>
        <br />
    </form>
</body>
</html>
