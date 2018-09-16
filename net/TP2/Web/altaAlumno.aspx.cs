using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class altaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void alta()
        {

            string nombre = txtNombre.Value;
            string apellido = txtApellido.Value;
            string dni = txtDni.Value;
            string legajo = txtLegajo.Value;
            string email = txtEmail.Value;
            string tel = txtTelefono.Value;
            Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, email, tel);
            al.NombreUsuario = txtUsuario.Value;
            al.Contraseña = txtContraseña.Value;
            int id=Business.Logic.ABMalumno.altaAlumno(al);
            if (id != -1)
            {
                string script = @"<script type='text/javascript'>
                            alert('{0}');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }

        }
    }
}