    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AntecedentesFamiliares.aspx.cs" Inherits="VGI.AntecedentesFamiliares"
    MasterPageFile="~/Site1.Master" %>

<%@ Register src="UserControl/DiagnosticoPrincipal.ascx" tagname="DiagnosticoPrincipal" tagprefix="uc1" %>

<asp:Content ID="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script type="text/javascript" src="js/jquery.ui.datepicker-es.js"></script>
    <script src="js/Format.js" type="text/javascript"></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/jquery-1.5.1.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/jquery-ui-1.8.9.custom.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/json2.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/jquery.dataTables.min.dataTables.min.js") %>'></script>

    <link type="text/css" rel="stylesheet" href="../js/jquery-ui-1.7.1.custom.css" />
    <script type="text/javascript" src="../js/jquery.min.js"></script><script type="text/javascript" src="../js/jquery-ui.min.js"></script><script type="text/javascript" src="../js/jquery.ui.datepicker-es.js"></script><script type="text/javascript">


   <%--$(function () {
           $("#<%=txtProximaEvaluacion.ClientID %>").datepicker({
           showOn: 'button',
           buttonImage: '../App_Themes/default/images/calend1.jpg',
    buttonImageOnly: true--%>

                                                                                                                                                                                                                                                                                                                     });
                                                                                                                                                                                                                                                                                                                 });

    </script><script type="text/javascript" src="../js/Mascara.js"></script><script type="text/javascript" src="../js/ValidaFecha.js"></script><table width="1000px" align="center" class="myTabla">
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
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:Label ID="ldniPaciente" runat="server" ForeColor="#336699" CssClass="ui-priority-primary" Visible="False"></asp:Label>
                                                            </td>
                                                            <td>&nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 145px">
                                                                &nbsp;</td>
                                                            <td>
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
                                                            <td style="width: 104px">Parentesco:</td>
                                                            <td style="width: 97px">
                                    <asp:DropDownList ID="ddlParentesco" runat="server" DataTextField="nombre" DataValueField="id" Height="41px" TabIndex="52" Width="315px">
                                        <asp:ListItem Value=""></asp:ListItem>
                                    </asp:DropDownList>
                                                            </td>
                                                            <td rowspan="6">
                        <asp:TreeView ID="TreeView1" runat="server" BorderStyle="Solid" BorderWidth="2px"
                            Width="95%" Font-Bold="False" BackColor="White" SkipLinkText="" ShowLines="True"
                            ExpandDepth="0">
                            <RootNodeStyle Font-Bold="True" ForeColor="Black" />
                            <NodeStyle Font-Bold="False" ForeColor="Black" />
                        </asp:TreeView>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 104px">Diag.</td>
                                                            <td style="width: 97px">
                                    <uc1:DiagnosticoPrincipal ID="DiagnosticoPrincipal" runat="server" />
                                                            </td>
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
                                                    <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" OnClick="btnGuardar_Click" TabIndex="33" Text="Guardar" ToolTip="Guardar datos" ValidationGroup="0" style="font-weight: 700" />
                                                </td>
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
