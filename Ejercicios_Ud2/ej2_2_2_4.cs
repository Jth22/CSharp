/* (2.2.2.4) Crea un programa que pida al usuario su identificador y su
 * contraseña (ambos numéricos), y no le permita seguir hasta que introduzca
 * como identificador "1234" y como contraseña "1111".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_2_4
 {
     static void Main()
     {
         int identificador, contrasenya;
         
         do
         {
             Console.Write("Usuario? ");
             identificador = Convert.ToInt32(Console.ReadLine());
             
             if ( identificador != 1234 )
             {
                 Console.WriteLine("Usuario Erróneo!");
             }
         }
         while ( identificador != 1234 );
         
         do
         {
             Console.Write("Contrasenya? ");
             contrasenya = Convert.ToInt32(Console.ReadLine());
             if ( contrasenya != 1111 )
             {
                 Console.WriteLine("Contrasenya erronea!!");
             }
         }
         while ( contrasenya != 1111 );
         
         Console.WriteLine("Contraseny correcta!!");
     }
 }
