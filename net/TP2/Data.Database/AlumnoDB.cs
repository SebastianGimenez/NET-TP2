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
    public class AlumnoDB
    {
        private static AlumnoDB _instance;

        public static AlumnoDB getInstance()
        {
            if (AlumnoDB._instance == null)
            {
                AlumnoDB._instance = new AlumnoDB();
            }
            return AlumnoDB._instance;
        }

    

        public int altaAlumno(Business.Entities.Alumno al)
        {
            
     
            string nombre = al.Nombre;
            string apellido = al.Apellido;
            string dni = al.Dni;
            string legajo = al.Legajo;
            string telefono = al.Telefono;
            string mail = al.Email;
            int tipo = (int)al.TipoUsuario;
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Persona(nombre,apellido,legajo,dni,telefono,mail)" +
                    " values('" + nombre + "','"
                    + apellido + "','" + legajo + "','" + dni + "','" + telefono + "','" + mail + "'); select SCOPE_IDENTITY()", Conexion.getInstance().Conection);
               int idPersona =Convert.ToInt32 (cmd.ExecuteScalar());
               
                
                Conexion.getInstance().Disconnect();
                return idPersona;
                
            }
            catch (Exception e)
            {
                
                Conexion.getInstance().Disconnect();
                return -1;
            }

        }

        public bool inscribirCurso(int idCurso, int idPer)
        {
            try
            {
                int idcurso = idCurso;
                int idpersona = idPer;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Alumno_inscripcion(idCurso,idAlumno)" +
                    " values('" + idcurso + "','"
                    + idpersona + "')", Conexion.getInstance().Conection);
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


        public bool modi(Alumno al)
        {
            try
            {
                Conexion.getInstance().Connect();
                string nombre = al.Nombre;
                string apellido = al.Apellido;
                string dni = al.Dni;
                string legajo = al.Legajo;
                string telefono = al.Telefono;
                string mail = al.Email;
                int tipo = (int)al.TipoUsuario;
                string usuario = al.NombreUsuario;
                string contra = al.Contraseña;
                int idpersona = al.IDPersona;
                SqlCommand cmd = new SqlCommand("update dbo.Persona set nombre='" + nombre + "',apellido='"
                    + apellido +  "',dni='" + dni + "',telefono='" + telefono + "',mail='" + mail +
                    "' where  CONVERT(VARCHAR,legajo)='" + legajo + "'", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update dbo.Usuario set nombreusuario=' " + usuario + "',contraseña='" + contra +
                    "' where idPersona='" + idpersona + "'", Conexion.getInstance().Conection);
                cmd.ExecuteNonQuery();
                Conexion.getInstance().Disconnect();
                return true;
            }
            catch(Exception e)
            {
                Conexion.getInstance().Disconnect();
                return false;
            }
            }

        public  bool borrarAlumno(String legajo)
        {
            try
            {
                Conexion.getInstance().Connect();
                
                SqlCommand cmd = new SqlCommand("delete from dbo.Persona where CONVERT(VARCHAR,legajo)='" + legajo + "'",Conexion.getInstance().Conection);
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

        public bool borrarCursoAlumno(int idCurso,int idAlumno)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Alumno_Inscripcion where idCurso='" + idCurso + "' and idAlumno='"+idAlumno+"'", Conexion.getInstance().Conection);
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

        public List<Business.Entities.Alumno> listarAlumnos()
        {
            try
            {
                Conexion.getInstance().Connect();
                List<Business.Entities.Alumno> alumnos = new List<Business.Entities.Alumno>();

                SqlCommand cmd = new SqlCommand("select * from dbo.Persona pe inner join dbo.Usuario us on pe.idPersona=us.idPersona where tipoUsuario=1", Conexion.getInstance().Conection);
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
                    Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, mail, telefono);
                    al.NombreUsuario = usu;
                    al.Contraseña = cont;
                    al.IDPersona =id;
                    alumnos.Add(al);
                }

                Conexion.getInstance().Disconnect();
                return alumnos;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }


        public List<int> listarCursosAlumno(int id)
        {
            try
            {
                int idAlumno = id;
                Conexion.getInstance().Connect();
                List<int> idCursos = new List<int>();
                SqlCommand cmd = new SqlCommand("select idCurso from dbo.Alumno_Inscripcion where idAlumno ='" + idAlumno + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idCurso = (int)reader.GetValue(0);
                    idCursos.Add(idCurso);
                }
                Conexion.getInstance().Disconnect();
                return idCursos;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

            public List<Business.Entities.Alumno> listarAlumnosPorLegajo(string lega)
        {
            try
            {
                Conexion.getInstance().Connect();
                List<Business.Entities.Alumno> alumnos = new List<Business.Entities.Alumno>();
                string legajo = "%"+lega+"%";
                SqlCommand cmd = new SqlCommand("select * from dbo.Persona pe inner join dbo.Usuario us on pe.idPersona=us.idPersona where tipoUsuario=1 AND CONVERT(VARCHAR,legajo) like '" + legajo+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    String nombre = reader.GetString(0);
                    String apellido = reader.GetString(1);
                    String legaj = reader.GetString(2);
                    String dni = reader.GetString(3);
                    String telefono = reader.GetString(4);
                    String mail = reader.GetString(5);
                    int id = (int)reader.GetValue(6);
                    String usu = reader.GetString(7);
                    String cont = reader.GetString(8);
                    Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legaj, dni, mail, telefono);
                    al.NombreUsuario = usu;
                    al.Contraseña = cont;
                    al.IDPersona = id;
                    alumnos.Add(al);
                }

                Conexion.getInstance().Disconnect();
                return alumnos;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
        public  Business.Entities.Alumno buscarAlumno(string legajo)
        {
            try
            {
                Conexion.getInstance().Connect();
                Business.Entities.Alumno al;

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
                    al= new Business.Entities.Alumno(nombre, apellido, legajo, dni, mail, telefono);
                    al.NombreUsuario = usu;
                    al.Contraseña = cont;
                    al.IDPersona = id;
                

                Conexion.getInstance().Disconnect();
                return al;
            }
            catch(Exception e) {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
        public Business.Entities.Alumno buscarAlumnoPorId(int id)
        {
            try
            {
                int idper = id;
                Conexion.getInstance().Connect();
                Business.Entities.Alumno al;

                SqlCommand cmd = new SqlCommand("select * from dbo.Persona where idPersona='" + idper + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string nombre = reader.GetString(0);
                string apellido = reader.GetString(1);
                string legajo = reader.GetString(2);
                string dni = reader.GetString(3);
                string telefono = reader.GetString(4);
                string mail = reader.GetString(5);
                int idp = (int)reader.GetValue(6);
                al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, mail, telefono);
                al.IDPersona = idp;
                Conexion.getInstance().Disconnect();
                return al;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
    }   


}
