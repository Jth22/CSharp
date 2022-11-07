/* (2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga 
 * si el primero es múltiplo del segundo (pista: igual que en el 
 * ejercicio 2.1.1.1, habrá que ver si el resto de la división 
 * es cero: a % b == 0).
 *  Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_1_3
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if (primerNumero % segundoNumero == 0)
         {
             Console.WriteLine("El numero {0} es multiplo de numero {1}"
                , primerNumero, segundoNumero);
         }
         else
         {
            Console.WriteLine("El numero {0} no es multiplo de numero {1}"
                , primerNumero, segundoNumero); 
         }
     }
 }
