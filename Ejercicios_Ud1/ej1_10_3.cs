/* (1.10.3) Suma tres números tecleados por usuario.
 * Por Jonathan Sirvent Pedreño
 */

public class ej1_10_3
{
    static void Main()
    {
        int primerNumero, segundoNumero, tercerNumero, suma = 0;
        
        System.Console.Write("Escribe un numero: ");
        primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Escribe otro numero: ");
        segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Escribe un numero mas: ");
        tercerNumero = System.Convert.ToInt32(System.Console.ReadLine());
        
        suma = primerNumero + segundoNumero + tercerNumero;
        
        System.Console.WriteLine("{0} + {1} + {2} = {3}", primerNumero
            , segundoNumero, tercerNumero, suma);
    }
}
