<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prueba.aspx.cs" Inherits="RIS_Publico.prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    <form id="form1" runat="server">


    <table id="tblDatos" style="width:100%;">
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="text-align: left; height: 14px">
                                                                
                                                                    <asp:Label ID="lProvincia" runat="server" ForeColor="Black"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlProvincia" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idProvincia" TabIndex="5" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                    &nbsp;Depart.:
                                                                    <asp:DropDownList ID="ddlDepartamento" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idDepartamento" TabIndex="6" Height="41px" Width="173px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Loc.:
                                                                    <asp:DropDownList ID="ddlLocalidad" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idLocalidad" TabIndex="7" Height="42px" Width="191px" >
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                        <asp:ListItem>NEUQUEN</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 15px; text-align: left">
                                                                
                                                                    Establecimiento Educativo:
                                                                    




<%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>
                                                                    <asp:DropDownList ID="ddlEstablecimiento" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEstablecimiento" TabIndex="8" Height="31px" Width="194px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>








                                                                &nbsp;&nbsp;&nbsp; Grado:
                                                                    <asp:DropDownList ID="ddlGrado" runat="server" Enabled="true" TabIndex="9">
                                                                        <asp:ListItem Value="sd">sd</asp:ListItem>
                                                                        <asp:ListItem>1</asp:ListItem>
                                                                        <asp:ListItem>2</asp:ListItem>
                                                                        <asp:ListItem>3</asp:ListItem>
                                                                        <asp:ListItem>4</asp:ListItem>
                                                                        <asp:ListItem>5</asp:ListItem>
                                                                        <asp:ListItem>6</asp:ListItem>
                                                                        <asp:ListItem>7</asp:ListItem>
                                                                        <asp:ListItem>8</asp:ListItem>
                                                                        <asp:ListItem>9</asp:ListItem>
                                                                    </asp:DropDownList>


                                                                &nbsp;&nbsp; Division:
                                                                    <asp:DropDownList ID="ddlDivision" runat="server" Enabled="true" TabIndex="10">
                                                                        <asp:ListItem Value="sd">sd</asp:ListItem>
                                                                        <asp:ListItem>a</asp:ListItem>
                                                                        <asp:ListItem>b</asp:ListItem>
                                                                        <asp:ListItem>c</asp:ListItem>
                                                                        <asp:ListItem>d</asp:ListItem>
                                                                        <asp:ListItem>1</asp:ListItem>
                                                                        <asp:ListItem>2</asp:ListItem>
                                                                        <asp:ListItem>3</asp:ListItem>

                                                                        

                                                                    </asp:DropDownList>


                                                                &nbsp;&nbsp;&nbsp;&nbsp; Turno:
                                                                    <asp:DropDownList ID="ddlTurno" runat="server" Enabled="true" TabIndex="11" Height="18px" Width="69px">
                                                                        <asp:ListItem Value="sd">sd</asp:ListItem>
                                                                        <asp:ListItem>Mañana</asp:ListItem>
                                                                        <asp:ListItem>Tarde</asp:ListItem>
                                                                        <asp:ListItem>Vespertino</asp:ListItem>
                                                                    </asp:DropDownList>


                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                </td>
                                                                <td colspan="5" style="height: 14px; text-align: left">
                                                                
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    <span style="font-weight: normal">Fecha Nacimiento:
                                                                    <asp:Label ID="lFechaNacimiento" runat="server" ForeColor="#336699"></asp:Label>
                                                                    <input id="txtFechaNac" runat="server" class="myTexto" maxlength="10" onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" style="width: 103px" tabindex="12" type="text" visible="False" />&nbsp;
                                                                    </span>&nbsp;&nbsp;Telefono:&nbsp;&nbsp;&nbsp;
                                                                
                                                                    <span style="font-weight: normal"> <asp:TextBox runat="server" Width="191px" TabIndex="13" 
                                                                        Font-Size="Medium" Height="16px" ID="txtPacTel" style="margin-top: 0px">-</asp:TextBox>
                                                                    &nbsp;Cel.:<asp:TextBox runat="server" Width="195px" TabIndex="14" 
                                                                        Font-Size="Medium" Height="16px" ID="txtCelular" style="margin-top: 0px">-</asp:TextBox>
                                                                    </span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    Domicilio: <asp:TextBox runat="server" Width="236px" TabIndex="15" 
                                                                        Font-Size="Medium" Height="16px" ID="txtPacDom" style="margin-top: 0px"></asp:TextBox>
                                                                    &nbsp;Cobertura Medica :<asp:DropDownList ID="ddlOSocialTiene" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="16" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                &nbsp;Cual
                                                                    <table id="tableOSociales" __designer:mapid="16" style="/*font-family: &quot;Segoe UI&quot;;
  font-size: 14px;*/border-style: none; border-color: inherit; border-width: 0; margin: 0; padding: 0; font-variant: normal; vertical-align: baseline; border-collapse: collapse; border-spacing: 0; font-size: 12px; font-family: Tahoma, Arial, Helvetica, Sans-Serif; text-align: justify;">
                                                                        <tr __designer:mapid="17">
                                                                            <td __designer:mapid="18">Obra Social: </td>
                                                                            <td __designer:mapid="19">
                                                                                <div id="OS" runat="server" __designer:mapid="1a" visible="false">
                                                                                    <a id="arefOS" runat="server" __designer:mapid="1b" href="http://www.desa.saludnqn.gob.ar/sips/Paciente/ObraSocial.aspx" onclick="window.open(this.href, this.target, 'width=600,height=250,scrollbars=yes,top=100, left=100'); return false;" target="_blank" title="Click para ver la Obra Social del Paciente">
                                                                                    <img __designer:mapid="1c" alt="Ver Obra Social del Paciente" border="0" src="http://www.desa.saludnqn.gob.ar/sips/App_Themes/Paciente/images/flecha1.jpg" /></a>
                                                                                </div>
                                                                                <div __designer:mapid="1d">
                                                                                    <uc1:osociales ID="OSociales" runat="server" TabIndex="10" />
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                    </table>








                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 6px; text-align: left">
                                                                
                                                                    Nacio prematuro : 
                                                                &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlPrematuro" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="18" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">Sd</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Peso Nacimiento:
                                                        <asp:TextBox runat="server" Width="43px" TabIndex="19" 
                                                                        Font-Size="Medium" Height="16px" ID="txtPesoNacimiento">0</asp:TextBox>
                                                                &nbsp;grs</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    DATOS DEL PADRE O TUTOR</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    Datos del Padre o Tutor:
                                                        <asp:TextBox ID="txtNombre" runat="server" Width="248px" TabIndex="20" 
                                                                        Font-Size="Medium" Height="16px"></asp:TextBox>
                                                                    &nbsp; DNI del Padre o Tutor:
                                                        <asp:TextBox runat="server" Width="104px" TabIndex="21" 
                                                                        Font-Size="Medium" Height="16px" ID="txtTutorDNI">0</asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    <asp:CheckBox ID="chekAutorizacion" runat="server" Text="Autorizado por el Tutor" TabIndex="21" />
                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: center">
                                                                
                                                                    <strong>DOCENTE</strong></td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left; font-weight: 700; ">
                                                                
                                                                    Desempeño Escolar</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left; ">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left; border-left-style: solid; border-right-style: solid;">
                                                                
                                                                    <strong>Zona&nbsp;&nbsp;
                                                                    Urbana</strong>&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlZonaEstudio" runat="server" Enabled="true" TabIndex="22">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem>Urb</asp:ListItem>
                                                                        <asp:ListItem>Rur</asp:ListItem>
                                                                        
                                                                    </asp:DropDownList>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sobreedad:</strong>&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlSobreedad" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="23" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Repitente:
                                                                    <asp:DropDownList ID="ddlRepitente" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="24" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong>&nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: center">
                                                                
                                                                    <strong>EXAMEN FISICO Y ODONTOLOGICO</strong></td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="text-align: center; height: 14px">
                                                                
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;&nbsp;&nbsp; Peso kg. &nbsp;<asp:TextBox ID="txtPesoAlumno" onblur="valNumero(this)" runat="server" Width="42px" TabIndex="25" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Talla:&nbsp; &nbsp;<asp:TextBox ID="txtTalla"  onblur="valNumero(this)" runat="server" Width="38px" TabIndex="26" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; IMC:&nbsp; &nbsp;<asp:TextBox  ID="txtIMC" runat="server" Width="59px" TabIndex="27" 
                                                                        Font-Size="Medium" Height="16px" style="margin-left: 0px"></asp:TextBox>
                                                                    &nbsp;<asp:Button ID="btnCalcula" Visible="false" runat="server" CssClass="myButton"  TabIndex="64" Text="Calcula" ToolTip="Guardar datos" ValidationGroup="0" Height="23px" Width="63px" />
                                                                     <input id="btnIMC" type="button" value="IMC" onclick="Operacion();"  />
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; TA max:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtTAMax" runat="server" Width="39px" TabIndex="28" 
                                                                        Font-Size="Medium" Height="16px"></asp:TextBox>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp; TA min<asp:TextBox ID="txtTAMin" runat="server" Width="35px" TabIndex="29" 
                                                                        Font-Size="Medium" Height="16px"></asp:TextBox>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 17px; text-align: justify">
                                                                
                                                                    &nbsp;&nbsp;&nbsp; Perc.Peso&nbsp;&nbsp;<asp:TextBox ID="txtPersentiloPeso" runat="server" Width="40px" TabIndex="30" 
                                                                        Font-Size="Medium" Height="18px"></asp:TextBox>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Perc.Talla:&nbsp;<asp:TextBox ID="txtPresntiloTalla" runat="server" Width="39px" TabIndex="31" 
                                                                        Font-Size="Medium" Height="16px"></asp:TextBox>
                                                                &nbsp;&nbsp;&nbsp; Perc. IMC: <asp:TextBox ID="txtPercentiloIMC" runat="server" Width="38px" TabIndex="32" 
                                                                        Font-Size="Medium" Height="16px"></asp:TextBox>
                                                                    &nbsp;Pers.TA max:&nbsp;<strong><asp:DropDownList ID="ddlPerTAMax" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="24" Height="35px" Width="56px">
                                                                        <asp:ListItem Value="<=90">&lt;=90</asp:ListItem>
                                                                        <asp:ListItem Value=">90">&gt;90</asp:ListItem>
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong>&nbsp; Pers.TA min:&nbsp;&nbsp;<strong><asp:DropDownList ID="ddlPerTAMin" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="24" Height="33px" Width="59px" style="margin-left: 0px">
                                                                        <asp:ListItem Value="&lt;=90"><=90</asp:ListItem>
                                                                        <asp:ListItem Value="NO">>90</asp:ListItem>
                                                                        <asp:ListItem Value="SI">SD</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;EXAMEN FÍSICO</td>
                                                            </tr>


                                                            <tr>
                                                                <td colspan="9" style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 13px; text-align: center; font-weight: 700;" class="art-postfootericons">
                                                                    Examen Fisico</td>
                                                                <td style="width: 217px; height: 13px; text-align: center;" class="art-postfootericons">
                                                                    <strong>Patologico</strong></td>
                                                                <td style="height: 13px; text-align: center; font-weight: 700;" class="art-postfootericons" colspan="2">
                                                                    Esquema. de Vacunas</td>
                                                                <td style="height: 13px; text-align: justify;" class="art-postfootericons">
                                                                    </td>
                                                                <td style="height: 13px; text-align: justify;" class="art-postfootericons" colspan="4">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px; text-align: justify;" class="ui-priority-primary">
                                                                    Piel y fanera</td>
                                                                <td style="width: 217px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    <asp:DropDownList ID="ddlPielFaneras" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="35" Height="42px" Width="191px" style="margin-bottom: 0px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    Trajo Carnet:</td>
                                                                <td style="width: 59px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    <strong>
                                                                    <asp:DropDownList ID="ddlTrajoCarnet" runat="server" DataTextField="nombre" TabIndex="42" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong></td>
                                                                <td style="height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify;" class="art-postfootericons" colspan="4">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Cardiovascular:</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlCardiovascular" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="36" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    Vacuna Completa</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    <strong>
                                                                    <asp:DropDownList ID="ddlVaunaCompleto" runat="server" DataTextField="nombre" TabIndex="43" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong></td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Respiratorio:<b> </b> </td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlRespiratorio" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="37" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    Se vacuno en la Esc.</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    <strong>
                                                                    <asp:DropDownList ID="ddlSeVacunoEscuela" runat="server" DataTextField="nombre" TabIndex="44" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong></td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Genital y/o desarrollo</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlGenital" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="38" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Abdomen:</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlAbdomen" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="39" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Osteocular:</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlOstocular" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="40" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Neurologico:</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlNeurologico" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idPSMEFisicoItems" TabIndex="41" Height="42px" Width="191px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    <b></b></td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    <b>Oftalmologia</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    <b></td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </b></b></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;" colspan="7">
                                                                    Fonoaudilogia</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Estrabismo</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <strong>
                                                                    <asp:DropDownList ID="ddlEstravismo" runat="server" DataTextField="nombre" TabIndex="45" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong>
                                                                </td>
                                                                <td style="height: 14px;" colspan="7">
                                                                    <asp:CheckBox ID="chekAudimotria" runat="server" Text="Audiometria" TabIndex="49" />
                                                                &nbsp;&nbsp;
                                                                    <asp:CheckBox ID="chekTato" runat="server" Text="Tato" TabIndex="50" />
                                                                &nbsp;&nbsp;<asp:TextBox ID="txtValorTato" runat="server" Width="34px" TabIndex="51" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                    &nbsp;&nbsp;
                                                                    <asp:CheckBox ID="chekDiapason" runat="server" Text="Diapason" TabIndex="52" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Usa Lentes</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <strong>
                                                                    <asp:DropDownList ID="ddlUsaLentes" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="46" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong>
                                                                </td>
                                                                <td style="height: 14px;" colspan="5">
                                                                    Hipoacusia<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <asp:DropDownList ID="ddlHipoacusia" runat="server" DataTextField="nombre" TabIndex="53" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong></td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Agud.Visual Izquierda</td>
                                                                <td style="width: 217px; height: 14px;">
                                                        <asp:TextBox ID="txtAgudezaVisualIzq" runat="server" Width="70px" TabIndex="47" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                </td>
                                                                <td style="height: 14px;" colspan="5">
                                                                    Tans. de Fonacion<strong><asp:DropDownList ID="ddlFonacion" runat="server" DataTextField="nombre" TabIndex="54" Height="35px" Width="46px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem Value="NO">No</asp:ListItem>
                                                                        <asp:ListItem Value="SI">Si</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </strong></td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Agud.Visual Derecha</td>
                                                                <td style="width: 217px; height: 14px;">
                                                        <asp:TextBox ID="txtAgudezaVisualDer" runat="server" Width="65px" TabIndex="48" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan = 9 style="width: 281px; height: 14px;">
                                                                    <strong>Observaciones</strong></td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan = 9 style="width: 281px; height: 14px;">
                                                        <asp:TextBox ID="txtObservaciones" runat="server" Width="715px" TabIndex="55" 
                                                                        Font-Size="Medium" Height="49px" ViewStateMode="Enabled"></asp:TextBox>
                                                                </td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;">
                                                                    </b></td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan = 9 style="width: 281px; height: 15px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 15px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 15px;">
                                                                    </td>
                                                                <td style="height: 15px;">
                                                                    </td>
                                                                <td style="height: 15px;">
                                                                    </td>
                                                                <td style="width: 142px; height: 15px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan = 9 style="width: 281px; height: 14px;">
                                                                    <strong>Responsable:</strong><br />
&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlResponsableFicha" runat="server" DataTextField="ApellidoyNombre" 
                                                                        DataValueField="idProfesional" TabIndex="56" Height="41px" Width="315px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px; font-weight: 700;">
                                                                    Odontologia</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 460px; height: 14px; text-align: center;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; width: 59px;">
                                                                    C.E.O.D.</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Habit.Perniciosos</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlHabitPerniciosos" runat="server" Enabled="true" TabIndex="56">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem>SI</asp:ListItem>
                                                                        <asp:ListItem>NO</asp:ListItem>
                                                                        
                                                                    </asp:DropDownList>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    </td>
                                                                <td style="width: 460px; height: 14px; text-align: left;">
                                                                        &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; width: 59px;">
                                                        <asp:TextBox ID="txtOHPerC" runat="server" Width="28px" TabIndex="59" 
                                                             onblur="Careados();" Font-Size="Medium" Height="16px" >0</asp:TextBox>
                                                                </td>
                                                                <td style="height: 14px;">
                                                        <asp:TextBox ID="txtOHPerE" runat="server" Width="28px" TabIndex="59" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                    </td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                        <asp:TextBox ID="txtOHPerO" runat="server" Width="28px" TabIndex="59" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Maloclusion</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlMaloclusion" runat="server" Enabled="true" TabIndex="57">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem>SI</asp:ListItem>
                                                                        <asp:ListItem>NO</asp:ListItem>
                                                                        
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; width: 59px;">
                                                                    C.P.O.D</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Fluor Aplicado</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlFluorAplicado" runat="server" Enabled="true" TabIndex="58" Height="16px">
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem>SI</asp:ListItem>
                                                                        <asp:ListItem>NO</asp:ListItem>
                                                                        
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px; text-align: center; width: 59px;">
                                                        <asp:TextBox ID="txtOMaloC" runat="server" Width="28px" TabIndex="59" 
                                                            onblur="Careados();"  Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                </td>
                                                                <td style="height: 14px;">
                                                        <asp:TextBox ID="txtOMaloP" runat="server" Width="28px" TabIndex="59" 
                                                                     onblur="Careados();"    Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                </td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                        <asp:TextBox ID="txtOMaloO" runat="server" Width="28px" TabIndex="59" 
                                                                        Font-Size="Medium" Height="16px">0</asp:TextBox>
                                                                </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Ens.Tec.Hig.Bucal</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    <asp:DropDownList ID="ddlTecnicaHigBucal" runat="server" Enabled="true" TabIndex="56">
                                                                        <asp:ListItem>SI</asp:ListItem>
                                                                        <asp:ListItem Value="SD">SD</asp:ListItem>
                                                                        <asp:ListItem>NO</asp:ListItem>
                                                                        
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    Cariados</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;&nbsp;
                                                                        <asp:TextBox ID="txtCareado" runat="server" Width="28px" TabIndex="61" 
                                                                        Font-Size="Medium" Height="16px" style="text-align: left" Enabled="False">0</asp:TextBox>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Responsable</td>
                                                                <td colspan = 3 style="height: 14px;">
                                                                    <asp:DropDownList ID="ddlResponsableOdonto" runat="server" DataTextField="ApellidoyNombre" 
                                                                        DataValueField="idProfesional" TabIndex="62" Height="41px" Width="315px">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    <asp:Label ID="Label1" runat="server" Text="Derivaciones"></asp:Label>
                                                                </td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px;" colspan="9">
                                                                    <table style="width: 87%">
                                                                        <tr>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 179px;">
                                                                    <asp:CheckBox ID="ChkDerPediatria" runat="server" Text="Pediatria" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 292px;">
                                                                    <asp:CheckBox ID="ChkDerFono" runat="server" Text="Fonoaudiol." TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px; width: 253px;">
                                                                    <asp:CheckBox ID="ChkDerNutricion" runat="server" Text="Nutricion" TabIndex="70" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px; width: 179px;">
                                                                    <asp:CheckBox ID="ChkDerOdonto" runat="server" Text="Odontologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 292px;">
                                                                    <asp:CheckBox ID="ChkDerCardiologia" runat="server" Text="Cardiologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 253px;">
                                                                    <asp:CheckBox ID="ChkDerCirugia" runat="server" Text="Cirugia" TabIndex="70" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px; width: 179px;">
                                                                    <asp:CheckBox ID="ChkOftalmologia" runat="server" Text="Oftalmologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 292px;">
                                                                    <asp:CheckBox ID="ChkDerTrauma" runat="server" Text="Traumatologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 253px;">
                                                                    <asp:CheckBox ID="ChkDerUrologia" runat="server" Text="Urologia" TabIndex="70" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px; width: 179px; height: 28px;">
                                                                    <asp:CheckBox ID="ChkDerORL" runat="server" Text="O . R . L . " TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 292px; height: 28px;">
                                                                    <asp:CheckBox ID="ChkDerTrabSocial" runat="server" Text="Trab.Social" TabIndex="70" OnCheckedChanged="ChkDerTrabSocial_CheckedChanged" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 253px; height: 28px;">
                                                                    <asp:CheckBox ID="ChkAgenteSanitario" runat="server" Text="Agent.Sanitario" TabIndex="70" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px; width: 179px;">
                                                                    <asp:CheckBox ID="ChkDermatologia" runat="server" Text="Dermatologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 292px;">
                                                                    <asp:CheckBox ID="ChkDerPsicologia" runat="server" Text="Psicologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 253px;">
                                                                    <asp:CheckBox ID="ChkDerOtros" runat="server" Text="Otros" TabIndex="70" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px; width: 179px;">
                                                                    <asp:CheckBox ID="ChkDerNeurologia" runat="server" Text="Neurologia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 292px;">
                                                                    <asp:CheckBox ID="ChkDerPsicopedagogia" runat="server" Text="Psicopedagogia" TabIndex="70" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px; width: 253px;">
                                                                                &nbsp;</td>
                                                                        </tr>
                                                                    </table>
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; width: 132px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 218px; height: 14px;">Observaciones</td>
                                                                <td style="width: 217px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 460px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan ="8" style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan ="9" style="width: 281px; height: 14px;">
                                                                    &nbsp;&nbsp;<asp:TextBox ID="txtObservacionesGenerales" runat="server" Width="715px" TabIndex="63" 
                                                                        Font-Size="Medium" Height="49px" ViewStateMode="Enabled"></asp:TextBox>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;</strong>
                                                                
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan ="9" style="width: 281px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            
                                                            <tr>
                                                                <td style="width: 218px">
                                                                    &nbsp;</td>
                                                                <td style="width: 217px; text-align: right;">
                                                                    Motivo Rechazo</td>
                                                                <td style="width: 460px">
                                                                    <asp:DropDownList ID="ddlMotivoRechazo" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idObraSocial" TabIndex="71" Height="33px" Width="171px">
                                                                        <asp:ListItem>Realizado</asp:ListItem>
<asp:ListItem Value="Neg.Alumno">Neg.Alumno</asp:ListItem>
                                                                            <asp:ListItem Value="Neg.Padre"></asp:ListItem>
                                                                        <asp:ListItem Value="Ausente">Ausente</asp:ListItem>
                                                                    </asp:DropDownList>








                                                                    </td>
                                                                <td style="width: 59px">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                                <td colspan="2" style="width: 132px">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px" colspan="2">
                                                                    <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" onclick="btnGuardar_Click"   TabIndex="64" Text="Guardar" ToolTip="Guardar datos" ValidationGroup="0" />
                                                                    <%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>

                                                                </td>
                                                            </tr>
                                                            </table>


    </form>


</body>
</html>
