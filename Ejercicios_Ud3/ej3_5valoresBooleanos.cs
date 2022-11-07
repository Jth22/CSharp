/* Ejercicios 3_5 valores booleanos
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios_3_5
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_5 valores booleanos.");
			 Console.WriteLine("Elije una opcion..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_5_1");
			 Console.WriteLine("2. Ejercicio 3_5_2");
			 Console.WriteLine("3. Ejercicio 3_5_3");
			 Console.WriteLine("4. Ejercicio 3_5_4");
			 Console.WriteLine("5. Ejercicio 3_5_5");
			 Console.WriteLine("6. Ejercicio 3_5_6");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio3_5_1(); break;
				 case "2": Ejercicio3_5_2(); break;
				 case "3": Ejercicio3_5_3(); break;
				 case "4": Ejercicio3_5_4(); break;
				 case "5": Ejercicio3_5_5(); break;
				 case "6": Ejercicio3_5_6(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio3_5_1()
	 {
		 /*(3.5.1) Crea un programa que use el operador condicional para dar a
		  * una variable llamada "iguales" (booleana) el valor "true" si los
		  * dos números que ha tecleado el usuario son iguales, o "false" si
		  * son distintos.*/
		 float primerNumero, segundoNumero;
		 bool iguales;
		 
		 try
		 {
			 Console.Write("Escribe un número: ");
			 primerNumero = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Escribe otro número: ");
			 segundoNumero = Convert.ToSingle(Console.ReadLine());
			 
			 iguales = primerNumero == segundoNumero ? true: false;
			 
			 if (iguales)
				Console.WriteLine("los números {0} y {0} son iguales."
					,primerNumero, segundoNumero);
			 else
				Console.WriteLine("los números {0} y {0} son distintos."
					,primerNumero, segundoNumero);
		 }
		 catch ( FormatException e)
		 {
			 Console.WriteLine("Dato erróneo! " + e.Message);
		 }
	 }
	 public static void Ejercicio3_5_2()
	 {
		 /*(3.5.2) Crea una versión alternativa del ejercicio 3.5.1, que use
		  * "if" en vez del operador condicional.*/
		  float primerNumero, segundoNumero;
		 bool iguales;
		 
		 try
		 {
			 Console.Write("Escribe un número: ");
			 primerNumero = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Escribe otro número: ");
			 segundoNumero = Convert.ToSingle(Console.ReadLine());
			 
			 if ( primerNumero == segundoNumero )
				iguales = true;
			 else
				iguales = false;
			 
			 if (iguales)
				Console.WriteLine("los números {0} y {0} son iguales."
					,primerNumero, segundoNumero);
			 else
				Console.WriteLine("los números {0} y {0} son distintos."
					,primerNumero, segundoNumero);
		 }
		 catch ( FormatException e)
		 {
			 Console.WriteLine("Dato erróneo! " + e.Message);
		 }
	 }
	 public static void Ejercicio3_5_3()
	 {
		 /*(3.5.3) Crea una versión alternativa del ejercicio 3.5.1, que
		  * asigne directamente el valor al booleano a partir de una comparación.*/
		 float primerNumero, segundoNumero;
		 bool iguales;
		 
		 try
		 {
			 Console.Write("Escribe un número: ");
			 primerNumero = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Escribe otro número: ");
			 segundoNumero = Convert.ToSingle(Console.ReadLine());
			 
			 iguales = (primerNumero == segundoNumero);
			 
			 if (iguales)
				Console.WriteLine("los números {0} y {0} son iguales."
					,primerNumero, segundoNumero);
			 else
				Console.WriteLine("los números {0} y {0} son distintos."
					,primerNumero, segundoNumero);
		 }
		 catch ( FormatException e)
		 {
			 Console.WriteLine("Dato erróneo! " + e.Message);
		 }
	 }
	 public static void Ejercicio3_5_4()
	 {
		 /*(3.5.4) Crea un programa que use el operador condicional para dar a
		  * una variable llamada "ambosPares" (booleana) el valor "true" si dos
		  * números introducidos por el usuario son pares, o "false" si alguno
		  * es impar.*/
		  int primerNumero, segundoNumero;
		  bool ambosPares;
		  
		  try
		  {
			  Console.Write("Dime un número: ");
			  primerNumero = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Dime otro número: ");
			  segundoNumero = Convert.ToInt32(Console.ReadLine());
			  
			  ambosPares = (primerNumero%2 == 0 && segundoNumero%2 == 0) ? true
				: false;
			  
			  if ( ambosPares )
				Console.WriteLine("Ambos números son pares");
			  else
				Console.WriteLine("Al menos algún número no es par");
		  }
		  catch ( FormatException e)
		  {
			  Console.WriteLine("Dato erróneo. " + e.Message);
		  }
	 }
	 public static void Ejercicio3_5_5()
	 {
		 /*(3.5.5) Crea una versión alternativa del ejercicio 3.5.4, que use
		  * "if" en vez del operador condicional.*/
		  int primerNumero, segundoNumero;
		  bool ambosPares;
		  
		  try
		  {
			  Console.Write("Dime un número: ");
			  primerNumero = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Dime otro número: ");
			  segundoNumero = Convert.ToInt32(Console.ReadLine());
			  
			  if ( primerNumero%2 == 0 && segundoNumero%2 == 0 )
				ambosPares = true;
			  else
				ambosPares = false;
			  
			  if ( ambosPares )
				Console.WriteLine("Ambos números son pares");
			  else
				Console.WriteLine("Al menos algún número no es par");
		  }
		  catch ( FormatException e)
		  {
			  Console.WriteLine("Dato erróneo. " + e.Message);
		  }
	 }
	 public static void Ejercicio3_5_6()
	 {
		 /*(3.5.6) Crea una versión alternativa del ejercicio 3.5.5, que asigne
		  * directamente el valor al booleano a partir de una comparación.*/
		  int primerNumero, segundoNumero;
		  bool ambosPares;
		  
		  try
		  {
			  Console.Write("Dime un número: ");
			  primerNumero = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Dime otro número: ");
			  segundoNumero = Convert.ToInt32(Console.ReadLine());
			  
			  ambosPares = (primerNumero%2 == 0 && segundoNumero%2 == 0);
			  
			  if ( ambosPares )
				Console.WriteLine("Ambos números son pares");
			  else
				Console.WriteLine("Al menos algún número no es par");
		  }
		  catch ( FormatException e)
		  {
			  Console.WriteLine("Dato erróneo. " + e.Message);
		  }
	 }
 }
