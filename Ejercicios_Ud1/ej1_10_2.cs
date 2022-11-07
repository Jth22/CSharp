/* (1.10.2) Crea un programa que calcule la división de dos números introducidos
 *  por el usuario, así como el resto de esa división.
 * Por Jonathan Sirvent Pedreño
 */
 
 public class ej1_10_2
 {
     static void Main()
     {
         int primerNumero, segundoNumero, division = 0, resto = 0;
         
         System.Console.Write("Escribe un numero: ");
         primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
         System.Console.Write("Escribe otro numero: ");
         segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
         
         if (segundoNumero != 0)
         {
            division = primerNumero / segundoNumero;
            resto = primerNumero % segundoNumero;
            System.Console.WriteLine("La division de {0} entre {1} es {2}"
                ,primerNumero, segundoNumero, division);
            System.Console.WriteLine("El resto de division de {0} entre {1} es {2}"
                ,primerNumero, segundoNumero, resto);
         }
         else
         {
             System.Console.WriteLine("No se puede dividir por cero");
         }  
     }
 }
