using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Inicio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContentPlaceHolder1_Init(object sender, EventArgs e)
        {

        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {
            Session.Remove("idPersonaLogueada");
            Session.Remove("tipoPersonaLogueada");
            Response.Redirect("~/loguin.aspx");
        }
    }
}