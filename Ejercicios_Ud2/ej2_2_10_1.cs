/* (2.2.10.1) Crea un programa que pida al usuario dos números y escriba 
 * su máximo común divisor (pista: una solución lenta pero sencilla es probar
 * con un "for" todos los números descendiendo a partir del menor de ambos,
 * hasta llegar a 1; cuando encuentres un número que sea divisor de ambos,
 * interrumpe la búsqueda con "break").
 * Por Jonathan Sirvent Pedreño
 */
 
 using System; 
 
 class ej2_2_10_1
 {
	 static void Main()
	 {
		int primerNumero, segundoNumero;
		
		Console.Write("Dime el primer número? ");
		primerNumero = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime el segundo número? ");
		segundoNumero = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("El MCD de {0} y {1} es: ", primerNumero, segundoNumero);
		if ( primerNumero < segundoNumero )
		{
			for ( int i = primerNumero ; i > 0 ; i-- )
			{
				if ( primerNumero % i == 0 && segundoNumero % i == 0)
				{
					Console.WriteLine(i);
					break;
				}
			}
		}
		else
		{
			for ( int i = segundoNumero ; i > 0 ; i-- )
			{
				if ( primerNumero % i == 0 && segundoNumero % i == 0)
				{
					Console.WriteLine(i);
					break;
				}
			}
		}
	 }
 }



