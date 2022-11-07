/* Ejercicio 5.8. El orden no importa
 * Por Jonathan Sirvent Pedreño
 */
 
 /*(5.8.1) Crea una nueva versión del ejercicio 5.7.1, en el que la función "Intercambiar" esté declarada después de “Main”.*/
 
 using System;
 
 class Ej5_8_1
 {
    static void Main()
    {
	int n = 5; 
	Console.WriteLine("n vale {0}", n);
	Duplicar(n);
	Console.WriteLine("Ahora n vale {0}", n); 
    }
    static void Duplicar(int x) 
    {
	Console.WriteLine(" El valor recibido vale {0}", x);
	x = x * 2;
	Console.WriteLine(" y ahora vale {0}", x);
    }
 }
