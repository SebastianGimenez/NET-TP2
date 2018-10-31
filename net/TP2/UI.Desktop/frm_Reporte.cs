using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace UI.Desktop
{
    public partial class frm_Reporte : Form
    {
        public frm_Reporte()
        {
            InitializeComponent();
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);

        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
         
            int idCurso = int.Parse(e.Parameters[0].Values[0]);
            List<int> doc = Business.Logic.ABMcurso.buscarDocentes(idCurso);
            List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();
            foreach(int id in doc)
            {
                docentes.Add(Business.Logic.ABMdocente.buscarDocentePorId(id));
            }
            
            e.DataSources.Add(new ReportDataSource("Docentes", docentes));
        }


        private void frm_Reporte_Load(object sender, EventArgs e)
        {
            this.AuthorBindingSource.DataSource = Business.Logic.ABMcurso.listarCursos();
            this.reportViewer1.RefreshReport();
        }
    }
}
