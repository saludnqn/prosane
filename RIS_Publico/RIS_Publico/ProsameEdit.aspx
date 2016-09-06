<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProsameEdit.aspx.cs" Inherits="RIS_Publico.ProsameEdit" MasterPageFile="~/MInterconsultas.Master" UICulture="es" Culture="es-AR" %>

<%--<%@ Register Src="~/UserControl/ObrasSociales.ascx" TagName="OSociales" TagPrefix="uc1" %>--%>

<asp:Content ID="content2" ContentPlaceHolderID="cuerpo" runat="server">
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui.min.js"></script>
    <script type="text/javascript" src="js/jquery.ui.datepicker-es.js"></script>
    <script src="js/Format.js" type="text/javascript"></script>
    <script type="text/javascript" src='<%= ResolveUrl("js/jquery-1.5.1.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("js/jquery-ui-1.8.9.custom.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("js/json2.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("js/jquery.dataTables.min.js") %>'></script>
    <link href='<%= ResolveUrl("js/jquery-ui.css") %>' rel="stylesheet" type="text/css" />
    <link type="text/css" rel="stylesheet" href="js/jquery-ui-1.7.1.custom.css" />

    <style type="text/css">
        .margenIzq {
            margin-left: 106px;
        }

        .box {
            border: dotted 1px green;
        }

        .boxcolor {
            border: dotted 1px gray;
            background-color: lightgray;
        }

        .txtcenter {
            text-align: center;
        }
         .lblCerrar {
            text-align: center;
            color: green;
            font-weight: 200;
        }
    </style>

    <script type="text/javascript">
        $(function () {
            $("#<%=txtFechaInicio.ClientID %>").datepicker({
                showOn: 'button',
                buttonImage: 'App_Themes/default/img/calendar.png',
                buttonImageOnly: true
            });
            $("#<%=txtFechaOdonto.ClientID %>").datepicker({
                showOn: 'button',
                buttonImage: 'App_Themes/default/img/calendar.png',
                buttonImageOnly: true
            });
        });
    </script>
    <script type="text/javascript" src="js/Mascara.js"></script>
    <script type="text/javascript" src="js/ValidaFecha.js"></script>

    <table class="myTabla">
        <tr>
            <td rowspan="10" style="vertical-align: top">
                <table class="myTabla" width="800px">
                    <tr>
                        <td colspan="2" align="right">
                            <table id="TablaErrores" runat="server" bgcolor="#CC3300" cellpadding="10" cellspacing="10" style="width: 100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#F3F3F3"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <div class="box">
                                            <table>
                                                <tr>
                                                    <td colspan="3" style="height: 14px; text-align: center">
                                                        <b>ACCION DE SALUD EN LA ESCUELA</b>
                                                        <br />
                                                        PLANILLA DE DATOS
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3">
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: left; width: 179px">DNI:
                                                    </td>
                                                    <td style="text-align: left; width: 270px">
                                                        <asp:Label ID="ldniPaciente" runat="server" ForeColor="#336699"></asp:Label>
                                                    </td>
                                                    <td style="width: 245px">
                                                        <asp:Label ID="lidPaciente" runat="server" ForeColor="#336699" Visible="False"></asp:Label></td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="text-align: left; width: 179px">Nombre y Apellido :&nbsp;&nbsp; 
                                                    </td>
                                                    <td style="text-align: left; width: 270px">
                                                        <asp:Label ID="lPaciente" runat="server" ForeColor="#336699"></asp:Label>
                                                    </td>
                                                    <td style="width: 245px">&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 179px; text-align: left">Sexo:
                                                    </td>
                                                    <td style="width: 270px; text-align: left">
                                                        <asp:Label ID="lSexo" runat="server" ForeColor="#336699"></asp:Label><asp:DropDownList ID="ddlSexo" runat="server" Visible="false" ValidationGroup="1">
                                                            <asp:ListItem Value="0" Selected="true">sd</asp:ListItem>
                                                            <asp:ListItem Value="F">F</asp:ListItem>
                                                            <asp:ListItem Value="M">M</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td style="width: 245px"></td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 179px; text-align: left">Fecha de Nacimiento:<span style="font-weight: normal">&nbsp; 
                                                    </span></td>
                                                    <td style="width: 270px; text-align: left"><span style="font-weight: normal">
                                                        <asp:Label ID="lFechaNacimiento" runat="server" ForeColor="#336699"></asp:Label>
                                                        &nbsp;&nbsp; Edad Actual:
                                                                <asp:Label ID="lEdad" runat="server" ForeColor="#336699"></asp:Label>
                                                    </span></td>
                                                    <td style="width: 245px">&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <br />
                                                        <div id="pnParentesco" runat="server" visible="true" class="boxcolor">
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td>Nombre del Madre/Padre/Tutor:
                                                                    </td>
                                                                    <td style="width: 270px">
                                                                        <asp:TextBox ID="txtNombre" runat="server" Width="248px"></asp:TextBox>
                                                                    </td>
                                                                    <td></td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Apellido del Madre/Padre/Tutor:
                                                                    </td>
                                                                    <td style="width: 270px">
                                                                        <asp:TextBox ID="txtApellido" runat="server" Width="248px"></asp:TextBox>
                                                                    </td>
                                                                    <td></td>
                                                                </tr>
                                                                <tr>
                                                                    <td>DNI del Madre/Padre/Tutor:
                                                                    </td>
                                                                    <td style="width: 270px">
                                                                        <asp:TextBox runat="server" Width="104px" ID="txtTutorDNI">0</asp:TextBox>
                                                                    </td>
                                                                    <td></td>
                                                                </tr>
                                                                <tr>
                                                                    <td>Tipo Parentesco: </td>
                                                                    <td style="width: 270px">
                                                                        <asp:DropDownList ID="ddlTipoParentesco" runat="server" ToolTip="Seleccionar Tipo de Parentesco">
                                                                            <asp:ListItem Value="" Selected="True">Seleccione -></asp:ListItem>
                                                                            <asp:ListItem Value="MADRE">MADRE</asp:ListItem>
                                                                            <asp:ListItem Value="PADRE">PADRE</asp:ListItem>
                                                                            <asp:ListItem Value="OTRO">OTRO</asp:ListItem>
                                                                        </asp:DropDownList>&nbsp;&nbsp;&nbsp;<asp:Button ID="btnGuardarParentezco" runat="server" Text="Guardar Tutor" ToolTip="Guardar datos del tutor" Width="100px" OnClick="btnGuardarParentezco_Click" />
                                                                    </td>
                                                                    <td></td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="3">
                                                                        <br />
                                                                        <asp:Label ID="lblMensajeTutor" runat="server" CssClass="txtcenter"></asp:Label></td>
                                                                </tr>
                                                            </table>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 179px; text-align: left">Domicilio:</td>
                                                    <td style="width: 270px; text-align: left">
                                                        <asp:Label ID="lDomicilio" runat="server" ForeColor="#336699"></asp:Label>
                                                    </td>
                                                    <td style="width: 245px">&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 179px; text-align: left">
                                                        <span style="font-weight: normal; text-align: left;">Telefono Fijo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; </span>
                                                    </td>
                                                    <td style="width: 270px; text-align: left">
                                                        <asp:Label ID="lTelefono" runat="server" ForeColor="#336699" Style="text-align: left"></asp:Label>
                                                    </td>
                                                    <td style="width: 245px; text-align: left;">Celular:
                                                    <asp:Label ID="lblCelular" runat="server" ForeColor="#336699" Style="text-align: left"></asp:Label>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 179px; text-align: left">
                                                        <span style="font-weight: normal; text-align: left;">Fecha Ficha:</span></td>
                                                    <td style="width: 270px; text-align: left">
                                                        <input id="txtFechaInicio" runat="server" class="myTexto" maxlength="10" onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" style="width: 105px" type="text" /></td>
                                                    <td style="width: 245px; text-align: left;">&nbsp;</td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 179px; text-align: left">&nbsp;</td>
                                                    <td style="width: 270px; text-align: left">&nbsp;</td>
                                                    <td style="width: 245px; text-align: left;">
                                                        <%--<asp:Button ID="btnBuscarPac" runat="server" OnClick="btnBuscarPac_Click" Text="Ingresar Datos" Visible="False" />--%>
                                                    </td>
                                                    <td>
                                                        <%--<asp:Button ID="cmdCargarPaciente" runat="server" CssClass="myButton" OnClick="cmdCargarPaciente_Click" TabIndex="2" Text="Cargar paciente" ToolTip="Buscar" ValidationGroup="0" Visible="False" />--%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="4">
                                                        <div id="pnProsameanterior" runat="server" visible="false">
                                                            <asp:GridView ID="gvProsane" runat="server" AutoGenerateColumns="false" CellPadding="2" Width="99%" Font-Names="Arial" ForeColor="#333333">
                                                                <RowStyle BackColor="#F7F6F3" Font-Names="Arial" ForeColor="#333333" />
                                                                <Columns>
                                                                    <asp:BoundField DataField="DNIPaciente" HeaderText="DNI" />
                                                                    <asp:BoundField DataField="PacNombre" HeaderText="Paciente" />
                                                                    <asp:BoundField DataField="Establecimiento" HeaderText="Establecimiento" />
                                                                    <asp:BoundField DataField="Sobreedad" HeaderText="Sobre Edad" />
                                                                    <asp:BoundField DataField="Repitente" HeaderText="Repitente" />
                                                                    <asp:BoundField DataField="IMC" HeaderText="IMC" />
                                                                    <asp:BoundField DataField="UsuarioCarga" HeaderText="Usuario Carga" />
                                                                    <asp:BoundField DataField="FechaCarga" HeaderText="Fecha Carga" DataFormatString="{0:MM/dd/yyyy}" />
                                                                    <asp:TemplateField HeaderText="Ver">
                                                                        <ItemTemplate>
                                                                            <a href="ProsameEdit.aspx?idProsame=<%# Eval("IdProsame") %>&ver=true" title="Ver datos del registro" target="_blank">
                                                                                <img id="imgView" alt="Ver Registro Completo" border="0" src="App_Themes/Clasificacion/images/ver.png" />
                                                                            </a>
                                                                        </ItemTemplate>
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                                <HeaderStyle BackColor="#333333" Font-Names="Arial" ForeColor="White" />
                                                            </asp:GridView>
                                                            <br />
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 14px; text-align: center">
                                        <asp:Panel ID="pnlDatos" runat="server" Style="text-align: left">
                                            <div class="box">
                                                <table id="tblDatos" style="width: 100%;">
                                                    <tr>
                                                        <td colspan="10" style="text-align: left; height: 14px">
                                                            <asp:Label ID="lProvincia" runat="server" ForeColor="Black"></asp:Label>
                                                            &nbsp;<asp:DropDownList ID="ddlProvincia" runat="server" DataTextField="nombre"
                                                                DataValueField="idProvincia" TabIndex="1" Height="30px" Width="191px">
                                                                <asp:ListItem Value=""></asp:ListItem>
                                                            </asp:DropDownList>
                                                            &nbsp;Depart.:
                                                                    <asp:DropDownList ID="ddlDepartamento" runat="server" DataTextField="nombre"
                                                                        DataValueField="idDepartamento" TabIndex="2" Height="30px" Width="173px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Loc.:
                                                                    <asp:DropDownList ID="ddlLocalidad" runat="server" DataTextField="nombre"
                                                                        DataValueField="idLocalidad" TabIndex="3" Height="30px" Width="175px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                        <asp:ListItem>NEUQUEN</asp:ListItem>
                                                                    </asp:DropDownList>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10" style="height: 15px; text-align: left">&nbsp;Establecimiento Educativo:
                                                        <asp:DropDownList ID="ddlEstablecimiento" runat="server" DataTextField="nombre"
                                                            DataValueField="idEstablecimiento" TabIndex="4" Height="30px" Width="194px">
                                                        </asp:DropDownList>&nbsp;&nbsp;&nbsp;
                                                        <asp:Label ID="lblEfector" runat="server" Text=""></asp:Label>
                                                            &nbsp;&nbsp;&nbsp;
                                                        Zona:
                                                        <asp:DropDownList ID="ddlZonaEstudio" runat="server" ToolTip="Seleccione la zona de estudio correspondiente">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="Urb">Urb</asp:ListItem>
                                                            <asp:ListItem Value="Rur">Rur</asp:ListItem>
                                                        </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10" style="height: 14px;">Escolaridad:
                                                        <asp:DropDownList ID="ddlEscolaridad" runat="server" DataValueField="idEscolaridad" DataTextField="Descripcion" ToolTip="Seleccione la escolaridad" Height="30px">
                                                        </asp:DropDownList>
                                                            Grado:
                                                                    <asp:DropDownList ID="ddlGrado" runat="server" DataValueField="idGrado" DataTextField="Descripcion" ToolTip="Seleccione el grado" Height="30px">
                                                                    </asp:DropDownList>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Division:
                                                                    <asp:DropDownList ID="ddlDivision" runat="server" DataValueField="idDivision" DataTextField="Descripcion" ToolTip="Seleccione la división" Height="30px">
                                                                    </asp:DropDownList>
                                                            &nbsp;&nbsp;&nbsp;&nbsp; Turno:&nbsp;
                                                                    <asp:DropDownList ID="ddlTurno" runat="server" Height="30px">
                                                                        <asp:ListItem Value="sd">sd</asp:ListItem>
                                                                        <asp:ListItem>Mañana</asp:ListItem>
                                                                        <asp:ListItem>Tarde</asp:ListItem>
                                                                        <asp:ListItem>Vespertino</asp:ListItem>
                                                                    </asp:DropDownList>
                                                            <br />
                                                            <br />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="9">
                                                            <div style="width: 99%">
                                                                Obra Social:
                                                            <uc1:OSociales ID="OSociales" runat="server" Visible="True" />
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10">Nacio prematuro: 
                                                                &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlPrematuro" runat="server" DataTextField="nombre"
                                                                    DataValueField="idObraSocial" TabIndex="9" Height="30px" Width="46px">
                                                                    <asp:ListItem Value="SD">Sd</asp:ListItem>
                                                                    <asp:ListItem Value="NO">No</asp:ListItem>
                                                                    <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                </asp:DropDownList>
                                                            &nbsp;&nbsp;&nbsp; Peso Nacimiento:
                                                        <asp:TextBox runat="server" Width="43px" TabIndex="10"
                                                            Font-Size="Medium" Height="16px" ID="txtPesoNacimiento" Text="0"></asp:TextBox>
                                                            &nbsp;grs</td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table>
                                                    <tr>
                                                        <td colspan="10" style="height: 14px; text-align: center">
                                                            <strong>DOCENTE</strong></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10" style="height: 14px; text-align: left;"><b>Desempeño Escolar</b></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10" style="height: 14px; text-align: left; border-left-style: solid; border-right-style: solid;">Sobreedad:
                                                        <asp:DropDownList ID="ddlSobreedad" runat="server" DataTextField="nombre"
                                                            DataValueField="idObraSocial" TabIndex="16" Height="30px">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="NO">No</asp:ListItem>
                                                            <asp:ListItem Value="SI">Si</asp:ListItem>
                                                        </asp:DropDownList>&nbsp;&nbsp;
                                                        Repitente:<asp:DropDownList ID="ddlRepitente" runat="server" DataTextField="nombre" DataValueField="idObraSocial" Height="35px">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="NO">No</asp:ListItem>
                                                            <asp:ListItem Value="SI">Si</asp:ListItem>
                                                        </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table style="width: 99%">
                                                    <tr>
                                                        <td class="txtcenter"><strong>EVALUACION ANTROPOMETRICA</strong></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="9">Peso:
                                                        <asp:TextBox ID="txtPesoAlumno" onblur="valNumero(this)" runat="server" Width="42px" Text="0" ToolTip="Ingrese el peso experesado en kilogramos. Ej: 1300"></asp:TextBox>kg
                                                        &nbsp;&nbsp;&nbsp; Talla:
                                                        <asp:TextBox ID="txtTalla" onblur="valNumero(this)" runat="server" Width="38px" Text="0" ToolTip="Ingrese la talla expresada en cm. Ej: 125" OnTextChanged="txtTalla_TextChanged" AutoPostBack="true"></asp:TextBox>cm
                                                        &nbsp;&nbsp;&nbsp;IMC:&nbsp; &nbsp;<asp:TextBox ID="txtIMC" runat="server" Width="59px" Text="0"></asp:TextBox><br />
                                                            Presión arterial sistólica(PAS):
                                                        <asp:TextBox ID="txtTAMax" runat="server" Width="39px" OnTextChanged="txtTAMax_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                            &nbsp;&nbsp;&nbsp;Presión arterial diastólica(PAD):
                                                        <asp:TextBox ID="txtTAMin" runat="server" Width="35px" OnTextChanged="txtTAMin_TextChanged" AutoPostBack="true"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Perc.Talla:
                                                        <asp:DropDownList ID="ddlPercentiloTalla" runat="server">
                                                            <asp:ListItem Value="SD" Selected="True">SD</asp:ListItem>
                                                            <asp:ListItem Value="<3"><3</asp:ListItem>
                                                            <asp:ListItem Value=">=3">>=3</asp:ListItem>
                                                        </asp:DropDownList>
                                                            Perc. IMC:
                                                        <asp:DropDownList ID="ddlPercentiloIMC" runat="server">
                                                            <asp:ListItem Value="SD" Selected="True">SD</asp:ListItem>
                                                            <asp:ListItem Value="Menor a 3">Menor a 3</asp:ListItem>
                                                            <asp:ListItem Value="Entre 3 y 9">Entre 3 y 9</asp:ListItem>
                                                            <asp:ListItem Value="Entre 10 y 84">Entre 10 y 84</asp:ListItem>
                                                            <asp:ListItem Value="Entre 85 y 97">Entre 85 y 97</asp:ListItem>
                                                            <asp:ListItem Value="Mayor a 97">Mayor a 97</asp:ListItem>
                                                        </asp:DropDownList>
                                                            Perc. PAS:
                                                        <asp:DropDownList ID="ddlPerPas" runat="server">
                                                            <asp:ListItem Value="SD" Selected="True">SD</asp:ListItem>
                                                            <asp:ListItem Value="<90"><90</asp:ListItem>
                                                            <asp:ListItem Value=">=90">>=90</asp:ListItem>
                                                        </asp:DropDownList>
                                                            Perc. PAD:
                                                        <asp:DropDownList ID="ddlPerPad" runat="server">
                                                            <asp:ListItem Value="SD" Selected="True">SD</asp:ListItem>
                                                            <asp:ListItem Value="<90"><90</asp:ListItem>
                                                            <asp:ListItem Value=">=90">>=90</asp:ListItem>
                                                        </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table>
                                                    <tr>
                                                        <td colspan="3">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3" class="txtcenter"><b>EXAMEN FÍSICO</b></td>
                                                    </tr>
                                                    <tr>
                                                        <td><strong>Esquema de Vacunas</strong></td>
                                                        <td>&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Trajo carnet:
                                                        <asp:DropDownList ID="ddlTrajoCarnet" runat="server" DataTextField="nombre">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="NO">No</asp:ListItem>
                                                            <asp:ListItem Value="SI">Si</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                        <td>
                                                            &nbsp;&nbsp;&nbsp;
                                                        Vacuna Completa:
                                                        <asp:DropDownList ID="ddlVaunaCompleto" runat="server" DataTextField="nombre">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="NO">No</asp:ListItem>
                                                            <asp:ListItem Value="SI">Si</asp:ListItem>
                                                        </asp:DropDownList></td>
                                                        <td>
                                                            &nbsp;&nbsp;&nbsp;Se vacunó en esc:
                                                        <asp:DropDownList ID="ddlSeVacunoEscuela" runat="server" DataTextField="nombre">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="NO">No</asp:ListItem>
                                                            <asp:ListItem Value="SI">Si</asp:ListItem>
                                                        </asp:DropDownList>
                                                            <br />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table>
                                                    <tr>
                                                        <td></td>
                                                        <td><b>Examen Fisico</b></td>
                                                        <td colspan="3" style="text-align: center;"><strong>Patologico</strong></td>
                                                        <td colspan="5" style="text-align: justify;"><strong>Otros</strong></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <modules runallmanagedmodulesforallrequests="true">
                                                                        Piel y fanera</modules>
                                                        </td>
                                                        <td>
                                                            <asp:DropDownList ID="ddlAllazgoPiel" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" OnSelectedIndexChanged="ddlAllazgoPiel_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlPielFaneras" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" AutoPostBack="True" Enabled="False" OnSelectedIndexChanged="ddlPielFaneras_SelectedIndexChanged">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtPielFanera" runat="server" Width="158px" Visible="False"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Partes blandas</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddlHallazgoPartesBlandas" runat="server" DataTextField="nombre" DataValueField="idObraSocial" OnSelectedIndexChanged="ddlHallazgoPartesBlandas_SelectedIndexChanged" AutoPostBack="True">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8" style="text-align: left;">
                                                            <asp:DropDownList ID="ddlPartesBlandas" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtPartesBlandas" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Cardivascular</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgoslCardiovascular" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" OnSelectedIndexChanged="ddHallazgoslCardiovascular_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlCardiovascular" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtCardiovascular" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Repiratorio</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgosRespiratorio" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" OnSelectedIndexChanged="ddHallazgosRespiratorio_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlRespiratorio" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtRespiratorio" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Abdominal</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgosAbdominal" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" OnSelectedIndexChanged="ddHallazgosAbdominal_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlAbdomen" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtAbdominal" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10">
                                                            <div id="pnGenitourinarioF" runat="server" visible="false">
                                                                Genitourinario (niñas): 
                                                            <asp:DropDownList ID="ddHallazgosGenitourinarioF" runat="server" DataTextField="nombre" AutoPostBack="True" OnSelectedIndexChanged="ddHallazgosGenitourinarioF_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                                <asp:DropDownList ID="ddlGenitalF" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                                </asp:DropDownList>
                                                                <asp:TextBox ID="txtGenitourinarioF" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10">
                                                            <div id="pnGenitourinarioM" runat="server" visible="false">
                                                                Genitourinario (niños): 
                                                            <asp:DropDownList ID="ddHallazgosGenitourinarioM" runat="server" DataTextField="nombre" AutoPostBack="True" OnSelectedIndexChanged="ddHallazgosGenitourinarioM_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                                <asp:DropDownList ID="ddlGenitalM" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                                </asp:DropDownList>
                                                                <asp:TextBox ID="txtGenitourinarioM" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Osteoarticular</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgosOsteoarticular" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" OnSelectedIndexChanged="ddHallazgosOsteoarticular_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlOstocular" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtOsteoarticular" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Neurologico</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgosNeurologico" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" CausesValidation="True" OnSelectedIndexChanged="ddHallazgosNeurologico_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlNeurologico" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtNeurologico" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Salud Visual</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgosSaludVisual" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" CausesValidation="True" OnSelectedIndexChanged="ddHallazgosSaludVisual_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlSaludVisual" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtSaludVisual" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Salud fono-audiologica</td>
                                                        <td>
                                                            <asp:DropDownList ID="ddHallazgosSaludFono" runat="server" DataTextField="nombre" DataValueField="idObraSocial" AutoPostBack="True" CausesValidation="True" OnSelectedIndexChanged="ddHallazgosSaludFono_SelectedIndexChanged">
                                                                <asp:ListItem Value="Sin hallazgos ">Sin hallazgos</asp:ListItem>
                                                                <asp:ListItem Value="Con hallaszgos">Con hallazgos </asp:ListItem>
                                                                <asp:ListItem Value="No se evaluo">No se evaluo</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="8">
                                                            <asp:DropDownList ID="ddlSaludFonoAudiologica" runat="server" DataTextField="nombre" DataValueField="idPSMEFisicoItems" Enabled="False">
                                                            </asp:DropDownList>
                                                            <asp:TextBox ID="txtSaludFono" runat="server" Visible="False" Width="158px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table>
                                                    <tr>
                                                        <td colspan="2">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="txtcenter"><b>Oftalmologia</b></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Estrabismo:
                                                            <asp:DropDownList ID="ddlEstravismo" runat="server" DataTextField="nombre">
                                                                <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                <asp:ListItem Value="NO">No</asp:ListItem>
                                                                <asp:ListItem Value="SI">Si</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>Usa Lentes:
                                                            <asp:DropDownList ID="ddlUsaLentes" runat="server" DataTextField="nombre"
                                                                DataValueField="idObraSocial">
                                                                <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                <asp:ListItem Value="NO">No</asp:ListItem>
                                                                <asp:ListItem Value="SI">Si</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Agud.Visual Izquierda:
                                                            <asp:TextBox ID="txtAgudezaVisualIzq" runat="server" Width="50px">0</asp:TextBox>
                                                        </td>
                                                        <td>Agud.Visual Derecha:
                                                            <asp:TextBox ID="txtAgudezaVisualDer" runat="server" Width="50px">0</asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2" class="txtcenter">
                                                            <b>Fonoaudilogia</b>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:CheckBox ID="chekAudimotria" runat="server" Text="Audiometria" />
                                                            &nbsp;&nbsp;
                                                                    <asp:CheckBox ID="chekTato" runat="server" Text="Tato" />
                                                            &nbsp;&nbsp;<asp:TextBox ID="txtValorTato" runat="server" Width="34px">0</asp:TextBox>
                                                            &nbsp;&nbsp;
                                                                    <asp:CheckBox ID="chekDiapason" runat="server" Text="Diapason" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Hipoacusia
                                                                    <asp:DropDownList ID="ddlHipoacusia" runat="server" DataTextField="nombre">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>
                                                        </td>
                                                        <td>Tans. de Fonacion<asp:DropDownList ID="ddlFonacion" runat="server" DataTextField="nombre">
                                                            <asp:ListItem Value="SD">SD</asp:ListItem>
                                                            <asp:ListItem Value="NO">No</asp:ListItem>
                                                            <asp:ListItem Value="SI">Si</asp:ListItem>
                                                        </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <strong>Observaciones</strong></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="txtObservaciones" runat="server" Width="715px" TextMode="MultiLine" ViewStateMode="Enabled"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">Responsable:
                                                        <asp:DropDownList ID="ddlResponsableFicha" runat="server" DataTextField="ApellidoyNombre"
                                                            DataValueField="idProfesional">
                                                        </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table>
                                                    <tr>
                                                        <td colspan="3">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3" class="txtcenter"><b>Odontologia</b></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3">Fecha Odontología: <input id="txtFechaOdonto" runat="server" class="myTexto" maxlength="10" onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" style="width: 105px" type="text" /></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Habit.Perniciosos:
                                                            <asp:DropDownList ID="ddlHabitPerniciosos" runat="server" Enabled="true">
                                                                <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                <asp:ListItem>SI</asp:ListItem>
                                                                <asp:ListItem>NO</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>C.E.O.D.</td>
                                                        <td>
                                                            <asp:TextBox ID="txtOHPerC" runat="server" onblur="Careados();" Width="28px">0</asp:TextBox>
                                                            <asp:TextBox ID="txtOHPerE" runat="server" Width="28px">0</asp:TextBox>
                                                            <asp:TextBox ID="txtOHPerO" runat="server" Width="28px">0</asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Maloclusion:
                                                            <asp:DropDownList ID="ddlMaloclusion" runat="server" Enabled="true">
                                                                <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                <asp:ListItem>SI</asp:ListItem>
                                                                <asp:ListItem>NO</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td colspan="2"></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Fluor Aplicado:
                                                            <asp:DropDownList ID="ddlFluorAplicado" runat="server" Enabled="true">
                                                                <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                <asp:ListItem>SI</asp:ListItem>
                                                                <asp:ListItem>NO</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>C.P.O.D</td>
                                                        <td>
                                                            <asp:TextBox ID="txtOMaloC" runat="server" onblur="Careados();" Width="28px">0</asp:TextBox>
                                                            <asp:TextBox ID="txtOMaloP" runat="server" onblur="Careados();" Width="28px">0</asp:TextBox>
                                                            <asp:TextBox ID="txtOMaloO" runat="server" Width="28px">0</asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Ens.Tec.Hig.Bucal:
                                                            <asp:DropDownList ID="ddlTecnicaHigBucal" runat="server" Enabled="true">
                                                                <asp:ListItem>SI</asp:ListItem>
                                                                <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                <asp:ListItem>NO</asp:ListItem>
                                                            </asp:DropDownList></td>
                                                        <td>Cariados:
                                                        </td>
                                                        <td><asp:TextBox ID="txtCareado" runat="server" Enabled="False" Width="28px">0</asp:TextBox></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="3">
                                                            <br />
                                                            Responsable Odontología:
                                                            <asp:DropDownList ID="ddlResponsableOdonto" runat="server" DataTextField="ApellidoyNombre" DataValueField="idProfesional">
                                                            </asp:DropDownList>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <br />
                                            <div class="box">
                                                <table>
                                                    <tr>
                                                        <td style="width: 259px; height: 14px;">
                                                            <br />
                                                            <b>
                                                                <asp:Label ID="Label1" runat="server" Text="Derivaciones"></asp:Label></b>
                                                        </td>
                                                        <td style="width: 218px; height: 14px;">&nbsp;</td>
                                                        <td style="width: 217px; height: 14px;">&nbsp;</td>
                                                        <td style="width: 460px; height: 14px;">&nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 14px;" colspan="10">
                                                            <table style="width: 87%">
                                                                <tr>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerPediatria" runat="server" Text="Pediatria" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerFono" runat="server" Text="Fonoaudiol." />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerNutricion" runat="server" Text="Nutricion" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerOdonto" runat="server" Text="Odontologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerCardiologia" runat="server" Text="Cardiologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerCirugia" runat="server" Text="Cirugia" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkOftalmologia" runat="server" Text="Oftalmologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerTrauma" runat="server" Text="Traumatologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerUrologia" runat="server" Text="Urologia" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerORL" runat="server" Text="O . R . L . " OnCheckedChanged="ChkDerORL_CheckedChanged" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerTrabSocial" runat="server" Text="Trab.Social" OnCheckedChanged="ChkDerTrabSocial_CheckedChanged" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkAgenteSanitario" runat="server" Text="Agent.Sanitario" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDermatologia" runat="server" Text="Dermatologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerPsicologia" runat="server" Text="Psicologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerOtros" runat="server" Text="Otros" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerNeurologia" runat="server" Text="Neurologia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                        <asp:CheckBox ID="ChkDerPsicopedagogia" runat="server" Text="Psicopedagogia" />
                                                                    </td>
                                                                    <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">&nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10">
                                                            <br />
                                                            <b>Observaciones</b>
                                                            <br />
                                                            <asp:TextBox ID="txtObservacionesGenerales" runat="server" Width="715px" TextMode="MultiLine" ViewStateMode="Enabled"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="10">
                                                            <div class="txtcenter">
                                                                <br />
                                                                Motivo Rechazo:
                                                                <asp:DropDownList ID="ddlMotivoRechazo" runat="server" DataTextField="nombre"
                                                                    DataValueField="idObraSocial">
                                                                    <asp:ListItem>Realizado</asp:ListItem>
                                                                    <asp:ListItem Value="Neg.Alumno">Neg.Alumno</asp:ListItem>
                                                                    <asp:ListItem Value="Neg.Padre"></asp:ListItem>
                                                                    <asp:ListItem Value="Ausente">Ausente</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </asp:Panel>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <asp:CompareValidator ID="cvSexo" runat="server" ErrorMessage="Debe seleccionar el Sexo" ControlToValidate="ddlSexo" ValueToCompare="0" ValidationGroup="1"></asp:CompareValidator>
            </td>
        </tr>
    </table>
    <div class="txtcenter">
        <input type="button" value="Cancelar" onclick="history.go(-1)" title="Cancelar y volver atras" id="btnCancelar" runat="server" />
        &nbsp;&nbsp;&nbsp;
     <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" OnClick="btnGuardar_Click" TabIndex="70" Text="Guardar" ToolTip="Guardar datos" ValidationGroup="1" />
     <a href="javascript:close()" id="btnCerrar" class="lblCerrar" runat="server" visible="false">[X]-Cerrar ventana</a>
    </div>
     <br />
    <%--   <table>
       <tr>
            <td colspan="2">
                <input id="txtOculto" style="width: 1px; height: 1px" type="hidden" size="1" name="txtOculto"
                    runat="server">
                <hr />
            </td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
               
                <%--  <asp:RegularExpressionValidator ID="ValidSexo" runat="server" ControlToValidate="ddlSexo" ErrorMessage="Debe seleccionar el Sexo" ForeColor="#CC3300" ValidationExpression="&quot;^[0-9]*&quot;&gt;" ValidationGroup="1"></asp:RegularExpressionValidator>
                <asp:RegularExpressionValidator ID="ValidTAMin" runat="server" ControlToValidate="txtTAMin" ErrorMessage="Ingrese Valores Numericos TAMin" ForeColor="#CC3300" ValidationExpression="&quot;^[0-9]*&quot;&gt;" ValidationGroup="1"></asp:RegularExpressionValidator>
                &nbsp;<asp:RegularExpressionValidator ID="ValidTAMax" runat="server" ControlToValidate="txtTAMax" ErrorMessage="Ingrese Valores Numericos TA Maxima" ForeColor="#CC3300" ValidationExpression="&quot;^[0-9]*&quot;&gt;" ValidationGroup="1"></asp:RegularExpressionValidator>
                &nbsp;<asp:RegularExpressionValidator ID="ValidTAMax0" runat="server" ControlToValidate="txtAgudezaVisualDer" ErrorMessage="Ingrese Valores Numericos Agud. visual derecha" ForeColor="#CC3300" ValidationExpression="&quot;^[0-9]*&quot;&gt;" ValidationGroup="1"></asp:RegularExpressionValidator>
                &nbsp;<asp:RegularExpressionValidator ID="ValidTAMax1" runat="server" ControlToValidate="txtAgudezaVisualIzq" ErrorMessage="Ingrese Valores Numericos Agud. visual izquierda" ForeColor="#CC3300" ValidationExpression="&quot;^[0-9]*&quot;&gt;" ValidationGroup="1"></asp:RegularExpressionValidator>
                <asp:RegularExpressionValidator ID="ValidTAMax2" runat="server" ControlToValidate="txtPesoNacimiento" ErrorMessage="Ingrese Valores Numericos Peso nacimiento" ForeColor="#CC3300" ValidationExpression="&quot;^[0-9]*&quot;&gt;" ValidationGroup="1"></asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>--%>

    <script lang="javascript" type="text/javascript">
        function Careados() {

            var vOHPerC = $("#<%=txtOHPerC.ClientID%>").val();
            var vOMaloC = $("#<%=txtOMaloC.ClientID%>").val();
            var resul = eval(vOHPerC) + eval(vOMaloC);

            document.getElementById('<%= Page.Master.FindControl("cuerpo").FindControl("txtCareado").ClientID %>').value = resul;
        }
    </script>
    <script lang="javascript" type="text/javascript">
        function IMC() {

            var vOHPerC = $("#<%=txtOHPerC.ClientID%>").val();
            var vOMaloC = $("#<%=txtOMaloC.ClientID%>").val();
            var resul = eval(vOHPerC) + eval(vOMaloC);

            document.getElementById('<%= Page.Master.FindControl("cuerpo").FindControl("txtCareado").ClientID %>').value = resul;
        }

        function Operacion() {

            var peso = $("#<%=txtPesoAlumno.ClientID%>").val();
                        var talla = $("#<%=txtTalla.ClientID%>").val();
                        var resul = (peso / (talla * talla)) * 10000
                        document.getElementById('<%= Page.Master.FindControl("cuerpo").FindControl("txtIMC").ClientID %>').value = resul;
                    }
                    function AlertaSeGrabo() {
                        alert('se ha cargado la página');
                    }

                    //function confirmar() {
                    //    confirmar = confirm("¿Te gusta nuestra web?");
                    //    if (confirmar)
                    //        // si pulsamos en aceptar
                    //        alert('Has dicho que si');
                    //    else
                    //        // si pulsamos en cancelar
                    //        alert('Has dicho que no');
                    //}
    </script>
</asp:Content>
