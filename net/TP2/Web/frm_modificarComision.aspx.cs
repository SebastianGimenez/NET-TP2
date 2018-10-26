using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarComision : System.Web.UI.Page
    {
        protected Business.Entities.Comision comision;

        protected void Page_Load(object sender, EventArgs e)
        {
            comision = Business.Logic.ABMcomision.buscarComisionPorId(int.Parse((string)Session["idCom"]));
            if (!IsPostBack)
            {
                this.txt_nombre.Text = comision.NombreComision;
                this.txt_aula.Text = comision.Aula;
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string aula = this.txt_aula.Text;
            Business.Entities.Comision com = new Business.Entities.Comision(nombre, aula);
            com.IdComision = comision.IdComision;
            bool val = Business.Logic.ABMcomision.modificarComision(com);
            if (val)
            {
                Session.Remove("idCom");
                Response.Write("<script type='text/javascript'> alert('modificado correctamente') </script>");
                Response.Redirect("~/ABMComision.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se pudo modificar, es probable que ese nombre de comision ya exista') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idCom");
            Response.Redirect("~/ABMComision.aspx");
        }
    }
}