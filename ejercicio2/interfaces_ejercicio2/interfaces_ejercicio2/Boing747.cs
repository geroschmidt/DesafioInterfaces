using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_ejercicio2
{
    class Boing747:Aviones,IVolador
    {
        int horasDeVuelo=0;
        public void volador()
        {
            Console.WriteLine("Boing747: Estoy volando como un avion...");
            horasDeVuelo += 13;
        }
    }
}
