using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace UI.Web.ABMS.Alumnos
{
    public partial class ABMAlumnos : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void btnModi_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = this.gvAlumnos.SelectedRow;
                string legajo = row.Cells[3].Text;
                Session["legajo"] = legajo;
                Response.Redirect("http://localhost:54354/ABMS/Alumnos/ModiAlumno.aspx");
            }
            catch (Exception) {
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun alumno') </script>");
            }
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/AltaAlumno.aspx");
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/BajaAlumno.aspx");
        }
    }
}