<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_puntuarAlumno.aspx.cs" Inherits="Web.frm_puntuarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Curso"></asp:Label>
    <asp:TextBox ID="txt_curso" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Legajo"></asp:Label>
    <asp:TextBox ID="txt_legajo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Nota"></asp:Label>
    <asp:DropDownList ID="ddl_nota" runat="server">
        <asp:ListItem>0</asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
    <asp:DropDownList ID="ddl_estado" runat="server">
        <asp:ListItem>Libre</asp:ListItem>
        <asp:ListItem>Regular</asp:ListItem>
        <asp:ListItem>Promovido</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" />
    <asp:Button ID="btn_volver" runat="server" OnClick="btn_volver_Click" Text="Volver" />
    <br />
    <script>
        var nota = document.querySelector('select[id$="ddl_nota"]');
        var estado = document.querySelector('select[id$="ddl_estado"]');
        if (nota.value < 6) estado.selectedIndex = 0;
            else if (nota.value < 8) estado.selectedIndex = 1;
            else estado.selectedIndex = 2;
        nota.addEventListener("change", function (c) {
            if (this.value < 6) estado.selectedIndex = 0;
            else if (this.value < 8) estado.selectedIndex = 1;
            else estado.selectedIndex = 2;
        });

    </script>
</asp:Content>
