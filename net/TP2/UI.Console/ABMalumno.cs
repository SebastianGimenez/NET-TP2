using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    public class ABMalumno : AbstractMenu
    {

       public ABMalumno(): base("Alumno")
        {

        }

        override
        protected void alta() {
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
            Business.Entities.Alumno al = new Business.Entities.Alumno(nombre, apellido, legajo, dni, email, telefono);
            Business.Logic.ABMalumno.altaAlumno(al);
        }

        override
        protected void listar()
        {
            List<Business.Entities.Alumno> alumnos = Business.Logic.ABMalumno.listarAlumnos();
            System.Console.WriteLine("NOMBRE | APELLIDO | LEGAJO | DNI | EMAIL | TELEFONO");
            foreach (Business.Entities.Alumno al in alumnos)
            {
                mostrarAlumno(al);
                System.Console.WriteLine("-----------------------------------------------------------------------------");
            }
            
        }

        override
        protected void buscar()
        {
            System.Console.Write("ingrese el legajo: ");
            string legajo = System.Console.ReadLine();
            Business.Entities.Alumno al = Business.Logic.ABMalumno.buscarAlumno(legajo);
            if (al != null)
            {
                mostrarAlumno(al);
            }
            else
            {
                System.Console.WriteLine("No se encontro un alumno con legajo {0}", legajo);
            }
        }

        private Business.Entities.Alumno buscarAlumno()
        {
            System.Console.Write("ingrese el legajo: ");
            string legajo = System.Console.ReadLine();
            Business.Entities.Alumno al = Business.Logic.ABMalumno.buscarAlumno(legajo);
            if (al != null)
            {
                mostrarAlumno(al);
            }
            else
            {
                System.Console.WriteLine("No se encontro un alumno con legajo {0}", legajo);
            }
            return al;
        }

        private void mostrarAlumno(Business.Entities.Alumno al)
        {
            System.Console.Write("| {0} | ", al.Nombre);
            System.Console.Write("| {0} | ", al.Apellido);
            System.Console.Write("| {0} | ", al.Legajo);
            System.Console.Write("| {0} | ", al.Dni);
            System.Console.Write("| {0} | ", al.Email);
            System.Console.WriteLine("| {0} | ", al.Telefono);

        }

        override
        protected void baja()
        {
            System.Console.Write("ingrese el legajo: ");
            string legajo = System.Console.ReadLine();
           bool borrado = Business.Logic.ABMalumno.borrarAlumno(legajo);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro un alumno con legajo {0}", legajo);
            }
            else
            {
                System.Console.WriteLine("Alumno eliminado con exito!!!");
            }
        }

        private bool borrarAlumno(Business.Entities.Alumno al)
        {
        
            return Business.Logic.ABMalumno.borrarAlumno(al.Legajo);
         
        }
        override
        protected void modi()
        {
            Business.Entities.Alumno alu = buscarAlumno();
            if(alu != null)
            {
                bool borrado = borrarAlumno(alu);
                if (borrado)
                {
                    alta();
                }
            }
        }
    }
}
