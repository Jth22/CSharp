/* (2.1.5.4) Crea un programa que pida al usuario un número entero y responda 
 * si no es múltiplo de 2 ni de 3.
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class ej2_1_5_1
{
    static void Main()
    {
        int numeroUsuario;
        
        Console.Write("Dime un numero: ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        
     
        if (( numeroUsuario % 2 == 0) || (numeroUsuario % 3 == 0))
        {
            Console.WriteLine("Lo siento {0} es multiplo de 2 o de 3"
                ,numeroUsuario);
        }
        
        if (( numeroUsuario % 2 != 0) && (numeroUsuario % 3 != 0))
        {
            Console.WriteLine("El numero {0} no es multiplo de 2 ni de 3"
                ,numeroUsuario);
        }
    }
}
