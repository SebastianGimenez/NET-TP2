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
            Business.Entities.Docente docente = buscarDocente(doc.Legajo);
            if (docente == null)
            {
                return Data.Database.DocenteDB.getInstance().altaDocente(doc);
            }
            return -1;
          
        }

        public static List<Business.Entities.Docente> listarDocentes()
        {
            return Data.Database.DocenteDB.getInstance().listarDocentes();
        }

        public static List<int> listarCursosDocente(int idDocente)
        {
            return Data.Database.DocenteDB.getInstance().listarCursosDocente(idDocente);
        }

        public static Business.Entities.Docente buscarDocente(string legajo)
        {
            return Data.Database.DocenteDB.getInstance().buscarDocente(legajo);
        }

        public static bool borrarDocente(string legajo)
        {
            Business.Entities.Docente docente = buscarDocente(legajo);
            if (docente!= null)
            {
                return Data.Database.DocenteDB.getInstance().borrarDocente(legajo);
            }
            return false;
            
        }

        public static bool modi(Business.Entities.Docente doc)
        {
            int idP = ABMUsuario.buscarIdpersonaPorUsuario(doc.NombreUsuario);
            if (idP == 0 || idP == doc.IDPersona)
            {
                Business.Entities.Docente docente = buscarDocente(doc.Legajo);
                if (docente == null || docente.IDPersona == doc.IDPersona)
                {
                    return Data.Database.DocenteDB.getInstance().modi(doc);
                }
            }
            return false;
            
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
