using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frm_AltaAlumno : UI.Desktop.frm_BaseMod
    {
        private bool saved;
        private bool ismodi;
        private Business.Entities.Alumno alumno;
        public frm_AltaAlumno()
        {
            saved = false;
            ismodi = false;
            InitializeComponent();
            
        }


        public frm_AltaAlumno(Business.Entities.Alumno al)
        {
            ismodi = true;
            InitializeComponent();
            txtUsuario.Text = al.NombreUsuario.Trim();
            txtContraseña.Text = al.Contraseña.Trim();
            txt_apellido.Text = al.Apellido;
            txt_dni.Text = al.Dni.Trim();
            txt_legajo.Text = al.Legajo.Trim();
            txt_legajo.Enabled = false;
            txt_nombre.Text = al.Nombre;
            txt_telefono.Text = al.Telefono;
            txt_email.Text = al.Email;
            alumno = al;
        }


        override 
        protected void guardar()
        {
           
            Business.Entities.Alumno al = new Business.Entities.Alumno(txt_nombre.Text,txt_apellido.Text.Trim(), txt_legajo.Text.Trim(), txt_dni.Text, txt_email.Text, txt_telefono.Text);
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
                ErrorManager.SetError(txt_telefono, "Proporcione un telefono valido");
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

            if (!camposValidos) return;


         
            if (ismodi)
            {
                al.IDPersona = alumno.IDPersona;
                al.NombreUsuario = txtUsuario.Text.Trim(); 
                al.Contraseña = txtContraseña.Text;
                bool modi = Business.Logic.ABMalumno.modi(al);
                if (modi) { MessageBox.Show(this.Owner, "modificado con exito", "Exito", MessageBoxButtons.OK); }
                else { MessageBox.Show(this.Owner, "No se pudo modificar, es probable que ya exista otro usuario con ese nombre", "Sin Exito", MessageBoxButtons.OK); }
                this.Close();
            }
            else
            {
                bool valido = Business.Logic.ABMUsuario.validarUsuario(txtUsuario.Text.Trim());
                if (valido)
                {
                    try
                    {                      
                        int id = Business.Logic.ABMalumno.altaAlumno(al);
                        if (id != -1)
                        {
                            al.IDPersona = id;
                            Business.Logic.ABMUsuario.altaUsuario(txtUsuario.Text.Trim(), txtContraseña.Text.Trim(), al);
                            MessageBox.Show(this.Owner, "Cargado con exito", "Exito", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(this.Owner, "No se pudo cargar, es probable que ya exista un alumno con ese legajo", "Sin Exito", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this.Owner, "No se pudo cargar, es probable que ya exista un alumno con ese legajo", "Sin Exito", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this.Owner, "No se pudo cargar, es probable que ya exista un alumno con ese usuario", "Sin Exito", MessageBoxButtons.OK);
                }
            }
            this.saved = true;
            
        }

        override
        protected void onclosing(object sender, FormClosingEventArgs e) {
            this.saved = (txt_apellido.Text.Length > 0 || txt_nombre.Text.Length > 0);
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
            //agregar validacion antes de cancelar
            this.Close();
        }

        private void frm_AltaAlumno_Load(object sender, EventArgs e)
        {
            if (ismodi)
            {
                this.Text = "Modificar";
            }
        }
    }
}
