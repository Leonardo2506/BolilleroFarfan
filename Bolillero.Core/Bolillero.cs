using System;
using System.Collections.Generic;
using System.Text;

namespace Bolillero.Core
{
    public class Bolillero
    {
        byte Cantidad {get; set;}
        List<byte> Afuera { get; set;}
        List<byte> Adentro {get; set;}
        public Bolillero()
        {
            Afuera = new List<byte>{};
            Adentro = new List<byte>{};
        }
        public Bolillero(byte Cantidad)
        {
            for(byte i=0; i < Cantidad; i++)
            {
                
            }
        }
        public byte IngresarBolilla()
        {
            
        }
        public byte SacarBolilla()
        {

        } 
    }

    
}
