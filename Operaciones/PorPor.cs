using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class PorPor
    {
        public float i { get; set; }
        public float d { get; set; }
        public float p { get; set; }

        public float c { get; set; }
        public PorPor(Configuracion configuracion) {
            this.i = configuracion.Ingresos;
            this.d = configuracion.Deudas;
            this.p = configuracion.por30;
            this.c = configuracion.capa;
        }

        public float CalculoFinal (PorcentajeEndeudamiento porcentaje)
        {
            float respuesta;
         respuesta=(porcentaje.Ingresos - porcentaje.DeudaMonto) * porcentaje.por30;
         respuesta = MathF.Round (respuesta , 2);
            return respuesta;
        }

        public bool Aprobado(PorcentajeEndeudamiento porcentaje) { 
                 return CalculoFinal(porcentaje) >= c;
        
        }
    }
}
