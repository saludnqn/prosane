    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AntecedentesFamiliares.aspx.cs" Inherits="RIS_Publico.AntecedentesFamiliares"
    MasterPageFile="~/mInterconsultas.Master" %>

<%@ Register src="UserControl/DiagnosticoPrincipal.ascx" tagname="DiagnosticoPrincipal" tagprefix="uc1" %>

<asp:Content ID="content2" ContentPlaceHolderID="cuerpo" runat="server">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <table width="1000px" align="center" class="myTabla">
        <tr>



            <td rowspan="10" style="vertical-align: top">
                <table class="myTabla" width="950px">
                    <tr>
                        <td>
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <table style="width: 100%;">
                                            <tr>
                                                <td style="height: 14px; text-align: center; width: 56px;">&nbsp;</td>
                                                <td colspan="9" style="height: 14px; text-align: left">
                                                    <table style="width:100%;">
                                                        <tr>
                                                            <td colspan="2" style="text-align: center; height: 23px;">
                                                                &nbsp;
                                                            &nbsp;&nbsp;
                                                                <asp:Label ID="lPaciente" runat="server" ForeColor="#336699" style="text-align: center" CssClass="ui-priority-primary"></asp:Label>
                                                            </td>
                                                            <td style="height: 23px"></td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 145px">
                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                                <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
                                                                                </td>
                                                            <td>
                                                                <asp:Label ID="ldniPaciente" runat="server" ForeColor="#336699" CssClass="ui-priority-primary" Visible="False"></asp:Label>
                                                            </td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                <asp:Label ID="lbExistenRegistros" runat="server" Text="No existen registros de Antecedentes Medicos" Visible="False"></asp:Label>
                        <asp:TreeView ID="TreeView1" runat="server" BorderStyle="Solid" BorderWidth="2px"
                            Width="95%" Font-Bold="False" BackColor="White" SkipLinkText="" ShowLines="True"
                            ExpandDepth="0">
                            <RootNodeStyle Font-Bold="True" ForeColor="Black" />
                            <NodeStyle Font-Bold="False" ForeColor="Black" />
                        </asp:TreeView>
                                                            </td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:Button ID="BtnMasAntecedentes" runat="server" OnClick="BtnMasAntecedentes_Click" style="text-align: center" Text="+" Width="38px" />
                                                            </td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 23px;" colspan="2">
                                                                <asp:Panel ID="PanelAlta" runat="server" Visible="False">
                                                                    <table style="width:100%;">
                                                                        <tr>
                                                                            <td colspan="3" style="height: 22px">Parentesco:&nbsp;&nbsp;
                                                                                <asp:DropDownList ID="ddlParentesco" runat="server" DataTextField="nombre" DataValueField="id" Height="41px" TabIndex="52" Width="315px">
                                                                                    <asp:ListItem Value=""></asp:ListItem>
                                                                                </asp:DropDownList>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="3" style="height: 22px">Diag.:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                                <uc1:DiagnosticoPrincipal ID="DiagnosticoPrincipal" runat="server" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>&nbsp;</td>
                                                                            <td>&nbsp;</td>
                                                                            <td style="text-align: right">
                                                                                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Visible="False" />
                                                                                <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" OnClick="btnGuardar_Click" style="font-weight: 700" TabIndex="33" Text="Guardar" ToolTip="Guardar datos" ValidationGroup="0" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </td>
                                                            <td style="height: 23px"></td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                &nbsp;</td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                        </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 16px; text-align: left; width: 56px;">&nbsp;</td>
                                                <td colspan="9" style="height: 16px; text-align: left;">

                                                    <table style="width:100%;">
                                                        <tr>
                                                            <td style="width: 104px">&nbsp;</td>
                                                            <td style="width: 97px">
                                                                &nbsp;</td>
                                                            <td rowspan="6">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 104px">&nbsp;</td>
                                                            <td style="width: 97px">
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 104px">&nbsp;</td>
                                                            <td style="width: 97px">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 104px">&nbsp;</td>
                                                            <td style="width: 97px">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 104px">&nbsp;</td>
                                                            <td style="width: 97px">&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 104px">&nbsp;</td>
                                                            <td style="width: 97px">&nbsp;</td>
                                                        </tr>
                                                    </table>








                                                </td>
                                            </tr>

                                            <tr>
                                                <td style="width: 56px">&nbsp;</td>
                                                <td style="width: 218px">
                                                    &nbsp;</td>
                                                <td style="width: 218px">
                                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="0" ShowSummary="False" />
                                                </td>
                                                <td style="width: 218px">&nbsp;</td>
                                                <td style="width: 217px">
                                                                &nbsp;</td>
                                                <td style="width: 467px; text-align: right;">
                                                    <asp:Label ID="lblUsuario" runat="server" Font-Bold="True" ForeColor="#CC3300" Text="Usuario:" Visible="False"></asp:Label>
                                                </td>
                                                <td style="width: 59px">
                                                    &nbsp;</td>
                                                <td>&nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                                <td style="width: 142px">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                    <tr>
                        <td class="style1">&nbsp;</td>

                    </tr>
                </table>
            </td>



            <td rowspan="10" style="vertical-align: top">&nbsp;</td>


        </tr>

    </table>
         
    <script language="javascript" type="text/javascript">
        function Operacion()
        {
<%--            var x = $("#<%=CheckHTA.ClientID%>").val();
            
            alert (x);
           
--%>
          
        }
    </script>




</asp:Content>
