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
        private bool ismodi;
        private Business.Entities.Curso curso;
        public frm_AltaCurso()
        {
            saved = false;
            ismodi = false;
            InitializeComponent();
            cmbComision.DataSource = Business.Logic.ABMcomision.listarComisiones();
            cmbMateria.DataSource = Business.Logic.ABMmateria.listarMaterias();
            cmbComision.ValueMember = "idComision";
            cmbComision.DisplayMember = "nombreComision";
            cmbMateria.ValueMember = "idMateria";
            cmbMateria.DisplayMember = "nombre";

        }
        public frm_AltaCurso(Business.Entities.Curso cur)
        {
            ismodi = true;
            saved = false;
            InitializeComponent();
            cmbComision.DataSource = Business.Logic.ABMcomision.listarComisiones();
            cmbMateria.DataSource = Business.Logic.ABMmateria.listarMaterias();
            cmbComision.ValueMember = "idComision";
            cmbComision.DisplayMember = "nombreComision";
            cmbComision.SelectedValue = Business.Logic.ABMcurso.buscarComisionCurso(cur.IdCurso);
            cmbMateria.ValueMember = "idMateria";
            cmbMateria.DisplayMember = "nombre";
            cmbMateria.SelectedValue = Business.Logic.ABMcurso.buscarMateriaCurso(cur.IdCurso);
            this.txtNombre.Text = cur.Nombre.Trim();
            this.txtCupo.Text = cur.Cupo.ToString();
            curso = cur;

        }




        override
        protected void guardar()
        {
            Business.Entities.Curso cur = new Business.Entities.Curso(txtNombre.Text.Trim(), int.Parse(txtCupo.Text));
            Business.Entities.Materia mat = new Business.Entities.Materia();
            mat.IdMateria = (int)cmbMateria.SelectedValue;
            cur.Materia = mat;
            Business.Entities.Comision com = new Business.Entities.Comision();
            com.IdComision = (int)cmbComision.SelectedValue;
            cur.Comision = com;
            if (ismodi)
            {
                cur.IdCurso = curso.IdCurso;
                bool guardado = Business.Logic.ABMcurso.modificarCurso(cur);
                if (guardado) { MessageBox.Show(this.Owner, "Modificado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo modificar el curso, es probable que ya exista otro curso con ese mismo nombre", "Sin Exito", MessageBoxButtons.OK); }
                this.saved = true;
                this.Close();

            }
            else
            {

                bool guardado=Business.Logic.ABMcurso.altaCurso(cur);
                if (guardado) { MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo guardar curso, es probable que ya exista otro curso con ese nombre", "Sin Exito", MessageBoxButtons.OK); }
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

        private void frm_AltaCurso_Load(object sender, EventArgs e)
        {
            if (ismodi)
            { this.Text = "Modificar"; }
        }
    }
    
}
