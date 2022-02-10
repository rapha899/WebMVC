using ModeloDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consola;
namespace TesAprobCredito
{
    public class DBBuilder
    {

        private DBBuilder() { }

        private static TarjetaContex db;

        public static TarjetaContex GetDB()
        {
            if (db == null)
            {
                Carga grabar = new Carga();
                grabar.DatosIni();
                db = TarjetaDbBuilder.Crear();
            }
            return db;
        }
    }
}
