/* Ejercicios 3_2_4 conversión de tipos (typecast)
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios3_2_4
 {
	 static void Main()
	 {
		 string opcion;
		 
		 Console.WriteLine("Ejercicios 3_2_4 (typecast)..");
		 Console.WriteLine("Elige una opción..");
		 Console.WriteLine("0. Salir");
		 Console.WriteLine("1. Ejercicio 3_2_4_1");
		 Console.WriteLine("2. Ejercicio 3_2_4_2");
		 opcion = Console.ReadLine();
		 
		 switch ( opcion )
		 {
			 case "1": Ejercicio3_2_4_1(); break;
			 case "2": Ejercicio3_2_4_2(); break;
			 case "0": break;
			 default: Console.WriteLine("Opción incorrecta."); break;
		 }
	 }
	 public static void Ejercicio3_2_4_1()
	 {
		 /* (3.2.4.1) Crea un programa que calcule la raíz cuadrada del número
		  * que introduzca el usuario. La raíz se deberá calcular como
		  * "double", pero el resultado se mostrará como "float".
		  * (Recuerda: como viste al hacer el ejercicio 3.2.3.3, la raíz
		  * cuadrada de un número x se calcula con Math.Sqrt(x)).*/
		 
		 float resultado;
		 double numUsuario = 0;
		 bool ok = true;
		 do
		 {
			 try
			 {
				 Console.Write("Dime un número: ( Pulsa 0 para salir)");
				 numUsuario = Convert.ToDouble(Console.ReadLine());
				 
				 if ( numUsuario != 0 )
				 {
					 resultado = (float) Math.Sqrt(numUsuario);
					 Console.WriteLine("El resultado de la raíz cuadrada" 
						+ " de {0} es : {1}", numUsuario, resultado);
				 }
			 }
			 catch( FormatException e)
			 {
				 Console.WriteLine("Dato erróneo" + e.Message);
				 ok = false;
			 }
			 
		 }while( !ok  && numUsuario != 0);
	 }
	 public static void Ejercicio3_2_4_2()
	 {
		/* (3.2.4.2) Crea una nueva versión del programa que calcula una
		 * aproximación de PI mediante la
		 * expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...)
		 * con tantos términos como indique el usuario. Debes hacer todas las
		 * operaciones con "double", pero mostrar el resultado como "float". */
		
		int numTerminos = 0;
		float resultado;
		double n1 = 0, j = 1;
		 
		 do
		 {
			 try
			 {
				 Console.Write("Dime el número de términos a mostrar: ");
				 numTerminos = Convert.ToInt32(Console.ReadLine());
				 
				 for (int i=1; i <= numTerminos ; i++)
				 {
					 if ( i%2==1 )
					 {
						n1 = (n1 + (1/j));
					 }	
					 else
					 {
						n1 = (n1 - (1/j));
					 }
					 j+=2;
				 }
				 resultado = (float)n1*4;
				 Console.WriteLine("PI es igual a {0} y el valor de {1} " 
					+ "operaciones es {2}", Math.PI, numTerminos, resultado);
			 }
			 catch( FormatException e)
			 {
				 Console.WriteLine("Dato erróneo." + e.Message);
			 }
		 }while( numTerminos <=0 );
	 }
 }
