/* (2.1.9.8) Pide al usuario el un número de mes y escribe su nombre
 * (por ejemplo, si escribe 3, la respuesta debería ser "Marzo"),
 * usando "switch".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_8
 {
     static void Main()
     {
         int mes;
         
         Console.Write("Dime un mes: ");
         mes = Convert.ToInt32(Console.ReadLine());
         
         switch ( mes )
         {
             case 1: Console.WriteLine("Enero"); break;
             case 2: Console.WriteLine("Febrero"); break;
             case 3: Console.WriteLine("Marzo"); break;
             case 4: Console.WriteLine("Abril"); break;
             case 5: Console.WriteLine("Mayo"); break;
             case 6: Console.WriteLine("Junio"); break;
             case 7: Console.WriteLine("Julio"); break;
             case 8: Console.WriteLine("Agosto"); break;
             case 9: Console.WriteLine("Septiembre"); break;
             case 10: Console.WriteLine("Octubre"); break;
             case 11: Console.WriteLine("Noviembre"); break;
             case 12: Console.WriteLine("Diciembre"); break;
         }
     }
 }
