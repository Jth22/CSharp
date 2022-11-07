/* Ejercicios 4.4.4. Extraer una subcadena
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejer4_4_4
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_4_4 Extraer una subcadena");
			 Console.WriteLine("Elije una opción...");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_4_4_1");
			 Console.WriteLine("2. Ejercicio 4_4_4_2");
			 Console.WriteLine("3. Ejercicio 4_4_4_3");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*', 15));
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_4_4_1(); break;
				 case "2": Ejercicio4_4_4_2(); break;
				 case "3": Ejercicio4_4_4_3(); break;
				 default: Console.WriteLine("Opción incorrecta!"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir..");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio4_4_4_1()
	 {
		 /*(4.4.4.1) Un programa que te pida tu nombre y lo muestre en
		  * pantalla separando cada letra de la siguiente con un espacio,
		  * similar al 4.4.3.1, pero esta vez usando "Substring". Por ejemplo,
		  * si tu nombre es "Juan", debería aparecer en pantalla "J u a n".*/
		 string nombre;
		 
		 Console.WriteLine("Dime tu nombre: ");
		 nombre = Console.ReadLine();
		 
		 for ( int i = 0; i < nombre.Length ; i++ )
		 {
			 Console.Write(nombre.Substring(i,1)+ " ");
		 }
		 Console.WriteLine();
	 }
	 public static void Ejercicio4_4_4_2()
	 {
		 /*(4.4.4.2) Un programa que te pida tu nombre y lo muestre en 
		  * pantalla como un triángulo creciente. Por ejemplo, si tu nombre
		  * es "Juan", debería aparecer en pantalla:
			J
			Ju
			Jua
			Juan*/
		 string nombre;
		 
		 Console.WriteLine("Dime tu nombre: ");
		 nombre = Console.ReadLine();
		 
		 for ( int i = 0; i < nombre.Length ; i++ )
		 {
			 for ( int j = i ; j <= i ; j++ )
			 {
				 Console.Write(nombre.Substring(0,i+1));
			 }
			 Console.WriteLine();
		 }
		 Console.WriteLine();
	 }
	 public static void Ejercicio4_4_4_3()
	 {
		 /* (4.4.4.3) Un programa que te pida tu nombre y lo muestre en
		  * pantalla como un triángulo creciente desde la derecha.
		  * Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla:
			n
		   an
		  uan
		 Juan*/
		 string nombre;
		 
		 Console.WriteLine("Dime tu nombre: ");
		 nombre = Console.ReadLine();
		 
		 for ( int i = 0 ; i < nombre.Length ; i++ )
		 {
			 for ( int j = 0 ; j < nombre.Length ; j++ )
			 {
				 if ( i+j < nombre.Length-1 )
					Console.Write(" ");
				 else
				 {
					Console.Write(nombre.Substring((nombre.Length-(i+1))));
					j = nombre.Length-1;
				 }
			 }
			 Console.WriteLine();
		 }
		 Console.WriteLine();
	 }
 }
