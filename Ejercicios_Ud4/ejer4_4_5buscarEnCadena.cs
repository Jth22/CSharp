/* Ejercicios 4.4.5. Buscar en una cadena
 * Por Jonathan Sirvent Pedreño
 */
 
 using System; 
 
 class Ejer4_4_5
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4.4.5. Buscar en una cadena");
			 Console.WriteLine("Elije una opción...");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_4_5_1");
			 Console.WriteLine("2. Ejercicio 4_4_5_2");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 switch ( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_4_5_1(); break;
				 case "2": Ejercicio4_4_5_2(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 static void Ejercicio4_4_5_1()
	 {
		 /*(4.4.5.1) Un programa que pida al usuario 10 frases, las guarde en 
		  * un array, y luego le pregunte textos de forma repetitiva, e 
		  * indique si cada uno de esos textos aparece como parte de alguno de
		  * los elementos del array. Terminará cuando el texto introducido
		  * sea "fin".*/
		  const int CAPACIDAD = 10;
		  string[] cadenas = new string[CAPACIDAD];
		  string cadenaUsuario;
		  bool encontrado; 
		  
		  Console.WriteLine("Dime frases...");
		  for ( int i = 0; i < cadenas.Length ; i++ )
		  {
			  Console.Write("Frase "+ (i+1) + ": " );
			  cadenas[i] = Console.ReadLine();
		  }
		  Console.WriteLine("Ahora dime otra cadena:");
		  Console.WriteLine("(Escribe \"fin\" para finalizar)");
		  do
		  {
			  encontrado = false;
			  Console.Write("? ");
			  cadenaUsuario = Console.ReadLine();
			  if ( cadenaUsuario != "fin" )
			  {
				  foreach (string dato in cadenas)
				  {
					if ( dato.Contains(cadenaUsuario) )
						encontrado = true;
				  }
				  if (encontrado)
					Console.WriteLine("El texto si está");
				  else
					Console.WriteLine("El texto no está");
			  }
		  }while( cadenaUsuario != "fin" );
	 }
	 static void Ejercicio4_4_5_2()
	 {
		 /*(4.4.5.2) Crea una versión del ejercicio 4.4.5.1 en la que, en caso
		  * de que alguno de los textos aparezca como subcadena, se informe
		  * además de si se encuentra exactamente al principio.*/
		  const int CAPACIDAD = 10;
		  string[] cadenas = new string[CAPACIDAD];
		  string cadenaUsuario;
		  bool encontrado, estaAlPrincipio; 
		  
		  Console.WriteLine("Dime frases...");
		  for ( int i = 0; i < cadenas.Length ; i++ )
		  {
			  Console.Write("Frase "+ (i+1) + ": " );
			  cadenas[i] = Console.ReadLine();
		  }
		  Console.WriteLine("Ahora dime otra cadena:");
		  Console.WriteLine("(Escribe \"fin\" para finalizar)");
		  do
		  {
			  encontrado = false;
			  estaAlPrincipio = false;
			  Console.Write("? ");
			  cadenaUsuario = Console.ReadLine();
			  if ( cadenaUsuario != "fin" )
			  {
				  foreach (string dato in cadenas)
				  {
					if ( dato.Contains(cadenaUsuario) && (dato.IndexOf(cadenaUsuario) == 0) )
						estaAlPrincipio = true;
					else if ( dato.Contains(cadenaUsuario))
						 encontrado = true;
				  }
				  if (estaAlPrincipio)
					Console.WriteLine("Está al principio");
				  else if (encontrado)
					Console.WriteLine("El texto está pero no al principio");
				  else
					Console.WriteLine("El texto no está");
			  }
		  }while( cadenaUsuario != "fin" );
	 }
 }
	  
