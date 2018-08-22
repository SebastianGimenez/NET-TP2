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
        public static int altaAlumno(Business.Entities.Alumno al) {
            return Data.Database.AlumnoDB.getInstance().altaAlumno(al);
         }
        public static List<Business.Entities.Alumno> listarAlumnos() {
        return Data.Database.AlumnoDB.getInstance().listarAlumnos();
        }

        public static Business.Entities.Alumno buscarAlumno(string legajo)
        {
           return Data.Database.AlumnoDB.getInstance().buscarAlumno(legajo);
        }

        public static bool borrarAlumno(string legajo)
        {
            return Data.Database.AlumnoDB.getInstance().borrarAlumno(legajo);
        }

        public static bool modi(Alumno alu)
        {
            return Data.Database.AlumnoDB.getInstance().modi(alu);
        }
    }
    
}
