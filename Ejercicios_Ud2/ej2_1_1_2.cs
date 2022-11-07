/*  (2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga 
 * cuál es el mayor de ellos.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_1_2
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if (primerNumero < segundoNumero)
         {
             Console.WriteLine("El numero {0} es el mayor", segundoNumero);
         }
         else
         {
             Console.WriteLine("El numero {0} es el mayor", primerNumero);
         }
     }
 }
 
 
