/* (2.1.9.7) Pide al usuario el número de un día de la semana y escribe 
 * su nombre (por ejemplo, si escribe 2, la respuesta debería ser "Martes").
 * Hazlo primero con "if" y después con "switch".
 * Por Jonathan Sirvent Pedreño
 */
 using System;
 
 class ej2_1_9_7
 {
     static void Main()
     {
         int diaSemana;
         
         Console.Write("Dime un dia: ");
         diaSemana = Convert.ToInt32(Console.ReadLine());
         
         if ( diaSemana == 1)
         {
             Console.WriteLine("Lunes");
         }
         if ( diaSemana == 2)
         {
             Console.WriteLine("Martes");
         }
         if ( diaSemana == 3)
         {
             Console.WriteLine("Miercoles");
         }
         if ( diaSemana == 4)
         {
             Console.WriteLine("Jueves");
         }
         if ( diaSemana == 5 )
         {
             Console.WriteLine("Viernes");
         }
         if ( diaSemana == 6)
         {
             Console.WriteLine("Sabado");
         }
         if ( diaSemana == 7)
         {
             Console.WriteLine("Domingo");
         }
         
         switch ( diaSemana )
         {
             case 1: Console.WriteLine("Lunes"); break;
             case 2: Console.WriteLine("Martes"); break;
             case 3: Console.WriteLine("Miercoles"); break;
             case 4: Console.WriteLine("Jueves"); break;
             case 5: Console.WriteLine("Viernes"); break;
             case 6: Console.WriteLine("Sabado"); break;
             case 7: Console.WriteLine("Domingo"); break;
         }
     }
 }
