using CargaDatos;
using Clases;
using ModeloDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIniciales;

namespace Consola
{
    public class Carga
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas
            var listaUsuarios = (List<Usuario>)listas[ListaTipo.Usuario];
            var listaTarjetas = (List<Tarjeta>)listas[ListaTipo.Tarjeta];
            var listaSolicitudes = (List<Solicitud>)listas[ListaTipo.Solicitud];
            //  var listaDeudas = (List<Deuda>)listas[ListaTipo.Deuda];
            //Grabar
            TarjetaContex db = new TarjetaContex();
            db.Usuarios.AddRange(listaUsuarios);
            db.Tarjetas.AddRange(listaTarjetas);
            db.Solicitudes.AddRange(listaSolicitudes);
            // db.Deudas.AddRange(listaDeudas);
            db.SaveChanges();
        }
    }
}
