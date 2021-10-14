using System; 
using System.Linq;
using System.Threading.Tasks;
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
            
            var vector = ConfigurarVectorTareas(bolillero, jugarNVeces, jugada, CantidadHilos);

            Task<long>.WaitAll(vector);
            
            return vector.Sum(t => t.Result); 
        }

        public async Task<long> simularConHilosAsync(Bolillero bolillero, long jugarNVeces, List<byte> jugada, int CantidadHilos)
        {
            var vector = ConfigurarVectorTareas(bolillero, jugarNVeces, jugada, CantidadHilos);
            await Task.WhenAll(vector);

            return vector.Sum(t => t.Result); 
        }

        private Task<long>[] ConfigurarVectorTareas(Bolillero bolillero, long jugarNVeces, List<byte> jugada, int CantidadHilos)
        {
            var vector = new Task<long>[CantidadHilos]; 

            long simulacionPorHilos = jugarNVeces/CantidadHilos;

            for(int i=0; i < CantidadHilos; i++)
            {
                var clone = (Bolillero)bolillero.Clone();  
                
                vector[i] = Task<long>.Run(() => clone.jugarNVeces(jugada, simulacionPorHilos)); 
            }   
            
            return vector; 
        }
    }
}