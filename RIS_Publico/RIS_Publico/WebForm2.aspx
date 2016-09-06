<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs"
    Inherits="RIS_Publico.Default" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <p class="auto-style1">
        <strong style="font-size: large">Paciente Cargado</strong></p>
    <p>
            <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" onclick="btnGuardar_Click"   TabIndex="64" Text="Aceptar" ToolTip="Guardar datos" ValidationGroup="0" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            font-size: x-small;
        }
    </style>
</asp:Content>


