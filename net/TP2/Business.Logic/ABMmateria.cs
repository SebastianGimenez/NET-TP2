using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMmateria
    {

        public static bool altaMateria(Business.Entities.Materia ma)
        {
            //validar que exista el plan
               return Data.Database.MateriaDB.getInstance().altaMateria(ma);
        }

        public static Business.Entities.Materia buscarMateriaPorId(int id)
        {
            return Data.Database.MateriaDB.getInstance().buscarMateriaPorId(id);
        }
        public static int contarMaterias()
        {
            return listarMaterias().Count;
        }

        public static List<Business.Entities.Materia> listarMaterias()
        {
            return Data.Database.MateriaDB.getInstance().listarMaterias();
        }

        public static List<Business.Entities.Materia> listarMateriasPorNombre(string nombre)
        {
            return Data.Database.MateriaDB.getInstance().listarMateriasPorNombre(nombre);
        }

        public static Business.Entities.Materia buscarMateria(string nombre)
        {
            return Data.Database.Materias.getInstance().buscarMateria(nombre);
        }

        public static bool borrarMateria(int idMateria)
        {
            return Data.Database.MateriaDB.getInstance().borrarMateria(idMateria);
        }

        public static bool modificarMateria(Business.Entities.Materia mat)
        {
            return Data.Database.MateriaDB.getInstance().modificarMateria(mat);
        }
        public static int buscarPlanDeMateria(int idMateria)
        {
            return Data.Database.MateriaDB.getInstance().buscarPlanDeMateria(idMateria);
        }
    }
}
