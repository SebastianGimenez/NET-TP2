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
    public class ComisionDB
    {
        private static ComisionDB _instance;

        public static ComisionDB getInstance()
        {
            if (ComisionDB._instance == null)
            {
                ComisionDB._instance = new ComisionDB();
            }
            return ComisionDB._instance;
        }

        public bool altaComision(Business.Entities.Comision com)
        {
            try
            {
                string nombre = com.NombreComision;
                string aula = com.Aula;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Comision(nombre,aula)" +
                    " values('" + nombre + "','"
                    + aula + "')", Conexion.getInstance().Conection);
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

        public List<Business.Entities.Comision> listarComisiones()
        {
            try
            {
                List<Business.Entities.Comision> comisiones = new List<Comision>();
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Comision", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idComision = (int)reader.GetValue(0);
                    String nombre = reader.GetString(1);
                    String aula = reader.GetString(2);
                    Business.Entities.Comision com = new Comision(nombre, aula);
                    com.IdComision = idComision;
                    comisiones.Add(com);
                }
                Conexion.getInstance().Disconnect();
                return comisiones;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }

        public List<Business.Entities.Comision> listarComisionesPorNombre(string nombre)
        {
            try
            {
                nombre = "%" + nombre + "%";
                List<Business.Entities.Comision> comisiones = new List<Comision>();
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Comision where CONVERT(VARCHAR,nombre) like'" + nombre + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idComision = (int)reader.GetValue(0);
                    String nombr = reader.GetString(1);
                    String aula = reader.GetString(2);
                    Business.Entities.Comision com = new Comision(nombr, aula);
                    com.IdComision = idComision;
                    comisiones.Add(com);
                }
                Conexion.getInstance().Disconnect();
                return comisiones;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
        public bool borrarComision(int id)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Comision where idComision='" + id + "'", Conexion.getInstance().Conection);
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

        public bool modificarComision(Comision com)
        {
            try
            {
                Conexion.getInstance().Connect();
                string nombre = com.NombreComision;
                string aula = com.Aula;
                int idCom = com.IdComision;
                SqlCommand cmd = new SqlCommand("update dbo.Comision set nombre='" + nombre + "',aula='"
                    + aula + "' where  idComision='" + idCom + "'", Conexion.getInstance().Conection);
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
        public Business.Entities.Comision buscarComisionPorId(int id)
        {
            try
            {
                int idCom = id;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from Comision where idComision='" + idCom + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int idComision = (int)reader.GetValue(0);
                String nombr = reader.GetString(1);
                String aula = reader.GetString(2);
                Business.Entities.Comision com = new Comision(nombr, aula);
                com.IdComision = idComision;                
                Conexion.getInstance().Disconnect();
                return com;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }
        }
    }
}

