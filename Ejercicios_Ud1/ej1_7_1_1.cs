/* (1.7.1.1): Amplía el "Ejemplo 01.06.02a" para declarar tres variables,
 * llamadas n1, n2, n3.
 * Por Jonathan Sirvent Pedreño
 */
 
public class ej1_7_1_1
{
    public static void Main()
    {
        int n1 = 3;
        int n2 = 4;
        int n3 = 5;
         
        System.Console.WriteLine("Ejemplo de precedencia de operadores");
        System.Console.Write("3 + 4 * 5 = ");
        System.Console.WriteLine(n1+n2*n3);
    }
}

