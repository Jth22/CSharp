/* Dibujar triangulo invertido en función del dato introducido por el usuario
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class pruebas
{
	static void Main()
	{
		int ancho = 0, caracter, espacio = 0;
		do 
		{
			try
			{
				Console.WriteLine("Dime un valor mayor que \"3\""
					+ " y que no sea par... ");
				Console.Write("El valor es... ");
				ancho = Convert.ToInt32(Console.ReadLine());
			}
			catch ( FormatException e)
			{
				Console.WriteLine("Formato erróneo"+e.Message);
			}		
		}while ( ancho < 3 || ancho % 2 == 0);
		
		caracter = ancho;
		
		Console.WriteLine("El triángulo dibujado es: ");
		
		for ( int i = 0 ; i < (ancho/2)+1 ; i++ )// De esta manera se evita que se genere lineas innecesarias al final del triangulo
		{
			for ( int j = 0; j < espacio ; j++ )
				Console.Write(" ");
			for ( int j = caracter; j > espacio ; j--)
				Console.Write("*");
			for ( int j = 0; j < espacio ;j++)
				Console.Write(" ");
				
			Console.WriteLine();
			espacio += 1;
			caracter -=1;
		}
		Console.WriteLine();
		/* Con el siguiente código, llegamos al mismo objetivo, pero con un código
		 * más límpio y sin tanto bucle. Pero como no hemos visto los string
		 * no sé si se podía utilizar
		 */
		Console.WriteLine("El triángulo dibujado con otro código: ");
		caracter = ancho;
		espacio = 0;
		for (int i = 0 ; i < ancho ; i++ )
		{
			if ( caracter > 0 )
			{
				Console.Write(new string(' ',espacio));
				Console.Write(new string('*', caracter));		
				Console.WriteLine(new string(' ',espacio));
				espacio += 1;
				caracter -= 2;
			}	
		}
	}
}

