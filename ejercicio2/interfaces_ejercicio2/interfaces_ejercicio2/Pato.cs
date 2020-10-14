using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_ejercicio2
{
    class Pato:Animal,IVolador
    {
        int energia = 100;
        public void volador()
        {
            Console.WriteLine("Pato: Estoy volando como un pato...¡Cuack!");
            energia -= 5;
        }
    

   

    }
}
