<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculosEdit.aspx.cs" Inherits="Web.Vehiculos.VehiculosEdit" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    



  <link type="text/css"rel="stylesheet"      href="../js/jquery-ui-1.7.1.custom.css" />  
  <script type="text/javascript"      src="../js/jquery.min.js"></script> 
  <script type="text/javascript"      src="../js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="../js/jquery.ui.datepicker-es.js"></script>   
      
  <script type="text/javascript">
  
	$(function() {
		$("#<%=inputFechaLecturaOdometro.ClientID %>").datepicker({
			showOn: 'button',
			buttonImage: '../App_Themes/default/images/calend1.jpg',
			buttonImageOnly: true
		});
	});
	     
  </script>    
  
  <script type="text/javascript" src="../js/Mascara.js"></script>
  <script type="text/javascript" src="../js/ValidaFecha.js"></script>   





 <table  width="1000px" align="center" class="myTabla">
					<tr>
						
						
						<td rowspan="10" style="vertical-align: top" >
                                            &nbsp;</td>

						
						
						<td rowspan="10" style="vertical-align: top" >
                                            <table class="myTabla" width="950px">
                                            <tr>
						<td style="width: 402px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 402px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 402px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 402px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 402px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 402px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 402px">
                            <table style="width:79%;">
                                <tr>
                                    <td style="width: 54px">
<img src="../App_Themes/default/images/itemRojo.png" title="" border="0" class="icon_left" />
                                        </td>
                                                                    <td>
                                                                        <h5>Vehículo</h5>
                                                                </td>
                                                                </tr>
                                                            </table>
                                                        </td>
						<td colspan="2" align="right" >
<a href="VehiculosList.aspx"><img src="../App_Themes/default/images/Volver.jpg"  height="16px" title="" border="0" width="16px" /></a>
						
                                                        </td>
					</tr>
                                            <tr>
						<td colspan="3" > <hr class="hrTitulo" /></td>
					</tr>
					<tr>
						<td colspan="3"  >
                                            <table style="width:100%;">
                                                <tr>
                                                    <td>
                                                        <table style="width:100%;">
                                                            <tr>
                                                                <td colspan="5">
                                                                
                                                                    <table style="width: 100%;" id="TablaErrores" bgcolor="#CC3300" runat="server" 
                                                                        cellpadding="10" cellspacing="10">
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#F3F3F3"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                     </table>                                                                
                                                                    
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    &nbsp;</td>
                                                                <td style="width: 354px">
                                                                    &nbsp;</td>
                                                                <td style="width: 39px">
                                                                    &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    &nbsp;</td>
                                                                <td style="width: 227px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Nº Matrícula</td>
                                                                <td style="width: 354px">
                                                        <asp:TextBox ID="txtMatricula" runat="server" Width="226px" TabIndex="1"></asp:TextBox>                                                                    
                                                                </td>
                                                                <td style="width: 39px">
                                                                    &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    Efector/Entidad</td>
                                                                <td style="width: 227px">
                                                                    <asp:DropDownList ID="ddlEfector" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7">
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Dominio</td>
                                                                <td style="width: 354px">
                                                        <asp:TextBox ID="txtDominio" runat="server" Width="226px" TabIndex="2"></asp:TextBox>
                                                                </td>
                                                                <td style="width: 39px">
                                                                    &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    &nbsp;</td>
                                                                <td style="width: 227px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 21px; width: 288px;">
                                                                    Año</td>
                                                                <td style="height: 21px; width: 354px;">
                                                        <asp:TextBox ID="txtAnio" runat="server" Width="74px" TabIndex="2"></asp:TextBox>
                                                                </td>
                                                                <td style="height: 21px; width: 39px;">
                                                                    </td>
                                                                <td style="width: 152px; height: 21px;">
                                                                    Nº de Motor</td>
                                                                <td style="width: 227px; height: 21px;">
                                                        <asp:TextBox ID="txtNumeroMotor" runat="server" Width="226px" TabIndex="8"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Tipo</td>
                                                                <td style="width: 354px">
                                                                    <asp:DropDownList ID="ddlTipoVehiculo" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idTipoVehiculo" TabIndex="2">
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 39px">
                                                                                </td>
                                                                <td style="width: 152px">
                                                                    Nº de Chasis</td>
                                                                <td style="width: 227px">
                                                        <asp:TextBox ID="txtNumeroChasis" runat="server" Width="226px" TabIndex="9"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Tracción</td>
                                                                <td style="width: 354px">
                                                                    <asp:DropDownList ID="ddlTraccion" runat="server" TabIndex="10">
                                                                        <asp:ListItem>Simple</asp:ListItem>
                                                                        <asp:ListItem>Doble</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                                </td>
                                                                <td style="width: 39px">
                                                                                &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    &nbsp;</td>
                                                                <td style="width: 227px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    &nbsp;</td>
                                                                <td style="width: 354px">
                                                                    &nbsp;</td>
                                                                <td style="width: 39px">
                                                                                &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    &nbsp;</td>
                                                                <td style="width: 227px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Odómetro (Km.)</td>
                                                                <td style="width: 354px">
                                                                    <asp:Label ID="lblOdometro" runat="server" Text="Label" Font-Size="Medium"></asp:Label>
                                                        <asp:TextBox ID="txtOdometroActual" runat="server" Width="226px" TabIndex="3" 
                                                                        Font-Size="Medium"></asp:TextBox>
                                                                </td>
                                                                <td style="width: 39px">
                                                                    &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    &nbsp;</td>
                                                                <td style="width: 227px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Fecha de última Lectura</td>
                                                                <td style="width: 354px">
                                                                    <asp:Label ID="lblFechaUltimaLectura" runat="server" Text="Label" 
                                                                        Font-Size="Medium"></asp:Label>
                                                                    <asp:Panel ID="panelFechaUltimaLectura" runat="server">
                                                                        <input id="inputFechaLecturaOdometro" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFechaNacimiento_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 70px" tabindex="4" 
                                                                        
    type="text" />
                                                                    </asp:Panel>
                                                                                </td>
                                                                <td style="width: 39px">
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    Tiene Radio ?</td>
                                                                <td style="width: 227px">
                                                                    <asp:DropDownList ID="ddlTieneRadio" runat="server" TabIndex="10">
                                                                        <asp:ListItem>NO</asp:ListItem>
                                                                        <asp:ListItem>SI</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    &nbsp;</td>
                                                                <td style="width: 354px">
                                                                    &nbsp;</td>
                                                                <td style="width: 39px">
                                                                    &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    Tiene Permiso de radio ?</td>
                                                                <td style="width: 227px">
                                                                    <asp:DropDownList ID="ddlTienePermisoRadio" runat="server" TabIndex="11">
                                                                        <asp:ListItem>NO</asp:ListItem>
                                                                        <asp:ListItem>SI</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 288px">
                                                                    Modelo</td>
                                                                <td style="width: 354px">
                                                                    <asp:DropDownList ID="ddlModelo" runat="server" DataTextField="modeloMarca" 
                                                                        DataValueField="idModelo" TabIndex="5">
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="width: 39px">
                                                                    &nbsp;</td>
                                                                <td style="width: 152px">
                                                                    &nbsp;</td>
                                                                <td style="width: 227px">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            </table>
                                                    </td>
                                                </tr>
                                                </table>
                        </td>
						
					</tr>
					<tr>
						
						<td class="style1" colspan="3">
                                            <hr /></td>
						
					</tr>
					<tr>
						<td colspan="2">
                                           <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" 
                                               onclick="btnGuardar_Click" TabIndex="12" Text="Guardar" ToolTip="Guardar datos" 
                                               ValidationGroup="0" />
<%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>
                                           
                        </td>
						
						<td align="right">
                                           
                                           &nbsp;</td>

                                                               
						
					</tr>
					<tr>
						<td colspan="3">
                                          <INPUT id="txtOculto" style="WIDTH: 1px; HEIGHT: 1px" type="hidden" size="1" name="txtOculto"
        runat="server">
                                            <hr /></td>
						
					</tr>
					<tr>
						<td class="style1" colspan="3">
                            &nbsp;</td>
						
					</tr>
					<tr>
						
						<td colspan="1" style="vertical-align: top; width: 402px;">
                            &nbsp;</td>
                                            </tr>
                                            </table></td>
						
						
					</tr>
					
					</table>


			
 </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

   


</asp:Content>
