/* (2.2.6.3) Haz un programa que dibuje un cuadrado de asteriscos, cuyo
 * ancho (y alto, que tendrá el mismo valor) será introducido por el usuario.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_6_3
 {
     static void Main()
     {
         int ancho, alto;
         
         Console.Write("Dime el ancho: ");
         ancho = Convert.ToInt32(Console.ReadLine());
         alto = ancho;
         
         for ( int i = 1 ; i <= ancho ; i++ )
         {
             for (int j = 1 ; j <= alto ; j++ )
             {
                 Console.Write("*");
             }
             Console.WriteLine();
         }
     }
 }
