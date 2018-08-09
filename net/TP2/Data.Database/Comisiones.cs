using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class Comisiones
    {
        private List<Business.Entities.Comision> comisiones;
        private static Comisiones _instance = null;

        public static Comisiones getInstance()
        {
            if (Comisiones._instance == null)
            {
                Comisiones._instance = new Comisiones();
            }
            return Comisiones._instance;
        }

        Comisiones()
        {
            comisiones = new List<Business.Entities.Comision>();
        }

        public void altaComision(Business.Entities.Comision com)
        {
            this.comisiones.Add(com);
        }

        public List<Business.Entities.Comision> listarComisiones()
        {
            return this.comisiones;
        }

        public Business.Entities.Comision buscarComision(string nombre)
        {

            foreach (Business.Entities.Comision com in this.comisiones)
            {
                if (com.NombreComision == nombre)
                {
                    return com;
                }
            }
            return null;
        }

        public bool borrarComision(string nombre)
        {
            Business.Entities.Comision com = buscarComision(nombre);
            if (com == null) return false;

            return this.comisiones.Remove(com);
        }
    }
}
