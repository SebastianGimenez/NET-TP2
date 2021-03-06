using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;


namespace Business.Logic
{
    public class ABMUsuario

    {
        public static Persona login(string usuario,string password)
        {
            return Data.Database.UsuarioDB.getInstance().login(usuario,password);
        }

        public static bool altaUsuario(string username,string password,Business.Entities.Usuario usu)
        {
            usu.NombreUsuario = username;
            usu.Contraseņa = password;
            return Data.Database.UsuarioDB.getInstance().altaUsuario(usu);
        }
        
        public static int checkUserNameAndPassword(string username,string password)
        {
            return Data.Database.UsuarioDB.getInstance().validarUsuarioContraseņa(username,password);
        }

        public static bool validarUsuario(string nombreUsuario)
        {
            return Data.Database.
                UsuarioDB.getInstance().validarUsuario(nombreUsuario);
        }
        public static int buscarIdpersonaPorUsuario(string NombreUsuario)
        {
            return Data.Database.UsuarioDB.getInstance().buscarIdpersonaPorUsuario(NombreUsuario);
        }
    }

    
}
