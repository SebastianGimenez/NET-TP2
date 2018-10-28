using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMEspecialidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            this.gv_Especialidades.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            this.gv_Especialidades.DataBind();
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = gv_Especialidades.SelectedRow;
                string idEsp = row.Cells[1].Text;
                Session["idEsp"] = idEsp;
                Response.Redirect("~/frm_modificarEspecialidad.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ninguna especialidad') </script>");
            }
        }

        protected void btn_Alta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frm_altaEspecialidad.aspx");
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = gv_Especialidades.SelectedRow;
                string nombre = row.Cells[1].Text;
                Session["idEsp"] = nombre;
                Response.Redirect("~/frm_bajaEspecialidad.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ninguna especialidad') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAdmin.aspx");
        }
    }
}