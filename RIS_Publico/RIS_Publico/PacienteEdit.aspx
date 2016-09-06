<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/mPaciente.Master"
    CodeBehind="PacienteEdit.aspx.cs" Inherits="SIPS.Paciente.PacienteEdit" ValidateRequest="false"
    Theme="Login" %>

<%@ Register Assembly="Subsonic" Namespace="SubSonic" TagPrefix="subsonic" %>
<%--<%@ Register Assembly="MagicAjax" Namespace="MagicAjax.UI.Controls" TagPrefix="ajax" %>--%>
<%@ Register Src="~/UserControls/ObrasSociales.ascx" TagName="OSociales" TagPrefix="uc1" %>
<%@ Register Src="~/UserControls/PacienteProvincial.ascx" TagPrefix="uc1" TagName="PacienteProvincial" %>

<asp:Content ID="content1" ContentPlaceHolderID="head" runat="server">
    <link href="../App_Themes/default/estiloAcordion.css" rel="stylesheet" type="text/css" />
    <script src="../js/Format.js" type="text/javascript"></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/ControlMenor/js/jquery-1.5.1.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/ControlMenor/js/jquery-ui-1.8.9.custom.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/ControlMenor/js/json2.js") %>'></script>
    <link href='<%= ResolveUrl("~/ControlMenor/css/redmond/jquery.ui.all.css") %>' rel="stylesheet"
        type="text/css" />
</asp:Content>
<asp:Content ID="content3" ContentPlaceHolderID="Superior" runat="server">
    Datos de Identificación del Paciente
</asp:Content>
<asp:Content ID="content2" ContentPlaceHolderID="Cuerpo" runat="server">
<asp:ScriptManager ID="scriptMgr" runat="server">
    </asp:ScriptManager>
    <table><tr>
        <td style="vertical-align: top"><div style="clear: both;">
        <ul id="acc">
            <li style="margin-top: 6px;">
                <h3>
                    Datos Principales
                </h3>
                <div class="acc-section">
                    <div class="acc-content" style="width: 782px">
                        <table class="tabla3">
                            <tr>
                                <td>
                                    Estado:
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlEstadoP" runat="server" TabIndex="1" OnSelectedIndexChanged="ddlEstadoP_SelectedIndexChanged"
                                        AutoPostBack="true" DataValueField="idEstado" DataTextField="nombre">
                                    </asp:DropDownList>
                                    Motivo NI:
                                    <asp:DropDownList ID="ddlMotivoNI" runat="server" TabIndex="2" OnSelectedIndexChanged="ddlMotivoNI_SelectedIndexChanged"
                                        AutoPostBack="true" DataValueField="idMotivoNI" ToolTip="Seleccione el Motivo de No Identificación"
                                        DataTextField="nombre">
                                    </asp:DropDownList>
                                </td>
                                <td>
                <asp:Button ID="btnSintys" runat="server" onclick="btnSintys_Click" 
    Text="Validar Sintys" /></td>
                            </tr>
                            <tr>
                                <td>
                                    DU:
                                </td>
                                <td>
                                    <asp:HiddenField ID="hfIdPaciente" runat="server" Value="0" />
                                    <asp:TextBox ID="txtNumeroDocumento" CssClass="boxcortos" MaxLength="9" BorderColor="#268fb8"
                                        TabIndex="3" runat="server" ToolTip="Solo números" AutoPostBack="true" OnTextChanged="VerificarNumeroDoc"></asp:TextBox><asp:CompareValidator
                                            ID="cvNroDoc" runat="server" ErrorMessage="Solo numeros" ControlToValidate="txtNumeroDocumento"
                                            Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                                    <asp:RequiredFieldValidator ID="rfvDI" runat="server" ControlToValidate="txtNumeroDocumento"
                                        Display="Dynamic" ErrorMessage="Documento" SetFocusOnError="true" ValidationGroup="I">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfvDV" runat="server" ControlToValidate="txtNumeroDocumento"
                                        Display="Dynamic" ErrorMessage="Documento" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                    <asp:Label ID="lblDuplicado" runat="server"></asp:Label>
                                    <asp:Label ID="lblExtranjero" runat="server"></asp:Label>
                                    <asp:TextBox ID="txtNumeroExtranjero" CssClass="boxcortos" Visible="false" MaxLength="10"
                                        BorderColor="#268fb8" runat="server" ToolTip="Ingrese el Número de Identificación Extranjero" />
                                    <asp:RequiredFieldValidator ID="rfvExt" runat="server" ControlToValidate="txtNumeroExtranjero"
                                        Display="Dynamic" ErrorMessage="Documento Extranjero" SetFocusOnError="true"
                                        ValidationGroup="TE">*</asp:RequiredFieldValidator>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:HyperLink ID="hlkHClinica" runat="server" ForeColor="DarkGreen">Registrar Nro. de Historia Clínica</asp:HyperLink>
                                    <asp:Panel ID="Msn" runat="server">
                                        <div>
                                            <asp:Label ID="lblMensaje" CssClass="lblmsn" Style="float: none; position: static;
                                                padding-top: 10px;" runat="server"></asp:Label>
                                        </div>
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Apellido:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtApellido" runat="server" CssClass="boxlargos" BorderColor="#268fb8"
                                        TabIndex="4"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvI" runat="server" ControlToValidate="txtApellido"
                                        Display="Dynamic" ErrorMessage="Apellido" SetFocusOnError="true" ValidationGroup="I">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfvV" runat="server" ControlToValidate="txtApellido"
                                        Display="Dynamic" ErrorMessage="Apellido" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfvT" runat="server" ControlToValidate="txtApellido"
                                        Display="Dynamic" ErrorMessage="Apellido" SetFocusOnError="true" ValidationGroup="T">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfvTExt" runat="server" ControlToValidate="txtApellido"
                                        Display="Dynamic" ErrorMessage="Apellido" SetFocusOnError="true" ValidationGroup="TE">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfvTBB" runat="server" ControlToValidate="txtApellido"
                                        Display="Dynamic" ErrorMessage="Apellido" SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                    &nbsp;&nbsp;&nbsp;<%--<asp:Label ID="lblNombres" runat="server" CssClass="lbl" Visible="false"></asp:Label>--%></td>
                            </tr>
                            <tr>
                                <td>
                                    Nombre:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtNombre" runat="server" CssClass="boxlargos" BorderColor="#268fb8"
                                        TabIndex="5"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfv4I" runat="server" ControlToValidate="txtNombre"
                                        ErrorMessage="Nombre" Display="Dynamic" SetFocusOnError="true" ValidationGroup="I">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv4V" runat="server" ControlToValidate="txtNombre"
                                        ErrorMessage="Nombre" Display="Dynamic" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv4T" runat="server" ControlToValidate="txtNombre"
                                        ErrorMessage="Nombre" Display="Dynamic" SetFocusOnError="true" ValidationGroup="T">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv4TExt" runat="server" ControlToValidate="txtNombre"
                                        ErrorMessage="Nombre" Display="Dynamic" SetFocusOnError="true" ValidationGroup="TE">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv4TBB" runat="server" ControlToValidate="txtNombre"
                                        ErrorMessage="Nombre" Display="Dynamic" SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                    &nbsp;&nbsp;&nbsp; Sexo:<subsonic:DropDown ID="ddlSexo" runat="server" OrderField="idSexo"
                                        PromptText="Seleccionar el Sexo" ShowPrompt="true" TabIndex="6" TableName="Sys_Sexo"
                                        TextField="nombre">
                                    </subsonic:DropDown>
                                    <asp:RequiredFieldValidator ID="rfv5I" runat="server" ControlToValidate="ddlSexo"
                                        ErrorMessage="Sexo" SetFocusOnError="true" ValidationGroup="I">*</asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="rvs1" runat="server" ErrorMessage="Debe seleccionar Masculino o Femenino"
                                        ControlToValidate="ddlSexo" MinimumValue="2" MaximumValue="3" ValidationGroup="I">*</asp:RangeValidator>
                                    <asp:RequiredFieldValidator ID="rfv5V" runat="server" ControlToValidate="ddlSexo"
                                        ErrorMessage="Sexo" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="rvs2" runat="server" ErrorMessage="Debe seleccionar Masculino o Femenino"
                                        ControlToValidate="ddlSexo" MinimumValue="2" MaximumValue="3" ValidationGroup="V">*</asp:RangeValidator>
                                    <asp:RequiredFieldValidator ID="rfv5T" runat="server" ControlToValidate="ddlSexo"
                                        ErrorMessage="Sexo" SetFocusOnError="true" ValidationGroup="T">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv5TE" runat="server" ControlToValidate="ddlSexo"
                                        ErrorMessage="Sexo" SetFocusOnError="true" ValidationGroup="TE">*</asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="rvs3" runat="server" ErrorMessage="Debe seleccionar Masculino o Femenino"
                                        ControlToValidate="ddlSexo" MinimumValue="2" MaximumValue="3" ValidationGroup="T">*</asp:RangeValidator>
                                    <asp:RequiredFieldValidator ID="rfv5TBB" runat="server" ControlToValidate="ddlSexo"
                                        ErrorMessage="Sexo" SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="rfvPN3" runat="server" ErrorMessage="Debe seleccionar Masculino o Femenino"
                                        ControlToValidate="ddlSexo" MinimumValue="2" MaximumValue="3" ValidationGroup="vgPlanNacer">**</asp:RangeValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Fecha Nac.:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFechaNac" runat="server" CssClass="boxcortos" BorderColor="#268fb8"
                                        ToolTip="Fecha de Nacimiento. Formatos permitidos: 01/03/1975, 010375, 01031975"
                                        TabIndex="7" onblur="javascript:formatearFecha(this)"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfv6I" runat="server" ControlToValidate="txtFechaNac"
                                        ErrorMessage="Fecha" SetFocusOnError="true" ValidationGroup="I">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv6V" runat="server" ControlToValidate="txtFechaNac"
                                        ErrorMessage="Fecha" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="rfv6TBB" runat="server" ControlToValidate="txtFechaNac"
                                        ErrorMessage="Fecha" SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Nacionalidad:
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlNacionalidad" runat="server" TabIndex="8" AutoPostBack="true"
                                        OnSelectedIndexChanged="ddlNacionalidad_SelectedIndexChanged" OnDataBound="ddlNacionalidad_DataBound"
                                        DataTextField="nombre" DataValueField="idPais">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvv11" runat="server" ControlToValidate="ddlNacionalidad"
                                        Display="Dynamic" ErrorMessage="Nacionalidad" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lugar de Nacimiento:
                                    <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="true" TabIndex="9"
                                        ToolTip="Seleccionar la Provincia"
                                        DataTextField="nombre" DataValueField="idProvincia">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvv12" runat="server" ControlToValidate="ddlProvincia"
                                        Display="Dynamic" ErrorMessage="LugarNacimiento" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <%--<asp:Label ID="lblOBl" runat="server" CssClass="lbl" Visible="false"></asp:Label>--%>
                                </td>
                                <td>
                                    <%--<asp:Label ID="lblOS" runat="server" CssClass="lbl" Visible="false"></asp:Label>--%>
                                </td>
                            </tr>
                        </table>
                        <asp:Label ID="lblobrasocial" runat="server"></asp:Label>
                        <asp:UpdatePanel ID="upOSocial" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <table id="tableOSociales" class="tabla3">
                                        <tr>
                                            <td>
                                                Obra Social:
                                            </td>
                                            <td>
                                                <div id="OS" runat="server" visible="false" style="float: right; margin-top: 6px;
                                                    margin-right: 0px;">
                                                    <a id="arefOS" runat="server" href="ObraSocial.aspx" onclick="window.open(this.href, this.target, 'width=600,height=250,scrollbars=yes,top=100, left=100'); return false;"
                                                        target="_blank" title="Click para ver la Obra Social del Paciente">
                                                        <img border="0" src="../App_Themes/Paciente/images/flecha1.jpg" alt="Ver Obra Social del Paciente" /></a>
                                                </div>
                                                <div style="font-family: Verdana;">
                                                    <uc1:OSociales ID="OSociales" runat="server" TabIndex="10" />
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        <%--DATOS Sintys--%>
                        <asp:UpdatePanel runat="server" ID="UpGrdPersona" UpdateMode="Conditional">
                            <ContentTemplate>
                                <table class="tabla3">
                                    <tr>
                                        <td colspan="1">
                                            <div>
                                                <asp:Label ID="Label2" CssClass="lblmsn" Style="float: none; position: static; color: Blue"
                                                    runat="server"></asp:Label>
                                            </div>
                                            <asp:GridView ID="GrdPersona" runat="server" AutoGenerateColumns="False" DataKeyNames="idPersona"
                                                EmptyDataText="<b>No se encontraron datos.</b>" OnRowCommand="GrdPersona_RowCommand"
                                                OnRowDataBound="GrdPersona_RowDataBound" CellPadding="4" Font-Size="8pt" BorderColor="#333333"
                                                BorderStyle="Solid" BorderWidth="1px" GridLines="None" Font-Bold="False" ForeColor="#333333"
                                                Width="600px">
                                                
                                                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                                                <RowStyle CssClass="GridRow" />
                                                <Columns>
                                                    <asp:BoundField DataField="TipoDocumento" HeaderText="Tipo" />
                                                    <asp:BoundField DataField="Documento" HeaderText="Documento" />
                                                    <asp:BoundField DataField="NombreCompleto" HeaderText="Apellido Nombre" />
                                                    <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" />
                                                    <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="Datos" runat="server" ImageUrl="~/App_Themes/Paciente/images/flecha1.jpg"
                                                                CommandName="Paciente" />
                                                        </ItemTemplate>
                                                        <ItemStyle Width="20px" HorizontalAlign="Center" Height="20px" />
                                                    </asp:TemplateField>
                                                </Columns>
                                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                <HeaderStyle CssClass="GridHeader" />
                                                <EditRowStyle BackColor="#999999" />
                                                <AlternatingRowStyle CssClass="GridAlternateRow" />
                                            </asp:GridView>
                                            <asp:GridView ID="grdOSociales" runat="server" CssClass="mGrid" AutoGenerateColumns="False"
                                                EmptyDataText="<b>No se encontraron datos de obras sociales para la persona seleccionada.</b>">
                                                <Columns>
                                                    <asp:BoundField DataField="ObraSocial" HeaderText="Obra Social" />
                                                    <asp:BoundField DataField="baseOrigen" HeaderText="Base Origen" />
                                                </Columns>
                                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                <HeaderStyle CssClass="GridHeader" />
                                                <EditRowStyle BackColor="#999999" />
                                                <AlternatingRowStyle CssClass="GridAlternateRow" />
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <asp:Panel ID="pnlOtrosDatos" runat="server">
                            <%--DATOS Sintys--%>
                            <asp:UpdatePanel ID="upOtrosDatos" runat="server">
                                <ContentTemplate>
                                    <table class="tabla3">
                                        <tr>
                                            <td>
                                                Teléfono Fijo:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtTFijo" TabIndex="11" runat="server" CssClass="boxcortos" />&nbsp;&nbsp; Teléfono
                                                Celular:
                                                <asp:TextBox ID="txtTCelular" TabIndex="12" runat="server" Width="25%" MaxLength="20" />&nbsp;&nbsp;
                                                Email:
                                                <asp:TextBox ID="txtEmail" TabIndex="13" runat="server" Width="25%" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Observaciones
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtContacto" runat="server" MaxLength="500" Rows="2" TabIndex="14"
                                                    TextMode="MultiLine" Width="90%" CssClass="uptext"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Fecha Defunción:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDefuncion" runat="server" CssClass="boxcortos" onblur="javascript:formatearFecha(this)"
                                                    TabIndex="15" ToolTip="Ingrese la Fecha de Defunción del Paciente"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                    </div>
                </div>
            </li>
            <li style="margin-top: 6px;">
                <h3>
                    Datos del Domicilio</h3>
                <div class="acc-section">
                    <div class="acc-content" style="width: 782px">
                        <asp:Panel ID="Panel2" runat="server" Width="100%">
                            <asp:UpdatePanel ID="upPanel2" runat="server">
                                <ContentTemplate>
                                    <table class="tabla3">
                                        <tr>
                                            <td>
                                                Provincia:
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlProvinciaDomicilio" runat="server" AutoPostBack="true" DataTextField="nombre"
                                                    DataValueField="idProvincia" OnDataBound="ddlProvinciaDomicilio_DataBound" OnSelectedIndexChanged="ddlProvinciaDomicilio_SelectedIndexChanged"
                                                    TabIndex="16" ToolTip="Seleccionar la Provincia">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvv1" runat="server" ControlToValidate="ddlProvinciaDomicilio"
                                                    Display="Dynamic" ErrorMessage="Provincia" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Departamento:
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlDepartamento" runat="server" TabIndex="17" OnSelectedIndexChanged="ddlDepartamento_SelectedIndexChanged"
                                                    AutoPostBack="true" ToolTip="Seleccionar el Departamento" DataTextField="nombre"
                                                    DataValueField="idDepartamento">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvv2" runat="server" ControlToValidate="ddlDepartamento"
                                                    Display="Dynamic" ErrorMessage="Departamento" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Localidad:
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlLocalidad" runat="server" TabIndex="18" OnSelectedIndexChanged="ddlLocalidad_SelectedIndexChanged"
                                                    AutoPostBack="true" ToolTip="Seleccionar Localidad" DataTextField="nombre" DataValueField="idLocalidad"
                                                    OnDataBound="ddlLocalidad_DataBound">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvv3" runat="server" ControlToValidate="ddlLocalidad"
                                                    Display="Dynamic" ErrorMessage="Localidad" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                                &nbsp;&nbsp;&nbsp; Codigo Postal:
                                                <asp:TextBox ID="txtCPostal" runat="server" CssClass="boxcortos" TabIndex="19"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Barrio:
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlBarrio" runat="server" TabIndex="20" DataTextField="nombre"
                                                    DataValueField="idBarrio">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvv4" runat="server" ControlToValidate="ddlBarrio"
                                                    Display="Dynamic" ErrorMessage="Barrio" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                                &nbsp;&nbsp;&nbsp; Otro Barrio:
                                                <asp:TextBox ID="txtOBarrio" runat="server" CssClass="uptext" TabIndex="21" Width="50%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Calle:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtCalle" runat="server" Width="95%" CssClass="uptext" TabIndex="22"></asp:TextBox><asp:RequiredFieldValidator
                                                    ID="rfvv5" runat="server" ControlToValidate="ddlProvinciaDomicilio" Display="Dynamic"
                                                    ErrorMessage="Calle" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                                <asp:RequiredFieldValidator ID="rfvPN1" runat="server" ControlToValidate="txtCalle"
                                                    Display="Dynamic" ErrorMessage="Calle es Requerido para Plan Nacer" SetFocusOnError="true"
                                                    ValidationGroup="vgPlanNacer">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Número:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNumero" CssClass="boxcorty" runat="server" TabIndex="23" ToolTip="Solo números"></asp:TextBox><asp:RequiredFieldValidator
                                                    ID="rfvv6" runat="server" ControlToValidate="txtNumero" Display="Dynamic" ErrorMessage="Numero"
                                                    SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                                <asp:CompareValidator ID="cvnro" runat="server" ErrorMessage="Solo numeros" ControlToValidate="txtNumero"
                                                    Operator="DataTypeCheck" Type="Integer" />
                                                <asp:RequiredFieldValidator ID="rfvPN2" runat="server" ControlToValidate="txtNumero"
                                                    Display="Dynamic" ErrorMessage="Numero de puerta es Requerido para Plan Nacer"
                                                    SetFocusOnError="true" ValidationGroup="vgPlanNacer">*</asp:RequiredFieldValidator>
                                                Edificio:<asp:TextBox ID="txtEdificio" runat="server" TabIndex="24" CssClass="boxcorty"></asp:TextBox>
                                                Piso:<asp:TextBox ID="txtPiso" runat="server" CssClass="boxcorty" TabIndex="25"></asp:TextBox><asp:RequiredFieldValidator
                                                    ID="rfvv7" runat="server" ControlToValidate="txtPiso" Display="Dynamic" ErrorMessage="Piso"
                                                    SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                                &nbsp;&nbsp;&nbsp; Dpto:<asp:TextBox ID="txtDepartamento" runat="server" MaxLength="8"
                                                    TabIndex="26" ToolTip="Ingreso el número o Letra de su departamento"></asp:TextBox><asp:RequiredFieldValidator
                                                        ID="rfvv8" runat="server" ControlToValidate="txtDepartamento" Display="Dynamic"
                                                        ErrorMessage="Departamento" SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                                Manzana:<asp:TextBox ID="txtManzana" runat="server" CssClass="boxcorty" TabIndex="27"></asp:TextBox><asp:RequiredFieldValidator
                                                    ID="rfvv9" runat="server" ControlToValidate="txtManzana" Display="Dynamic" ErrorMessage="Manzana"
                                                    SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Referencia:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtReferencia" runat="server" CssClass="uptext" TabIndex="28" Rows="3"
                                                    Width="95%"></asp:TextBox><asp:RequiredFieldValidator ID="rfvv10" runat="server"
                                                        ControlToValidate="txtReferencia" Display="Dynamic" ErrorMessage="Referencia"
                                                        SetFocusOnError="true" ValidationGroup="V">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Tipo:
                                            </td>
                                            <td>
                                                <asp:RadioButtonList ID="rbUrbano" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" TabIndex="29">
                                                    <asp:ListItem Value="1" Selected="True">Urbano</asp:ListItem>
                                                    <asp:ListItem Value="0">RuraL</asp:ListItem>
                                                </asp:RadioButtonList>
                                                &nbsp;&nbsp;&nbsp; Coordenadas: Latitud
                                                <asp:TextBox ID="txtLatitud" runat="server" Width="100"  TabIndex="30" />
                                                &nbsp; Longitud
                                                <asp:TextBox ID="txtLongitud" runat="server" Width="100"  TabIndex="31"/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Campo:
                                            </td>
                                            <td >
                                                <asp:TextBox ID="txtCampo" runat="server" CssClass="uptext"  TabIndex="32" Width="90%"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Camino:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtCamino" runat="server" CssClass="uptext"  TabIndex="33" Width="62%"></asp:TextBox>
                                                &nbsp;&nbsp;&nbsp; Lote:
                                                <asp:TextBox ID="txtLote" runat="server" TabIndex="34" CssClass="boxcorty"></asp:TextBox>
                                                Parcela:
                                                <asp:TextBox ID="txtParcela" runat="server" TabIndex="35" CssClass="boxcorty"></asp:TextBox>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                    </div>
                </div>
            </li>
            <li style="margin-top: 6px;">
                <h3>
                    Datos del Progenitor</h3>
                <div class="acc-section">
                    <div class="acc-content" style="width: 782px">
                        <asp:Panel ID="Panel1" runat="server" Width="100%">
                            <asp:UpdatePanel ID="upPanel1" runat="server">
                                <ContentTemplate>
                                    <table class="tabla3">
                                        <tr>
                                            <td colspan="2" class="tde">
                                                <b>
                                                    <asp:Label ID="lblMadre" runat="server" Text="Datos de la Madre" /></b>
                                                <asp:Label ID="lblIdParentescoM" Visible="false" runat="server">0</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                DU:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNumeroM" TabIndex="36" CssClass="boxcortos" MaxLength="9" runat="server" ToolTip="Solo números" /><asp:RequiredFieldValidator
                                                    ID="rffv3" runat="server" ControlToValidate="txtNumeroM" Display="Dynamic" ErrorMessage="Número de Documento de la Madre"
                                                    SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tde">
                                                Apellido:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtApellidoM" TabIndex="37" runat="server" CssClass="boxlargos" /><asp:RequiredFieldValidator
                                                    ID="rffv1" runat="server" ControlToValidate="txtApellidoM" Display="Dynamic"
                                                    ErrorMessage="Apellido de la Madre" SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tde">
                                                Nombre:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNombreM" runat="server" TabIndex="38" CssClass="boxlargos" /><asp:RequiredFieldValidator
                                                    ID="rffv2" runat="server" ControlToValidate="txtNombreM" Display="Dynamic" ErrorMessage="Nombre de la Madre"
                                                    SetFocusOnError="true" ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Fecha Nacimiento
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFNacMadre" runat="server" TabIndex="39" onblur="javascript:formatearFecha(this)"
                                                    CssClass="boxcortos"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="frrv4" runat="server" ControlToValidate="txtFNacMadre"
                                                    Display="Dynamic" ErrorMessage="Fecha de Nacimiento de Madre" SetFocusOnError="true"
                                                    ValidationGroup="TBB">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Nacionalidad:
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlNacionalidadM" runat="server" DataTextField="nombre" DataValueField="idPais" TabIndex="40">
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp; Lugar Nac:
                                                <asp:DropDownList ID="ddlLugarNacimientoM" runat="server" ToolTip="Seleccionar la Provincia" TabIndex="41"
                                                    DataTextField="nombre" DataValueField="idProvincia">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <hr />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tde" colspan="2">
                                                <b>
                                                    <asp:Label ID="lblPadre" runat="server" Text="Datos del Padre" /></b>
                                                <asp:Label ID="lblIdParentescoP" Visible="false" runat="server">0</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                DU:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtDUPadre" runat="server" CssClass="boxcortos" MaxLength="9" ToolTip="Solo números" TabIndex="42" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tde">
                                                Apellido:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtApellidoPadre" runat="server" CssClass="boxlargos" TabIndex="43"/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="tde">
                                                Nombre:
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNombrePadre" runat="server" CssClass="boxlargos" TabIndex="44"/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Fecha Nacimiento
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFNacPadre" runat="server" onblur="javascript:formatearFecha(this)" TabIndex="45"
                                                    CssClass="boxcortos"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Nacionalidad:
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlNacionalidadP" runat="server" AutoPostBack="true" DataValueField="idPais" TabIndex="46"
                                                    DataTextField="nombre">
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp; Lugar Nac:
                                                <asp:DropDownList ID="ddlLugarNacimientoP" runat="server" DataValueField="idProvincia" TabIndex="47"
                                                    DataTextField="nombre">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </asp:Panel>
                    </div>
                </div>
            </li>
        </ul>
        
        <asp:ValidationSummary ID="VST" DisplayMode="SingleParagraph" ShowMessageBox="true"
            runat="server" HeaderText="Completar Información:" ValidationGroup="T" />
        <asp:ValidationSummary ID="VSET" DisplayMode="SingleParagraph" ShowMessageBox="true"
            runat="server" HeaderText="Completar Información:" ValidationGroup="TE" />
        <asp:ValidationSummary ID="valSum" DisplayMode="SingleParagraph" ShowMessageBox="true"
            runat="server" HeaderText="Completar Información del Paciente:" ValidationGroup="I" />
        <asp:ValidationSummary ID="VS1" DisplayMode="SingleParagraph" ShowMessageBox="true"
            runat="server" HeaderText="Completar Otros Datos del Paciente:" ValidationGroup="V" />
        <asp:ValidationSummary ID="VS2" DisplayMode="SingleParagraph" ShowMessageBox="true"
            ShowSummary="true" runat="server" HeaderText="Completar Datos del Progenitor:"
            ValidationGroup="TBB" />
    </div></td>
        <td></td>
        <td style="vertical-align: top">
                <asp:Button ID="btnPadronPcial" runat="server" onclick="btnPadronPcial_Click" 
    Text="Validar Padron Provincial" />
                <br />
                <br />
             
            <uc1:PacienteProvincial runat="server" id="PacienteProvincial" Visible="False" />
             <br />
                <br />

            <table >
                <tr>
                    <td colspan="3"> 
                         <asp:Button ID="btnCopiarTodo" runat="server" Text="Copiar Todo" Visible="False" onclick="btnCopiarTodo_Click" /> 

                    </td>
                    
                </tr>
                 <tr>
                    <td colspan="3"> 
                    <br />
                    </td>                    
                </tr>
                <tr>
                    <td>  <asp:Button ID="btnCopiarDatosPrincipales" runat="server" Text="Copiar Datos Principales" Visible="False" onclick="btnCopiarDatosPrincipales_Click" />
              </td>
                    <td><asp:Button ID="btnCopiarDomicilio" runat="server" onclick="btnCopiarDomicilio_Click" Text="Copiar Domicilio" Visible="False" /></td>
                    <td><asp:Button ID="btnCopiarProgenitor" runat="server" onclick="btnCopiarProgenitor_Click"     Text="Copiar Datos Progenitor" Visible="False" /></td>
                </tr>
                 <tr>
                    <td colspan="3"> 
                    <br />
                    </td>                    
                </tr>
                <tr>
                    <td colspan="2"></td>
                    <td>  <asp:Button ID="btnCopiarMadre" runat="server" onclick="btnCopiarMadre_Click"   Text="Solo Datos Madre" Visible="False" />  <asp:Button ID="btnCopiarPadre" runat="server" onclick="btnCopiarPadre_Click"     Text="Solo Datos Padre" Visible="False" /></td>
                </tr>
            </table>
     <br />
             
        
               
        </td>

           </tr></table>
    
</asp:Content>
<asp:Content ID="content" ContentPlaceHolderID="Botones" runat="server">
    <asp:UpdatePanel ID="upBotones" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <div style="text-align: center">
                <asp:Button ID="btnGuardarRem" runat="server" Text="Guardar y Volver" ToolTip="Vuelve a Remediar"
                    OnClick="btnGuardarRem_Click" />
                <asp:Button ID="btnGuardarClasif" runat="server" Text="Guardar y Clasificar" ToolTip="Vuelve a Clasificacion"
                    OnClick="btnGuardarClasif_Click" />
                <asp:Button ID="btnGuardarCP" runat="server" Text="Guardar y VolverCPerinatal" ToolTip="Vuelve a ControlPerinatal"
                    OnClick="btnGuardarCP_Click" />
                <asp:Button ID="btnGuardarCM" runat="server" Text="Guardar y VolverCMenor" ToolTip="Vuelve a ControlMenor"
                    OnClick="btnGuardarCM_Click" />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" TabIndex="48" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                <asp:Label EnableViewState="False" ID="Label1" runat="server"></asp:Label>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
