using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despachador_de_pizza
{
    class Salsa:Ingredientes
    {
        int Costo_a;

        public int consto_a
        {
            get { return Costo_a; }
            set { Costo_a = value; }
        }
    }
}
