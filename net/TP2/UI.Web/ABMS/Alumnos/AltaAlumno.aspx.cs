using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.ABMS.Alumnos
{
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string legajo = this.txtLegajo.Text;
            string dni = this.txtDni.Text;
            string email = this.txtEmail.Text;
            string telefono = this.txtTelefono.Text;
            Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, email, telefono);
            int id = Business.Logic.ABMalumno.altaAlumno(al);
            if (id != -1) { 
            al.IDPersona = id;
            al.NombreUsuario = this.txtUsuario.Text;
            al.Contraseña = this.txtContra.Text;
            Business.Logic.ABMUsuario.altaUsuario(txtUsuario.Text, txtContra.Text, al);   
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/ABMAlumnos.aspx");
             }
            else
            { Response.Write("<script type='text/javascript'> alert('un error ha ocurrido') </script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/ABMAlumnos.aspx");
        }
    }
}