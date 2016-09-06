<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehiculoPMPHistoricoList.aspx.cs" Inherits="Web.Vehiculos.VehiculoPMPHistoricoList" MasterPageFile="~/Site1.Master" %>

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
						<td colspan="2">
<%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>
                                           
                        </td>
						
						<td align="right">
                                           
                                           <asp:LinkButton ID="lnkBtnNuevoPMPRealizado" runat="server" 
                                               onclick="lnkBtnNuevoPMPRealizado_Click" TabIndex="5">Nuevo PMP realizado</asp:LinkButton>
                                           
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
                                AutoGenerateColumns="False" CellPadding="5" DataKeyNames="idHistoricoVehiculoPMP" 
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
                            <asp:ImageButton ID="Editar" runat="server" ImageUrl="~/App_Themes/default/images/editar.png" 
                            />
                            </ItemTemplate>
                          
                               <ItemStyle Width="18px" HorizontalAlign="Center" Height="18px" />
                          
                        </asp:TemplateField>
                                    <asp:BoundField HeaderText="idVehiculo" DataField="idVehiculo" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="idVehiculoPMP" HeaderText="idVehiculoPMP" 
                                        Visible="False" />
                                    <asp:BoundField HeaderText="idPMP" DataField="idPMP" Visible="False" />
                                    <asp:BoundField HeaderText="idHistoricoVehiculoPMP" 
                                        DataField="idHistoricoVehiculoPMP" Visible="False" />
                                    <asp:BoundField HeaderText="Fecha de Realización" DataField="fecha" />
                                    <asp:BoundField DataField="kilometraje" HeaderText="Kilometraje" />
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
						
						<td colspan="1" style="vertical-align: top; width: 402px;">
                            &nbsp;</td>
                                            </tr>
                                            </table></td>
						
						
					</tr>
					
					</table>


			
 </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

   


</asp:Content>
