/* (2.2.2.2) Crea un programa que escriba en pantalla los números del 1 al 10,
 * usando "do..while".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_2_2
 {
     static void Main()
     {
         int numero = 0;
         
         do
         {
             numero += 1;
             Console.WriteLine(numero);
         }
         while (numero < 10);
     }
 }
