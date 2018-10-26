using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarMateria : System.Web.UI.Page
    {
        Business.Entities.Materia materia;
        protected void Page_Load(object sender, EventArgs e)
        {
            materia = Business.Logic.ABMmateria.buscarMateriaPorId(int.Parse((string)Session["idMateria"]));
            if (!IsPostBack)
            {
                int idPlan = Business.Logic.ABMmateria.buscarPlanDeMateria(materia.IdMateria);
                this.ddl_planes.DataSource = Business.Logic.ABMplan.listarPlanes();
                this.ddl_planes.DataTextField = "nombrePlan";
                this.ddl_planes.DataValueField = "idPlan";
                this.ddl_planes.DataBind();
                this.ddl_planes.SelectedValue = idPlan.ToString();
                this.txt_nombre.Text = materia.Nombre;
                this.txt_descripcion.Text = materia.Descripcion;
                this.txt_hsSemanales.Text = materia.HorasSemanales.ToString();
                this.txt_hsTotales.Text = materia.HorasTotales.ToString();

            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string desc = this.txt_descripcion.Text;
            int hsSemanales = int.Parse(this.txt_hsSemanales.Text);
            int hsTotales = int.Parse(this.txt_hsTotales.Text);
            Business.Entities.Materia mate = new Business.Entities.Materia(nombre, desc, hsSemanales, hsTotales);
            mate.IdMateria = materia.IdMateria;
            int idPlan = int.Parse(ddl_planes.SelectedValue);
            Business.Entities.Plan plan = new Business.Entities.Plan();
            plan.IdPlan = idPlan;
            mate.Plan = plan;
            bool val = Business.Logic.ABMmateria.modificarMateria(mate);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Modificado correctamente') </script>");
                Response.Redirect("~/ABMMateria.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido modificar, es probable que ya exista otra materia con ese nombre o que las horas totales sean menos que las semanales') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMMateria.aspx");

        }
    }
}