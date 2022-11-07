/* (2.2.7.2) Crea un programa que muestre 5 veces las letras de la
 * L (mayúscula) a la N (mayúscula), en la misma línea, empleando 
 * dos "for" anidados.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_7_2
 {
     static void Main()
     {
         for ( int i = 0 ; i < 5 ; i++ )
         {
             for ( char letra = 'L' ; letra <= 'N' ; letra++ )
             {
                 Console.Write(letra);
             }
             Console.WriteLine();
         }
     }
 }
