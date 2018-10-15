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
            Business.Entities.Especialidad esp = Business.Logic.ABMespecialidad.buscarEspecialidadPorId(plan.Especialidad.IdEspecialidad);
            if (esp != null)
            {
                Business.Entities.Plan pl = buscarPlan(plan.NombrePlan);
                if (pl == null)
                {
                    return Data.Database.PlanDB.getInstance().altaPlan(plan);
                }
            }
            return false;
        }

        public static Business.Entities.Plan buscarPlanPorId(int id)
        {
            return Data.Database.PlanDB.getInstance().buscarPlanPorId(id);
        }

        public static int buscarEspDelPlan(int idPlan)
        {
            Business.Entities.Plan pl = buscarPlanPorId(idPlan);
            if (pl != null)
            {
                return Data.Database.PlanDB.getInstance().buscarEspDelPlan(idPlan);
            }
            return -1;
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
            return Data.Database.PlanDB.getInstance().buscarPlanPorNombre(nombre);
        }

        public static bool borrarPlan(int id)
        {
            return Data.Database.PlanDB.getInstance().borrarPlan(id);
        }

        public static bool modificarPlan(Business.Entities.Plan plan)
        {
            Business.Entities.Especialidad esp = Business.Logic.ABMespecialidad.buscarEspecialidadPorId(plan.Especialidad.IdEspecialidad);
            if (esp != null)
            {
                Business.Entities.Plan pl = buscarPlan(plan.NombrePlan);
                if (pl == null || pl.IdPlan==plan.IdPlan)
                {
                    return Data.Database.PlanDB.getInstance().modificarPlan(plan); 
                }
            }
            return false;
            

        }
    }
}
