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
        {
            Regex reg = new Regex(@"^ (?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 5, 12 }$");
            Match match = reg.Match(password);
            return match.Success;
        }
    }
}
