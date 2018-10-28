using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarEspecialidad : System.Web.UI.Page
    {
        protected Business.Entities.Especialidad especialidad;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            especialidad = Business.Logic.ABMespecialidad.buscarEspecialidadPorId(int.Parse((string)Session["idEsp"]));
            if (!IsPostBack)
            {
                this.txt_nombre.Text = especialidad.NombreEspecialidad;
                this.txt_descripcion.Text = especialidad.Descripcion;
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string desc = this.txt_descripcion.Text;
            Business.Entities.Especialidad esp = new Business.Entities.Especialidad(nombre, desc);
            esp.IdEspecialidad = especialidad.IdEspecialidad;
            bool val = Business.Logic.ABMespecialidad.modificarEspecialidad(esp);
            if (val)
            {
                Session.Remove("idEsp");
                Response.Write("<script type='text/javascript'> alert('modificado correctamente'); location.href = '/ABMEspecialidad.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('no se pudo modificar, es probable que ese nombre de especialidad ya exista') </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMEspecialidad.aspx");
        }
    }
}