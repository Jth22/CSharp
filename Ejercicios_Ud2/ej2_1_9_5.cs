/* (2.1.9.5) Repite el ejercicio 2.1.9.2, empleando "if" en lugar de "switch"
 *  (pista: como las cifras numéricas del 0 al 9 están ordenadas, no hace
 *  falta comprobar los 10 valores, sino que se puede hacer con
 *  "if ((simbolo >= '0') && (simbolo <='9'))").
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga
 *  si se trata de un signo de puntuación (. , ; :), una cifra numérica
 *  (del 0 al 9) o algún otro carácter, usando "switch" (pista: necesitarás 
 * que usar un dato de tipo "char").
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_1_9_5
 {
     static void Main()
     {
         char c;
         
         Console.Write("Dime un caracter: ");
         c = Convert.ToChar(Console.ReadLine());
         
         if ( c == '.' || c == ',' || c == ';' || c== ':')
         {
             Console.WriteLine("Es un signo de puntuacion");
         }
                 
         if ( c >= '0' && c <= '9')
         {
             Console.WriteLine("Es un digito");
         }
         
          if (( c != '.' || c != ',' || c != ';' || c!= ':') 
            || !(c >= '0' && c <= '9'))
         {
             Console.WriteLine("Es algun caracter");
         }
         
         
    
     }
 }
