/* (2.5.2) Crea un programa en el que el usuario deba adivinar un número del
 * 1 al 100 (prefijado en el programa). En cada pasada deberá avisar de si se
 * ha pasado o se ha quedado corto.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_5_2
 {
	 static void Main()
	 {
		 int numeroOculto = 56, numeroUsuario;
		 
		 do
		 {
			 Console.Write("Dime un numero: ");
			 numeroUsuario = Convert.ToInt32(Console.ReadLine());
			 
			 if ( numeroUsuario > numeroOculto )
			 {
				 Console.WriteLine("{0} es mayor que el número Oculto"
					, numeroUsuario);
			 }else if ( numeroUsuario < numeroOculto )
			 {
				  Console.WriteLine("{0} es menor que el número Oculto"
					, numeroUsuario);
			 }
			 else
			 {
				 Console.WriteLine("Enhorabuena son iguales");
			 }
		 }
		 while ( numeroUsuario != numeroOculto);	 
	 }
 }
