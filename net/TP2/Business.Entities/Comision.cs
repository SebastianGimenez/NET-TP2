using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision
    {
        string nombreComision;
        string aula;

        public override string ToString()
        {
            return this.nombreComision;
        }
        public Comision(string nombre, string aula)
        {
            this.nombreComision = nombre;
            this.aula = aula;
        }


        public string NombreComision
        {
            get { return this.nombreComision; }
            set { this.nombreComision = value; }
        }


        public string Aula
        {
            get { return this.aula; }
            set { this.aula = value; }
        }


    }
}
