/* (2.2.1.2.2) Crea un programa que escriba en pantalla los números pares 
 * del 26 al 10 (descendiendo), usando "while".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_1_2_2
 {
	 static void Main()
	 {
		 int i = 26;
		 
		 Console.Write("Escriba en pantalla los números pares "); 
		 Console.WriteLine("del 26 al 10 (descendiendo):");
		 while ( i >= 10 )
		 {
			 Console.Write( i+ " ");
			 i-=2;
		 }
	 }
 }
