using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5.Capitulo_10
{
    class Poligono
    {
        public int Lados { get; set; }
        public double MedidaLados { get; set; }

        public Poligono()
        {
            Lados = 0;
            MedidaLados = 0;
        }

        public Poligono(int CantLado, float LongitudLado)
        {
            Lados = CantLado;
            MedidaLados = LongitudLado;
        }
    }
}
