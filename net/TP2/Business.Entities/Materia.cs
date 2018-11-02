using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    [Serializable]
    public class Materia
    {
        int idMateria;
        string nombre;
        string descripcion;
        int horasSemanales;
        int horasTotales;
        Plan plan;

        public Materia() { }

        public override string ToString()
        {
            return this.nombre;
        }
        public Materia(string nombre, string descripcion, int horasSemanales, int horasTotales) {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.horasSemanales = horasSemanales;
            this.horasTotales = horasTotales;
        }

        public string NombreMateria
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

       

        public int IdMateria
        {
            get { return this.idMateria; }
            set { this.idMateria = value; }
        }


        public string Nombre
        {
            get { return this.nombre;}
            set { this.nombre = value;}
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public int HorasSemanales
        {
            get { return this.horasSemanales; }
            set { this.horasSemanales = value; }
        }

        public int HorasTotales
        {
            get { return this.horasTotales; }
            set { this.horasTotales = value; }
        }

        public Plan Plan
        {
            get {return this.plan; }
            set { this.plan = value; }
        }

        public void agregarPlan(Plan plan)
        {
            this.plan = plan;
        }

    }
}
