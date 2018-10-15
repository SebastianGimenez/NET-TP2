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
            int id = ((Business.Entities.Persona)(us)).IDPersona;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into dbo.Usuario(NombreUsuario,Contraseña,TipoUsuario,idPersona)" +
                    " values('" + nombreUsuario + "','"
                    + pass + "'," +
                    tipo + "," + id +
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
        public int validarUsuarioContraseña(string NombreUsuario,string Contraseña)
        {
            Conexion.getInstance().Connect();
            string nombreUsuario = NombreUsuario;
            string pass = Contraseña;
            try
            {
                SqlCommand cmd = new SqlCommand("select IdUsuario from dbo.Usuario where CONVERT(VARCHAR,NombreUsuario)='"+nombreUsuario+"', CONVERT(VARCHAR,Contraseña)='"+pass+"'",Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int id = (int)reader.GetValue(0);
                Conexion.getInstance().Disconnect();
                return id;
            }
            catch (Exception e)
            {

                Conexion.getInstance().Disconnect();
                return -1;
            }

        }

    }
}
