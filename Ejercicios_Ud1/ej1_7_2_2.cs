/* (1.7.2.2) Amplía el ejercicio 1.7.2.1, declarando también una variable 
 * "suma" y guardando en ella el resultado de sumar n1, n2 y n3.
 * Por Jonathan Sirvent Pedreño
 */
 

public class ej1_7_2_2
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


