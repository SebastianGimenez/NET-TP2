using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class frm_altaDocenteCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                Business.Entities.Curso curso = Business.Logic.ABMcurso.buscarCursoPorId((int)Session["idCurso"]);
                this.txt_curso.Text = curso.Nombre;
                this.txt_curso.Enabled = false;
                this.ddl_Docentes.DataSource = Business.Logic.ABMdocente.listarDocentes();
                this.ddl_Docentes.DataValueField = "idPersona";
                this.ddl_Docentes.DataTextField = "legajo";
                this.ddl_Docentes.DataBind();
            }
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            int idDoc = int.Parse(this.ddl_Docentes.SelectedValue);
            Business.Entities.Docente doc = new Business.Entities.Docente();
            doc.IDPersona = idDoc;
            Business.Entities.Curso cur = new Business.Entities.Curso();
            cur.IdCurso = (int)Session["idCurso"];
            bool agregado = Business.Logic.ABMcurso.agregarDocenteCurso(doc, cur);
            if (agregado)
            {
                Session.Remove("idCurso");
                Response.Redirect("~/ABMDocenteCurso.aspx");
            }
            else
            {
                Response.Write("<script type='text/javascript'> alert('No se ha podido dar de alta, es probable que ya exista ese docente en dicha comision') </script>");

            }

        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Session.Remove("idCurso");
            Response.Redirect("~/ABMDocenteCurso.aspx");

        }
    }
}