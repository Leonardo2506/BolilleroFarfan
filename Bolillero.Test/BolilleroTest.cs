using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bolillero.Core;
using System.Collections.Generic;

namespace Bolillero.Test
{
    [TestClass]
    public class BolilleroTest
    {
        Bolillero.Core.Bolillero bolillero {get; set;}

        [TestMethod]  
        public void CantidadBolillasAlSacar()
        {
           bolillero = new Bolillero.Core.Bolillero(10);
           
           bolillero.SacarBolilla();

           Assert.AreEqual(1, bolillero.CantidadAfuera);

           Assert.AreEqual(9, bolillero.CantidadAdentro); 
        }

        [TestMethod]  
        public void Probabilidad()
        {
           bolillero = new Bolillero.Core.Bolillero(5);

           var jugadaFacil = new List<byte>(){2};

           var ganadas = bolillero.jugarNVeces(jugadaFacil, 100);

           Assert.AreEqual(0.2, ganadas/100.0, 0.05); 
        }
    }
}
