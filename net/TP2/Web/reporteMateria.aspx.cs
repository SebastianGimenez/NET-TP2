using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;


namespace Web
{
    public partial class reporteMateria : System.Web.UI.Page
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
                ReportDataSource rptDataSource = new ReportDataSource("Materias", Business.Logic.ABMmateria.listarMaterias());

                this.ReportViewer.LocalReport.DataSources.Add(rptDataSource);
                this.ReportViewer.LocalReport.ReportPath = "../Reports/reportMaterias.rdlc";

                this.ReportViewer.LocalReport.Refresh();

            }

        }
    }
}
