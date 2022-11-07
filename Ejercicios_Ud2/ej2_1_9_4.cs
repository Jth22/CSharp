/* (2.1.9.4) Repite el ejercicio 2.1.9.1, empleando "if" en lugar de "switch".
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (2.1.9.1) Crea un programa que pida un número del 1 al 10 al usuario, y 
 * escriba el nombre de ese número, usando "switch" (por ejemplo, 
 * si introduce "1", el programa escribirá "uno").
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_4
 {
     static void Main()
     {
         int numeroUsuario;
         
         Console.Write("Dime un numero del 1 al 10: ");
         numeroUsuario = Convert.ToInt32(Console.ReadLine());
         
         if (numeroUsuario == 1)
         {
             Console.WriteLine("uno");
         }
          if (numeroUsuario == 2)
         {
             Console.WriteLine("dos");
         }
          if (numeroUsuario == 3)
         {
             Console.WriteLine("tres");
         }
          if (numeroUsuario == 4)
         {
             Console.WriteLine("cuatro");
         }
          if (numeroUsuario == 5)
         {
             Console.WriteLine("cinco");
         }
          if (numeroUsuario == 6)
         {
             Console.WriteLine("seis");
         }
          if (numeroUsuario == 7)
         {
             Console.WriteLine("siete");
         }
          if (numeroUsuario == 8)
         {
             Console.WriteLine("ocho");
         }
          if (numeroUsuario == 9)
         {
             Console.WriteLine("nueve");
         }
          if (numeroUsuario == 10)
         {
             Console.WriteLine("diez");
         }         
     }
 }








