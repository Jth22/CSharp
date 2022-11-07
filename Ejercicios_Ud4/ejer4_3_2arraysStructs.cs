/* Ejercicios 4.3.2. Arrays de structs
 * por jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejer4_3_2arryasStruct
 {
	  struct imagen
	 {
		 public string nombre;
		 public int ancho;
		 public int alto;
		 public int tamanio;
	 }
	 struct musicaMp3
	 {
		 public string artista;
		 public string titulo;
		 public int duracion;
		 public int tamanyo;
	 }
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_3_2 Arrays de Structs");
			 Console.WriteLine("Elije una opción:");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio4_3_2_1");
			 Console.WriteLine("2. Ejercicio4_3_2_2");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_3_2_1(); break;
				 case "2": Ejercicio4_3_2_2(); break;
				 default: Console.WriteLine("Opción errónea."); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio4_3_2_1()
	 {
		 /*(4.3.2.1) Amplia el programa del ejercicio 4.3.1.1, para que
		  * almacene datos de hasta 100 canciones. Deberá tener un menú que
		  * permita al usuario realizar las opciones: añadir una nueva canción,
		  * mostrar el título de todas las canciones, buscar la canción que
		  * contenga un cierto texto (en el artista o en el título). Recuerda
		  * que el array estará sobredimensionado, así que deberás llevar un
		  * contador de la cantidad de datos que hay almacenados hasta el
		  * momento.*/
		  int cantidad = 0, posicion = 0;
		  musicaMp3[] discos = new musicaMp3[100];
		  string op, datoABuscar;
		  bool encontrado = false;
		  
		  do
		  {
			  Console.WriteLine("Elije una opcioón.");
			  Console.WriteLine("0. Salir");
			  Console.WriteLine("1. Añadir");
			  Console.WriteLine("2. Mostrar");
			  Console.WriteLine("3. Buscar");
			  op = Console.ReadLine();
			  switch( op ) 
			  {
				  case "0": break;
				  case "1": 
						if ( cantidad < discos.Length )
						{
							Console.Write("Artista? ");
							discos[cantidad].artista = Console.ReadLine();
							Console.Write("Título? ");
							discos[cantidad].titulo = Console.ReadLine();
							Console.Write("Duración? ");
							try
							{
								discos[cantidad].duracion = Convert.ToInt32(Console.ReadLine());
								Console.Write("Tamaño? ");
								discos[cantidad].tamanyo = Convert.ToInt32(Console.ReadLine());
							}
							catch( FormatException e)
							{
								Console.Write("Error"+e.Message);
							}
							cantidad++;
						}
						break;
				  case "2":
						for ( int i = 0 ; i < cantidad ; i++ )
						{
							Console.WriteLine("Artista: "+ discos[i].artista);
							Console.WriteLine("Título: "+ discos[i].titulo);
							Console.WriteLine("Duración: "+ discos[i].duracion);
							Console.WriteLine("Tamaño: "+ discos[i].tamanyo);
							Console.WriteLine();
						}
						break;
				  case "3":
						Console.WriteLine("Dato a buscar(Título o artísta)? ");
						datoABuscar = Console.ReadLine();
						for ( int i = 0 ; i < cantidad ; i++ )
						{
							if ( discos[i].artista == datoABuscar || 
								discos[i].titulo == datoABuscar)
							{
								encontrado = true;
								posicion = i;
							}
						}
						if (encontrado)
						{
							Console.WriteLine("los datos buscados son: ");
							Console.WriteLine("Artista: "+ discos[posicion].artista);
							Console.WriteLine("Título: "+ discos[posicion].titulo);
							Console.WriteLine("Duración: "+ discos[posicion].duracion);
							Console.WriteLine("Tamaño: "+ discos[posicion].tamanyo);
							Console.WriteLine();
						}
						break;
				  default: Console.WriteLine("Opción errónea"); break;
			  }
		  }while(op != "0" );
	 }
	
	 public static void Ejercicio4_3_2_2()
	 {
		 /*(4.3.2.2) Crea un programa que permita guardar datos de "imágenes"
		  * (ficheros de ordenador que contengan fotografías o cualquier otro
		  * tipo de información gráfica). De cada imagen se debe guardar:
		  * nombre (texto), ancho en píxeles (por ejemplo 2000), alto en
		  * píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6).
		  * El programa debe ser capaz de almacenar hasta 700 imágenes
		  * (deberá avisar cuando su capacidad esté llena). Debe permitir las
		  * opciones: añadir una ficha nueva, ver todas las fichas (número y
		  * nombre de cada imagen), buscar la ficha que tenga un cierto nombre
		  * (mostrando entonces todos sus datos).*/
		  imagen[] datos = new imagen[700];
		  int cant = 0, posicion = 0;
		  string opcio, datoABuscar;
		  bool encontrado = false;
		  
		  do
		  {
			  Console.WriteLine("Elije una opción...");
			  Console.WriteLine("0. Salir");
			  Console.WriteLine("1. Añadir");
			  Console.WriteLine("2. Mostrar");
			  Console.WriteLine("3. Buscar");
			  opcio = Console.ReadLine();
			  switch( opcio )
			  {
				  case "0": break;
				  case "1": 
					if ( cant < datos.Length )
					{
						Console.Write("Nombre? ");
						datos[cant].nombre = Console.ReadLine();
						try
						{
							Console.Write("Ancho? ");
							datos[cant].ancho = Convert.ToInt32(Console.ReadLine());
							Console.Write("Alto? ");
							datos[cant].alto = Convert.ToInt32(Console.ReadLine());
							Console.Write("Tamaño? ");
							datos[cant].tamanio = Convert.ToInt32(Console.ReadLine());
						}
						catch( FormatException e)
						{
							Console.WriteLine("Formato erróneo"+ e.Message);
						}
						cant++;
					}
					break;
				  case "2": 
					for ( int i = 0 ; i < cant ; i++ )
					{
						Console.WriteLine("Nombre: " + datos[i].nombre);
						Console.WriteLine("Ancho: " + datos[i].ancho);
						Console.WriteLine("Alto: " + datos[i].alto);
						Console.WriteLine("Tamaño: " + datos[i].tamanio);
						Console.WriteLine();
					}
					break;
				  case "3": 
					Console.WriteLine("Nombre a buscar? ");
					datoABuscar = Console.ReadLine();
					for ( int i = 0 ; i < cant ; i++ )
					{
						if ( datos[i].nombre == datoABuscar )
						{
							encontrado = true;
							posicion = i;
						}
					}
					if (encontrado)
					{
						Console.WriteLine("los datos buscados son: ");
						Console.WriteLine("Artista: "+ datos[posicion].nombre);
						Console.WriteLine("Título: "+ datos[posicion].ancho);
						Console.WriteLine("Duración: "+ datos[posicion].alto);
						Console.WriteLine("Tamaño: "+ datos[posicion].tamanio);
						Console.WriteLine();
					}
					break;
				  default: Console.WriteLine("opción errónea!!"); break;
			  }
		  }while( opcio != "0" );
	 }
 }
