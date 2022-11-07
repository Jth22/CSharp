/* (2.1.5.2) Crea un programa que pida al usuario un número entero y responda 
 * si es múltiplo de 2 y de 3 simultáneamente.
 * Por Jonathan Sirvent Pedreño
 */
 using System;

class ej2_1_5_2
{
    static void Main()
    {
        int numeroUsuario;
        
        Console.Write("Dime un numero: ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        
        if (( numeroUsuario % 2 == 0 ) && (numeroUsuario % 3 == 0))
        {
            Console.WriteLine("El numero {0} es multiplo de 2 y tambien de 3"
                , numeroUsuario);
        }
        
        if ((numeroUsuario % 2 == 0) || (numeroUsuario % 3 == 0))
        {
            Console.WriteLine("El numero {0} puede ser multiplo de 2 o de 3"
                , numeroUsuario);
        }
        
        if (( numeroUsuario % 2 != 0) && (numeroUsuario % 3 != 0))
        {
            Console.WriteLine("El numero {0} no es multiplo de 2 ni de 3"
                ,numeroUsuario);
        }
    }
}
