using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web.ABMS.Alumnos
{
    public partial class BajaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
  
            bool borrado = Business.Logic.ABMalumno.borrarAlumno(this.txtLegajo.Text);
            if (borrado) { Response.Redirect("http://localhost:54354/ABMS/Alumnos/ABMAlumnos.aspx"); }
            else {
                Response.Write("<script type='text/javascript'> alert('legajo no encontrado') </script>"); }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:54354/ABMS/Alumnos/ABMAlumnos.aspx");
        }
    }
}