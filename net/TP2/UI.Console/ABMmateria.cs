using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
   public class ABMmateria : AbstractMenu
    {
        public ABMmateria() : base("materia") { }

        override
        protected void alta()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("ingrese una descripcion: ");
            string descripcion = System.Console.ReadLine();
            System.Console.Write("ingrese horas semanales: ");
            int horasSemanales = int.Parse(System.Console.ReadLine());
            System.Console.Write("ingrese horas totales: ");
            int horasTotales = int.Parse(System.Console.ReadLine());
            System.Console.Write("ingrese el plan: ");
            Business.Entities.Materia materia = new Business.Entities.Materia(nombre, descripcion, horasSemanales, horasTotales);
            string plan = System.Console.ReadLine();
            bool agregado = Business.Logic.ABMmateria.altaMateria(materia, plan);
            if (agregado)
            {
                System.Console.Write("agregado con exito");
            }
            else
            {
                System.Console.WriteLine("no existe ese plan");

            }
        }
        


        override
        protected void listar()
        {
            List<Business.Entities.Materia> materias = Business.Logic.ABMmateria.listarMaterias();
            System.Console.WriteLine("NOMBRE | DESCRIPCION | HORAS SEMANALES | HORAS TOTALES | PLAN ");
            foreach (Business.Entities.Materia mat in materias)
            {
                mostrar(mat);
                System.Console.WriteLine("-----------------------------------------------------------------------------");
            }

        }

        private Business.Entities.Materia buscarMateria()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Materia ma = Business.Logic.ABMmateria.buscarMateria(nombre);
            if (ma != null)
            {
                mostrar(ma);
            }
            else
            {
                System.Console.WriteLine("No se encontro la materia {0}", nombre);
            }
            return ma;
        }

            override protected void buscar() {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Materia ma = Business.Logic.ABMmateria.buscarMateria(nombre);
            if (ma != null)
            {
                mostrar(ma);
            }
            else
            {
                System.Console.WriteLine("No se encontro la materia {0}", nombre);
            }
        }

        private void mostrar(Business.Entities.Materia ma)
        {
            System.Console.Write("| {0} | ", ma.Nombre);
            System.Console.Write("| {0} | ", ma.Descripcion);
            System.Console.Write("| {0} | ", ma.HorasSemanales);
            System.Console.Write("| {0} | ", ma.HorasTotales);
            System.Console.Write("| {0} | \n", ma.Plan.NombrePlan);
            

        }
        override
        protected void baja()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            bool borrado = Business.Logic.ABMmateria.borrarMateria(nombre);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro la materia {0}", nombre);
            }
            else
            {
                System.Console.WriteLine("Materia eliminado con exito!!!");
            }
        }

        override
        protected void modi()
        {
        Business.Entities.Materia materia = buscarMateria();
        if (materia != null)
        {
            bool borrado = Business.Logic.ABMmateria.borrarMateria(materia.Nombre);
            if (borrado)
            {
                alta();
            }
        }
    }
    }
}

