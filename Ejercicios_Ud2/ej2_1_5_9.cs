/* (2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál 
 * es el mayor de los tres
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_5_9
 {
     static void Main()
     {
         int primerNumero, segundoNumero, tercerNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime un mas numero: ");
         tercerNumero = Convert.ToInt32(Console.ReadLine());
         
         if (primerNumero > segundoNumero && primerNumero > tercerNumero)
         {
             Console.WriteLine("El numero {0} es el mayor", primerNumero);
         }
         else if (primerNumero < segundoNumero && segundoNumero > tercerNumero)
         {
              Console.WriteLine("El numero {0} es el mayor", segundoNumero);
         }
         else
         {
             Console.WriteLine("El numero {0} es el mayor", tercerNumero);
         }
         
     }
 }
