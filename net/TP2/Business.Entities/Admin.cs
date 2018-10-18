using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Admin : Persona
    {
        const tipoUsuario tipo = tipoUsuario.ADMIN;
        public Admin(string nom, string ape, string legajo, string dni, string email, string telefono) :
            base(tipoUsuario.ADMIN, nom, ape, legajo, dni, email, telefono)
        { }

    }
}
