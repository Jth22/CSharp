/* (1.11.1) Crea una nueva versión del programa que calcula el producto de dos 
 * números introducidos por el usuario (1.10.1), empleando "using System". El 
 * programa deberá contener un comentario al principio, que recuerde cual es su 
 * objetivo
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
  public class ej1_10_1
 {
     static void Main()
     {
         int numero1Usuario, num2Usuario, producto;
         
         Console.Write("Escribe un numero: ");
         numero1Usuario = Convert.ToInt32(Console.ReadLine());
         Console.Write("Escribe otro numero: ");
         num2Usuario = Convert.ToInt32(Console.ReadLine());
         
         producto = numero1Usuario * num2Usuario;
         
         Console.Write("El resultado del producto de {0} por {1} es {2}"
            ,numero1Usuario, num2Usuario, producto);
     }
 }
