using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces_ejercicio2
{
    class TorreDeControl
    {
        List<IVolador> voladores = new List<IVolador>();


        public void vuelenTodos()
        {
            foreach(IVolador v in voladores)
            {
                v.volador();
            }
        }

        public void agregarVolador(IVolador unIVolador)
        {
            voladores.Add(unIVolador);
        }
    }
}
