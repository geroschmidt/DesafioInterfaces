using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeInterfaces
{
    class Documento:Papel,Iimprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
