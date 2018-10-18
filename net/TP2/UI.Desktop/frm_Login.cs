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
            if (txt_nombreUsuario.Text.Length > 0 && txt_password.Text.Length > 0)
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
