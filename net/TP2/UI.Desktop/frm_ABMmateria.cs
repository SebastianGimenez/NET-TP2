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
    public partial class frm_ABMmateria : frm_BaseABM
    {
        override
          protected void alta()
        {
            new frm_AltaMateria().ShowDialog();
            grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
        }

        override
        protected void baja()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idMateria = (int)celdas["idMateria"].Value;
                new frm_BajaMateria(idMateria).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
            }
            catch (Exception e)
            {
                new frm_BajaMateria().ShowDialog();
                grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();

            }

        }

        override
        protected void modi()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idMateria = (int)celdas["idMateria"].Value;
                string nombre = celdas["nombre"].Value.ToString();
                string desc = celdas["descripcion"].Value.ToString();
                int hsSem = (int)celdas["horasSemanales"].Value;
                int hsTot = (int)celdas["horasTotales"].Value;
                Business.Entities.Materia materia = new Business.Entities.Materia(nombre, desc, hsSem, hsTot);
                materia.IdMateria = idMateria;
                new frm_AltaMateria(materia).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
            }
            catch (Exception e)
            {
                MessageBox.Show("No ha seleccionado ninguna materia", "Cuidado", MessageBoxButtons.OK);

            }
        }

        public frm_ABMmateria()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                this.grd_view.DataSource = Business.Logic.ABMmateria.listarMateriasPorNombre(txtNombre.Text);

            }
            else { grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias(); }
        }
    }
}
