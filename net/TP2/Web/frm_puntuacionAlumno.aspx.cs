using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_puntuacionAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {if (!IsPostBack)
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
                    this.ddl_Cursos.DataSource = cursos;
                    this.ddl_Cursos.DataTextField = "nombre";
                    this.ddl_Cursos.DataValueField = "idCurso";
                    this.ddl_Cursos.DataBind();
                    actualizarGrilla();
                }
                catch
                {
                    this.ddl_Cursos.DataSource = null;
                }
            }
        }

        private void actualizarGrilla()
        {
            try
            {
                int idComision = Business.Logic.ABMcurso.buscarComisionCurso(int.Parse(ddl_Cursos.SelectedValue));
                int idMateria = Business.Logic.ABMcurso.buscarMateriaCurso(int.Parse(ddl_Cursos.SelectedValue));
                Business.Entities.Comision com = Business.Logic.ABMcomision.buscarComisionPorId(idComision);
                if (com != null)
                {
                    txt_Comision.Text = com.NombreComision;
                }
                else
                {
                    txt_Comision.Text = "";
                }
                if (idMateria != -1)
                {
                    Business.Entities.Materia mat = Business.Logic.ABMmateria.buscarMateriaPorId(idMateria);
                    if (mat != null)
                    {
                        txt_Materia.Text = mat.Nombre;
                    }
                    else
                    {
                        txt_Materia.Text = "";
                    }
                }
                List<int> idAlumnos = Business.Logic.ABMcurso.buscarAlumnos(int.Parse(ddl_Cursos.SelectedValue));
                List<Business.Entities.Alumno> alumnos = new List<Business.Entities.Alumno>();
                foreach (int i in idAlumnos)
                {
                    Business.Entities.Alumno al = Business.Logic.ABMalumno.buscarAlumnoPorId(i);
                    alumnos.Add(al);
                }
                this.gv_alumnos.DataSource = alumnos;
                this.gv_alumnos.DataBind();
            }
            catch
            {
                this.gv_alumnos.DataSource = null;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = gv_alumnos.SelectedRow;
                int idAlumno = int.Parse(row.Cells[6].Text);
                Session["idAlumno"] = idAlumno;
                int idCurso = int.Parse(ddl_Cursos.SelectedValue);
                Session["idCurso"] = idCurso;
                Response.Redirect("~/frm_puntuarAlumno.aspx");
            }
            catch (NullReferenceException ex)
            {
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun alumno') </script>");

            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexDocente.aspx");
        }

        protected void ddl_Cursos_SelectedIndexChanged1(object sender, EventArgs e)
        {        
            actualizarGrilla();
        }
    }
}