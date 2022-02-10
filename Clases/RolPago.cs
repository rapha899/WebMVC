﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class RolPago
    {
        public int id { get; set; }
        public int rolPago { get; set; }
        public string nombreEmpresa { get; set; }
        public float monto { get; set; }
        public DateTime FechaRol { get; set; }
        //

        //Relaciones 
        public List<Solicitud> Solicitudes { get; set; }



    }


}