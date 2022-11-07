/*(1.7.3.1) Crea un programa que calcule el producto de los números 121 y 132, 
* usando variables
* Por Jonathan Sirvent Pedreño
*/

public class ej1_7_3_1
{
    static void Main()
    {
        int primerNumero = 121, segundoNumero = 132, producto;
        
        producto = primerNumero * segundoNumero;
        
        System.Console.Write("El producto del numero {0} ", primerNumero);
        System.Console.WriteLine("por el numero {0} es {1}"
            , segundoNumero, producto);
    }
}
