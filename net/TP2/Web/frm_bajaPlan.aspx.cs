using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                ddl_planes.DataSource = Business.Logic.ABMplan.listarPlanes();
                ddl_planes.DataTextField = "nombrePlan";
                ddl_planes.DataValueField = "idPlan";
                ddl_planes.DataBind();
                ddl_planes.SelectedValue = (string)Session["idPlan"];
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            bool val = Business.Logic.ABMplan.borrarPlan(int.Parse(ddl_planes.SelectedValue));
            if (val)
            {
                Session.Remove("idPlan");
                Response.Write("<script type='text/javascript'> alert('dado de baja con exito'); location.href = '/ABMPlan.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja el plan') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idPlan");
            Response.Redirect("~/ABMPlan.aspx");
        }
    }
}