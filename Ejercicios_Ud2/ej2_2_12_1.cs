/* (2.2.12.1) Crea un programa que escriba los números del 100 al 200,
 * separados por un espacio, sin avanzar de línea, usando "for". En la
 * siguiente línea, vuelve a escribirlos usando "while".
 * Por jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_12_1
 {
	 static void Main()
	 {
		 for ( int i = 100 ; i <= 200 ; i++ )
		 {
			 Console.Write(i + " ");
		 }
		 Console.WriteLine();
		 int j = 100;
		 while ( j <= 200 )
		 {
			 Console.Write( j +" ");
			 j++;
		 }
	 }
 }

