﻿using System;
using System.Threading;

namespace Automata_Celular_en_consola
{
    class Program
    {
        //retarso de actualizacion dle sistema
        private const int retraso = 200;

        //tamaño del espacio

        static void Main(string[] args)
        {
            const int tamaño = 40;

            double Uduracion = 100;
            //Vairables de seguridad
            
            Random r = new Random();

            // espacio que almacena las células
            string[,] mapa = new string[tamaño, tamaño];
            int[,] log_mapa = new int[tamaño, tamaño];

            string[,] AMapa = new string[tamaño, tamaño];
            int[,] log_Amapa = new int[tamaño, tamaño];

            //inicializacion del sistema:

            Console.WriteLine("Bienvenido al Automata Celular de consola creado por Gregorio Ortega \n");


            bool pass = false;
            while (pass == (false)) {
                Console.WriteLine("Ingrese el números de veces que se repetirá el programa \n min: 50 max: 10000");
                Uduracion = Convert.ToInt32(Console.ReadLine());
                if (Uduracion >= 50 && Uduracion < 10001)
                {
                    Uduracion = (int)Uduracion;

                    pass = true;
                }
                else if (Uduracion > 50)
                {
                    Uduracion = 50;
                    pass = true;
                }
            }

            arranque(retraso);

            //limpieza del mapa
           
            int Espacios = 0;
            int Mapa_Length = mapa.Length;

            for (int j = 0; j < (tamaño); j++)
            {
                for (int i = 0; i < (tamaño); i++)
                {

                    log_mapa[i, j] = 0;
                    log_Amapa[i, j] = 0;
                    mapa[i, j] = " ";
                    AMapa[i, j] = " ";
                    Espacios++;

                }
            }

            //ciclo de limpieza

            Thread.Sleep(retraso);
            Console.Clear();
            //inicializacion correcta de Matrices temporales.

            //funcion correr programa
            bool Correr_Programa(int Espacios, int Mapa_Length)
            {
                bool estado;
                if (Espacios == Mapa_Length)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                return estado;
            }


            bool Correr = Correr_Programa(Espacios, Mapa_Length);

            //programa de simulacion

            if (Correr == true)
            {
                Console.WriteLine($"Condicion del programa: {Correr}");
                Thread.Sleep(retraso);
                Console.Clear();

                //Seleecion de simulación

                int hh = 0;
                do
                {
                    Console.WriteLine("inserte el numero de simulacion que desea ver \n");

                    for (int h = 1; h < 7; h++)
                    {
                        Console.WriteLine($"Simulación {h} = {h} \n");
                    }

                    hh = Convert.ToInt32(Console.ReadLine());
                } while (hh == 0);


                //Valores precargados de la matriz
                switch (hh)
                {
                    case 1:
                        Console.WriteLine("caso 1");
                        Thread.Sleep(retraso);

                        //   i  j
                        log_mapa[4, 0] = 1;
                        log_mapa[4, 1] = 1;
                        log_mapa[4, 2] = 1;
                        log_mapa[4, 3] = 1;
                        log_mapa[10, 0] = 1;
                        log_mapa[10, 1] = 1;
                        log_mapa[10, 2] = 1;
                        log_mapa[9, 3] = 1;
                        log_mapa[0, 4] = 1;
                        log_mapa[1, 4] = 1;
                        log_mapa[2, 4] = 1;
                        log_mapa[2, 5] = 1;
                        log_mapa[0, 10] = 1;
                        log_mapa[1, 10] = 1;
                        log_mapa[2, 10] = 1;
                        log_mapa[2, 9] = 1;





                        //Convercion de binario a string de Celulas vivas en mapa 
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {
                                if (log_mapa[p, t] == 1) {

                                    mapa[p, t] = "O";
                                }
                                else
                                {
                                    mapa[p, t] = " ";
                                }

                            }
                        }


                        break;

                    case 2:

                        Console.WriteLine("caso 2 random");

                        for (int t = 0; t < tamaño; t++) {
                            for (int p = 0; p < tamaño; p++) {

                                //   p  t
                                log_mapa[p, t] = r.Next(0, 2);
                            }
                        }

                        //Convercion de binario a string de Celulas vivas en mapa 
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {
                                if (log_mapa[p, t] == 1)
                                {

                                    mapa[p, t] = " ";
                                    log_mapa[p, t] = 0;
                                }
                                else
                                {
                                    mapa[p, t] = "O";
                                    log_mapa[p, t] = 1;
                                }

                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("caso 3");

                        //   i  j

                        log_mapa[19, 10] = 1;
                        log_mapa[18, 11] = 1;
                        log_mapa[20, 11] = 1;
                        log_mapa[18, 12] = 1;
                        log_mapa[20, 12] = 1;
                        log_mapa[19, 13] = 1;
                        log_mapa[18, 14] = 1;
                        log_mapa[19, 14] = 1;
                        log_mapa[17, 15] = 1;
                        log_mapa[18, 15] = 1;
                        log_mapa[20, 15] = 1;
                        log_mapa[20, 16] = 1;
                        log_mapa[24, 16] = 1;
                        log_mapa[26, 16] = 1;
                        log_mapa[17, 17] = 1;
                        log_mapa[18, 17] = 1;
                        log_mapa[24, 17] = 1;
                        log_mapa[26, 17] = 1;
                        log_mapa[27, 17] = 1;
                        log_mapa[29, 17] = 1;
                        log_mapa[30, 17] = 1;
                        log_mapa[27, 18] = 1;
                        log_mapa[28, 18] = 1;
                        log_mapa[31, 18] = 1;
                        log_mapa[25, 19] = 1;
                        log_mapa[26, 19] = 1;
                        log_mapa[29, 19] = 1;
                        log_mapa[30, 19] = 1;
                        log_mapa[12, 21] = 1;
                        log_mapa[13, 21] = 1;
                        log_mapa[16, 21] = 1;
                        log_mapa[17, 21] = 1;
                        log_mapa[11, 22] = 1;
                        log_mapa[14, 22] = 1;
                        log_mapa[15, 22] = 1;
                        log_mapa[12, 23] = 1;
                        log_mapa[13, 23] = 1;
                        log_mapa[15, 23] = 1;
                        log_mapa[16, 23] = 1;
                        log_mapa[18, 23] = 1;
                        log_mapa[24, 23] = 1;
                        log_mapa[25, 23] = 1;
                        log_mapa[16, 24] = 1;
                        log_mapa[18, 24] = 1;
                        log_mapa[22, 24] = 1;
                        log_mapa[22, 25] = 1;
                        log_mapa[24, 25] = 1;
                        log_mapa[25, 25] = 1;
                        log_mapa[23, 26] = 1;
                        log_mapa[24, 26] = 1;
                        log_mapa[23, 27] = 1;
                        log_mapa[22, 28] = 1;
                        log_mapa[24, 28] = 1;
                        log_mapa[22, 29] = 1;
                        log_mapa[24, 29] = 1;
                        log_mapa[23, 30] = 1;


                        //Convercion de binario a string de Celulas vivas en mapa 

                        for (int t = 0; t < tamaño; t++) {
                            for (int p = 0; p < tamaño; p++) {
                                if (log_mapa[p, t] == 1) {

                                    mapa[p, t] = "O";
                                } else {
                                    mapa[p, t] = " ";
                                }
                            }
                        }

                        break;

                    case 4:
                        Console.WriteLine("caso 4");


                        //   i  j
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {

                                //   p  t
                                log_mapa[p, t] = r.Next(0, 2);
                            }
                        }

                        //Convercion de binario a string de Celulas vivas en mapa 
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {
                                if (log_mapa[p, t] == 1)
                                {

                                    mapa[p, t] = "O";
                                }
                                else
                                {
                                    mapa[p, t] = " ";
                                }

                            }
                        }

                        break;
                    case 5:
                        Console.WriteLine("caso 5");


                        //   i  j
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {

                                //   p  t
                                log_mapa[p, t] = r.Next(0, 2);
                            }
                        }

                        //Convercion de binario a string de Celulas vivas en mapa 
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {
                                if (log_mapa[p, t] == 1)
                                {

                                    mapa[p, t] = "O";
                                }
                                else
                                {
                                    mapa[p, t] = " ";
                                }

                            }
                        }

                        break;


                    case 6:
                        Console.WriteLine("Testing");
                        Thread.Sleep(retraso);

                        //   i  j
                        log_mapa[1, 1] = 1;
                        log_mapa[2, 1] = 1;
                        log_mapa[3, 1] = 1;

                        log_mapa[1, 2] = 1;
                        log_mapa[2, 2] = 1;
                        log_mapa[3, 2] = 1;

                        log_mapa[1, 3] = 1;
                        log_mapa[2, 3] = 1;
                        log_mapa[3, 3] = 1;




                        //Convercion de binario a string de Celulas vivas en mapa 
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {
                                if (log_mapa[p, t] == 1)
                                {

                                    mapa[p, t] = "O";
                                }
                                else
                                {
                                    mapa[p, t] = " ";
                                }

                            }
                        }


                        break;


                    default:

                        
                        Console.WriteLine("Default random");

                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {

                                //   p  t
                                log_mapa[p, t] = r.Next(0, 2);
                            }
                        }
                        //Convercion de binario a string de Celulas vivas en mapa 
                        for (int t = 0; t < tamaño; t++)
                        {
                            for (int p = 0; p < tamaño; p++)
                            {
                                if (log_mapa[p, t] == 1)
                                {

                                    mapa[p, t] = "O";
                                }
                                else
                                {
                                    mapa[p, t] = " ";
                                }

                            }
                        }

                        break;
                }
                //mensaje
                for (int ñ = 0; ñ < 5; ñ++) {

                    Console.WriteLine("Preparando simulación.");
                    Console.WriteLine("Para mejor observacion abra la consola al maximo.");

                    Thread.Sleep(retraso * 2);
                    Console.Clear();
                    Console.WriteLine("Preparando simulación..");
                    Console.WriteLine("Para mejor observacion abra la consola al maximo.");

                    Thread.Sleep(retraso * 3);
                    Console.Clear();
                    Console.WriteLine("Preparando simulación...");
                    Console.WriteLine("Para mejor observacion abra la consola al maximo.");

                    Thread.Sleep(retraso * 4);
                    Console.Clear();
                }


                //Mostrar mapa

                //estado inicial
                Console.WriteLine("Estado Inicial del mapa \n");
                for (int j = 0; j < (tamaño); j++)
                {
                    //filas mapa

                    /*fila con los valores de mapa*/
                    Console.WriteLine($"{mapa[0, j]} {mapa[1, j]} {mapa[2, j]} {mapa[3, j]} {mapa[4, j]} {mapa[5, j]} {mapa[6, j]} {mapa[7, j]} {mapa[8, j]} {mapa[9, j]} {mapa[10, j]} {mapa[11, j]} {mapa[12, j]} {mapa[12, j]} {mapa[14, j]} {mapa[15, j]} {mapa[16, j]} {mapa[17, j]} {mapa[18, j]} {mapa[19, j]} {mapa[20, j]} {mapa[21, j]} {mapa[22, j]} {mapa[23, j]} {mapa[24, j]} {mapa[25, j]} {mapa[26, j]} {mapa[27, j]} {mapa[28, j]} {mapa[29, j]} {mapa[30, j]} {mapa[31, j]} {mapa[32, j]} {mapa[32, j]} {mapa[34, j]} {mapa[35, j]} {mapa[36, j]} {mapa[37, j]} {mapa[38, j]} {mapa[39, j]}");
                    Thread.Sleep(200);

                }

                Console.Clear();

                for (int duracion = 0; duracion < Uduracion +1 ; duracion++)
                {
                    Console.WriteLine($"Simulación despues de: {duracion} veces. \n");

                    //ciclo por fila

                    /*Imprime cada fila y cambia a la siguiente 
                    * columna gracias al CICLO FOR */

                    //columnas mapa
                    for (int j  = 0; j < (tamaño); j++)
                    {
                        //filas mapa


                        /*fila con los valores de mapa*/
                        Console.WriteLine($"{mapa[0, j]} {mapa[1, j]} {mapa[2, j]} {mapa[3, j]} {mapa[4, j]} {mapa[5, j]} {mapa[6, j]} {mapa[7, j]} {mapa[8, j]} {mapa[9, j]} {mapa[10, j]} {mapa[11, j]} {mapa[12, j]} {mapa[12, j]} {mapa[14, j]} {mapa[15, j]} {mapa[16, j]} {mapa[17, j]} {mapa[18, j]} {mapa[19, j]} {mapa[20, j]} {mapa[21, j]} {mapa[22, j]} {mapa[23, j]} {mapa[24, j]} {mapa[25, j]} {mapa[26, j]} {mapa[27, j]} {mapa[28, j]} {mapa[29, j]} {mapa[30, j]} {mapa[31, j]} {mapa[32, j]} {mapa[32, j]} {mapa[34, j]} {mapa[35, j]} {mapa[36, j]} {mapa[37, j]} {mapa[38, j]} {mapa[39, j]}");

                    }
                    //Adaptacion mapa por simulacion//

                    //Recorrido por cada celula

                    for (int j = 0; j <= 39; j++) {
                        for (int i = 0; i <= 39; i++)
                        {
                            int Cel_vecinas_V = 0;





                            //Escaneo alrrededor de la celula en muestra

                            /* Console.WriteLine("valor de i {0} valor de j {1} Inicio de ciclo", i, j);
                             Console.ReadKey(); */

                            //guarda los valores iniciales de i,j
                            int vi = i;
                            int vj = j;

                            //-i -j (1)
                            if (((vi -1) > 0) && ((vj -1) > 0))
                            {

                                if (log_mapa[(vi - 1), (vj - 1)] == 1)
                                {
                                    Cel_vecinas_V++;
                                }
                            }
                          
                            vi = i;
                            vj = j;


                            // i -j (2)
                            if ((vj -1) > 0)
                            {

                                if (log_mapa[vi, (vj - 1)] == 1)
                                {
                                    Cel_vecinas_V++;
                                }

                            }
                            
                            vi = i;
                            vj = j;

                            // +i -j (3)
                            if (((vi +1) < tamaño) && ((vj -1) > 0))
                            {
                                
                                if (log_mapa[(vi + 1), (vj - 1)] == 1)
                                {
                                    Cel_vecinas_V++;
                                }
                            }
                           
                            vi = i;
                            vj = j;

                            // +i j (4)
                            if ((vi +1) < tamaño)
                            {
                                if (log_mapa[(vi + 1), vj] == 1)
                                {
                                Cel_vecinas_V++;
                                }
                            }
                           
                            vi = i;
                            vj = j;

                            // +i +j (5)
                          
                            if (((vi +1) < tamaño) && ((vj +1) < tamaño))
                            {
                                if (log_mapa[(vi + 1), (vj + 1)] == 1)
                                {
                                    Cel_vecinas_V++;
                                }
                            }
                           
                            vi = i;
                            vj = j;

                            // i +j (6)
                            if ((vj +1) < tamaño)
                            {

                                if (log_mapa[vi, (vj + 1)] == 1)
                                {
                                    Cel_vecinas_V++;
                                }
                            }
                            

                            vi = i;
                            vj = j;
                           

                            // -i +j (7)
                            if (((vi -1) > 0) && ((vj +1) < tamaño))
                            {

                                if (log_mapa[(vi - 1), (vj + 1)] == 1)
                                {
                                    Cel_vecinas_V++;

                                }
                            }
                           
                            vi = i;
                            vj = j;




                            // -i j (8)
                            if ((vi -1) > 0)
                            {

                                if (log_mapa[(vi -1), vj] == 1)
                                {
                                    Cel_vecinas_V++;
                                }
                            }
                           
                            


                            //Logica de revivir

                            /*   Console.WriteLine($"- Valores i:{i} \n - Valores j: {j}");
                               Console.WriteLine($"Valores celulas {Cel_vecinas_V}");
                               Console.WriteLine($"Valores {log_Amapa[i, j]}");
                               Console.ReadKey(); */
                            //Condicion Celula Muerta


                            if (log_mapa[i, j] != 1)
                            {
                                if (Cel_vecinas_V <= 3 && Cel_vecinas_V >= 3)
                                {
                                    log_Amapa[i, j] = 1;
                                }
                                else
                                {
                                    log_Amapa[i, j] = 0;
                                }
                            }
                            else if (log_mapa[i, j] == 1)
                            {
                                if (Cel_vecinas_V == 2 || Cel_vecinas_V == 3) {
                                    log_Amapa[i, j] = 1;
                                } else {
                                    log_Amapa[i, j] = 0;
                                }
                            }

                           
                          //  Console.WriteLine($"Valores i:{i} = {vi} \n - Valores j: {j} = {vj}");
                            //Console.WriteLine($"Valores {log_Amapa[i, j]}");
                         //   Console.ReadKey();
                        //    Console.Clear();


                        }
                    }

                    //conervir de binario a caracteres

                    for (int t = 0; t < tamaño; t++)
                    {
                        for (int p = 0; p < tamaño; p++)
                        {
                            if (log_Amapa[p, t] == 1)
                            {

                                AMapa[p, t] = "O";
                            }
                            else
                            {
                                AMapa[p, t] = " ";
                            }

                        }
                    }

                    //Actualizacion del mapa


                    for (int t = 0; t < tamaño; t++) {
                        for (int p = 0; p < tamaño; p++) {
                            if (log_Amapa[p, t] == 1) {

                                mapa[p, t] = "O";
                                log_mapa[p, t] = 1;
                            } else {
                                mapa[p, t] = " ";
                                log_mapa[p, t] = 0;
                            }
                        }
                    }

                    Thread.Sleep(retraso);
                    Console.Clear();
                }//Fin ciclo for de muestra

                Console.WriteLine("Fin de la simulacion Gracias por usar");

            }
            else {
                Console.WriteLine("error 404");
                Console.WriteLine(Espacios);
                Console.ReadKey();
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();

        }//final Main

       static void arranque(int retraso){
            for (int ñ = 0; ñ< 4; ñ++)
            {

                Console.WriteLine("Preparando Arranque de la simulación.");
                Console.WriteLine($"Iniciando en: {4-ñ}");
                Thread.Sleep(retraso);
                Console.Clear();
                Console.WriteLine("Preparando Arranque de la simulación..");
                Console.WriteLine($"Iniciando en: {4 - ñ}");
                Thread.Sleep(retraso* 2);
                Console.Clear();
                Console.WriteLine("Preparando Arranque de la simulación...");
                Console.WriteLine($"Iniciando en: {4 - ñ}");
                Thread.Sleep(retraso* 3);
                Console.Clear();
            }
}
  
        

    } //final Class Program

}