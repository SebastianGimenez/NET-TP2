using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMespecialidad
    {
        public static void altaEspecialidad(Business.Entities.Especialidad esp)
        {
            Data.Database.Especialidades.getInstance().altaEspecialidad(esp);
        }
        public static List<Business.Entities.Especialidad> listarEspecialidades()
        {
            return Data.Database.Especialidades.getInstance().listarEspecialidades();
        }

        public static int contarEspecialidades()
        {
            return listarEspecialidades().Count;
        }

        public static Business.Entities.Especialidad buscarEspecialidad(string nombre)
        {
            return Data.Database.Especialidades.getInstance().buscarEspecialidad(nombre);
        }

        public static bool borrarEspecialidad(string nombre)
        {
            return Data.Database.Especialidades.getInstance().borrarEspecialidad(nombre);
        }
    }
}
