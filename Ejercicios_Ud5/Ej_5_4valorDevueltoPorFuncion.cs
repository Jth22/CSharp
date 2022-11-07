/* Ejercicios 5.4. Valor devuelto por una función. El valor "void"
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class Ej_5_4
{
    static void Main()
    {
        string opcion;
        do
        {
            Console.WriteLine("Ejercicios 5.4. Valor devuelto por una función. El valor \"void\"");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Ejercicio 5.4.1");
            Console.WriteLine("2. Ejercicio 5.4.2");
            Console.WriteLine("3. Ejercicio 5.4.3");
            Console.WriteLine("4. Ejercicio 5.4.4");
            Console.WriteLine("5. Ejercicio 5.4.5");
            Console.WriteLine("6. Ejercicio 5.4.6");
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
                case "1" : Ejercicio5_4_1(); break;
                case "2" : Ejercicio5_4_2(); break;
                case "3" : Ejercicio5_4_3(); break;
                case "4" : Ejercicio5_4_4(); break;
                case "5" : Ejercicio5_4_5(); break;
                case "6" : Ejercicio5_4_6(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadKey();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejercicio5_4_1()
    {
	/*(5.4.1) Crea una función "Cubo" que calcule el cubo de un número real
	 * (float) que se indique como parámetro. El resultado deberá ser otro
	 * número real. Prueba esta función para calcular el cubo de 3.2 y
	 * el de 5.*/
	float numero = 0f, resultado;
	
	try
	{
	    Console.WriteLine("Dime un número: ");
	    numero = Convert.ToSingle(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo" + e.Message);
	}
	resultado = Cubo(numero);
	Console.WriteLine("El cubo de {0} es {1}", numero, resultado);
    }
    static float Cubo(float num)
    {
	float alCubo = 1f;
	for (int i = 0; i < 3 ; i++)
	    alCubo *= num;
	
	return alCubo;
    }
    static void Ejercicio5_4_2()
    {
	/*(5.4.2) Crea una función "Menor" que calcule el menor de dos números
	 * enteros que recibirá como parámetros. El resultado será otro
	 * número entero.*/
	int primerNumero = 0, segundoNumero = 0;
	
	try
	{
	    Console.Write("Dime un número: ");
	    primerNumero = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Dime otro número: ");
	    segundoNumero = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+ e.Message);
	}
	Console.WriteLine("El menor de los números {0} y {1} es {2}"
	    , primerNumero, segundoNumero, Menor(primerNumero, segundoNumero));
    }
    static int Menor(int num1, int num2)
    {
	int peque;
	
	if (num1 > num2)
	    peque = num2;
	else
	    peque = num1;
	    
	return peque;
    }
    
    static void Ejercicio5_4_3()
    {
	/*(5.4.3) Crea una función llamada "Signo", que reciba un número real,
	 * y devuelva un número entero con el valor: -1 si el número es
	 * negativo, 1 si es positivo o 0 si es cero.*/
	float numero = 0f;
	
	try
	{
	    Console.Write("Dame un número: ");
	    numero = Convert.ToSingle(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+ e.Message);
	}
	
	if (Signo(numero) > 0)
	    Console.WriteLine("El valor es positvo: "+ Signo(numero));
	else if (Signo(numero) < 0)
	    Console.WriteLine("El valor es negativo: "+ Signo(numero));
	else
	    Console.WriteLine("El valor es cero: "+ Signo(numero));
    }
    static int Signo(float n)
    {
	int resultado = 0;
	if (n > 0)
	    return 1;
	else if (n < 0)
	    return -1;
	else    
	    return resultado;
    }
    static void Ejercicio5_4_4()
    {
	/*(5.4.4) Crea una función "Inicial", que devuelva la primera letra de
	 * una cadena de texto. Prueba esta función para calcular la primera 
	 * letra de la frase "Hola".*/
	string cadena;
	
	Console.Write("Escribe una frase: ");
	cadena = Console.ReadLine();
	
	Console.WriteLine("Tu cadena es \"{0}\" su primera letra es \"{1}\""
	    , cadena, Inicial(cadena));
    }
    static string Inicial(string frase)
    {
	return frase.Substring(0,1);
    }
    static void Ejercicio5_4_5()
    {
	/*(5.4.5) Crea una función "UltimaLetra", que devuelva la última letra
	 * de una cadena de texto. Prueba esta función para calcular la última
	 * letra de la frase "Hola".*/
	string cadena;
	
	Console.Write("Escribe una frase: ");
	cadena = Console.ReadLine();
	
	Console.WriteLine("Tu cadena es {0} y su última letra es {1} "
	    , cadena, UltimaLetra(cadena));
    }
    static string UltimaLetra(string cadena)
    {
	return cadena.Substring(cadena.Length-1);
    }
    static void Ejercicio5_4_6()
    {
	/*(5.4.6) Crea una función "MostrarPerimSuperfCuadrado" que reciba un
	 * número entero y calcule y muestre en pantalla el valor del perímetro
	 * y de la superficie de un cuadrado que tenga como lado el número que
	 * se ha indicado como parámetro, sin devolver ningún valor.*/
	 
	int numero = 0;
	
	try
	{
	    Console.Write("Dame un número: ");
	    numero = Convert.ToInt32(Console.ReadLine());
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo" +e.Message);
	}
	
	MostrarPermiSuperfCuadrado(numero);
    }
    static void MostrarPermiSuperfCuadrado(int num)
    {
	int perimetro = 0, superficie;
	
	perimetro = num + num;
	superficie = num * num; 
	
	Console.WriteLine("El perímetro de un cuadrado de lado {0} es {1} ", num, perimetro);
	Console.WriteLine("La superficie de un cuadrado de la lado {0} es {1}", num, superficie);
    }
}

