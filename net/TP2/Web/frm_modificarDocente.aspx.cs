using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarDocente : System.Web.UI.Page
    {
        protected Business.Entities.Docente doc;
        protected void Page_Load(object sender, EventArgs e)
        {
            doc = Business.Logic.ABMdocente.buscarDocente((string)Session["legajo"]);
            if (!IsPostBack)
            {
                txtApellido.Text = doc.Apellido;
                txtContraseña.Text = doc.Contraseña;
                txtDNI.Text = doc.Dni;
                txtLegajo.Text = doc.Legajo;
                txtLegajo.Enabled = false;
                txtMail.Text = doc.Email;
                txtNombre.Text = doc.Nombre;
                txtTelefono.Text = doc.Telefono;
                txtUsuario.Text = doc.NombreUsuario.Trim();
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
            Business.Entities.Docente docente = new Business.Entities.Docente(nombre, apellido, legajo, dni, email, telefono);
            docente.NombreUsuario = usuario;
            docente.Contraseña = contr;
            docente.IDPersona = doc.IDPersona;
            bool val = Business.Logic.ABMdocente.modi(docente);
            if (val)
            {
                Session.Remove("legajo");
                Response.Write("<script type='text/javascript'> alert('Docente modificado correctamente') </script>");
                Response.Redirect("~/ABMDocente.aspx");
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