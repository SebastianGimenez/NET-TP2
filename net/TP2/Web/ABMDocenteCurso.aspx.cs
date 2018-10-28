using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMDocenteCurso : System.Web.UI.Page
    {
        private int idCurso;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                txt_Comision.Enabled = false;
                txt_Materia.Enabled = false;
                this.ddl_Cursos.DataSource = Business.Logic.ABMcurso.listarCursos();
                this.ddl_Cursos.DataValueField = "idCurso";
                this.ddl_Cursos.DataTextField = "nombre";
                this.ddl_Cursos.DataBind();
                idCurso =int.Parse(ddl_Cursos.SelectedValue);
                actualizarGrilla();
                int idComision = Business.Logic.ABMcurso.buscarComisionCurso(idCurso);
                int idMateria = Business.Logic.ABMcurso.buscarMateriaCurso(idCurso);
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

            }

        }

        private void actualizarGrilla()
        {
            try
            {
                List<int> idDocentes = Business.Logic.ABMcurso.buscarDocentes(idCurso);
                List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();
                foreach (int i in idDocentes)
                {
                    Business.Entities.Docente doc = Business.Logic.ABMdocente.buscarDocentePorId(i);
                    docentes.Add(doc);
                }
                gv_docentes.DataSource = docentes;
                gv_docentes.DataBind();
            }
            catch (Exception)
            {
                gv_docentes.DataSource = null;
                gv_docentes.DataBind();
            }
        }

     

       

        protected void ddl_Cursos_SelectedIndexChanged1(object sender, EventArgs e)
        {
            idCurso = int.Parse(ddl_Cursos.SelectedValue);
            int idComision = Business.Logic.ABMcurso.buscarComisionCurso(idCurso);
            int idMateria = Business.Logic.ABMcurso.buscarMateriaCurso(idCurso);
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

            this.actualizarGrilla();
        }

        protected void btn_alta_Click(object sender, EventArgs e)
        {
                Session["idCurso"] = int.Parse(ddl_Cursos.SelectedValue);
                Response.Redirect("~/frm_altaDocenteCurso.aspx");
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            Session["idCurso"] = int.Parse(ddl_Cursos.SelectedValue);    
            try
            {
                GridViewRow row = this.gv_docentes.SelectedRow;
                int id = int.Parse(row.Cells[6].Text);
                Session["idDocente"] = id;
                Response.Redirect("~/frm_bajaDocenteCurso.aspx");
            }
            catch (Exception)
            {
                //Ver como validar desde el cliente
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ningun docetne') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAdmin.aspx");

        }
    }
}