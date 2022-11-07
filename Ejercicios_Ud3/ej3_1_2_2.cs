/* (3.1.2.2) Pide al usuario dos números de dos cifras ("byte"),
 * calcula su multiplicación, que se deberá guardar en un "int", y
 * muestra el resultado en pantalla.
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej3_1_2_2
 {
	 static void Main()
	 {
		 byte primerNumero, segundoNumero;
		 int resultado;
		 
		 Console.Write("Dime un numero? ");
		 primerNumero = Convert.ToByte(Console.ReadLine());
		 Console.Write("Dime otro numero? ");
		 segundoNumero = Convert.ToByte(Console.ReadLine());
		 
		 resultado = primerNumero * segundoNumero;
		 
		 Console.WriteLine("{0} * {1} = {2}", primerNumero, segundoNumero
			,resultado);	 
	 }
 }
