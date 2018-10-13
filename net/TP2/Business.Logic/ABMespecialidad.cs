﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMespecialidad
    {
        public static bool altaEspecialidad(Business.Entities.Especialidad esp)
        {
            return Data.Database.EspecialidadDB.getInstance().altaEspecialidad(esp);
        }
        public static List<Business.Entities.Especialidad> listarEspecialidades()
        {
            return Data.Database.EspecialidadDB.getInstance().listarEspecialidades();
        }
        public static List<Business.Entities.Especialidad> listarEspecialidadesPorNombre(String nombre)
        {
            return Data.Database.EspecialidadDB.getInstance().listarEspecialidadesPorNombre(nombre);
        }

        public static int contarEspecialidades()
        {
            return listarEspecialidades().Count;
        }

        public static bool modificarEspecialidad(Business.Entities.Especialidad esp)
        {
            return Data.Database.EspecialidadDB.getInstance().modificarEspecialidad(esp);
        }

        public static Business.Entities.Especialidad buscarEspecialidad(string nombre)
        {
            return Data.Database.Especialidades.getInstance().buscarEspecialidad(nombre);
        }

        public static bool borrarEspecialidad(int id)
        {
            return Data.Database.EspecialidadDB.getInstance().borrarEspecialidad(id);
        }
    }
}
