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
    public partial class frm_AltaMateria : frm_BaseMod
    {
        private bool saved;
        private bool ismodi;
        private Business.Entities.Materia materia;
        public frm_AltaMateria()
        {
            ismodi = false;
            saved = false;
            InitializeComponent();
            this.cmbPlanes.DataSource = Business.Logic.ABMplan.listarPlanes();
            this.cmbPlanes.ValueMember = "idPlan";
            this.cmbPlanes.DisplayMember = "nombrePlan";

        }
        public frm_AltaMateria(Business.Entities.Materia mate)
        {
            ismodi = true;
            saved = false;
            InitializeComponent();
            this.cmbPlanes.DataSource = Business.Logic.ABMplan.listarPlanes();
            this.cmbPlanes.ValueMember = "idPlan";
            this.cmbPlanes.DisplayMember = "nombrePlan";
            this.cmbPlanes.SelectedValue = Business.Logic.ABMmateria.buscarPlanDeMateria(mate.IdMateria);
            this.txtNombre.Text = mate.Nombre;
            this.txtDescripcion.Text = mate.Descripcion;
            this.txtHsSemanales.Text = mate.HorasSemanales.ToString();
            this.txtHsTotales.Text = mate.HorasTotales.ToString();
            materia = mate;

        }



        override
        protected void guardar()
        {
            Business.Entities.Materia mat = new Business.Entities.Materia(txtNombre.Text, txtDescripcion.Text, int.Parse(txtHsSemanales.Text), int.Parse(txtHsTotales.Text));
            Business.Entities.Plan plan = new Business.Entities.Plan();
            plan.IdPlan = (int)cmbPlanes.SelectedValue;
            mat.Plan = plan;
            if (ismodi)
            {
                mat.IdMateria = materia.IdMateria;
                bool guardado = Business.Logic.ABMmateria.modificarMateria(mat);
                if (guardado) { MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo modificar la materia, es probable que ya exista otra materia con ese nombre", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();

            }
            else
            {

                bool guardado = Business.Logic.ABMmateria.altaMateria(mat);
                if (guardado) { MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo guardar materia, es probable que ya exista otra materia con ese nombre", "Sin Exito", MessageBoxButtons.OK); }
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

        private void frm_AltaMateria_Load(object sender, EventArgs e)
        {
            if (ismodi)
            { this.Text = "Modificar"; }
        }
    }
}
