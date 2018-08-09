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
    public partial class frm_ABMplan : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaPlan().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
        }

        override
        protected void baja()
        {
            new frm_BajaPlan().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
        }



        public frm_ABMplan()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMplan.listarPlanes();
        }
    }
}
