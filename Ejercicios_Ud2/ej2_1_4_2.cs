/* (2.1.4.2) Mejora la solución al ejercicio 2.1.3.2, usando "else".
 * Por Jonathan Sirvent Pedreño
 */
 
/* (2.1.3.2) Crea un programa que pida al usuario dos números enteros. Si el 
 * segundo no es cero, mostrará el resultado de dividir el primero entre
 *  el segundo. Por el contrario, si el segundo número es cero, escribirá
 *  "Error: No se puede dividir entre cero"
 * Por Jonathan Sirvent Pedreño
 */
 
using System;
 
 class Ej2_1_4_2
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if ( segundoNumero != 0 )
         {
            Console.WriteLine("El resultado del dividir de {0} entre {1} es {2}"
                ,primerNumero, segundoNumero, primerNumero/segundoNumero);
         }
         else
         {
             Console.WriteLine("Error: No se puede dividir entre cero");
         }
     }
 }
