using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Docente : Persona
    {
        const tipoUsuario tipo = tipoUsuario.DOCENTE;
        public Docente(string nom, string ape, string legajo, string dni, string email, string telefono) :
            base(tipoUsuario.DOCENTE, nom, ape, legajo, dni, email, telefono)
        { }
        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
