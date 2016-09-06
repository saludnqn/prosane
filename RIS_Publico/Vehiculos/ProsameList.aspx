<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProsameList.aspx.cs" Inherits="Web.Vehiculos.ProsameList" MasterPageFile="~/Site1.Master" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

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
                                                                        <h5>Alumno</h5>
                                                                </td>
                                                                </tr>
                                                            </table>
                                                        </td>
						<td colspan="2" align="right" >
<a href="../Principal.aspx"><img src="../App_Themes/default/images/Volver.jpg"  height="16px" title="" border="0" width="16px" /></a>
						
                                                        </td>
					</tr>
                                            <tr>
						<td colspan="3" > <hr class="hrTitulo" /></td>
					</tr>
					<tr>
						<td colspan="3"  >
                                            <table style="width:100%;">
                                                <tr>
                                                    <td style="width: 112px">
                                                        DNI</td>
                                                    <td>
                                                        <asp:TextBox ID="tNombre" runat="server" Width="136px" TabIndex="1"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 112px">
                                                        Nombre</td>
                                                    <td>
                                                        <asp:TextBox ID="tApellido" runat="server" Width="361px" TabIndex="1"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 112px">
                                                        Apellido</td>
                                                    <td>
                                                        <asp:TextBox ID="cboNombre" runat="server" Width="359px" TabIndex="1"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 112px">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 112px">
                                                        Establecimiento</td>
                                                    <td>
                                                        <asp:DropDownList ID="cboEstablecimiento" runat="server" DataTextField="nombre" 
                                                            DataValueField="idEstablecimiento" TabIndex="2" Width="211px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 112px">
                                                        Efector/Entidad</td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlEstablecimeinto" runat="server" DataTextField="nombre" 
                                                            DataValueField="idEntidad" TabIndex="2" Height="16px" Width="209px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 112px">
                                                        &nbsp;</td>
                                                    <td>
                                                        &nbsp;</td>
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
<%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%><table 
                                               style="width: 100%; height: 41px;">
                                               <tr>
                                                   <td style="width: 200px">
                                           <asp:Button ID="btnBuscar" runat="server" CssClass="myButton" 
                                           onclick="btnBuscar_Click" TabIndex="7" Text="Buscar" ValidationGroup="0" 
                                           Width="77px" />
                                                   </td>
                                                   <td>
                                                       <table style="width:100%;">
                                                           <tr>
                                                               <td>
                                           
                                           <asp:HyperLink ID="LinkNuevoVehiculo" runat="server"
                                               Font-Bold="True" Font-Size="9pt" Font-Underline="True" ForeColor="Maroon" 
                                               ToolTip="Crear un nuevo Vehiculo" onclick="nuevoVeiculo_Click" 
                                               NavigateUrl="../Vehiculos/VehiculosEdit.aspx" TabIndex="9" style="text-align: center">Nuevo Alumno</asp:HyperLink>
                                                               </td>
                                                               <td>
                                                                   &nbsp;</td>
                                                               <td>
                                                                   &nbsp;</td>
                                                               <td style="width: 17px">
                                                                   &nbsp;</td>
                                                               <td>
                                           
                                                           <asp:Button ID="btnImprimirListadoDeVehiculos" runat="server" 
                                                               CssClass="myButton" onclick="btnImprimirListadoDeVehiculos_Click" TabIndex="8" 
                                                               Text="Imprimir" ValidationGroup="0" Width="115px" />
                                                                   <asp:CheckBox ID="chekReducido" runat="server" 
                                                               oncheckedchanged="CheckBox1_CheckedChanged" Text="Reducido" />
                                                               </td>
                                                           </tr>
                                                       </table>
                                                   </td>
                                               </tr>
                                           </table>
&nbsp;</td>
						
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
                            <asp:GridView ID="gvLista" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" CellPadding="5" DataKeyNames="idVehiculo" 
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


                                    <asp:BoundField HeaderText="idVehiculo" DataField="idVehiculo" Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="Efector" HeaderText="Efector" />
                                    <asp:BoundField DataField="DNI" HeaderText="DNI" />
                                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                    <asp:BoundField DataField="Establacimiento" HeaderText="Establecimiento" />
                                    

                                    
                                    
                                    <asp:TemplateField HeaderText="PMP">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="PMP" runat="server" 
                                                ImageUrl="~/App_Themes/default/images/resumen.png" CommandName="PMP" />
                                        </ItemTemplate>
                                        <ItemStyle Height="20px" HorizontalAlign="Center" Width="20px" />
                                    </asp:TemplateField>    
                                    
                                    <asp:TemplateField HeaderText="Movimientos">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="Viajes" runat="server" 
                                                ImageUrl="~/App_Themes/default/images/resumen.png" CommandName="Viajes" />
                                        </ItemTemplate>
                                        <ItemStyle Height="20px" HorizontalAlign="Center" Width="20px" />
                                    </asp:TemplateField>     
                                    
                                    <asp:TemplateField HeaderText="Novedades">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="Movimientos" runat="server" 
                                                ImageUrl="~/App_Themes/default/images/resumen.png" CommandName="Movimientos" />
                                        </ItemTemplate>
                                        <ItemStyle Height="20px" HorizontalAlign="Center" Width="20px" />
                                    </asp:TemplateField>   
                                    
                                    <asp:TemplateField HeaderText="Accidentes">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="Accidentes" runat="server" 
                                                ImageUrl="~/App_Themes/default/images/resumen.png" CommandName="Accidentes" />
                                        </ItemTemplate>
                                        <ItemStyle Height="20px" HorizontalAlign="Center" Width="20px" />
                                    </asp:TemplateField> 
                                    
                                    
                                                                                                                                 

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

