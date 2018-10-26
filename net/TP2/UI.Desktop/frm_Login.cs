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
    public partial class frm_Login : Form
    {
        public bool IsLoggedIn { get; set; }
        public Business.Entities.Persona Persona { get; set; }
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Util.Validate.Username(txt_nombreUsuario.Text))
            {
                ErrorManager.SetError(txt_nombreUsuario, "Este campo no puede estar vacio o ser mayor a 12 caracteres");
            }
            else
            {
                //reset error
                ErrorManager.SetError(txt_nombreUsuario, "");
            }

            if (!Util.Validate.Password(txt_password.Text))
            {
                ErrorManager.SetError(txt_password, "Debe contener como minimo 5 caracteres, al menos una mayuscula y un número");
            }
            else
            {
                //reset error
                ErrorManager.SetError(txt_password, "");
            }

            if (Util.Validate.Username(txt_nombreUsuario.Text) && Util.Validate.Password(txt_password.Text))
            {
              
                Persona = Business.Logic.ABMUsuario.login(txt_nombreUsuario.Text, txt_password.Text);
                if (Persona != null)
                {
                    IsLoggedIn = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this.Owner, "Nombre de usuario y/o contraseña incorrectos");
                }
            }
           
        }

       
    }
}
