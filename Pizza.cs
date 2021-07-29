using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Despachador_de_pizza
{
    public class Pizza: Producto
    {       
        
        int Tamaño;
        int Ptamaño = 10;
        
        public int tamaño
        {
            get { return Tamaño; }
            set { Tamaño = value; }
        }
        public int ptamaño
        {
            get
            {
                return Ptamaño;
            }
            set
            {
                switch (value)
                {
                    case 8:
                        Ptamaño = 10;
                        Tamaño = 8;
                        break;
                    case 12:
                        Ptamaño = 12;
                        break;
                    case 14:
                        Ptamaño = 15;
                        break;
                    case 16:
                        Ptamaño = 16;
                        break;

                }
            }
        }

         
    }
}
