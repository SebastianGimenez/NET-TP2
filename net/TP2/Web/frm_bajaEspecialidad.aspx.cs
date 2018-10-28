using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaEspecialidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                ddl_Especialidades.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
                ddl_Especialidades.DataTextField = "nombreEspecialidad";
                ddl_Especialidades.DataValueField = "idEspecialidad";
                ddl_Especialidades.DataBind();
                ddl_Especialidades.SelectedValue = (string)Session["idEsp"];
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            bool val = Business.Logic.ABMespecialidad.borrarEspecialidad(int.Parse(ddl_Especialidades.SelectedValue));
            if (val)
            {
                Session.Remove("idEsp");
                Response.Write("<script type='text/javascript'> alert('dada de baja con exito'); location.href = '/ABMEspecialidad.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja la especialidad') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idEsp");
            Response.Redirect("~/ABMEspecialidad.aspx");
        }
    }
}