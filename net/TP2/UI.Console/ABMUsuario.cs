using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    public class ABMUsuario : AbstractMenu
    {

        public ABMUsuario() : base("usuario") { }

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
            bool valid = true;
            string username = "";
            string password = "";
            do
            {
                System.Console.Clear();
                if (!valid)
                    System.Console.WriteLine("Nombre de usuario ya utilizado o invalido");
                System.Console.Write("Ingrese un nombre de usuario : ");
                 username = System.Console.ReadLine();
                System.Console.Write("Ingrese una contraseña: ");
                 password = System.Console.ReadLine();
                valid = Business.Logic.ABMUsuario.checkUserNameAndPassword(username, password);
            } while (valid == false);
            Business.Logic.ABMUsuario.altaUsuario(username, password, al);
           }

        protected override void baja()
        {
            throw new NotImplementedException();
        }

        protected override void buscar()
        {
            throw new NotImplementedException();
        }

        protected override void listar()
        {
            throw new NotImplementedException();
        }

        protected override void modi()
        {
            throw new NotImplementedException();
        }
    }
}
