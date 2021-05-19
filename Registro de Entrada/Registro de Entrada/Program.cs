using System;
using System.Collections.Generic;

namespace Registro_de_Entrada{
    class Program{
        static void Main(string[] args){
            
            //lista de usuarios ingresados
            var cedula = new List<String> { };
            var Rcedula = new List<String> { };              
            //salir del ciclo
            bool key = false;
            while (key == false){
                //lectura y conversión de la entrada del usuario
                Console.WriteLine(@"Ingrese su Cédula Para registrar");
                if (Console.ReadLine() != " "){
                    var Entrada = Convert.ToInt32(Console.ReadLine());
                    //optener la hora
                    int h = DateTime.Now.Hour;
                    //otorga la llave para salir del ciclo
                    if (Entrada == 0){
                        Console.WriteLine("Se ha ingresado en la seccion de administrador");
                        key = true;
                        //bloqueo de sistema por hora
                    }else if (0 < h && h < 8){
                        //registro de usuarios diario cédula mayor a 4 millones
                        if (Entrada > 4000000){
                            //Crea un campo en la lista de cedulas
                            cedula.Add(Convert.ToString(Entrada));
                            Console.WriteLine("Usuario Registrado con exito");
                            //indica un error al ingresar la cédulaS
                        }else{
                            Console.WriteLine("La cédula indicada no es válida");
                        }
                        //indica que el sistema esta cerrado por la hora
                    }else{
                        Console.WriteLine("El sistema está cerrado");
                        Rcedula.Add(Convert.ToString(Entrada));
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (key == true){
                //nuevo ciclo
                key = false;
                Console.Clear();
                while (key != true){
                    Console.Clear();
                    //adorno
                    Console.WriteLine("Admin \n\n");
                    //Menú admin
                    Console.WriteLine("¿Qué desea hacer?\n" +
                        "Ver el número de trabajadores fuera de la hora de llegada press: 3 \n\n" +
                        "Ver el número de trabajadores que asistieron press: 2 \n\n" +
                        "ver la lista de usuarios press: 1\n\n" +
                        "Salir press: 0\n");
                    //Guarda la seleccion a
                    string a = Console.ReadLine();
                    switch (a){
                        case "0":
                            Console.Clear();
                            Console.Write("Bye bye");
                            key = true;
                            break;
                        case "1":
                            //muestra la lista completa de usuarios
                            Console.Clear();
                            Console.WriteLine($"Lista de empleados que trabajaron el dia: " +
                                $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} \n");
                            foreach (string Usuario in cedula){
                                Console.WriteLine($"{Usuario}\n");
                            }
                            string b = null;
                            while (b != "0"){
                                Console.WriteLine("¿Desea gestionar el salario de los usuarios?");
                                Console.WriteLine("SI : 1\n NO: 0");
                                b = Console.ReadLine();
                                Console.Clear();
                                //administracion de salario por usuario selecionado
                                if (b == "1"){
                                    bool pass = false;
                                    while(pass != true){ 
                                        foreach (string Usuario in cedula){
                                            Console.WriteLine($"C.I: {Usuario}\n");
                                        }
                                        Console.WriteLine("\n Ingrese el número de cédula que desea ver");
                                        //guarda la cédula selecionada
                                        string C = Console.ReadLine();
                                        //busca en la lista la cédula selecionada
                                        foreach (string UserR in cedula){
                                            if (UserR == C){
                                                pass = true;
                                                break;
                                            }
                                        }
                                        //no se encuentra
                                        if (pass != true){
                                            Console.WriteLine("Cédula indicada no encontrada, Intente nuevamente");
                                            Console.Clear();
                                         //existe
                                        }else{
                                            Console.WriteLine("Usuario encontrado \n");
                                            Console.WriteLine("Ingrese el numero de horas que trabajó la semana pasada");
                                            //guarda el numero de horas
                                            int HDT = Convert.ToInt32(Console.ReadLine());
                                            //llama a la funcion Calculo_sueldo y regresa el valor
                                            int Cobro = Calculo_sueldo(HDT);
                                            Console.Clear();Console.WriteLine($"\n El usuario: {C}, trabajó un número total de: {HDT} horas. \n Cobra: {Cobro}");
                                            Console.WriteLine("\n\n Press any key to continue.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }
                                //mensaje de error
                                else if (b != "1" || b != "0"){
                                    Console.Clear();
                                    Console.WriteLine("Accion invalida");
                                }
                            }
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine($"El número total de trabajadores registrados es: \"{cedula.Capacity}\" ");
                            break;
                        case "3":
                            Console.Clear();
                            Console.Write("Usuarios no registrados por retraso \n");
                            if (Rcedula.Capacity > 0){
                                foreach (string Usuario in Rcedula){
                                    Console.WriteLine($"{Usuario}\n");
                                }
                            }else{
                                Console.WriteLine("Ningún usuario encontrado");
                            }                             
                            break;
                        //mensaje de error
                        default:
                            Console.WriteLine("Acción seleccionada invalida");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
        public static int Calculo_sueldo(int HDT){
            return HDT * 1000;
        }
    }
}
