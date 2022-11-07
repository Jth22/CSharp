/* Ejercicios 4.4.2. Cómo acceder a las letras que forman una cadena
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (4.4.2.1) Crea un programa que pregunte al usuario su nombre y le responda cuál es su inicial.*/
 
 using System;
 
 class Ejer4_4_2
 {
	 static void Main()
	 {
		 string nombre;
		 
		 do
		 {
			 Console.WriteLine("Dime tu nombre: (Escribe \"fin\" para terminar) ");
			 nombre = Console.ReadLine();
			 
			 if ( nombre != "fin" )
			 {
				Console.WriteLine(new string('*',10));
				Console.WriteLine("Tu inicial es : \""+ nombre[0]+"\"");
			 }
			 Console.WriteLine();
		 }while( nombre != "fin" );
	 }
 }
