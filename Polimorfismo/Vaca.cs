using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Polimorfismo
{
    public class Vaca : Animal2
    {
        public override void Comer()
        {
            Console.WriteLine("La vaca come pasto");
        }
    }
}
