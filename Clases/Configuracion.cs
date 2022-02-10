using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Configuracion
    {
        public int Id { get; set; }

        public float por30 { get; set; }
        public float Ingresos { get; set; }
        public float Deudas{ get; set; }
        public float capa { get; set; }
        // relacion registro 
        public Registro Registro { get; set; }
        public int RegistroId { get; set; }
    }
}
