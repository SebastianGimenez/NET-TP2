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
    public partial class frm_AltaPlan : frm_BaseMod
    {
        private bool saved;
        public frm_AltaPlan()
        {
            saved = false;
            InitializeComponent();

        }



        override
        protected void guardar()
        {
            Business.Entities.Plan plan = new Business.Entities.Plan(txtNombre.Text, txtDescripcion.Text);
            bool guardado=Business.Logic.ABMplan.altaPlan(plan,txtEspecialidad.Text);
            if (guardado) { MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK); }
            else { MessageBox.Show(this.Owner, "No se pudo encontrar ESpecialidad con ese nombre :(", "Sin Exito", MessageBoxButtons.OK); }
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
    }
}
