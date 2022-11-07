/* (2.2.10.4) Crea una versión alternativa del ejercicio 2.2.10.2 
 * (mínimo común múltiplo) usando "while", en vez de "for" y "break".
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (2.2.10.2) Crea un programa que pida al usuario dos números y escriba su
 * mínimo común múltiplo (pista: una solución lenta pero sencilla es probar
 * con un "for" todos los números a partir del mayor de ambos, de forma
 * creciente; cuando encuentres un número que sea múltiplo de ambos,
 * interrumpes la búsqueda con "break").
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_10_4
 {
	 static void Main()
	 {
		 int primerNumero, segundoNumero;
		 
		 Console.Write("Dime el primer número? ");
		 primerNumero = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Dime el segundo número? ");
		 segundoNumero = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("El MCM de {0} y {1} es: ", primerNumero, segundoNumero);
		 if ( primerNumero > segundoNumero )
		 {
			 int i = primerNumero; 
			 while ( i > segundoNumero )
			 {
				 if ( i % primerNumero == 0 && i % segundoNumero == 0 )
				 {
					 Console.WriteLine(i);
					 i = segundoNumero - 1;
				 }
				 i++;
			 } 
		 }
		 else
		 {
			  int i = segundoNumero; 
			 while ( i > primerNumero )
			 {
				 if ( i % primerNumero == 0 && i % segundoNumero == 0 )
				 {
					 Console.WriteLine(i);
					 i = primerNumero - 1;
				 }
				 i++;
			 } 
		 }
	 }
 }

