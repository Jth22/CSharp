/* ejercicios 3_1_2 Converiones de cadena a entero
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios3_1_2
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Elige una opción..");
			 Console.WriteLine("1. Ejercicio 3_1_2_1");
			 Console.WriteLine("2. Ejercicio 3_1_2_2");
			 Console.WriteLine("3. Ejercicio 3_1_2_3");
			 Console.WriteLine("0. Salir");
			 opcion = Console.ReadLine();
			 
			 switch (opcion)
			 {
				 case "1": Ejercicio3_1_2_1(); break;
				 case "2": Ejercicio3_1_2_2(); break; 
				 case "3": Ejercicio3_1_2_3(); break;
				 case "0": break;
				 default: Console.WriteLine("Opción incorrecta!!"); break;
			 }
		 }while ( opcion != "0");
	 }
	 
	 public static void Ejercicio3_1_2_1()
	 {
		 /* (3.1.2.1) Pregunta al usuario su edad, que se guardará en un
		  *  "byte". A continuación, le deberás decir que no aparenta tantos
		  *  años (por ejemplo, "No aparentas 20 años").*/
		 byte edadUsuario;
		 try
		 {
			 Console.Write("Dime tu edad? ");
			 edadUsuario = Convert.ToByte(Console.ReadLine());
			 Console.WriteLine("No aparentas "+ edadUsuario + " años");
		 }
		 catch ( FormatException e)
		 {
			 Console.WriteLine("Error de datos" + e.Message);
		 }
		  
	 }
	 
	 public static void Ejercicio3_1_2_2()
	 {
		 byte primerNumero, segundoNumero;
		 int resultado;
		 
		 try
		 {
			 Console.Write("Dime un numero? ");
			 primerNumero = Convert.ToByte(Console.ReadLine());
			 Console.Write("Dime otro numero? ");
			 segundoNumero = Convert.ToByte(Console.ReadLine());
			 resultado = primerNumero * segundoNumero;
			 Console.WriteLine("{0} * {1} = {2}", primerNumero, segundoNumero
				,resultado);
		 }
		 catch ( FormatException e )
		 {
			 Console.WriteLine("Error de datos" + e.Message);
		 }
	 }
	 
	 public static void Ejercicio3_1_2_3()
	 {
		 long numero1;
		 long numero2;
		 
		 try
		 {
			 Console.Write("Dime un número? ");
			 numero1 = Convert.ToInt64(Console.ReadLine());
			 Console.Write("Dime otro número? ");
			 numero2 = Convert.ToInt64(Console.ReadLine());
			 Console.WriteLine();
			 Console.WriteLine("La suma de: {0} + {1} = {2}",numero1
				,numero2, (numero1 + numero2));
			 Console.WriteLine("La resta de: {0} - {1} = {2}",numero1
				,numero2, (numero1 - numero2));
			 Console.WriteLine("El producto de: {0} * {1} = {2}"
				,numero1,numero2,(numero1*numero2));
		}
		catch ( FormatException e)
		{
			Console.WriteLine("Formato erróneo" + e.Message);
		}
	 }
 }
