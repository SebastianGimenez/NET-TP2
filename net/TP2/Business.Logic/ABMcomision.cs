using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ABMcomision
    {
        public static bool altaComision(Business.Entities.Comision com)
        {
               return Data.Database.ComisionDB.getInstance().altaComision(com);
        }
        public static List<Business.Entities.Comision> listarComisiones()
        {
            return Data.Database.ComisionDB.getInstance().listarComisiones();
        }
        public static List<Business.Entities.Comision> listarComisionesPorNombre(string nombre)
        {
            return Data.Database.ComisionDB.getInstance().listarComisionesPorNombre(nombre);
        }

        public static Business.Entities.Comision buscarComision(string nombre)
        {
            return Data.Database.Comisiones.getInstance().buscarComision(nombre);
        }

        public static bool borrarComision(int idCom)
        {
            return Data.Database.ComisionDB.getInstance().borrarComision(idCom);
        }
        public static Business.Entities.Comision buscarComisionPorId(int id)
        {
            return Data.Database.ComisionDB.getInstance().buscarComisionPorId(id);
        }
        public static bool modificarComision(Business.Entities.Comision com)
        {
            return Data.Database.ComisionDB.getInstance().modificarComision(com);
        }
        public static int contarComisiones()
        {
            return listarComisiones().Count;
        }
    }
}
