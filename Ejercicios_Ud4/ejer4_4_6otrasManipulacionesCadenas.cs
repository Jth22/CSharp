/* Ejercicios 4.4.6. Otras manipulaciones de cadenas
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios4_4_6
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("4.4.6. Otras manipulaciones de cadenas");
			 Console.WriteLine("Elje una opción...");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_4_6_1");
			 Console.WriteLine("2. Ejercicio 4_4_6_2");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*',15));
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_4_6_1(); break;
				 case "2": Ejercicio4_4_6_2(); break;
				 default: Console.WriteLine("opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 static void Ejercicio4_4_6_1()
	 {
		 /* (4.4.6.1) Una variante del ejercicio 4.4.5.1 (buscar textos en un
		  * array de frases), que no distinga entre mayúsculas y minúsculas a
		  * la hora de buscar.*/
		  
		  const int CAPACIDAD = 5;
		  string[] cadenas = new string[CAPACIDAD];
		  string cadenaUsuario;
		  bool encontrado;
		  
		  Console.WriteLine("Dime {0} frases..", CAPACIDAD);
		  for ( int i = 0 ; i < cadenas.Length ; i++ )
		  {
			  Console.Write("Cadena "+(i+1)+": ");
			  cadenas[i] = Console.ReadLine().ToLower();
		  }
		  Console.WriteLine("Ahora dime otra frase...");
		  Console.WriteLine("Escribe \"fin\" para finalizar.");
		  do
		  {
			  encontrado = false;
			  Console.Write("? ");
			  cadenaUsuario = Console.ReadLine().ToLower();
			  if ( cadenaUsuario != "fin" )
			  {
				  foreach (string dato in cadenas)
				  {
					  
					  if ( dato.Contains(cadenaUsuario))
						encontrado = true;
				  }
				  if ( encontrado )
					  Console.WriteLine("El texto si está");
				  else
					  Console.WriteLine("El texto no está");
			  }
		  }while( cadenaUsuario != "fin" );
	 }
	 static void Ejercicio4_4_6_2()
	 {
		 /* (4.4.6.2) Un programa que pida al usuario una frase y elimine
		  * todos los espacios redundantes que contenga (debe quedar sólo un
		  * espacio entre cada palabra y la siguiente).*/
		  
		  string cadena;
		  Console.Write("Dime una frase: ");
		  cadena = Console.ReadLine().ToLower();
	  
		  Console.WriteLine(cadena.Replace("  ", " "));
	 }
 }
