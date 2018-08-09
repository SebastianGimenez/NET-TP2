using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    class Login
    {
        private int opc = -1;
        public void submenu()
        {
            while (opc != 0)
            {
                System.Console.Clear();
                System.Console.WriteLine("Bienvenido al login de usuario");
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
                            ingresar();
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

        private void ingresar() {
            System.Console.Write("ingrese nombre de usuario: ");
            string usuario = System.Console.ReadLine();
            System.Console.Write("ingrese el contraseña: ");
            string contraseña = System.Console.ReadLine();
            Business.Entities.Usuario usu = Business.Logic.ABMUsuario.login(usuario, contraseña);
            if (usu != null)
            {
                if (usu.GetType() == typeof(Business.Entities.Alumno))
                {
                    new ABMalumno().submenu();
                }//else if(usu.GetType == typeof(Business.Entities.Docente))
                 //{

                //}   
            }
            else {
                System.Console.WriteLine("Nombre de usuario y/o contraseña incorrectos");
                System.Console.ReadKey();
            }
        }

        private string opciones()
        {
            return "0-> Volver\n" +
                "1-> Ingresar\n";
               
        }
    }
}
