using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Solicitud
    {
        public int id { get; set; }
        public int Ingresos { get; set; }
        public string NombreEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public DateTime FechaSolicitud { get; set; }
        //usurio
        public int Usuarioid { get; set; }
        public Usuario Usuario { get; set; }
        //tarjeta
        public int Tarjetaid { get; set; }
        public Tarjeta Tarjeta { get; set;}
        //deuda
        public ICollection<Deuda> Deudas { get; set; }
    }
}
