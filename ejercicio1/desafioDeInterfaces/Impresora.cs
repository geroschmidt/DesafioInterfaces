using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeInterfaces
{
    class Impresora
    {
        List<Iimprimible> ColaDeImpresion = new List<Iimprimible>();

        public void ImprimirTodo()
        {
            foreach  (Iimprimible i in ColaDeImpresion)
            {
                Type tipo = i.GetType();
                Console.Write(tipo.Name+":");
                i.imprimir();
                Console.WriteLine();
            }
        }

        public void AgregarImprimible(Iimprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
