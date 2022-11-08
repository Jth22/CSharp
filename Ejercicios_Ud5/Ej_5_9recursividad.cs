/* Ejercicios 5.9. Recursividad
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class EJ5_9
{
    static void Main()
    {
        string opcion;
	int ejers = 11;
        do
        {
            Console.WriteLine("Ejercicios 5.9. Recursividad");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
	    for (int i = 0 ; i < ejers ; i++)
		Console.WriteLine((i+1)+". Ejercicio 5_9_"+(i+1));
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
		case "1" : Ejericio5_9_1(); break;
		case "2" : Ejericio5_9_2(); break;
		case "3" : Ejericio5_9_3(); break;
		case "4" : Ejericio5_9_4(); break;
		case "5" : break;
		case "6" : break;
		case "7" : break;
		case "8" : break;
		case "9" : break;
		case "10" : break;
		case "11" : break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadLine();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejericio5_9_1()
    {
	/*(5.9.1) Crea una función que calcule el valor de elevar un número
	 * entero a otro número entero (por ejemplo, 5 elevado 
	 * a 3 = 53 = 5 ·5 ·5 = 125). Esta función se debe crear de forma
	 * recursiva. Piensa cuál será el caso base (qué potencia se puede
	 * calcular de forma trivial) y cómo pasar del caso "n-1" al caso "n"
	 * (por ejemplo, si sabes el valor de 54, cómo hallarías el
	 * de 55 a partir de él).*/
	 int numero, exponente;
	 
	 do
	 {
	     Console.Write("Dime un número: ");
	   
	 }while(!Int32.TryParse(Console.ReadLine(), out numero)&&  numero <= 0 );
	 do
	 {
	       Console.Write("Dime un exponente: ");
	 }while(!Int32.TryParse(Console.ReadLine(), out exponente)&& exponente < 0);
	int result = Elevar(ref numero, exponente);
	Console.WriteLine(result);
    }
    static int Elevar(ref int numero, int expo)
    {
	if ( expo == 0)
	    return 1;
	    
	return numero*Elevar(ref numero, expo-1);
    }
    static void Ejericio5_9_2()
    {
	/*(5.9.2) Como alternativa, crea una función que calcule el valor de elevar un número entero a otro número entero de forma NO recursiva (lo que llamaremos "de forma iterativa"), usando la orden "for".*/
	int numero, expo;
	do
	{
	    Console.Write("Dime un número: " );
	}while(!Int32.TryParse(Console.ReadLine(), out numero) && numero <= 0);
	do
	{
	    Console.Write("Dime el esponente: ");
	}while(!Int32.TryParse(Console.ReadLine(), out expo) && expo <= 0);
	int result = ElevarIterativo(ref numero, expo); 
	Console.WriteLine("El resultado de {0} elevado {1} es {2} "
	    ,numero, expo, result);
    }
    static int ElevarIterativo(ref int num, int expo)
    {
	int result2 = 1;
	for (int i = 0 ; i < expo ; i++)
	    result2 = result2 * num ;
	    
	return result2;
    }
    static void Ejericio5_9_3()
    {
	/*(5.9.3) Crea un programa que emplee recursividad para calcular un
	 * número de la serie Fibonacci (en la que los dos primeros elementos
	 * valen 1, y para los restantes, cada elemento es la suma de los
	 * dos anteriores).*/
	int cantidad;
	
	do
	{
	    Console.Write("¿cuántos números quieres de la serie FIbonacci: ");
	}while(!Int32.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0);
	
	for (int i = 0 ; i < cantidad ; i++)
	{
	    Console.Write(Fibonacci(i)+ " ");
	}
    }
    static int Fibonacci(int n)
    {
	if (n <= 1)
	    return n;
	    
	return Fibonacci(n-2)+Fibonacci(n-1);
    }
    static void Ejericio5_9_4()
    {
	/*(5.9.4) Crea un programa que emplee recursividad para calcular la
	 * suma de los elementos de un vector de números enteros, desde su
	 * posición inicial a la final, usando una función recursiva que
	 * tendrá la apariencia: SumaVector(v, desde, hasta). Nuevamente,
	 * piensa cuál será el caso base (cuántos elementos podrías sumar para
	 * que dicha suma sea trivial) y cómo pasar del caso "n-1" al caso "n"
	 * (por ejemplo, si conoces la suma de los 6 primeros elementos y el
	 * valor del séptimo elemento, cómo podrías emplear esta información
	 * para conocer la suma de los 7 primeros).*/
	const int CAPACIDAD = 5 ;
	int[] v1 = new int [CAPACIDAD];
	Random rm = new Random();
	int inicio = 0, final = v1.Length-1;
	
	for (int i = 0 ; i < v1.Length ; i++)
	    v1[i] = rm.Next(1,15);
	    
	int result = Sumar(v1,inicio,final);
	Console.WriteLine("Los elementos del array son: "++);
	for(int i = 0; i < v1.Length ; i++)
	    Console.Write(v1[i]+ " ");
	    
	Console.WriteLine();
	Console.WriteLine("La suma de los elementos del vector son: " +result);
	
    }
    static int Sumar(int[] v1, int inicio, int final)
    {
	if (inicio == final)
	    return v1[final];
	
	return v1[inicio]+ Sumar(v1, (inicio+1), final);
    }
    static void Ejericio5_9_5()
    {
	/*(5.9.5) Crea un programa que emplee recursividad para calcular el
	 * mayor de los elementos de un vector. El planteamiento será muy
	 * similar al del ejercicio anterior.*/
    }
    static void Ejericio5_9_6()
    {
	/*(5.9.6) Crea un programa que emplee recursividad para dar la vuelta
	 * a una cadena de caracteres (por ejemplo, a partir de "Hola"
	 * devolvería "aloH"). La función recursiva se llamará
	 * "Invertir(cadena)". Como siempre, analiza cuál será el caso base
	 * (qué longitud debería tener una cadena para que sea trivial darle
	 * la vuelta) y cómo pasar del caso "n-1" al caso "n" (por ejemplo, si
	 * ya has invertido las 5 primeras letras, que ocurriría con la
	 * letra de la sexta posición).*/
    }
    static void Ejericio5_9_7()
    {
	/*(5.9.7) Crea, tanto de forma recursiva como de forma iterativa, una
	 * función diga si una cadena de caracteres es simétrica (un palíndromo). Por ejemplo, "OSO", "RADAR" y "DABALEARROZALAZORRAELABAD" son palíndromos.*/
    }
    static void Ejericio5_9_8()
    {
	/*(5.9.8) Crea un programa que encuentre el máximo común divisor de dos números usando el algoritmo de Euclides: Dados dos números enteros positivos m y n, tal que m > n, para encontrar su máximo común divisor, es decir, el mayor entero positivo que divide a ambos, se puede: 1) Dividir m por n para obtener el resto r (0 ≤ r < n) ; 2) Si r = 0, el MCD es n; 3) Si el resto no es cero, el máximo común divisor es MCD(n,r).*/
    }
    static void Ejericio5_9_9()
    {
	/*(5.9.9) Crea dos funciones que sirvan para saber si un cierto texto es subcadena de una cadena. No puedes usar "Contains" ni "IndexOf", sino que debes analizar letra a letra. Una función debe ser iterativa y la otra debe ser recursiva.*/
    }
    static void Ejericio5_9_10()
    {
	/*(5.9.10) Crea una función que reciba una cadena de texto, y una subcadena, y devuelva cuántas veces aparece la subcadena en la cadena, como subsecuencia formada a partir de sus letras en orden. Por ejemplo, si recibes la palabra "Hhoola" y la subcadena "hola", la respuesta sería 4, porque se podría tomar la primera H con la primera O (y con la L y con la A), la primera H con la segunda O, la segunda H con la primera O, o bien la segunda H con la segunda O. Si recibes "hobla", la respuesta sería 1. Si recibes "ohla", la respuesta sería 0, porque tras la H no hay ninguna O que permita completar la secuencia en orden.*/
    }
    static void Ejericio5_9_11()
    {
	/*(5.9.11) El algoritmo de ordenación conocido como "Quicksort", parte de la siguiente idea: para ordenar un array entre dos posiciones "i" y "j", se comienza por tomar un elemento del array, llamado "pivote" (por ejemplo, el punto medio); luego se recoloca el array de modo que todos los elementos menores que el pivote queden a su izquierda y los mayores a su derecha; finalmente, se llama de forma recursiva a Quicksort para cada una de las dos mitades. El caso base de la función recursiva es cuando se llega a un array de tamaño 0 ó 1. Implementa una función que ordene un array usando este método.*/
    }
}

