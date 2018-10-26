using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ddl_planes.DataSource = Business.Logic.ABMplan.listarPlanes();
                this.ddl_planes.DataTextField = "nombrePlan";
                this.ddl_planes.DataValueField = "idPlan";
                this.ddl_planes.DataBind();
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string desc = this.txt_descripcion.Text;
            int hsSemanales = int.Parse(this.txt_hsSemanales.Text);
            int hsTotales = int.Parse(this.txt_hsTotales.Text);
            Business.Entities.Materia materia = new Business.Entities.Materia(nombre, desc,hsSemanales,hsTotales);
            int idPlan = int.Parse(ddl_planes.SelectedValue);
            Business.Entities.Plan plan = new Business.Entities.Plan();
            plan.IdPlan = idPlan;
            materia.Plan = plan;
            bool val = Business.Logic.ABMmateria.altaMateria(materia);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Dado de alta correctamente') </script>");
                Response.Redirect("~/ABMMateria.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta, es probable que ya exista otra materia con ese nombre o que las horas totales sean menos que las semanales') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMMateria.aspx");

        }
    }
}