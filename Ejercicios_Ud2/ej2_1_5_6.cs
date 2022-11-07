/* (2.1.5.6) Crea un programa que pida al usuario dos números enteros y diga si
 *  (al menos) uno es par.
 * Por Jonathan Sirvent Pedreño
 */
 
using System;
 
 class ej2_1_5_6
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if ((primerNumero % 2 == 0) || (segundoNumero % 2 == 0))
         {
             Console.WriteLine("Al menos un numero es par");
         }
         else
         {
             Console.WriteLine("Ninguno es par");
         }
        
     }
 }
