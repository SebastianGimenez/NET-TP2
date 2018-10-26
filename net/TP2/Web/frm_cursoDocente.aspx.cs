using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_cursoDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            acualizarGrilla();
        }
        protected void acualizarGrilla()
        {
            try
            {
                List<int> idCursos;               
                    idCursos = Business.Logic.ABMdocente.listarCursosDocente((int)Session["idPersonaLogueada"]);
                List<Business.Entities.Curso> cursos = new List<Business.Entities.Curso>();
                foreach (int i in idCursos)
                {
                    Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId(i);
                    cursos.Add(cur);
                }
                this.gv_cursos.DataSource = cursos;
                this.gv_cursos.DataBind();
            }
            catch
            {
                this.gv_cursos.DataSource = null;
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexDocente.aspx");
        }
    }
}