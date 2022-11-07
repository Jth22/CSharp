/* Ejercicios 4.6. Ejemplo completo
 * Por Jonathan Sirvent Pedreño
 */
 
using System; 

class Ejercicios4_6
{
	static void Main()
	{
		string opcion;
		
		do
		{
			Console.WriteLine("Ejercicios 4.6. Ejemplo completo");
			Console.WriteLine("Elije una opción..");
			Console.WriteLine("0. Salir");
			Console.WriteLine("1. Ejrcicio 4_6_1");
			Console.WriteLine("2. Ejrcicio 4_6_2");
			Console.WriteLine("3. Ejrcicio 4_6_3");
			Console.WriteLine("4. Ejrcicio 4_6_4");
			Console.WriteLine("5. Ejrcicio 4_6_5");
			Console.WriteLine("6. Ejrcicio 4_6_6");
			Console.WriteLine("7. Ejrcicio 4_6_7");
			Console.WriteLine("8. Ejrcicio 4_6_8");
			Console.WriteLine("9. Ejrcicio 4_6_9");
			Console.Write("? ");
			opcion = Console.ReadLine();
			Console.WriteLine(new string('*', 20));
			switch(opcion)
			{
				case "0": break;
				case "1": Ejercicios4_6_1(); break;
				case "2": Ejercicios4_6_2(); break;
				case "3": Ejercicios4_6_3(); break;
				case "4": Ejercicios4_6_4(); break;
				case "5": Ejercicios4_6_4(); break;
				case "6": Ejercicios4_6_4(); break;
				case "7": Ejercicios4_6_4(); break;
				case "8": Ejercicios4_6_4(); break;
				case "9": Ejercicios4_6_4(); break;
				default: Console.WriteLine("Opción incorrecta!"); break;
			}
			Console.WriteLine();
			Console.WriteLine("Pulsa \"Intro\" para seguir..");
			Console.ReadLine();
			Console.Clear();
		}while( opcion != "0" );
	}
	
	static void Ejercicios4_6_1()
	{
		/*(4.6.1) Un programa que pida el nombre, el apellido y la edad de una
		 * persona, los almacene en un "struct" y luego muestre los tres
		 * datos en una misma línea, separados por comas.*/
		 persona usuario = new persona();
		 
		 Console.Write("Dime tu nombre: ");
		 usuario.name = Console.ReadLine().ToUpper();
		 Console.Write("Dime tu apellido: ");
		 usuario.surname = Console.ReadLine().ToUpper();
		 try
		 {
			Console.Write("Dime tu edad: ");
			usuario.age = Convert.ToInt16(Console.ReadLine());
		}catch( FormatException e)
		{
			Console.WriteLine("Dato erróneo"+e.Message);
		}
		 Console.WriteLine("Tu nombre , apellido y edad es: ");
		 Console.Write(usuario.name+", "+usuario.surname+", "+usuario.age+" años");
		 Console.WriteLine();
	}
	
	static void Ejercicios4_6_2()
	{
		/*(4.6.2) Un programa que pida datos de 8 personas: nombre, día de
		 * nacimiento, mes de nacimiento, y año de nacimiento (que se deben
		 * almacenar en un array de structs). Después deberá repetir lo
		 * siguiente: preguntar un número de mes y mostrar en pantalla los
	 * datos de las personas que cumplan los años durante ese mes.
		 * Terminará de repetirse cuando se teclee 0 como número de mes.*/
		const int CAPACIDAD = 8;
		persona[] p = new persona[CAPACIDAD];
		int usuarioMes = 0;
		
		
		for ( int i = 0; i < CAPACIDAD ; i++ )
		{
			Console.Write("Dime el nombre: ");
			p[i].name = Console.ReadLine();
			try
			{
				Console.Write("Dime día de nacimineto: ");
				p[i].birthday = Convert.ToInt16(Console.ReadLine());
				Console.Write("Dime mes de nacimiento: ");
				p[i].birthMonth = Convert.ToInt16(Console.ReadLine());
				Console.Write("Año de nacimiento: ");
				p[i].yearBirth = Convert.ToInt32(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine("Dato erróneo"+e.Message);
			}
		}
		do
		{
			Console.Write("Dime un mes: (1 al 12)");
			usuarioMes = Convert.ToInt32(Console.ReadLine());
			if ( usuarioMes >= 1 || usuarioMes <=12 )
			{
				for (int i = 0 ; i < CAPACIDAD ; i++)
				{
					if ( usuarioMes == p[i].birthMonth )
					{
						Console.WriteLine("Nombre: "+p[i].name);
						Console.WriteLine("Día Ncimiento: "+p[i].birthday);
						Console.WriteLine("Mes ncaimineto: "+p[i].birthMonth);
						Console.WriteLine("Año de Nacimiento: "+p[i].yearBirth);
						Console.WriteLine();
					}
				}
			} 
		}while( usuarioMes != 0 );
	}
	struct persona
	{
		public string name;
		public string surname;
		public short age;
		public short birthday;
		public int birthMonth;
		public int yearBirth;
		public int telephon;
		public string direction;
	}
	static void Ejercicios4_6_3()
	{
		/*(4.6.3) Un programa que sea capaz de almacenar los datos de 50
		 * personas: nombre, dirección, teléfono, edad (usando una tabla de
		 * structs). Deberá ir pidiendo los datos uno por uno, hasta que un
		 * nombre se introduzca vacío (se pulse Intro sin teclear nada).
		 * Entonces deberá aparecer un menú que permita:
			 Mostrar la lista de todos los nombres.	
			 Mostrar las personas de una cierta edad.
			 Mostrar las personas cuya inicial sea la que el usuario indique.
			 Salir del programa
		 * (lógicamente, este menú debe repetirse hasta que se escoja la
		 * opción de "salir").*/
		const int CAPACIDAD = 50;
		string nombre = " ";
		persona[] p = new persona[CAPACIDAD];
		int cantidad = 0, edad = 0;
		string opcion;
		string inicial;
		do
		{
			Console.Write("Nombre? ");
			nombre = Console.ReadLine();
			if (nombre != "" && cantidad < CAPACIDAD)
			{
				p[cantidad].name = nombre;
				Console.Write("Dirección? ");
				p[cantidad].direction = Console.ReadLine();
				try
				{
					Console.Write("Teléfono? ");
					p[cantidad].telephon = Convert.ToInt32(Console.ReadLine());
					Console.Write("Edad? ");
					p[cantidad].age = Convert.ToInt16(Console.ReadLine());
				}catch(FormatException e)
				{
					Console.WriteLine("Dato erróneo"+e.Message);
				}
				cantidad++;
			}
		}while( nombre != "" && cantidad != CAPACIDAD);
		Console.WriteLine("Elje una opción..");
		Console.WriteLine("1. Mostrar la lista de nombres");
		Console.WriteLine("2. Mostrar las personas de una cierta edad");
		Console.WriteLine("3. Mostrar las personas cuya inicial sea la que el usuario indique");
		opcion = Console.ReadLine();
		switch(opcion)
		{
			case "1": 
				for (int i = 0 ; i < cantidad ; i++)
				{
					Console.WriteLine("Nombre: "+ p[i].name);
					Console.WriteLine("Dirección: "+ p[i].direction);
					Console.WriteLine("Teléfono: "+ p[i].telephon);
					Console.WriteLine("Edad: "+ p[i].age);
					Console.WriteLine();
				}
				break;				
			case "2":
				try
				{
					Console.Write("Dime una edad? ");
					edad = Convert.ToInt32(Console.ReadLine());	
				}
				catch( FormatException e)
				{
					Console.WriteLine("Dato erróneo"+ e.Message);
				}
				for (int i = 0; i < cantidad ; i++)
				{
					if ( edad == p[i].age )
					{
						Console.WriteLine("Nombre: "+ p[i].name);
						Console.WriteLine("Dirección: "+ p[i].direction);
						Console.WriteLine("Teléfono: "+ p[i].telephon);
						Console.WriteLine("Edad: "+ p[i].age);
						Console.WriteLine();
					}
				}
				break;
			case "3": 
				Console.Write("Dime una incial: ");
				inicial = Console.ReadLine();
				
				for (int i = 0; i < cantidad ; i++)
				{
					if ( inicial == p[i].name.Substring(0,1))
					{
						Console.WriteLine("Nombre: "+ p[i].name);
						Console.WriteLine("Dirección: "+ p[i].direction);
						Console.WriteLine("Teléfono: "+ p[i].telephon);
						Console.WriteLine("Edad: "+ p[i].age);
						Console.WriteLine();
					}
				}
				break;
		}
	}
	struct tipoFicha 
	{ 	public string nombreFich; //Nombre del fichero
		public long tamanyo; // El tamaño en KB
	}
	static void Ejercicios4_6_4()
	{
		/*(4.6.4) Mejora la base de datos de ficheros (ejemplo 04_06a) para
		 * que no permita introducir tamaños incorrectos (números negativos)
		 * ni nombres de fichero vacíos.*/
		/*(4.6.5) Amplía la base de datos de ficheros (ejemplo 04_06a) para
		 * que incluya una opción de búsqueda parcial, en la que el usuario
		 * indique parte del nombre y se muestre todos los ficheros que
		 * contienen ese fragmento (usando "Contains" o "IndexOf"). Esta
		 * búsqueda no debe distinguir mayúsculas y minúsculas (con la ayuda
		 * de ToUpper o ToLower, por ejemplo).*/
		/*(4.6.6) Amplía el ejercicio anterior (4.6.5) para añadir la
		 * posibilidad de que la búsqueda sea incremental: el usuario irá
		 * indicando letra a letra el texto que quiere buscar, y se mostrará
		 * todos los datos que lo contienen (por ejemplo, primero los que
		 * contienen "j", luego "ju", después "jua" y finalmente "juan").*/
		/*(4.6.7) Amplía la base de datos de ficheros (ejemplo 04_06a) para
		 * que se pueda borrar un cierto dato (habrá que "mover hacia atrás"
		 * todos los datos que había después de ese, y disminuir el contador
		 * de la cantidad de datos que tenemos).*/
		/*(4.6.8) Mejora la base de datos de ficheros (ejemplo 04_06a) para
		 * que se pueda modificar un cierto dato a partir de su número
		 * (por ejemplo, el dato número 3). En esa modificación, se deberá
		 * permitir al usuario pulsar Intro sin teclear nada, para indicar
		 * que no desea modificar un cierto dato, en vez de reemplazarlo por
		 * una cadena vacía.*/
		/*(4.6.9) Amplía la base de datos de ficheros (ejemplo 04_06a) para
		 * que se permita ordenar los datos por nombre. Para ello, deberás
		 * buscar información sobre algún método de ordenación sencillo, como
		 * el "método de burbuja" (en el siguiente apartado tienes algunos), y
		 * aplicarlo a este caso concreto.*/
		const int CAPACIDAD = 1000;
		tipoFicha[] fichas = new tipoFicha[CAPACIDAD];
		int numeroFichas=0;
		int posicion= 0; // Número de fichas que ya tenemos 
		string opcion; // La opcion del menú que elija el usuario
		string textoBuscar =""; // Para cuando preguntemos al usuario
		string nombreABuscar;
		bool encontrado;
		long tamanyoBuscar; // Para buscar por tamaño
		do 
		{ // Menu principal, repetitivo 
			Console.WriteLine();
			Console.WriteLine("Escoja una opción:");
			Console.WriteLine("1.- Añadir datos de un nuevo fichero"); 
			Console.WriteLine("2.- Mostrar los nombres de todos los ficheros"); 
			Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño"); 
			Console.WriteLine("4.- Ver datos de un fichero");
			Console.WriteLine("5.- Buscar dato");
			Console.WriteLine("6.- Salir");
			opcion =  Console.ReadLine();
			// Hacemos una cosa u otra según la opción escogida 

			switch(opcion) 
				{
			case "1": // Añadir un dato nuevo 
				if ( numeroFichas >= 0 || numeroFichas < 1000 && opcion !="" ) 
				{ // Si queda hueco 
					Console.WriteLine("Introduce el nombre del fichero: "); 
					fichas[numeroFichas].nombreFich = Console.ReadLine();
					try
					{
						Console.WriteLine("Introduce el tamaño en KB: "); 
						fichas[numeroFichas].tamanyo = Convert.ToInt32( Console.ReadLine() );
					}
					catch( FormatException e)
					{
						Console.WriteLine("Dato erróneo"+e.Message);
					}
					// Y ya tenemos una ficha más 
					numeroFichas++;
				 } 
				else // Si no hay hueco para más fichas, avisamos 
					Console.WriteLine("Máximo de fichas alcanzado (1000)!");
					break;
			case "2": // Mostrar todos 
				for (int i=0; i < numeroFichas; i++) 
					Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
					break;
			case "3": // Mostrar según el tamaño
					try
					{
						Console.WriteLine("¿A partir de que tamaño quieres ver?"); 
						tamanyoBuscar = Convert.ToInt64( Console.ReadLine() );
						for (int i=0; i < numeroFichas; i++)
						{ 
							if (fichas[i].tamanyo >= tamanyoBuscar) 
								Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
									, fichas[i].nombreFich, fichas[i].tamanyo);
						}
					}
					catch(FormatException e)
					{
						Console.WriteLine("Dato erróneo"+e.Message);
					}
					break;
			case "4": // Ver todos los datos (pocos) de un fichero 
					Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
					textoBuscar = Console.ReadLine();
					for (int i=0; i < numeroFichas; i++)
						if ( fichas[i].nombreFich == textoBuscar ) 
						{
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
								, fichas[i].nombreFich, fichas[i].tamanyo);
						}
					break;
			case "5": 
					encontrado = false;
					Console.Write("Dime un nombre a buscar ");
					nombreABuscar = Console.ReadLine();
				
					for (int i = 0 ; i < numeroFichas ; i++ )
					{
						if (fichas[i].nombreFich.Contains(nombreABuscar))
						{
							encontrado = true;
							posicion = i;
						}
					}
					if (encontrado)
					{
						Console.WriteLine("Nombre: "+fichas[posicion].nombreFich);
						Console.WriteLine("Tamaño: "+fichas[posicion].tamanyo);
					}
					else
						Console.WriteLine("El nombre {0} no está", nombreABuscar);
					break;
			case "6": // Salir: avisamos de que salimos */
					Console.WriteLine("Fin del programa");
					break;
			default: // Otra opcion: no válida 
					Console.WriteLine("Opción desconocida!");
					break;
					}
		}while (opcion != "6" ); // Si la opcion es 5, terminamos 
	}
}
	
