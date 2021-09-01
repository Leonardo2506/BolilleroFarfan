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

            long cantidadVeces = 1000000;

            var ganadasSinHilos = Simulacion.simularSinHilos(bolillero, cantidadVeces, jugada);

            var ganadasConHilos = Simulacion.simularConHilos(bolillero, cantidadVeces, jugada, 4);

            Assert.AreEqual(ganadasConHilos/100.0, ganadasSinHilos/100.0, 0.05);
        }
    }
}