/* (2.1.3.1) Crea un programa que multiplique dos números enteros de la 
 * siguiente forma: pedirá al usuario un primer número entero. Si el número
 *  que se que teclee es 0, escribirá en pantalla "El producto de 0 por
 *  cualquier número es 0". Si se ha tecleado un número distinto de cero,
 *  se pedirá al usuario un segundo número y se mostrará el producto de ambos.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_3_1
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         
         if ( primerNumero != 0 )
         {
             Console.Write("Dime otro numero: ");
             segundoNumero = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("El resultado del producto de {0} * {1} es {2}"
                ,primerNumero, segundoNumero, primerNumero*segundoNumero);
         }
         else
         {
             Console.WriteLine("El producto de 0 por cualquier numero es 0");
         }
     }
 }
 
