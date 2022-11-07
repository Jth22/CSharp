/* (2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y
 * diga si se trata de una vocal, una cifra numérica o una consonante,
 * usando "switch".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_3
 {
     static void Main()
     {
         char c;
         
         Console.Write("Pulse una tecla: ");
         c = Convert.ToChar(Console.ReadLine());
         
         switch (c)
         {
             case 'a': 
             case 'e':
             case 'i':
             case 'o':
             case 'u': Console.WriteLine("Es una vocal"); break;
             case '0':
             case '1':
             case '2':
             case '3':
             case '4':
             case '5':
             case '6':
             case '7':
             case '8':
             case '9': Console.WriteLine("Es una cifra"); break;
             default: Console.WriteLine("Es una consonante"); break;
         }
     }
 }
