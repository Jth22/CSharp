/* Ejercicios 4.3.1. Definición y acceso a los datos
 * Por Jonathan Sirvent Pedreño
 */
 /* (4.3.1.1) Crea un "struct" que almacene datos de una canción en
  * formato MP3: Artista, Título, Duración (en segundos), Tamaño del
  * fichero (en KB). Un programa debe pedir los datos de una canción
  * al usuario, almacenarlos en dicho "struct" y después
  * mostrarlos en pantalla.*/
 
 using System;
 
 class Ejer4_3_1_1
 {
	 struct cancion
	 {
		 public string artista;
		 public string titulo;
		 public int duracion;
		 public int tamanyo;
	 }
	 static void Main()
	 {
		 cancion disco;
		 disco.duracion = 0;
		 disco.tamanyo = 0;
		 Console.Write("Artista? ");
		 disco.artista = Console.ReadLine();
		 Console.Write("Título? ");
		 disco.titulo = Console.ReadLine();
		 try
		 {
			 Console.Write("Duración? ");
			 disco.duracion = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Tamaño fichero? ");
			 disco.tamanyo = Convert.ToInt32(Console.ReadLine());
		 }
		 catch( FormatException e )
		 {
			 Console.Write("Error"+ e.Message);
		 }
		 
		 Console.WriteLine("Los datos introducidos son: ");
		 Console.WriteLine("Nombre del artista: " + disco.artista);
		 Console.WriteLine("Título del disco: " + disco.titulo);
		 Console.WriteLine("Duración del disco: " + disco.duracion);
		 Console.WriteLine("Tamaño del fichero: " + disco.tamanyo);
	 }
 }
