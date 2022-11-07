/* (2.2.2.5) Crea un programa que pida al usuario su identificador y su 
 * contraseña, y no le permita seguir hasta que introduzca como nombre "Pedro"
 * y como contraseña "Peter".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_2_5
 {
     static void Main()
     {
          string identificador, contrasenya;
         
         do
         {
             Console.Write("Usuario? ");
             identificador = Console.ReadLine();
             
             if ( identificador != "Pedro" )
             {
                 Console.WriteLine("Usuario Erróneo!");
             }
         }
         while ( identificador != "Pedro" );
         
         do
         {
             Console.Write("Contrasenya? ");
             contrasenya = Console.ReadLine();
             if ( contrasenya != "Peter" )
             {
                 Console.WriteLine("Contrasenya erronea!!");
             }
         }
         while ( contrasenya != "Peter" );
         
         Console.WriteLine("Contraseny correcta!!");
     }
 }

