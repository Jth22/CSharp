/* Ejercicio 4.3.3. structs anidados
 * Por Jonathan Sirvent Pedreño
 */
 
 /* (4.3.3.1) Amplia el programa 4.3.2.1, para que el campo "duración" se
  * almacene como minutos y segundos, usando un "struct" anidado que contenga
  * a su vez estos dos campos.*/
 
 using System;
 
 class Ejer4_3_3structAnidados
 {
	 struct duracion
	 {
		 public int segundos;
		 public int minutos;
	 }
	 struct musicaMp3
	 {
		 public string artista;
		 public string titulo;
		 public duracion tiempo;
		 public int tamanyo;
	 }
	 static void Main()
	 {
		 /*(4.3.2.1) Amplia el programa del ejercicio 4.3.1.1, para que
		  * almacene datos de hasta 100 canciones. Deberá tener un menú que
		  * permita al usuario realizar las opciones: añadir una nueva canción,
		  * mostrar el título de todas las canciones, buscar la canción que
		  * contenga un cierto texto (en el artista o en el título). Recuerda
		  * que el array estará sobredimensionado, así que deberás llevar un
		  * contador de la cantidad de datos que hay almacenados hasta el
		  * momento.*/
		  int cantidad = 0;
		  musicaMp3[] discos = new musicaMp3[100];
		  string op;

		  do
		  {
			  Console.WriteLine("Elije una opcioón.");
			  Console.WriteLine("0. Salir");
			  Console.WriteLine("1. Añadir");
			  Console.WriteLine("2. Mostrar");
			  Console.WriteLine("3. Buscar");
			  op = Console.ReadLine();
			  Console.WriteLine(new string('*',10));
			  switch( op ) 
			  {
				  case "0": break;
				  case "1": Aniadir(discos, ref cantidad); break;
				  case "2": Mostrar (discos, cantidad); break;
				  case "3": Buscar(discos, cantidad); break;
				  default: Console.WriteLine("Opción errónea"); break;
			  }
		  }while(op != "0" );
	 }
	 static void Aniadir( musicaMp3[] discos, ref int cantidad )
	 {
		 if ( cantidad < discos.Length )
		{
			Console.Write("Artista? ");
			discos[cantidad].artista = Console.ReadLine();
			Console.Write("Título? ");
			discos[cantidad].titulo = Console.ReadLine();
			Console.WriteLine("Duración ");
			try
			{
				Console.Write("Minutos? ");
				discos[cantidad].tiempo.minutos = 
					Convert.ToInt32(Console.ReadLine());
				Console.Write("Segundos? ");
				discos[cantidad].tiempo.segundos = 
					Convert.ToInt32(Console.ReadLine());
				Console.Write("Tamaño? ");
				discos[cantidad].tamanyo = Convert.ToInt32(Console.ReadLine());
			}
			catch( FormatException e)
			{
				Console.Write("Error"+e.Message);
			}
			cantidad++;
		}
	 }
	 static void Mostrar(musicaMp3[] discos, int cantidad)
	 {
		 for ( int i = 0 ; i < cantidad ; i++ )
		 {
			 Console.WriteLine("Artista: "+ discos[i].artista);
			 Console.WriteLine("Título: "+ discos[i].titulo);
			 Console.WriteLine("Duración: ");
			 Console.WriteLine("Minutos: "+ discos[i].tiempo.minutos);
			 Console.WriteLine("Segundos: "+ discos[i].tiempo.segundos);
			 Console.WriteLine("Tamaño: "+ discos[i].tamanyo);
			 Console.WriteLine();
		 }
	 }
	 static void Buscar(musicaMp3[] discos, int cantidad)
	 {
		 string datoABuscar = " ";
		 int posicion = 0;
		 bool encontrado = false;
		 
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
			Console.WriteLine("Duración: ");
			Console.WriteLine("Minutos: "+ discos[posicion].tiempo.minutos);
			Console.WriteLine("Segundos: "+ discos[posicion].tiempo.segundos);
			Console.WriteLine("Tamaño: "+ discos[posicion].tamanyo);
			Console.WriteLine();
		}
	 }
 }

