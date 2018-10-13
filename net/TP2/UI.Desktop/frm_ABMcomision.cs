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
    public partial class frm_ABMcomision : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaComision().ShowDialog();
            grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
        }

        override
        protected void baja()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idcom = (int)celdas["IdComision"].Value;
                new frm_BajaComision(idcom).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
            }
            catch (NullReferenceException ex)
            {
                new frm_BajaComision().ShowDialog();
                grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();

            }
        }
        override
        protected void modi()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                Business.Entities.Comision com = new Business.Entities.Comision(
                      celdas["nombreComision"].Value.ToString(),
                      celdas["aula"].Value.ToString()
                      );
                int id = (int)celdas["IdComision"].Value;
                com.IdComision = id;
                new frm_AltaComision(com).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun docente", "Cuidado", MessageBoxButtons.OK);
            }
        }


        public frm_ABMcomision()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                this.grd_view.DataSource = Business.Logic.ABMcomision.listarComisionesPorNombre(txtNombre.Text);
            }
            else {
                grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
            }
        }
    }
}
