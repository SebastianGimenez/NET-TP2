<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="loguin.aspx.cs" Inherits="Web.loguin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class="container col-sm-6">
<h1 class="form-heading">login Form</h1>
<div class="login-form">
<div class="main-div">
    <div class="panel">
      </div>
 

        <div class="form-group">


         
             <asp:TextBox CssClass="form-control" placeholder="Usuario" ID="txt_usuario" runat="server"></asp:TextBox>
   
    
        </div>

        <div class="form-group">
             <asp:TextBox CssClass="form-control" placeholder="Contraseña" ID="txt_Contra" runat="server" TextMode="Password"></asp:TextBox>

          
        </div>
    
</div>
    <asp:Button ID="btn_ingresar" CssClass="btn btn-primary" runat="server" OnClick="btn_ingresar_Click" Text="Ingresar" />
      

</div>

</div>

   



</asp:Content>

