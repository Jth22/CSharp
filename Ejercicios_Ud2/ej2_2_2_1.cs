/* (2.2.2.1) Crea un programa que pida números positivos al usuario, y vaya
 * calculando y mostrando la suma de todos ellos (terminará cuando se teclea
 * un número negativo o cero).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_2_1
 {
     static void Main()
     {
         int numeroUsuario, suma = 0;
         
         do
         {
             Console.Write("Dame un numero: ");
             numeroUsuario = Convert.ToInt32(Console.ReadLine());
             
             if ( numeroUsuario > 0)
             {
                suma += numeroUsuario;
                Console.WriteLine("La suma de todos los numeros es: " + suma);
            }
         }
         while ( numeroUsuario > 0);
     }
 }




