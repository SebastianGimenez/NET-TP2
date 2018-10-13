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
    public class MateriaDB
    {
        private static MateriaDB _instance;
        public static MateriaDB getInstance()
        {
            if (MateriaDB._instance == null)
            {
                MateriaDB._instance = new MateriaDB();
            }
            return MateriaDB._instance;
        }

        public bool altaMateria(Business.Entities.Materia materia)
        {
            try
            {
                string nombre = materia.Nombre;
                string descripcion = materia.Descripcion;
                int idPlan = materia.Plan.IdPlan;
                int hsSem = materia.HorasSemanales;
                int hsAn = materia.HorasTotales;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Materia(nombre,descripcion,hsSemanales,hsTotales,idPlan) " +
                    "values('" + nombre + "','" + descripcion + "','" + hsSem + "','" + hsAn + "','" + idPlan + "')", Conexion.getInstance().Conection);
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
        public List<Business.Entities.Materia> listarMaterias()
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Materia", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Business.Entities.Materia> materias = new List<Materia>();
                while (reader.Read())
                {
                    int idMateria = (int)reader.GetValue(0);
                    string nombre = reader.GetString(1);
                    string desc = reader.GetString(2);
                    int hsSem = (int)reader.GetValue(3);
                    int hsTot = (int)reader.GetValue(4);
                    int idPlan = (int)reader.GetValue(5);
                    Business.Entities.Materia mat = new Materia(nombre, desc, hsSem, hsTot);
                    mat.IdMateria = idMateria;
                    //Business.Entities.Plan plan = new Plan();
                    //plan.IdPlan = idPlan;
                    //mat.Plan = plan;
                    materias.Add(mat);          
                }
                Conexion.getInstance().Disconnect();
                return materias;
            }
            catch(Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;

            }
        }


        public List<Business.Entities.Materia> listarMateriasPorNombre(string nombre)
        {
            try
            {
                string nomb = "%"+nombre+"%";
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Materia where CONVERT(VARCHAR,nombre) like'"+nomb+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Business.Entities.Materia> materias = new List<Materia>();
                while (reader.Read())
                {
                    int idMateria = (int)reader.GetValue(0);
                    string nom = reader.GetString(1);
                    string desc = reader.GetString(2);
                    int hsSem = (int)reader.GetValue(3);
                    int hsTot = (int)reader.GetValue(4);
                    int idPlan = (int)reader.GetValue(5);
                    Business.Entities.Materia mat = new Materia(nom, desc, hsSem, hsTot);
                    mat.IdMateria = idMateria;
                    //Business.Entities.Plan plan = new Plan();
                    //plan.IdPlan = idPlan;
                    //mat.Plan = plan;
                    materias.Add(mat);
                }
                Conexion.getInstance().Disconnect();
                return materias;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;

            }
        }
        public bool borrarMateria(int idMateria)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Materia where idMateria='" + idMateria + "'", Conexion.getInstance().Conection);
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

        public int buscarPlanDeMateria(int idMateria)
        {
            try
            {
                int id = idMateria;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idPlan from dbo.Materia where idMateria='" + id + "'", Conexion.getInstance().Conection);
                int idEsp = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.getInstance().Disconnect();
                return idEsp;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return -1;
            }

        }


        public bool modificarMateria(Materia materia)
        {
            try
            {
                
                string nombre = materia.Nombre;
                int idplan = materia.Plan.IdPlan;
                int hssem = materia.HorasSemanales;
                int hst = materia.HorasTotales;
                string desc = materia.Descripcion;
                int idMat = materia.IdMateria;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.Materia set nombre='" + nombre + "',idPlan='"
                    + idplan + "',hsSemanales='"
                    + hssem + "',hsTotales='"
                    + hst + "',descripcion='"
                    + desc + "' where  idMateria='" + idMat+ "'", Conexion.getInstance().Conection);
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

        public Business.Entities.Materia buscarMateriaPorId(int id)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Materia where idMateria ='" + id + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int idMateria = (int)reader.GetValue(0);
                string nom = reader.GetString(1);
                string desc = reader.GetString(2);
                int hsSem = (int)reader.GetValue(3);
                int hsTot = (int)reader.GetValue(4);
                int idPlan = (int)reader.GetValue(5);
                Business.Entities.Materia mat = new Materia(nom, desc, hsSem, hsTot);
                mat.IdMateria = idMateria;
                Conexion.getInstance().Disconnect();
                return mat;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;

            }

        }
    }
}
