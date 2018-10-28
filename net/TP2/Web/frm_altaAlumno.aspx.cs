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
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Business.Entities.Alumno al = new Business.Entities.Alumno(txtNombre.Text, txtApellido.Text, txtLegajo.Text.Trim(), txtDNI.Text.Trim(), txtMail.Text, txtTelefono.Text);
            bool valido = Business.Logic.ABMUsuario.validarUsuario(txtUsuario.Text);
            if (valido)
            {
                try
                {
                    int id = Business.Logic.ABMalumno.altaAlumno(al);
                    if (id != -1)
                    {
                        al.IDPersona = id;
                        bool val = Business.Logic.ABMUsuario.altaUsuario(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), al);
                        if (val)
                        {
                            Response.Write("<script type='text/javascript'> alert('Alumno dado de alta correctamente'); location.href = '/ABMAlumno.aspx' </script>");
                        }
                        else
                        {
                            Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el alumno, es porbable que el legajo o usuario ingresados ya existan') </script>");

                        }
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el alumno, es porbable que el legajo o usuario ingresados ya existan') </script>");

                    }
                }
                catch (Exception)
                {
                    Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el alumno, es porbable que el legajo o usuario ingresados ya existan') </script>");
                }
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta el alumno, es porbable que el legajo o usuario ingresados ya existan') </script>");
            }           
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMAlumno.aspx");
        }
    }
}