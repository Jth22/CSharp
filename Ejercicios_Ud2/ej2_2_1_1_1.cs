/* (2.2.1.1.1) Crea un programa que pida al usuario su contraseña (numérica). 
 * Deberá terminar cuando introduzca como contraseña el número 1111, pero
 *  volvérsela a pedir tantas veces como sea necesario.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_1_1_1
 {
     static void Main()
     {
         int contrasenya = 0;
         
         while ( contrasenya != 1111 )
         {
             Console.Write("Escribe el password: ");
             contrasenya = Convert.ToInt32(Console.ReadLine());
             
             if (contrasenya != 1111 )
             {
                 Console.WriteLine("Error!!");
             }
         }
         Console.WriteLine("Contraseña Correcta!!");
     }
 }



