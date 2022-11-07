/* (2.2.2.3) Crea un programa que escriba en pantalla los números pares del
 *  26 al 10 (descendiendo), usando "do..while".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_2_3
 {
     static void Main()
     {
         int numero = 26;
         
         do
         {
             Console.WriteLine(numero);
             numero -= 2;
         }
         while ( numero >= 10 && numero < 26);
     }
 }
