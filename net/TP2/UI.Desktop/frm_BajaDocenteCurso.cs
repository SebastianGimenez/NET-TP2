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
    public partial class frm_BajaDocenteCurso : Form
    {
        private bool saved;
        private Business.Entities.Curso curso;
        private Business.Entities.Docente docente;
        public frm_BajaDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            InitializeComponent();
            this.txt_legajo.Text = doc.Legajo;
            this.txt_nombreCurso.Text = cur.Nombre;
            curso = cur;
            docente = doc;
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

        

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
      
                bool borrado = Business.Logic.ABMcurso.borrarDocenteCurso(docente, curso);
                if (borrado) { MessageBox.Show(this.Owner, "Dado de baja con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo dar de baja ", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();     
        }
    }
}
