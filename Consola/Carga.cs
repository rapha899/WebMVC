using CargaDatos;
using Clases;
using ModeloDb;
using System.Collections.Generic;
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
            var listaDeudas = (List<Deuda>)listas[ListaTipo.Deuda];
            //Grabar


            using (TarjetaContex db = TarjetaDbBuilder.Crear())
             { 
                // Se asegura que se borre y vuelva a crear la base de datos
                db.PreparaDB();
                // Agrega los listados
                db.Usuarios.AddRange(listaUsuarios);
                db.Tarjetas.AddRange(listaTarjetas);
                db.Solicitudes.AddRange(listaSolicitudes);
                db.Deudas.AddRange(listaDeudas);
                // Guarda todos los datos
                db.SaveChanges();
            }
        }
    }
}
