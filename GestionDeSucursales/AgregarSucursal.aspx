<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="GestionDeSucursales.AgregarSucursal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Agregar Sucursal</title>
<link href="Styles/AgregarSucursal.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="links">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
        </div>
        <div class="container">
            <div class="header">
                <h2>Agregar Sucursal</h2>
                <small>GRUPO Nº12</small>
            </div>
            <div class="form-group">
                <label for="txtNombreSucursal" class="form-label">Nombre sucursal:</label>
                <asp:TextBox ID="txtNombreSucursal" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ForeColor="Red" CssClass="form-text">Debe ingresar un nombre de sucursal</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="txtDescripcion" class="form-label">Descripción:</label>
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDescripción" runat="server" ControlToValidate="txtDescripcion" ForeColor="Red" CssClass="form-text">Debe ingresar una descripción</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="ddlProvincia" class="form-label">Provincia:</label>
                <asp:DropDownList ID="ddlProvincia" runat="server" CssClass="form-select" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="La Provincia debe seleccionarse" ForeColor="Red" InitialValue="0" CssClass="form-text"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="TxtDireccion" class="form-label">Dirección:</label>
                <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="TxtDireccion" ErrorMessage="La Direccion es Obligatoria" ForeColor="Red" CssClass="form-text"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblMensaje" runat="server" CssClass="form-text"></asp:Label>
            </div>
            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" CssClass="btn" />
        </div>
    </form>
</body>
</html>

