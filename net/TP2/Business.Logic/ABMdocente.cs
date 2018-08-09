using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMdocente
    {
        public static void altaDocente(Business.Entities.Docente doc)
        {
            Data.Database.Docentes.getInstance().altaDocente(doc);
        }
        public static List<Business.Entities.Docente> listarDocentes()
        {
            return Data.Database.Docentes.getInstance().listarDocentes();
        }

        public static Business.Entities.Docente buscarDocente(string legajo)
        {
            return Data.Database.Docentes.getInstance().buscarDocente(legajo);
        }

        public static bool borrarDocente(string legajo)
        {
            return Data.Database.Docentes.getInstance().borrarDocente(legajo);
        }

        public static int contarDocentes()
        {
            return listarDocentes().Count;
        }
    }
}
