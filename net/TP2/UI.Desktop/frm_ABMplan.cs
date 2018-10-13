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
    public partial class frm_ABMplan : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaPlan().ShowDialog();
            grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
        }

        override
        protected void baja()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idPlan = (int)celdas["idPlan"].Value;
                new frm_BajaPlan(idPlan).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
            }
            catch (NullReferenceException ex)
            {

                new frm_BajaPlan().ShowDialog();
                grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
            }
        }



        public frm_ABMplan()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
        }

        override
        protected void modi()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                Business.Entities.Plan pl = new Business.Entities.Plan(celdas["nombrePlan"].Value.ToString(),
                      celdas["descripcionPlan"].Value.ToString()
                      );
                pl.IdPlan = (int)celdas["idPlan"].Value;
                new frm_AltaPlan(pl).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun plan", "Cuidado", MessageBoxButtons.OK);
            }
        }

      

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                this.grd_view.DataSource = Business.Logic.ABMplan.listarPlanesPorNombre(txtNombre.Text);
            }
            else
            {
                grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
            }
        }
    }
}
