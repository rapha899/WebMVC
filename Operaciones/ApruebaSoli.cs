﻿using Clases;
using Microsoft.EntityFrameworkCore;
using ModeloDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class ApruebaSoli
    {
        public TarjetaContex db { get; set; }

        public ApruebaSoli(TarjetaContex db)
        {
            this.db = db;
        }
        public bool Aprobo(Usuario usuario, Solicitud solicitud) {
            var tmpUsuario = db.Usuarios
                    .Include(soli => soli.Solicitudes)
                    .ThenInclude(det => det.SolicitudDets)
                    .ThenInclude(deuda => deuda.Deuda)
                    .Include(soli => soli.Solicitudes)
                    .ThenInclude(det => det.SolicitudDets)
                    .ThenInclude(t => t.Tarjeta)
                    .Include(solidets => solidets.SolicitudDets)
                    .Single(user => user.Id == usuario.Id);
            // si no tiene solicitudes
            if (tmpUsuario == null)  return false;
            //Preparar Clase por
            var config = db.Configuracions.Single();
            var calc = new PorPor(config);

            //busco solicitud 
            foreach (var soli in tmpUsuario.Solicitudes) {
                foreach (var det in soli.SolicitudDets)
                {
                    if (det.Solicitud.id == solicitud.id)
                    {
                        // si no tiene ingresos reprobo la solicitud
                        if (calc.Aprobado(det.PorcentajeEndeudamiento))
                        {
                            return true;
                        }
                    }
                }
                }
            return false;
        }

    }
}

