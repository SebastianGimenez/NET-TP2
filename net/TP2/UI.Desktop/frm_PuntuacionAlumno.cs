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
    public partial class frm_PuntuacionAlumno : Form
    {
        Business.Entities.Curso curso;
        int idAlumno;
        public frm_PuntuacionAlumno(Business.Entities.Curso cur, int id, string legajo, string nombre)
        {
            InitializeComponent();
            curso = cur;
            txtCurso.Text = cur.Nombre;
            txtCurso.Enabled = false;
            txtLegajo.Text = legajo;
            txtLegajo.Enabled = false;
            txtNombre.Text = nombre;
            txtNombre.Enabled = false;
            idAlumno = id;
            cmb_Estado.Items.Add("Libre");
            cmb_Estado.Items.Add("Regular");
            cmb_Estado.Items.Add("Promovido");
            cmb_Estado.SelectedItem = "Libre";
            for (int i=0; i<11; i++)
            {
                cmbNota.Items.Add(i);
            }
            int nota = Business.Logic.ABMcurso.buscarNotaAlumnoCurso(cur.IdCurso, id);
            if (nota != -1)
            {
                MessageBox.Show(this.Owner, "Ya has puntuado a este alumno en este curso", "Cuidado", MessageBoxButtons.OK);
                this.cmbNota.SelectedItem = nota;
            }

        }

        private void btnPuntuar_Click(object sender, EventArgs e)
        {
            bool agregado = Business.Logic.ABMcurso.modificarNotaAlumno(curso.IdCurso, idAlumno, (int)cmbNota.SelectedItem, (string)cmb_Estado.SelectedItem);
            if (agregado) { MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK); }
            else { MessageBox.Show(this.Owner, "No se ha podido guardar", "Sin exito", MessageBoxButtons.OK); }
            this.Close();

        }

        private void cmbNota_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((int)cmbNota.SelectedItem < 6)
            { cmb_Estado.SelectedItem = "Libre"; }
            else if ((int)cmbNota.SelectedItem < 8)
            { cmb_Estado.SelectedItem = "Regular"; }
            else { cmb_Estado.SelectedItem = "Promovido"; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
