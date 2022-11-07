/* (2.2.3.5) Crea un programa que muestre los primeros ocho números 
 * pares: 2 4 6 8 10 12 14 16 (pista: en cada pasada habrá que aumentar
 * de 2 en 2, o bien mostrar el doble del valor que hace de contador).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;

 class ej2_2_3_5
 {
     static void Main()
     {
         Console.WriteLine("los primeros ocho números pares son : ");
         for ( int i = 2 ; i <= 16 ; i+=2 )
         {
             Console.Write(i + " ");
         }
     }
 }

