/* ejercicios 3_1_3 Incremento y decremento
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios3_1_3
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine();
			 Console.WriteLine("Elige una opción...");
			 Console.WriteLine("1. Ejercicio3_1_3_1.");
			 Console.WriteLine("2. Ejercicio3_1_3_2.");
			 Console.WriteLine("0. Salir.");
			 opcion = Console.ReadLine();
			 
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_1_3_1(); break;
				 case "2": Ejercicio3_1_3_2(); break;
				 case "0": break;
				 default: Console.WriteLine("Opción incorrecta!!");  break;
			 }
		 }while( opcion != "0");
	 }
	 public static void  Ejercicio3_1_3_1()
	 {
		 /* (3.1.3.1) Crea un programa que use tres variables enteras x,y,z.
		  * Sus valores iniciales serán 15, -10, 2.147.483.647. Se deberá
		  * incrementar el valor de estas variables. ¿Qué valores esperas que
		  * se obtengan? Contrástalo con el resultado obtenido por el programa.*/
		 int x = 15, y = -10;
		 long z = 2147483647;
		 Console.WriteLine("El valor de {0} es {1}", x, ++x);
		 Console.WriteLine("El valor de {0} es {1}", y, ++y);
		 Console.WriteLine("El valor de {0} es {1}", z, ++z);
	 }
	 public static void Ejercicio3_1_3_2()
	 {
		 /* (3.1.3.2) ¿Cuál sería el resultado de las siguientes operaciones? 
		  * a=5; b=++a; c=a++; b=b*5; a=a*2; Calcúlalo a mano y luego crea un
		  * programa que lo resuelva, para ver si habías hallado la
		  * solución correcta.*/
		 int a, b, c;
		 a = 5;
		 b = ++a;
		 c = a++;
		 b = b * 5;
		 a = a * 2;
		 Console.WriteLine("a = "+ a);
		 Console.WriteLine("b = "+ b);
		 Console.WriteLine("c = "+ c);
	 }
 }
