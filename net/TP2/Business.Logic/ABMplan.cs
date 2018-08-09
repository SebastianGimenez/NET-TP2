using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMplan
    {
        public static bool altaPlan(Business.Entities.Plan plan, string nombreEsp)
        {
            Business.Entities.Especialidad especi = Business.Logic.ABMespecialidad.buscarEspecialidad(nombreEsp);
            if (especi != null)
            {
                plan.agregarEspecialidad(especi);
                Data.Database.Planes.getInstance().altaPlan(plan);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int contarPlanes()
        {
            return listarPlanes().Count;
        }
        public static List<Business.Entities.Plan> listarPlanes()
        {
            return Data.Database.Planes.getInstance().listarPlanes();
        }

        public static Business.Entities.Plan buscarPlan(string nombre)
        {
            return Data.Database.Planes.getInstance().buscarPlan(nombre);
        }

        public static bool borrarPlan(string nombre)
        {
            return Data.Database.Planes.getInstance().borrarPlan(nombre);
        }
    }
}
