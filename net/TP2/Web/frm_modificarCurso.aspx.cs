using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_modificarCurso : System.Web.UI.Page
    {
        Business.Entities.Curso curso;
        protected void Page_Load(object sender, EventArgs e)
        {
            curso = Business.Logic.ABMcurso.buscarCursoPorId(int.Parse((string)Session["idCurso"]));
            if (!IsPostBack)
            {
                int idCom = Business.Logic.ABMcurso.buscarComisionCurso(curso.IdCurso);
                this.ddl_comisiones.DataSource = Business.Logic.ABMcomision.listarComisiones();
                this.ddl_comisiones.DataTextField = "nombreComision";
                this.ddl_comisiones.DataValueField = "idComision";
                this.ddl_comisiones.DataBind();
                int idMat = Business.Logic.ABMcurso.buscarMateriaCurso(curso.IdCurso);
                this.ddl_materias.DataSource = Business.Logic.ABMmateria.listarMaterias();
                this.ddl_materias.DataTextField = "nombre";
                this.ddl_materias.DataValueField = "idMateria";
                this.ddl_materias.DataBind();
                this.ddl_materias.SelectedValue = idMat.ToString();
                this.txt_nombre.Text = curso.Nombre;
                this.txt_cupo.Text = curso.Cupo.ToString();
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            int cupo = int.Parse(this.txt_cupo.Text);
            Business.Entities.Curso cur = new Business.Entities.Curso(nombre, cupo);
            cur.IdCurso = curso.IdCurso;
            int idCom = int.Parse(ddl_comisiones.SelectedValue);
            Business.Entities.Comision com = new Business.Entities.Comision();
            com.IdComision = idCom;
            cur.Comision = com;
            int idMat = int.Parse(ddl_materias.SelectedValue);
            Business.Entities.Materia mat = new Business.Entities.Materia();
            mat.IdMateria = idMat;
            cur.Materia = mat;
            bool val = Business.Logic.ABMcurso.modificarCurso(cur);
            if (val)
            {
                Response.Write("<script type='text/javascript'> alert('Modificado correctamente') </script>");
                Response.Redirect("~/ABMCurso.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido modificar, es probable que ya exista otra curso con ese nombre') </script>");
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ABMCurso.aspx");

        }
    }
}