/* Ejercicos 4.4.7. Descomponer una cadena en fragmentos
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios4_4_7
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("4.4.7. Descomponer una cadena en fragmentos");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4.4.7.1");
			 Console.WriteLine("2. Ejercicio 4.4.7.2");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*',20));
			 switch(opcion)
			 {
				 case "0": break;
				 case "1": Ejercicios4_4_7_1(); break;
				 case "2": Ejercicios4_4_7_2(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine();
			 Console.WriteLine("Pulsa \"Intro\" para seguir...");
			 Console.ReadLine();
			 Console.Clear();
		 }while(opcion != "0");
	 }
	 static void Ejercicios4_4_7_1()
	 {
		 /* (4.4.7.1) Un programa que pida al usuario una frase y muestre sus
		  * palabras en orden inverso.*/
		  string cadena;
		  string[] nuevaCadena;
		  
		  Console.Write("Dime una frase: ");
		  cadena = Console.ReadLine();
		  nuevaCadena = cadena.Split();
		  
		  for (int i = nuevaCadena.Length-1 ; i >= 0 ; i-- )
		  {
			  Console.Write(nuevaCadena[i] + " ");
		  }
		  Console.WriteLine();
	 }
	 static void Ejercicios4_4_7_2()
	 {
		 /*(4.4.7.2) Un programa que pida al usuario varios números separados
		  * por espacios y muestre su suma.*/
		  string[] nuevaCadena;
		  char delimitador = ' ';
		  int suma = 0;
		  
		  Console.WriteLine("Escribe números separador por un espacio \" \").");
		  nuevaCadena = Console.ReadLine().Split(delimitador);
		  int[] numeros = new int[nuevaCadena.Length];
		  
		  for (int i = 0 ; i < nuevaCadena.Length ; i++ )
		  {
			  numeros[i] = Convert.ToInt32(nuevaCadena[i]);
			  suma += numeros[i];
		  }
		  Console.WriteLine("Los números son: ");
		  for (int i = 0 ; i < numeros.Length ; i++)
		  {
			  Console.Write(numeros[i]+" ");
		  }
		  Console.WriteLine();
		  Console.WriteLine("La suma de todos ellos es: "+ suma);
	 }
 }
