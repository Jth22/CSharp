/* (2.2.7.1) Crea un programa que muestre las letras de la Z (mayúscula)
 * a la A (mayúscula, descendiendo).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
class ej2_2_7_1
{
    static void Main()
    {        
        for ( char letra = 'Z' ; letra >= 'A' ; letra--)
        {
            Console.Write(letra + " ");
        }
    }
} 
