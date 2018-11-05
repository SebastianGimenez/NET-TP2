using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    public class ABMespecialidad : AbstractMenu
    {
       public ABMespecialidad() : base("especialidad") { }
        
        override
        protected void alta()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("ingrese la descripcion: ");
            string descripcion = System.Console.ReadLine();

            Business.Entities.Especialidad esp = new Business.Entities.Especialidad(nombre, descripcion);
            Business.Logic.ABMespecialidad.altaEspecialidad(esp);
        }
        override
        protected void listar()
        {
            List<Business.Entities.Especialidad> especialidades = Business.Logic.ABMespecialidad.listarEspecialidades();
            System.Console.WriteLine("NOMBRE | DESCRIPCION");
            foreach (Business.Entities.Especialidad esp in especialidades)
            {
                mostrarEspecialidad(esp);
                System.Console.WriteLine("-----------------------------------------------------------------------------");
            }

        }
        override
        protected void buscar()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Especialidad esp = Business.Logic.ABMespecialidad.buscarEspecialidad(nombre);
            if (esp != null)
            {
                mostrarEspecialidad(esp);
            }
            else
            {
                System.Console.WriteLine("No se encontro una especialidad con nombre {0}", nombre);
            }

        }

        private Business.Entities.Especialidad buscarEspecialidad()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Especialidad esp = Business.Logic.ABMespecialidad.buscarEspecialidad(nombre);
            if (esp != null)
            {
                mostrarEspecialidad(esp);
            }
            else
            {
                System.Console.WriteLine("No se encontro una especialidad con nombre {0}", nombre);
            }
            return esp;
        }

        public Business.Entities.Especialidad buscarEspecialidad(string nombre)
        {
            Business.Entities.Especialidad esp = Business.Logic.ABMespecialidad.buscarEspecialidad(nombre);

            if (esp == null)
            {
                return null;
            }
            else
            {
                return esp;
            }
        }

        private void mostrarEspecialidad(Business.Entities.Especialidad esp)
        {
            System.Console.Write("| {0} | ", esp.NombreEspecialidad);
            System.Console.Write("| {0} | \n ", esp.Descripcion);

        }
        override
        protected void baja()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Especialidad esp = Business.Logic.ABMespecialidad.buscarEspecialidad(nombre);
            bool borrado = Business.Logic.ABMespecialidad.borrarEspecialidad(esp.IdEspecialidad);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro una especialidad con el nombre {0}", nombre);
            }
            else
            {
                System.Console.WriteLine("especialidad eliminada con exito!!!");
            }
        }

        private bool borrarEspecialidad(Business.Entities.Especialidad esp)
        {

            return Business.Logic.ABMespecialidad.borrarEspecialidad(esp.NombreEspecialidad);

        }
        override
        protected void modi()
        {
            Business.Entities.Especialidad esp = buscarEspecialidad();
            if (esp != null)
            {
                bool borrado = borrarEspecialidad(esp);
                if (borrado)
                {
                    alta();
                }
            }
        }
    }   
}
