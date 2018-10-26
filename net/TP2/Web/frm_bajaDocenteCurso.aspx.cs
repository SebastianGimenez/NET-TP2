using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_bajaDocenteCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {if (!IsPostBack)
            {
                Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId((int)Session["idCurso"]);
                Business.Entities.Docente doc = Business.Logic.ABMdocente.buscarDocentePorId((int)Session["idDocente"]);
                this.txt_curso.Text = cur.Nombre;
                this.txt_curso.Enabled = false;
                this.txt_docente.Enabled = false;
                this.txt_docente.Text = doc.Legajo;
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId((int)Session["idCurso"]);
            Business.Entities.Docente doc = Business.Logic.ABMdocente.buscarDocentePorId((int)Session["idDocente"]);
            bool borrado = Business.Logic.ABMcurso.borrarDocenteCurso(doc, cur);
            if (borrado)
            {
                Session.Remove("idCurso");
                Session.Remove("idDocente");
                Response.Write("<script type='text/javascript'> alert('docente eliminado del curso correctamente') </script>");
                Response.Redirect("~/ABMDocenteCurso.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('algo ha fallado') </script>");

            }

        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idCurso");
            Session.Remove("idDocente");
            Response.Redirect("~/ABMDocenteCurso.aspx");

        }
    }
}