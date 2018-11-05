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
         ReportViewer1.Reset();
            ReportDataSource rptDataSource = new ReportDataSource("Materias", Business.Logic.ABMmateria.listarMaterias());

            this.ReportViewer1.LocalReport.DataSources.Add(rptDataSource);
            
          this.ReportViewer1.LocalReport.ReportPath = "Materia.rdlc";
            this.ReportViewer1.LocalReport.Refresh();
        }
    }
}
