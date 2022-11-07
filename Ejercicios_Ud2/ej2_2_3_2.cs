/* (2.2.3.2) Crea un programa que escriba en pantalla los números del 1 al 50
 * que sean múltiplos de 3 (pista: habrá que recorrer todos esos números y
 * ver si el resto de la división entre 3 resulta 0).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_3_2
 {
     static void Main()
     {
         Console.WriteLine( "Los multiplo de 3 son: " );
         for (int i = 1 ; i <= 50 ; i++ )
         {
             if ( i % 3 == 0)
             {
                Console.Write( i + " " );
             }
         }
     }
 }
