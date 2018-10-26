using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaEspecialidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string desc = this.txt_descripcion.Text;
            Business.Entities.Especialidad espe = new Business.Entities.Especialidad(nombre, desc);
            bool val = Business.Logic.ABMespecialidad.altaEspecialidad(espe);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Dado de alta correctamente') </script>");
                Response.Redirect("~/ABMEspecialidad.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta, es probable que ya exista otra especialidad con ese nombre') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMEspecialidad.aspx");
        }
    }
}