/* (2.2.1.1.2) Crea un "calculador de cuadrados": pedirá al usuario un
 * número y mostrará su cuadrado. Se repetirá mientras el número introducido
 * no sea cero (usa "while" para conseguirlo).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_1_1_2
 {
     static void Main()
     {
         int numero = 1;
         
         while ( numero != 0)
         {
             Console.Write("Dime un numero: ");
             numero = Convert.ToInt32(Console.ReadLine());
             
             if ( numero != 0 )
             {
                Console.Write("El cuadrado de {0} es: ", numero);
                Console.WriteLine( numero * numero );
             }
         }
     }
 }
