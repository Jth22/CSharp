/* (2.1.9.1) Crea un programa que pida un número del 1 al 10 al usuario, y 
 * escriba el nombre de ese número, usando "switch" (por ejemplo, 
 * si introduce "1", el programa escribirá "uno").
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_1
 {
     static void Main()
     {
         int numeroUsuario;
         
         Console.Write("Dime un numero del 1 al 10: ");
         numeroUsuario = Convert.ToInt32(Console.ReadLine());
         
         switch(numeroUsuario)
         {
             case 1: Console.WriteLine("uno"); break;
             case 2: Console.WriteLine("dos"); break;
             case 3: Console.WriteLine("tres"); break;
             case 4: Console.WriteLine("cuatro"); break;
             case 5: Console.WriteLine("cinco"); break;
             case 6: Console.WriteLine("seis"); break;
             case 7: Console.WriteLine("siete"); break;
             case 8: Console.WriteLine("ocho"); break;
             case 9: Console.WriteLine("nueve"); break;
             case 10: Console.WriteLine("diez"); break;
             default: Console.WriteLine("Un numero del 1 al 10"); break;
         }
     }
 }







