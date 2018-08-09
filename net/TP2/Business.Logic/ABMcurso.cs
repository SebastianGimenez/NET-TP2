using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMcurso
    {
        public static bool validarComision(Business.Entities.Curso cur, string com)
        {
            Business.Entities.Comision comi = ABMcomision.buscarComision(com);
            if (comi != null)
            {
                cur.agregarComision(comi);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool validarMateria(Business.Entities.Curso cur,string mat)
        {
            Business.Entities.Materia mate = ABMmateria.buscarMateria(mat);
            if (mate != null)
            {
                cur.agregarMateria(mate);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool validarDocente(Business.Entities.Curso cur,string doc)
        {
            Business.Entities.Docente doce = ABMdocente.buscarDocente(doc);
            if (doce != null)
            {
                cur.agregarDocente(doce);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void altaCurso(Business.Entities.Curso cur)
        {
                Data.Database.Cursos.getInstance().altaCurso(cur);
          
        }

        public static List<Business.Entities.Curso> listarCursos()
        {
            return Data.Database.Cursos.getInstance().listarCursos();
        }

        public static Business.Entities.Curso buscarCurso(string nombre)
        {
            return Data.Database.Cursos.getInstance().buscarCurso(nombre);
        }

        public static bool borrarCurso(string nombre)
        {
            return Data.Database.Cursos.getInstance().borrarCurso(nombre);
        }

    }
}
