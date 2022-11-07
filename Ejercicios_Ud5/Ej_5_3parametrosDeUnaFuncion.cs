/* Ejercicios 5.3. Parámetros de una función
 * Por Jonathan Sirvent Pedreño
 */
  
using System;

class Ej_5_3
{
    static void Main()
    {
        string opcion;
        do
        {
            Console.WriteLine("Ejercicios 5.3. Parámetros de una función");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
	    Console.WriteLine("1. Ejercicio 5_3_1");
	    Console.WriteLine("2. Ejercicio 5_3_2");
	    Console.WriteLine("3. Ejercicio 5_3_3");
	    Console.WriteLine("4. Ejercicio 5_3_4");
	    Console.WriteLine("5. Ejercicio 5_3_5");
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
                case "1" : Ejercicio5_3_1(); break;
                case "2" : Ejercicio5_3_2(); break;
                case "3" : Ejercicio5_3_3(); break;
                case "4" : Ejercicio5_3_4(); break;
                case "5" : Ejercicio5_3_5(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadKey();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejercicio5_3_1()
    {
	/*(5.3.1) Crea una función "DibujarCuadrado" que dibuje en pantalla un
	 * cuadrado de asteriscos del ancho (y alto) que se indique como
	 * parámetro. Completa el programa con un Main que permita probarla.*/
	 int ancho = 0, alto = 0;
	 
	try
	{
	    Console.Write("Dime el ancho? ");
	    ancho = Convert.ToInt32(Console.ReadLine());
	    alto = ancho;
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Formato erróneo"+ e.Message);
	}
	DibujarCuadrado(ancho, alto);
    }
    static void DibujarCuadrado(int ancho, int alto)
    {
	for (int i = 0 ; i < alto ; i++ )
	{
	    for (int j = 0 ; j < ancho ; j++)
	    {
		Console.Write("*");
	    }
	    Console.WriteLine();
	}
    }
    static void Ejercicio5_3_2()
    {
	/*(5.3.2) Crea una función "DibujarRectangulo" que dibuje en pantalla
	 * un rectángulo del ancho y alto que se indiquen como parámetros, en
	 * ese orden. Incluye un Main para probarla.*/
	int ancho = 0, alto = 0;
	 
	try
	{
	    Console.Write("Dime el ancho: ");
	    ancho = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Dime el alto: ");
	    alto = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Formato erróneo"+ e.Message);
	}
	DibujarRectangulo(ancho, alto);
    }
    static void DibujarRectangulo(int ancho, int alto)
    {
	for (int i = 0 ; i < alto ; i++ )
	{
	    for (int j = 0 ; j < ancho ; j++)
	    {
		Console.Write("*");
	    }
	    Console.WriteLine();
	} 
    }
    static void Ejercicio5_3_3()
    {
	/*(5.3.3) Crea una función "DibujarRectanguloHueco" que dibuje en
	 * pantalla un rectángulo hueco del ancho y alto que se indiquen como
	 * parámetros, formado por una letra que también se indique como
	 * parámetro. Completa el programa con un Main que pida esos datos al
	 * usuario y dibuje el rectángulo.*/
	char letra = ' ';
	int ancho = 0, alto = 0;
	 
	try
	{
	    Console.Write("Dime el ancho? ");
	    ancho = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Dime el ancho? ");
	    alto = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Dime un carcater? ");
	    letra = Convert.ToChar(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+e.Message);
	} 
	DibujarRectanguloHueco(ancho, alto, letra);
    }
    static void DibujarRectanguloHueco(int ancho, int alto, char M)
    {
	for (int i = 0 ; i < alto ; i++ )
	{
	    for (int j = 0 ; j < ancho ; j++)
	    {
		if (i == 0 || i == ancho-1 || j == alto-1 || j == 0)
		    Console.Write(M);
		else
		    Console.Write(" ");
	    }
	    Console.WriteLine();
	} 
    }
    static void Ejercicio5_3_4()
    {
	/*(5.3.4) Crea una función "EscribirRepetido", que reciba un carácter
	 * y un número, y escriba ese carácter tantas veces como indique ese
	 * número (todas ellas en la misma línea).*/
	int repetir = 0;
	char caracter = ' ';
	 
	try
	{
	    Console.Write("Dime un carcater? ");
	    caracter = Convert.ToChar(Console.ReadLine());
	    Console.Write("Cunatas veces lo repito? ");
	    repetir = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{ 
	    Console.WriteLine("Dato erróneo"+e.Message);
	}
	EscribirRepetido(caracter, repetir);
    }
    static void EscribirRepetido(char c, int n)
    {
	for (int i = 0 ; i < n ; i++)
	    Console.Write(c);
    }
    static void Ejercicio5_3_5()
    {
	/*(5.3.5) Crea una nueva versión de la función "DibujarRectangulo",
	 * que se apoye en la "EscribirRepetido" que acabas de crear.*/
	int repetir = 0, ancho = 0, alto = 0;
	char caracter = ' ';
	 
	try
	{
	    Console.Write("Ancho? ");
	    ancho = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Alto? ");
	    alto = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Dime un carcater? ");
	    caracter = Convert.ToChar(Console.ReadLine());
	    Console.Write("Cunatas veces lo repito? ");
	    repetir = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{ 
	    Console.WriteLine("Dato erróneo"+e.Message);
	}
	EscribirRepetidoRectangulo(caracter, repetir, ancho, alto);
    }
    static void EscribirRepetidoRectangulo(char c, int rep, int an, int al)
    {
	for (int i = 0 ; i < rep ; i++)
	{
	    for (int j = 0 ; j < al ; j++ )
	    {
		for (int k = 0 ; k < an ; k++)
		{
		    Console.Write(c);
		}
		Console.WriteLine();
	    }
	    Console.WriteLine();
	}	
    }
}

