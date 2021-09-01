using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bolillero.Core;
using System.Collections.Generic;

namespace Bolillero.Test
{
    [TestClass]
    public class SimulacionTest
    {
        Simulacion Simulacion {get; set;}
        
        [TestMethod]
        public void SimultaneidadConTask()
        {
            /* Crear un bolillero de 10 bolillas y hacer un millon de simulacion sin hilos y otro con cuatro hilos 
            */
            var bolillero = new Bolillero.Core.Bolillero(10);

            Simulacion = new Simulacion();

            var jugada  = new List<byte>{5};

            long cantidadVeces = 24000000;
            double esperado = cantidadVeces/10;
            var ganadasSinHilos = Simulacion.simularSinHilos(bolillero, cantidadVeces, jugada);

            var ganadasConHilos = Simulacion.simularConHilos(bolillero, cantidadVeces, jugada, 8);

            Assert.AreEqual(ganadasConHilos/esperado, ganadasSinHilos/esperado, 0.1);
        }
    }
}