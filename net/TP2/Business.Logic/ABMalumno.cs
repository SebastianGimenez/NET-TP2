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
        public static void altaAlumno(Business.Entities.Alumno al) {
            Data.Database.Alumnos.getInstance().altaAlumno(al);
         }
        public static List<Business.Entities.Alumno> listarAlumnos() {
        return Data.Database.Alumnos.getInstance().listarAlumnos();
        }

        public static Business.Entities.Alumno buscarAlumno(string legajo)
        {
           return Data.Database.Alumnos.getInstance().buscarAlumno(legajo);
        }

        public static bool borrarAlumno(string legajo)
        {
            return Data.Database.Alumnos.getInstance().borrarAlumno(legajo);
        }

        
    }
    
}
