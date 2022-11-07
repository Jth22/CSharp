/* (2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de números
 *  al usuario. Tras introducir cada par de números, responderá si el primero
 * es múltiplo del segundo. Se repetirá mientras los dos números sean distintos
 * de cero (terminará cuando uno de ellos sea cero).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
class ej2_2_1_1_3
{
    static void Main()
    {
        int primerNumero, segundoNumero;
        
        Console.Write("Dime un numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime otro numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());
        
        while (primerNumero != 0 && segundoNumero != 0)
        {
            if ( primerNumero % segundoNumero == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de {1}"
                    ,primerNumero, segundoNumero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es multiplo de {1}"
                    ,primerNumero, segundoNumero);
            }
           
            Console.Write("Dime un numero: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dime otro numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
       }
    }
}
