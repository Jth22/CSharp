/* Ejercicios 5.7.3. Parámetros de salida
 * Por Jonathan Sirvent Pedreño
 */
 

using System;

class Ej5_7_3
{
    static void Main()
    {
        string opcion;
	int ejers = 2;
        do
        {
            Console.WriteLine("Ejercicios 5.7.3. Parámetros de salida");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
	    for (int i = 0 ; i < ejers ; i++)
		Console.WriteLine((i+1)+". Ejercicio 5.7.3."+(i+1));
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
                case "1" : Ejercicio5_7_3_1();  break;
                case "2" : Ejercicio5_7_3_2(); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadKey();
            Console.Clear();
        }while(opcion != "0");
    }
    static void Ejercicio5_7_3_1()
    {
	/*(5.7.3.1) Crea una función "Iniciales", similar a la del 
	 * ejercicio 5.7.2.2, que reciba una cadena como "Nacho Cabanes" y
	 * devuelva las letras N y C (primera letra, y letra situada tras el
	 * primer espacio), pero esta vez usando parámetros de salida. Crea
	 * un "Main" que te permita comprobar que funciona correctamente.*/
	 /*(5.7.2.2) Crea una función "Iniciales", que reciba una cadena como
	 * "Nacho Cabanes" y devuelva las letras N y C (primera letra, y letra
	 * situada tras el primer espacio), usando parámetros por referencia.
	 * Crea un "Main" que te permita comprobar que funciona correctamente.*/
	string cadena;
	char letra;
	
	Console.Write("Escribe una cadena: ");
	cadena = Console.ReadLine();
	string[] novaCadenas = cadena.Split(' ');
	Console.Write(cadena+ " ,");
	for (int i = 0 ; i < novaCadenas.Length ; i++)
	{
	    Iniciales(novaCadenas[i], out letra);
	    Console.Write(letra);
	}
    }
    static void Iniciales(string cadena, out char letra)
    {
	letra = Convert.ToChar(cadena.Substring(0,1).ToUpper());
    }
    static void Ejercicio5_7_3_2()
    {
	/*(5.7.3.2) Crea una función "MaxMinArray", parecida a la del
	 * ejercicio 5.7.2.3, que reciba un array de reales de doble precisión
	 * y devuelva el mayor valor almacenado en ese array y el menor,
	 * utilizando parámetros de salida. Pruébala con un "Main" adecuado.*/
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
	    
	MaxMinArray(nums, out max, out min);
	
	for (int i = 0 ; i < nums.Length ; i++)
	    Console.Write(nums[i]+ " ");
	    
	Console.WriteLine();
	Console.WriteLine("El max es "+ max);
	Console.WriteLine("El max es "+ min);
    }
    static void MaxMinArray(double[] nums, out double max, out double min)
    {
	max = nums[0];
	min = nums[0];
	
	for (int i = 0; i < nums.Length ; i++)
	{
	    if (nums[i] > max)
		max = nums[i];
		
	    if (nums[i] < min)
		min = nums[i];
	}
    }
}

