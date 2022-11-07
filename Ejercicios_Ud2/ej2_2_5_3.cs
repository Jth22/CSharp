/* (2.2.5.3) Crea un programa que, para los números entre el 10 y el 20
 * (ambos incluidos) diga si son divisibles entre 5, si son divisibles
 * entre 6 y si son divisibles entre 7, usando dos bucles anidados.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_5_3
 {
     static void Main()
     {
         for (int i = 10 ; i <= 20 ; i++ )
         {
             for (int j = i ; j % 3 == 0 || j % 6 == 0 || j % 7 == 0 ; j++ )
             {
                 if ( j % 3 == 0 )
                 {
                     Console.WriteLine("{0} es divisible por 3", j);
                 }
                 if ( j % 6 == 0 )
                 {
                     Console.WriteLine("{0} es divisible por 6", j);
                 }
                 if ( j % 7 == 0 )
                 {
                     Console.WriteLine("{0} es divisible por 7", j);
                 }
             }
         }
     }
 }
