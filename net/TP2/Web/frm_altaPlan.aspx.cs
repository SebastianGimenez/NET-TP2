using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddl_Especialidades.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
                this.ddl_Especialidades.DataTextField = "nombreEspecialidad";
                this.ddl_Especialidades.DataValueField = "idEspecialidad";
                this.ddl_Especialidades.DataBind();
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string desc = this.txt_descripcion.Text;
            Business.Entities.Plan plan = new Business.Entities.Plan(nombre, desc);
            int idEsp = int.Parse(ddl_Especialidades.SelectedValue);
            Business.Entities.Especialidad esp = new Business.Entities.Especialidad();
            esp.IdEspecialidad = idEsp;
            plan.Especialidad = esp;
            bool val = Business.Logic.ABMplan.altaPlan(plan);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Dado de alta correctamente') </script>");
                Response.Redirect("~/ABMPlan.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta, es probable que ya exista otro plan con ese nombre') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMPlan.aspx");
        }
    }
}