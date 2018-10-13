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
    public class CursoDB
    {
        private static CursoDB _instance;
        public static CursoDB getInstance()
        {
            if (CursoDB._instance == null)
            {
                CursoDB._instance = new CursoDB();
            }
            return CursoDB._instance;
        }

        public bool altaCurso(Business.Entities.Curso curso)
        {
            try
            {
                string nombre = curso.Nombre;
                int idComision = curso.Comision.IdComision;
                int cupo = curso.Cupo;
                int idMateria = curso.Materia.IdMateria;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Curso(nombre,cupo,idMateria,idComision) " +
                    "values('" + nombre + "','" + cupo + "','" + idMateria + "','" + idComision + "')", Conexion.getInstance().Conection);
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
        public List<Business.Entities.Curso> listarCursos()
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Curso", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Business.Entities.Curso> cursos = new List<Curso>();
                while (reader.Read())
                {
                    int idCurso = (int)reader.GetValue(0);
                    string nombre = reader.GetString(1);
                    int cupo = (int)reader.GetValue(2);
                    int idMateria = (int)reader.GetValue(3);
                    int idComision = (int)reader.GetValue(4);
                    Business.Entities.Curso cur = new Curso(nombre, cupo);
                    //agregar los valores del comision y de la materia
                    cur.IdCurso = idCurso;
                   
                    cursos.Add(cur);
                }
                Conexion.getInstance().Disconnect();
                return cursos;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;

            }
        }

        public List<Business.Entities.Curso> listarCursosPorNombre(string nombre)
        {
            try
            {
                string nomb = "%" + nombre + "%";
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Curso where CONVERT(VARCHAR,nombre) like '"+nomb+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Business.Entities.Curso> cursos = new List<Curso>();
                while (reader.Read())
                {
                    int idCurso = (int)reader.GetValue(0);
                    string nom = reader.GetString(1);
                    int cupo = (int)reader.GetValue(2);
                    int idMateria = (int)reader.GetValue(3);
                    int idComision = (int)reader.GetValue(4);
                    Business.Entities.Curso cur = new Curso(nom, cupo);
                    //agregar los valores del comision y de la materia
                    cur.IdCurso = idCurso;

                    cursos.Add(cur);
                }
                Conexion.getInstance().Disconnect();
                return cursos;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;

            }
        }

        public bool borrarCurso(int idCurso)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Curso where idCurso='" + idCurso + "'", Conexion.getInstance().Conection);
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

        public bool modificarCurso(Curso curso)
        {
            try
            {
                string nombre = curso.Nombre;
                int cupo = curso.Cupo;
                int idMat = curso.Materia.IdMateria;
                int idCom = curso.Comision.IdComision;
                int idCurso = curso.IdCurso;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.Curso set nombre='" + nombre + "',cupo='"
                    + cupo + "',idMateria='"
                    + idMat + "',idComision='"
                    + idCom + "' where  idCurso='" + idCurso + "'", Conexion.getInstance().Conection);
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

        public bool agregarDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            try
            {
                int idDocente = doc.IDPersona;
                int idCurso = cur.IdCurso;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("insert into dbo.Docente_Curso(idDocente,idCurso) " +
                        "values('" + idDocente + "','"+idCurso+"')", Conexion.getInstance().Conection);
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

        public bool borrarDocenteCurso(Docente doc, Curso cur)
        {
            try
            {
                int idDocente = doc.IDPersona;
                int idCurso = cur.IdCurso;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("delete from dbo.Docente_Curso where idCurso='" + idCurso + "'AND idDocente='"+idDocente+"'", Conexion.getInstance().Conection);
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



        public List<int> buscarDocentes(int idCurso)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Docente_Curso where idCurso='"+idCurso+"'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<int> idDocentes = new List<int>();
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(1);
                    idDocentes.Add(id);
                }
                Conexion.getInstance().Disconnect();
                return idDocentes;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;

            }

        }
        public int buscarComisionCurso(int idCurso)
        {
            try
            {
                int id = idCurso;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idComision from dbo.Curso where idCurso='" + id + "'", Conexion.getInstance().Conection);
                int idcom = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.getInstance().Disconnect();
                return idcom;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return -1;
            }

        }
        public int buscarMateriaCurso(int idCurso)
        {
            try
            {
                int id = idCurso;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idMateria from dbo.Curso where idCurso='" + id + "'", Conexion.getInstance().Conection);
                int idMat = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.getInstance().Disconnect();
                return idMat;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return -1;
            }

        }

    }
}
