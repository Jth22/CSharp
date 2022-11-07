/* (1.10.1) Crea un programa que calcule el producto de dos números introducidos
 *  por el usuario.
 * Por Jonathan Sirvent Pedreño
 */
 
 public class ej1_10_1
 {
     static void Main()
     {
         int numero1Usuario, num2Usuario, producto;
         
         System.Console.Write("Escribe un numero: ");
         numero1Usuario = System.Convert.ToInt32(System.Console.ReadLine());
         System.Console.Write("Escribe otro numero: ");
         num2Usuario = System.Convert.ToInt32(System.Console.ReadLine());
         
         producto = numero1Usuario * num2Usuario;
         
         System.Console.Write("El resultado del prodcuto de {0} por {1} es {2}"
            ,numero1Usuario, num2Usuario, producto);
     }
 }
