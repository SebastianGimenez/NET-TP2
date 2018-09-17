<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplo.aspx.cs" Inherits="UI.Web.Ejemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Button" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
