using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Prerequisito
    {
        public int UsuarioId { get; set; }
        public int RolPagoId { get; set; }
        public int RolPagoPublicaId { get; set; }
        public int FacturaId { get; set; }
        //Relaciones
        public Usuario Usuario { get; set; }
        public RolPago RolPago { get; set; }
        public RolPagoPublica RolPagosPublica { get; set; }
        public Factura Factura { get; set; }
    }
}
