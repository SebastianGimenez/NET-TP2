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
    public partial class frm_AltaCurso : frm_BaseMod
    {
       
        private bool saved;
        public frm_AltaCurso()
        {
            saved = false;
            InitializeComponent();

        }


        Business.Entities.Curso cur = new Business.Entities.Curso();

        override
        protected void guardar()
        {
            this.saved = (txtNombre.Text.Length > 0 || txtCupo.Text.Length > 0);
            cur.Nombre = txtNombre.Text;
            cur.Cupo = int.Parse(txtCupo.Text);
            bool valCom = Business.Logic.ABMcurso.validarComision(cur,txtComision.Text);
            if (!valCom) { MessageBox.Show(this.Owner, "Comision no encontrada", "Sin Exito", MessageBoxButtons.OK); }

            bool valMat = Business.Logic.ABMcurso.validarMateria(cur, txtMateria.Text);
            if (!valMat) { MessageBox.Show(this.Owner, "Materia no encontrada", "Sin Exito", MessageBoxButtons.OK); }

            if(valCom && valMat) { MessageBox.Show(this.Owner, "Materia registrada", "Exito", MessageBoxButtons.OK);
                Business.Logic.ABMcurso.altaCurso(cur);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_AgregaDocente(cur).ShowDialog();
        }
    }
    
}
