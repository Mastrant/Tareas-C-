using System;
using System.Collections;
using System.Threading;


namespace Despachador_de_pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            bool iva_fijo;

            Console.ForegroundColor = ConsoleColor.Yellow;
            

            Console.WriteLine("¿Desea colocar una taza de iva difente al 16%?");
            Console.WriteLine("SI: (s) NO: (n)");

            
            int  IVa = 1;

            if (Console.ReadKey().KeyChar.Equals('n'))
            {
                iva_fijo = false;
            }
            else 
            {
                iva_fijo = true;

                Console.Clear();
                Console.WriteLine("Ingrese la taza de iba que desea evaluar\n");
                Console.Write("");
                IVa = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("BIEMVENIDO A PIZZA PIZZONO \n");
            Thread.Sleep(300);
            Console.WriteLine("Selecione el tipo de pizza que quiera pedir:\n");

            Console.WriteLine("Margarita (1)      Surf (5) \n");
            Console.WriteLine("Polaca (2)         Romana (6) \n");
            Console.WriteLine("Hawaiana (3)       \n");
            Console.WriteLine("Marina (4)\n");
            Console.WriteLine("Personalizada (0)");
            Console.Write("");

            int seleccion = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("\nIngrese el tamaño de su pizza \n");
            Console.Write("\n");

            Console.WriteLine(@" 8', 12', 14' 16");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            Thread.Sleep(300);
            Console.Clear();
            
            Console.WriteLine("Cargando Ingredientes.");

            Ingredientes Pepperoni = new Ingredientes();            
                Pepperoni.tipo = "Pepperoni";
                Pepperoni.precio = 3;
            Salsa Base = new Salsa();
            Base.tipo = "Salsa";
            Base.consto_a = 0;
            Base.precio = Base.consto_a + 0;

            Ingredientes Champiñones = new Ingredientes();
                Champiñones.tipo = "Champiñones";
                Champiñones.precio = 42;

            Ingredientes Queso = new Ingredientes();
                Queso.tipo = "Queso";
                Queso.precio = 1;

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Cargando Ingredientes..");
            Ingredientes Jamón = new Ingredientes();
            Jamón.tipo = "Jamón";
            Jamón.precio = 2;

            Ingredientes Anchoas = new Ingredientes();
            Anchoas.tipo = "Anchoas";
            Anchoas.precio = 3;

            Ingredientes Aceitunas = new Ingredientes();
            Aceitunas.tipo = "Aceitunas";
            Aceitunas.precio = 3;

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Cargando Ingredientes...");
            Ingredientes Piña = new Ingredientes();
            Piña.tipo = "Piña";
            Piña.precio = 4;

            Ingredientes Oregano = new Ingredientes();
            Oregano.tipo = "Orégano";
            Champiñones.precio = 1;

            Ingredientes Tomate = new Ingredientes();
            Champiñones.tipo = "Tomate";
            Champiñones.precio = 2;

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Cargando Ingredientes.\n");
            Ingredientes Pimenton = new Ingredientes();
            Pimenton.tipo = "Pimenton";
            Pimenton.precio = 4;

            Ingredientes Cebolla = new Ingredientes();
            Cebolla.tipo = "Cebolla";
            Cebolla.precio = 2;

            Ingredientes Salchicha = new Ingredientes();
            Salchicha.tipo = "Salchicha";
            Champiñones.precio = 5;

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Cargando Ingredientes...");
            Ingredientes Tocineta = new Ingredientes();
            Tocineta.tipo = "Tocineta";
            Tocineta.precio = 5;

            Ingredientes Salsa = new Ingredientes();
            Salsa.tipo = "Salsa";
            Salsa.precio = 0;

            Ingredientes Maiz = new Ingredientes();
            Maiz.tipo = "Maíz";
            Maiz.precio = 4;

            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Cargando Ingredientes...\n");

            Ingredientes Pimienta = new Ingredientes();
            Pimienta.tipo = "Pimienta";
            Pimienta.precio = 1;

            Ingredientes Camaron = new Ingredientes();
            Camaron.tipo = "Camarón";
            Camaron.precio = 4;

            Salsa Salsa_pesto = new Salsa();
            Salsa_pesto.consto_a = 2;
            Salsa_pesto.tipo = "Salsa Pesto";
            Salsa_pesto.precio = 1 + Salsa_pesto.consto_a;

            ArrayList Ingredientes_Añadidos = new ArrayList();
            ArrayList PIngredientes_Añadidos = new ArrayList();

            Thread.Sleep(300);
            Console.Clear();

            Console.Write("Creando pizza");
            Thread.Sleep(600);
            Console.Clear();

            Pizza pizza = new Pizza();

            int subTotal = 0;
            float costo_iva = 0;
            bool facturar = false;
            int Precio_Ingredientes = 0;

            switch (seleccion)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;                    

                    pizza.nombre = "MARGARITA";
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;                    

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);

                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Queso.tipo);
                    PIngredientes_Añadidos.Add(Queso.precio);
                    Console.WriteLine("Queso Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Jamón.tipo);
                    PIngredientes_Añadidos.Add(Jamón.precio);
                    Console.WriteLine("Jamón Agregado");
                    Thread.Sleep(900);

                    Console.Clear();
                    
                    foreach ( int ingr in PIngredientes_Añadidos)
                     {
                        Precio_Ingredientes += ingr;
                     }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                         costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                         costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;

                    break;

                case 2:
                    Console.WriteLine("POLACA");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    pizza.nombre = "POLACA";
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);

                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Queso.tipo);
                    PIngredientes_Añadidos.Add(Queso.precio);
                    Console.WriteLine("Queso Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Jamón.tipo);
                    PIngredientes_Añadidos.Add(Jamón.precio);
                    Console.WriteLine("Jamón Agregado");

                    Ingredientes_Añadidos.Add(Salchicha.tipo);
                    PIngredientes_Añadidos.Add(Salchicha.precio);
                    Console.WriteLine("Salchicha Agregada");
                    Thread.Sleep(900);

                    Console.Clear();
                    
                    foreach (int ingr in PIngredientes_Añadidos)
                    {
                        Precio_Ingredientes += ingr;
                    }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                        costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                        costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;

                    break;
                case 3:
                    Console.WriteLine("HAWAIANA");

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    pizza.nombre = "HAWAIANA";
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);

                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Queso.tipo);
                    PIngredientes_Añadidos.Add(Queso.precio);
                    Console.WriteLine("Queso Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Piña.tipo);
                    PIngredientes_Añadidos.Add(Piña.precio);
                    Console.WriteLine("Piña Agregada");

                    Thread.Sleep(900);

                    Console.Clear();

                    foreach (int ingr in PIngredientes_Añadidos)
                    {
                        Precio_Ingredientes += ingr;
                    }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                        costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                        costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;

                    break;
                case 4:
                    Console.WriteLine("MARINA");
                   
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    pizza.nombre = "MARINA";
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);

                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Queso.tipo);
                    PIngredientes_Añadidos.Add(Queso.precio);
                    Console.WriteLine("Queso Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Anchoas.tipo);
                    PIngredientes_Añadidos.Add(Anchoas.precio);
                    Console.WriteLine("Anchoas Agregadas");
                    Ingredientes_Añadidos.Add(Camaron.tipo);
                    PIngredientes_Añadidos.Add(Camaron.precio);
                    Console.WriteLine("Camarón Agregado");
                    Thread.Sleep(800);
                    Thread.Sleep(900);

                    Console.Clear();

                    foreach (int ingr in PIngredientes_Añadidos)
                    {
                        Precio_Ingredientes += ingr;
                    }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                        costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                        costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;


                    break;
                case 5:
                    Console.WriteLine("SURF");

                   
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    pizza.nombre = "SURF";
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);

                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Queso.tipo);
                    PIngredientes_Añadidos.Add(Queso.precio);
                    Console.WriteLine("Queso Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Jamón.tipo);
                    PIngredientes_Añadidos.Add(Jamón.precio);
                    Console.WriteLine("Jamón Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Tocineta.tipo);
                    PIngredientes_Añadidos.Add(Tocineta.precio);
                    Console.WriteLine("Tocineta Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Pepperoni.tipo);
                    PIngredientes_Añadidos.Add(Pepperoni.precio);
                    Console.WriteLine("Peperoni Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Maiz.tipo);
                    PIngredientes_Añadidos.Add(Maiz.precio);
                    Console.WriteLine("Maíz Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Pimenton.tipo);
                    PIngredientes_Añadidos.Add(Pimenton.precio);
                    Console.WriteLine("Jamón Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Cebolla.tipo);
                    PIngredientes_Añadidos.Add(Cebolla.precio);
                    Console.WriteLine("Cebolla Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Champiñones.tipo);
                    PIngredientes_Añadidos.Add(Champiñones.precio);
                    Console.WriteLine("Champiñones Agregados");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Aceitunas.tipo);
                    PIngredientes_Añadidos.Add(Aceitunas.precio);
                    Console.WriteLine("Aceituna Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Anchoas.tipo);
                    PIngredientes_Añadidos.Add(Anchoas.precio);
                    Console.WriteLine("Anchoas Agregado");
                    Thread.Sleep(900);
                    Console.Clear();

                    foreach (int ingr in PIngredientes_Añadidos)
                    {
                        Precio_Ingredientes += ingr;
                    }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                        costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                        costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;

                    break;
                case 6:
                    Console.WriteLine("ROMANA");
                   
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    pizza.nombre = "ROMANA";
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);

                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Queso.tipo);
                    PIngredientes_Añadidos.Add(Queso.precio);
                    Console.WriteLine("Queso Agregado");
                    Thread.Sleep(800);
                    Ingredientes_Añadidos.Add(Jamón.tipo);
                    PIngredientes_Añadidos.Add(Jamón.precio);
                    Console.WriteLine("Jamón Agregado");
                    Ingredientes_Añadidos.Add(Maiz.tipo);
                    PIngredientes_Añadidos.Add(Maiz.precio);
                    Console.WriteLine("Maíz Agregado");
                    Ingredientes_Añadidos.Add(Pimenton.tipo);
                    PIngredientes_Añadidos.Add(Pimenton.precio);
                    Console.WriteLine("Pimenton Agregado");
                    Thread.Sleep(900);

                    Console.Clear();

                    foreach (int ingr in PIngredientes_Añadidos)
                    {
                        Precio_Ingredientes += ingr;
                    }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                        costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                        costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;

                    break;
                
                case 0:


                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("PERSONALIZADA\n");

                    Console.WriteLine("Ingrese el nombre de su pizza");


                    pizza.nombre = Console.ReadLine(); ;
                    pizza.tamaño = tamaño;
                    pizza.ptamaño = pizza.tamaño;

                    Console.WriteLine("Añadiendo ingredientes... \n");
                    Thread.Sleep(300);                                        
                    Ingredientes_Añadidos.Add(Salsa.tipo);
                    PIngredientes_Añadidos.Add(Salsa.precio);
                    Console.WriteLine("Salsa Agregada");
                    Thread.Sleep(800);
                    bool exit;
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("Ingrese el ingredientes que desea añadir\n\n");
                        Console.WriteLine("Ingredientes ya añadidos:\n");
                        foreach (var on in Ingredientes_Añadidos)
                        {
                            Console.WriteLine(on);
                        }

                        Console.WriteLine("Tomate: 2$ (1)          Pepperoni: 3$ (2)");
                        Console.WriteLine("champiñones: 4$ (3)     Pimenton: 4$ (4)");
                        Console.WriteLine("Queso: 1$ (5)           Cebolla: 2$ (6)");
                        Console.WriteLine("Jamón: 2$ (7)           Salcicha: 5$ (8)");
                        Console.WriteLine("Anchoas: 3$ (9)         Tocineta: 5$ (10)");
                        Console.WriteLine("Acitunas: 3$ (11)       Maíz: 4$ (12)");
                        Console.WriteLine("Piña: 4$ (13)           Pimienta: 1$ (14)");
                        Console.WriteLine("Oregano: 1$ (15)        Camaron: 4$ (16)");
                        Console.WriteLine("Eliminar Último Ingrediente (99)");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("          Facturar: (0)");

                        int selec2 = Convert.ToInt32(Console.ReadLine());

                        switch (selec2)
                        { case 1:
                                Ingredientes_Añadidos.Add(Tomate.tipo);
                                PIngredientes_Añadidos.Add(Tomate.precio);
                                break;
                            case 2:
                                Ingredientes_Añadidos.Add(Pepperoni.tipo);
                                PIngredientes_Añadidos.Add(Pepperoni.precio);
                                break;
                            case 3:
                                Ingredientes_Añadidos.Add(Champiñones.tipo);
                                PIngredientes_Añadidos.Add(Champiñones.precio);
                                break;
                            case 4:
                                Ingredientes_Añadidos.Add(Pimenton.tipo);
                                PIngredientes_Añadidos.Add(Pimenton.precio);
                                break;
                            case 5:
                                Ingredientes_Añadidos.Add(Queso.tipo);
                                PIngredientes_Añadidos.Add(Queso.precio);
                                break;
                            case 6:
                                Ingredientes_Añadidos.Add(Cebolla.tipo);
                                PIngredientes_Añadidos.Add(Cebolla.precio);
                                break;
                            case 7:
                                Ingredientes_Añadidos.Add(Jamón.tipo);
                                PIngredientes_Añadidos.Add(Jamón.precio);
                                break;
                            case 8:
                                Ingredientes_Añadidos.Add(Salchicha.tipo);
                                PIngredientes_Añadidos.Add(Salchicha.precio);
                                break;
                            case 9:
                                Ingredientes_Añadidos.Add(Anchoas.tipo);
                                PIngredientes_Añadidos.Add(Anchoas.precio);
                                break;
                            case 10:
                                Ingredientes_Añadidos.Add(Tocineta.tipo);
                                PIngredientes_Añadidos.Add(Tocineta.precio);
                                break;
                            case 11:
                                Ingredientes_Añadidos.Add(Aceitunas.tipo);
                                PIngredientes_Añadidos.Add(Aceitunas.precio);
                                break;
                            case 12:
                                Ingredientes_Añadidos.Add(Maiz.tipo);
                                PIngredientes_Añadidos.Add(Maiz.precio);
                                break;
                            case 13:
                                Ingredientes_Añadidos.Add(Piña.tipo);
                                PIngredientes_Añadidos.Add(Piña.precio);
                                break;
                            case 14:
                                Ingredientes_Añadidos.Add(Pimienta.tipo);
                                PIngredientes_Añadidos.Add(Pimienta.precio);
                                break;
                            case 15:
                                Ingredientes_Añadidos.Add(Oregano.tipo);
                                PIngredientes_Añadidos.Add(Oregano.precio);
                                break;
                            case 16:
                                Ingredientes_Añadidos.Add(Camaron.tipo);
                                PIngredientes_Añadidos.Add(Camaron.precio);
                                break;

                            case 99:
                                Ingredientes_Añadidos.Remove(Ingredientes_Añadidos.Count -1);
                                PIngredientes_Añadidos.Remove(PIngredientes_Añadidos.Count - 1);
                                break;

                                case 0:
                                exit = true;
                                break;

                            default:
                                break;

                        }
                        Thread.Sleep(600);

                            Console.WriteLine("¿Desea añadir otro ingrediente=");
                            Console.WriteLine("Si(s)        No(n)");
                        exit = Console.ReadKey().KeyChar.Equals('s');

                    } while (exit == false);
                   

                    Console.Clear();

                    foreach (int ingr in PIngredientes_Añadidos)
                    {
                        Precio_Ingredientes += ingr;
                    }
                    subTotal = Precio_Ingredientes + pizza.ptamaño;
                    if (iva_fijo)
                    {
                        costo_iva = pizza.IVA(subTotal);
                    }
                    else
                    {
                        costo_iva = pizza.IVA(subTotal, IVa);
                    }

                    pizza.precio = costo_iva + subTotal;

                    facturar = true;

                    break;
            }

            //facturar:

            if (facturar)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("-------------------------------------------------------");
                Thread.Sleep(900);
                Console.WriteLine("FACTURANDO");
                Thread.Sleep(500);
                Console.WriteLine(pizza.nombre  + $"   Tamaño:{pizza.tamaño}´\n\n");
                Thread.Sleep(500);

                for (int k = 0; k < Ingredientes_Añadidos.Count; k++)
                {
                    Console.WriteLine($"{Ingredientes_Añadidos[k]} ------- {PIngredientes_Añadidos[k]}$");
                    Thread.Sleep(1000);
                }

                Thread.Sleep(500);
                Console.WriteLine($"\n\nSub Total: {subTotal}");
                Thread.Sleep(150);
                Console.WriteLine($"IVA: {IVa}%: {costo_iva}");
                Thread.Sleep(150);
                Console.WriteLine($"\nTOTAL: {pizza.precio}$");

                Console.WriteLine("\n-------------------------------------------------------");

                Console.WriteLine("\nn     ....Press any key to exit....");
                Console.ReadKey();
            }
        }
    }
}
