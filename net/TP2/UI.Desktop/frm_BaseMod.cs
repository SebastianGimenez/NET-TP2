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
    public partial class frm_BaseMod : Form
    {
        protected virtual void guardar() { }
        protected virtual void cancelar() { }
        protected virtual void onclosing(object sender, FormClosingEventArgs e) { }

        public frm_BaseMod()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.guardar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.cancelar();
        }

        private void frm_BaseMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.onclosing(sender,e);
        }
    }
}
