/* (2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras
 * introducir cada par de números, responderá si el primero es múltiplo del
 * segundo, o el segundo es múltiplo del primero, o ninguno de ellos es
 * múltiplo del otro.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
class ej2_2_1_1_3
{
    static void Main()
    {
        int primerNumero = 1, segundoNumero = 1;
        
        while (primerNumero != 0 && segundoNumero != 0)
        {
            Console.Write("Dime un numero: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dime otro numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
             
            if (primerNumero != 0 && segundoNumero != 0)
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
            }
       }
    }
}
