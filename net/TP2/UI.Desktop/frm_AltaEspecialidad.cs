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
    public partial class frm_AltaEspecialidad : frm_BaseMod
    {
        private bool saved;
        private bool ismodi;
        private Business.Entities.Especialidad especialidad;
        public frm_AltaEspecialidad()
        {
            saved = false;
            InitializeComponent();
            ismodi = false;

        }
        public frm_AltaEspecialidad(Business.Entities.Especialidad esp)
        {
            saved = false;
            InitializeComponent();
            ismodi = true;
            txtNombre.Text = esp.NombreEspecialidad.Trim();
            txtDescripcion.Text = esp.Descripcion;
            especialidad = esp;
        }



        override
        protected void guardar()
        {
            Business.Entities.Especialidad esp = new Business.Entities.Especialidad(this.txtNombre.Text.Trim(), this.txtDescripcion.Text);
            if (ismodi)
            {
                esp.IdEspecialidad = especialidad.IdEspecialidad;
                bool modi=Business.Logic.ABMespecialidad.modificarEspecialidad(esp);
                if (modi) { MessageBox.Show(this.Owner, "Modificado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo modificar, es probable que ya exista otra especialidad con ese nombre ", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();
            }
            else
            {
                bool guardado=Business.Logic.ABMespecialidad.altaEspecialidad(esp);
                this.saved = true;
                if (guardado)
                {
                    MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK);
                }
                else { { MessageBox.Show(this.Owner, "No se pudo guardar, es probable que ya exista otra especialidad con ese nombre", "Fracaso", MessageBoxButtons.OK); } }
                this.Close();
            }
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

        private void frm_AltaEspecialidad_Load(object sender, EventArgs e)
        {
            if (ismodi)
            {
                this.Text = "Modificacion";
            }
        }
    }
}
