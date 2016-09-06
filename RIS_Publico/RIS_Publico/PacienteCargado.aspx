<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PacienteCargado.aspx.cs" Inherits="RIS_Publico.PacienteCargado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        
    input[type="submit"],
    input[type="button"],
    button {
        background-color: #d3dce0;
        border: 1px solid #787878;
        cursor: pointer;
        font-size: 1.2em;
        font-weight: 600;
        padding: 7px;
        margin-right: 8px;
        width: auto;
            text-align: center;
        }

    input, textarea {
        border: 1px solid #e2e2e2;
        background: #fff;
        color: #333;
        font-size: 1.2em;
        margin: 5px 0 6px 0;
        padding: 5px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Paciente cargado correctamente.<br />
        <br />
            <asp:Button ID="btnGuardar" runat="server" CssClass="myButton" onclick="btnGuardar_Click"   TabIndex="64" Text="Confirma" ToolTip="Guardar datos" ValidationGroup="0" />
    
    </div>
    </form>
</body>
</html>
