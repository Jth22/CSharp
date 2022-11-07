/*(1.11.2) Crea una nueva versión del programa que calcula la división de dos
 * números introducidos por el usuario, así como el resto de esa división (1.10.2), 
 * empleando "using System". Deberás incluir un comentario con tu nombre y la 
 * fecha en que has realizado el programa.
 * Por Jonathan Sirvent Pedreño 08/09/2022
 */
 using System;
  
  public class ej1_11_2
 {
     static void Main()
     {
         int primerNumero, segundoNumero, division = 0, resto = 0;
         
         Console.Write("Escribe un numero: ");
         primerNumero = Convert.ToInt32(Console.ReadLine());
         Console.Write("Escribe otro numero: ");
         segundoNumero = Convert.ToInt32(Console.ReadLine());
         
         if (segundoNumero != 0)
         {
            division = primerNumero / segundoNumero;
            resto = primerNumero % segundoNumero;
            Console.WriteLine("La division de {0} entre {1} es {2}"
                ,primerNumero, segundoNumero, division);
            Console.WriteLine("El resto de division de {0} entre {1} es {2}"
                ,primerNumero, segundoNumero, resto);
         }
         else
         {
             Console.WriteLine("No se puede dividir por cero");
         }  
     }
 }
