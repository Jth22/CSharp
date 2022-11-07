/* Ejercicios 4_2 Arrays bidimensionales
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios4_2
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_2.");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio4_2_1");
			 Console.WriteLine("2. Ejercicio4_2_2");
			 Console.WriteLine("3. Ejercicio4_2_3");
			 Console.WriteLine("4. Ejercicio4_2_4");
			 Console.WriteLine("5. Ejercicio4_2_5");
			 Console.WriteLine("6. Ejercicio4_2_6");
			 Console.WriteLine("7. Ejercicio4_2_7");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_2_1(); break;
				 case "2": Ejercicio4_2_2(); break;
				 case "3": Ejercicio4_2_3(); break;
				 case "4": Ejercicio4_2_4(); break;
				 case "5": Ejercicio4_2_5(); break;
				 case "6": break;
				 case "7": break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio4_2_1()
	 {
		 /*(4.2.1) Un programa que pida al usuario dos bloques de 10 números
		  * enteros (usando un array de dos dimensiones). Después deberá
		  * mostrar el mayor dato que se ha introducido en cada uno de ellos.*/
		 const int CAPACIDAD = 10;
		 int[,] numeros = new int[ 2, CAPACIDAD ];
		 int mayor;
		 
		 try
		 {
			 Console.WriteLine("Rellena los arrays..");
			 for ( int i = 0 ; i < numeros.GetLength(0) ; i++ )
			 {
				 for ( int j = 0 ; j < numeros.GetLength(1); j++ )
				 {
					 Console.Write("Array "+ (i+1)+ " dato"+ (j+1)+ ": ");
					 numeros[i,j] = Convert.ToInt32(Console.ReadLine());
				 }
			 }
		 }
		 catch( FormatException e )
		 {
			 Console.WriteLine("Dato erróneo"+ e.Message);
		 }
		 mayor = numeros[0,0];
		 for ( int i = 0 ; i < numeros.GetLength(0) ; i++)
		 {
			 for (int j = 0 ; j < numeros.GetLength(1) ; j++ )
			 {
				 if ( numeros[i,j] > mayor )
					mayor = numeros[i,j];
			 }
		 }
		 Console.WriteLine("El número mayor es "+ mayor);
	 }
	 public static void Ejercicio4_2_2()
	 {
		 /*(4.2.2) Un programa que pida al usuario dos bloques de 6 cadenas de
		  * texto. Después pedirá al usuario una nueva cadena y comprobará si
		  * aparece en alguno de los dos bloques de información anteriores.*/
		  string[,] textos = new string[2, 6];
		  string nuevaCadena;
		  bool encontrado = false;
		  try
		  {
			  Console.WriteLine("Rellena los arrays..");
			  for ( int i = 0 ; i < textos.GetLength(0) ; i++ )
			  {
				  for ( int j = 0 ; j < textos.GetLength(1); j++ )
				  {
					  Console.Write("Array "+ (i+1)+ " dato"+ (j+1)+ ": ");
					  textos[i,j] = Console.ReadLine();
				  }
			  }
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo"+ e.Message);
		  }
		  Console.Write("Escribe una nueva cadena: ");
		  nuevaCadena = Console.ReadLine();
		  for( int i = 0 ; i < textos.GetLength(0) ; i++ )
		  {
			  for ( int j = 0 ; j < textos.GetLength(1) ; j++ )
			  {
				  if (textos[i, j] == nuevaCadena )
					encontrado = true;
			  }
		  }
		  if ( encontrado )
			Console.WriteLine("El texto {0} se ha encontrado", nuevaCadena);
		  else
			Console.WriteLine("El texto {0} no se ha encontrado", nuevaCadena);
	 }
	 public static void Ejercicio4_2_3()
	 {
		 /*(4.2.3) Un programa que pregunte al usuario el tamaño que tendrán
		  * dos bloques de números enteros (por ejemplo, uno de 10 elementos y
		  * otro de 12). Luego pedirá los datos para ambos bloques de datos.
		  * Finalmente deberá mostrar el mayor dato que se ha introducido en
		  * cada uno de ellos.*/
		  int[][] datos = new int[2][];
		  int mayor = 0, tamanyo1, tamanyo2;
		  
		  try
		  {
			  Console.Write("Escribe el tamaño del 1 array: ");
			  tamanyo1 = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Escribe el tamaño del 2 array: ");
			  tamanyo2 = Convert.ToInt32(Console.ReadLine());
			  datos[0] = new int[tamanyo1];
			  datos[1] = new int[tamanyo2];
			  for (int i = 0 ; i < datos.Length ; i++ )
			  {
				  for (int j = 0 ; j < datos[i].Length ; j++ )
				  {
					  Console.Write("Array "+ (i+1)+ " dato"+ (j+1)+ ": ");
					  datos[i][j] = Convert.ToInt32(Console.ReadLine());
				  }
			  }
			  for ( int i = 0 ; i < datos.Length ; i++ )
			  {
				  mayor = datos[i][0];
				  for ( int j = 0 ; j < datos[i].Length; j++ )
				  {
					  if ( datos[i][j] > mayor )
						 mayor = datos[i][j];
				  }
				  Console.WriteLine("El número mayor del bloque "
					+(i+1)+" es {0}", mayor);
			  }
		  }
		  catch( FormatException e)
		  {
			  Console.WriteLine("Formato erróneo" + e.Message);
		  }
	 }
	 public static void Ejercicio4_2_4()
	 {
		 /*(4.2.4) Un programa que calcule el determinante de una
		  * matriz de 2x2.*/
		  int[,] nums = new int [2,2];
		  Random rm = new Random();
		  int determinante;
		  for ( int i = 0 ; i < nums.GetLength(0) ; i++ )
		  {
			  for ( int j = 0 ; j < nums.GetLength(1) ; j++ )
			  {
				  nums[i,j] = (int)rm.Next(1,6);
			  }
		  }
		  Console.WriteLine("Matriz \"2*2\"");
		 for ( int i = 0 ; i < nums.GetLength(0) ; i++ )
		 {
			 for ( int j = 0 ; j < nums.GetLength(1) ; j++ )
			 {
				 Console.Write(nums[i,j]+ " ");
			 }
			 Console.WriteLine();
		 }
		 
		 determinante = ((nums[0,0]*nums[1,1]) - (nums[0,1]*nums[1,0]));
		 Console.WriteLine("El determinate de esta matriz es: "+ determinante);
		 
		
		 
	 }
	 public static void Ejercicio4_2_5()
	 {
		 /*(4.2.5) Un programa que calcule el determinante de una
		  * matriz de 3x3.*/
		   int[,] nums = new int [3,3];
		  Random rm = new Random();
		  int determinante;
		  for ( int i = 0 ; i < nums.GetLength(0) ; i++ )
		  {
			  for ( int j = 0 ; j < nums.GetLength(1) ; j++ )
			  {
				  nums[i,j] = (int)rm.Next(-100,100);
			  }
		  }
		  Console.WriteLine("Matriz \"3*3\"");
		 for ( int i = 0 ; i < nums.GetLength(0) ; i++ )
		 {
			 for ( int j = 0 ; j < nums.GetLength(1) ; j++ )
			 {
				 Console.Write(nums[i,j]+ " ");
			 }
			 Console.WriteLine();
		 }
		 int deter1 = (nums[0,0]*nums[1,1]*nums[2,2]);
		 int deter2 = (nums[0,1]*nums[1,2]*nums[2,0]);
		 int deter3 = (nums[0,2]*nums[1,0]*nums[2,1]);
		 int deter4 = (nums[0,1]*nums[1,0]*nums[2,2]);
		 int deter5 = (nums[0,0]*nums[2,1]*nums[1,2]);
		 int deter6 = (nums[2,0]*nums[1,1]*nums[0,2]);
		 determinante = deter1+deter2+deter3-(deter4-deter5-deter6);
		 Console.WriteLine("El determinate de esta matriz es: "+ determinante);
	 }
	 public static void Ejercicio4_2_6()
	 {
		 /*(4.2.6) Un programa que calcule si las filas de una matriz de 4x4
		  * son linealmente dependientes.*/
	 }
	 public static void Ejercicio4_2_7()
	 {
		 /*(4.2.7) Un programa que use matrices para resolver un sistema de
		  * ecuaciones lineales (por ejemplo, de 3 ecuaciones con 3 incógnitas)
		  * mediante el método de Gauss.*/
	 }
 }
