using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Docentes
    {
        private List<Business.Entities.Docente> docentes;
        private static Docentes _instance = null;

        public static Docentes getInstance()
        {
            if (Docentes._instance == null)
            {
                Docentes._instance = new Docentes();
            }
            return Docentes._instance;
        }

        Docentes()
        {
            docentes = new List<Business.Entities.Docente>();
        }

        public void altaDocente(Business.Entities.Docente doc)
        {
            this.docentes.Add(doc);
        }

        public List<Business.Entities.Docente> listarDocentes()
        {
            return this.docentes;
        }

        public Business.Entities.Docente buscarDocente(string legajo)
        {

            foreach (Business.Entities.Docente doc in this.docentes)
            {
                if (doc.Legajo == legajo)
                {
                    return doc;
                }
            }
            return null;
        }

        public bool borrarDocente(string legajo)
        {
            Business.Entities.Docente doc = buscarDocente(legajo);
            if (doc == null) return false;

            return this.docentes.Remove(doc);
        }
    }
}
