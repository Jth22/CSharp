/* Ejercicios 4_1_1 Definición de un array y aceeso a los datos
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios4_1_1
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_1_1 Array y acceso a datos.");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_1_1_1");
			 Console.WriteLine("2. Ejercicio 4_1_1_2");
			 opcion = Console.ReadLine();
			 
			 switch( opcion )
			 {
				case "0": break; 
				case "1": Ejercicio4_1_1_1(); break; 
				case "2": Ejercicio4_1_1_2(); break;
				default: Console.WriteLine("Opción incorrecta"); break; 		
			 }
			 Console.WriteLine("Pulsa \"intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio4_1_1_1()
	 {
		 /*(4.1.1.1) Un programa que pida al usuario 4 números, los memorice
		  * (utilizando un array), calcule su media aritmética y después
		  * muestre en pantalla la media y los datos tecleados.*/
		 const int CAPACIDAD = 4;
		 int[] numUsuarios = new int[CAPACIDAD];
		 int suma = 0;
		 float media;
		 
		 try
		 {
			Console.WriteLine("Introduce 4 números..");
			for ( int i = 0 ; i < numUsuarios.Length ; i++ )
			{
				Console.Write("Número "+ (i+1) + ": ");
				numUsuarios[i] = Convert.ToInt32(Console.ReadLine());
				suma += numUsuarios[i];
			}
			media = (float)suma / numUsuarios.Length;
			
			Console.WriteLine("Los datos tecleados son: ");
			for ( int i = 0 ; i < numUsuarios.Length ; i++ )
			{
				Console.Write(numUsuarios[i]+ " ");
			}
			Console.WriteLine();
			Console.WriteLine("Y su media es: {0}", media);
		 }
		 catch( FormatException e )
		 {
			 Console.WriteLine( "Dato erróneo." + e.Message );
		 }
	 }
	 public static void Ejercicio4_1_1_2()
	 {
		 /*(4.1.1.2) Un programa que pida al usuario 5 números
		  * reales (pista: necesitarás un array de "float") y luego los
		  * muestre en el orden contrario al que se introdujeron.*/
		  
		  const int CAPACIDAD = 5;
		  float[] numUsuarios = new float[CAPACIDAD];
		  
		  try
		  {
			  Console.WriteLine("Dime {0} número.", CAPACIDAD);
			  for ( int i = 0; i < CAPACIDAD ; i++ )
			  {
				 Console.Write("Número " +(i+1)+ ": ");
				 numUsuarios[i] = Convert.ToSingle(Console.ReadLine());
			  }
		  }
		  catch ( FormatException e	)
		  {
			  Console.WriteLine("Dato erróneo" + e.Message);
		  }
		  Console.WriteLine("El orden inverso de los datos son:");
		  for ( int i = CAPACIDAD-1 ; i >= 0 ; i-- )
		  {
			  Console.Write(numUsuarios[i] + " ");
		  }
		  Console.WriteLine();
	 }
 }
