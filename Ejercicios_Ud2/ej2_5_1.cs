/* (2.5.1) Crea un programa que muestre una cuenta atrás (3 2 1 0) desde el
 * número que introduzca el usuario hasta cero. Ese número debe estar entre 1
 * y 10 (y el programa debe comprobar que realmente lo está, y volverlo a pedir
 * tantas veces como sea necesario, en caso de que no sea así).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_5_1
 {
	 static void Main()
	 {
		 int numeroUsuario;
		 
		 do
		 {
			 Console.Write("Dime un numero: ");
			 numeroUsuario = Convert.ToInt32(Console.ReadLine());
			 
			if ( numeroUsuario >= 0 && numeroUsuario <= 10 )
			{
				for ( int i = numeroUsuario ; i >= 0 ; i-- )
				{
					Console.Write(i+ " ");
				}
			}
		 }
		 while ( numeroUsuario < 0 || numeroUsuario > 10 );
	 }
 }

