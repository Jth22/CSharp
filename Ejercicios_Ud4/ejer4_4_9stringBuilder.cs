/* Ejercicos 4.4.9. Una cadena modificable: StringBuilder
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 using System.Text;
 
 class Ejercicios4_4_9
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Elercicos 4.4.9. Una cadena modificable: StringBuilder");
			 Console.WriteLine("Elije una opción...");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4.4.9.1");
			 Console.WriteLine("2. Ejercicio 4.4.9.2");
			 Console.WriteLine("3. Ejercicio 4.4.9.3");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*', 20));
			 switch(opcion)
			 {
				 case "0": break;
				 case "1": Ejercicios4_4_9_1(); break;
				 case "2": Ejercicios4_4_9_2(); break;
				 case "3": Ejercicios4_4_9_3(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine();
			 Console.WriteLine("Pulsa \"Intro\" para seguir..");
			 Console.ReadLine();
			 Console.Clear();
		 }while(opcion != "0");
	 }
	 static void Ejercicios4_4_9_1()
	 {
		 /* (4.4.9.1) Prepara un programa que pida una cadena al usuario y la
		  * modifique, de modo que todas las vocales se conviertan en "o".*/
		  string cadena;
		  
		  Console.Write("Escribe una frase: ");
		  cadena = Console.ReadLine();
		  
		  StringBuilder nuevaCadena = new StringBuilder(cadena);
		  
		  for (int i = 0 ; i < nuevaCadena.Length ; i++)
		  {
			if (nuevaCadena[i] == 'a' || nuevaCadena[i] == 'e' || nuevaCadena[i] == 'i' || nuevaCadena[i] == 'u')
			{
				nuevaCadena[i] = 'o';
			}
		  }
		  cadena = nuevaCadena.ToString();
		  Console.WriteLine(cadena);
	 }
	 static void Ejercicios4_4_9_2()
	 {
		 /* (4.4.9.2) Un programa que pida una cadena al usuario y la
		  * modifique, de modo que las letras de las posiciones impares
		  * (primera, tercera, etc.) estén en minúsculas y las de las
		  * posiciones pares estén en mayúsculas, mostrando el resultado en
		  * pantalla. Por ejemplo, a partir de un nombre como "Nacho", la
		  * cadena resultante sería "nAcHo".*/
		  string cadena;
		  
		  Console.Write("Escribe una frase: ");
		  cadena = Console.ReadLine();
		  
		  StringBuilder nuevaCadena = new StringBuilder(cadena);
		  
		  for (int i = 0; i < nuevaCadena.Length ; i++)
		  {
			  if ( (i+1)%2 != 0 )
			  {
				  Console.Write(nuevaCadena[i].ToString().ToLower());
			  }
			  else
			  {
				 Console.Write(nuevaCadena[i].ToString().ToUpper());
			  }
		  }	
	 }
	 static void Ejercicios4_4_9_3()
	 {
		 /* (4.4.9.3) Crea un juego del ahorcado, en el que un primer usuario
		  * introduzca la palabra a adivinar, se muestre ésta oculta con
		  * guiones (-----) y el programa acepte las letras que introduzca el
		  * segundo usuario, cambiando los guiones por letras correctas cada
		  * vez que acierte (por ejemplo, a---a-t-). La partida terminará
		  * cuando se acierte la palabra por completo o el usuario agote
		  * sus 8 intentos.*/
		string palabraOculta, resultado ="", caracterOculta;
		int intentos, posicion, aciertos = 0;
		char letra =' ';
		bool terminado = false, encontrado;
		  
		Console.Write("Escribe una palabra: ");
		palabraOculta = Console.ReadLine();
		intentos = palabraOculta.Length;
		caracterOculta = new string('-', palabraOculta.Length);
		
		StringBuilder nuevaPalabra = new StringBuilder(palabraOculta);
		StringBuilder nuevoCaracter = new StringBuilder(caracterOculta);
		do
		{
			posicion = 0;
			Console.Clear();
			encontrado = false;
			Console.WriteLine("Palabra a buscar..");
			for (int i = 0 ; i < nuevoCaracter.Length ; i++)
				Console.Write(nuevoCaracter[i]);
				
			Console.WriteLine();
			try
			{
				Console.WriteLine("Dime una letra:");
				letra = Convert.ToChar(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine("Opción Incorrecta"+e.Message);
			}
			
			for (int i = 0; i < nuevoCaracter.Length ; i++)
			{
				if ( letra == nuevaPalabra[i])
				{
					encontrado = true;
					posicion = i;
					aciertos++;
				}
			}
			if (aciertos == palabraOculta.Length && intentos > 0 && resultado == palabraOculta  )
			{
				Console.WriteLine("Ganaste!!");
				terminado = true;
			}
			else
			{
				if (encontrado && intentos > 0)
				{
					nuevoCaracter[posicion] = letra;
					nuevaPalabra[posicion] = letra;
					Console.WriteLine("Bien, te quedan {0} intentos", intentos);
				}
				else
				{
					Console.WriteLine("Fallaste, te quedan {0} intentos", intentos);
				}
			}
			
			resultado = String.Join(" ",nuevaPalabra);
			intentos--;
			Console.WriteLine("Pulsa \"Intro\" prar seguir");
			Console.ReadLine();
		}while(intentos != 0 && !terminado );	  
	 }
 }
