using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioDB
    {

        private static UsuarioDB _instance;

        public static UsuarioDB getInstance()
        {
            if (UsuarioDB._instance == null)
            {
                UsuarioDB._instance = new UsuarioDB();
            }
            return UsuarioDB._instance;
        }

        UsuarioDB()
        {
            //alumnos = new List<Business.Entities.Alumno>();
        }

        public bool altaUsuario(Business.Entities.Usuario us)
        {
            //this.alumnos.Add(al);
            Conexion.getInstance().Connect();
            string nombreUsuario = us.NombreUsuario;
            string pass = us.Contraseña;
            int tipo = (int)us.TipoUsuario;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into dbo.Usuario(NombreUsuario,Contraseña,TipoUsuario)" +
                    " values('" + nombreUsuario + "','"
                    + pass + "'," +
                    tipo +
                    ");",Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                Conexion.getInstance().Disconnect();
                return true;
            }catch(Exception e)
            {
               
                Conexion.getInstance().Disconnect();
                return false;
            }

        }
    }
}
