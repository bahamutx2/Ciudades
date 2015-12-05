<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="Ciudad.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="pnMenuSesi">
        <center>
        <asp:Label runat="server">Usuario</asp:Label><br />
        <asp:TextBox runat="server" ID="tbUser"></asp:TextBox><br /><br />

        <asp:Label ID="Label1" runat="server">Contraseña</asp:Label><br />
        <asp:TextBox runat="server" ID="tbPass" TextMode="Password"></asp:TextBox><br /><br /><br />

        <asp:Button runat="server" ID="btnIniciarSesion" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion"/><br />
            <asp:Label ID="ResponseNo" runat="server" Visible="false" CssClass="lbError">Error al iniciar sesión</asp:Label>
            </center>

        
    </asp:Panel>
</asp:Content>
