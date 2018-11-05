using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
namespace Web
{
    public partial class reporteCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["tipoPersonaLogueada"] == null) || (Business.Entities.tipoUsuario)Session["tipoPersonaLogueada"] != Business.Entities.tipoUsuario.ADMIN)
            {
                Response.Redirect("~/loguin.aspx");
            }
            if (!IsPostBack)
            {
                ReportViewer.Reset();
                ReportDataSource rptDataSource = new ReportDataSource("Cursos", Business.Logic.ABMcurso.listarCursos());

                this.ReportViewer.LocalReport.DataSources.Add(rptDataSource);
                this.ReportViewer.LocalReport.ReportPath = "../Reports/reportCursos.rdlc";
                ReportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                this.ReportViewer.LocalReport.Refresh();

            }
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {

            int idCurso = int.Parse(e.Parameters[0].Values[0]);
            List<int> doc = Business.Logic.ABMcurso.buscarDocentes(idCurso);
            List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();
            foreach (int id in doc)
            {
                docentes.Add(Business.Logic.ABMdocente.buscarDocentePorId(id));
            }

            e.DataSources.Add(new ReportDataSource("Docentes", docentes));
        }
    }
}