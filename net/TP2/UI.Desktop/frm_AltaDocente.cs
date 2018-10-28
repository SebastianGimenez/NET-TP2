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
    public partial class frm_AltaDocente : frm_BaseMod
    {
        private bool saved;
        private bool ismodi;
        private Business.Entities.Docente docente;
        public frm_AltaDocente()
        {
            saved = false;
            ismodi = false;
            InitializeComponent();

        }

        public frm_AltaDocente(Business.Entities.Docente doc)
        {
            saved = false;
            InitializeComponent();
            ismodi = true;
            txtUsuario.Text = doc.NombreUsuario.Trim();
            txtContraseña.Text = doc.Contraseña.Trim();
            txt_apellido.Text = doc.Apellido;
            txt_dni.Text = doc.Dni.Trim();
            txt_legajo.Text = doc.Legajo.Trim();
            txt_legajo.Enabled = false;
            txt_nombre.Text = doc.Nombre;
            txt_telefono.Text = doc.Telefono;
            txt_email.Text = doc.Email;
            docente = doc;
        }



        override protected void guardar()
        {
            Boolean camposValidos = true;
            if (!Util.Validate.Password(txtContraseña.Text))
            {
                ErrorManager.SetError(txtContraseña, "Debe contener como minimo 5 caracteres, al menos una mayuscula y un número");
                camposValidos = false;
            }
            else
            {
                //reset error
                ErrorManager.SetError(txtContraseña, "");
            }

            if (!Util.Validate.Username(txtUsuario.Text))
            {
                ErrorManager.SetError(txtUsuario, "Este campo no puede estar vacio o ser mayor a 12 caracteres");
                camposValidos = false;
            }
            else
            {
                //reset error
                ErrorManager.SetError(txtUsuario, "");
            }

            if (!Util.Validate.DNI(txt_dni.Text))
            {
                ErrorManager.SetError(txt_dni, "dni invalido");
                camposValidos = false;
            }
            else
            {
                //reset error
                ErrorManager.SetError(txt_dni, "");
            }

            if (!Util.Validate.Email(txt_email.Text))
            {
                ErrorManager.SetError(txt_email, "Proporcione un email valido");
                camposValidos = false;
            }
            else
            {
                //reset error
                ErrorManager.SetError(txt_email, "");
            }

            if (!Util.Validate.Phone(txt_telefono.Text))
            {
                ErrorManager.SetError(txt_telefono, "Proporcione un telefono valido(10 digitos) ");
                camposValidos = false;
            }
            else
            {
                //reset error
                ErrorManager.SetError(txt_telefono, "");
            }

            if (!Util.Validate.Text(txt_nombre.Text))
            {
                ErrorManager.SetError(txt_nombre, "El nombre debe contener solo letras");
                camposValidos = false;
            }
            else
            {
                ErrorManager.SetError(txt_nombre, "");
            }

            if (!Util.Validate.Text(txt_apellido.Text))
            {
                ErrorManager.SetError(txt_apellido, "El apellido debe contener solo letras");
                camposValidos = false;
            }
            else
            {
                ErrorManager.SetError(txt_apellido, "");
            }

            if (!Util.Validate.Legajo(txt_legajo.Text))
            {
                ErrorManager.SetError(txt_legajo, "El legajo no debe estar vacio");
                camposValidos = false;
            }
            else
            {
                ErrorManager.SetError(txt_legajo, "");
            }

            if (!camposValidos) return;

            Business.Entities.Docente doc = new Business.Entities.Docente(txt_nombre.Text, txt_apellido.Text, txt_legajo.Text.Trim(), txt_dni.Text.Trim(), txt_email.Text, txt_telefono.Text);
            if (ismodi)
            {
                doc.IDPersona = docente.IDPersona;
                doc.NombreUsuario = txtUsuario.Text.Trim();
                doc.Contraseña = txtContraseña.Text.Trim();
                bool modi = Business.Logic.ABMdocente.modi(doc);
                if (modi) {
                    MessageBox.Show(this.Owner, "modificado con exito", "Exito", MessageBoxButtons.OK);
                    this.saved = true;
                    this.Close();
                }
                else { MessageBox.Show(this.Owner, "No se pudo modificar, es probable que ya exista otro docente con ese usuario ", "Sin Exito", MessageBoxButtons.OK); }

            }
            else
            {
                bool valido = Business.Logic.ABMUsuario.validarUsuario(txtUsuario.Text.Trim());
                if (valido)
                {
                    try
                    {
                        int id = Business.Logic.ABMdocente.altaDocente(doc);
                        if (id != -1)
                        {
                            doc.IDPersona = id;
                            bool val = Business.Logic.ABMUsuario.altaUsuario(txtUsuario.Text.Trim(), txtContraseña.Text, doc);
                            this.saved = true;
                            MessageBox.Show(this.Owner, "Guardado con exito", "Exito", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(this.Owner, "no se pudo guardar, es probable que exista otro docente con ese legajo", "Sin Exito", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this.Owner, "No se pudo guardar", "Sin Exito", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this.Owner, "no se pudo guardar, es probable que exista otro docente con ese usuario", "Sin Exito", MessageBoxButtons.OK);
                }
            }
        }
          

        override protected void onclosing(object sender, FormClosingEventArgs e)
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

        private void frm_AltaDocente_Load(object sender, EventArgs e)
        {
            if (ismodi)
            { this.Text = "Modificar"; }
        }
    }
}
