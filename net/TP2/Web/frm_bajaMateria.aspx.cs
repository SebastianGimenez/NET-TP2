using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                this.ddl_materias.DataSource = Business.Logic.ABMmateria.listarMaterias();
                this.ddl_materias.DataTextField = "nombre";
                this.ddl_materias.DataValueField = "idMateria";
                this.ddl_materias.DataBind();
                this.ddl_materias.SelectedValue = (string)Session["idMateria"];
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMMateria.aspx");
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {

            bool val = Business.Logic.ABMmateria.borrarMateria(int.Parse(ddl_materias.SelectedValue));
            if (val)
            {
                Session.Remove("idMateria");
                //no se muestra el mensaje
                Response.Write("<script type='text/javascript'> alert('dado de baja con exito'); location.href = '/ABMMateria.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se ha podido dar de baja la materia') </script>");
            }
        }
    }
}