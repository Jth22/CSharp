/* (2.2.1.2.3) Crea un programa calcule cuantas cifras tiene un número
 * entero positivo (pista: se puede hacer dividiendo varias veces entre 10).
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_1_2_3
 {
	 static void Main()
	 {
		 int numeroUsuario, cifra, contador = 0;
		 
		 Console.Write("Escribe un numero: ");
		 numeroUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 cifra = numeroUsuario;
		 while( cifra != 0 )
		 {
			 cifra /= 10;
			 contador++;
		 }
		 Console.WriteLine("El número {0} tiene {1} cifras"
			, numeroUsuario, contador);
	 }
 }
