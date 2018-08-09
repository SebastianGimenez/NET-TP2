using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Planes
    {
        private List<Business.Entities.Plan> planes;
        private static Planes _instance = null;

        public static Planes getInstance()
        {
            if (Planes._instance == null)
            {
                Planes._instance = new Planes();
            }
            return Planes._instance;
        }

        Planes()
        {
            planes = new List<Business.Entities.Plan>();
        }

        public void altaPlan(Business.Entities.Plan plan)
        {
            this.planes.Add(plan);
        }

        public List<Business.Entities.Plan> listarPlanes()
        {
            return this.planes;
        }

        public Business.Entities.Plan buscarPlan(string nombre)
        {

            foreach (Business.Entities.Plan plan in this.planes)
            {
                if (plan.NombrePlan == nombre)
                {
                    return plan;
                }
            }
            return null;
        }

        public bool borrarPlan(string nombre)
        {
            Business.Entities.Plan plan = buscarPlan(nombre);
            if (plan == null) return false;

            return this.planes.Remove(plan);
        }
    }
}
