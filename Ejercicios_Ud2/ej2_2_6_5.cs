/* (2.2.6.5) Dibuja un triángulo de asteriscos descendente. Por ejemplo, si
 * el usuario escoge "4" como tamaño, la primera fila tendrá 4 asteriscos,
 * la segunda tendrá 3, la siguiente tendrá 2 y la última tendrá 1.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_6_5
 {
     static void Main()
     {
         int tamanyo;
         
         Console.Write("Dime el tamaño: ");
         tamanyo = Convert.ToInt32(Console.ReadLine());
         
         for ( int i = 0 ; i < tamanyo ; i++ )
         {
             for ( int j = i ; j < tamanyo ; j++ )
             {
                 Console.Write("*");
             }
             Console.WriteLine();
         }
     }
 }
