/* (2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es
 *  par (pista: habrá que comprobar si el resto que se obtiene al dividir entre
 *  dos es cero: if (x % 2 == 0) …).
 * Por Jonathan Sirvent Pedreño
 */

using System;

class ej2_1_1_1
{
    static void Main()
    {
        int numeroUsuario;
        
        Console.Write("Dime un numero: ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        
        if (numeroUsuario%2 == 0)
        {
            Console.WriteLine("El numero {0} es par.", numeroUsuario);
        }
        else
        {
            Console.WriteLine("El numero {0} no es par.", numeroUsuario);
        }
    }
} 


