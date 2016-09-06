<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PacienteSips.aspx.cs" Inherits="RIS_Publico.PacienteSips" 
        MasterPageFile="~/Site1.Master" %>


<%@ Register Src="~/UserControls/ObrasSociales.ascx" TagName="OSociales" TagPrefix="uc1" %>

<asp:Content ID="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
    <script type="text/javascript"      src="js/jquery.min.js" ></script> 
  <script type="text/javascript"      src="js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="js/jquery.ui.datepicker-es.js"></script>   
    <script src="js/Format.js" type="text/javascript"></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/jquery-1.5.1.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/jquery-ui-1.8.9.custom.min.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/json2.js") %>'></script>
    <script type="text/javascript" src='<%= ResolveUrl("~/js/jquery.dataTables.min.dataTables.min.js") %>'></script>

      <link href='<%= ResolveUrl("~/js/jquery.ui.all.css") %>' rel="stylesheet"  type="text/css" />
  <link type="text/css"rel="stylesheet"      href="js/jquery-ui-1.7.1.custom.css" />  
  
      
  <script type="text/javascript">


      $(function () {
          $("#<%=txtFechaInicio.ClientID %>").datepicker({
              showOn: 'button',
              buttonImage: '../App_Themes/default/images/calend1.jpg',
              buttonImageOnly: true

          });
      });

  </script>    
  
  <script type="text/javascript" src="js/Mascara.js"></script>
  <script type="text/javascript" src="js/ValidaFecha.js"></script>   





 <table  width="1000" align="center" class="myTabla" style="height: 2925px">
					<tr>
						
						
						
						<td rowspan="10" style="vertical-align: top" >
                                            <table class="myTabla" width="950px">
                                            <tr>
						<td colspan="2" align="right" >
                                           
                            <table id="TablaErrores" runat="server" bgcolor="#CC3300" cellpadding="10" cellspacing="10" style="width: 100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#F3F3F3"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                                           
                                                        </td>
					</tr>
                                            <tr>
						<td colspan="2" > <hr class="hrTitulo" /></td>
					</tr>
					<tr>
						<td colspan="2"  >
                                            <table style="width:100%;">
                                                <tr>
                                                    <td>
                                                        <table style="width:100%;">
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    <strong><span style="font-size: xx-large">PROSANE</span><br />
                                                                    ACCION DE SALUD EN LA ESCUELA</strong></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 13px; text-align: center">
                                                                
                                                                    PLANILLA DE DATOS</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    <asp:Label ID="lblUsuario" runat="server" Font-Bold="True" ForeColor="#CC3300" Text="Usuario:"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 20px; text-align: center">
                                                                
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    Paciente D.N.I.:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:TextBox runat="server" Width="135px" TabIndex="1" 
                                                                        Font-Size="Medium" Height="16px" ID="txtDNIPac" style="margin-bottom: 0px"></asp:TextBox>
                                                                &nbsp;<asp:Button ID="cmdExistePaciente" runat="server" CssClass="myButton" OnClick="cmdExistePaciente_Click" TabIndex="2" Text="Busca Paciente" ToolTip="Buscar" ValidationGroup="0" />
&nbsp;&nbsp;  
                                                                    <asp:Label ID="idPaciente" runat="server" ForeColor="#336699"></asp:Label>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    Nombre&nbsp;y Apellido&nbsp;&nbsp; 
                                                                    <asp:Label ID="lPaciente" runat="server" ForeColor="#336699"></asp:Label>
                                                                    <asp:TextBox runat="server" Width="313px" TabIndex="3" 
                                                                        Font-Size="Medium" Height="16px" ID="txtNombrePac" style="margin-top: 0px" Visible="False"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 16px; text-align: left; ">
                                                                
                                                                    &nbsp;Sexo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:DropDownList ID="ddlSexo" runat="server" Enabled="true" TabIndex="4" Visible="False">
                                                                        <asp:ListItem Value="sd">sd</asp:ListItem>
                                                                        <asp:ListItem>F</asp:ListItem>
                                                                        <asp:ListItem>M</asp:ListItem>
                                                                        
                                                                    </asp:DropDownList>
                                                                    <asp:Label ID="lSexo" runat="server" ForeColor="#336699"></asp:Label>
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    <asp:Label ID="lFechaFicha" runat="server" ForeColor="Black">Fecha Ficha</asp:Label>
                                                                    &nbsp;&nbsp; <input id="txtFechaInicio" runat="server" class="myTexto" maxlength="10" onblur="valFecha(this)" onkeyup="mascara(this,'/',patron,true)" style="width: 105px" tabindex="0" type="text" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" onclick="btnGuardar_Click"   TabIndex="64" Text="Guardar" ToolTip="Guardar datos" ValidationGroup="0" />
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            
                                                            </table>
                                                    </td>
                                                </tr>
                                                </table>
                        </td>
						
					</tr>
					<tr>
						
						<td class="style1" colspan="2">
                                            <hr /></td>
						
					</tr>
					<tr>
						<td>
<%--                                            <asp:CustomValidator ID="cvDatosEntrada" runat="server" 
                                                ErrorMessage="Debe ingresar al menos un parametro de busqueda." 
                                                onservervalidate="cvDatosEntrada_ServerValidate" ValidationGroup="0"></asp:CustomValidator>--%>
                                           
                        </td>
						
						<td align="right" style="width: 268435440px" width="500">
                                           
                                           &nbsp;</td>

                                                               
						
					</tr>
					<tr>
						<td colspan="2">
                                          <INPUT id="txtOculto" style="WIDTH: 1px; HEIGHT: 1px" type="hidden" size="1" name="txtOculto"
        runat="server">
                                            <hr /></td>
						
					</tr>
					<tr>
						<td class="style1" colspan="2">
                            &nbsp;</td>
						
					</tr>
					                        </table></td>
						
						
						
						<td rowspan="10" style="vertical-align: top" >
                                            &nbsp;</td>
						
						
					</tr>
					
					</table>
   
    
     <script language="javascript" type="text/javascript">
         function Careados() {

             var vOHPerC = $("#<%=txtOHPerC.ClientID%>").val();
            var vOMaloC = $("#<%=txtOMaloC.ClientID%>").val();
            var resul = eval(vOHPerC) + eval(vOMaloC);

            document.getElementById('<%= Page.Master.FindControl("ContentPlaceHolder1").FindControl("txtCareado").ClientID %>').value = resul;

        }
     </script>
     <script language="javascript" type="text/javascript">
         function IMC() {

             var vOHPerC = $("#<%=txtOHPerC.ClientID%>").val();
             var vOMaloC = $("#<%=txtOMaloC.ClientID%>").val();
             var resul = eval(vOHPerC) + eval(vOMaloC);

             document.getElementById('<%= Page.Master.FindControl("ContentPlaceHolder1").FindControl("txtCareado").ClientID %>').value = resul;

        }


        function Operacion() {

            var peso = $("#<%=txtPesoAlumno.ClientID%>").val();
             var talla = $("#<%=txtTalla.ClientID%>").val();
             var resul = (peso / (talla * talla)) * 10000
             document.getElementById('<%= Page.Master.FindControl("ContentPlaceHolder1").FindControl("txtIMC").ClientID %>').value = resul;
      }
      function AlertaSeGrabo() {

          alert('se ha cargado la página');

      }



      function confirmar() {
          confirmar = confirm("¿Te gusta nuestra web?");
          if (confirmar)
              // si pulsamos en aceptar
              alert('Has dicho que si');
          else
              // si pulsamos en cancelar
              alert('Has dicho que no');
      }





</script>

   

			
 </asp:Content>