using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {

            //Inicio
            
            //declaracion variables de inicio
            int Count = 3;
            string key;
            ArrayList Lista_Clientes = new ArrayList();
            /*
            //ciclo candado
            do
            {
                Console.WriteLine("Ingrese la Contraseña");

                //asignacion del valor a la variable
                key = Console.ReadLine();

                //comprobar el valor
                if(key != "1234")
                {
                    Count--;
                    Console.WriteLine($"La clave es Incorrecta, quedan {Count} Intentos/n");
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();                    
                }
                else
                {
                    Console.WriteLine("Pass :)");                    
                }

            } while (Count != 0 && key != "1234");
            */

            //Codigo de la tienda
            if (Count != 0)
            {
                Console.Clear();
                //Kay admin
                int administrador = -1;
                //contador de clientes
                int NumC = 00;
                //instaciador de la clase Cliente
                Cliente C;
                //declaracion de arreglo que contiene a los clientes registrados
                
                var NProducto = new List<string>();
                var PProducto = new List<int>();
                do
                {
                    //incianilador de variables
                    bool ky = false;
                    int p;

                    C = new Cliente();
                    

                    //pedir datos del cliente
                            Console.WriteLine("Ingrese el nombre del usuario");
                            C.N0ombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido del usuario");
                            C.Apellid0 = Console.ReadLine();
                            Console.WriteLine("Ingrese la cédula del usuario (sin puntos)");
                            C.Cedula = Convert.ToInt32(Console.ReadLine());
                            C.Id = NumC;

                    //guarda el cliente en una lista 
                    Lista_Clientes.Add(C);
                    Console.WriteLine("Usuario Registrado");
                    Thread.Sleep(30);
                    Console.Clear();
                    //añadir productos

                    string N;
                    while (ky != true)
                    {
                        do
                        {
                            Console.WriteLine("Ingrese el nombre del producto \n");
                            N = Console.ReadLine();
                        } while (N.Length == 0);

                        //Guarda el producto
                        NProducto.Add(N);                      

                        bool ok = false;
                        //compueba que el precio del producto sea mayor a 2
                        Console.WriteLine($"Ingrese el Precio del producto {N}: \n");
                        do
                        {
                            //guarda el Precio del Producto
                            p = Convert.ToInt32(Console.ReadLine());
                            if (p >= 2)
                            {
                                ok = true;
                                PProducto.Add(p);
                            }
                            else 
                            {
                                Console.WriteLine("Ingrese el monto nuevamente \n");
                            }
                        } while (ok != true);

                        Console.WriteLine("Producto Registrado \n");
                        Console.WriteLine("Press any key to continue or press 0 to exit");
                        ky = Console.ReadKey().KeyChar.Equals('0');
                        Console.Clear();
                    }
                    
                    Console.WriteLine($"Cliente ID:{C.Id}, {C.N0ombre} {C.Apellid0} C.I: {C.Cedula}\n");

                    for (int i = 0; i < NProducto.Count; i++){

                        Console.WriteLine($"{NProducto[i]} {PProducto[i]}Bs.S");
                    }
                    float SubTotal= 0;
                    foreach(int Subtotal in PProducto)
                    {
                        SubTotal += Subtotal;
                    }

                    Console.WriteLine($"\nMonto sub total: {SubTotal} Bs.S");
                    Console.WriteLine($"\nImporte del iva: 20% {Iva(SubTotal)}");
                    Console.WriteLine($"\nTotal a pagar: {SubTotal+Iva(SubTotal)} ");

                    //NO PERMITE SALIR DEL CICLO

                    //Hasta que el administrador precione 0
                    do
                    {
                        Console.WriteLine(administrador);
                        Console.WriteLine("\n ¿Desea ingresar otro usuario? \n NO: (0) \n SI: (1)");
                        administrador = Convert.ToInt32(Console.ReadLine());
                        Thread.Sleep(30);
                    } while (administrador != 0);
                     Console.Clear();
                    NumC++;
                } while (administrador != 0);

                Console.WriteLine("Clientes registrados: \n\n");
                foreach(Cliente Cl in Lista_Clientes)
                {
                    Cl.visualizacion();
                    Thread.Sleep(300);
                }

                Console.WriteLine("Fin del programa. \n press aky key to exit");

            }//Fin del codigo (clave válida)
            else
            {
                Console.Clear();
                Console.WriteLine("Usuario bloquedado");
                Thread.Sleep(600);
            }//Fin del codigo (clave inválida)


            //fin del código
        }
        public static float Iva(float SubTotal)
        {
            float Total = (SubTotal * 20) / 100;
            return Total;
        }
    }
}
