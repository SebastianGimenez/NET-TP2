<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModiAlumno.aspx.cs" Inherits="UI.Web.ABMS.Alumnos.ModiAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modificar Alumno</title>
     <link rel="stylesheet" type="text/css" href="ABMAlumnos.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>ABM Alumnos</legend>
        <div>
    <h1>Modificar Alumno</h1>
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Cancelar" OnClick="Button1_Click" />
        </div>
        </div>
            </fieldset>
    </form>
</body>
</html>
