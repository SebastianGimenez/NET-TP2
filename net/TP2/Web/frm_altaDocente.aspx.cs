using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Business.Entities.Docente doc = new Business.Entities.Docente(txtNombre.Text, txtApellido.Text, txtLegajo.Text.Trim(), txtDNI.Text, txtMail.Text, txtTelefono.Text);
            bool valido = Business.Logic.ABMUsuario.validarUsuario(txtUsuario.Text);
            if (valido)
            {
                try
                {
                    int id = Business.Logic.ABMdocente.altaDocente(doc);
                    if (id != -1)
                    {
                        doc.IDPersona = id;
                        bool val = Business.Logic.ABMUsuario.altaUsuario(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), doc);
                        if (val)
                        {
                            Response.Write("<script type='text/javascript'> alert('Docente dado de alta correctamente'); location.href = '/ABMDocente.aspx' </script>");
                        }
                        else
                        {
                            Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el docente, es porbable que el legajo o usuario ingresados ya existan') </script>");

                        }
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el docente, es porbable que el legajo o usuario ingresados ya existan') </script>");

                    }
                }
                catch (Exception)
                {
                    Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el docente, es porbable que el legajo o usuario ingresados ya existan') </script>");
                }
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el docente, es porbable que el legajo o usuario ingresados ya existan') </script>");
            }
        }

      
    }
}