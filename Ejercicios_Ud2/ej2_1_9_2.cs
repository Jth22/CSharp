/* (2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga
 *  si se trata de un signo de puntuación (. , ; :), una cifra numérica
 *  (del 0 al 9) o algún otro carácter, usando "switch" (pista: necesitarás 
 * que usar un dato de tipo "char").
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_2
 {
     static void Main()
     {
         char c;
         
         Console.Write("Pulse una tecla: ");
         c = Convert.ToChar(Console.ReadLine());
         
         switch (c)
         {
             case '.': 
             case ',':
             case ';':
             case ':': Console.WriteLine("Es un signo de puntuación"); break;
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
             default: Console.WriteLine("Es otro caracter"); break;
         }
     }
 }
