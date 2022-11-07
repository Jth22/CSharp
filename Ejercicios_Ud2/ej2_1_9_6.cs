/* (2.1.9.6) Repite el ejercicio 2.1.9.3, empleando "if" en lugar de "switch".
 * Por Jonathan Sirvent Pedreño
 */
 /* (2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y
 * diga si se trata de una vocal, una cifra numérica o una consonante,
 * usando "switch".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_6
 {
     static void Main()
     {
         char c;
         
         Console.Write("Escribe un caracter: ");
         c = Convert.ToChar(Console.ReadLine());
         
         if ( c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
         {
             Console.WriteLine("Es una vocal.");
         }else if ( c >= '0' && c <= '9')
         {
             Console.WriteLine("Es un digito");
         }
         else
         {
             Console.WriteLine("En una consonante");
         }
         
         
     }
 }
