using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Alumno: Persona
    { const tipoUsuario tipo = tipoUsuario.ALUMNO;
        public Alumno(string nom, string ape, string legajo, string dni, string email, string telefono) :
            base(tipoUsuario.ALUMNO, nom, ape, legajo, dni, email, telefono)
        { }
        
       
    }
}
