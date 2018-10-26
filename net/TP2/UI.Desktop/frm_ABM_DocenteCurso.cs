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
    public partial class frm_ABM_DocenteCurso : frm_BaseABM
    {
        public frm_ABM_DocenteCurso()
        {
            InitializeComponent();
            txtMateria.Enabled = false;
            txtComision.Enabled = false;
            this.cmb_curso.DataSource = Business.Logic.ABMcurso.listarCursos();
            this.cmb_curso.ValueMember = "idCurso";
            this.cmb_curso.DisplayMember = "nombre";
        }

        private void btn_buscarDocentes_Click(object sender, EventArgs e)
        {
            
        }
        private void actualizarGrilla()
        {
            try
            {
                int idCurso = (int)cmb_curso.SelectedValue;
                List<int> idDocentes = Business.Logic.ABMcurso.buscarDocentes(idCurso);
                List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();
                foreach (int i in idDocentes)
                {
                    Business.Entities.Docente doc = Business.Logic.ABMdocente.buscarDocentePorId(i);
                    docentes.Add(doc);
                }
                grd_view.DataSource = docentes;
            }
            catch (Exception)
            {
                grd_view.DataSource = null;
            }
        }

        override
         protected void alta()
        { 
            Business.Entities.Curso cur = (Business.Entities.Curso)this.cmb_curso.SelectedItem;
            new frm_AltaDocenteCurso(cur).ShowDialog();
            this.actualizarGrilla();
        }

        override
         protected void baja()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                Business.Entities.Docente doc = new Business.Entities.Docente(
                      celdas["nombre"].Value.ToString(),
                      celdas["apellido"].Value.ToString(),
                      celdas["legajo"].Value.ToString(),
                      celdas["dni"].Value.ToString(),
                      celdas["email"].Value.ToString(),
                      celdas["telefono"].Value.ToString()
                      );
                int idpersona = (int)celdas["IDPersona"].Value;
                doc.IDPersona = idpersona;
                Business.Entities.Curso cur = (Business.Entities.Curso)this.cmb_curso.SelectedItem;
                new frm_BajaDocenteCurso(doc, cur).ShowDialog();
                this.actualizarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show(this.Owner, "No se ha seleccionado ningun docente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_curso_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_curso.SelectedItem != null)
            {
                Business.Entities.Curso cur = (Business.Entities.Curso)cmb_curso.SelectedItem;
                int idComision = Business.Logic.ABMcurso.buscarComisionCurso(cur.IdCurso);
                int idMateria = Business.Logic.ABMcurso.buscarMateriaCurso(cur.IdCurso);
                Business.Entities.Comision com = Business.Logic.ABMcomision.buscarComisionPorId(idComision);
                if (com != null)
                {
                    txtComision.Text = com.NombreComision;
                }
                else
                {
                    txtComision.Text = "";
                }
                if (idMateria != -1)
                {
                    Business.Entities.Materia mat = Business.Logic.ABMmateria.buscarMateriaPorId(idMateria);
                    if (mat != null)
                    {
                        txtMateria.Text = mat.Nombre;
                    }
                    else
                    {
                        txtMateria.Text = "";
                    }
                }

                this.actualizarGrilla();
            }
        }
    }
}
