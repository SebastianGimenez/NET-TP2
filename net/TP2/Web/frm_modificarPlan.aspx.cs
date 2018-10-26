using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarPlan : System.Web.UI.Page
    { Business.Entities.Plan plan;
        protected void Page_Load(object sender, EventArgs e)
        {
            plan = Business.Logic.ABMplan.buscarPlanPorId(int.Parse((string)Session["idPlan"]));
            if (!IsPostBack)
            {
                int idEsp = Business.Logic.ABMplan.buscarEspDelPlan(plan.IdPlan);
                this.ddl_Especialidades.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
                this.ddl_Especialidades.DataTextField = "nombreEspecialidad";
                this.ddl_Especialidades.DataValueField = "idEspecialidad";
                this.ddl_Especialidades.DataBind();
                this.ddl_Especialidades.SelectedValue = idEsp.ToString();
                this.txt_nombre.Text = plan.NombrePlan;
                this.txt_descripcion.Text = plan.DescripcionPlan;
            }

        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string desc = this.txt_descripcion.Text;
            Business.Entities.Plan pla = new Business.Entities.Plan(nombre, desc);
            int idEsp = int.Parse(ddl_Especialidades.SelectedValue);
            Business.Entities.Especialidad esp = new Business.Entities.Especialidad();
            esp.IdEspecialidad = idEsp;
            pla.Especialidad = esp;
            pla.IdPlan = plan.IdPlan;
            bool val = Business.Logic.ABMplan.modificarPlan(pla);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Modificado correctamente') </script>");
                Response.Redirect("~/ABMPlan.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido modificar, es probable que ya exista otro plan con ese nombre') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMPlan.aspx");

        }
    }
}