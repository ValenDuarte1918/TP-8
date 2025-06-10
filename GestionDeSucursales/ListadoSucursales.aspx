<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="GestionDeSucursales.ListadoSucursales" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Listado de Sucursales</title>
<link href="Styles/ListadoSucursal.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
                    <div class="links">
                <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                <asp:HyperLink ID="hlListadoSucursal" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
            </div>
        <div class="container">
            <div class="header">
                <h2>Listado de Sucursales</h2>
                <small>GRUPO Nº12</small>
            </div>
            <div class="search-bar">
                <label for="txtbBuscarSucursales" class="form-label">Búsqueda: Ingrese Id Sucursal</label>
                <asp:TextBox ID="txtbBuscarSucursales" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revIdSucursal" runat="server" ControlToValidate="txtbBuscarSucursales" ForeColor="#CC0000" ValidationExpression="^[0-9]+$" CssClass="form-text">Debe ingresar un ID válido</asp:RegularExpressionValidator>
                <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" CssClass="btn" OnClick="btnFiltrar_Click" />
                <asp:Button ID="btnMostrarTodo" runat="server" Text="Mostrar todo" CssClass="btn" OnClick="btnMostrarTodo_Click" />
            </div>
            <asp:Label ID="lblNoResultados" runat="server" CssClass="no-results"></asp:Label>
            <div class="gridview-container">
                <asp:GridView ID="gvSucursales" runat="server" AutoGenerateColumns="False" CssClass="aspNet-GridView">
                    <Columns>
                        <asp:TemplateField HeaderText="Id_Sucursal">
                            <ItemTemplate>
                                <asp:Label ID="lblIdSucursal" runat="server" Text='<%# Bind("Id_Sucursal") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre">
                            <ItemTemplate>
                                <asp:Label ID="lblNombreSucursal" runat="server" Text='<%# Bind("NombreSucursal") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripción">
                            <ItemTemplate>
                                <asp:Label ID="lblDescripcionSucursal" runat="server" Text='<%# Bind("DescripcionSucursal") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Provincia">
                            <ItemTemplate>
                                <asp:Label ID="lblProvinciaSucursal" runat="server" Text='<%# Bind("DescripcionProvincia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Dirección">
                            <ItemTemplate>
                                <asp:Label ID="lblDireccionSucursal" runat="server" Text='<%# Bind("DireccionSucursal") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>

