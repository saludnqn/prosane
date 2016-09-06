﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculosMovimientos_Paso2_Edit.aspx.cs" Inherits="Web.Vehiculos.VehiculosMovimientos_Paso2_Edit" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

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
                                                        Items de Novedad</td>
                                                    <td>
                                                                    <table style="width:100%;">
                                                                        <tr>
                                                                            <td style="width: 42px">
                                                                    <asp:DropDownList ID="ddlItemMovimiento" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idItemMovimiento">
                                                                    </asp:DropDownList>
                                                                            </td>
                                                                            <td>                                                                                    
                                                                                <asp:Button ID="BtnAgregarItemMovimientos" runat="server" CssClass="myButton" 
                                                                                    onclick="btnAgregarItemMovimiento_Click" TabIndex="1" Text="Agregar" ToolTip="Agregar Items" 
                                                                                ValidationGroup="0" />                                                                                    
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 171px">
                                                        &nbsp;</td>
                                                    <td>
                            <asp:GridView ID="gvLista" runat="server" 
                                AutoGenerateColumns="False" CellPadding="5" DataKeyNames="idMovimientoItemMovimiento" 
                                EmptyDataText="Lista vacía" 
                                EnableTheming="True" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" 
                                ForeColor="#333333" 
                                onrowcommand="gvLista_RowCommand" onrowdatabound="gvLista_RowDataBound" 
                                Width="100%">
                                <RowStyle BackColor="#F7F6F3" Font-Names="Arial" Font-Size="8pt" 
                                    ForeColor="#333333" />
                                <Columns>
                                    <asp:TemplateField>
                            <ItemTemplate>
                            <asp:ImageButton ID="Editar" runat="server" ImageUrl="~/App_Themes/default/images/delete.png" 
                            />
                            </ItemTemplate>
                          
                               <ItemStyle Width="18px" HorizontalAlign="Center" Height="18px" />
                          
                        </asp:TemplateField>
                                    <asp:BoundField DataField="idMovimientoItemMovimiento" 
                                        HeaderText="idMovimientoItemMovimiento" Visible="False" />
                                    <asp:BoundField DataField="idMovimiento" HeaderText="idMovimiento" 
                                        Visible="False" />
                                    <asp:BoundField HeaderText="idItemMovimiento" DataField="idItemMovimiento" 
                                        Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="nombre" HeaderText="Item" />
                                </Columns>
                                <FooterStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#990000" ForeColor="White" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#990000" Font-Bold="False" Font-Italic="False" 
                                    Font-Names="Arial" Font-Size="7.5pt" ForeColor="White" />
                                <EditRowStyle BackColor="#999999" />
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            </asp:GridView>
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
                                           <asp:Button ID="btnFinalizar" runat="server" CssClass="myButton" 
                                               onclick="btnFinalizar_Click" TabIndex="2" Text="Finalizar" ToolTip="Finalizar" 
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
