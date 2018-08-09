using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.Database.Conexion cn = new Data.Database.Conexion();
            System.Console.ReadKey();
            int opc = -1;
            while(opc != 0)
            {
                System.Console.Clear();
                System.Console.WriteLine("========MENU========");
                System.Console.Write(opciones());
                System.Console.Write("Ingrese una opcion: ");
                try
                {
                    opc = int.Parse(System.Console.ReadLine());
                    switch (opc)
                    {
                        case 0:
                            break;
                        case 1:
                               //new ABMUsuario().submenu();
                            new ABMalumno();
                            break;
                        case 2:
                            new ABMdocente();
                            
                            break;
                        case 3:
                            new ABMespecialidad();

                            break;
                        case 4:
                            new ABMplan();

                            break;
                        case 5:
                            new ABMUsuario();
                            break;
                        case 6:
                            new ABMmateria();
                            break;
                        case 7:
                            new ABMCurso();
                            break;
                        case 8:
                            new ABMcomision();
                            break;
                        default:
                            System.Console.WriteLine("No existe esa opcion");
                            System.Console.ReadKey();
                            break;
                    }

                }
                catch (FormatException e)
                {
                    System.Console.WriteLine("Te dije un numero");
                    System.Console.ReadKey();

                }
            }
         
        }

        private static string opciones()
        {
            return "0-> Cerrar\n" +
                "1-> ABM ALUMNO \n" +
                "2-> ABM DOCENTE \n"+
                "3-> ABM ESPECIALIDAD \n"+
                "4-> ABM PLAN \n" + 
                "5-> ABM USUARIO\n" +
                "6-> ABM MATERIA\n" + 
                "7-> ABM CURSO  \n" + 
                "8-> ABM COMISION \n";
        }
    }
}
