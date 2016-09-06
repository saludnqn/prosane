<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/mPaciente.Master"
    CodeBehind="PacienteList.aspx.cs" Inherits="SIPS.Paciente.PacienteList" Theme="Login" %>

<asp:Content ID="content1" ContentPlaceHolderID="head" runat="server">
    <link href="../App_Themes/default/estiloAcordion.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.6.2.min.js" type="text/javascript"></script>
    <script src="../js/Format.js" type="text/javascript"></script>
</asp:Content>
<%--<asp:Content ID="content4" ContentPlaceHolderID="Superior" runat="server">
    Búsqueda e Identificación del Paciente
</asp:Content>--%>
<asp:Content ID="content2" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div style="clear: both;">
        <ul id="acc">
            <li style="margin-top: 6px;">
                <h3>
                    Búsqueda de Pacientes</h3>
                <div class="acc-section">
                    <div class="acc-content" style="width: 782px">
                        <asp:Panel ID="Panel1" runat="server" Width="98%" Style="margin-top: 6px;" DefaultButton="btnBuscar">
                            <asp:UpdatePanel ID="upPanel1" runat="server">
                                <ContentTemplate>
                                    <table width="100%">
                                        <tr>
                                            <td>
                                                Documento:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDni" runat="server" MaxLength="9" CssClass="boxcortos" ToolTip="Solo números"
                                                    TabIndex="1"></asp:TextBox>
                                                <asp:CompareValidator ID="cvNDocumento" runat="server" ErrorMessage="Solo numeros" 
                                                    ControlToValidate="txtDni" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                            </td>
                                            <td align="justify">
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Fecha de Nac.:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFecNacBusqueda" runat="server" CssClass="boxcortos" onblur="javascript:formatearFecha(this)"
                                                    TabIndex="2"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Apellido:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtApellidoBusqueda" runat="server" TabIndex="3"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Nombre:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNombreBusqueda" runat="server" TabIndex="4"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                &nbsp;
                                                <hr />
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                <h2>
                                                    Datos de la Madre/Tutor</h2>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Número Doc:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDocMadre" runat="server" TabIndex="5" CssClass="boxcortos" ToolTip="Ingrese el número de documento de la Madre"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Apellido (Soltera):
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtApellidoMadreBusqueda" runat="server" TabIndex="6"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Nombre:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNombreMadreBusqueda" runat="server" TabIndex="7"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                &nbsp;
                                                <hr />
                                                &nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                            </td>
                                            <td align="center">
                                                <div class="botones">
                                                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"
                                                        TabIndex="8" /><br />
                                                </div>
                                            </td>
                                            <td align="center">
                                                <div class="botones">
                                                    <asp:Button ID="btnNuevo" runat="server" Text="Ingresar Nuevo" OnClick="btnNuevo_Click"
                                                        ToolTip="Ingresar un nuevo Paciente" TabIndex="9" />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                <div>
                                                    Referencia de Estados:
                                                    <asp:Image ID="imgReferencia" runat="server" ImageUrl="~/App_Themes/default/img/ref.png" /><br />
                                                    <asp:Label ID="lblMensajeBusqueda" CssClass="lblmsn" Text="" runat="server"></asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                    <div>
                                        <h2>
                                            Padrón Unico de Pacientes</h2>
                                        <asp:GridView ID="gvPacientes" runat="server" CssClass="mGrid" GridLines="None" PagerStyle-CssClass="pgr"
                                            AlternatingRowStyle-CssClass="alt" AutoGenerateColumns="False" OnSorting="gridView_Sorting"
                                            AllowPaging="True" OnPageIndexChanging="gvPacientes_PageIndexChangind" EmptyDataText="<b>No se encontraron datos.</b>"
                                            OnRowDataBound="gvPacientes_RowDataBound">
                                            <Columns>
                                                <asp:BoundField DataField="numeroDocumento" HeaderText="Nro Doc" />
                                                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                                <asp:BoundField DataField="historiaClinica" HeaderText="HC" />
                                                <asp:BoundField DataField="sexo" HeaderText="Sexo" />
                                                <asp:BoundField DataField="fechaNacimiento" DataFormatString="{0:dd/MM/yyy}" HeaderText="Fec.Nac" />
                                                <%--<asp:BoundField DataField="cronico" HeaderText="PC" />--%>
                                                <asp:HyperLinkField DataNavigateUrlFields="idPaciente" DataNavigateUrlFormatString="~/Paciente/PacienteView.aspx?id={0}"
                                                    HeaderText="Ver" Text="Ver" />
                                                <asp:HyperLinkField DataNavigateUrlFields="idPaciente" DataNavigateUrlFormatString="~/Paciente/PacienteEdit.aspx?id={0}"
                                                    HeaderText="Editar" Text="Editar" />
                                            </Columns>
                                            <PagerStyle CssClass="pgr" />
                                            <AlternatingRowStyle CssClass="alt" />
                                        </asp:GridView>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                        <%--</ajax:ajaxpanel>--%>
                    </div>
                </div>
            </li>
            <li style="margin-top: 6px;">
                <h3>
                    Padrón de Obras Sociales</h3>
                <div class="acc-section">
                    <div class="acc-content" style="width: 782px">
                        <asp:Panel ID="Panel2" runat="server" Width="98%" Style="margin-top: 6px;">
                            <asp:UpdatePanel ID="upPanel2" runat="server">
                                <ContentTemplate>
                                    <%--<ajax:ajaxpanel id="AjaxPanel2" runat="server" width="98%" style="margin-top: 6px;">--%>
                                    <div style="overflow: auto; width: 100%; scrollbars: Both">
                                        <asp:GridView ID="gvPersonas" runat="server" CssClass="mGrid" GridLines="None" PagerStyle-CssClass="pgr"
                                            AlternatingRowStyle-CssClass="alt" AutoGenerateColumns="false" EmptyDataText="No se encontraron datos."
                                            PageSize="10" AllowPaging="True" OnPageIndexChanging="gvPersonas_PageIndexChangind">
                                            <Columns>
                                                <asp:BoundField DataField="tipoDocumento" HeaderText="Tipo" />
                                                <asp:BoundField DataField="Documento" HeaderText="Número" />
                                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                                <asp:BoundField DataField="ObraSocial" HeaderText="Obra Social" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                        <%--</ajax:ajaxpanel>--%>
                    </div>
                </div>
            </li>
            <li style="margin-top: 6px;">
                <h3>
                    Histórico</h3>
                <div class="acc-section">
                    <div class="acc-content" style="width: 782px">
                        <asp:Panel ID="Panel3" runat="server" Width="98%" Style="margin-top: 6px;">
                            <asp:UpdatePanel ID="upPanel3" runat="server">
                                <ContentTemplate>
                                    <%--<ajax:ajaxpanel id="AjaxPanel1" runat="server" width="98%" style="margin-top: 6px;">--%>
                                    <div style="width: 100%">
                                        <asp:GridView ID="gvPadronPaciente" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron datos."
                                            AllowPaging="True" OnPageIndexChanging="gvPadronPaciente_PageIndexChanging" CellPadding="4"
                                            ForeColor="#333333" GridLines="None" Width="99%">
                                            <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                                            <Columns>
                                                <asp:BoundField DataField="numeroDocumento" HeaderText="Documento" />
                                                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                                <asp:BoundField DataField="FecNac" HeaderText="Fecha Nac." />
                                            </Columns>
                                            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                            <EditRowStyle BackColor="#999999" />
                                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                        </asp:GridView>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                    </div>
                </div>
            </li>
        </ul>
        <script type="text/javascript" src="../js/scriptAcordion.js"></script>
        <script language="javascript" type="text/javascript">
            var parentAccordion = new TINY.accordion.slider("parentAccordion");
            parentAccordion.init("acc", "h3", false, 0);
        </script>
    </div>
</asp:Content>
