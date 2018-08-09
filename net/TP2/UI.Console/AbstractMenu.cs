using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    public abstract class AbstractMenu
    {
        private string nombremenu;

        private int opc = -1;
        public void submenu()
        {
            while (opc != 0)
            {
                System.Console.Clear();
                System.Console.WriteLine("Bienvenido al abm de {0}", nombremenu);
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
                            System.Console.Clear();
                            alta();
                            break;
                        case 2:
                            System.Console.Clear();
                            baja();
                            System.Console.ReadKey();
                            break;
                        case 3:
                            System.Console.Clear();
                            modi();
                            System.Console.ReadKey();
                            break;
                        case 4:
                            System.Console.Clear();
                            buscar();
                            System.Console.ReadKey();
                            break;
                        case 5:
                            System.Console.Clear();
                            listar();
                            System.Console.ReadKey();
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

        protected abstract void alta();
        protected abstract void baja();
        protected abstract void modi();
        protected abstract void listar();
        protected abstract void buscar();

       public AbstractMenu(string nombremenu)
        {
            this.nombremenu = nombremenu;
            submenu();
        }

        private string opciones()
        {
            return "0-> Volver\n" +
                "1-> Alta " + nombremenu + "\n" +
                "2-> Baja " + nombremenu + "\n" +
                "3-> Modificacion " + nombremenu + "\n" +
                "4-> Busqueda " + nombremenu + "\n" +
                "5-> Listar " + nombremenu + "\n";
        }
    }
}
