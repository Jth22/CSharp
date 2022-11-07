/* Ejercicios 4_1_3 Recorriendo elementos tablas
 * Por Jonathan Sirvent Pedreño */
 
 using System;
 
 class Ejer4_1_3recorriendoTabla
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_1_3 Recorriendo tablas..");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_1_3_1");
			 Console.WriteLine("2. Ejercicio 4_1_3_2");
			 Console.WriteLine("3. Ejercicio 4_1_3_3");
			 Console.WriteLine("4. Ejercicio 4_1_3_4");
			 Console.WriteLine("5. Ejercicio 4_1_3_5");
			 Console.WriteLine("6. Ejercicio 4_1_3_6");
			 Console.WriteLine("7. Ejercicio 4_1_3_7");
			 Console.WriteLine("8. Ejercicio 4_1_3_8");
			 Console.WriteLine("9. Ejercicio 4_1_3_9");
			 Console.WriteLine("10. Ejercicio 4_1_3_10");
			 Console.WriteLine("11. Ejercicio 4_1_3_11");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_1_3_1(); break;
				 case "2": Ejercicio4_1_3_2(); break;
				 case "3": Ejercicio4_1_3_3(); break;
				 case "4": Ejercicio4_1_3_4(); break;
				 case "5": Ejercicio4_1_3_5(); break;
				 case "6": Ejercicio4_1_3_6(); break;
				 case "7": Ejercicio4_1_3_7(); break;
				 case "8": Ejercicio4_1_3_8(); break;
				 case "9": Ejercicio4_1_3_9(); break;
				 case "10": Ejercicio4_1_3_10(); break;
				 case "11": Ejercicio4_1_3_11(); break;
				 default: Console.WriteLine("Opción errónea"); break;
			 }
			 Console.WriteLine("Pulsa \"intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0");
	 }
	 public static void Ejercicio4_1_3_1()
	 {
		 /* (4.1.3.1) Crea un programa que pida al usuario 6 números enteros
		  * cortos y luego los muestre en orden inverso (pista: usa un array
		  * para almacenarlos y "for" para mostrarlos).*/
		  const int CAPACIDAD = 6;
		  short[] numeros = new short[CAPACIDAD];
		  
		  try
		  {
			  Console.WriteLine("Escribe {0} numeros:", CAPACIDAD);
			  for ( int i = 0 ; i < CAPACIDAD ; i++ )
			  {
				 Console.Write("Número " +(i+1)+": ");
				 numeros[i] = Convert.ToInt16(Console.ReadLine()); 
			  }
			  for ( int i = CAPACIDAD-1 ; i >= 0 ; i-- )
			  {
				  Console.Write(numeros[i]+ " ");
			  }
			  Console.WriteLine();
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo" + e.Message);  
		  }
	 }
	 public static void Ejercicio4_1_3_2()
	 {
		 /* (4.1.3.2) Crea un programa que pregunte al usuario cuántos números
		  * enteros va a introducir (por ejemplo, 10), le pida todos esos
		  * números, los guarde en un array y finalmente calcule y muestre la
		  * media de esos números.*/
		  
		  int capacidad, suma = 0;
		  float media;
		  int[] numeros;
		  try
		  {
			  Console.Write("Dime la capacidad del array: ");
			  capacidad = Convert.ToInt32(Console.ReadLine());
			  numeros = new int[capacidad];
			  
			  Console.WriteLine("Escribe {0} números:", capacidad);
			  for ( int i = 0 ; i < capacidad ; i++ )
			  {
				  Console.Write("Número "+ (i+1) +": ");
				  numeros[i] = Convert.ToInt32(Console.ReadLine());
				  suma += numeros[i];
			  }
			  
			  media = (float)suma / capacidad;
			  
			  Console.WriteLine("La media de todos los números es {0}"
				, media.ToString("N3"));
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo" + e.Message);
		  }
	 }
	 public static void Ejercicio4_1_3_3()
	 {
		 /* (4.1.3.3) Un programa que pida al usuario 10 reales de doble
		  * precisión, calcule su media y luego muestre los que están por
		  * encima de la media.*/
		  const int CAPACIDAD = 10;
		  double[] datos = new double[CAPACIDAD];
		  double suma = 0, media;
		  try
		  {
			  Console.WriteLine("Escribe {0} números de doble presición."
				, CAPACIDAD);
			  for ( int i = 0; i < CAPACIDAD ; i++ )
			  {
				  Console.Write("Número "+ (i+1) +": ");
				  datos[i] = Convert.ToDouble(Console.ReadLine());
				  suma += datos[i];
			  }
			  
			  media = suma / datos.Length;
			  Console.WriteLine("La media es "+ media.ToString("N4"));
			  Console.WriteLine("Los datos que son mayor que la media son: ");
			  for ( int i = 0 ; i < CAPACIDAD ; i++ )
			  {
				  if ( datos[i] > media)
				  {
					  Console.Write(datos[i]+ " ");
				  }
			  }
			  Console.WriteLine();
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo"+ e.Message);
		  }
	 }
	 public static void Ejercicio4_1_3_4()
	 {
		 /* (4.1.3.4) Un programa que almacene en una tabla el número de
		  * días que tiene cada mes (de un año no bisiesto), pida al usuario
		  * que le indique un mes (ej. 2 para febrero) y un día (ej. el día 15)
		  * y diga qué número de día es dentro del año (por ejemplo, 
		  * el 15 de febrero sería el día número 46, el 31 de diciembre sería
		  * el día 365).*/
		  int[] diasMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		  int dia, mes = 0, numeroDiaAnyo;
		  do
		  {  
			  try
			  {
				  numeroDiaAnyo = 0;
				  Console.Write("Dime un mes (Pulsa \"0\" para salir): ");
				  mes = Convert.ToInt32(Console.ReadLine());
				  if ( mes >=1 && mes <= 12 )
				  {
					  Console.Write("Dime un día: ");
					  dia = Convert.ToInt32(Console.ReadLine());
					  for ( int i = 1 ; i < mes ; i++ )
					  {
						  numeroDiaAnyo += diasMeses[i-1];
					  }
					  Console.WriteLine(numeroDiaAnyo);
					  Console.WriteLine("El {0}/{1} sería el día número {2}"
						, dia, mes, (numeroDiaAnyo+dia));
				  }
			  }
			  catch( FormatException e )
			  {
				  Console.WriteLine("Dato erróeno"+ e.Message);
			  }
		  }while( mes >= 1 && mes <= 12);
	 }
	 public static void Ejercicio4_1_3_5()
	 {
		 /*(4.1.3.5) A partir del ejercicio anterior, crea otro que pida al
		  * usuario que le indique la fecha, formada por día (1 al 31) y el
		  * mes (1=enero, 12=diciembre), y como respuesta muestre en pantalla
		  * el número de días que quedan hasta final de año.*/
		  int dia, mes, cuentaDias = 0, diasRestantes;
		  string[] letrameses = {"Enero", "febrero", "Marzo", "Abril", "Mayo"
			  , "Junio", "Julio", "Agosto", "Septimebre", "Octubre"
			  , "Noviembre", "Diciembre"};
		  int[] meses = {31,28,31,30,31,30,31,31,30,31,30,31};
		  
		  try
		  {
			  Console.Write("Escribe un mes (1 al 12): ");
			  mes = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Escribe del 1 al 31 para el dia: ");
			  dia = Convert.ToInt32(Console.ReadLine());
			  			  
			  for ( int i = mes-2 ; i >= 0 ; i-- )
			  {
				  cuentaDias += meses[i];
			  }
			  diasRestantes = 365 - (cuentaDias+dia);
			  Console.WriteLine("La fecha del metida por usuario es : " 
				+ "{0} de {1} y para final de año queda : {2} días."
				, dia, letrameses[(mes-1)], diasRestantes);
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo" + e.Message);
		  }
	 }
	 public static void Ejercicio4_1_3_6()
	 {
		 /*(4.1.3.6) Un programa que pida 10 nombres y los memorice
		  * (pista: esta vez se trata de un array de "string"). Después deberá
		  * pedir que se teclee un nombre y dirá si se encuentra o no entre
		  * los 10 que se han tecleado antes. Volverá a pedir otro nombre y a
		  * decir si se encuentra entre ellos, y así sucesivamente hasta que
		  * se teclee "fin". En el siguiente apartado verás detalles de cómo
		  * hacer ese tipo de búsquedas.*/
		  const int CAPACIDAD = 10;
		  string[] nombres = new string[CAPACIDAD];
		  string nombreUsuario;
		  bool encontrado;
		  
		  Console.WriteLine("Vamos a escribir {0} nombres.");
		  for ( int i = 0 ; i < CAPACIDAD ; i++ )
		  {
			  Console.Write("Nombre "+(i+1)+": ");
			  nombres[i] = Console.ReadLine();
		  }
		  do
		  {
			  encontrado = false;
			  Console.Write("Escribe otro nombre: ");
			  nombreUsuario = Console.ReadLine();
			  for ( int i = 0 ; i < CAPACIDAD ; i++ )
			  {
				  if ( nombreUsuario == nombres[i])
				  {
					  encontrado = true;
				  }
			  }
			  if ( encontrado )
				Console.WriteLine("El nombre se encuentra en la lista.");
			  else
				Console.WriteLine("EL nombre no se encuentra en la lista");
				
		 }while( nombreUsuario != "fin");
	 }
	 public static void Ejercicio4_1_3_7()
	 {
		 /*(4.1.3.7) Un programa que prepare espacio para guardar un máximo
		  * de 100 nombres. El usuario deberá ir introduciendo un nombre
		  * cada vez, hasta que se pulse Intro sin teclear nada, momento en
		  * el que dejarán de pedirse más nombres y se mostrará en pantalla la
		  * lista de los nombres que se han introducido.*/
		  const int CAPACIDAD = 100;
		  string[] nombres = new string[CAPACIDAD];
		  string nombreUsuario = " ";
		  int cantidad = 0;
		  
		  do
		  {
			  if ( cantidad < CAPACIDAD )
			  {
				  Console.Write("Escribe un nombre: ");
				  nombreUsuario = Console.ReadLine();
				  nombres[cantidad] = nombreUsuario;
				  cantidad++;
			  }	  
		  }while ( nombreUsuario != "" );
		  Console.WriteLine("La lista de nombres introducida es:");
		  for ( int i = 0 ; i < cantidad ; i++ )
		  {
			  Console.WriteLine(nombres[i]);
		  }
	 }
	 public static void Ejercicio4_1_3_8()
	 {
		 /*(4.1.3.8) Un programa que reserve espacio para un vector de
		  * 3 componentes, pida al usuario valores para dichas componentes
		  * (por ejemplo [2, -5, 7]) y muestre su módulo (la raíz cuadrada de
		  * la suma de sus componentes al cuadrado; por ejemplo,
		  * para [2, -5, 7] el resultado sería la raíz cuadrada de 78, 
		  * aproximadamente 8,83).*/
		  
		  int[] vector = new int[3];
		  double modulo;
		  try
		  {
			  Console.WriteLine("Escribe 3 valores:");
			  for ( int i = 0 ; i < 3 ; i++ )
			  {
				  Console.Write("Número "+(i+1)+": ");
				  vector[i] = Convert.ToInt32(Console.ReadLine());
			  }
			  modulo = (double) Math.Sqrt(Math.Pow(vector[0],2)
				+Math.Pow(vector[1],2)+Math.Pow(vector[2],2));
			  Console.WriteLine("El módulo de vector es :" 
				+ modulo.ToString("N2"));
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo"+ e.Message);
		  }
	 }
	 public static void Ejercicio4_1_3_9()
	 {
		 /*(4.1.3.9) Un programa que reserve espacio para dos vectores de 3
		  * componentes, pida al usuario sus valores y calcule la suma de ambos
		  * vectores (su primera componente será x1+y1, 
		  * la segunda será x2+y2 y así sucesivamente).*/
		  double[] vector1 = new double[3];
		  double[] vector2 = new double[3];
		  double[] vector3 = new double[3];
		  
		  Console.WriteLine("Escribe 3 datos para el vector1: ");
		  for ( int i = 0; i < 3 ; i++ )
		  {
			  Console.Write("dato "+(i+1)+": ");
			  vector1[i] = Convert.ToDouble(Console.ReadLine());
		  }
		  Console.WriteLine("Escribe 3 datos para el vector2: ");
		  for ( int i = 0; i < 3 ; i++ )
		  {
			  Console.Write("dato "+(i+1)+": ");
			  vector2[i] = Convert.ToDouble(Console.ReadLine());
		  }
		  Console.WriteLine("Los valores del nuevo vector son:");
		  for ( int i = 0; i < 3 ; i++ )
		  {
			  Console.Write((vector1[i]+vector2[i])+ " ");
		  }
		  Console.WriteLine();	  
	 }
	 public static void Ejercicio4_1_3_10()
	 {
		 /*(4.1.3.10) Un programa que reserve espacio para dos vectores de
		  * 3 componentes, pida al usuario sus valores y calcule su producto
		  * escalar (x1·y1+ x2·y2 + z1·z2).*/
		double[] vector1 = new double[2];
		double[] vector2 = new double[2];
		double[] vector3 = new double[2];
		double prod1 = 0, prod2 = 0, prod3 = 0;
		try
		{
			for (int i = 0 ; i<2 ; i++)
			{
				Console.Write("Introduce el dato numero {0}: ", i+1); 
				vector1[i] = Convert.ToInt32(Console.ReadLine());
			}
			prod1 = vector1[0] * vector1[1];
			for (int i = 0 ; i<2 ; i++)
			{
				Console.Write("Introduce el dato numero {0}: ", i+1); 
				vector2[i] = Convert.ToInt32(Console.ReadLine());
			}
			prod2 = vector2[0] * vector2[1];
			for (int i = 0 ; i<2 ; i++)
			{
				Console.Write("Introduce el dato numero {0}: ", i+1); 
				vector3[i] = Convert.ToInt32(Console.ReadLine());
			}
			prod3 = vector3[0] * vector3[1];
			Console.WriteLine("El resultado del producto escalar es : {0}"
				,prod1 + prod2 + prod3);
		}
		catch (FormatException)
		{
			Console.WriteLine("Error..");
		}
	 }
	 public static void Ejercicio4_1_3_11()
	 {
		 /*(4.1.3.11) Un programa que pida al usuario 4 números enteros y
		  * calcule (y muestre) cuál es el mayor de ellos. Nota: para calcular
		  * el mayor valor de un array, hay que comparar cada uno de los
		  * valores que tiene almacenados el array con el que hasta ese
		  * momento es el máximo provisional. El valor inicial de este máximo
		  * provisional no debería ser cero (porque el resultado sería
		  * incorrecto si todos los números son negativos), sino el primer
		  * elemento del array. Si no lo consigues, en el próximo apartado
		  * tienes más detalles sobre cómo resolver este problema.*/
		  const int CAPACIDAD = 4;
		  int[] numeros = new int[CAPACIDAD];
		  int maximo;
		  
		  try
		  {
			  Console.WriteLine("Vamos a escribir {0} números.", CAPACIDAD);
			  for ( int i = 0; i < CAPACIDAD ; i++ )
			  {
				  Console.Write("Número "+ (i+1) + ": ");
				  numeros[i] = Convert.ToInt32(Console.ReadLine());
			  }
			  maximo = numeros[0];
			  for ( int i = 0; i < CAPACIDAD ; i++ )
			  {
				  if ( numeros[i] > maximo )
					maximo = numeros[i];
			  }
			  Console.WriteLine("El número máximo es {0}", maximo);
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo" + e.Message);
		  }
	 }
 }
	 
