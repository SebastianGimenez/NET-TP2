using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    [Serializable]
    public class Plan
    {
        string nombrePlan;
        string descripcionPlan;
        int idPlan;
        Especialidad especialidad;

        public Plan() { }

        public int IdPlan {
            set { this.idPlan = value; }
            get { return this.idPlan; }
        }

       public override string ToString()
        {
           return this.nombrePlan;
        }
       
        public Plan(string nombre, string desc)
        {
            this.nombrePlan = nombre;
            this.descripcionPlan = desc;
        }

        public void agregarEspecialidad(Business.Entities.Especialidad esp)
        {
            this.especialidad = esp;
        }

     

        public string NombrePlan
        {
            get {return this.nombrePlan; }
            set { this.nombrePlan = value; }
        }


        public string DescripcionPlan
        {
            get { return this.descripcionPlan; }
            set { this.descripcionPlan = value; }
        }

        public Especialidad Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }
    }
}
