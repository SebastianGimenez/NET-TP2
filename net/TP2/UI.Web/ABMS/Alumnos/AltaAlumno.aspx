<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="UI.Web.ABMS.Alumnos.AltaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alta Alumno</title>
    <link rel="stylesheet" type="text/css" href="ABMAlumnos.css" media="screen" />
</head>
<body>
    <h1>Alta Alumno</h1>
    <form id="form1" runat="server">
        <fieldset>
            <legend>ABM Alumnos</legend>
        <div>
            Nombre:<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellido:<asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono:<asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            Legajo:<asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dni:<asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
            <br />
            Usuario:
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Contraseña:<asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Cancelar" OnClick="Button1_Click" />
        </div>
            </fieldset>
    </form>
</body>
</html>
