/* EJercicios 4_1_4 Operaciones habituales con arryas: buscar, máximo, añadir, insertar, borrar
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejer4_1_4operacionesHabitualesConArrays
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_1_4 operaciones habituales");
			 Console.WriteLine("Elije una opción: ");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio4_1_4_1");
			 Console.WriteLine("2. Ejercicio4_1_4_2");
			 Console.WriteLine("3. Ejercicio4_1_4_3");
			 Console.WriteLine("4. Ejercicio4_1_4_4");
			 Console.WriteLine("5. Ejercicio4_1_4_5");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0" : break;
				 case "1" : Ejercicio4_1_4_1(); break;
				 case "2" : Ejercicio4_1_4_2(); break;
				 case "3" : Ejercicio4_1_4_3(); break;
				 case "4" : Ejercicio4_1_4_4(); break;
				 case "5" : Ejercicio4_1_4_5(); break;
				 default: Console.WriteLine("Opción errónea"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0");
	 }
	 public static void Ejercicio4_1_4_1()
	 {
		 /*(4.1.4.1) Crea una variante del ejemplo 04_01_04a que pida al
		  * usuario el dato a buscar, avise si ese dato no aparece, y que
		  * diga cuántas veces se ha encontrado en caso contrario.*/
		  const int CAPACIDAD = 10;
		  int[] datos = new int[CAPACIDAD];
		  int contador = 0, buscarNumero;
		  bool encontrado = false;
		  
		  Console.WriteLine("Escribe 10 datos");
		  for ( int i = 0 ; i < CAPACIDAD ; i++ )
		  {
			  Console.Write("Numero "+(i+1)+": ");
			  datos[i] = Convert.ToInt32(Console.ReadLine());
		  }
		  Console.WriteLine("Introduce un dato a buscar:");
		  buscarNumero = Convert.ToInt32(Console.ReadLine());
		  for ( int i = 0 ; i < CAPACIDAD ; i++ )
		  {
			  if ( buscarNumero == datos[i])
			  {
				  contador++;
				  encontrado = true;
			  }
		  }
		  if (encontrado)
		  {
			  Console.WriteLine("El número {0} se ha encontrado",
				buscarNumero);
			  Console.WriteLine("Se ha encontrado {0} veces"
				,contador );
		  }
		  else
		  {
			  Console.WriteLine("Número {0} no encontrado", 	buscarNumero);
		  }
	 }
	 public static void Ejercicio4_1_4_2()
	 {
		 /*(4.1.4.2) Crea una variante del ejemplo 04_01_04a que añada un
		  * dato introducido por el usuario al final de los datos existentes.*/
		const int CAPACIDAD = 5;
		int[] numeros = {1,2,3,0,0};
		int cantidad = 3;
		int dato = 0;
		try
		{
			Console.WriteLine("Escribe un numero: ");
			dato = Convert.ToInt32(Console.ReadLine());
		}
		catch ( FormatException )
		{
			Console.WriteLine("Dato erróneo.");
		}
		if ( cantidad < CAPACIDAD )
		{
			numeros[cantidad] = dato;
			cantidad++;
		}
		for ( int i = 0 ; i < CAPACIDAD ; i++)
		{
			Console.Write("{0} ", numeros[i]);
		}
		Console.WriteLine();
	 }
	 public static void Ejercicio4_1_4_3()
	 {
		 /*(4.1.4.3) Crea una variante del ejemplo 04_01_04a que inserte un
		  * dato introducido por el usuario en la posición que elija el
		  * usuario. Debe avisar si la posición escogida es incorrecta 
		  * porque esté más allá del final de los datos).*/
		const int CAPACIDAD = 5;
		int[] numeros = {1,2,3,0,0};
		int cantidad = 3, posicionDato = 0, datoAInsertar = 0;
		try
		{
			Console.Write("Dime la posición del dato: ");
			posicionDato = Convert.ToInt32(Console.ReadLine())-1;
			if ( posicionDato+1 > CAPACIDAD )
			{
				Console.WriteLine("Posición fuera de rango");
			}
			else
			{
				Console.Write("Dime el dato a insertar: ");
				datoAInsertar = Convert.ToInt32(Console.ReadLine());
			}
		}
		catch( FormatException e)
		{
			Console.WriteLine("Dato erróneo" + e.Message);
		}
		for (int i = cantidad ; i > posicionDato ; i-- )
		{
			numeros[i] = numeros[i-1];
		}
		numeros[posicionDato] = datoAInsertar;
		cantidad++;
		for ( int i = 0 ; i < CAPACIDAD ; i++)
		{
			Console.Write("{0} ", numeros[i]);
		}
		Console.WriteLine();
	 }
	 public static void Ejercicio4_1_4_4()
	 {
		 /*(4.1.4.4) Crea una variante del ejemplo 04_01_04a que borre el
		  * dato que se encuentre en la posición que escoja el usuario. Debe
		  * avisar si la posición seleccionada no es válida.*/
		const int CAPACIDAD = 5;
		int[] numeros = {1,2,3,0,0};
		int cantidad = 3, posicionABorrar = 0;
		try
		{
			Console.Write("¿Qué posición quieres borrar? ");
			posicionABorrar = Convert.ToInt32(Console.ReadLine());
			if ( posicionABorrar > CAPACIDAD )
			{
				Console.WriteLine("Posición a borrar fuera de rango");
			}
			else
			{
				for ( int i = posicionABorrar-1 ; i < cantidad ; i++ )
					numeros[i] = numeros[i+1];
			}
			
			for ( int i = 0; i < cantidad ; i++ )
				Console.Write(numeros[i] + " ");
			Console.WriteLine();
		}
		catch( FormatException e )
		{
			Console.WriteLine("Dato erróneo"+ e.Message);
		}		
	 }
	 public static void Ejercicio4_1_4_5()
	 {
		 /*(4.1.4.5) Crea un programa que prepare espacio para un máximo
		  * de 10 nombres. Deberá mostrar al usuario un menú que le permita
		  * realizar las siguientes operaciones:
			* Añadir un dato al final de los ya existentes.
			* Insertar un dato en una cierta posición (como ya se ha comentado,
			  los que queden detrás deberán desplazarse "hacia el final" para
			  dejarle hueco); por ejemplo, si el array contiene "hola", "adiós"
			  y se pide insertar "bien" en la segunda posición, el array
			  pasará a contener "hola", "bien", "adiós".
		    * Borrar el dato que hay en una cierta posición (como se
		      ha visto, lo que estaban detrás deberán desplazarse "hacia el
		      principio" para que no haya huecos); por ejemplo, si el array contiene "hola", "bien", "adiós" y se pide borrar el dato de la segunda posición, el array pasará a contener "hola", "adiós"
		      Mostrar los datos que contiene el array.
			* Salir del programa.*/
		const int CAPACIDAD = 10;
		string[] nombres = new string[CAPACIDAD];
		int cantidad = 0;
		string opcionUsuario;
		
		do
		{
			Console.WriteLine("ELige una opción." );
			Console.WriteLine("1. Añadir un nombre.");
			Console.WriteLine("2. Insertar un nombre.");
			Console.WriteLine("3. Borrar un nombre.");
			Console.WriteLine("4. Mostrar datos.");
			Console.WriteLine("5. Salir del menú.");
			opcionUsuario = Console.ReadLine();
			switch( opcionUsuario )
			{
			case "1": Anyadir(nombres, ref cantidad); break;
			case "2": Insertar( nombres, ref cantidad ); break; 
			case "3": Borrar(nombres, ref cantidad); break;
			case "4": Mostrar(nombres, ref cantidad); break;
			case "5": break;
			default: Console.WriteLine("opcion inválida"); break;
			}
		}while( opcionUsuario != "5");		
	}
	public static void Anyadir(string[] nombres, ref int cantidad)
	{
		if ( cantidad < nombres.Length )
		{
			Console.Write("nombre? ");
			nombres[cantidad] = Console.ReadLine();
			cantidad++;
		}
		Mostrar(nombres, ref cantidad);
		Console.WriteLine();
	}
	public static void Insertar(string[] nombres, ref int cantidad)
	{
		int posicionAInsertar = 0;
		string datoAInsertar = " ";	
		if ( cantidad < nombres.Length )
		{
			try
			{
				Console.Write("Posición a insertar? ");
				posicionAInsertar = Convert.ToInt32(Console.ReadLine())-1;
			}
			catch( FormatException e)
			{
				Console.WriteLine("Dato erróneo"+ e.Message);
			}
			if ( posicionAInsertar < cantidad && cantidad < nombres.Length )
			{
				Console.Write("Dato a insertar? ");
				datoAInsertar = Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Array lleno");
			}
			for ( int i = cantidad ; i > posicionAInsertar ; i-- )
			{
				nombres[i] = nombres[i-1];
			}
			nombres[posicionAInsertar] = datoAInsertar;
			cantidad++;
			
		}
		Mostrar(nombres, ref cantidad);
		Console.WriteLine();
	}
	public static void Borrar(string[] nombres, ref int cantidad)
	{
		int datoaBorrar = 0;
		try
		{ 
			Console.Write("Posición a borrar? ");
			datoaBorrar = Convert.ToInt32(Console.ReadLine())-1;
		}
		catch( FormatException e )
		{
			Console.WriteLine("Dato erróneo" + e.Message);
		}
		for ( int i = datoaBorrar ; i < cantidad ; i++)
		{
			nombres[i] = nombres[i+1];
		}
		cantidad--;
		Mostrar(nombres, ref cantidad);
		Console.WriteLine();
	}
	public static void Mostrar(string[] nombres,ref int cantidad)
	{
		for (int i = 0 ; i < cantidad ; i++ )
					Console.WriteLine(nombres[i]);
	}
 }
