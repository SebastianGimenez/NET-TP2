using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMAlumno : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
                this.grv_Alumnos.DataSource = Business.Logic.ABMalumno.listarAlumnos();
                this.grv_Alumnos.DataBind();
            
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frm_altaAlumno.aspx");
        }
    
        protected void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.grv_Alumnos.SelectedRow;
                string legajo = row.Cells[3].Text;
                Session["legajo"] = legajo;
                Response.Redirect("~/frm_bajaAlumno.aspx");
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
                GridViewRow row = this.grv_Alumnos.SelectedRow;
                string legajo = row.Cells[3].Text;
                Session["legajo"] = legajo;
                Response.Redirect("~/frm_modificarAlumno.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun alumno') </script>");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAdmin.aspx");
        }
    }
}