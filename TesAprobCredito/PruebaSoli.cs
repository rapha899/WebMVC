using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Operaciones;
using Clases;
using Microsoft.EntityFrameworkCore;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace TesAprobCredito
{
    public class PruebaSoli
    {
        [Theory]
        [InlineData(1, 7409.84f)]
        public void AproSoli(int id , float resultadoesperado) {
            float rescalc;
            var db = DBBuilder.GetDB();
            var  porcneta = db.porcentajeEndeudamientos.Find(id);

            var config = new Configuracion() {
                Ingresos = 25000.35f,
                Deudas = 300.89f,
                por30 = 0.30f,
                capa = 700.00f
            };

            var Calc = new PorPor(config);
            rescalc = Calc.CalculoFinal(porcneta);
            Assert.True(resultadoesperado == rescalc);

        }
    }
}
