using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Business.Entities.Alumno> lista = Business.Logic.ABMalumno.listarAlumnos();
                this.ddl_legajos.DataSource = lista;
                this.ddl_legajos.DataTextField = "Legajo";
                this.ddl_legajos.DataValueField = "Legajo";
                this.ddl_legajos.DataBind();
                this.ddl_legajos.SelectedValue = (string)Session["legajo"];
            }
        }

      

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool val = Business.Logic.ABMalumno.borrarAlumno(ddl_legajos.SelectedValue);
            if (val)
            {//el cartel de que se dio de baja bien no se ve
                Session.Remove("legajo");
                Response.Write("<script type='text/javascript'> alert('dado de baja correctamente')</script>");
                Response.Redirect("~/ABMAlumno.aspx");           
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja')</script>"); 
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("legajo");
            Response.Redirect("~/ABMAlumno.aspx");
        }

        
    }
}