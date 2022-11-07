/*  (1.12.1) El usuario tecleará dos números (a y b), y el programa mostrará el
 * resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b2.
 * Ambos resultados se deben mostrar en la misma línea.
 * Por Jonathan Sirvent Pedreño
 */
 
 
 using System;
 
 class ej1_12_1
 {
     static void Main()
     {
         int a, b, resultado1, resultado2;
         
         Console.Write("Dime un numero: ");
         a = Convert.ToInt32(Console.ReadLine());
         Console.Write("Dime otro numero: ");
         b = Convert.ToInt32(Console.ReadLine());
         
         resultado1 = (a+b)*(a-b);
         resultado2 = (a*a)-(b*b);
         
         Console.WriteLine("El resultado de las operaciones es: ");
         Console.WriteLine("({0}+{1})*({2}-{3}) = {4}", a,b,a,b, resultado1);
         Console.WriteLine("({0}*{1})-({2}*{3}) = {4}", a,a,b,b, resultado2);
         
     }
 }
