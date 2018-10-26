
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
                    Business.Entities.Curso cur = new Curso(nombre, cupo);
                    if (reader["idMateria"] != DBNull.Value)
                    {
                        Business.Entities.Materia mat = MateriaDB.getInstance().buscarMateriaPorId((int)reader.GetValue(3));
                        cur.Materia = mat;
                    }
                    if (reader["idComision"] != DBNull.Value)
                    {
                        Business.Entities.Comision com = ComisionDB.getInstance().buscarComisionPorId((int)reader.GetValue(4));
                        cur.Comision = com;
                    }
         
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
                    if (reader["idMateria"] != DBNull.Value)
                    {
                        Business.Entities.Materia mat = MateriaDB.getInstance().buscarMateriaPorId((int)reader.GetValue(3));
                        cur.Materia = mat;
                    }
                    if (reader["idComision"] != DBNull.Value)
                    {
                        Business.Entities.Comision com = ComisionDB.getInstance().buscarComisionPorId((int)reader.GetValue(4));
                        cur.Comision = com;
                    }
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

        public bool modificarNotaAlumno(int idCurso,int idAlumno,int nota,string estado)
        {
            try
            {

                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("update dbo.Alumno_Inscripcion set nota='" + nota + "',condicion='"
                    + estado + "'where idCurso='"+idCurso+"'and idAlumno='"+idAlumno+"'", Conexion.getInstance().Conection);
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
        public int buscarDocenteCurso(Docente doc, Curso cur)
        {
            try
            {
                int idDocente = doc.IDPersona;
                int idCurso = cur.IdCurso;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idDocente_Curso from dbo.Docente_Curso where idCurso='" + idCurso + "'AND idDocente='" + idDocente + "'", Conexion.getInstance().Conection);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.getInstance().Disconnect();
                return id;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return -1;
            }

        }
        public int buscarAlumnoCurso(int al, int cur)
        {
            try
            {
                int idAlumno = al;
                int idCurso = cur;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idInscripcion from dbo.Alumno_Inscripcion where idCurso='" + idCurso + "'AND idAlumno='" + idAlumno + "'", Conexion.getInstance().Conection);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.getInstance().Disconnect();
                return id;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return -1;
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
        public int buscarNotaAlumnoCurso(int idCurso,int idAlumno)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select nota from dbo.Alumno_Inscripcion where idCurso='" + idCurso + "'and idAlumno='"+idAlumno+"'", Conexion.getInstance().Conection);
                int nota = Convert.ToInt32(cmd.ExecuteScalar());
                Conexion.getInstance().Disconnect();
                return nota;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return -1;
            }

        }

        public List<int> buscarAlumnos(int idCurso)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select idAlumno from dbo.Alumno_Inscripcion where idCurso='" + idCurso + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                List<int> idAlumnos = new List<int>();
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    idAlumnos.Add(id);
                }
                Conexion.getInstance().Disconnect();
                return idAlumnos;
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

        public Business.Entities.Curso buscarCursoPorId(int id)
        {
            try
            {
                int idcurso = id;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Curso where idCurso='" + idcurso + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int idCurso = (int)reader.GetValue(0);
                string nom = reader.GetString(1);
                int cupo = (int)reader.GetValue(2);
                Business.Entities.Curso cur = new Curso(nom, cupo);
                if (reader["idMateria"] != DBNull.Value)
                {
                    Business.Entities.Materia mat = MateriaDB.getInstance().buscarMateriaPorId((int)reader.GetValue(3));
                    cur.Materia = mat;
                }
                if (reader["idComision"] != DBNull.Value)
                {
                    Business.Entities.Comision com = ComisionDB.getInstance().buscarComisionPorId((int)reader.GetValue(4));
                    cur.Comision = com;
                }
                //agregar los valores del comision y de la materia
                cur.IdCurso = idCurso;
                Conexion.getInstance().Disconnect();
                return cur;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }
        public Business.Entities.Curso buscarCursoPorNombre(string nombr)
        {
            try
            {
                string nombre = nombr;
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("select * from dbo.Curso where CONVERT(VARCHAR,nombre)='" + nombre + "'", Conexion.getInstance().Conection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int idCurso = (int)reader.GetValue(0);
                string nom = reader.GetString(1);
                int cupo = (int)reader.GetValue(2);
                Business.Entities.Curso cur = new Curso(nom, cupo);
                //agregar los valores del comision y de la materia
                cur.IdCurso = idCurso;
                Conexion.getInstance().Disconnect();
                return cur;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return null;
            }

        }
        public bool validarInscripcionAlumnoMateria(int idAlu, int idMat)
        {
            try
            {
                Conexion.getInstance().Connect();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from Alumno_Inscripcion al inner join Curso cu on cu.idCurso=al.idCurso where al.idAlumno='"+idAlu+"' and idMateria='"+idMat+"'", Conexion.getInstance().Conection);
                int cant = Convert.ToInt32(cmd.ExecuteScalar());          
                Conexion.getInstance().Disconnect();
                return cant>0;
            }
            catch (Exception e)
            {
                Conexion.getInstance().Disconnect();
                return false;
            }

        }
    }
}
