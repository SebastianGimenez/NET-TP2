using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaComision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                ddl_Comisiones.DataSource = Business.Logic.ABMcomision.listarComisiones();
                ddl_Comisiones.DataTextField = "nombreComision";
                ddl_Comisiones.DataValueField = "idComision";
                ddl_Comisiones.DataBind();
                ddl_Comisiones.SelectedValue = (string)Session["idCom"];
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            bool val = Business.Logic.ABMcomision.borrarComision(int.Parse(ddl_Comisiones.SelectedValue));
            if (val)
            {
                Session.Remove("idCom");
                Response.Write("<script type='text/javascript'> alert('dada de baja con exito'); location.href = '/ABMComision.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja la comision') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idCom");
            Response.Redirect("~/ABMComision.aspx");
        }
    }
}