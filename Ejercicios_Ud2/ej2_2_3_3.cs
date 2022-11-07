/* (2.2.3.3) Crea un programa que muestre los números del 100 al 200
 * (ambos incluidos) que sean divisibles entre 7 y a la vez entre 3.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_3_3
 {
     static void Main()
     {
         Console.WriteLine("Los multiplos de 3 y 7 simultaneamente son: ");
         
         for (int i = 100 ; i <= 200 ; i++)
         {
             if ( i % 3 == 0 && i % 7 == 0 )
             {
                 Console.Write(i + " ");
             }
         }
     }
 }
