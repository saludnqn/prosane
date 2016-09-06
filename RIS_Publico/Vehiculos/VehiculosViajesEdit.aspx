<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculosViajesEdit.aspx.cs" Inherits="Web.Vehiculos.VehiculosViajesEdit" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

  <link type="text/css"rel="stylesheet"      href="../js/jquery-ui-1.7.1.custom.css" />  
  <script type="text/javascript"      src="../js/jquery.min.js"></script> 
  <script type="text/javascript"      src="../js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="../js/jquery.ui.datepicker-es.js"></script>   
      
  <script type="text/javascript">
  
	$(function() {
		$("#<%=txtFechaInicio.ClientID %>").datepicker({
			showOn: 'button',
			buttonImage: '../App_Themes/default/images/calend1.jpg',
			buttonImageOnly: true
		});
	});

	$(function() {
		$("#<%=txtFechaFin.ClientID %>").datepicker({
			showOn: 'button',
			buttonImage: '../App_Themes/default/images/calend1.jpg',
			buttonImageOnly: true
		});
	}); 
     
  </script>  
  
  
  <script type="text/javascript" src="../js/Mascara.js"></script>
  <script type="text/javascript" src="../js/ValidaFecha.js"></script>   
  

    <%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>
 <table  width="1000px" align="center" class="myTabla">
					<tr>
						
						
						<td rowspan="10" style="vertical-align: top" >
                                            &nbsp;</td>

						
						
						<td rowspan="10" style="vertical-align: top" >
                                            <table class="myTabla" width="650px">
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
                                                                        <h5>
                                                                            <asp:Label ID="lblDatosVehiculo" runat="server" Text="Label"></asp:Label>
                                                                        </h5>
                                                                </td>
                                                                </tr>
                                                            </table>
                                                        </td>
						<td colspan="2" align="right" >
                            <asp:ImageButton ID="IBVolver" runat="server" onclick="IBVolver_Click" ImageUrl="~/App_Themes/default/images/Volver.jpg" />
                                                        </td>
					</tr>
                                            <tr>
						<td colspan="3">
                            &nbsp;</td>
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
                                                                <td colspan="2">
                                                                    <table id="TablaErrores" runat="server" bgcolor="#CC3300" cellpadding="10" 
                                                                        cellspacing="10" style="width: 100%;">
                                                                        <tr>
                                                                            <td>
                                                                                <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#F3F3F3"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Fecha Inicio</td>
                                                                <td>
                                                                    <input id="txtFechaInicio" runat="server" class="myTexto" maxlength="10" 
                                                                        onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" 
                                                                        style="width: 70px" tabindex="1" type="text" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Hora Inicio</td>
                                                                <td>
                                                                    <input id="txtHoraInicio" 
                                                                        runat="server" class="myTexto" maxlength="5" onblur="valHora(this)" 
                                                                        onkeyup="mascara(this,':',patron,true)" style="width: 70px" tabindex="2" 
                                                                        title="Ingrese la hora de Admisión" type="text" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Fecha Fin</td>
                                                                <td>
                                                                    <input id="txtFechaFin" runat="server" class="myTexto" maxlength="10" 
                                                                        onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" 
                                                                        style="width: 70px" tabindex="1" type="text" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Hora Fin</td>
                                                                <td>
                                                                    <input id="txtHoraFin" 
                                                                        runat="server" class="myTexto" maxlength="5" onblur="valHora(this)" 
                                                                        onkeyup="mascara(this,':',patron,true)" style="width: 70px" tabindex="2" 
                                                                        title="Ingrese la hora de Admisión" type="text" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Odómetro Actual (km.)</td>
                                                                <td>
                                                                    <asp:Label ID="lblOdometroActual" runat="server" Font-Size="Medium" 
                                                                        Text="Label"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Odómetro Nuevo (km.)</td>
                                                                <td>
                                                        <asp:TextBox ID="txtOdometroFin" runat="server" Width="125px" TabIndex="3" 
                                                                        Font-Size="Medium"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Origen</td>
                                                                <td>
                                                        <asp:DropDownList ID="ddlOrigen" runat="server" DataTextField="nombre" 
                                                            DataValueField="idOrigenDestino" TabIndex="4">
                                                        </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Destino</td>
                                                                <td>
                                                        <asp:DropDownList ID="ddlDestino" runat="server" DataTextField="nombre" 
                                                            DataValueField="idOrigenDestino" TabIndex="5">
                                                        </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Chofer</td>
                                                                <td>
                                                        <asp:DropDownList ID="ddlChofer" runat="server" DataTextField="nombreCompleto" 
                                                            DataValueField="idChofer" TabIndex="6">
                                                        </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 149px">
                                                                    Observaciones</td>
                                                                <td>
                                                        <asp:TextBox ID="txtObservaciones" runat="server" Width="504px" TabIndex="3" 
                                                            Height="156px" TextMode="MultiLine"></asp:TextBox>
                                                                </td>
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
                                               onclick="btnGuardar_Click" TabIndex="7" Text="Guardar" ToolTip="Guardar datos" 
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
					                        </table></td>
						
						
					</tr>
					
					</table>


			
 </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

   


</asp:Content>

