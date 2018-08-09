using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{   
    public class Usuarios
    {
        private List<Business.Entities.Usuario> usuarios;
        private static Usuarios _instance = null;

        public static Usuarios getInstance()
        {
            if(Usuarios._instance == null)
            {
                Usuarios._instance = new Usuarios();
            }
            return Usuarios._instance;
        }

        Usuarios()
        {
            usuarios = new List<Business.Entities.Usuario>();
        }

        public bool userExist(string username) {
            foreach (Business.Entities.Usuario u in usuarios)
            {
                if (u.NombreUsuario == username)
                    return true;
            }
            return false;
        }

        public bool altaUsuario(Business.Entities.Usuario usu)
        {   //esto se soluciona con la db luego
            if (userExist(usu.NombreUsuario))
            {
                return false;
            }
            //lo agrego a la lista de alumnos
            if(usu.GetType() == typeof(Business.Entities.Alumno))
            {
                Alumnos.getInstance().altaAlumno((Business.Entities.Alumno)usu);
            }
            //lo agrego a la lista de usuarios
            this.usuarios.Add(usu);
            return true;
        }
		
        public Business.Entities.Usuario login(string usuario,string password)
        {
           
            foreach(Business.Entities.Usuario usu in this.usuarios)
            {
                if(usu.NombreUsuario == usuario)
                {

                    if (usu.Contraseña == password)
						switch(usu.TipoUsuario){
							case Business.Entities.tipoUsuario.ALUMNO:
                                Business.Entities.Alumno al = (Business.Entities.Alumno)usu;
								return new Business.Entities.Alumno(al.Nombre,al.Apellido, al.Legajo, al.Dni, al.Email, al.Telefono);
							
							case Business.Entities.tipoUsuario.DOCENTE:
								//return new Business.Entities.Docente(usu.Nombre,usu.Apellido, usu.Legajo, usu.Dni, usu.Email, usu.Telefono);
							break;
							default:
							break;
						}
						
                }
            }
            return null;
        }

       

    }
}
