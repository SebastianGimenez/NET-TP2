using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Especialidades
    {
        private List<Business.Entities.Especialidad> especialidades;
        private static Especialidades _instance = null;

        public static Especialidades getInstance()
        {
            if (Especialidades._instance == null)
            {
                Especialidades._instance = new Especialidades();
            }
            return Especialidades._instance;
        }

        Especialidades()
        {
            especialidades = new List<Business.Entities.Especialidad>();
        }

        public void altaEspecialidad(Business.Entities.Especialidad esp)
        {
            this.especialidades.Add(esp);
        }

        public List<Business.Entities.Especialidad> listarEspecialidades()
        {
            return this.especialidades;
        }

        public Business.Entities.Especialidad buscarEspecialidad(string nombre)
        {

            foreach (Business.Entities.Especialidad esp in this.especialidades)
            {
                if (esp.NombreEspecialidad == nombre)
                {
                    return esp;
                }
            }
            return null;
        }

        public bool borrarEspecialidad(string nombre)
        {
            Business.Entities.Especialidad esp = buscarEspecialidad(nombre);
            if (esp == null) return false;

            return this.especialidades.Remove(esp);
        }
    }
}
