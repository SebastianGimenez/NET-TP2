using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
                {
                    Response.Redirect("~/loguin.aspx");
                }
                ddl_cursos.DataSource = Business.Logic.ABMcurso.listarCursos();
                ddl_cursos.DataTextField = "nombre";
                ddl_cursos.DataValueField = "idCurso";
                ddl_cursos.DataBind();
                ddl_cursos.SelectedValue = (string)Session["idCurso"];
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            bool val = Business.Logic.ABMcurso.borrarCurso(int.Parse(ddl_cursos.SelectedValue));
            if (val)
            {
                Session.Remove("idCurso");
                Response.Write("<script type='text/javascript'> alert('dado de baja con exito'); location.href = '/ABMCurso.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja el curso') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idCurso");
            Response.Redirect("~/ABMCurso.aspx");
        }
    }
}