/* (2.1.5.8) Crea un programa que pida al usuario dos números enteros y diga 
 * "Uno de los números es positivo", "Los dos números son positivos" o
 *  bien "Ninguno de los números es positivo", según corresponda.
 * Por Jonathan Sirvent Pedreño
 */

using System;
 
 class ej2_1_5_8
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if ((primerNumero > 0) && (segundoNumero > 0))
         {
             Console.WriteLine("Ambos numeros son positivos");
         }
         else if ((primerNumero < 0) && (segundoNumero < 0))
         {
             Console.WriteLine("Ambos numeros son negativos");
         }
         else
         {
             Console.WriteLine("Algun numero es positivo");
         }
        
     }
 }
