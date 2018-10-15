using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;


namespace Business.Logic
{
    public class ABMalumno

    {
        public static int altaAlumno(Business.Entities.Alumno al)
        {
            Business.Entities.Alumno alu = buscarAlumno(al.Legajo);
            if (alu == null)
            {
                return Data.Database.AlumnoDB.getInstance().altaAlumno(al);
            }
            return -1;
        }

        public static List<int> listarCursosAlumno(int idAlumno)
        {
            return Data.Database.AlumnoDB.getInstance().listarCursosAlumno(idAlumno);
        }

        public static bool inscribirCursoAlumno(int idCurso, int idAlumno)
        {
            bool cupo = Business.Logic.ABMcurso.validarCupo(idCurso);
            if (cupo)
            { 
                int enc = Business.Logic.ABMcurso.buscarAlumnoCurso(idAlumno, idCurso);
                if (enc == -1 || enc == 0)
                {
                    return Data.Database.AlumnoDB.getInstance().inscribirCurso(idCurso, idAlumno);
                }
            }
            return false;
        }

        public static List<Business.Entities.Alumno> listarAlumnos()
        {
            return Data.Database.AlumnoDB.getInstance().listarAlumnos();
        }

        public static Business.Entities.Alumno buscarAlumno(string legajo)
        {
           return Data.Database.AlumnoDB.getInstance().buscarAlumno(legajo);
        }

        public static Business.Entities.Alumno buscarAlumnoPorId(int id)
        {
            return Data.Database.AlumnoDB.getInstance().buscarAlumnoPorId(id);
        }

        public static bool borrarAlumno(string legajo)
        {
            return Data.Database.AlumnoDB.getInstance().borrarAlumno(legajo);
        }

        public static bool borrarCursoAlumno(int idCurso, int idAlumno)
        {
            int nota = Business.Logic.ABMcurso.buscarNotaAlumnoCurso(idCurso, idAlumno);
            if (nota == -1)
            {
                return Data.Database.AlumnoDB.getInstance().borrarCursoAlumno(idCurso, idAlumno);
            }
            return false;
        }

        public static bool modi(Alumno alu)
        {
            return Data.Database.AlumnoDB.getInstance().modi(alu);
        }

        public static List<Business.Entities.Alumno> listarAlumnosPorLegajo(string legajo)
        {
            return Data.Database.AlumnoDB.getInstance().listarAlumnosPorLegajo(legajo);
        }
    }
    
}
