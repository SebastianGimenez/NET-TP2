using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidad
    {
        string nombreEspecialidad;
        string descripcionEspecialidad;

        public override string ToString()
        {
            return this.nombreEspecialidad;
        }
        public Especialidad(string nombre, string desc)
        {
            this.nombreEspecialidad = nombre;
            this.descripcionEspecialidad = desc;
        }

       
        public string NombreEspecialidad
        {
            get { return this.nombreEspecialidad; }
            set { this.nombreEspecialidad = value; }
        }


        public string Descripcion
        {
            get { return this.descripcionEspecialidad; }
            set { this.descripcionEspecialidad = value; }
        }
    }
}
