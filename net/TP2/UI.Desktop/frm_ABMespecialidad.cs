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
    public partial class frm_ABMespecialidad : frm_BaseABM
    {



        public frm_ABMespecialidad()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
        }

        override
         protected void alta()
        {
            new frm_AltaEspecialidad().ShowDialog();
            grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
        }

        override
        protected void baja()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                int idesp = (int)celdas["IdEspecialidad"].Value;


                new frm_BajaEspecialidad(idesp).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            }
            catch (NullReferenceException ex)
            {
                new frm_BajaEspecialidad().ShowDialog();
                grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();

            }
        }



        override
        protected void modi()
        {
            try
            {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                Business.Entities.Especialidad esp = new Business.Entities.Especialidad(
                      celdas["nombreEspecialidad"].Value.ToString(),
                      celdas["descripcion"].Value.ToString()
                      );
                int idEsp = (int)celdas["IdEspecialidad"].Value;
                esp.IdEspecialidad = idEsp;



                new frm_AltaEspecialidad(esp).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun docente", "Cuidado", MessageBoxButtons.OK);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                this.grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidadesPorNombre(txtNombre.Text);

            }
            else
            {
                grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "")
            {
                this.grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidadesPorNombre(txtNombre.Text);

            }
            else
            {
                grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            }
        }
    }

}

