/* Ejercisio 4.4.3. Longitud de la cadena
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejer4_4_3
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_4_3..");
			 Console.WriteLine("Elije una opción:");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_4_3_1");
			 Console.WriteLine("2. Ejercicio 4_4_3_2");
			 Console.WriteLine("3. Ejercicio 4_4_3_3");
			 Console.WriteLine("4. Ejercicio 4_4_3_4");
			 Console.WriteLine("5. Ejercicio 4_4_3_5");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*',15));
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_4_3_1(); break;
				 case "2": Ejercicio4_4_3_2(); break;
				 case "3": Ejercicio4_4_3_3(); break;
				 case "4": break;
				 case "5": break;
				 default: Console.WriteLine("Opción errónea!"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio4_4_3_1()
	 {
		 /*(4.4.3.1) Un programa que te pida tu nombre y lo muestre en
		  * pantalla separando cada letra de la siguiente con un espacio.
		  * Por ejemplo, si tu nombre es "Juan", debería aparecer
		  * en pantalla "J u a n".*/
		 string nombre;
		 
		 Console.Write("Dime tu nombre: ");
		 nombre = Console.ReadLine();
		 
		 for ( int i = 0 ; i < nombre.Length ; i++ )
		 {
			 Console.Write(nombre[i]+" ");
		 }
		 Console.WriteLine();
	 }
	 public static void Ejercicio4_4_3_2()
	 {
		 /*(4.4.3.2) Un programa que pida una frase al usuario y la muestre
		  * en orden inverso (de la última letra a la primera).*/
		 string frase;
		 
		 Console.WriteLine("Escribe una frase: ");
		 frase = Console.ReadLine();
		 Console.WriteLine();
		 Console.WriteLine("La frase en sentido inverso es:");
		 for ( int i = frase.Length-1 ; i >= 0 ; i-- )
		 {
			 Console.Write(frase[i]);
		 }
	 }
	 public static void Ejercicio4_4_3_3()
	 {
		 /*(4.4.3.3) Un programa que pida al usuario una frase, después una
		  * letra y finalmente diga si aparece esa letra como parte de esa
		  * frase o no.*/
		 string cadena;
		 char letra;
		 bool encontrado = false;
		 
		 Console.WriteLine("Escribe una frase:");
		 cadena = Console.ReadLine();
		 Console.WriteLine("Ahora escribe una letra: ");
		 letra = Convert.ToChar(Console.ReadLine());
		 
		 for ( int i = 0 ; i < cadena.Length ; i++ )
		 {
			 if ( cadena[i] == letra )
				encontrado = true;
		 }
		 if ( encontrado )
			Console.WriteLine("La letra {0} aparece en {1}", letra, cadena);
		else
			Console.WriteLine("la letra {0} no aparece en la cadena {1}"
				, letra, cadena);
		 
	 }
	 public static void Ejercicio4_4_3_4()
	 {
		 /*(4.4.3.4) Un programa capaz de sumar dos números enteros muy
		  * grandes (por ejemplo, de 50 cifras), que se deberán pedir como
		  * cadena de texto y analizar letra a letra (pista: tendrás que
		  * pensar cómo sumas dos números a mano: qué ocurre si al suma cifra
		  * a cifra obtienes un número mayor que 10 y cómo tratar el caso de
		  * que los dos números no tengan la misma longitud).*/
	 }
	 public static void Ejercicio4_4_3_5()
	 {
		 /*(4.4.3.5) Un programa capaz de multiplicar dos números enteros muy
		  * grandes (por ejemplo, de 50 cifras), que se deberán pedir como
		  * cadena de texto y analizar letra a letra (pista: nuevamente,
		  * deberás pensar cómo lo haces en papel:
		  * multiplicar cifra a cifra, desplazar cuando terminas una cifra... te
		 * ayudará también haber hecho el ejercicio anterior para poder sumar
		 * dos números grandes).*/
	 }
 }
