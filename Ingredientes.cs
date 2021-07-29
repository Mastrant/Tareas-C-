using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despachador_de_pizza
{
     public class Ingredientes
    {
        string Tipo;
        int Precio;

        public virtual string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        public virtual int precio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public void Imprimir_Ingrediente()
        {
            Console.WriteLine($"{Tipo}: {precio}$");
        }

    }
}
