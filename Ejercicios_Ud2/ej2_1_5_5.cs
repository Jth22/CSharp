/* (2.1.5.5) Crea un programa que pida al usuario dos números enteros y diga 
 * si ambos son pares
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_5_5
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if ((primerNumero % 2 == 0) && (segundoNumero % 2 == 0))
         {
             Console.WriteLine("Ambos numeros son pares simultaneamente");
         }
         else
         {
             Console.WriteLine("Puede que un numero o bien los dos no sean par ");
         }
        
     }
 }
 
