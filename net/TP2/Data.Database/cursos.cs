using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Cursos
    {
        private List<Business.Entities.Curso> cursos;
        private static Cursos _instance = null;

        public static Cursos getInstance()
        {
            if (Cursos._instance == null)
            {
                Cursos._instance = new Cursos();
            }
            return Cursos._instance;
        }

        Cursos()
        {
            cursos = new List<Business.Entities.Curso>();
        }

        public void altaCurso(Business.Entities.Curso cur)
        {
            this.cursos.Add(cur);
        }

        public List<Business.Entities.Curso> listarCursos()
        {
            return this.cursos;
        }

        public Business.Entities.Curso buscarCurso(string nombre)
        {

            foreach (Business.Entities.Curso cur in this.cursos)
            {
                if (cur.Nombre == nombre)
                {
                    return cur;
                }
            }
            return null;
        }

        public bool borrarCurso(string nombre)
        {
            Business.Entities.Curso cur = buscarCurso(nombre);
            if (cur == null) return false;

            return this.cursos.Remove(cur);
        }
    }
}

