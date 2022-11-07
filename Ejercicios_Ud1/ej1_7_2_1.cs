/* (1.7.2.1) Amplía el ejercicio 1.7.1.1, para que las tres variables 
 * n1, n2, n3 estén declaradas en la misma línea y tengan valores iniciales.
 * Por Jonathan Sirvent Pedreño
 */
 
public class ej1_7_2_1
{
    public static void Main()
    {
        int n1= 3, n2 = 4, n3 = 5;
         
        System.Console.WriteLine("Ejemplo de precedencia de operadores");
        System.Console.Write("3 + 4 * 5 = ");
        System.Console.WriteLine(n1+n2*n3);
        
    }
}


