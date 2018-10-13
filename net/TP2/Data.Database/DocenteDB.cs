using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Business.Entities;


namespace Data.Database
{
    public class DocenteDB
    {
        private static DocenteDB _instance;

        public static DocenteDB getInstance()
        {
            if (DocenteDB._instance == null)
            {
                DocenteDB._instance = new DocenteDB();
            }
            return DocenteDB._instance;
        }

        public int altaDocente(Business.Entities.Docente doc)
        {


            string nombre = doc.Nombre;
            string apellido = doc.Apellido;
            string dni = doc.Dni;
            string legajo = doc.Legajo;
            string telefono = doc.Telefono;
            string mail = doc.Email;
            int tipo = (int)doc.TipoUsuario;
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Persona(nombre,apellido,legajo,dni,telefono,mail)" +
                    " values('" + nombre + "','"
                    + apellido + "','" + legajo + "','" + dni + "','" + telefono + "','" + mail + "'); select SCOPE_IDENTITY()", Conexion.getInstance().Conection);
                int idPersona = Convert.ToInt32(cmd.ExecuteScalar());


                Conexion.getInstance().Disconnect();
                return idPersona;

            }
            catch (Exception e)
            {

                Conexion.getInstance().Disconnect();
                return -1;
            }

        }

        public bool modi(Docente doc)
        {
            try
            {
                Conexion.getInstance().Connect();
                string nombre = doc.Nombre;
                string apellido = doc.Apellido;
                string dni = doc.Dni;
                string legajo = doc.Legajo;
                string telefono = doc.Telefono;
                string mail = doc.Email;
                int tipo = (int)doc.TipoUsuario;
                string usuario = doc.NombreUsuario;
                string contra = doc.Contraseña;
                int idpersona = doc.IDPersona;
                SqlCommand cmd = new SqlCommand("update dbo.Persona set nombre='" + nombre + "',apellido='"
                    + apellido + "',dni='" + dni + "',telefono='" + telefono + "',mail='" + mail +
                    "' where  CONVERT(VARCHAR,legajo)='" + legajo + "'", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update dbo.Usuario set nombreusuario=' " + usuario + "',contraseña='" + contra +
                    "' where idPersona='" + idpersona + "'", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                Conexion.getInstance().Disconnect();
                return true;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return false;
            }
        }

        public bool borrarDocente(String legajo)
        {
            try
            {
                Conexion.getInstance().Connect();

                SqlCommand cmd = new SqlCommand("delete from dbo.Persona where CONVERT(VARCHAR,legajo)='" + legajo + "'", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();

                Conexion.getInstance().Disconnect();
                return true;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return false;
            }
        }

        public List<Business.Entities.Docente> listarDocentes()
        {
            try
            {
                Conexion.getInstance().Connect();
                List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();

                SqlCommand cmd = new SqlCommand("select * from dbo.Persona pe inner join dbo.Usuario us on pe.idPersona=us.idPersona where tipoUsuario=2", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    String nombre = reader.GetString(0);
                    String apellido = reader.GetString(1);
                    String legajo = reader.GetString(2);
                    String dni = reader.GetString(3);
                    String telefono = reader.GetString(4);
                    String mail = reader.GetString(5);
                    int id = (int)reader.GetValue(6);
                    String usu = reader.GetString(7);
                    String cont = reader.GetString(8);
                    Business.Entities.Docente doc = new Business.Entities.Docente(nombre, apellido, legajo, dni, mail, telefono);
                    doc.NombreUsuario = usu;
                    doc.Contraseña = cont;
                    doc.IDPersona = id;
                    docentes.Add(doc);
                }

                Conexion.getInstance().Disconnect();
                return docentes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public List<Business.Entities.Docente> listarDocentesPorLegajo(string legajo)
        {
            try
            {
                
                Conexion.getInstance().Connect();
                List<Business.Entities.Docente> docentes = new List<Business.Entities.Docente>();
                string lega = "%"+legajo+"%";
                SqlCommand cmd = new SqlCommand("select * from dbo.Persona pe inner join dbo.Usuario us on pe.idPersona=us.idPersona where tipoUsuario=2 and CONVERT(VARCHAR,legajo) like'"+lega+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    String nombre = reader.GetString(0);
                    String apellido = reader.GetString(1);
                    String leg = reader.GetString(2);
                    String dni = reader.GetString(3);
                    String telefono = reader.GetString(4);
                    String mail = reader.GetString(5);
                    int id = (int)reader.GetValue(6);
                    String usu = reader.GetString(7);
                    String cont = reader.GetString(8);
                    Business.Entities.Docente doc = new Business.Entities.Docente(nombre, apellido, leg, dni, mail, telefono);
                    doc.NombreUsuario = usu;
                    doc.Contraseña = cont;
                    doc.IDPersona = id;
                    docentes.Add(doc);
                }

                Conexion.getInstance().Disconnect();
                return docentes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
        public Business.Entities.Docente buscarDocente(string legajo)
        {
            try
            {
                Conexion.getInstance().Connect();
                Business.Entities.Docente doc;

                SqlCommand cmd = new SqlCommand("select * from dbo.Persona pe inner join dbo.Usuario us on pe.idPersona=us.idPersona where CONVERT(VARCHAR,legajo)='" + legajo + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();


                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                string dni = reader.GetString(3);
                string telefono = reader.GetString(4);
                string mail = reader.GetString(5);
                int id = (int)reader.GetValue(6);
                string usu = reader.GetString(7);
                string cont = reader.GetString(8);
                doc = new Business.Entities.Docente(nombre, apellido, legajo, dni, mail, telefono);
                doc.NombreUsuario = usu;
                doc.Contraseña = cont;
                doc.IDPersona = id;


                Conexion.getInstance().Disconnect();
                return doc;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public Business.Entities.Docente buscarDocentePorId(int id)
        {
            try
            {
                int idDoc = id;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Persona where idPersona='" + idDoc + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                string legajo = reader.GetString(2);
                string dni = reader.GetString(3);
                string telefono = reader.GetString(4);
                string mail = reader.GetString(5);
                int idPersona = (int)reader.GetValue(6);
                Business.Entities.Docente doc = new Business.Entities.Docente(nombre, apellido, legajo, dni, mail, telefono);
                doc.IDPersona = idPersona;
                Conexion.getInstance().Disconnect();
                return (doc);
            }
            catch(Exception)
            {
                return null;
            }

        }

    }
}
