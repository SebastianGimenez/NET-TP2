using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                List<Business.Entities.Docente> lista = Business.Logic.ABMdocente.listarDocentes();
                this.ddl_legajos.DataSource = lista;
                this.ddl_legajos.DataTextField = "Legajo";
                this.ddl_legajos.DataValueField = "Legajo";
                this.ddl_legajos.DataBind();
                this.ddl_legajos.SelectedValue = (string)Session["legajo"];
            }
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool val = Business.Logic.ABMdocente.borrarDocente(ddl_legajos.SelectedValue);
            if (val)
            {
                //el cartel de que se dio de baja bien no se ve
                Session.Remove("legajo");
                Response.Write("<script type='text/javascript'> alert('dado de baja correctamente'); location.href = '/ABMDocente.aspx'</script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja')</script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("legajo");
            Response.Redirect("~/ABMDocente.aspx");
        }
    }
}