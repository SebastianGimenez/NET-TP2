using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMmateria
    {

        public static bool altaMateria(Business.Entities.Materia ma, string nombrePlan)
        {
            Business.Entities.Plan plan = ABMplan.buscarPlan(nombrePlan);
            if (plan != null)
            {
                ma.agregarPlan(plan);
                Data.Database.Materias.getInstance().altaMateria(ma);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int contarMaterias()
        {
            return listarMaterias().Count;
        }

        public static List<Business.Entities.Materia> listarMaterias()
        {
            return Data.Database.Materias.getInstance().listarMaterias();
        }

        public static Business.Entities.Materia buscarMateria(string nombre)
        {
            return Data.Database.Materias.getInstance().buscarMateria(nombre);
        }

        public static bool borrarMateria(string nombre)
        {
            return Data.Database.Materias.getInstance().borrarMateria(nombre);
        }

    }
}
