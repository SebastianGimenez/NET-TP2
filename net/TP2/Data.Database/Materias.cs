using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
   public class Materias
    {
        private List<Business.Entities.Materia> materias;
        private static Materias _instance = null;

        public static Materias getInstance()
        {
            if (Materias._instance == null)
            {
                Materias._instance = new Materias();
            }
            return Materias._instance;
        }

        Materias()
        {
            materias = new List<Business.Entities.Materia>();
        }

        public void altaMateria(Business.Entities.Materia ma)
        {
            this.materias.Add(ma);
        }

        public List<Business.Entities.Materia> listarMaterias()
        {
            return this.materias;
        }

        public Business.Entities.Materia buscarMateria(string nombre)
        {

            foreach (Business.Entities.Materia mat in this.materias)
            {
                if (mat.Nombre == nombre)
                {
                    return mat;
                }
            }
            return null;
        }

        public bool borrarMateria(string nombre)
        {
            Business.Entities.Materia mat = buscarMateria(nombre);
            if (mat == null) return false;

            return this.materias.Remove(mat);
        }
    }
}
