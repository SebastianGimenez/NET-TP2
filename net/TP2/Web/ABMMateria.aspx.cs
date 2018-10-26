using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.grv_Materias.DataSource = Business.Logic.ABMmateria.listarMaterias();
            this.grv_Materias.DataBind();
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frm_altaMateria.aspx");
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Materias.SelectedRow;
                string id = row.Cells[1].Text;
                Session["idMateria"] = id;
                Response.Redirect("~/frm_bajaMateria.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ninguna materia') </script>");
            }
        }

        protected void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Materias.SelectedRow;
                string id = row.Cells[1].Text;
                Session["idMateria"] = id;
                Response.Redirect("~/frm_modificarMateria.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ninguna materia') </script>");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAdmin.aspx");

        }
    }
}