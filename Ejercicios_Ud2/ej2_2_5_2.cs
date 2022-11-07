/* (2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en
 * una misma línea, usando "while": 12345123451234512345.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_5_2
 {
     static void Main()
     {
         int i = 1, j;
         
         while ( i <= 4)
         {
             j = 1; 
             while ( j <= 5 )
             {
                 Console.Write(j);
                 j++;
             }
             i++;
         }
     }
 }
