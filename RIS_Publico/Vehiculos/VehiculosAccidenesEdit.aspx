<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculosAccidenesEdit.aspx.cs" Inherits="Web.Vehiculos.VehiculosAccidenesEdit" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    





  <link type="text/css"rel="stylesheet"      href="../js/jquery-ui-1.7.1.custom.css" />  
  <script type="text/javascript"      src="../js/jquery.min.js"></script> 
  <script type="text/javascript"      src="../js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="../js/jquery.ui.datepicker-es.js"></script>   
      
  <script type="text/javascript">
  
	$(function() {
		$("#<%=txtFecha.ClientID %>").datepicker({
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
                                                        &nbsp;</td>
					</tr>
                                            <tr>
						<td colspan="3" > <hr class="hrTitulo" /></td>
					</tr>
					<tr>
						<td colspan="3"  >
                                            <table style="width:100%;">
                                                <tr>
                                                    <td style="width: 171px">
                                                        Fecha</td>
                                                    <td>
                                                        <asp:TextBox ID="txtFecha" runat="server" maxlength="10" 
                                                            onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" 
                                                            style="width: 70px"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        Descripción</td>
                                                    <td>
                                                        <asp:TextBox ID="txtDescripcion" runat="server" Width="555px" TabIndex="1" 
                                                            Height="168px" TextMode="MultiLine"></asp:TextBox>
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
                                               onclick="btnGuardar_Click" TabIndex="4" Text="Guardar" ToolTip="Guardar datos" 
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
