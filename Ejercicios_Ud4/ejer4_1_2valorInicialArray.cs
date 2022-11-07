/* Ejercicio 4_2_1 Valor icnial de arrya
 * Por Jonathan Sirvent Pedreño
 */
 
/* (4.1.2.1) Un programa que almacene en una tabla el número de días que tiene cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.*/

using System;

class Ejer4_1_2_1
{
	static void Main()
	{
		int[] diasMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int mes;
		
		try
		{
			Console.Write("Dime un mes: ");
			mes = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("El mes {0} tiene {1} días"
				,mes, diasMes[mes-1]);
		}
		catch( FormatException e )
		{
			Console.WriteLine("Dato erróneo" + e.Message);
		}
	}
}
 
