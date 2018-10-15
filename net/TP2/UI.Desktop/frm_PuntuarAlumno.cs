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
    public partial class frm_PuntuarAlumno : Form
    {
        public frm_PuntuarAlumno()
        {
            InitializeComponent();
            comboBox1.DataSource = Business.Logic.ABMdocente.listarDocentes();
            comboBox1.DisplayMember = "legajo";
            comboBox1.ValueMember = "idPersona";
        }


        private void actualizarMateriasDocente()
        {
            try
            {
                List<int> idCursos = Business.Logic.ABMdocente.listarCursosDocente((int)comboBox1.SelectedValue);
                //el combo de legajos se elimina y se manda en el metodo de arriba el id del docente logueado
                List<Business.Entities.Curso> cursos = new List<Business.Entities.Curso>();
                foreach (int i in idCursos)
                {
                    Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCursoPorId(i);
                    cursos.Add(cur);
                }
                this.cmb_Cursos.DataSource = cursos;
                this.cmb_Cursos.DisplayMember = "nombre";
                this.cmb_Cursos.ValueMember = "idCurso";
            }
            catch
            {
                this.cmb_Cursos.DataSource = null;
            }
        }
        private void actualizarGrilla()
        {
            try
            {
                List<int> idAlumnos = Business.Logic.ABMcurso.buscarAlumnos((int)cmb_Cursos.SelectedValue);
                List<Business.Entities.Alumno> alumnos = new List<Business.Entities.Alumno>();
                foreach (int i in idAlumnos)
                {
                    Business.Entities.Alumno al = Business.Logic.ABMalumno.buscarAlumnoPorId(i);
                    alumnos.Add(al);
                }
                this.grv_Alumnos.DataSource = alumnos;
            }
            catch
            {
                this.cmb_Cursos.DataSource = null;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.actualizarMateriasDocente();
        }

        private void cmb_Cursos_SelectedValueChanged(object sender, EventArgs e)
        {
            this.actualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Puntuar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = grv_Alumnos.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idAlumno = (int)celdas["idPersona"].Value;
                string legajo = celdas["legajo"].Value.ToString();
                string nombre = celdas["Nombre"].Value.ToString() + " " + celdas["Apellido"].Value.ToString();

                Business.Entities.Curso curso = (Business.Entities.Curso)cmb_Cursos.SelectedItem;
                new frm_PuntuacionAlumno(curso,idAlumno,nombre,legajo).ShowDialog();
                
            }
            catch (NullReferenceException ex)
            {
               
            }
        }
    }
}
