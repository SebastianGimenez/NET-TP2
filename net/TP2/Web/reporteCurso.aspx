<%@ Page Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="reporteCurso.aspx.cs" Inherits="Web.reporteCurso" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer" runat="server" Width="780px">
        </rsweb:ReportViewer>
     <p>
        <asp:LinkButton ID="LinkButton1" runat="server" style="margin-left:50%" href="/indexAdmin.aspx">Volver</asp:LinkButton>
    
    </p>
    </asp:Content>
