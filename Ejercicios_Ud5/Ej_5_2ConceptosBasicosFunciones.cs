/* Ejercicios 5.2. Conceptos básicos sobre funciones
 * Por Jonathan Sirvent Pedreño
 */ 
using System;

class Ej5_2
{
    static void Main()
    {
        string opcion;
        do
        {
            Console.WriteLine("Ejercicios 5.2. Conceptos básicos sobre funciones");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Ejercicio 5_2_1");
            Console.WriteLine("2. Ejercicio 5_2_2");
            Console.WriteLine("3. Ejercicio 5_2_3");
            Console.WriteLine(new string('-',20));
            Console.Write("? ");
	    opcion = Console.ReadLine();
            switch(opcion)
            {
                case "0" : break;
                case "1" : Ejercicio_5_2_1(); break;
                case "2" : Ejercicio_5_2_2(); break;
                case "3" : Ejercicio_5_2_3(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadKey();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejercicio_5_2_1()
    {
	    /*(5.2.1) Crea una función llamada "BorrarPantalla", que borre la
	     * pantalla dibujando 25 líneas en blanco. Crea también un "Main"
	     * que permita probarla.*/
	    BorrarPantalla();
    }
    static void BorrarPantalla()
    {
	for(int i = 0 ; i < 25 ; i++)
	{
		Console.WriteLine(" ");
	}
    }
    static void Ejercicio_5_2_2()
    {
	    /*(5.2.2) Crea una función llamada "DibujarCuadrado3x3", que dibuje
	     * un cuadrado formato por 3 filas con 3 asteriscos cada una.
	     * Incluye un "Main" para probarla.*/
	    DibujarCuadrado3x3();
	}
	static void DibujarCuadrado3x3()
	{
		for(int i = 0; i < 3; i++)
		{
			for (int j = 0 ; j < 3 ; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
	struct tipoFicha 
	{ 
		public string nombreFich; // Nombre del fichero 
		public long tamanyo; // El tamaño en KB 
	}
    static void Ejercicio_5_2_3()
    {
	    /*(5.2.3) Descompón en funciones la base de datos de ficheros
	     * (ejemplo 04_06a), de modo que el "Main" sea breve y más legible
	     * (Pista: las variables que se compartan entre varias funciones
	     * deberán estar fuera de todas ellas, y deberán estar precedidas
	     * por la palabra "static").*/
	    int numeroFichas=0; // Número de fichas que ya tenemos
	    string textoBuscar = " "; // Para cuando preguntemos al usuario
	    long tamanyoBuscar = 0; // Para buscar por tamaño
	    tipoFicha[] fichas  = new tipoFicha[1000];
	    
	    int opcion; // La opcion del menú que elija el usuario
	    do 
	    { // Menu principal, repetitivo 
		    Console.WriteLine(); 
		    Console.WriteLine("Escoja una opción:"); 
		    Console.WriteLine("1.- Añadir datos de un nuevo fichero"); 
		    Console.WriteLine("2.- Mostrar los nombres de todos los ficheros"); 
		    Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño"); 
		    Console.WriteLine("4.- Ver datos de un fichero"); 
		    Console.WriteLine("5.- Salir");
		    opcion = Convert.ToInt32( Console.ReadLine() );
		    // Hacemos una cosa u otra según la opción escogida
		    switch(opcion)
		    {
			    case 1: numeroFichas = Anyadir(fichas,  numeroFichas); break; // Añadir un dato nuevo
			    case 2: MostrarTodos(fichas, numeroFichas); break;// Mostrar todos
			    case 3: MostrarTamanyo(fichas, numeroFichas, tamanyoBuscar); break;// Mostrar según el tamaño
			    case 4: Ver(fichas, numeroFichas, textoBuscar); break; // Ver todos los datos (pocos) de un fichero
			    case 5: // Salir: avisamos de que salimos */ 
				    Console.WriteLine("Fin del programa"); 
				    break;
			    default: // Otra opcion: no válida 
				    Console.WriteLine("Opción desconocida!");
				    break;
		    } 
	    } while (opcion != 5); // Si la opcion es 5, terminamos
	}
	static int Anyadir(tipoFicha[] fichas, int numeroFichas)
	{
		if (numeroFichas < 1000)
		{ // Si queda hueco
			Console.WriteLine("Introduce el nombre del fichero: ");
			fichas[numeroFichas].nombreFich = Console.ReadLine(); 
			Console.WriteLine("Introduce el tamaño en KB: "); 
			fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());
			 // Y ya tenemos una ficha más 
			numeroFichas++;
		}
		else // Si no hay hueco para más fichas, avisamos 
			Console.WriteLine("Máximo de fichas alcanzado (1000)!");
		
		
		return numeroFichas;
	}
	static void MostrarTodos(tipoFicha[] fichas, int numeroFichas)
	{
		for (int i=0; i<numeroFichas; i++)
			Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
				, fichas[i].nombreFich, fichas[i].tamanyo);
	}
	static void MostrarTamanyo(tipoFicha[] fichas, int numeroFichas, long tamanyoBuscar)
	{
		Console.WriteLine("¿A partir de que tamaño quieres ver?");
		tamanyoBuscar = Convert.ToInt64( Console.ReadLine() ); 
		for (int i=0; i < numeroFichas; i++)
			if (fichas[i].tamanyo >= tamanyoBuscar) 
				Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
					, fichas[i].nombreFich, fichas[i].tamanyo); 
	}
	static void Ver(tipoFicha[] fichas, int numeroFichas, string textoBuscar)
	{
		Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
		textoBuscar = Console.ReadLine(); 
		for (int i=0; i < numeroFichas; i++) 
		if ( fichas[i].nombreFich == textoBuscar ) 
		Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
			, fichas[i].nombreFich, fichas[i].tamanyo); 
	}
}
