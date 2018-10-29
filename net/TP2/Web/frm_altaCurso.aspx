<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_altaCurso.aspx.cs" Inherits="Web.frm_altaCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="lbl_nombre" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server" required="required"></asp:TextBox>
   </div>
    <div>
    <asp:Label ID="lbl_cupo" runat="server" Text="Cupo"></asp:Label>
    <asp:TextBox ID="txt_cupo" runat="server" required="required"></asp:TextBox>
   </div>
    <div>
    <asp:Label ID="lbl_comision" runat="server" Text="Comision"></asp:Label>
    <asp:DropDownList ID="ddl_comisiones" runat="server">
    </asp:DropDownList>
        </div>  
    <div>
    <asp:Label ID="lbl_materia" runat="server" Text="Materia"></asp:Label>
    <asp:DropDownList ID="ddl_materias" required="required" runat="server">
    </asp:DropDownList>
        </div>
    <asp:Button ID="btn_agregar" runat="server" OnClientClick="return validar()" OnClick="btn_agregar_Click" Text="Agregar" />
<asp:LinkButton ID="LinkButton1" runat="server" href="/ABMCurso.aspx">Volver</asp:LinkButton>    </p>
    <br />
    <br />
    <br />
      <script>

            function validar() {
            var cupo = document.querySelector('input[id$="txt_cupo"]');
                //corregir validacion de texto 
                var valido = esNumero(cupo) && Number(cupo.value) > 0;
                   
         
            return valido;

        }

   
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
