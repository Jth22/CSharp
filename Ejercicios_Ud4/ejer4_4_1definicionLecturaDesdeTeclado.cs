/* Ejercicios 4.4.1. Definición. Lectura desde teclado
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejer4_4_1
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("4.4.1. Definición. Lectura desde teclado");
			 Console.WriteLine("Elije una opción: ");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 4_4_1_1");
			 Console.WriteLine("2. Ejercicio 4_4_1_2");
			 Console.WriteLine("3. Ejercicio 4_4_1_3");
			 Console.WriteLine("4. Ejercicio 4_4_1_4");
			 opcion = Console.ReadLine();
			 Console.WriteLine(new string('*',15));
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_4_1_1(); break;
				 case "2": Ejercicio4_4_1_2(); break;
				 case "3": Ejercicio4_4_1_3(); break;
				 case "4": Ejercicio4_4_1_4(); break;
				 default: Console.WriteLine("Opción errónea."); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para seguir");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 static void Ejercicio4_4_1_1()
	 {
		 /*(4.4.1.1) Crea un programa que te pida tu nombre y lo escriba 5 veces.*/
		 string nombreUsuario;
		 
		 Console.Write("Dime tu nombre: ");
		 nombreUsuario = Console.ReadLine();
		 for ( int i = 0 ; i < 5 ; i++ )
		 {
			 Console.WriteLine(nombreUsuario);
		 }
	 }
	 static void Ejercicio4_4_1_2()
	 {
		 /*(4.4.1.2) Crea un programa que pida al usuario su nombre. Si se
		  * llama como tú (por ejemplo, "Nacho"), 
		  * responderá "Bienvenido, jefe". 
		  * En caso contrario, le saludará por su nombre.*/
		 string nombreUsuario;
		 
		 Console.Write("Dime tu nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
		 if ( nombreUsuario == "Jonathan" )
		 {
			 Console.WriteLine("Bienvenido, jefe");
		 }
		 else
		 {
			 Console.WriteLine("Bienvenido, "+ nombreUsuario);
		 }
	 }
	 static void Ejercicio4_4_1_3()
	 {
		 /*(4.4.1.3) Un programa que pida tu nombre, tu día de nacimiento y
		  * tu mes de nacimiento y lo junte todo en una cadena, separando el
		  * nombre de la fecha por una coma, y el día y el mes por una barra
		  * inclinada, así: "Juan, nacido el 31/12".*/
		 string nombreUsuario;
		 short mesNac = 0, anyoNac = 0;
		 Console.Write("Dime tu nombre: ");
		 nombreUsuario = Console.ReadLine();
		 try
		 {
			 Console.Write("Dime tu mes nacimiento (1 al 12): ");
			 mesNac = Convert.ToInt16(Console.ReadLine());
			 Console.Write("Dime tu año de nacimiento (0 al 99): ");
			 anyoNac = Convert.ToInt16(Console.ReadLine());
		 }
		 catch( FormatException e )
		 {
			 Console.WriteLine("Error de formato" + e.Message);
		 }
		 Console.WriteLine("\""+ nombreUsuario+ ", nacido el " + mesNac+ "/"
			+anyoNac+"\"");
	 }
	 static void Ejercicio4_4_1_4()
	 {
		 /*(4.4.1.4) Crea un programa que pida al usuario dos números enteros
		  * y después una operación que realizar con ellos. La operación podrá
		  * ser "suma", "resta", multiplicación" y "división", que también se
		  * podrán escribir de forma abreviado con los operadores
		  * matemáticos "+", "-", "*" y "/". Para multiplicar también se
		  * podrá usar una "x", minúscula o mayúscula. A continuación se
		  * mostrará el resultado de esa operación (por ejemplo, si los
		  * números son 3 y 6 y la operación es "suma", el resultado sería 9).
		  * La operación debes tomarla como una cadena de texto y analizarla
		  * con un "switch".*/
		 int primerNumero = 0, segundoNumero = 0;
		 string operacion;
		 
		 try
		 {
			 Console.Write("Dime un número: ");
			 primerNumero = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Dime otro número: ");
			 segundoNumero = Convert.ToInt32(Console.ReadLine());
		 }
		 catch( FormatException e )
		 {
			 Console.WriteLine("Dato erróneo" + e.Message);
		 }
		 catch ( DivideByZeroException e)
		 {
			 Console.WriteLine("error de entrada" + e.Message);
		 }
		 catch ( Exception e )
		 {
			 Console.WriteLine("Error"+ e.Message);
		 }
		 
		 if ( segundoNumero != 0 )
		 {
			 Console.WriteLine("Elje una operación matemática: ");
			 Console.WriteLine("1. Suma");
			 Console.WriteLine("2. Resta");
			 Console.WriteLine("3. Multiplicar");
			 Console.WriteLine("4. Dividir");
			 operacion = Console.ReadLine().ToLower();
			 switch( operacion )
			 {
				 case "1": Console.WriteLine("{0} + {1} = {2}", primerNumero
					, segundoNumero, (primerNumero+segundoNumero));break;
				 case "2": Console.WriteLine("{0} + {1} = {2}", primerNumero
					, segundoNumero, (primerNumero-segundoNumero));break;
				 case "3": Console.WriteLine("{0} x {1} = {2}", primerNumero
					, segundoNumero, (primerNumero*segundoNumero));break;
				 case "4": Console.WriteLine("{0} / {1} = {2}", primerNumero
					, segundoNumero, (primerNumero/segundoNumero));break;
				 default: Console.WriteLine("Operación errónea"); break;
			 } 
		}
	 }
 }
