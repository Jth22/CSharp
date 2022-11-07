/* Ejercicios 5.5. Variables locales y variables globales
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class Ej5_5
{
    static void Main()
    {
        string opcion;
	int ejers= 7;
        do
        {
            Console.WriteLine("Ejercicios 5.5. Variables locales y variables globales");
            Console.WriteLine("Elije una opción..");
	    Console.WriteLine("0. Salir");
	    for (int i = 0 ; i < ejers ; i++)
		Console.WriteLine((i+1)+". Ejercicio 5.5."+(i+1));
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
                case "1" : Ejercicio5_5_1(); break;
                case "2" : Ejercicio5_5_2(); break;
                case "3" : Ejercicio5_5_3(); break;
                case "4" : Ejercicio5_5_4(); break;
                case "5" : Ejercicio5_5_5(); break;
                case "6" : Ejercicio5_5_6(); break;
		case "7" : Ejercicio5_5_7(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadKey();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejercicio5_5_1()
    {
	/*(5.5.1) Crea una función "PedirEntero", que reciba como parámetros el
	 * texto que se debe mostrar en pantalla, el valor mínimo aceptable y
	 * el valor máximo aceptable. Esta función deberá pedir al usuario
	 * que introduzca el valor, tantas veces como sea necesario, deberá
	 * volvérselo a pedir en caso de error, y deberá devolver un valor
	 * correcto. Pruébalo con un programa que pida al usuario un año 
	 * entre 1800 y 2100*/
	string cadena;
	int anyoMinimo = 1800, anyoMaximo = 2100;
	cadena = "Dame un año entre 1800 y 1900";
	
	Console.WriteLine("El dato es: "
	    +PedirEntero(cadena, anyoMinimo, anyoMaximo));
    }
    static string PedirEntero(string cadena, int minimo, int maximo)
    {
	int dato = 0;
	string datoUsuario = " ";
	do
	{
	    try
	    {
		Console.WriteLine(cadena);
		dato = Convert.ToInt32(Console.ReadLine());
		if (dato >= 1800 && dato <= 2100)
		{
		    datoUsuario = dato.ToString();
		}
	    }
	    catch(FormatException e)
	    {
		Console.WriteLine("Dato erróneo"+ e.Message);
	    }
	}while (dato < minimo || dato > maximo);
	
	return datoUsuario;
    }
    static void Ejercicio5_5_2()
    {
	/*(5.5.2) Crea una función "EscribirTablaMultiplicar", que reciba como
	 * parámetro un número entero, y escriba la tabla de multiplicar de
	 * ese número (por ejemplo, para el 3 deberá llegar desde "3x0=0"
	 * hasta "3x10=30")*/
	int numero = 0;
	 
	Console.Write("Escribe un número: ");
	try
	{
	    numero = Int32.Parse(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+e.Message);
	}
	EscribirTablaMultiplicar(numero);
    }
    static void EscribirTablaMultiplicar(int numero)
    {
	for(int i = 0 ; i <= 10 ; i++)
	    Console.WriteLine(numero+"x"+i+"="+(i*numero));
    }
    static void Ejercicio5_5_3()
    {
	/*(5.5.3) Crea una función "EsPrimo", que reciba un número y devuelva
	 * el valor booleano "true" si es un número primo o "false" en 
	 * caso contrario.*/
	int numero = 0;
	
	Console.Write("Escribe un número: ");
	try
	{
	    numero = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+ e.Message);
	}
	if (numero != 0)
	    Console.WriteLine("El número {0} es primo: {1}",numero,EsPrimo(numero));
	else
	    Console.WriteLine("El número no puede ser \"0\"");
    }
    static bool EsPrimo(int numero)
    {
	int contador = 0;

	for (int i = 1; i <= numero ; i++)
	{
	    if (numero%i == 0)
		contador++;
	}
	if (contador == 2)
	    return true;
	else
	    return false;
    }
    static void Ejercicio5_5_4()
    {
	/*(5.5.4) Crea una función "ContarLetra", que reciba una cadena y
	 * una letra, y devuelva la cantidad de veces que dicha letra aparece
	 * en la cadena. Por ejemplo, si la cadena es "Barcelona" y la letra
	 * es 'a', debería devolver 2 (porque la "a" aparece 2 veces).*/
	 string cadena;
	 char letra;
	 int veces = 0;
	 Console.Write("Dime una frase: ");
	 cadena = Console.ReadLine();
	 Console.Write("Ahora dime una letra:");
	 letra = Convert.ToChar(Console.ReadLine());
	 
	 Console.WriteLine("La letra \""+letra+"\" se repite "
	    +ContarLetra(cadena, letra, veces)+" veces en la cadena \""+cadena+"\"");
    }
    static int ContarLetra(string cadena, char c, int contador)
    {
	for(int i = 0 ; i < cadena.Length ; i++)
	{
	    if (cadena[i] == c)
		contador++;
	}	
	return contador;
    }
    static void Ejercicio5_5_5()
    {
	/*(5.5.5) Crea una función "SumarCifras" que reciba un numero
	 * cualquiera y que devuelva como resultado la suma de sus dígitos.
	 * Por ejemplo, si el número fuera 123, la suma sería 6.*/
	int numero = 0;
	
	Console.Write("Dime un número: ");
	try
	{
	    numero = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+e.Message);
	}
	Console.WriteLine("La suma de todas las cifras del número {0} es {1}"
	    , numero, SumarCifras(numero));
    }
    static int SumarCifras(int num)
    {
	int suma = 0;
	while( num != 0 )
	{
	    suma += num%10;
	    num /= 10;
	}
	return suma;
    }
    static void Ejercicio5_5_6()
    {
	/*(5.5.6) Crea una función "DibujarTriángulo" que reciba una letra y
	 * un número, y escriba un "triángulo" formado por esa letra, que
	 * tenga como anchura inicial la que se ha indicado. Por ejemplo, si
	 * la letra es * y la anchura es 4, debería escribir
		****
		***
		**
		*
	*/
	int numero = 0;
	char letra = ' ';
	
	Console.Write("Dime un número: ");
	try
	{
	    numero = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Ahora dime una letra: ");
	    letra = Convert.ToChar(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo" + e.Message);
	}
	
	DibujarTriangulo(numero, letra);
    }
    static void DibujarTriangulo(int n , char c)
    {
	for (int i = 0 ; i < n ; i++)
	{
	    for (int j = i ; j < n ; j++)
	    {
		Console.Write(c);
	    }
	    Console.WriteLine();
	}
    }
    struct persona
    {
	    public string name;
	    public short age;
	    public int telephon;
	    public string direction;
    }
    static void Ejercicio5_5_7()
    {
	/*(5.5.7) Crea una nueva versión del ejercicio 4.6.3 (datos
	 * de 50 personas), en la que cada una de las funcionalidades que
	 * permite el programa esté desglosada en su propia función
	 * independiente de Main (PedirDatos, MostrarTodos, MostrarPorEdad,
	 * MostrarPorInicial):*/
	/*(4.6.3) Un programa que sea capaz de almacenar los datos de 50
		 * personas: nombre, dirección, teléfono, edad (usando una
		 * tabla de structs). Deberá ir pidiendo los datos uno por uno,
		 * hasta que un nombre se introduzca vacío (se pulse Intro sin
		 * teclear nada). Entonces deberá aparecer un menú que permita:
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
	string inicial = "";
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
	    case "1": MostrarLista(p, cantidad); break;				
	    case "2": MostrarPorEdad(p, edad, cantidad); break;
	    case "3": MostrarPorIdentidad(inicial, cantidad, p); break;
	}
    }
    static void MostrarLista(persona[] p , int cantidad)
    {
	for (int i = 0 ; i < cantidad ; i++)
	{
		Console.WriteLine("Nombre: "+ p[i].name);
		Console.WriteLine("Dirección: "+ p[i].direction);
		Console.WriteLine("Teléfono: "+ p[i].telephon);
		Console.WriteLine("Edad: "+ p[i].age);
		Console.WriteLine();
	}
    }
    static void MostrarPorEdad(persona[] p, int edad, int cantidad)
    {
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
    }
    static void MostrarPorIdentidad(string inicial, int cantidad , persona[] p)
    {
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
    }
}
