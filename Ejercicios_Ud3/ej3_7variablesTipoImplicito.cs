/* Ejercicio 3_7 Variables con tipo implicito
 * Por Jonathan Sirvent Pedreño
 */
 
 /*(3.7.1) Crea un programa que pida al usuario una cantidad de kilómetros y
  * muestre su equivalencia en millas. El valor de conversión debe estar en
  * una variable definida con "var".*/

using System;

class Ejercicio3_7_1
{
	static void Main()
	{
		const float MILLA = 1.60943f;
		float km;
		var kmMilla = 0f;
		try
		{
			Console.Write("Dime los kilometros a convertir en millas: ");
			km = Convert.ToSingle(Console.ReadLine());
			
			kmMilla = (float)km / MILLA;
			Console.WriteLine("{0} kilometros son {1} millas", km, kmMilla);
		}
		catch( FormatException e )
		{
			Console.WriteLine("Dato erróneo" + e.Message);
		}
	}
}
