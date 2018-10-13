using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;


namespace Data.Database
{
    public class EspecialidadDB
    {
        private static EspecialidadDB _instance;

        public static EspecialidadDB getInstance()
        {
            if (EspecialidadDB._instance == null)
            {
                EspecialidadDB._instance = new EspecialidadDB();
            }
            return EspecialidadDB._instance;
        }

        public bool altaEspecialidad(Business.Entities.Especialidad esp)
        {
            try
            {
                string nombre = esp.NombreEspecialidad;
                string descripcion = esp.Descripcion;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Especialidad(nombre,descripcion)" +
                    " values('" + nombre + "','"
                    + descripcion +  "')", Conexion.getInstance().Conection);
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

        public List<Business.Entities.Especialidad> listarEspecialidades()
        {
            try
            {
                List<Business.Entities.Especialidad> especialidades = new List<Especialidad>();
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from especialidad", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idEspecialidad = (int)reader.GetValue(0);
                    String nombre = reader.GetString(1);
                    String desc = reader.GetString(2);
                    Business.Entities.Especialidad esp = new Especialidad(nombre, desc);
                    esp.IdEspecialidad = idEspecialidad;
                    especialidades.Add(esp);
                }
                Conexion.getInstance().Disconnect();
                return especialidades;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public List<Business.Entities.Especialidad> listarEspecialidadesPorNombre(string nombre)
        {
            try
            {
                List<Business.Entities.Especialidad> especialidades = new List<Especialidad>();
                Conexion.getInstance().Connect();
                string nom = "%" + nombre + "%";
                SqlCommand cmd = new SqlCommand("select * from especialidad where CONVERT(VARCHAR,nombre) like '"+nom+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idEspecialidad = (int)reader.GetValue(0);
                    String nombr = reader.GetString(1);
                    String desc = reader.GetString(2);
                    Business.Entities.Especialidad esp = new Especialidad(nombr, desc);
                    esp.IdEspecialidad = idEspecialidad;
                    especialidades.Add(esp);
                }
                Conexion.getInstance().Disconnect();
                return especialidades;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public bool borrarEspecialidad(int id)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Especialidad where idEspecialidad='" + id + "'", Conexion.getInstance().Conection);
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

        public bool modificarEspecialidad(Especialidad esp)
        {
            try
            {
                Conexion.getInstance().Connect();
                string nombre =esp.NombreEspecialidad;
                string desc = esp.Descripcion;
                int idEspecialidad = esp.IdEspecialidad;
                SqlCommand cmd = new SqlCommand("update dbo.Especialidad set nombre='" + nombre + "',descripcion='"
                    + desc + "' where  idEspecialidad='" + idEspecialidad + "'", Conexion.getInstance().Conection);
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

    }
}
