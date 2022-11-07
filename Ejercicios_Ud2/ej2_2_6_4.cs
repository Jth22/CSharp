/* (2.2.6.4) Crea un triángulo de asteriscos, que mostrará uno en la primera
 * fila, dos en la segunda, tres en la tercera y así sucesivamente, hasta
 * llegar al tamaño indicado por el usuario.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_6_4
 {
     static void Main()
     {
         int tamanyo;
         
         Console.Write("Dime el tamaño: ");
         tamanyo = Convert.ToInt32(Console.ReadLine());
         
         for ( int i = 0 ; i < tamanyo ; i++ )
         {
             for ( int j = 0 ; j <= i ; j++ )
             {
                 Console.Write("*");
             }
             Console.WriteLine();
         }
     }
 }
