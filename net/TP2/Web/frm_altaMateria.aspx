<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_altaMateria.aspx.cs" Inherits="Web.frm_altaMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lbl_nombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server" required="required"></asp:TextBox>

    <asp:Label ID="lbl_descripcion"  runat="server" Text="Descripcion:"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txt_descripcion" TextMode="multiline" Columns="20" Rows="8" runat="server" required="required"></asp:TextBox>
  <div>
    <asp:Label ID="lbl_hsSemanales" runat="server" Text="Horas Semanales:"></asp:Label>
    <asp:TextBox ID="txt_hsSemanales" runat="server" required="required"></asp:TextBox>
  </div>
     <div>
    <asp:Label ID="lbl_hsTotales" runat="server" Text="Horas Totales:"></asp:Label>
    <asp:TextBox ID="txt_hsTotales" runat="server" required="required"></asp:TextBox>
         </div>
     <div>
    <asp:Label ID="lbl_plan" runat="server" Text="Plan:"></asp:Label>
    <asp:DropDownList ID="ddl_planes" runat="server">
    </asp:DropDownList>
         </div>

    <asp:Button ID="btn_agregar" runat="server" OnClick="btn_agregar_Click" Text="Agregar" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMMateria.aspx">Volver</asp:LinkButton>    </p>

    <script>

            function validar() {
            var hs_semanales = document.querySelector('input[id$="txt_hsSemanales"]');
            var hs_totales = document.querySelector('input[id$="txt_hsTotales"]');

                //corregir validacion de texto 
                var valido = esNumero(hs_semanales,40) &
                    esNumero(hs_totales); 
         
            return valido;

        }

        document.querySelector("form").addEventListener("submit", function (e) {
            e.preventDefault();
            if (validar())
                this.submit();
        });

        function setErrorMessage(element, message) {
             var child = element.parentNode.querySelector("label");
            if (child) {
                element.parentElement.removeChild(child);
            }
            if (message === "") {
               
                     element.style.borderColor = "#00FF00";
                
                return;
            }
                var newlabel = document.createElement("Label");
                newlabel.setAttribute("for",element.id);
            newlabel.innerHTML = message;
            element.parentNode.appendChild(newlabel);
            element.style.borderColor = "#FF0000";
        }

      
        function esNumero(num, lessThan) {
            var valido = num.value.match(/^[\d]+$/) != null;
            if (num.valido <= lessThan) {
                valido = true;
            } else if (lessThan)
                valido = false;
            if (!valido) {
                if (lessThan)
                    setErrorMessage(num, "Debe ser un numero menor que " + lessThan);
                else
                    setErrorMessage(num, "Debe ser un numero");
                return false;
            } else {
                  setErrorMessage(num, "");
            }
            return true;
        }
    </script>
</asp:Content>
