/* Ejercicios 4.5. Recorriendo arrays y cadenas con "foreach"
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios4_5
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4.5. Recorriendo arrays y cadenas con \"foreach\"");
			 Console.WriteLine("Elije una opción...");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4.5.1");
			 Console.WriteLine("2. Ejercicio 4.5.2");
			 Console.WriteLine("3. Ejercicio 4.5.3");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*',20));
			 switch(opcion)
			 {
				 case "0": break;
				 case "1": Ejercicio4_5_1(); break;
				 case "2": Ejercicio4_5_2(); break;
				 case "3": Ejercicio4_5_3(); break;
				 default: Console.WriteLine(); break;
			 }
			 Console.WriteLine();
			 Console.WriteLine("Pulsa \"Intro\" para seguir..");
			 Console.ReadLine();
			 Console.Clear();
		 }while(opcion != "0");
	 }
	 static void Ejercicio4_5_1()
	 {
		 /*(4.5.1) Un programa que pida tu nombre y lo muestre con un espacio
		  * entre cada par de letras, usando "foreach".*/
		string nombreUsuario;
		
		Console.Write("Dime tu nombre: ");
		nombreUsuario = Console.ReadLine();
		
		foreach (char letra in nombreUsuario)
			Console.Write(letra+ " ");
	 } 
	 static void Ejercicio4_5_2()
	 {
		 /*(4.5.2) Un programa que pida al usuario una frase y la descomponga
		  * en subcadenas separadas por espacios, usando "Split". Luego debe
		  * mostrar cada subcadena en una línea nueva, usando "foreach".*/
		  string[] nuevaCadena;
		  
		  Console.WriteLine("Escribe una frase: ");
		  nuevaCadena = Console.ReadLine().Split();
		  
		  foreach (string palabra in nuevaCadena)
			Console.WriteLine(palabra);
	 } 
	 static void Ejercicio4_5_3()
	 {
		 /*4.5.3) Un programa que pida al usuario varios números separados por
		  * espacios y muestre su suma (como el del
		  * ejercicio 4.4.7.2), empleando "foreach".*/
		 string[] dato;
		 int[] numeros;
		 int suma = 0;
		 Console.WriteLine("Escribe varios números separados por espacios:");
		 dato = Console.ReadLine().Split();
		 numeros = new int[dato.Length];
		 for (int i = 0 ; i < numeros.Length ; i++)
		 {
			 numeros[i] = Convert.ToInt32(dato[i]);
		 }
		 
		 foreach (int num in numeros)
		 {
			suma += num;
		 }
		 Console.WriteLine("La suma de los numeros introducidos es "+ suma);
	 } 
 }
