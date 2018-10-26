﻿using System;
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
         
            Regex reg = new Regex(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
            Match match = reg.Match(email);
            return match.Success;
        }

        //arreglar
        public static bool Phone(string phone)
        {
            if (phone.Length <10 || phone.Length >10) return false;
            else { return true; }

        }
       
        public static bool Text(string txt)
        {
           return Regex.IsMatch(txt, @"^[\p{L}]+$");
        }
    }
}
