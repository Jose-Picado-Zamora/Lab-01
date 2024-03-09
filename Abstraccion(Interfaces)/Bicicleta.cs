using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Abstraccion_Interfaces_
{
    public class Bicicleta : IBicicleta
    {
        public void Avanzar()
        {
            Console.WriteLine("La bicicleta avanza al darle pedal");
        }

        public void Detenerse()
        {
            Console.WriteLine("La bicicleta se detiene"); 
        }
    }
}
