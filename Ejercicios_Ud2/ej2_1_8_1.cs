/* (2.1.8.1) Crea un programa que use el operador condicional para mostrar el 
 * valor absoluto de un número de la siguiente forma: si el número es positivo,
 *  se mostrará tal cual; si es negativo, se mostrará cambiado de signo.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_8_1
 {
     static void Main()
     {
         int primerNumero, valor;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         
         valor = (primerNumero > 0) ? primerNumero : -primerNumero;
         
         Console.WriteLine("El valor del numero es {0} ", valor);
     }
 }

