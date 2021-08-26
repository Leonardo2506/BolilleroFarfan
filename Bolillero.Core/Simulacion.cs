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
            var vector = new Task<long>[CantidadHilos]; 

            for(long i=0; i < jugarNVeces; i++)
            {
                Bolillero.Clone();

                CantidadHilos = CantidadHilos + 1; 
                
            }

            
            return 0; 
        }
    }
}