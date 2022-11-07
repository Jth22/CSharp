/* Ejercicio 5.7.4. Una aplicación de los parámetros de salida: pedir números sin try-catch (TryParse)
 * Por Jonathan Sirvent Pedreño
 */
 
 /*(5.7.4.1) Crea un programa que te pida tu edad tantas veces como sea necesario, hasta que introduzcas un valor numérico aceptable.*/
 
 using System;
 
 class ej5_7_4_1
 {
    static void Main()
    {
	int edad;
	
	do
	{
	    Console.WriteLine("Dime tu edad: ");
	    Console.Write("? ");
	    if (Int32.TryParse(Console.ReadLine(), out edad))
		if (edad >= 0 && edad <= 100)
		    Console.WriteLine("Te conservas bien");
		else
		    Console.WriteLine("Imposible que tengas esa edad");
	    else
		Console.WriteLine("Fuera de Rango");
	}while(edad < 0 || edad > 100);
    }
 }
