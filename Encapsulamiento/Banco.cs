using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Encapsulamiento
{
    public class Banco
    {
        private decimal saldo;
        
       public void IngresoDinero(decimal ingreso)
        {
            if (ingreso > 0)
            {
                saldo += ingreso;
                Console.WriteLine("El ingreso fue exitoso");
            }
            else
            {
                Console.WriteLine("Debe ingresar un monto mayor a 0");
            }
        }

        public void Retirar (decimal retiro)
        {
            if (retiro > 0 && saldo >= retiro)
            {
                saldo -= retiro;
                Console.WriteLine("Retiro exitoso");
            }
            else
            {
                Console.WriteLine("La cantidad de debe ser mayor a cero o no tiene fondos suficientes");
            }
        }

    }
}
