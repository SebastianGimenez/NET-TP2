using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
   public class ABMplan : AbstractMenu
    {
      public  ABMplan() : base("plan") { }

        override
        protected void alta()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("ingrese la descripcion: ");
            string descripcion = System.Console.ReadLine();
            Business.Entities.Plan plan = new Business.Entities.Plan(nombre, descripcion);
            System.Console.Write("ingrese el nombre de la especialidad: ");
            string especialidad = System.Console.ReadLine();
            bool guardado= Business.Logic.ABMplan.altaPlan(plan,especialidad);
            if (guardado)
            {
                System.Console.Write("guardado con exito");
                System.Console.ReadKey();
            }
            else
            {
                {
                    System.Console.Write("no se pudo guardar");
                    System.Console.ReadKey();
                }
            }
        }

        override
        protected void listar()
        {
            List<Business.Entities.Plan> planes = Business.Logic.ABMplan.listarPlanes();
            System.Console.WriteLine("NOMBRE | DESCRIPCION | NOMBRE ESPECIALIDAD");
            foreach (Business.Entities.Plan plan in planes)
            {
                mostrarPlan(plan);
                System.Console.WriteLine("-----------------------------------------------------------------------------");
            }

        }
        private Business.Entities.Plan buscarPlan()
        {
            System.Console.Write("ingrese el nombre del plan: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Plan plan = Business.Logic.ABMplan.buscarPlan(nombre);
            if (plan != null)
            {
                mostrarPlan(plan);
            }
            else
            {
                System.Console.WriteLine("No se encontro un plan con nombre {0}", nombre);
            }
            return plan;
        }

        override
            protected void buscar()
        {
            System.Console.Write("ingrese el nombre del plan: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Plan plan = Business.Logic.ABMplan.buscarPlan(nombre);
            if (plan != null)
            {
                mostrarPlan(plan);
            }
            else
            {
                System.Console.WriteLine("No se encontro un plan con nombre {0}", nombre);
            }
        }

        private void mostrarPlan(Business.Entities.Plan plan)
        {
            System.Console.Write("| {0} | ",plan.NombrePlan );
            System.Console.Write("| {0} | ",plan.DescripcionPlan );
            System.Console.Write("| {0} | \n ", plan.Especialidad.NombreEspecialidad);

        }
        override
        protected void baja()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            bool borrado = Business.Logic.ABMplan.borrarPlan(nombre);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro un plan con el nombre {0}", nombre);
            }
            else
            {
                System.Console.WriteLine("plan eliminado con exito!!!");
            }
        }

        override
        protected void modi()
        {
            Business.Entities.Plan plan = buscarPlan();
            if (plan != null)
            {
                bool borrado = Business.Logic.ABMplan.borrarPlan(plan.NombrePlan);
                if (borrado)
                {
                    alta();
                }
            }
        }
    }
}
