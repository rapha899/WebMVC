using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PorcentajeEndeudamiento
    {
        public int id { get; set; } 
        public float por30 { get; set; }
        public float Ingresos { get; set; }
        public float DeudaMonto { get; set; }
        // Relación Uno a Uno
        public int SolId { get; set; }
        public solicitudDet solicitudDet { get; set; }
        public float Capacidad(float d, float i, float por)
        {
            float suma = 0;
            suma = (i - d) * por;
            suma = MathF.Round(suma, 2);
            return suma;

        }

        public bool Aprueba(float d, float i, float por , float tarj) {
            bool res;
            res = (i - d) * por >= tarj;
            return res;
        }


    }

   

}
