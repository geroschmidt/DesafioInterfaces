using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioDeInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();
            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(documento);

            impresora.ImprimirTodo();
            Console.ReadKey();

        }
    }
}
