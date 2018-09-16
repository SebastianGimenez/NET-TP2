using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AltaAlumno : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_guardar_Click(object sender, EventArgs e)
    {

        bool isValiduser = Business.Logic.ABMUsuario.checkValidUser(txt_nombre_usuario.Text);
        if (isValiduser)
        {
            Business.Entities.Alumno al = new Business.Entities.Alumno(txt_nombre.Text, txt_apellido.Text, txt_legajo.Text,
             txt_dni.Text, txt_email.Text, txt_telefono.Text);
            int alID = Business.Logic.ABMalumno.altaAlumno(al);
            if(alID != -1)
            {
                al.IDPersona = alID;
                Business.Logic.ABMUsuario.altaUsuario(txt_nombre_usuario.Text, txt_passw.Text, al);
            }
        }
       
    }
}