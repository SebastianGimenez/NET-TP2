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
        private bool ismodi;
        private Business.Entities.Plan plan;
        public frm_AltaPlan()
        {
            saved = false;
            InitializeComponent();
            this.cmbEspecialidades.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            this.cmbEspecialidades.ValueMember = "idEspecialidad";
            this.cmbEspecialidades.DisplayMember = "nombreEspecialidad";
        }

        public frm_AltaPlan(Business.Entities.Plan pl)
        {
            saved = false;
            InitializeComponent();
            this.cmbEspecialidades.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
            this.cmbEspecialidades.ValueMember = "idEspecialidad";
            this.cmbEspecialidades.DisplayMember = "nombreEspecialidad";
            ismodi = true;
            txtNombre.Text = pl.NombrePlan;
            txtDescripcion.Text= pl.DescripcionPlan;
            cmbEspecialidades.SelectedValue = Business.Logic.ABMplan.buscarEspDelPlan(pl.IdPlan);
            plan = pl;
        }


        override
        protected void guardar()
        {
            Business.Entities.Plan pl = new Business.Entities.Plan(txtNombre.Text, txtDescripcion.Text);
            Business.Entities.Especialidad esp = new Business.Entities.Especialidad();
            esp.IdEspecialidad = (int)this.cmbEspecialidades.SelectedValue;
            pl.Especialidad = esp;
            if (ismodi)
            {
                pl.IdPlan = plan.IdPlan;
                bool modi=Business.Logic.ABMplan.modificarPlan(pl);
                if (modi) { MessageBox.Show(this.Owner, "modificado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo modificar ", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();
            }
            else
            {

                bool guardado = Business.Logic.ABMplan.altaPlan(pl);
                if (guardado) { MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo guardar", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
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

        private void frm_AltaPlan_Load(object sender, EventArgs e)
        {
            if (ismodi)
            {
                this.Text = "Modificacion";
            }
        }
    }
}
