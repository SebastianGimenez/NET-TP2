using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMcomision
    {
        public static void altaComision(Business.Entities.Comision com)
        {
                Data.Database.Comisiones.getInstance().altaComision(com);
        }
        public static List<Business.Entities.Comision> listarComisiones()
        {
            return Data.Database.Comisiones.getInstance().listarComisiones();
        }

        public static Business.Entities.Comision buscarComision(string nombre)
        {
            return Data.Database.Comisiones.getInstance().buscarComision(nombre);
        }

        public static bool borrarComision(string nombre)
        {
            return Data.Database.Comisiones.getInstance().borrarComision(nombre);
        }

        public static int contarComisiones()
        {
            return listarComisiones().Count;
        }
    }
}
