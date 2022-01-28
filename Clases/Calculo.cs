using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calculo
    {
        public int id { get; set; }
        public float calculo { get; set; }

        public float rol12 { get; set; }

        public float Factur36 { get; set; }
        public float rol24 { get; set; }

        //RELACIONES
        public RolPago rolPago { get; set; }
        public Factura Facturas { get; set; }
        public RolPagoPublica rolPagosPublica { get; set; }
    }
}
