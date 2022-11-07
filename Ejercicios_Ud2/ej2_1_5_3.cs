/* (2.1.5.3) Crea un programa que pida al usuario un número entero y responda 
 * si es múltiplo de 2 pero no de 3.
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class ej2_1_5_3
{
    static void Main()
    {
        int numeroUsuario;
        
        Console.Write("Dime un numero: ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        
        if (( numeroUsuario % 2 == 0) && (numeroUsuario% 3 != 0)) 
        {
            Console.WriteLine("El numero {0} es multiplo de 2, pero no de 3"
                , numeroUsuario);
        }
        
        if (( numeroUsuario % 2 == 0) && (numeroUsuario % 3 == 0))
        {
            Console.WriteLine("El numero {0} es multiplo de 2 pero tambien de 3"
                ,numeroUsuario);
        }
        
        if (( numeroUsuario % 2 != 0) && (numeroUsuario % 3 != 0))
        {
            Console.WriteLine("El numero {0} no es multiplo de 2 ni de 3"
                ,numeroUsuario);
        }
    }
}
