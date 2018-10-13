using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frm_bajaAlumno : UI.Desktop.frm_BaseMod
    {
        private bool saved;
        public frm_bajaAlumno()
        {
            saved = false;
            InitializeComponent();

        }
        public frm_bajaAlumno(string legajo,string nombre)
        {
            saved = false;
            InitializeComponent();
            this.txtNombre.Text = nombre;
            this.txtNombre.Enabled = false;
            this.cmb_Legajo.DataSource = Business.Logic.ABMalumno.listarAlumnos();
            this.cmb_Legajo.DisplayMember = "Legajo";
            this.cmb_Legajo.ValueMember = "Legajo";
            this.cmb_Legajo.SelectedValue = legajo;
        }


        override
        protected void guardar()
        {
            bool borrado = Business.Logic.ABMalumno.borrarAlumno(this.cmb_Legajo.SelectedValue.ToString());
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Legajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Business.Entities.Alumno al =(Business.Entities.Alumno)cmb_Legajo.SelectedItem;
            this.txtNombre.Text = al.Apellido + ", " + al.Nombre;
        }
    }
}
