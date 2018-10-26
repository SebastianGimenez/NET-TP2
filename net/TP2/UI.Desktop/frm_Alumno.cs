using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frm_Alumno : Form
    {
        public frm_Alumno()
        {
            InitializeComponent();
        }

        private void inscribirseAUnaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_InscripcionCursoAlumno().ShowDialog();
        }

        private void verMisNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_CursosAlumno().ShowDialog();
            
        }

        private void lnk_salir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            new frm_Principal().Show();
           
        }
    }
}
