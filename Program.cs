using System;

namespace Proyecto_c{
    class Program{

        static void Main(string[] args){
            float edad = 0;
            int tipo_Actividad;
            Boolean Fin = false;
            string Ctipo_actividad = "";

            Console.WriteLine("Hola, Bienvenido");
                    
            /*definicon de valores predeterminados por tipo
            *de actividas para categoria adulto*/

            String[] actividad_Alta = new string[8];

             actividad_Alta[0] = "60gr-115gr";
             actividad_Alta[1] = "115gr-190gr";
             actividad_Alta[2] = "190gr-255gr";
             actividad_Alta[3] = "255gr-380gr";
             actividad_Alta[4] = "380gr-535gr";
             actividad_Alta[5] = "535gr-680gr";
             actividad_Alta[6] = "680gr-820gr";
             actividad_Alta[7] = "820gr-985gr";

            

            String[] actividad_Media = new string[8];
             actividad_Media[0] = "55gr-100gr";
             actividad_Media[1] = "100gr-170gr";
             actividad_Media[2] = "170gr-255gr";
             actividad_Media[3] = "255gr-330gr";
             actividad_Media[4] = "330gr-475gr";
             actividad_Media[5] = "475gr-600gr";
             actividad_Media[6] = "600gr-720gr";
             actividad_Media[7] = "820gr-985gr";



            String[] actividad_Baja = new string[8];

            actividad_Baja[0] = "45gr-85gr";
            actividad_Baja[1] = "85gr-145gr";
            actividad_Baja[2] = "145gr-195gr";
            actividad_Baja[3] = "195gr-285gr";
            actividad_Baja[4] = "285gr-410gr";
            actividad_Baja[5] = "410gr-520gr";
            actividad_Baja[6] = "520gr-620gr";
            actividad_Baja[7] = "620gr-750gr";

            int[] Mes2 = new int[11];
            Mes2[0] = 50;
            Mes2[1] = 95;
            Mes2[2] = 155;
            Mes2[3] = 215;
            Mes2[4] = 270;
            Mes2[5] = 300;
            Mes2[6] = 355;
            Mes2[7] = 405;
            Mes2[8] = 450;
            Mes2[9] = 485;
            Mes2[10] = 580;


            int[] Mes3 = new int[10];

            Mes3[0] = 60;
            Mes3[1] = 110;
            Mes3[2] = 185;
            Mes3[3] = 265;
            Mes3[4] = 350;
            Mes3[5] = 400;
            Mes3[6] = 475;
            Mes3[7] = 545;
            Mes3[8] = 605;
            Mes3[9] = 670;

            int[] Mes4 = new int[9];

            Mes4[0] = 60;
            Mes4[1] = 115;
            Mes4[2] = 195;
            Mes4[3] = 285;
            Mes4[4] = 375;
            Mes4[5] = 445;
            Mes4[6] = 525;
            Mes4[7] = 610;
            Mes4[8] = 685;

            int[] Mes5 = new int[8];

            Mes5[0] = 60;
            Mes5[1] = 115;
            Mes5[2] = 190;
            Mes5[3] = 285;
            Mes5[4] = 375;
            Mes5[5] = 450;
            Mes5[6] = 530;
            Mes5[7] = 625;

            int[] Mes6_12 = new int[7];

            Mes6_12[0] = 55;
            Mes6_12[1] = 110;
            Mes6_12[2] = 185;
            Mes6_12[3] = 280;
            Mes6_12[4] = 370;
            Mes6_12[5] = 450;
            Mes6_12[6] = 530;


            /*selecion del tipo de mascota que se tiene
             * si es cachorro o adulto*/

            while (Fin == false){ 
                if (edad != 0){
                    edad = 0;
                }
                Console.WriteLine("Ingrese la edad de su mascota en meses");

                edad = int.Parse(Console.ReadLine());

                //categoria adulto
                if (edad >= 12 && edad <= 144){

                    Console.WriteLine("Categoría Adulto ");

                    Console.WriteLine("---------------------------------------------------------------");

                    //peso adulto
                    Console.WriteLine("Ingrese el peso de su mascota en Kg");
                    int peso = 0;
                    peso = (int)float.Parse(Console.ReadLine());
                    if (peso < 0)
                    {
                        Console.WriteLine("Valor ingresado incorrecto");

                        //tamaño diminuto
                    }
                    else if (peso >= 1 && peso < 5)
                    {
                        Console.WriteLine("ingrese el tipo de actividad de su mascota");
                        Console.WriteLine("(1)Alta, (2)Media, (3)Baja");
                        tipo_Actividad = int.Parse(Console.ReadLine());
                        string Resultado = "";
                        switch (tipo_Actividad)
                        {
                            case 1:
                                Ctipo_actividad = "Actividad Alta";
                                Resultado = actividad_Alta[0];
                                break;
                            case 2:
                                Ctipo_actividad = "Actividad Media";
                                Resultado = actividad_Media[0];
                                break;
                            case 3:
                                Ctipo_actividad = "Actividad Baja";
                                Resultado = actividad_Baja[0];
                                break;
                        }
                        Console.WriteLine("Peso: "+ peso + " kg");
                         edad = edad / 12;
                        Console.WriteLine("Edad: " + edad + " Años");
                        Console.WriteLine("Tipo de actividad: "+ Ctipo_actividad);
                        Console.WriteLine("Cantidad de alimento necesario:"+ Resultado);
                        int salir;
                        Console.WriteLine("¿Desea salir?");
                        Console.WriteLine("(1) Si (0)No");
                        do{
                         salir = int.Parse(Console.ReadLine());
                        } while (salir == 0 || salir == 1);
                        if (salir == 1){
                            Fin = true;
                        }

                        //tamaño pequeño
                    }
                    else if (peso >= 5 && peso < 10)
                    {
                        Console.WriteLine("ingrese el tipo de actividad de su mascota");
                        Console.WriteLine("(1)Alta, (2)Media, (3)Baja");
                        tipo_Actividad = int.Parse(Console.ReadLine());
                        string Resultado = "";
                        switch (tipo_Actividad)
                        {
                            case 1:
                                Ctipo_actividad = "Actividad Alta";
                                Resultado = actividad_Alta[1];
                                break;
                            case 2:
                                Ctipo_actividad = "Actividad Media";
                                Resultado = actividad_Media[1];
                                break;
                            case 3:
                                Ctipo_actividad = "Actividad Baja";
                                Resultado = actividad_Baja[1];
                                break;
                        }
                        Console.WriteLine("Peso: " + peso);
                        edad = edad / 12;
                        Console.WriteLine("Edad: " + edad + " Años");
                        Console.WriteLine("Tipo de actividad: " + Ctipo_actividad);
                        Console.WriteLine("Cantidad de alimento necesario:" + Resultado);
                        int salir;
                        Console.WriteLine("¿Desea salir?");
                        Console.WriteLine("(1) Si (0)No");
                        do
                        {
                            salir = int.Parse(Console.ReadLine());
                        } while (salir == 0 || salir == 1);
                        if (salir == 1)
                        {
                            Fin = true;
                        }

                        //tamaño mediano
                    }
                    else if (peso > 10 && peso < 15)
                    {
                        Console.WriteLine("ingrese el tipo de actividad de su mascota");
                        Console.WriteLine("(1)Alta, (2)Media, (3)Baja");
                        tipo_Actividad = int.Parse(Console.ReadLine());
                        string Resultado = "";
                        switch (tipo_Actividad)
                        {
                            case 1:
                                Ctipo_actividad = "Actividad Alta";
                                Resultado = actividad_Alta[2];
                                break;
                            case 2:
                                Ctipo_actividad = "Actividad Media";
                                Resultado = actividad_Media[2];
                                break;
                            case 3:
                                Ctipo_actividad = "Actividad Baja";
                                Resultado = actividad_Baja[2];
                                break;
                        }
                        Console.WriteLine("Peso: " + peso);
                        edad = edad / 12;
                        Console.WriteLine("Edad: " + edad + " Años");
                        Console.WriteLine("Tipo de actividad: " + Ctipo_actividad);
                        Console.WriteLine("Cantidad de alimento necesario:" + Resultado);
                        int salir;
                        Console.WriteLine("¿Desea salir?");
                        Console.WriteLine("(1) Si (0)No");
                        do
                        {
                            salir = int.Parse(Console.ReadLine());
                        } while (salir == 0 || salir == 1);
                        if (salir == 1)
                        {
                            Fin = true;
                        }


                        //tamaño grande
                    }
                    else if (peso > 15 && peso < 90){

                        Console.WriteLine("ingrese el tipo de actividad de su mascota");
                        Console.WriteLine("(1)Alta, (2)Media, (3)Baja");
                        tipo_Actividad = int.Parse(Console.ReadLine());
                        string Resultado = "";
                        switch (tipo_Actividad)
                        {
                            case 1:
                                Ctipo_actividad = "Actividad Alta";

                                if (peso >= 15 && peso < 25)
                                {
                                    Resultado = actividad_Alta[3];
                                }
                                else if (peso >= 25 && peso < 40)
                                {
                                    Resultado = actividad_Alta[4];
                                }
                                else if (peso >= 40 && peso < 55)
                                {
                                    Resultado = actividad_Alta[5];
                                }
                                else if (peso >= 55 && peso < 70)
                                {
                                    Resultado = actividad_Alta[6];
                                }
                                else if (peso >= 70 && peso <= 90)
                                {
                                    Resultado = actividad_Alta[7];
                                }
                                else
                                {
                                    Console.WriteLine("Peso indicado no valido");
                                }
                                    break;
                            case 2:
                                Ctipo_actividad = "Actividad Media";
                                if (peso >= 15 && peso < 25)
                                {
                                    Resultado = actividad_Media[3];
                                }
                                else if (peso >= 25 && peso < 40)
                                {
                                    Resultado = actividad_Media[4];
                                }
                                else if (peso >= 40 && peso < 55)
                                {
                                    Resultado = actividad_Media[5];
                                }
                                else if (peso >= 55 && peso < 70)
                                {
                                    Resultado = actividad_Media[6];
                                }
                                else if (peso >= 70 && peso <= 90)
                                {
                                    Resultado = actividad_Media[7];
                                }
                                else
                                {
                                    Console.WriteLine("Peso indicado no valido");
                                }
                                break;

                            case 3:
                                Ctipo_actividad = "Actividad Baja";
                                if (peso >= 15 && peso < 25)
                                {
                                    Resultado = actividad_Baja[3];
                                }
                                else if (peso >= 25 && peso < 40)
                                {
                                    Resultado = actividad_Baja[4];
                                }
                                else if (peso >= 40 && peso < 55)
                                {
                                    Resultado = actividad_Baja[5];
                                }
                                else if (peso >= 55 && peso < 70)
                                {
                                    Resultado = actividad_Baja[6];
                                }
                                else if (peso >= 70 && peso <= 90)
                                {
                                    Resultado = actividad_Baja[7];
                                }
                                else
                                {
                                    Console.WriteLine("Peso indicado no valido");
                                }

                                break;
                        }
                        Console.WriteLine("Peso: " + peso);
                        edad = edad / 12;
                        Console.WriteLine("Edad: " + edad + " Años");
                        Console.WriteLine("Tipo de actividad: " + Ctipo_actividad);
                        Console.WriteLine("Cantidad de alimento necesario:" + Resultado);
                        int salir;
                        Console.WriteLine("¿Desea salir?");
                        Console.WriteLine("(1) Si (0)No");
                        do
                        {
                            salir = int.Parse(Console.ReadLine());
                        } while (salir != 1 || salir == 1);
                        if (salir == 1)
                        {
                            Fin = true;
                        }
                    }

                } /*Categoría cachorro*/
                else if (edad > 0 && edad < 12)
                {

                    Console.WriteLine("Categoría Cachorro ");

                    Console.WriteLine("---------------------------------------------------------------");


                    //peso Cachorro
                    //key do-while
                    Boolean entrada = false;

                    //seguro de entrada
                    
                        Console.WriteLine("Ingrese el peso ideal de adulto de su mascota en Kg");
                        float peso = 0;
                        peso = (int)float.Parse(Console.ReadLine());
                   
                        switch (peso)
                        {

                            case 2:
                                entrada = true;
                               if (edad == 1) {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2){
                                    Console.WriteLine("Edad: " + edad);
                                    Console.WriteLine("peso ideal de adulto: "+ peso);
                                    Console.WriteLine("Alimento necesario: "+ Mes2[0]+"Gr");
                                }
                                else if(edad == 3){
                                    Console.WriteLine("Alimento necesario: " + Mes3[0] + "Gr");
                                }
                                else if( edad == 4){
                                    Console.WriteLine("Alimento necesario: " + Mes4[0] + "Gr");
                                }
                                else if(edad == 5){
                                    Console.WriteLine("Alimento necesario: " + Mes5[0] + "Gr");
                                }
                                else if (edad >= 6) {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[0] + "Gr");
                                }
                                
                                break;

                            case 5:
                                entrada = true;

                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[1] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[1] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[1] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[1] + "Gr");
                                }
                                else if (edad >= 6)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[1] + "Gr");
                                }

                                break;

                            case 10:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[2] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[2] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[2] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[2] + "Gr");
                                }
                                else if (edad >= 6)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[2] + "Gr");
                                }

                                break;

                            case 17:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[3] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[3] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[3] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[3] + "Gr");
                                }
                                else if (edad >= 6)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[3] + "Gr");
                                }

                                break;

                            case 25:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[4] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[4] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[4] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[4] + "Gr");
                                }
                                else if (edad >= 6)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[4] + "Gr");
                                }

                                break;

                            case 32:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[5] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[5] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[5] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[5] + "Gr");
                                }
                                else if (edad >= 6)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[5] + "Gr");
                                }

                                break;

                            case 40:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[6] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[6] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[6] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[6] + "Gr");
                                }
                                else if (edad >= 6)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes6_12[6] + "Gr");
                                }

                                break;

                            case 50:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[7] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[7] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[7] + "Gr");
                                }
                                else if (edad == 5)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes5[7] + "Gr");
                                }
                                

                                break;

                            case 60:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[8] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[8] + "Gr");
                                }
                                else if (edad == 4)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes4[8] + "Gr");
                                }
                            
                                break;

                            case 70:
                                entrada = true;
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[9] + "Gr");
                                }
                                else if (edad == 3)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes3[9] + "Gr");
                                }
                               

                                break;

                            case 90:
                                
                                if (edad == 1)
                                {
                                    Console.WriteLine("No se debe subminitrar alimento");
                                }
                                else if (edad == 2)
                                {
                                    Console.WriteLine("Alimento necesario: " + Mes2[10] + "Gr");
                                }
                             
                                break;

                            default:
                                Console.WriteLine("valor ingresado noválido");
                                break;

                        }
                    int salir;
                    Console.WriteLine("¿Desea salir?");
                    Console.WriteLine("(1) Si (0)No");
                    do
                    {
                        salir = int.Parse(Console.ReadLine());
                    } while (salir != 1 || salir == 1);
                    if (salir == 1)
                    {
                        Fin = true;
                    }


                }
                else{
                    Console.WriteLine("Valor ingresado no válido");
                    Fin = false;
                }

            }
            //final de la consola
            Console.WriteLine("Press any num for finish the program");
            Console.ReadKey(true);
            Console.WriteLine("Gregorio Ortega");
        }
      
       
    }
}
