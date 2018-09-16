<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaAlumno.aspx.cs" Inherits="AltaAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input{
         margin:auto;
         width:50%;  
         display:block;
        }

        .user-container{
            margin:15px auto;
            width:50%;
            border:1px solid;
            background:#2196f3;
            padding:15px;
            color:white;
            border-radius:15px;
        }

        .user-container input{
            width:80%;
            
        }

        button{
           margin-top:15px;
           height:75px;
        }

        .btn{
        width: 25%;
        height: 25px;
        margin: 10px auto 15px auto;
        color: white;
        background: #E91E63;
        border: none;
        }

        form{
            width:50%;
                padding: 15px;
            margin:auto;
            text-align:center;
           color:hotpink;
        }
        body{
            background-color:whitesmoke;
        }
        #form-container{
            width:100%;
            background-color:blanchedalmond;
            border-radius:25px;
            padding:10px;
        }

        label{
            margin:5px;
            display:block;
        }
    </style>
</head>
<body style="width: 100%">
    <form id="form1" runat="server">
        <div id="form-container">
            <asp:Label runat="server">Nombre</asp:Label>
            <asp:TextBox runat="server" ID="txt_nombre"></asp:TextBox>
            <asp:Label runat="server">Apellido</asp:Label>
            <asp:TextBox runat="server" ID="txt_apellido"></asp:TextBox>
            <asp:Label runat="server">Legajo</asp:Label>
            <asp:TextBox runat="server" ID="txt_legajo"></asp:TextBox>
            <asp:Label runat="server">DNI</asp:Label>
            <asp:TextBox runat="server" ID="txt_dni"></asp:TextBox>
            <asp:Label runat="server">Telefono</asp:Label>
            <asp:TextBox runat="server" ID="txt_telefono"></asp:TextBox>
            <asp:Label runat="server">email</asp:Label>
            <asp:TextBox runat="server" ID="txt_email"></asp:TextBox>
            <div class="user-container">
                  <asp:Label runat="server">Nombre Usuario</asp:Label>
            <asp:TextBox runat="server" ID="txt_nombre_usuario"></asp:TextBox>
            <asp:Label runat="server">Contraseña</asp:Label>
            <asp:TextBox runat="server" TextMode="Password" ID="txt_passw"></asp:TextBox>
            </div>
            <asp:Button CssClass="btn" runat="server" Text="Guardar" ID="btn_guardar" OnClick="btn_guardar_Click"/>
        </div>
    </form>
</body>
</html>
