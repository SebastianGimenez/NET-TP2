using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMcurso
    {


        public static bool altaCurso(Business.Entities.Curso cur)
        {
            Business.Entities.Comision com = Business.Logic.ABMcomision.buscarComisionPorId(cur.Comision.IdComision);
            Business.Entities.Materia mat = Business.Logic.ABMmateria.buscarMateriaPorId(cur.Materia.IdMateria);
            if (com != null && mat != null)
            {
                Business.Entities.Curso curso = buscarCursoPorNombre(cur.Nombre);
                if (curso == null)
                { 
                return Data.Database.CursoDB.getInstance().altaCurso(cur);
                }
            }
            return false;
        }

        public static int buscarDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            Business.Entities.Docente docente = Business.Logic.ABMdocente.buscarDocentePorId(doc.IDPersona);
            Business.Entities.Curso curso = Business.Logic.ABMcurso.buscarCursoPorId(cur.IdCurso);
            if (curso != null && docente != null)
            {
                return Data.Database.CursoDB.getInstance().buscarDocenteCurso(doc, cur);
            }
            return -1;
        }

        public static bool validarCupo(int idCurso)
        {
            int ocupados = (buscarAlumnos(idCurso).Count());
            int cupo = (buscarCursoPorId(idCurso)).Cupo;
            if (cupo > ocupados)
            { return true; }
            else { return false; }
        }

        public static bool modificarNotaAlumno(int idCurso, int idAlumno, int nota, string estado)
        {
            int rel = buscarAlumnoCurso(idAlumno, idCurso);
            if (rel != -1 || rel != 0)
            {
                return Data.Database.CursoDB.getInstance().modificarNotaAlumno(idCurso, idAlumno, nota, estado);
            }
            return false;
        }

        public static int buscarNotaAlumnoCurso(int idCurso, int idAlumno)
        {
            int rel = buscarAlumnoCurso(idAlumno, idCurso);
            if (rel != -1 || rel != 0)
            {
                return Data.Database.CursoDB.getInstance().buscarNotaAlumnoCurso(idCurso, idAlumno);
            }
            return -1;
           
        }

        public static List<Business.Entities.Curso> listarCursos()
        {
            return Data.Database.CursoDB.getInstance().listarCursos();
        }

        public static List<Business.Entities.Curso> listarCursosPorNombre(string nombre)
        {
            return Data.Database.CursoDB.getInstance().listarCursosPorNombre(nombre);
        }

        public static int buscarComisionCurso(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarComisionCurso(idCurso);
        }

        public static int buscarMateriaCurso(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarMateriaCurso(idCurso);
        }

        public static Business.Entities.Curso buscarCursoPorNombre(string nombre)
        {
            return Data.Database.CursoDB.getInstance().buscarCursoPorNombre(nombre);
        }

        public static bool borrarCurso(int id)
        {
            return Data.Database.CursoDB.getInstance().borrarCurso(id);
        }

        public static bool modificarCurso(Business.Entities.Curso cur)
        {
            Business.Entities.Comision com = Business.Logic.ABMcomision.buscarComisionPorId(cur.Comision.IdComision);
            Business.Entities.Materia mat = Business.Logic.ABMmateria.buscarMateriaPorId(cur.Materia.IdMateria);
            if (com != null && mat != null)
            {
                Business.Entities.Curso curso = buscarCursoPorNombre(cur.Nombre);
                if (curso == null || curso.IdCurso == cur.IdCurso)
                {
                    return Data.Database.CursoDB.getInstance().modificarCurso(cur);
                }
            }
            return false;         
        }

        public static List<int> buscarDocentes(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarDocentes(idCurso);
        }

        public static int buscarAlumnoCurso(int al, int cur)
        {
            Business.Entities.Alumno alu = Business.Logic.ABMalumno.buscarAlumnoPorId(al);
            Business.Entities.Curso curso = Business.Logic.ABMcurso.buscarCursoPorId(cur);
            if (curso != null && alu != null)
            {
                return Data.Database.CursoDB.getInstance().buscarAlumnoCurso(al, cur);
            }
            return -1;
        }

        public static List<int> buscarAlumnos(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarAlumnos(idCurso);
        }

        public static bool agregarDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            int val = Business.Logic.ABMcurso.buscarDocenteCurso(doc, cur);
            if (val == -1 || val==0)
            {
                return Data.Database.CursoDB.getInstance().agregarDocenteCurso(doc, cur);
            }
            else
            {
                return false;
            }
        }

        public static bool borrarDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            int val = Business.Logic.ABMcurso.buscarDocenteCurso(doc, cur);
            if (val != -1 || val != 0)
            {
                return Data.Database.CursoDB.getInstance().borrarDocenteCurso(doc, cur);
            }
            else
            {
                return false;
            }
            
        }

        public static Business.Entities.Curso buscarCursoPorId(int id)
        {
            return Data.Database.CursoDB.getInstance().buscarCursoPorId(id);
        }

        public static bool validarInscAlumnoMateria(int idAl, int idMat)
        {
            return Data.Database.CursoDB.getInstance().validarInscripcionAlumnoMateria(idAl, idMat);
        }
    }
}
