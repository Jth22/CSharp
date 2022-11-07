/* Ejercicios 3_2_2 simple y doble presición
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios3_2_2
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_2_2 Simple y doble precisión..");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("1. Ejercicio 3_2_2_1");
			 Console.WriteLine("2. Ejercicio 3_2_2_2");
			 Console.WriteLine("0. Salir");
			 opcion = Console.ReadLine();
			 
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_2_2_1(); break;
				 case "2": Ejercicio3_2_2_2(); break;
				 case "0": break;
				 default: Console.WriteLine("Opcion incorrecta."); break;
			 }
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio3_2_2_1()
	 {
		 /* (3.2.2.1) Crea un programa que muestre el resultado de
		 * dividir 13 entre 6 usando números enteros, luego usando
		 * números de coma flotante de simple precisión y luego con
		 *  números de doble precisión.*/
		int primerNumero = 13, segundoNumero = 6, resultadoEntero = 0;
		float resultadoSimple;
		double resultadoDoblePresicion;
		resultadoSimple = (float) primerNumero / segundoNumero;
		resultadoDoblePresicion = (double) primerNumero / segundoNumero;
		Console.WriteLine("El resultado de dividir 13 entre 6 usando " 
			+ "números enteros es: {0}", resultadoEntero);
		Console.WriteLine("El resultado de dividir 13 entre 6 usando "
			+ "coma flotante de simple presición es {0}", resultadoSimple);
		Console.WriteLine("El resultado de dividir 13 entre 6 usando "
			+ "doble presición es {0}", resultadoDoblePresicion);
	 }
	 public static void Ejercicio3_2_2_2()
	 {
		 /* (3.2.2.2) Calcula el área de un círculo, dado su radio, 
		  * que será un número entero (área = pi * radio al cuadrado)
		  * Usa datos de doble precisión.*/
		 int radio;
		 float pi = 3.1416f;
		 double area;
		 Console.Write("Dime el radio del área a calcular? ");
		 radio = Convert.ToInt32(Console.ReadLine());
		 area = (double) pi * radio * radio;
		 Console.WriteLine("El área de un circulo de radio {0} es: {1}"
		  	,radio, area);
	 }
 }
