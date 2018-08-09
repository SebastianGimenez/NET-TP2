using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    public class ABMCurso : AbstractMenu
    {
        public ABMCurso() : base("curso") { }
        static int opc = -1;
        override
        protected void alta()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            System.Console.Write("ingrese cupo: ");
            int cupo = int.Parse(System.Console.ReadLine());
            Business.Entities.Curso curso = new Business.Entities.Curso(nombre, cupo);
            System.Console.Write("ingrese la comision: ");
            string comision = System.Console.ReadLine();
            bool valCom = Business.Logic.ABMcurso.validarComision(curso, comision);
            if (valCom)
            {
                System.Console.Write("ingrese la materia: ");
                string materia = System.Console.ReadLine();
                bool valMat = Business.Logic.ABMcurso.validarMateria(curso, materia);
                if (valMat)
                {

                    while (opc != 0)
                    {
                        System.Console.Write("ingrese el legajo de un docente: ");
                        string docente = System.Console.ReadLine();
                        bool valDoc = Business.Logic.ABMcurso.validarDocente(curso, docente);
                        if (valDoc) { System.Console.Write("Docente agregado con exito"); }
                        else { System.Console.Write("Docente inexistente"); }
                        System.Console.Write("\n 0/Terminar \n 1/Ingresar otro docente \n opcion:");
                        opc = int.Parse(System.Console.ReadLine());
                        System.Console.Clear();
                    }
                    opc = -1;
                    Business.Logic.ABMcurso.altaCurso(curso);
                    System.Console.Write("Curso agregado con exito");
                    System.Console.ReadKey();
                }
                else { System.Console.Write("Materia inexistente");
                    System.Console.ReadKey();
                }
            }
            else { System.Console.Write("Comision inexistente");
                System.Console.ReadKey();
            }
        }



        override
        protected void listar()
        {
            List<Business.Entities.Curso> cursos = Business.Logic.ABMcurso.listarCursos();
            System.Console.WriteLine("NOMBRE | CUPO | MATERIA | COMISION ");
            foreach (Business.Entities.Curso cur in cursos)
            {
                mostrar(cur);
                System.Console.WriteLine("-----------------------------------------------------------------------------\n");
            }

        }

        private Business.Entities.Curso buscarCurso()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCurso(nombre);
            if (cur != null)
            {
                mostrar(cur);
            }
            else
            {
                System.Console.WriteLine("No se encontro el curso {0}", nombre);
            }
            return cur;
        }

        override protected void buscar()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            Business.Entities.Curso cur = Business.Logic.ABMcurso.buscarCurso(nombre);
            if (cur != null)
            {
                mostrar(cur);
            }
            else
            {
                System.Console.WriteLine("No se encontro el curso {0}", nombre);
            }
        }

        private void mostrar(Business.Entities.Curso cur)
        {
            System.Console.Write("| {0} | ", cur.Nombre);
            System.Console.Write("| {0} | ", cur.Cupo);
            System.Console.Write("| {0} | ", cur.Materia.Nombre);
            System.Console.Write("| {0} | \n ", cur.Comision.NombreComision);
            System.Console.Write("          Docentes:");
            foreach (Business.Entities.Docente doc in cur.Docentes)
            {
                System.Console.Write("          {0} \n", doc.Nombre);
            }


        }
        override
        protected void baja()
        {
            System.Console.Write("ingrese el nombre: ");
            string nombre = System.Console.ReadLine();
            bool borrado = Business.Logic.ABMcurso.borrarCurso(nombre);
            if (!borrado)
            {
                System.Console.WriteLine("No se encontro el curso {0}", nombre);
            }
            else
            {
                System.Console.WriteLine("curso eliminado con exito!!!");
            }
        }

        override
        protected void modi()
        {
            Business.Entities.Curso cur = buscarCurso();
            if (cur != null)
            {
                bool borrado = Business.Logic.ABMcurso.borrarCurso(cur.Nombre);
                if (borrado)
                {
                    alta();
                }
            }
        }
    }
    }
