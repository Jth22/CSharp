/* (1.7.3.5) Amplía el ejercicio 1.7.2.2, para que se muestre la suma de los 
 * tres números.
 * Por Jonathan Sirvent Pedreño
 */

public class ej1_7_3_5
{
    public static void Main()
    {
        int n1= 3, n2 = 4, n3 = 5, suma;
         
        System.Console.WriteLine("Ejemplo de precedencia de operadores");
        System.Console.Write("3 + 4 * 5 = ");
        suma = n1 + n2 * n3;
        System.Console.WriteLine(suma);
    }
}


