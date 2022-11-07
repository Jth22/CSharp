/* (2.2.3.6) Crea un programa que muestre los números del 15 al 5, 
 * descendiendo (pista: en cada pasada habrá que descontar 1, por ejemplo 
 * haciendo i=i-1, que se puede abreviar i--).
 * Por Jonathan Sirvent Pedreño
 */

using System;

class ej2_2_3_6
{
    static void Main()
    {
        Console.WriteLine("Números descendentes del 15 al 5: ");
        for ( int i = 15 ; i >= 5  ; i-- )
        {
            Console.Write( i + "  " );
        } 
    }
}
