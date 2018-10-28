using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_puntuarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.DOCENTE)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId((int)Session["idCurso"]);
                Business.Entities.Alumno alu = Business.Logic.ABMalumno.buscarAlumnoPorId((int)Session["idAlumno"]);
                this.txt_curso.Text = cur.Nombre;
                this.txt_nombre.Text = alu.Apellido + ", "+ alu.Nombre;
                this.txt_legajo.Text = alu.Legajo;
                int nota = Business.Logic.ABMcurso.buscarNotaAlumnoCurso(cur.IdCurso, alu.IDPersona);
                if (nota != -1)
                {               
                    this.ddl_nota.SelectedValue = nota.ToString();
                }
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            bool agregado = Business.Logic.ABMcurso.modificarNotaAlumno((int)Session["idCurso"], (int)Session["idAlumno"], int.Parse(ddl_nota.SelectedValue), (string)ddl_estado.SelectedValue);
            if (agregado)
            {
                Session.Remove("idCurso");
                Session.Remove("idAlumno");
                Response.Write("<script type='text/javascript'> alert('Puntuado correctamente'); location.href = '/frm_puntuacionAlumno.aspx' </script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se pudo puntuar') </script>");

            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idCurso");
            Session.Remove("idAlumno");
            Response.Redirect("~/frm_puntuacionAlumno.aspx");
        }  
    }
}