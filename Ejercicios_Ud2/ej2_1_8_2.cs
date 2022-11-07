/* (2.1.8.2) Usa el operador condicional para calcular el menor de dos números.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_8_2
 {
     static void Main()
     {
         int primerNumero, segundoNumero, menor;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otr numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         menor = primerNumero < segundoNumero ? primerNumero : segundoNumero;
         
         Console.WriteLine("El numero {0} es el menor", menor);
     }
 }
