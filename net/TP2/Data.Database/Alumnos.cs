using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{   
    public class Alumnos
    {
        private List<Business.Entities.Alumno> alumnos;
        private static Alumnos _instance = null;

        public static Alumnos getInstance()
        {
            if(Alumnos._instance == null)
            {
                Alumnos._instance = new Alumnos();
            }
            return Alumnos._instance;
        }

        Alumnos()
        {
            alumnos = new List<Business.Entities.Alumno>();
        }

        public void altaAlumno(Business.Entities.Alumno al)
        {
            this.alumnos.Add(al);
        }

        public List<Business.Entities.Alumno> listarAlumnos()
        {
            return this.alumnos;
        }

        public Business.Entities.Alumno buscarAlumno(string legajo)
        {
           
            foreach(Business.Entities.Alumno alu in this.alumnos)
            {
                if(alu.Legajo == legajo)
                {
                    return alu;
                }
            }
            return null;
        }

        public bool borrarAlumno(string legajo)
        {
            Business.Entities.Alumno alu = buscarAlumno(legajo);
            if (alu == null) return false;

            return this.alumnos.Remove(alu);
        }

    }
}
