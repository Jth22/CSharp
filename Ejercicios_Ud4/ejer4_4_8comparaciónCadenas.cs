/* Ejercicios 4.4.8. Comparación de cadenas
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios4_4_8
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4.4.8. Comparación de cadenas");
			 Console.WriteLine("Elije una opcion..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4.4.8.1");
			 Console.WriteLine("2. Ejercicio 4.4.8.2");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*',20));
			 switch(opcion)
			 {
				 case "0": break;
				 case "1": Ejercicios4_4_8_1(); break;
				 case "2": Ejercicios4_4_8_2(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine();
			 Console.WriteLine("Pulsa \"Intro\" para seguir..");
			 Console.ReadLine();
			 Console.Clear();
		 }while(opcion != "0" ); 
	 }
	 static void Ejercicios4_4_8_1()
	 {
		 /* (4.4.8.1) Un programa que pida al usuario dos frases y diga cuál
		  * sería la "mayor" de ellas (la que aparecería en último lugar en
		  * un diccionario).*/
		 string primeraCadena, segundaCadena;
		 
		 Console.Write("Escribe una cadena: ");
		 primeraCadena = Console.ReadLine();
		 Console.Write("Escribe otra cadena: ");
		 segundaCadena = Console.ReadLine();
		 
		 if (String.Compare(primeraCadena, segundaCadena, true)> 0)
			Console.WriteLine("La cadena {0} es mayor", primeraCadena);
		 else
			Console.WriteLine("La cadena {0} es mayor", segundaCadena);
			
		Console.WriteLine();// buscar el mayor de manera diferente
			
		 if (primeraCadena.ToUpper().CompareTo(segundaCadena.ToUpper()) > 0)
			Console.WriteLine("La cadena {0} es mayor", primeraCadena);
		 else
			Console.WriteLine("La cadena {0} es mayor", segundaCadena);
  	 }
	 static void Ejercicios4_4_8_2()
	 {
		 /* (4.4.8.2) Un programa que pida al usuario cinco frases, las
		  * guarde en un array y muestre la "mayor" de ellas.*/
		 const int CAPACIDAD = 5;
		 string mayor = "";; 
		 string[] cadenas = new string[CAPACIDAD];
		 
		 Console.WriteLine("Escribe {0} frases...", CAPACIDAD);
		 for (int i = 0; i < CAPACIDAD ; i++)
		 {
			 Console.Write("Frase "+(i+1)+": ");
			 cadenas[i] = Console.ReadLine();
		 }
		 for (int i = 0; i < CAPACIDAD-1 ; i++)
		 {
			 if (String.Compare(cadenas[i], cadenas[i+1], true)>0)
			 {
				 mayor = cadenas[i];
			 }
		 }
		 Console.WriteLine("La cadena mayor es : "+ mayor);
	 }
 }
