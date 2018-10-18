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
    public partial class frm_Principal : Form
    {   
        public static Business.Entities.Persona PersonaLogueada { get; set; }
        public frm_Principal()
        {
            InitializeComponent();
           
        }

        private void activateControllers()
        {
            int nEsp = Business.Logic.ABMespecialidad.contarEspecialidades();
            int nPlan = Business.Logic.ABMplan.contarPlanes();
            int nMaterias = Business.Logic.ABMmateria.contarMaterias();
            int nComision = Business.Logic.ABMcomision.contarComisiones();
            int nDocentes = Business.Logic.ABMdocente.contarDocentes();
            if (nEsp == 0)
            {
                planToolStripMenuItem.Enabled = false;
                materiaToolStripMenuItem.Enabled = false;
                cursoToolStripMenuItem.Enabled = false;
            }
            else if (nPlan == 0)
            {
                planToolStripMenuItem.Enabled = true;
                materiaToolStripMenuItem.Enabled = false;
                cursoToolStripMenuItem.Enabled = false;
            }
            else if (nMaterias == 0)
            {
                materiaToolStripMenuItem.Enabled = true;
                cursoToolStripMenuItem.Enabled = false;
            }
            else if(nComision == 0 || nDocentes == 0)
            {
                cursoToolStripMenuItem.Enabled = false;
            }
            else
            {
                cursoToolStripMenuItem.Enabled = true;
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMAlumno().ShowDialog();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMdocente().ShowDialog();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMespecialidad().ShowDialog();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMplan().ShowDialog();

        }

        private void comisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMcomision().ShowDialog();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMmateria().ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABMcurso().ShowDialog();
        }

        private void frm_Principal_Activated(object sender, EventArgs e)
        {
            this.activateControllers();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void docenteCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_ABM_DocenteCurso().ShowDialog();
        }

        private void inscripcionACursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_InscripcionCursoAlumno().ShowDialog();
        }

        private void verMisCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new frm_CursosAlumno().ShowDialog();
        }

        private void verMisCursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frm_CursosDocente().ShowDialog();
        }

        private void puntuarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_PuntuarAlumno().ShowDialog();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.IsLoggedIn = false;
            frm.ShowDialog();

            if (!frm.IsLoggedIn)
            {
                this.Close();
                Application.Exit();
                return;
            }
            else
            {
                PersonaLogueada = frm.Persona;
                switch (frm.Persona.TipoUsuario)
                { 
                    case Business.Entities.tipoUsuario.ALUMNO:
                        new frm_Alumno().ShowDialog();
                        Application.Exit();
                        break;
                    case Business.Entities.tipoUsuario.DOCENTE:
                        new frm_Docente().ShowDialog();
                        Application.Exit();
                        break;
                    case Business.Entities.tipoUsuario.ADMIN:
                        break;
                    default:
                        Application.Exit();
                        break;
                }
            }
        }
    }
}
