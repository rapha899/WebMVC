using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Registro
    {
        public int  Id { get; set; }
        public string  registroUser { get; set; }

        //Relacion solicitud
        public List<Solicitud> Solicituds { get; set; }
        //


    }
}
