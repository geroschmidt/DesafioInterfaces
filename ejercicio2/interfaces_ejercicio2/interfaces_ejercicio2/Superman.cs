using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_ejercicio2
{
    class Superman:SuperHeroe,IVolador
    {
        int exp=0;
        public void volador()
        {
            Console.WriteLine("Superman: Estoy volando como un campeon...");
            exp += 3;
        }
    }
}
