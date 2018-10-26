using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_inscripcionAlumnoMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gv_cursos.DataSource = Business.Logic.ABMcurso.listarCursos();
            gv_cursos.DataBind();
        }

        protected void btn_inscribir_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno = (int)Session["idPersonaLogueada"];
                GridViewRow row = gv_cursos.SelectedRow;             
                int idCurso = int.Parse(row.Cells[2].Text);
                bool agregado = Business.Logic.ABMalumno.inscribirCursoAlumno(idCurso, idAlumno);
                if (agregado)
                {
                    Response.Write("<script type='text/javascript'> alert('Alumno inscripto correctamente') </script>");
                    Response.Redirect("~/frm_inscripcionAlumnoMateria.aspx");
                }
                else
                {
                    Response.Write("<script type='text/javascript'> alert('No se ha podico inscribir al alumno, es probable que el alumno ya se encuentre inscripto a ese curso o a la misma materia en otro curso ');  </script>");
                }
            }
            catch (Exception j )
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podico inscribir al alumno, es probable que el alumno ya se encuentre inscripto a ese curso o a la misma materia en otro curso ');  </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAlumno.aspx");

        }
    }
}