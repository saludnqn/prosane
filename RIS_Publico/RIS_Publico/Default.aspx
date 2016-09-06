<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RIS_Publico.Default" MasterPageFile="~/MInterconsultas.Master" UICulture="es" Culture="es-AR" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="Superior" runat="server">
    <script type="text/javascript" src='<%= ResolveUrl("~/ControlMenor/js/jquery-1.5.1.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/ControlMenor/js/jquery-ui-1.8.9.custom.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/ControlMenor/js/json2.js") %>'></script>
    <link href='<%= ResolveUrl("~/ControlMenor/css/redmond/jquery.ui.all.css") %>' rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="http://www.test.saludnqn.gob.ar/App_Themes/consultorio/ical.css" />
    <script type="text/javascript" src="http://www.test.saludnqn.gob.ar/js/jquery.ui.datepicker-es.js"></script>
    <script type="text/javascript" src="http://www.test.saludnqn.gob.ar/js/Mascara.js"></script>
    <script type="text/javascript" src="http://www.test.saludnqn.gob.ar/js/ValidaFecha.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 90px;
        }

        .auto-style5 {
            width: 139px;
        }

        .auto-style6 {
            width: 90px;
            height: 21px;
        }

        .auto-style7 {
            width: 139px;
            height: 21px;
        }

        .auto-style8 {
            height: 21px;
        }

        .auto-style9 {
            width: 90px;
            height: 47px;
        }

        .auto-style10 {
            width: 139px;
            height: 47px;
        }

        .auto-style11 {
            height: 47px;
        }

        .auto-style12 {
            font-size: xx-small;
        }
    </style>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="Cuerpo">
    <ol class="round">
        <li>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">Zona:</td>
                    <td>
                        <asp:DropDownList ID="ddlZona" runat="server" DataTextField="nombre"
                            DataValueField="idZona" TabIndex="8" Height="31px" Width="194px" AutoPostBack="True" OnSelectedIndexChanged="ddlZona_SelectedIndexChanged">
                            <asp:ListItem Value=""></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">Efector:</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlEfector" runat="server" DataTextField="nombre"
                            DataValueField="idEfector" TabIndex="8" Height="31px" Width="194px">
                            <asp:ListItem Value=""></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">Establecimiento:</td>
                    <td>
                        <asp:DropDownList ID="ddlEstablecimiento" runat="server" DataTextField="nombre"
                            DataValueField="idEstablecimiento" TabIndex="8" Height="31px" Width="260px">
                            <asp:ListItem Value=""></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">Alumno DNI:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDNI" runat="server" Width="133px" TabIndex="20"
                            Font-Size="Medium" Height="16px">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlBusca" runat="server" DataTextField="nombre"
                            DataValueField="idObraSocial" TabIndex="16" Height="29px" Width="179px">
                            <asp:ListItem Value="Total">Total</asp:ListItem>
                            <asp:ListItem Value="Obecidad">Obecidad</asp:ListItem>
                            <asp:ListItem Value="Sobrepeso">Sobrepeso</asp:ListItem>
                            <asp:ListItem Value="Oftalmologia">Oftalmologia</asp:ListItem>
                            <asp:ListItem Value="Fonoaudilogia">Fonoaudilogia</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Total de Pacientes"></asp:Label>
                        :&nbsp;
                            <asp:Label ID="lblTotal" runat="server" Style="font-weight: 700" Text="."></asp:Label>
                        &nbsp;<asp:Label ID="Label2" runat="server" Text="de"></asp:Label>
                        &nbsp;
                            <asp:Label ID="lblTotalGeneral" runat="server" Style="font-weight: 700" Text="."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:Button ID="btnBuscar" runat="server" CssClass="myButton" OnClick="btnBuscar_Click" TabIndex="4" Text="Buscar" ValidationGroup="0" Width="77px" />
                    </td>
                        <td style="text-align: right" class="auto-style11">
                        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="9pt" Font-Underline="True" ForeColor="Maroon" NavigateUrl="PacienteList.aspx" onclick="LinkNuevoPSM" TabIndex="9" ToolTip="Cargar nueva ficha">Nueva Ficha</asp:HyperLink>
                        &nbsp;&nbsp;&nbsp;<asp:Button ID="btn_Exportar" runat="server" OnClick="btn_Exportar_Click" Text="Exportar  Sumar" Visible="False" />
                        <asp:Button ID="btnExportarExecl" runat="server" CssClass="myButton" OnClick="btnExportarExecl_Click" TabIndex="4" Text="Exportar" ValidationGroup="0" Width="77px" Visible="False" />
                        <%--<asp:Button ID="btnAgrega" runat="server" CausesValidation="False" OnClick="btnAgrega_Click" Style="font-weight: 700" Text="Nuevo" Width="70px" Visible="False" />--%>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td style="text-align: right" class="auto-style12">22/10/2014</td>
                </tr>
            </table>
        </li>
        <li>
            <asp:GridView ID="gvListaFichasAlumnos" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                CellPadding="5" DataKeyNames="idProsame" EmptyDataText="No hay fichas que correspondan con los criterios de búsqueda utilizados. Verifique los datos ingresados e intente nuevamente."
                EnableTheming="True" Font-Bold="False" Font-Names="Arial" Font-Size="10pt"
                ForeColor="#333333" Width="100%"
                OnPageIndexChanging="gvListaFichasAlumnos_PageIndexChanging"
                OnRowCommand="gvListaFichasAlumnos_RowCommand"
                OnRowDataBound="gvListaFichasAlumnos_RowDataBound" Style="margin-top: 0px">
                <RowStyle BackColor="#F7F6F3" Font-Names="Arial" Font-Size="10pt"
                    ForeColor="#333333" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="Modificar" runat="server" ImageUrl="~/RIS_Publico/Images/edit.png"
                                CommandName="editarAlumno" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="idProsame" HeaderText="idProsame" Visible="False" />
                    <asp:BoundField DataField="DNIPaciente" HeaderText="DNI" />
                    <asp:BoundField DataField="nombrePaciente" HeaderText="Paciente" />
                    <asp:BoundField DataField="Nombre" HeaderText="Escuela" />
                    <asp:BoundField DataField="nombreEfector" HeaderText="Efector" />
                    <asp:BoundField DataField="nombreZona" HeaderText="Zona" />
                </Columns>
                <FooterStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#990000" ForeColor="White" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#333333" Font-Bold="False" Font-Italic="False"
                    Font-Names="Arial" Font-Size="10pt" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
        </li>
    </ol>
</asp:Content>


