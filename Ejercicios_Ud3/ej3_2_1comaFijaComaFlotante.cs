/* Ejercicios 3_2_1 coma fija y coma flotante
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios3_2_1
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine();
			 Console.WriteLine("Ejercicios 3_2_1 coma fija y coma flotante.");
			 Console.WriteLine("Elije una opción...");
			 Console.WriteLine("1. Ejercicio 3_2_1_1.");
			 Console.WriteLine("2. Ejercicio 3_2_1_2.");
			 Console.WriteLine("0. Salir");
			 opcion = Console.ReadLine();
			 
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_2_1_1(); break;
				 case "2": Ejercicio3_2_1_2(); break;
				 case "0": break;
				 default: Console.WriteLine("Opcion Incorrecta.");
					break;
			 }
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio3_2_1_1()
	 {
		 /* (3.2.1.1) Crea un programa que muestre el resultado de
		  * dividir 3 entre 4,primero usando números enteros y luego
		  * usando números de coma flotante.*/
		 
		  int resultadoEntero;
		  float resultadoFlotante;
		 
		  resultadoEntero = 3 / 4;
		  resultadoFlotante = ( float )3 / 4;
		 
		  Console.WriteLine("El resultado de dividir 3 entre 4(con enteros) es:"
			 + resultadoEntero );
		  Console.WriteLine("El resultado de dividir 3 entre 4(con coma) es: "
			 + resultadoFlotante );
	 }
	 public static void Ejercicio3_2_1_2()
	 {
		 /* (3.2.1.2) ¿Cuál sería el resultado de las siguientes 
		  * operaciones, usando números reales? a=5; a/=2; a+=1; 
		  * a*=3; --a;*/
		  float a = 5;
		  Console.WriteLine("Resultados de las siguientes operaciones reales:");
		  Console.WriteLine(a+" /= 2 : {0}", a/=2);
		  Console.WriteLine(a+" += 1 : {0}", a+=1);
		  Console.WriteLine(a+" *= 3 : {0}", a*=3);
		  Console.WriteLine(a+" --a : {0}", --a);
	 }
 }
