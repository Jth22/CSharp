/* (2.1.5.7) Crea un programa que pida al usuario dos números enteros y diga si
 *  uno y sólo uno es par
 * Por Jonathan Sirvent Pedreño
 */

using System;
 
 class ej2_1_5_7
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if (((primerNumero % 2 == 0) && (segundoNumero % 2 != 0)) 
            || ((primerNumero % 2 != 0) && (segundoNumero % 2 == 0)))
         {
             Console.WriteLine("Solo un numero es par");
         }
         else
         {
             Console.WriteLine("O más de numero es par o nunguno es par ");
         }
     }
 }
