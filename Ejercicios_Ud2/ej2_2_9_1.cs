/* (2.2.9.1) Crea un programa que pida un número al usuario y escriba los 
 * múltiplos de 9 que haya entre 1 y ese número. Debes usar llaves en todas
 * las estructuras de control, aunque sólo incluyan una sentencia.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_9_1
 {
	 static void Main()
	 {
		 int numeroUsuario;
		 
		 Console.Write("Dime un numero: ");
		 numeroUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 Console.WriteLine("Los multiplos de 9 comprendidos entre 1 y {0} son:"
			, numeroUsuario);
		 for ( int i = 1 ; i <= numeroUsuario ; i++ )
		 {
			 if ( i % 9 == 0 )
			 {
				 Console.Write(i + " ");
			 }
		 }
	 }
 }

