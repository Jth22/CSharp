/* (2.2.8.1) Crea un programa que escriba 6 líneas de texto, cada una de
 * las cuales estará formada por los números del 1 al 7. Debes usar dos
 * variables llamadas "linea" y "numero", y ambas deben estar declaradas
 * en el "for".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_8_1
 {
     static void Main()
     {         
         for ( int linea = 1; linea <= 6 ; linea++ )
         {
             for ( int numero = 1 ; numero <= 7 ; numero++ )
             {
                 Console.Write(numero);
             }
             Console.WriteLine();
         }
     }
 }
