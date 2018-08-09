using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
   public class ABMdocente : AbstractMenu
    {
        public ABMdocente() : base("docente") { }
        
        override
        protected void alta()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("ingrese el apellido: ");
            string apellido = System.Console.ReadLine();
            System.Console.Write("ingrese el legajo: ");
            string legajo = System.Console.ReadLine();
            System.Console.Write("ingrese el dni: ");
            string dni = System.Console.ReadLine();
            System.Console.Write("ingrese el email: ");
            string email = System.Console.ReadLine();
            System.Console.Write("ingrese el telefono: ");
            string telefono = System.Console.ReadLine();
            Business.Entities.Docente doc = new Business.Entities.Docente(nombre, apellido, legajo, dni, email, telefono);
            Business.Logic.ABMdocente.altaDocente(doc);
        }
        override
        protected void listar()
        {
            List<Business.Entities.Docente> docentes = Business.Logic.ABMdocente.listarDocentes();
            System.Console.WriteLine("NOMBRE | APELLIDO | LEGAJO | DNI | EMAIL | TELEFONO");
            foreach (Business.Entities.Docente doc in docentes)
            {
                mostrarDocente(doc);
                System.Console.WriteLine("-----------------------------------------------------------------------------");
            }

        }

        private Business.Entities.Docente buscarDocente()
        {
            System.Console.Write("ingrese el legajo: ");
            string legajo = System.Console.ReadLine();
            Business.Entities.Docente doc = Business.Logic.ABMdocente.buscarDocente(legajo);
            if (doc != null)
            {
                mostrarDocente(doc);
            }
            else
            {
                System.Console.WriteLine("No se encontro un docente con legajo {0}", legajo);
            }
            return doc;
        }

        override
        protected void buscar()
        {
                System.Console.Write("ingrese el legajo: ");
                string legajo = System.Console.ReadLine();
                Business.Entities.Docente doc = Business.Logic.ABMdocente.buscarDocente(legajo);
                if (doc != null)
                {
                    mostrarDocente(doc);
                }
                else
                {
                    System.Console.WriteLine("No se encontro un docente con legajo {0}", legajo);
                }
        }

        private void mostrarDocente(Business.Entities.Docente doc)
        {
            System.Console.Write("| {0} | ", doc.Nombre);
            System.Console.Write("| {0} | ", doc.Apellido);
            System.Console.Write("| {0} | ", doc.Legajo);
            System.Console.Write("| {0} | ", doc.Dni);
            System.Console.Write("| {0} | ", doc.Email);
            System.Console.WriteLine("| {0} | ", doc.Telefono);

        }

        override
        protected void baja()
        {
            System.Console.Write("ingrese el legajo: ");
            string legajo = System.Console.ReadLine();
            bool borrado = Business.Logic.ABMdocente.borrarDocente(legajo);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro un docente con legajo {0}", legajo);
            }
            else
            {
                System.Console.WriteLine("Docente eliminado con exito!!!");
            }
        }

        
        override
        protected void modi()
        {
            Business.Entities.Docente doc = buscarDocente();
            if (doc != null)
            {
                bool borrado = Business.Logic.ABMdocente.borrarDocente(doc.Legajo);
                if (borrado)
                {
                    alta();
                }
            }
        }
    }


}
