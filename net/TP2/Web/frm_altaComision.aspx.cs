using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaComision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string aula = this.txt_aula.Text;
            Business.Entities.Comision com = new Business.Entities.Comision(nombre, aula);
            bool val = Business.Logic.ABMcomision.altaComision(com);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Dado de alta correctamente') </script>");
                Response.Redirect("~/ABMComision.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta, es probable que ya exista otra comision con ese nombre') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMComision.aspx");
        }
    }
}