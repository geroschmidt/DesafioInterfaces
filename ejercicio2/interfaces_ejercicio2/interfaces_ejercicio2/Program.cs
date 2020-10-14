using System;

namespace interfaces_ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato lucas = new Pato();
            Boing747 boing747presidencial = new Boing747();
            Superman ClarkKent = new Superman();
            TorreDeControl adminTC = new TorreDeControl();

            adminTC.agregarVolador(ClarkKent);
            adminTC.agregarVolador(lucas);
            adminTC.agregarVolador(boing747presidencial);

            adminTC.vuelenTodos();

        }
    }
}
