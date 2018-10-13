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
    public partial class frm_ABMdocente : frm_BaseABM
    {
        public frm_ABMdocente()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
        }

        override
        protected void alta()
        {
            new frm_AltaDocente().ShowDialog();
            grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
        }

        override
        protected void baja()
        { 
             try
             {
                DataGridViewRow row = grd_view.CurrentRow;
                DataGridViewCellCollection celdas = row.Cells;
                string legajo = celdas["legajo"].Value.ToString();
                new frm_BajaDocente(legajo).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
             }
             catch (NullReferenceException ex)
             {
                new frm_BajaDocente().ShowDialog();
                grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
             }
        }


        override
        protected void modi()
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
                doc.NombreUsuario = celdas["nombreusuario"].Value.ToString();
                doc.Contraseña = celdas["contraseña"].Value.ToString();
                int idpersona = (int)celdas["IDPersona"].Value;
                doc.IDPersona = idpersona;



                new frm_AltaDocente(doc).ShowDialog();
                grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No ha seleccionado ningun docente","Cuidado", MessageBoxButtons.OK);
            }
        }

       

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtLegajo.Text != "")
            {
                this.grd_view.DataSource = Business.Logic.ABMdocente.listarDocentesPorLegajo(this.txtLegajo.Text);
            }
            else
            {
                grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();

            }
        }
    }
}
