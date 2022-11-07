/* (2.2.1.2.1) Crea un programa que escriba en pantalla los números 
 * del 1 al 10, usando "while".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_1_2_1
 {
	 static void Main()
	 {
		 int i = 1;
		 
		 Console.WriteLine("Escriba en pantalla los números del 1 al 10");
		 while ( i <= 10)
		 {
			 Console.Write(i + " ");
			 i++;
		 }
	 }
 }



