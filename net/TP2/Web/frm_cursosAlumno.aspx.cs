using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_cursosAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
        }
        private void actualizarGrilla()
        {
            List<int> idCursos;
            idCursos = Business.Logic.ABMalumno.listarCursosAlumno((int)Session["idPersonaLogueada"]);
            List<Business.Entities.Curso> cursos = new List<Business.Entities.Curso>();
            foreach (int i in idCursos)
            {
                Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId(i);
                cursos.Add(cur);
                int nota;
                nota = Business.Logic.ABMcurso.buscarNotaAlumnoCurso(cur.IdCurso, (int)Session["idPersonaLogueada"]);
                if (nota != -1)
                {
                    cur.Nota = nota;
                }
            }
            this.gv_cursos.DataSource = cursos;
            this.gv_cursos.DataBind();
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = gv_cursos.SelectedRow;               
                int idCurso = int.Parse(row.Cells[2].Text);               
                bool borrado = Business.Logic.ABMalumno.borrarCursoAlumno(idCurso, (int)Session["idPersonaLogueada"]);
                if (borrado)
                {
                    Response.Write("<script type='text/javascript'> alert('Borrado con exito');  </script>");
                    actualizarGrilla();
                }
                else
                {
                    Response.Write("<script type='text/javascript'> alert('No se ha podico dar de baja la inscripcion, es probable que ya haya sido puntuado');  </script>");
                    
                }
               
            }
            catch (Exception)
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podico dar de baja la inscripcion, es probable que ya haya sido puntuado');  </script>");
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAlumno.aspx");
        }
    }
}