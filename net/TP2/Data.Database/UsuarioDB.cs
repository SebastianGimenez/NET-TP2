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

        public Business.Entities.Persona login(string usuario,string password)
        {

            Conexion.getInstance().Connect();
         
            try
            {
                SqlCommand cmd = new SqlCommand("select * from dbo.Usuario us inner join dbo.Persona p on p.idPersona = us.idPersona where CONVERT(VARCHAR,us.NombreUsuario)='" + usuario + "' and CONVERT(VARCHAR,us.Contraseña)='" + password + "'",Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();

                Business.Entities.Persona usu;
                reader.Read();
                    int tipo = (int)Convert.ToInt32(reader.GetValue(3));
                    Business.Entities.tipoUsuario tipoUsuario = (Business.Entities.tipoUsuario)tipo;
                    String nombre = reader.GetString(5);
                    String apellido = reader.GetString(6);
                    String legajo = reader.GetString(7);
                    String dni = reader.GetString(8);
                    String telefono = reader.GetString(9);
                    String mail = reader.GetString(10);                 
                
                switch (tipoUsuario)
                {
                    case Business.Entities.tipoUsuario.ALUMNO:
                        usu = new Business.Entities.Alumno(nombre, apellido, legajo, dni, mail, telefono);
                        break;
                    case Business.Entities.tipoUsuario.DOCENTE:
                        usu = new Business.Entities.Docente(nombre, apellido, legajo, dni, mail, telefono);
                        break;
                    default:
                        usu = null;
                        break;
                }

                Conexion.getInstance().Disconnect();
                return usu;
            
            }
            catch (Exception e)
            {

                Conexion.getInstance().Disconnect();
                return null;
            }

        }

    }
}
