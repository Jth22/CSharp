/* Ejercicios 4.4.10. Cadenas repetitivas
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (4.4.10.1) Crea un programa que pida al usuario una frase y la muestre subrayada, usando para ello una cadena formada por tantos guiones como letras tuviera la frase inicial.
 using System;*/
 using System;
 
 class Ejercicios4_4_10_1
 {
	 static void Main()
	 {
		 string cadena;
		 
		 Console.WriteLine("Dime una frase: ");
		 cadena = Console.ReadLine();
		 
		 Console.WriteLine(new string('-', cadena.Length));
	 }
 }
