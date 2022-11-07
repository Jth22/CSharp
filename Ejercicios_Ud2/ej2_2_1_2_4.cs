/* (2.2.1.2.4) Haz un programa que muestre tantos asteriscos
 * (en la misma línea) como indique el usuario.
 * Por jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej2_2_1_2_4
 {
	 static void Main()
	 {
		 int numeroAstericos;
		 
		 Console.Write("Dime el número de asteríscos que quieres: ");
		 numeroAstericos = Convert.ToInt32(Console.ReadLine());
		 
		 while ( numeroAstericos > 0 )
		 {
			 Console.Write("*");
			 numeroAstericos--;
		 }
	 }
 }
