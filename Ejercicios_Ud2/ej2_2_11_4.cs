/* (2.2.11.4) Crea una versión alternativa del ejercicio 2.2.11.2, que no
 * emplee "continue" sino el "if" contrario.
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (2.2.11.2) Crea un programa que escriba los números pares del 2 al 106,
 * excepto los que sean múltiplos de 10, usando "continue".
 * POr Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_11_
 {
	 static void Main()
	 {
		 for ( int i = 2 ; i <= 106 ; i+=2 )
		 {
			 if ( i % 10 != 0 )
			 {
				 Console.Write(i + " ");
			 }
		 }
	 }
 }

