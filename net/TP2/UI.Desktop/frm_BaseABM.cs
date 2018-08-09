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
    public partial class frm_BaseABM : Form
    {
        public frm_BaseABM()
        {
            InitializeComponent();
        }

        protected virtual void alta() { }

        protected virtual void baja() { }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            this.alta();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            this.baja();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
