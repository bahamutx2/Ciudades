<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Sitio.aspx.cs" Inherits="Ciudad.Formulario_web11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="up" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <fieldset>
                <asp:Panel runat="server" CssClass="pnFiltros">
                    <asp:Panel runat="server" CssClass="pnFiltro">
                        <asp:Label runat="server">Sector</asp:Label>
                        <asp:DropDownList runat="server" ID="ddlSector">
                        </asp:DropDownList>
                    </asp:Panel>
                    <asp:Panel ID="Panel1" runat="server" CssClass="pnFiltro">
                        <asp:Label ID="Label1" runat="server">Fecha</asp:Label>
                        <asp:TextBox runat="server" ID="tbFecha" Type="Date">

                        </asp:TextBox>
                    </asp:Panel>
                    <asp:Panel ID="Panel2" runat="server" CssClass="pnFiltro">
                        <asp:Button runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" Text="Buscar"></asp:Button>
                    </asp:Panel>
                </asp:Panel>
                
                <asp:Panel runat="server" CssClass="pnResultados">
                    <asp:GridView ID="gvDenuncias" runat="server" CssClass="gvResultados" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="nombreSector" HeaderText="Sector" ReadOnly="True" />
                            <asp:BoundField DataField="fecha" HeaderText="Fecha" ReadOnly="True" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" ReadOnly="True" />
                            <asp:BoundField DataField="link" HeaderText="Vinculo" ReadOnly="True" HtmlEncode="false" />
                            <asp:BoundField DataField="linkb" HeaderText="Acciones" ReadOnly="True" HtmlEncode="false" />
                        </Columns>
                        <EmptyDataTemplate>No hay resultados</EmptyDataTemplate>
                    </asp:GridView>
                </asp:Panel>


            </fieldset>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnBuscar" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
