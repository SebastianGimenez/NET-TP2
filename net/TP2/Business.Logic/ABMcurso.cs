using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMcurso
    {
    

        public static bool altaCurso(Business.Entities.Curso cur)
        {
                return Data.Database.CursoDB.getInstance().altaCurso(cur);
          
        }

        public static List<Business.Entities.Curso> listarCursos()
        {
            return Data.Database.CursoDB.getInstance().listarCursos();
        }

        public static List<Business.Entities.Curso> listarCursosPorNombre(string nombre)
        {
            return Data.Database.CursoDB.getInstance().listarCursosPorNombre(nombre);
        }

        public static int buscarComisionCurso(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarComisionCurso(idCurso);
        }

        public static int buscarMateriaCurso(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarMateriaCurso(idCurso);
        }

        public static Business.Entities.Curso buscarCurso(string nombre)
        {
            return Data.Database.Cursos.getInstance().buscarCurso(nombre);
        }

        public static bool borrarCurso(int id)
        {
            return Data.Database.CursoDB.getInstance().borrarCurso(id);
        }
        public static bool modificarCurso(Business.Entities.Curso curso)
        {
            return Data.Database.CursoDB.getInstance().modificarCurso(curso);
        }
        public static List<int> buscarDocentes(int idCurso)
        {
            return Data.Database.CursoDB.getInstance().buscarDocentes(idCurso);
        }
        public static bool agregarDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            //validar que ya no exista docente curso
            return Data.Database.CursoDB.getInstance().agregarDocenteCurso(doc, cur);
        }
        public static bool borrarDocenteCurso(Business.Entities.Docente doc, Business.Entities.Curso cur)
        {
            //validar que ya no exista docente curso
            return Data.Database.CursoDB.getInstance().borrarDocenteCurso(doc, cur);
        }
    }
}
