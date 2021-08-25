using System; 
using System.Collections.Generic;

namespace Bolillero.Core
{
    public class Simulacion
    {
        public long simularSinHilos(Bolillero bolillero, long jugarNVeces, List<byte> jugada)
        {
            return bolillero.jugarNVeces(jugada, jugarNVeces);
        }

        public long simularConHilos(Bolillero bolillero, long jugarNVeces, List<byte> jugada, int CantidadHilos)
        {
            
        }
    }
}