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
    public partial class frm_CursosDocente : Form
    {
        public frm_CursosDocente()
        {
            InitializeComponent();
            comboBox1.DataSource = Business.Logic.ABMdocente.listarDocentes();
            comboBox1.DisplayMember = "legajo";
            comboBox1.ValueMember = "idPersona";
        }


        private void actualizarGrid()
        {
            try
            {
                List<int> idCursos = Business.Logic.ABMdocente.listarCursosDocente((int)comboBox1.SelectedValue);
                //El combo se elimina y el metodo de arriba recibe el id del docente logueado
                List<Business.Entities.Curso> cursos = new List<Business.Entities.Curso>();
                foreach (int i in idCursos)
                {
                    Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId(i);
                    cursos.Add(cur);
                }
                this.grv_Cursos.DataSource = cursos;
            }
            catch
            {
                this.grv_Cursos.DataSource = null;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.actualizarGrid();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
