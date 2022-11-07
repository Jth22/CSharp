/* (1.7.3.4) Amplía el ejercicio 1.7.2.1, para que se muestre el resultado de 
 * la operación n1+n2*n3.
 * Por Jonathan Sirvent Pedreño
 */
 
 public class ej1_7_3_4
{
    public static void Main()
    {
        int n1= 3, n2 = 4, n3 = 5, resultado;
         
        System.Console.WriteLine("Ejemplo de precedencia de operadores");
        System.Console.WriteLine("3 + 4 * 5 = ");
        resultado = n1 + n2 * n3;
        
        System.Console.WriteLine("El resultado es {0}", resultado);
        
    }
}

