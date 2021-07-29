using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despachador_de_pizza
{
    public abstract class Producto
    {
        string Nombre;

        float Precio;
        public virtual string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public float precio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        //calcula el iva del precio de la pizza en conjunto a los ingredientes
        public float IVA(float sub_total)
        {
            float calculo = (sub_total * 16) / 100;
            return calculo;
        }

        public float IVA(float sub_total, int taza)
        {
            float calculo = (sub_total * taza) / 100;
            return calculo;
        }

    }
}
