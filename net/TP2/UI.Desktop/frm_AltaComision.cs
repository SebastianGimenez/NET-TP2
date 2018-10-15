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
    public partial class frm_AltaComision : frm_BaseMod
    {
        private bool saved;
        private bool ismodi;
        private Business.Entities.Comision comision;
        public frm_AltaComision()
        {
            saved = false;
            InitializeComponent();
            ismodi = false;

        }
        public frm_AltaComision(Business.Entities.Comision com)
        {
            saved = false;
            InitializeComponent();
            ismodi = true;
            txtNombre.Text = com.NombreComision;
            txtAula.Text = com.Aula;
            comision = com;
        }


        override
               protected void guardar()
        {
            Business.Entities.Comision com = new Business.Entities.Comision(this.txtNombre.Text, this.txtAula.Text);
            if (ismodi)
            {
                com.IdComision = comision.IdComision;
                bool modi=Business.Logic.ABMcomision.modificarComision(com);
                if (modi) { MessageBox.Show(this.Owner, "modificado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo modificar, es probable que ya exista otra comision con ese nombre ", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();
            }
            else
            {
                bool agregado=Business.Logic.ABMcomision.altaComision(com);
                if (agregado) { MessageBox.Show(this.Owner, "Agregado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo agregar, es probable que ya exista otra comision con el mismo nombre ", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();
            }
        }

        override
        protected void onclosing(object sender, FormClosingEventArgs e)
        {
            this.saved = (txtNombre.Text.Length > 0 || txtAula.Text.Length > 0);
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

        private void frm_AltaComision_Load(object sender, EventArgs e)
        {
            if (ismodi)
            { this.Text = "Modificar"; }
        }
    }
}
