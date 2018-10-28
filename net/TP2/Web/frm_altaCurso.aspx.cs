using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                this.ddl_comisiones.DataSource = Business.Logic.ABMcomision.listarComisiones();
                this.ddl_comisiones.DataTextField = "nombreComision";
                this.ddl_comisiones.DataValueField = "idComision";
                this.ddl_comisiones.DataBind();
                this.ddl_materias.DataSource = Business.Logic.ABMmateria.listarMaterias();
                this.ddl_materias.DataTextField = "nombre";
                this.ddl_materias.DataValueField = "idMateria";
                this.ddl_materias.DataBind();
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {

            string nombre = this.txt_nombre.Text;
            int cupo =int.Parse(this.txt_cupo.Text);
            Business.Entities.Curso cur = new Business.Entities.Curso(nombre, cupo);
            int idCom = int.Parse(ddl_comisiones.SelectedValue);
            Business.Entities.Comision com = new Business.Entities.Comision();
            com.IdComision = idCom;
            cur.Comision= com;
            int idMat = int.Parse(ddl_materias.SelectedValue);
            Business.Entities.Materia mat = new Business.Entities.Materia();
            mat.IdMateria = idMat;
            cur.Materia = mat;
            bool val = Business.Logic.ABMcurso.altaCurso(cur);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Dado de alta correctamente'); location.href = '/ABMCurso.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta, es probable que ya exista otro curso con ese nombre') </script>");
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMCurso.aspx");

        }
    }
}