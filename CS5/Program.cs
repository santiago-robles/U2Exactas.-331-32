using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            //sesión 12: Instruccion while 3009026

            //SINTAXIS WHILE
            //inicializacion;
            //while //(expresion)
            //{
            //bloque de instruciiones
            //iterador;
            //}
            //iterar: repetir
            // ejemplo 1: ciclo ascendente (rango 1-3)
            int i = 1;

            while (i <= 10) {
                Console.WriteLine($"Iterador {i}");
                i++;
            }


            // ejercitacion

            int m = 1;

            while (m < 6) {
                Console.WriteLine($"Rodrigo Franza");
                m++;
            }

            int d = 10;

            while (d > 0) {
                Console.WriteLine(d);
                d--;
            }

            // secuencia 3 6 9 12 15 18

            int s = 3;

            while (s <= 18) {
                Console.WriteLine($"Numero: {s}");
                s += 3;
            }

            int a = 16;


            while (a >= 1) {
                Console.WriteLine("331");
                a -= 2;
            }

            /*
            Actividadd 1: Ciclo infinito

            1. Definir un ciclo infinito ascendente.
            2. Definir un ciclo infinito descendente.

            NOTA: Utilizar el operador de diferencia
            */

            // Ascendente

            int f = 1;

            while (f > 0) {
                Console.WriteLine(f);
                f++;
            }

            // Descendente

            int g = 99;

            while (g != 100) {
                Console.WriteLine(g);
                g--;
            }
        }
    }
}