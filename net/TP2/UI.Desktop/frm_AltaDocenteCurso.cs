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
    public partial class frm_AltaDocenteCurso : Form
    {
        private bool saved;
        private Business.Entities.Curso curso;
        public frm_AltaDocenteCurso(Business.Entities.Curso cur)
        {
            InitializeComponent();
            this.txt_NombreCurso.Text = cur.Nombre;
            this.txt_NombreCurso.Enabled = false;
            this.cmb_Legajos.DataSource = Business.Logic.ABMdocente.listarDocentes();
            this.cmb_Legajos.DisplayMember = "legajo";
            this.cmb_Legajos.ValueMember = "iDPersona";
            curso = cur;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Business.Entities.Docente doc = (Business.Entities.Docente)this.cmb_Legajos.SelectedItem;
            bool agregado = Business.Logic.ABMcurso.agregarDocenteCurso(doc, curso);
            if (agregado)
            { MessageBox.Show(this.Owner, "Agregado con exito", "Exito", MessageBoxButtons.OK); }
            else { MessageBox.Show(this.Owner, "No se pudo agregar ", "Sin Exito", MessageBoxButtons.OK); }
            this.Close();

        }

      
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
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

        private void frm_AltaDocenteCurso_Load(object sender, EventArgs e)
        {
           
        }
    }
}
