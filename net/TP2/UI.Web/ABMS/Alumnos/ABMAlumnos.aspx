<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMAlumnos.aspx.cs" Inherits="UI.Web.ABMS.Alumnos.ABMAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ABMAlumnos</title>
    <link rel="stylesheet" type="text/css" href="ABMAlumnos.css" media="screen" />
</head>
<body>
    <h1>Gestion Alumnos</h1>
    <form id="form1" runat="server">
        <fieldset>
            <legend>ABM Alumnos</legend>
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NET TP2ConnectionString %>" SelectCommand="select * from dbo.Persona pe inner join dbo.Usuario us on pe.idPersona=us.idPersona"></asp:SqlDataSource>
            <asp:GridView ID="gvAlumnos" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idPersona,IdUsuario" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
                    <asp:BoundField DataField="legajo" HeaderText="legajo" SortExpression="legajo" />
                    <asp:BoundField DataField="dni" HeaderText="dni" SortExpression="dni" />
                    <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
                    <asp:BoundField DataField="mail" HeaderText="mail" SortExpression="mail" />
                    <asp:BoundField DataField="idPersona" HeaderText="idPersona" InsertVisible="False" ReadOnly="True" SortExpression="idPersona" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                    <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" />
                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" InsertVisible="False" ReadOnly="True" SortExpression="IdUsuario" />
                    <asp:BoundField DataField="TipoUsuario" HeaderText="TipoUsuario" SortExpression="TipoUsuario" />
                    <asp:BoundField DataField="idPersona1" HeaderText="idPersona1" SortExpression="idPersona1" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:Button ID="btnAlta"  runat="server"  PostBackUrl="http://localhost:54354/ABMS/Alumnos/AltaAlumno.aspx" Text="Alta"  OnClick="btnAlta_Click" />
            <br />
            <asp:Button ID="btnBaja" runat="server" PostBackUrl="http://localhost:54354/ABMS/Alumnos/BajaAlumno.aspx" Text="Baja" OnClick="btnBaja_Click" />
            <br />
            <asp:Button ID="btnModi" runat="server"  OnClick="btnModi_Click" Text="Modificar" />
        </div>
            </fieldset>
    </form>
</body>
</html>
