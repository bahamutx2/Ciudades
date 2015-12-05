<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Ciudad.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="pnMostrar">
        <h1><asp:Label runat="server" ID="denuncia">Ver multimedia</asp:Label></h1>
        <div runat="server" id="divMostrar" width="20%">

        </div>
    </asp:Panel>

    <a class="sharebutton" type="button" href="http://www.facebook.com/sharer.php" target="_blank">Compatir</a>  
</asp:Content>
