/* (2.2.14.1) Crea un programa que escriba los números del 1 al 10, separados
 * por un espacio, sin avanzar de línea. No puedes usar "for", ni "while",
 * ni "do..while", sólo "if" y "goto".
 * Por Jonathan Sirvent Pedreño
*/

using System;

class ej2_2_14_1
{
	static void Main()
	{
		int i = 1;
		
		repetir:
		if ( i <= 10 )
		{
			Console.Write(i + " ");
			i++;
			goto repetir;
		}
	}
}
