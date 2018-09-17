using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.ABMS.Alumnos
{
    public partial class ModiAlumno : System.Web.UI.Page
    {
        static int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string legajo = (string)Session["legajo"];
                Business.Entities.Alumno al;
                al = Business.Logic.ABMalumno.buscarAlumno(legajo);
                if (al != null) {
                    txtApellido.Text = al.Apellido;
                    txtNombre.Text = al.Nombre;
                    txtLegajo.Text = al.Legajo;
                    txtLegajo.Enabled = false;
                    txtTelefono.Text = al.Telefono;
                    txtDni.Text = al.Dni;
                    txtUsuario.Text = al.NombreUsuario;
                    txtContra.Text = al.Contraseña;
                    txtEmail.Text = al.Email;
                    id = al.IDPersona;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/ABMAlumnos.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string legajo = this.txtLegajo.Text;
            string dni = this.txtDni.Text;
            string email = this.txtEmail.Text;
            string telefono = this.txtTelefono.Text;
            
            Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, email, telefono);
            al.NombreUsuario = this.txtUsuario.Text;
            al.Contraseña = this.txtContra.Text;
            al.IDPersona = id;
            Business.Logic.ABMalumno.modi(al);
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/ABMAlumnos.aspx");
        }
    }
}