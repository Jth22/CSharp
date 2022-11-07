/* (2.2.6.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4)
 * y el alto (por ejemplo, 3) y escriba un rectángulo formado por esa
 * cantidad de asteriscos:
****
****
****
* Por Jonathan Sirvent Pedreño
*/

using System;

class ej2_2_6_2
{
    static void Main()
    {
        int ancho, alto;
        
        Console.Write("ancho: ");
        ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("alto: ");
        alto = Convert.ToInt32(Console.ReadLine());
        
        for ( int i = 0 ; i < alto ; i++ )
        {
            for ( int j = 0 ; j < ancho ; j++ )
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
