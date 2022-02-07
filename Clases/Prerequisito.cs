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
        public int TarjetaId { get; set; }
        //Relaciones
        public Usuario Usuario { get; set; }
        public Tarjeta Tarjeta { get; set; }

    }
}
