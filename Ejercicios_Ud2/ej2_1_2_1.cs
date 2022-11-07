/* (2.1.2.1) Crea un programa que pida al usuario un número entero. Si es 
 * múltiplo de 10, informará al usuario y pedirá un segundo número, para decir 
 * a continuación si este segundo número también es múltiplo de 10.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_2_1
 {
     static void Main()
     {
         int primerNumero, segundoNumero;
         
         Console.Write("Dime un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         
         if (primerNumero % 10 == 0)
         {
             Console.WriteLine("El numero {0} es multiplo de 10", primerNumero);
             Console.Write("Dime otro numero: ");
             segundoNumero = Convert.ToInt32(Console.ReadLine());
             
             if ( segundoNumero % 10 == 0)
             {
                 Console.WriteLine("El numero {0} tambien es multiplo de 10 "
                    , segundoNumero);
             }
             else
             {
                  Console.WriteLine("El numero {0} no es multiplo de 10 "
                    , segundoNumero);
             }
         }
         else
         {
             Console.WriteLine("El numero {0} no es multiplo de 10"
                , primerNumero);
         }
     }
 }
 
