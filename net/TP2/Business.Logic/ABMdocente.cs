using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMdocente
    {
        public static int altaDocente(Business.Entities.Docente doc)
        {
           return Data.Database.DocenteDB.getInstance().altaDocente(doc);
        }
        public static List<Business.Entities.Docente> listarDocentes()
        {
            return Data.Database.DocenteDB.getInstance().listarDocentes();
        }

        public static Business.Entities.Docente buscarDocente(string legajo)
        {
            return Data.Database.DocenteDB.getInstance().buscarDocente(legajo);
        }

        public static bool borrarDocente(string legajo)
        {
            return Data.Database.DocenteDB.getInstance().borrarDocente(legajo);
        }

        public static bool modi(Business.Entities.Docente doc)
        {
            return Data.Database.DocenteDB.getInstance().modi(doc);
        }
        public static int contarDocentes()
        {
            return listarDocentes().Count;
        }
        public static List<Business.Entities.Docente> listarDocentesPorLegajo(string legajo)
        {
            return Data.Database.DocenteDB.getInstance().listarDocentesPorLegajo(legajo);
        }
        public static Business.Entities.Docente buscarDocentePorId(int id)
        {
            return Data.Database.DocenteDB.getInstance().buscarDocentePorId(id);
        }

    }
}
