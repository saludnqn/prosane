<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prosame.aspx.cs" Inherits="Web.Vehiculos.Prosame" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  



  <link type="text/css"rel="stylesheet"      href="../js/jquery-ui-1.7.1.custom.css" />  
  <script type="text/javascript"      src="../js/jquery.min.js"></script> 
  <script type="text/javascript"      src="../js/jquery-ui.min.js"></script> 
    
  <script type="text/javascript"     src="../js/jquery.ui.datepicker-es.js"></script>   
      
  <script type="text/javascript">
  
  
	$(function() {
		$("#<%=inputFecha.ClientID %>").datepicker({
			showOn: 'button',
			buttonImage: '../App_Themes/default/images/calend1.jpg',
			buttonImageOnly: true
		$("#<%=inputFechaInicio.ClientID %>").datepicker({
			showOn: 'button',
			buttonImage: '../App_Themes/default/images/calend1.jpg',
			buttonImageOnly: true
		$("#<%=inputFechaFin.ClientID %>").datepicker({
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
                                            <table class="myTabla" width="950px">
                                            <tr>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td colspan="2" align="right" >
                            &nbsp;</td>
					</tr>
                                            <tr>
						<td colspan="2" align="right" style="height: 14px" >
                                                </td>
					</tr>
                                            <tr>
						<td colspan="2" align="right" >
                                                </td>
					</tr>
                                            <tr>
						<td colspan="2" align="right" >
<a href="VehiculosList.aspx"><img src="../App_Themes/default/images/Volver.jpg"  height="16px" title="" border="0" width="16px" /></a>
						
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
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    <strong><span style="font-size: xx-large">PROSAME</span><br />
                                                                    ACCION DE SALUD EN LA ESCUELA</strong></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    PLANILLA DE DATOS</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    Padre Madre o Tutor</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="text-align: left; height: 14px">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="text-align: left; height: 14px">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="text-align: left; height: 14px">
                                                                
                                                                    Provincia:
                                                                    <asp:DropDownList ID="ddlProvincia" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Depatamento:
                                                                    

                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Localidad:
                                                                    <asp:DropDownList ID="ddlLocalidad" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 15px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 15px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 15px; text-align: left">
                                                                
                                                                    Establecimiento Educativo:
                                                                    <asp:DropDownList ID="ddlEEducativo" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                &nbsp;&nbsp;&nbsp; Grado:
                                                                    <asp:DropDownList ID="ddlGrado" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="62px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                &nbsp;&nbsp; Division:
                                                                    <asp:DropDownList ID="ddlDivision" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="38px" Width="43px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                &nbsp;&nbsp;&nbsp;&nbsp; Turno:
                                                                    <asp:DropDownList ID="ddlTurno" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="38px" Width="43px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">&nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                </td>
                                                                <td colspan="5" style="height: 14px; text-align: left">
                                                                
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    Nombre y Apellido:
                                                        <asp:TextBox ID="txtNombre" runat="server" Width="384px" TabIndex="3" 
                                                                        Font-Size="Medium" Height="16px"></asp:TextBox>
                                                                &nbsp;&nbsp; Sexo :
                                                                    <asp:DropDownList ID="ddlSexo" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="38px" Width="43px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                &nbsp;&nbsp; D.N.I.
                                                        <asp:TextBox runat="server" Width="135px" TabIndex="3" 
                                                                        Font-Size="Medium" Height="16px" ID="txtDNI"></asp:TextBox>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    <strong>Docente</strong></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left; font-weight: 700; border-left-style: solid; border-right-style: solid;">
                                                                
                                                                    Desempeño Escolar</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left; border-left-style: solid; border-right-style: solid;">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left; border-left-style: solid; border-right-style: solid;">
                                                                
                                                                    <strong>Zona</strong>&nbsp;&nbsp;
                                                                    <asp:RadioButton ID="rbZonaSi" runat="server" OnCheckedChanged="rbZonaSi_CheckedChanged" Text="Si" />
&nbsp;                                                              <asp:RadioButton ID="rbZonaNo" runat="server" OnCheckedChanged="rbZonaNo_CheckedChanged" Text="No" />/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sobreedad:</strong>&nbsp;&nbsp;&nbsp;
                                                                    <asp:RadioButton ID="rbSobreedadSi" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Si" />
                                                                    <asp:RadioButton ID="rbSobreedadNo" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="No" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Repitente:</strong>
                                                                    <asp:RadioButton ID="rbRepitenteSi" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Si" />
                                                                    <asp:RadioButton ID="rbRepitenteNo" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="No" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    <br />
                                                                    <br />
                                                                </td>
                                                                <td style="height: 14px; text-align: left">
                                                                
                                                                    </td>
                                                                <td colspan="12" style="height: 14px; text-align: left">
                                                                
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    EXAMEN FISICO ODONTOLOGICO</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="text-align: center; height: 14px">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="text-align: center; height: 14px">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="text-align: center; height: 14px">
                                                                
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Peso kg.
                                                                        <input id="txtPeso" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Talla:&nbsp;
                                                                        <input id="txtTalla" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; IMC:&nbsp;
                                                                        <input id="txtIMC" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; TA max:&nbsp;&nbsp;&nbsp;&nbsp;
                                                                        <input id="txtTAMax" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; TA min&nbsp;&nbsp;&nbsp;&nbsp;
                                                                        <input id="txtTAMin" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: justify">
                                                                
                                                                    &nbsp;&nbsp;&nbsp; Percentilo Peso&nbsp;&nbsp;
                                                                        <input id="txtPersentiloPeso" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Percentilo Talla:&nbsp;
                                                                        <input id="txtPresntiloTalla" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Percentilo IMC:
                                                                        <input id="txtPercentiloIMC" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;Persentilo max:&nbsp;&nbsp;&nbsp;&nbsp;
                                                                        <input id="txtPersentiloMax" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Persentilo TA min:&nbsp;&nbsp;
                                                                        <input id="txtPersentiloTAMin" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center; font-weight: 700;">
                                                                
                                                                    Examen Fisico</td>
                                                            </tr>

                                                            <tr>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: center">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>

                                                            <tr>
                                                                <td style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>


                                                            <tr>
                                                                <td style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                                <td colspan="12" style="height: 14px; text-align: justify" class="art-postfootericons">
                                                                
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 13px; text-align: center; font-weight: 700;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 13px; text-align: center; font-weight: 700;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 13px; text-align: center; font-weight: 700;" class="art-postfootericons">
                                                                    Examen Fisico</td>
                                                                <td style="width: 204px; height: 13px; text-align: justify;" class="art-postfootericons">
                                                                </td>
                                                                <td style="width: 314px; height: 13px; text-align: left; font-weight: 700;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 13px; text-align: left; font-weight: 700;" class="art-postfootericons" colspan="4">
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Patologico</td>
                                                                <td style="height: 13px; text-align: justify;" class="art-postfootericons">
                                                                    </td>
                                                                <td style="width: 114px; height: 13px; text-align: justify;" class="art-postfootericons">
                                                                    </td>
                                                                <td style="width: 47px; height: 13px; text-align: justify;" class="art-postfootericons">
                                                                    </td>
                                                                <td style="width: 218px; height: 13px; text-align: justify;" class="art-postfootericons">
                                                                    <strong>Esquema de las vacunas</strong></td>
                                                                <td style="width: 142px; height: 13px; text-align: justify;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    Piel y fanera</td>
                                                                <td style="width: 204px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    <asp:CheckBox ID="CheckNormalPiel" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px; text-align: justify;" class="art-postfootericons" colspan="4">
                                                                    <asp:DropDownList ID="ddlPielFanera" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px; text-align: justify;" class="art-postfootericons">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px; text-align: justify;" class="art-postfootericons" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px; text-align: justify;" class="art-postfootericons" colspan="2">
                                                                    Trajo Carne:
                                                                    <asp:DropDownList ID="ddlEEducativo7" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="70px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                    &nbsp;
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Cardiovascular:</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckNormalPiel0" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    <asp:DropDownList ID="ddlCardiovascular" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    <asp:CheckBox ID="CheckNormalPiel6" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Se vacuno aqui" />
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Respiratorio:</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckNormalPiel1" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    <asp:DropDownList ID="ddlRespiratorio" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Genital y/o desarrollo: </td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckNormalPiel2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    <asp:DropDownList ID="ddlGenital" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Abdomen:</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckNormalPiel3" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    <asp:DropDownList ID="ddlAbdomen" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Osteocular:</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckNormalPiel4" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    <asp:DropDownList ID="ddlOstocular" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Neurologico:</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckNormalPiel5" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Normal" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    <asp:DropDownList ID="ddlNeurologico" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    <b>Oftalmologia</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    <b></td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    Fonoaudiologia</b></b></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Estrabismo</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckEstravismo" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    Audiometria</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    <asp:DropDownList ID="ddlAudiometria" runat="server" DataTextField="nombre" 
                                                                        DataValueField="idEntidad" TabIndex="7" Height="42px" Width="191px" 
                                                                        onselectedindexchanged="ddlEfector_SelectedIndexChanged">
                                                                        <asp:ListItem Value=""></asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Usa Lentes</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckLentes" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    Hipoacusia</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    <asp:CheckBox ID="CheckHipoacusia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Agud.Visual Izquierda</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                        <input id="txtAgudezaVisualIzq" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    Tans. de Fonacion</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    <asp:CheckBox ID="CheckFonacion" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Agud.Visual Derecha</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                        <input id="txtAgudezaVisualDer" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan = 12 style="width: 281px; height: 14px;">
                                                                    <strong>Observaciones</strong></td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan = 12 style="width: 281px; height: 14px;">
                                                                    <b>
                                                                        <input id="txtObservaciones" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 807px; height: 46px;" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;">
                                                                    </b></td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 15px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 15px;">
                                                                    &nbsp;</td>
                                                                <td colspan = 12 style="width: 281px; height: 15px;">
                                                                    </td>
                                                                <td style="width: 204px; height: 15px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 15px;">
                                                                    </td>
                                                                <td style="height: 15px;">
                                                                    </td>
                                                                <td style="height: 15px;">
                                                                    </td>
                                                                <td style="width: 142px; height: 15px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan = 12 style="width: 281px; height: 14px;">
                                                                    <strong>Responsable:</strong><br />
&nbsp;<input id="txtResponsable" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 281px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" />&nbsp; </td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px; font-weight: 700;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px; font-weight: 700;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px; font-weight: 700;">
                                                                    Odontologia</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    </td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    </td>
                                                                <td style="width: 314px; height: 14px; text-align: center;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    <b>c</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    e</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    o</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    d</b></td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Habit.Perniciosos</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckHabitosPerniciosos" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                    </td>
                                                                <td style="width: 314px; height: 14px; text-align: center;">
                                                                        &nbsp;</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtCareadoNiño" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtExtraidoNiño" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtObsturadoNiño" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtDienteNiño" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="height: 14px;">
                                                                    </td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Maloclusion</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckMaloclunsion" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    C</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    P</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    O</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Fluor Aplicado</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    <asp:CheckBox ID="CheckFluorAplicado" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Si" />
                                                                </td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtCareadoAdulto" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtExtraidoAdulto" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                        <input id="txtObsturadoAdulto" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px; text-align: center;">
                                                                    c</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 281px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 218px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 204px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 314px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 23px;">
                                                                        &nbsp;&nbsp;&nbsp;
                                                                        <input id="txtIndice" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 23px; text-align: center;" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 23px;">
                                                                    </td>
                                                                <td style="width: 59px; height: 23px;">
                                                                    </td>
                                                                <td style="height: 23px;">
                                                                    </td>
                                                                <td style="height: 23px;" colspan="2">
                                                                    </td>
                                                                <td style="width: 142px; height: 23px;" colspan="2">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    Responsable</td>
                                                                <td colspan = 6 style="width: 204px; height: 14px;">
                                                                    <input id="txtResponsableOdonto" runat="server" class="myTexto" 
                                                                        
    maxlength="10" onblur="valFecha(this)" 
                                                                        onclick="return txtFecha_onclick()" 
                                                                        
    onkeyup="mascara(this,'/',patron,true)" style="width: 386px" tabindex="4" 
                                                                        
    type="text" __designer:mapid="5c" /></td>
                                                                <td style="width: 59px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px; height: 14px;" colspan="4">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px; height: 14px;" colspan="2">
                                                                    &nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td colspan ="12" style="width: 281px; height: 14px;">
                                                                    <b>Derivaciones</b></td>
                                                            </tr>

                                                            <tr>
                                                                
                                                                <td colspan ="12" style="width: 281px; height: 14px;">
                                                                    <table style="width: 292%">
                                                                        <tr>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerPediatria" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Pediatria" />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerFono" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Fonoaudiol." />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerNutricion" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Nutricion" />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerORL" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="O . R . L . " />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerTrabSocial" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Trab.Social" />
                                                                            </td>
                                                                            <td style="border-style: solid; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkAgenteSanitario" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Agent.Sanitario" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerOdonto" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Odontologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerCardiologia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Cardiologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerCirugia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Cirugia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDermatologia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Dermatologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerPsicologia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Psicologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerOtros" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Otros" />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="border-left-style: solid; border-left-width: 1px; border-right-style: outset; border-right-width: 1px; border-top-style: outset; border-top-width: 1px; border-bottom-style: outset; border-bottom-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerOftalmo" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Oftalmologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerTrauma" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Traumatologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerUrologia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Urologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerNeurologia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Neurologia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">
                                                                    <asp:CheckBox ID="ChkDerPsicopedagogia" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Psicopedagogia" />
                                                                            </td>
                                                                            <td style="border-style: outset; border-width: 1px; padding: 1px 4px">&nbsp;</td>
                                                                        </tr>
                                                                    </table>
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px"></td>
                                                                <td></td>
                                                                <td style="width: 314px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan ="11" style="width: 281px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan ="12" style="width: 281px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px; height: 14px;">
                                                                    &nbsp;</td>
                                                                <td colspan ="12" style="width: 281px; height: 14px;">
                                                                    </td>
                                                            </tr>
                                                            
                                                            <tr>
                                                                <td style="width: 281px">
                                                                    &nbsp;</td>
                                                                <td style="width: 281px">
                                                                    &nbsp;</td>
                                                                <td style="width: 218px">
                                                                    &nbsp;</td>
                                                                <td style="width: 204px">
                                                                    &nbsp;</td>
                                                                <td style="width: 314px">
                                                                    &nbsp;</td>
                                                                <td style="width: 59px" colspan="4">
                                                                    &nbsp;</td>
                                                                <td>
                                                                    &nbsp;</td>
                                                                <td colspan="2">
                                                                    &nbsp;</td>
                                                                <td style="width: 142px" colspan="2">
                                                                    &nbsp;</td>
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
                                           
                                           <asp:LinkButton ID="lnkBtnNuevoItems" runat="server" 
                                               onclick="lnkBtnNuevoItems_Click" TabIndex="5">Nuevo Items</asp:LinkButton>
                                           
                        </td>
						
						<td align="right" style="width: 268435440px">
                                           
                                           <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" 
                                               onclick="btnGuardar_Click" TabIndex="12" Text="Guardar" ToolTip="Guardar datos" 
                                               ValidationGroup="0" />
                                           
                                                           <asp:Button ID="btnImprimirListadoDeVehiculos" runat="server" 
                                                               CssClass="myButton" onclick="btnImprimirListadoDeVehiculos_Click" TabIndex="8" 
                                                               Text="Imprimir" ValidationGroup="0" Width="115px" />
                                                               </td>

                                                               
						
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


			
 </asp:Content>
