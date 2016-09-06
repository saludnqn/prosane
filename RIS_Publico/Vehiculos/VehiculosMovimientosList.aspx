<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculosMovimientosList.aspx.cs" Inherits="Web.Vehiculos.VehiculoMovimientoList" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

  <link type="text/css"rel="stylesheet"      href="../js/jquery-ui-1.7.1.custom.css" />  
  <script type="text/javascript"      src="../js/jquery.min.js"></script> 
  <script type="text/javascript"      src="../js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="../js/jquery.ui.datepicker-es.js"></script>   
      
  <script type="text/javascript">
  
	$(function() {
		$("#<%=txtFechaDesde.ClientID %>").datepicker({
			showOn: 'button',
			buttonImage: '../App_Themes/default/images/calend1.jpg',
			buttonImageOnly: true
		});
	});

	$(function() {
		$("#<%=txtFechaHasta.ClientID %>").datepicker({
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
                                            <table class="myTabla" width="650px">
                                            <tr>
						<td style="width: 611px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 611px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 611px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 611px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 611px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 611px">
                            &nbsp;</td>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td style="width: 611px">
                            <table style="width:107%;">
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
                                                    <td style="width: 154px">
                                                        Inico</td>
                                                    <td>
                                                    
                                                    
                                                        <asp:TextBox ID="txtFechaDesde" runat="server" maxlength="10" 
                                                                                 onblur="valFecha(this)" 
                                                                                onkeyup="mascara(this,'/',patron,true)"
                                                                                        style="width: 70px"></asp:TextBox>                                                   
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 154px">
                                                        Fin</td>
                                                    <td>
                                                        <asp:TextBox ID="txtFechaHasta" runat="server" maxlength="10" 
                                                                                 onblur="valFecha(this)" 
                                                                                onkeyup="mascara(this,'/',patron,true)" tabindex="1"
                                                                                        style="width: 70px"></asp:TextBox>                                                   
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 154px">
                                                        Tipo de Novedad</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlTipoMovimiento" runat="server" DataTextField="nombre" 
                                                            DataValueField="idTipoMovimiento" TabIndex="2">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 154px">
                                                        Proveedor</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlProveedor" runat="server" DataTextField="nombre" 
                                                            DataValueField="idProveedor" TabIndex="3">
                                                        </asp:DropDownList>
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
                                           <asp:Button ID="btnBuscar" runat="server" CssClass="myButton" 
                                           onclick="btnBuscar_Click" TabIndex="4" Text="Buscar" ValidationGroup="0" 
                                           Width="77px" />
<%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>
                                           
                                           </td>
						
						<td align="right">
                                           
                                           <asp:LinkButton ID="lnkBtnNuevoMovimiento" runat="server" 
                                               onclick="lnkBtnNuevoMovimiento_Click" TabIndex="5">Nueva Novedad</asp:LinkButton>
                                           
                        </td>

                                                               
						
					</tr>
					<tr>
						<td colspan="3">
                                          <INPUT id="txtOculto" style="WIDTH: 1px; HEIGHT: 1px" type="hidden" size="1" name="txtOculto"
        runat="server">
                                            <hr /></td>
						
					</tr>
					<tr>
						<td class="style1" colspan="3">
                            <asp:GridView ID="gvLista" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellPadding="5" DataKeyNames="idMovimiento" 
                                EmptyDataText="No se encontraron datos para los filtros ingresados" 
                                EnableTheming="True" Font-Bold="False" Font-Names="Arial" Font-Size="13pt" 
                                ForeColor="#333333" onpageindexchanging="gvLista_PageIndexChanging" 
                                onrowcommand="gvLista_RowCommand" onrowdatabound="gvLista_RowDataBound" 
                                Width="100%">
                                <RowStyle BackColor="#F7F6F3" Font-Names="Arial" Font-Size="10pt" 
                                    ForeColor="#333333" />
                                <Columns>
                                
                                
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="Modificar" runat="server" 
                                                ImageUrl="~/App_Themes/default/images/editar.png" CommandName="Modificar" />
                                        </ItemTemplate>
                                        <ItemStyle Height="20px" HorizontalAlign="Center" Width="20px" />
                                    </asp:TemplateField>    


                                    <asp:BoundField HeaderText="idMovimiento" DataField="idMovimiento" 
                                        Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="idVehiculo" HeaderText="idVehiculo" 
                                        Visible="False" />
                                    <asp:BoundField DataField="fechaHoraRealizacion" 
                                        HeaderText="Fecha Realización" />
                                    <asp:BoundField DataField="idTipoMovimiento" HeaderText="idTipoMovimiento" 
                                        Visible="False" />
                                    <asp:BoundField DataField="tipoMovimiento" HeaderText="Tipo de Novedad" />
                                    <asp:BoundField DataField="idProveedor" HeaderText="idProveedor" 
                                        Visible="False" />
                                    <asp:BoundField DataField="proveedor" HeaderText="Proveedor" />
                                    <asp:BoundField DataField="importe" HeaderText="Importe" />

                                </Columns>
                                <FooterStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#990000" ForeColor="White" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#990000" Font-Bold="False" Font-Italic="False" 
                                    Font-Names="Arial" Font-Size="10pt" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
                        </td>
						
					</tr>
					<tr>
						
						<td colspan="1" style="vertical-align: top; width: 611px;">
                            &nbsp;</td>
                                            </tr>
                                            </table></td>
						
						
					</tr>
					
					</table>


			
 </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

   


</asp:Content>
