<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BajaAlumno.aspx.cs" Inherits="UI.Web.ABMS.Alumnos.BajaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Baja Alumno</title>
     <link rel="stylesheet" type="text/css" href="ABMAlumnos.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>ABM Alumnos</legend>
        <div>
            <h1>Borrar Alumno</h1>
            <br />
            <br />
            Legajo:
            <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAceptar" runat="server" Text="Borrar" OnClick="btnAceptar_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
        </div>
            </fieldset>
    </form>
</body>
</html>
