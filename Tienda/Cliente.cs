using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tienda
{
    public class Cliente
    {
        String Nombre;
        String Apellido;
        int Cédula;
        int ID;
        public string N0ombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string Apellid0
        {
            get
            {
                return Apellido;
            }
            set
            {
                Apellido = value;
            }
        }
        public int Cedula
        {
            get
            {
                return Cédula;
            }
            set
            {
              Cédula = value;                    
            }
        }
        public int Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public void visualizacion()
        {
            Console.WriteLine($"Cliente ID:{Id}, {N0ombre} {Apellid0} C.I: {Cedula}\n");
        }
    }
}
