/* (2.1.5.10) Crea un programa que pida al usuario dos números enteros y diga 
 * si son iguales o, en caso contrario, cuál es el mayor de ellos.
 * Por Jonathan Sirvent Pedreño
 */ 

using System;

class ej2_1_5_10
{
    static void Main()
    {
        int primerNumero, segundoNumero;
        
        Console.Write("Dime un numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime otro numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());
        
        if (primerNumero > segundoNumero)
        {
            Console.WriteLine("El numero {0} es mayor", primerNumero);
        }
        else if (primerNumero < segundoNumero)
        {
            Console.WriteLine("El numero {0} es mayor", segundoNumero);
        }
        else
        {
            Console.WriteLine("Los numeros son iguales");
        }
    }
}
