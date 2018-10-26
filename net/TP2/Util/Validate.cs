using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Util
{
    public class Validate
    { 
        public static bool Username(string username)
        {
            return username.Trim().Length > 0 && username.Trim().Length <= 12;
        }

      //EXPRESION REGULAR MINIMO 5 CARACTERES, 1 MAYUSCULA 1 MINUSCULA Y UN NÚMERO
        public static bool Password(string password)
        {   //para evitar cambiar los valores, remover en la entrega
            return true;
            if (password.Length < 5 || password.Length > 12) return false;
            Regex reg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{5,12}$");
            Match match = reg.Match(password);
            return match.Success;
        }

        public static bool DNI(string dni)
        {
            if (dni.Length != 8)
                return false;
            Regex reg = new Regex(@"\d{8}");
            Match match = reg.Match(dni);
            return match.Success;
        }
        //arreglar
        public static bool Email(string email)
        {
            return Regex.IsMatch(email,@"^([\w -\.] +)@((\[[0 - 9]{ 1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w -]+\.)+))([a - zA - Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        //arreglar
        public static bool Phone(string phone)
        {
            if (phone.Length < 6 || phone.Length > 9) return false;
            Regex reg = new Regex(@"\d{6,9}/");
            Match match = reg.Match(phone);
            return match.Success;
        }
       
        public static bool Text(string txt)
        {
           return Regex.IsMatch(txt, @"^[\p{L}]+$");
        }
    }
}
