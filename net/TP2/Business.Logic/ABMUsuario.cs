using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;


namespace Business.Logic
{
    public class ABMUsuario

    {
        public static Usuario login(string usuario,string password) {
            return Data.Database.Usuarios.getInstance().login(usuario,password);
         }

        public static bool altaUsuario(string username,string password,Business.Entities.Usuario usu)
        {
            usu.NombreUsuario = username;
            usu.Contraseña = password;
            return Data.Database.UsuarioDB.getInstance().altaUsuario(usu);
        }
        
        public static bool checkUserNameAndPassword(string username,string password)
        {
            //reglas de negocio de usuario y contraseña aca
            if (username.Length == 0 || password.Length == 0) return false;
            return checkValidUser(username);
        }

        public static bool checkValidUser(string username)
        {
            return !Data.Database.Usuarios.getInstance().userExist(username);
        }
    }
    
}
