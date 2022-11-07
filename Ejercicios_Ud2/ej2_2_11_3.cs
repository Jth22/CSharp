/* (2.2.11.3) Crea una versión alternativa del ejercicio 2.2.11.1, que no
 * utilice "continue" sino el "if" contrario.
 * Por Jonathan Sirvent Pedreño
 */
 
/* (2.2.11.1) Crea un programa que escriba los números del 20 al 10,
 * descendiendo, excepto el 13, usando "continue".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_11_3
 {
	 static void Main()
	 {
		 for ( int i = 20 ; i >= 10 ; i-- )
		 {
			 if ( i != 13 )
			 {
				 Console.Write( i +  " ");
			 }
		 }
	 }
 }




