﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeInterfaces
{
    class Foto:Papel,Iimprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
}
