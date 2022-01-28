using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListaTipo
        {
           Usuario,Tarjeta,Solicitud,Deuda,RolPago,RolPagoPublica,Factura,Prerequesito,Calculo
        }
        public Dictionary<ListaTipo, object> Carga()
        {
            //rol de pagos usuario 1
            RolPago rolPago1 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago2 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago3 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago4 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago5 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago6 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago7 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago8 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago9 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago10 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago11 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago12 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            List<RolPago> LstRol = new List<RolPago>() { rolPago1, rolPago2, rolPago3, rolPago4, rolPago5, rolPago6, rolPago7, rolPago8, rolPago9, rolPago10, rolPago11 };
            //prerequsito 1 usuuario rol 
            Prerequisito prerequsitos = new Prerequisito()
            {
                RolPago = rolPago1
            };
            //prerequsito 1 usuuario rol 
            Prerequisito prerequsitos2 = new Prerequisito()
            {
                RolPago = rolPago2
            };
            //prerequsito 1 usuuario rol 
            Prerequisito prerequsitos3 = new Prerequisito()
            {
                RolPago = rolPago3
            };
            //prerequsito 2 usuuario rol 
            Prerequisito prerequsitos4 = new Prerequisito()
            {
                RolPago = rolPago4
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos5 = new Prerequisito()
            {
                RolPago = rolPago5
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos6 = new Prerequisito()
            {
                RolPago = rolPago5
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos7 = new Prerequisito()
            {
                RolPago = rolPago7
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos8 = new Prerequisito()
            {
                RolPago = rolPago8
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos9 = new Prerequisito()
            {
                RolPago = rolPago9
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos10 = new Prerequisito()
            {
                RolPago = rolPago10
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos11 = new Prerequisito()
            {
                RolPago = rolPago11
            };
            //prerequsito 1 usuuario 
            Prerequisito prerequsitos12 = new Prerequisito()
            {
                RolPago = rolPago12
            };


            Usuario usuario = new Usuario()
            {
                Nombre = "Raphael",
                Apellido = "Perez",
                Cedula = 1750269969,
                Email = "jr.perez@itq.edu.ec",

            };
            Usuario usuario2 = new Usuario()
            {
                Nombre = "Jaime",
                Apellido = "Pineda",
                Cedula = 1750269967,
                Email = "jaime78@itq.edu.ec"

            };
            Usuario usuario3 = new Usuario()
            {
                Nombre = "Juan Martin",
                Apellido = "Del Potro",
                Cedula = 1750269968,
                Email = "juanmartin67@itq.edu.ec"

            };
            Usuario usuario4 = new Usuario()
            {
                Nombre = "Rafael",
                Apellido = "Nadal",
                Cedula = 1750269965,
                Email = "rafana@itq.edu.ec",

            };

            List < Usuario> LstUsuario = new List<Usuario>() { usuario , usuario2, usuario3, usuario4 };

            //Creamos una tarjeta
            Tarjeta tarjeta = new Tarjeta()
            {
                NombreTarjeta = "Visa Normal",
            };
            Tarjeta tarjeta1 = new Tarjeta()
            {
                NombreTarjeta = "Visa Platinum"
            };
            Tarjeta tarjeta3 = new Tarjeta()
            {
                NombreTarjeta = "Visa Signature"
            };
            //Lista de Tarjetas
            List<Tarjeta> LstTarjetas = new List<Tarjeta>() { tarjeta, tarjeta1, tarjeta3 };
            Deuda deudas = new Deuda()
            {
                TipoDeuda = "Bancaria",
                CantidadDeuda = 300,
            };
            Deuda deudas1 = new Deuda()
            {
                TipoDeuda = "Prestamo Coperativa",
                CantidadDeuda = 2100,
            };
            // dedudas lista
            List<Deuda> LstDeudas = new List<Deuda>() { deudas1, deudas };
            Solicitud solicitud = new Solicitud()
            {
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022, 1, 18),
                Ingresos = 12400,
                Usuario = usuario,
                Tarjeta = tarjeta
            };
            List<Solicitud> LtsSolicitudes = new List<Solicitud>() {  solicitud};


            Dictionary<ListaTipo, object> dictListasDatos = new Dictionary<ListaTipo, object>()
            {

                { ListaTipo.Usuario , LstUsuario },
                { ListaTipo.Tarjeta , LstTarjetas },
                { ListaTipo.Deuda , LstDeudas },
                { ListaTipo.RolPago , LstRol },
                { ListaTipo.Solicitud , LtsSolicitudes },
            };
            return dictListasDatos;
        }
    }
}
