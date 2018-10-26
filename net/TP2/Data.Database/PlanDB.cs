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
    public class PlanDB
    {
        private static PlanDB _instance;

        public static PlanDB getInstance()
        {
            if (PlanDB._instance == null)
            {
                PlanDB._instance = new PlanDB();
            }
            return PlanDB._instance;
        }

        public bool altaPlan(Business.Entities.Plan plan)
        {
            try
            {
                string nombre = plan.NombrePlan;
                string descripcion = plan.DescripcionPlan;
                int id = (int)plan.Especialidad.IdEspecialidad;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into Planes(nombre,descripcion,idEsp)" +
                    " values('" + nombre + "','"
                    + descripcion + "','" + id + "')", Conexion.getInstance().Conection);
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
        public List<Business.Entities.Plan> listarPlanes()
        {
            try
            {
                List<Business.Entities.Plan> planes = new List<Plan>();
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Planes", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idPlan = (int)reader.GetValue(0);
                    String nombre = reader.GetString(1);
                    String desc = reader.GetString(2);
                    
                    Business.Entities.Plan plan = new Plan(nombre, desc);
                    if (reader["idEsp"] != DBNull.Value)
                    {
                        int IdEspecialidad = (int)reader.GetValue(3);
                        Business.Entities.Especialidad esp = EspecialidadDB.getInstance().buscarEspecialidadPorId(IdEspecialidad);
                        plan.Especialidad = esp;

                    }
                    
                    plan.IdPlan = idPlan;
                    planes.Add(plan);
                }
                Conexion.getInstance().Disconnect();
                return planes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }

        public List<Business.Entities.Plan> listarPlanesPorNombre(string nombre)
        {
            try
            {
                List<Business.Entities.Plan> planes = new List<Plan>();
                string nom = "%"+nombre+"%";
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Planes where CONVERT(VARCHAR,nombre) like'"+nom+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idPlan = (int)reader.GetValue(0);
                    String nombr = reader.GetString(1);
                    String desc = reader.GetString(2);
                    Business.Entities.Plan plan = new Plan(nombr, desc);
                    if (reader["idEsp"] != DBNull.Value)
                    {
                        int IdEspecialidad = (int)reader.GetValue(3);
                        Business.Entities.Especialidad esp = EspecialidadDB.getInstance().buscarEspecialidadPorId(IdEspecialidad);
                        plan.Especialidad = esp;

                    }
                    plan.IdPlan = idPlan;
                    planes.Add(plan);
                }
                Conexion.getInstance().Disconnect();
                return planes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }

        public bool borrarPlan(int id)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Planes where idPlan='" + id + "'", Conexion.getInstance().Conection);
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

        public bool modificarPlan(Plan plan)
        {
            try
            {
                Conexion.getInstance().Connect();
                string nombre = plan.NombrePlan;
                string desc = plan.DescripcionPlan;
                int idEsp = plan.Especialidad.IdEspecialidad;
                int id = plan.IdPlan;
                SqlCommand cmd = new SqlCommand("update dbo.Planes set nombre='" + nombre + "',idEsp='"
                    + idEsp + "',descripcion='"
                    + desc + "' where  idPlan='" + id + "'", Conexion.getInstance().Conection);
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
        public int buscarEspDelPlan(int idPlan)
        {
            try
            {
                int id = idPlan;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idEsp from dbo.Planes where idPlan='" + id + "'", Conexion.getInstance().Conection);
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
        public Business.Entities.Plan buscarPlanPorId(int id)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Planes where idPlan='" + id + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                    int idPlan = (int)reader.GetValue(0);
                    String nombr = reader.GetString(1);
                    String desc = reader.GetString(2);
                    Business.Entities.Plan plan = new Plan(nombr, desc);
                    plan.IdPlan = idPlan;
                
                Conexion.getInstance().Disconnect();
                return plan;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }
        public Business.Entities.Plan buscarPlanPorNombre(string nombre)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Planes where CONVERT(VARCHAR,nombre)='" + nombre + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                int idPlan = (int)reader.GetValue(0);
                String nombr = reader.GetString(1);
                String desc = reader.GetString(2);
                Business.Entities.Plan plan = new Plan(nombr, desc);
                plan.IdPlan = idPlan;

                Conexion.getInstance().Disconnect();
                return plan;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }
    }
}