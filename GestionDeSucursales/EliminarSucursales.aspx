<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="GestionDeSucursales.EliminarSucursales" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Eliminar Sucursal</title>
<link href="Styles/EliminarSucursal.css" rel="stylesheet" type="text/css" />
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
                <h2>Eliminar Sucursal</h2>
                <small>GRUPO Nº12</small>
            </div>
            <div class="form-group">
                <label for="txtEliminar" class="form-label">Ingresar ID Sucursal:</label>
                <asp:TextBox ID="txtEliminar" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="revIdSucursalIng" runat="server" ControlToValidate="txtEliminar" ForeColor="#CC0000" CssClass="form-text">Se debe ingresar un ID</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revidSucursalOnlyNum" runat="server" ControlToValidate="txtEliminar" ValidationExpression="^\d+$" ForeColor="#CC0000" CssClass="form-text">Se debe ingresar un ID válido</asp:RegularExpressionValidator>
            </div>
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn" OnClick="btnEliminar_Click" />
            <asp:Label ID="lblEstasSeguro" runat="server" Visible="False" CssClass="message"></asp:Label>
            <div class="btn-group">
                <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" Visible="False" CssClass="btn" />
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" Visible="False" CssClass="btn" />
            </div>
            <asp:Label ID="lblMensaje" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>

