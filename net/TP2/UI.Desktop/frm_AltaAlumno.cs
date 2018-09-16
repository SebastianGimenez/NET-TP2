﻿using System;
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
            InitializeComponent();
            ismodi = true;
            txtUsuario.Text = al.NombreUsuario;
            txtContraseña.Text = al.Contraseña;
            txt_apellido.Text = al.Apellido;
            txt_dni.Text = al.Dni;
            txt_legajo.Text = al.Legajo;
            txt_legajo.Enabled = false;
            txt_nombre.Text = al.Nombre;
            txt_telefono.Text = al.Telefono;
            txt_email.Text = al.Email;
            alumno = al;
        }



        override 
        protected void guardar()
        {
           
            Business.Entities.Alumno al = new Business.Entities.Alumno(txt_nombre.Text,txt_apellido.Text, txt_legajo.Text, txt_dni.Text, txt_email.Text, txt_telefono.Text);
            if (ismodi)
            {
                al.IDPersona = alumno.IDPersona;
                al.NombreUsuario = txtUsuario.Text;
                al.Contraseña = txtContraseña.Text;
                Business.Logic.ABMalumno.modi(al);
                this.Close();
            }
            else
            {
                int id = Business.Logic.ABMalumno.altaAlumno(al);
                if (id != -1)
                {
                    al.IDPersona = id;
                    bool valid = Business.Logic.ABMUsuario.checkUserNameAndPassword(txtUsuario.Text, txtContraseña.Text);
                    if (valid)
                    {
                        Business.Logic.ABMUsuario.altaUsuario(txtUsuario.Text, txtContraseña.Text, al);
                        this.Close();
                    }
                    else
                    {
                        ErrorManager.showError(this.Owner, "No se pudo cargar el usuario", "1");
                    }
                }
                else
                {
                    ErrorManager.showError(this.Owner, "No se pudo cargar el alumno", "0");
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
       
    }
}
