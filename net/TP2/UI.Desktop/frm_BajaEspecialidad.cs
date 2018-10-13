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
    public partial class frm_BajaEspecialidad : frm_BaseMod
    {
        private bool saved;
        public frm_BajaEspecialidad()
        {
            saved = false;
            InitializeComponent();
       

        }
        public frm_BajaEspecialidad(int id)
        {
            saved = false;
            InitializeComponent();
            this.txtNombre.Enabled = false;
            this.cmb_IdEsp.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            this.cmb_IdEsp.DisplayMember = "idEspecialidad";
            this.cmb_IdEsp.ValueMember = "idEspecialidad";
            this.cmb_IdEsp.SelectedValue = id;
        }


        override
        protected void guardar()
        {
            bool borrado=Business.Logic.ABMespecialidad.borrarEspecialidad((int)this.cmb_IdEsp.SelectedValue);
            if (borrado) { MessageBox.Show(this.Owner, "Borrado con exito", "Exito", MessageBoxButtons.OK); }
            else  { MessageBox.Show(this.Owner, "No se pudo encontrar :(", "Sin Exito", MessageBoxButtons.OK); } 
            this.saved = true;
            this.Close();
        }

        override
        protected void onclosing(object sender, FormClosingEventArgs e)
        {
            if (!this.saved)
            {
                DialogResult res = MessageBox.Show(this.Owner, "Hay cambios sin guardar desea salir de todos modos?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (res)
                {
                    case DialogResult.No:
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        override
         protected void cancelar()
        {
            if (!this.saved)
            {
                DialogResult res = MessageBox.Show(this.Owner, "Desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (res)
                {
                    case DialogResult.No:
                    case DialogResult.Yes:
                        this.Close();
                        break;
                }
            }
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_IdEsp_SelectedValueChanged(object sender, EventArgs e)
        {
            Business.Entities.Especialidad esp = (Business.Entities.Especialidad)cmb_IdEsp.SelectedItem;
            this.txtNombre.Text = esp.NombreEspecialidad;
        }
    }
}
