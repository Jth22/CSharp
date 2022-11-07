/* Ejercicios 5.7.2. Paso de parámetros por referencia
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;

class Ej5_7_2
{
    static void Main()
    {
        string opcion;
	int ejers = 3;
        do
        {
            Console.WriteLine("......");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
	    for (int i = 0 ; i < ejers ; i++)
		Console.WriteLine((i+1)+". Ejercicio 5_7_2_"+(i+1));
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
                case "1" : Ejercicio5_7_2_1(); break;
                case "2" : Ejercicio5_7_2_2(); break;
                case "3" : Ejercicio5_7_2_3(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadKey();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejercicio5_7_2_1()
    {
	/*(5.7.2.1) Crea una función "Intercambiar", que intercambie el valor
	 * de los dos números enteros que se le indiquen como parámetro. Crea
	 * también un programa que la pruebe.*/
	int primerNumero = 0, segundoNumero= 0;
	
	Console.Write("Dime un número: ");
	try
	{
	    primerNumero = Convert.ToInt32(Console.ReadLine());
	    Console.Write("Ahora dame otro número: ");
	    segundoNumero = Convert.ToInt32(Console.ReadLine()); 
	}
	catch(FormatException e)
	{
	    Console.WriteLine("Dato erróneo"+ e.Message);
	}
	Console.WriteLine("Los valore inicales son:");
	Console.WriteLine("Primer número: "+ primerNumero);
	Console.WriteLine("Segundo número: "+ segundoNumero);
	Console.WriteLine("Los valores intercambiados  son:");
	Intercambiar(ref primerNumero, ref segundoNumero);
	Console.WriteLine("Primer número: "+ primerNumero);
	Console.WriteLine("Segundo número: "+ segundoNumero);
    }
    static void Intercambiar(ref int uno, ref int dos)
    {
	int aux = uno;
	uno = dos;
	dos = aux;
    }
    static void Ejercicio5_7_2_2()
    {
	/*(5.7.2.2) Crea una función "Iniciales", que reciba una cadena como
	 * "Nacho Cabanes" y devuelva las letras N y C (primera letra, y letra
	 * situada tras el primer espacio), usando parámetros por referencia.
	 * Crea un "Main" que te permita comprobar que funciona correctamente.*/
	string cadena;
	char letra = ' ';
	
	Console.Write("Escribe una cadena: ");
	cadena = Console.ReadLine();
	string[] novaCadenas = cadena.Split(' ');
	Console.Write(cadena+ " ,");
	for (int i = 0 ; i < novaCadenas.Length ; i++)
	{
	    Iniciales(novaCadenas[i], ref letra);
	    Console.Write(letra);
	}
    }
    static void Iniciales(string cadena, ref char letra)
    {
	letra = Convert.ToChar(cadena.Substring(0,1).ToUpper());
    }
    static void Ejercicio5_7_2_3()
    {
	/*(5.7.2.3) Crea una función "MaxMinArray", que reciba un array de
	 * reales de doble precisión y devuelva el mayor valor almacenado en
	 * ese array y el menor, utilizando parámetros por referencia.
	 * Pruébala con un "Main" adecuado.*/
	const int CAPACIDAD = 10;
	double[] nums = new double[CAPACIDAD];
	double max, min;
	Random rm = new Random();
	
	for (int i = 0; i < nums.Length ; i++)
	    nums[i] = rm.Next(1,15);
	    
	max = nums[0];
	min = nums[0];
	
	MaxMinArray(nums, ref max, ref min);
	
	for (int i = 0 ; i < nums.Length ; i++)
	    Console.Write(nums[i]+ " ");
	    
	Console.WriteLine();
	Console.WriteLine("El max es "+ max);
	Console.WriteLine("El max es "+ min);
    }
    static void MaxMinArray(double[] nums, ref double max, ref double min)
    {
	for (int i = 0; i < nums.Length ; i++)
	{
	    if (nums[i] > max)
		max = nums[i];
		
	    if (nums[i] < min)
		min = nums[i];
	}
    }
}
