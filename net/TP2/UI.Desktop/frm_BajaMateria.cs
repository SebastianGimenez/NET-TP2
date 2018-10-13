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
    public partial class frm_BajaMateria : frm_BaseMod
    {
        private bool saved;
        public frm_BajaMateria()
        {
            saved = false;
            InitializeComponent();

        }
        public frm_BajaMateria(int idMateria)
        {
            saved = false;
            InitializeComponent();
            this.txtNombre.Enabled = false;
            this.cmbIdMateria.DataSource = Business.Logic.ABMmateria.listarMaterias();
            this.cmbIdMateria.DisplayMember = "idMateria";
            this.cmbIdMateria.ValueMember = "idMateria";
            this.cmbIdMateria.SelectedValue = idMateria;
        }



        override
        protected void guardar()
        {
            bool borrado = Business.Logic.ABMmateria.borrarMateria((int)cmbIdMateria.SelectedValue);
            if (borrado) { MessageBox.Show(this.Owner, "Borrado con exito", "Exito", MessageBoxButtons.OK); }
            else { MessageBox.Show(this.Owner, "No se pudo encontrar :(", "Sin Exito", MessageBoxButtons.OK); }
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

        private void cmbIdMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            Business.Entities.Materia mat = (Business.Entities.Materia)cmbIdMateria.SelectedItem;
            txtNombre.Text = mat.Nombre;
        }
    }
}
