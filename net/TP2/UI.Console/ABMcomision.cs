using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
   public class ABMcomision : AbstractMenu
    {
       public ABMcomision() : base("comision") { }

        override
        protected void alta()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("ingrese el aula: ");
            string aula = System.Console.ReadLine();
            Business.Entities.Comision com = new Business.Entities.Comision(nombre, aula);
            Business.Logic.ABMcomision.altaComision(com);
        }

        override
        protected void listar()
        {
            List<Business.Entities.Comision> comisiones = Business.Logic.ABMcomision.listarComisiones();
            System.Console.WriteLine("NOMBRE | AULA |");
            foreach (Business.Entities.Comision com in comisiones)
            {
                mostrarComision(com);
                System.Console.WriteLine("-----------------------------------------------------------------------------");
            }

        }
        private Business.Entities.Comision buscarComision()
        {
            System.Console.Write("ingrese el nombre de la comision: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Comision com = Business.Logic.ABMcomision.buscarComision(nombre);
            if (com != null)
            {
                mostrarComision(com);
            }
            else
            {
                System.Console.WriteLine("No se encontro una comision con nombre {0}", nombre);
            }
            return com;
        }

        override
            protected void buscar()
        {
            System.Console.Write("ingrese el nombre de la comision: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Comision com = Business.Logic.ABMcomision.buscarComision(nombre);
            if (com != null)
            {
                mostrarComision(com);
            }
            else
            {
                System.Console.WriteLine("No se encontro una comision con nombre {0}", nombre);
            }
        }

        private void mostrarComision(Business.Entities.Comision com)
        {
            System.Console.Write("| {0} | ", com.NombreComision);
            System.Console.Write("| {0} | \n", com.Aula);
        }
        override
        protected void baja()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            bool borrado = Business.Logic.ABMcomision.borrarComision(nombre);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro una comision con el nombre {0}", nombre);
            }
            else
            {
                System.Console.WriteLine("comision eliminada con exito!!!");
            }
        }

        override
        protected void modi()
        {
            Business.Entities.Comision com = buscarComision();
            if (com != null)
            {
                bool borrado = Business.Logic.ABMcomision.borrarComision(com.NombreComision);
                if (borrado)
                {
                    alta();
                }
            }
        }
    }
}
