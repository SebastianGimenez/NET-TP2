using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    [Serializable]
    public class Comision
    {
        string nombreComision;
        string aula;
        int idComision;
        public Comision() { }
        public override string ToString()
        {
            return this.nombreComision;
        }
        public Comision(string nombre, string aula)
        {
            this.nombreComision = nombre;
            this.aula = aula;
        }

        public int IdComision
        {
            get { return this.idComision; }
            set { this.idComision = value; }
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
