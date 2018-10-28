using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarAlumno : System.Web.UI.Page
    {
        protected Business.Entities.Alumno alu;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            alu = Business.Logic.ABMalumno.buscarAlumno((string)Session["legajo"]);
            if (!IsPostBack)
            {
                txtApellido.Text = alu.Apellido;
                txtContraseña.Text = alu.Contraseña;
                txtDNI.Text = alu.Dni;
                txtLegajo.Text = alu.Legajo;
                txtLegajo.Enabled = false;
                txtMail.Text = alu.Email;
                txtNombre.Text = alu.Nombre;
                txtTelefono.Text = alu.Telefono;
                txtUsuario.Text = alu.NombreUsuario.Trim();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string legajo = this.txtLegajo.Text.Trim();
            string dni = this.txtDNI.Text;
            string email = this.txtMail.Text;
            string telefono = this.txtTelefono.Text;
            string usuario = txtUsuario.Text.Trim();
            string contr = txtContraseña.Text;
            Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, email, telefono);
            al.NombreUsuario = usuario;
            al.Contraseña = contr;
            al.IDPersona = alu.IDPersona;
            bool val = Business.Logic.ABMalumno.modi(al);
            if (val)
            {
                Session.Remove("legajo");
                Response.Write("<script type='text/javascript'> alert('Alumno modificado correctamente'); location.href = '/ABMAlumno.aspx' </script>");

            }
            else
            {             
                Response.Write("<script type='text/javascript'> alert('No se pudo modificar, es probable que el nombre de usuario ya se encuentre en uso') </script>");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Session.Remove("legajo");
            Response.Redirect("~/ABMAlumno.aspx");
        }
    }
}