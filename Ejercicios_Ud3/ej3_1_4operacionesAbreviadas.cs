/* Ejercicios 3_1_4 Operaciones abreviadas
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios3_1_4
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			Console.WriteLine("Ejercicios 3_1_4 Operaciones abreviadas.");
			Console.WriteLine("Elije una opción...");
			Console.WriteLine("1. Ejercicio 3_1_4_1");
			Console.WriteLine("2. Ejercicio 3_1_4_2");
			Console.WriteLine("0. Salir");
			opcion = Console.ReadLine();
			
			switch ( opcion )
			{
				case "1": Ejercicio3_1_4_1(); break;
				case "2": Ejercicio3_1_4_2(); break;
				case "0": break;
				default: Console.WriteLine("Opción incorrecta!!"); break;
			}
		 }while ( opcion != "0");
	 }
	 public static void Ejercicio3_1_4_1()
	 {
		 /* (3.1.4.1) Crea un programa que use tres variables x,y,z. Sus valores
		  * iniciales serán 15, -10, 214. Deberás incrementar el valor de estas
		  * variables en 12, usando el formato abreviado. ¿Qué valores esperas que se
		  * obtengan? Contrástalo con el resultado obtenido por el programa.*/
		 int x = 15, y = -10, z = 214;
		 Console.WriteLine("El valor de {0} aumentado 12 es {1}", x, (x += 12));
		 Console.WriteLine("El valor de {0} aumentado 12 es {1}", y, (y += 12));
		 Console.WriteLine("El valor de {0} aumentado 12 es {1}", z, (z += 12));
	 }
	 public static void Ejercicio3_1_4_2()
	 {
		 /* (3.1.4.2) ¿Cuál sería el resultado de las siguientes operaciones?
		  * a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;
		  * Crea un programa que te lo muestre.*/
		 int a, b, c;
		 a = 5; b = a+2; b -= 3; c = -3; c *= 2; ++c;
		 a *= b; 
		 Console.WriteLine("El valor de a es {0}", a);
		 Console.WriteLine("El valor de b es {0}", b);
		 Console.WriteLine("El valor de c es {0}", c);
	 }
 }
