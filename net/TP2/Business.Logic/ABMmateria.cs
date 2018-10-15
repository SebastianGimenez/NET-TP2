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
            Business.Entities.Plan plan = Business.Logic.ABMplan.buscarPlanPorId(ma.Plan.IdPlan);
            if (plan != null)
            {
                Business.Entities.Materia mate = buscarMateriaPorNombre(ma.Nombre);
                if (mate == null)
                {
                    return Data.Database.MateriaDB.getInstance().altaMateria(ma);
                }
            }
            return false;
        }

        public static Business.Entities.Materia buscarMateriaPorId(int id)
        {
            return Data.Database.MateriaDB.getInstance().buscarMateriaPorId(id);
        }

        public static Business.Entities.Materia buscarMateriaPorNombre(string nombre)
        {
            return Data.Database.MateriaDB.getInstance().buscarMateriaPorNombre(nombre);
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
            Business.Entities.Plan plan = Business.Logic.ABMplan.buscarPlanPorId(mat.Plan.IdPlan);
            if (plan != null)
            {
                Business.Entities.Materia mate = buscarMateriaPorNombre(mat.Nombre);
                if (mate == null || mate.IdMateria==mat.IdMateria)
                {
                    return Data.Database.MateriaDB.getInstance().modificarMateria(mat);
                }
            }
            return false;
            
        }
        public static int buscarPlanDeMateria(int idMateria)
        {
            Business.Entities.Materia mat = buscarMateriaPorId(idMateria);
            if (mat != null)
            {
                return Data.Database.MateriaDB.getInstance().buscarPlanDeMateria(idMateria);
            }
            return -1;
        }
    }
}
