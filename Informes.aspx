<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="Ciudad.Formulario_web14" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Panel runat="server" CssClass="pnBotones">
        <asp:Chart ID="Chart1" runat="server" >
            <Titles>
                <asp:Title Font="Times New Roman, 12pt, style=Bold, Italic" Name="Title1" 
                    Text="Reporte de videos">
                </asp:Title>
            </Titles>
            <Series>
                <asp:Series Name="Series1" XValueMember="Estado" YValueMembers="Cantidad"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:Chart ID="Chart2" runat="server">
            <Titles>
                <asp:Title Font="Times New Roman, 12pt, style=Bold, Italic" Name="Title1" 
                    Text="Reporte de denuncias">
                </asp:Title>
            </Titles>
            <Series>
                <asp:Series Name="Series1" XValueMember="Estado" YValueMembers="Cantidad"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </asp:Panel>

    <asp:Panel runat="server" CssClass="pnBotones">
        <asp:Button ID="btnRepVi" runat="server" Text="Generar reporte de videos"  OnClick="btnRepVi_Click"/>
        <asp:Button ID="btnRepDe" runat="server" Text="Generar reporte de denuncias" OnClick="btnRepDe_Click" />
    </asp:Panel>
    
</asp:Content>

