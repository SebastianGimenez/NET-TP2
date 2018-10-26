using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class loguin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            Business.Entities.Persona per = Business.Logic.ABMUsuario.login(txt_usuario.Text, txt_Contra.Text);
            if (per != null)
            {
                Session["idPersonaLogueada"] = per.IDPersona;
                Session["tipoPersonaLogueada"] = per.TipoUsuario;
                switch (per.TipoUsuario)
                {
                    case Business.Entities.tipoUsuario.ALUMNO:
                        Response.Redirect("~/indexAlumno.aspx");
                        break;
                    case Business.Entities.tipoUsuario.DOCENTE:
                        Response.Redirect("~/indexDocente.aspx");
                        break;

                    case Business.Entities.tipoUsuario.ADMIN:
                        Response.Redirect("~/indexAdmin.aspx");
                        break;
                }
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('usuario y contraseña invalidos') </script>");
            }
        }
    }
}