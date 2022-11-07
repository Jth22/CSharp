/* (2.2.9.2) Crea un programa que pida al usuario dos números y escriba sus
 * divisores comunes. Debes usar llaves en todas las estructuras de control,
 * aunque sólo incluyan una sentencia.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_9_2
 {
	 static void Main()
	 {
		 int primerNumero, segundoNumero;
		 
		 Console.Write("Primer numero? ");
		 primerNumero = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Segundo numero? ");
		 segundoNumero = Convert.ToInt32(Console.ReadLine());
		 
		 if ( primerNumero < segundoNumero )
		 {
			 Console.WriteLine("Los divisores comunes de {0} y {1} son:"
				, primerNumero,segundoNumero);
			 for ( int i = 1 ; i <= primerNumero ; i++ )
			 {
				 if ( primerNumero % i == 0 && segundoNumero % i == 0 )
				 {
					 Console.WriteLine(i + " ");
				 }
			 }
		 }
	     else
		 {
			 Console.WriteLine("Los divisores comunes de {0} y {1} son:"
				, primerNumero,segundoNumero);
			 for ( int i = 1 ; i <= segundoNumero ; i++ )
			 {
				 if ( primerNumero % i == 0 && segundoNumero % i == 0 )
				 {
					 Console.WriteLine(i + " ");
				 }
			 }
		 }
	 }
 }
