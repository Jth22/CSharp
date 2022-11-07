/*  (1.12.4) Crea un programa que convierta de grados Celsius (centígrados) a 
 * Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y 
 * usará las siguiente tablas de conversión: kelvin = celsius + 273 ; 
 * fahrenheit = celsius x 18 / 10 + 32. Emplea "Write" en vez de "{0}" cuando debas 
 * mostrar varios datos en la misma línea.
 * Por Jonathan Sirvent Pedreño
 */
using System;

class ej1_12_4
{
    static void Main()
    {
        int celsius, fahrenheit, kelvin;
        
        Console.Write("Dime cuantos grados clesius quieres convertir? ");
        celsius = Convert.ToInt32(Console.ReadLine());
        
        fahrenheit = celsius * 18 / 10 + 32;
        kelvin = celsius + 273;
        
        Console.Write(celsius+ "º centigrados son : ");
        Console.Write(kelvin + "º Kelvin o ");
        Console.WriteLine(fahrenheit + "º Fahrenheit.");
    }
}
