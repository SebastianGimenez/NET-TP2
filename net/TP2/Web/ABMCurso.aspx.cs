using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            this.grv_Cursos.DataSource = Business.Logic.ABMcurso.listarCursos();
            this.grv_Cursos.DataBind();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frm_altaCurso.aspx");
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Cursos.SelectedRow;
                string id = row.Cells[2].Text;
                Session["idCurso"] = id;
                Response.Redirect("~/frm_bajaCurso.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun plan') </script>");
            }
        }

        protected void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Cursos.SelectedRow;
                string id = row.Cells[2].Text;
                Session["idCurso"] = id;
                Response.Redirect("~/frm_modificarCurso.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun curso') </script>");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAdmin.aspx");
        }
    }
}