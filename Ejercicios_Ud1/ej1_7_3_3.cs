/* (1.7.3.3) Crea un programa que calcule el resto de dividir 3784 entre 16
 *  usando variables.
 * Por Jonathan Sirvent Pedreño
 */
 
 public class ej1_7_3_3
 {
     static void Main()
     {
         int primerNumero = 3784, segundoNumero = 16 , restoDivision;
         
         restoDivision = primerNumero % segundoNumero;
         
         System.Console.Write("El resto de la division de ");
         System.Console.WriteLine("{0} entre {1} es {2}", primerNumero
            , segundoNumero, restoDivision);
     }
 }
 
