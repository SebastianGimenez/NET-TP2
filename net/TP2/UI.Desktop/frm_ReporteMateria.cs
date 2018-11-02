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
    public partial class frm_ReporteMateria : Form
    {
        public frm_ReporteMateria()
        {
            InitializeComponent();
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);

        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {

            int idPlan = int.Parse(e.Parameters[0].Values[0]);
            
           /* List<int> doc = Business.Logic.ABMcurso.buscarDocentes(idCurso);
            List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();
            foreach (int id in doc)
            {
                docentes.Add(Business.Logic.ABMdocente.buscarDocentePorId(id));
            }

            e.DataSources.Add(new ReportDataSource("Docentes", docentes));
            */
        }

        private void frm_ReporteMateria_Load(object sender, EventArgs e)
        {
            List<Business.Entities.Materia> materias = Business.Logic.ABMmateria.listarMaterias();
            this.bindingSource.DataSource = materias;
            this.reportViewer1.RefreshReport();
        }
    }
}
