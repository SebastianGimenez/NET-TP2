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
    public partial class frm_ABMdocente : frm_BaseABM
    {
     
        override
        protected void alta()
        {
            new frm_AltaDocente().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
        }

        override
        protected void baja()
        {
            new frm_BajaDocente().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
        }



        public frm_ABMdocente()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMdocente.listarDocentes();
        }

    }
}
