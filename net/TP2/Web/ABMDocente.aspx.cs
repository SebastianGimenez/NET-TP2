using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            this.grv_Docentes.DataSource = Business.Logic.ABMdocente.listarDocentes();
            this.grv_Docentes.DataBind();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frm_altaDocente.aspx");
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Docentes.SelectedRow;
                string legajo = row.Cells[3].Text;
                Session["legajo"] = legajo;
                Response.Redirect("~/frm_bajaDocente.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun alumno') </script>");
            }
        }

        protected void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Docentes.SelectedRow;
                string legajo = row.Cells[3].Text;
                Session["legajo"] = legajo;
                Response.Redirect("~/frm_modificarDocente.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun alumno') </script>");
            }
        }

       

    }
}