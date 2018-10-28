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
    public partial class frm_Docente : Form
    {
        public frm_Docente()
        {
            InitializeComponent();
        }

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_CursosDocente().ShowDialog();
        }

        private void puntuarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_PuntuarAlumno().ShowDialog();
        }

        private void lnk_salir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            new frm_Principal().Show();           
        }

        private void frm_Docente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
