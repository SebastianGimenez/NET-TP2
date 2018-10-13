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
    public partial class frm_ABMcurso : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaCurso().ShowDialog();
            grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
        }

        override
        protected void baja()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idCurso = (int)celdas["idCurso"].Value;
                new frm_BajaCurso(idCurso).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
            }
            catch (Exception e)
            {
                new frm_BajaCurso().ShowDialog();
                grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();

            }
        }

        override
       protected void modi()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idCurso = (int)celdas["idCurso"].Value;
                string nombre = celdas["nombre"].Value.ToString();
                int cupo = (int)celdas["cupo"].Value;
                Business.Entities.Curso curso = new Business.Entities.Curso(nombre, cupo);
                curso.IdCurso = idCurso;
                new frm_AltaCurso(curso).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
            }
            catch (Exception e)
            {
                MessageBox.Show("No ha seleccionado ningun curso", "Cuidado", MessageBoxButtons.OK);

            }
        }



        public frm_ABMcurso()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            { this.grd_view.DataSource = Business.Logic.ABMcurso.listarCursosPorNombre(txtNombre.Text); }
            else
            {
                grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
            }
        }
    }
}
