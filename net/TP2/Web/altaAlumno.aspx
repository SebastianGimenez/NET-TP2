<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="altaAlumno.aspx.cs" Inherits="Web.altaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
     
        function alerta() {
            alert('Ha ocurrido un error');
        }
     
    </script>
    <style type="text/css">
        #Button1 {
            width: 91px;
        }
        #btnAceptar {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;&nbsp; <input id="txtNombre" type="text" runat="server"/>&nbsp;&nbsp;&nbsp; Apellido:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtApellido" type="text" runat="server" /><br />
            Telefono:&nbsp;&nbsp;
            <input id="txtTelefono" type="text" runat="server"/>&nbsp;&nbsp;&nbsp; Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtEmail" type="text" runat="server"/><br />
            Legajo:&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtLegajo" type="text" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DNI:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="txtDni" type="text" runat="server"/><br />
            Usuario:&nbsp;&nbsp;&nbsp;
            <input id="txtUsuario" type="text" runat="server"/>&nbsp;&nbsp;&nbsp; Contraseña:&nbsp;&nbsp;
            <input id="txtContraseña" type="text" runat="server" /><br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input id="btnAceptar" type="button" value="Aceptar" onclick="alta" runat="server" /><br />
        </div>
    </form>
</body>
</html>
