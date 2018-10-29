<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="frm_altaDocente.aspx.cs" Inherits="Web.frm_altaDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p id="lblNombre">
        Nombre:<asp:TextBox ID="txtNombre" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Apellido:<asp:TextBox ID="txtApellido" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Dni:<asp:TextBox ID="txtDNI" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Legajo:<asp:TextBox ID="txtLegajo" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Telefono:<asp:TextBox ID="txtTelefono" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Mail:<asp:TextBox ID="txtMail" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Usuario:<asp:TextBox ID="txtUsuario" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        Contraseña:<asp:TextBox ID="txtContraseña" runat="server" required="required"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" style="height: 26px" />
        <asp:LinkButton ID="LinkButton1" runat="server" href="/ABMDocente.aspx">Volver</asp:LinkButton>
    
    </p>
    <script>
       
        function validar() {
            var nombre = document.querySelector('input[id$="txtNombre"]');
            var apellido = document.querySelector('input[id$="txtApellido"]');
            var dni = document.querySelector('input[id$="txtDNI"]');
            var legajo = document.querySelector('input[id$="txtLegajo"]');
            var telefono = document.querySelector('input[id$="txtTelefono"]');
            var email = document.querySelector('input[id$="txtMail"]');
            var usuario = document.querySelector('input[id$="txtUsuario"]');
            var password = document.querySelector('input[id$="txtContraseña"]');

            //corregir validacion de texto 
           var valido = passwordValido(password) &
            telefonoValido(telefono) &
            usuarioValido(usuario) &
            Estexto(nombre) &
               Estexto(apellido) &
            emailValido(email) &
            dniValido(dni);
            return (valido);

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

        function passwordValido(pass) {
            var valido = pass.value.match(/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{5,12}$/) != null;
            if (!valido) {
                setErrorMessage(pass, "El password debe contener al menos una mayuscula un numero y una minuscula y ser mayor a 5 caracteres y menor a 12");
                return false;
            } else {
                  setErrorMessage(pass, "");
            }
            return true;
        }

        function telefonoValido(telefono) {
            var valido = telefono.value.match(/\d{10}/) != null;
            if (!valido) {
                setErrorMessage(telefono, "El telefono debe estar formado por 10 digitos");
                return false;
            } else {
                setErrorMessage(telefono, "");
            }
            return true;
        }

        function usuarioValido(usu) {
            var valido = usu.value.length >= 4 && usu.value.length < 10;
            if (!valido) {
                setErrorMessage(usu, "El usuario debe ser mayor a 4 caracteres y menor a 10");
                return false;
            } else {
                setErrorMessage(usu, "");
            }
            return true;
        }
        function Estexto(txt) {
            var valido = txt.value.match(/^[a-zA-Z\s]*$/g) != null;
            if (!valido) {
                setErrorMessage(txt, "Debe contener solo letras");
                return false;
            } else {
                setErrorMessage(txt, "");
            }
            return true;
        }

        function emailValido(email) {
            var valido = email.value.match(/^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/) != null;
            if (!valido) {
                setErrorMessage(email, "El email no es valido");
                return false;
            } else {
                setErrorMessage(email, "");
            }
            return true;
        }

        function dniValido(dni) {
            
            var valido = dni.value.match(/\d{8}/) != null;
            if (dni.value.length != 8)
                valido = false;
            if (!valido) {
                setErrorMessage(dni, "El dni debe estar formado por 8 digitos");
                return false;
            } else {
                setErrorMessage(dni, "");
            }
            return true;
 
        }

    </script>
</asp:Content>
