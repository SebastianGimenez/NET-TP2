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
    public partial class frm_InscripcionCursoAlumno : Form
    {
        public frm_InscripcionCursoAlumno()
        {
            InitializeComponent();
            if (frm_Principal.PersonaLogueada.TipoUsuario == Business.Entities.tipoUsuario.ALUMNO)
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(comboBox1);
            }
            else
            { 
            this.comboBox1.DataSource = Business.Logic.ABMalumno.listarAlumnos();
            this.comboBox1.DisplayMember = "legajo";
            this.comboBox1.ValueMember = "idPersona";
            
            }
            this.grv_Cursos.DataSource = Business.Logic.ABMcurso.listarCursos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                this.grv_Cursos.DataSource = Business.Logic.ABMcurso.listarCursosPorNombre(txtNombre.Text);
            }
            else {
                this.grv_Cursos.DataSource = Business.Logic.ABMcurso.listarCursos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno;
                if (frm_Principal.PersonaLogueada.TipoUsuario == Business.Entities.tipoUsuario.ADMIN)
                { idAlumno = (int)this.comboBox1.SelectedValue; }
                else
                {
                    idAlumno = frm_Principal.PersonaLogueada.IDPersona;
                }
                DataGridViewRow row = grv_Cursos.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idCurso = (int)celdas["idCurso"].Value;
                bool agregado = Business.Logic.ABMalumno.inscribirCursoAlumno(idCurso, idAlumno);
                if (agregado)
                { MessageBox.Show("Agregado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show("No ha podido agregar, es probable que ya se encuentre inscripto o que el curso ya no tenga cupo disponible.", "Sin exito", MessageBoxButtons.OK); }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha ido mal", "Cuidado", MessageBoxButtons.OK);
            }
        }
    }
}
