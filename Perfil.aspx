<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Ciudad.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="Panel1" runat="server" CssClass="pnMenuSesi">
        <center>
        <h3>Cambiar contraseña</h3>
        <asp:Label runat="server">Contraseña actual</asp:Label><br />
        <asp:TextBox runat="server" ID="pwdActual"  TextMode="Password"></asp:TextBox><br /><br />

        <asp:Label ID="Label2" runat="server">Contraseña nueva</asp:Label><br />
        <asp:TextBox runat="server" ID="pwdN1" TextMode="Password"></asp:TextBox><br /><br />

        <asp:Label ID="Label1" runat="server">Verificar Contraseña nueva</asp:Label><br />
        <asp:TextBox runat="server" ID="pwdN2" TextMode="Password"></asp:TextBox><br /><br /><br />

        <asp:Button runat="server" ID="btnCambiarPwd" OnClick="btnCambiarPwd_Click" Text="Cambiar contraseña"/><br />
            <asp:Label ID="Respons" runat="server" Visible="true" CssClass="lbError"></asp:Label>
         </center>
        
    </asp:Panel>
</asp:Content>
