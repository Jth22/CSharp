/* (2.2.12.2) Crea un programa que escriba los números pares del 20 al 10,
 * descendiendo, excepto el 14, primero con "for" y luego con "while".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_12_2
 {
	 static void Main()
	 {
		 for (int i = 20 ; i >= 10 ; i -=2 ) 
		 {
			 if ( i == 14)
				continue;
				
			Console.Write(i + " ");
		 }
		 
		 Console.WriteLine();
		 
		 int j = 22;
		 while ( j > 10 )
		 {
			 j-=2;
			 if ( j == 14 )
			 {
				continue;
			 }
			 Console.Write(j + " ");
		 }
	 }
 }
