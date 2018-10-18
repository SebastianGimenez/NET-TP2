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
    public partial class frm_CursosAlumno : Form
    {
        public frm_CursosAlumno()
        {
            InitializeComponent();
            if (frm_Principal.PersonaLogueada.TipoUsuario == Business.Entities.tipoUsuario.ADMIN)
            { 
            comboBox1.DataSource = Business.Logic.ABMalumno.listarAlumnos();
            comboBox1.DisplayMember = "legajo";
            comboBox1.ValueMember = "idPersona";
            }
            else
            {
                this.Controls.Remove(comboBox1);
              
            }
            actualizarGrid();
        }


        private void actualizarGrid()
        {
            try
            {
                List<int> idCursos;


                if (frm_Principal.PersonaLogueada.TipoUsuario == Business.Entities.tipoUsuario.ADMIN)
                {
                   idCursos = Business.Logic.ABMalumno.listarCursosAlumno((int)comboBox1.SelectedValue);
                }
                else
                {
                    idCursos = Business.Logic.ABMalumno.listarCursosAlumno(frm_Principal.PersonaLogueada.IDPersona);
                }
                List<Business.Entities.Curso> cursos = new List<Business.Entities.Curso>();
                foreach (int i in idCursos)
                {
                    Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId(i);
                    cursos.Add(cur);
                    int nota;
                    if (frm_Principal.PersonaLogueada.TipoUsuario == Business.Entities.tipoUsuario.ADMIN)
                    {
                         nota = Business.Logic.ABMcurso.buscarNotaAlumnoCurso(cur.IdCurso, (int)comboBox1.SelectedValue);
                    }
                    else
                    {
                        nota = Business.Logic.ABMcurso.buscarNotaAlumnoCurso(cur.IdCurso, frm_Principal.PersonaLogueada.IDPersona);
                    }
                    if (nota != -1)
                    {
                        cur.Nota = nota;
                    }
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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = grv_Cursos.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idCurso = (int)celdas["idCurso"].Value;
                int idAlumno;
                if (frm_Principal.PersonaLogueada.TipoUsuario == Business.Entities.tipoUsuario.ADMIN)
                {
                    idAlumno = (int)comboBox1.SelectedValue;
                }
                else
                {
                    idAlumno = frm_Principal.PersonaLogueada.IDPersona;
                }
                bool borrado = Business.Logic.ABMalumno.borrarCursoAlumno(idCurso, idAlumno);
                if (borrado)
                { MessageBox.Show("Borrado exitosamente", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show("No se ha podido borrar, es probable que el curso ya haya sido puntuado", "Sin exito", MessageBoxButtons.OK); }
                this.actualizarGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Cuidado", MessageBoxButtons.OK);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
