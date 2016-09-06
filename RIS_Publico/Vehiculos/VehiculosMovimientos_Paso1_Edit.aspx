<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculosMovimientos_Paso1_Edit.aspx.cs" Inherits="Web.Vehiculos.VehiculosMovimientos_Paso1_Edit" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    






<link type="text/css"rel="stylesheet"      href="../js/jquery-ui-1.7.1.custom.css" />  
  <script type="text/javascript"      src="../js/jquery.min.js"></script> 
  <script type="text/javascript"      src="../js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="../js/jquery.ui.datepicker-es.js"></script>   
      
  <script type="text/javascript">
  
	$(function() {
		$("#<%=txtFechaRealizacion.ClientID %>").datepicker({
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
                            <table style="width:151%;">
                                <tr>
                                    <td style="width: 54px">
<img src="../App_Themes/default/images/itemRojo.png" title="" border="0" class="icon_left" />
                                        </td>
                                                                    <td>
                                                                        <h5><asp:Label ID="lblDatosVehiculo" runat="server" Text="Label"></asp:Label></h5>
                                                                        
                                                                </td>
                                                                </tr>
                                                            </table>
                                                        </td>
						<td colspan="2" align="right" >
                            <asp:ImageButton ID="IBVolver" runat="server" onclick="IBVolver_Click" ImageUrl="~/App_Themes/default/images/Volver.jpg" />
                                                        </td>
					</tr>
                                            <tr>
						<td colspan="3" > <hr class="hrTitulo" /></td>
					</tr>
					<tr>
						<td colspan="3"  >
                                            <table style="width:100%;">
                                                <tr>
                                                    <td style="width: 171px">
                                                        Fecha de Realización</td>
                                                    <td>
                                                        <asp:TextBox ID="txtFechaRealizacion" runat="server" Width="92px" TabIndex="3"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        Tipo de Novedad</td>
                                                    <td>
                                                                    <asp:DropDownList ID="ddlTipoMovimiento" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idTipoMovimiento" TabIndex="1">
                                                                    </asp:DropDownList>
                                                                </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        Proveedor</td>
                                                    <td>
                                                                    <asp:DropDownList ID="ddlProveedor" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idProveedor" TabIndex="2">
                                                                    </asp:DropDownList>
                                                                </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        Importe</td>
                                                    <td>
                                                        <asp:TextBox ID="txtImporte" runat="server" Width="92px" TabIndex="3"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        Descripción</td>
                                                    <td>
                                                        <asp:TextBox ID="txtDescripcion" runat="server" Width="504px" TabIndex="3" 
                                                            Height="156px" TextMode="MultiLine"></asp:TextBox>
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
                                           <asp:Button ID="btnGuardarYPaso2" runat="server" CssClass="myButton" 
                                               onclick="btnGuardarYPaso2_Click" TabIndex="4" Text="Paso 2" ToolTip="Guardar datos e ir al Paso 2" 
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
