using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMplan
    {
        public static bool altaPlan(Business.Entities.Plan plan)
        {
            //validar que exista la especialidad
             return Data.Database.PlanDB.getInstance().altaPlan(plan);
        }

        public static int buscarEspDelPlan(int idPlan)
        {
            return Data.Database.PlanDB.getInstance().buscarEspDelPlan(idPlan);
        }

        public static int contarPlanes()
        {
            try
            {
                return listarPlanes().Count;
            }
            catch
            {
                return 0;
            }
        }
        public static List<Business.Entities.Plan> listarPlanes()
        {
            return Data.Database.PlanDB.getInstance().listarPlanes();
        }

        public static List<Business.Entities.Plan> listarPlanesPorNombre(string nombre)
        {
            return Data.Database.PlanDB.getInstance().listarPlanesPorNombre(nombre);
        }

        public static Business.Entities.Plan buscarPlan(string nombre)
        {
            return Data.Database.Planes.getInstance().buscarPlan(nombre);
        }

        public static bool borrarPlan(int id)
        {
            return Data.Database.PlanDB.getInstance().borrarPlan(id);
        }

        public static bool modificarPlan(Business.Entities.Plan plan)
        {
            return Data.Database.PlanDB.getInstance().modificarPlan(plan);

        }
    }
}
