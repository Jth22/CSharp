/* Ejercicios 3_2_6 cambiosDeBase
 * Por Jonathan Sirvent Pedreño
 */
using System;
 
 class Ejercicios_3_2_6
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_2_6 cambios de base..");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_2_6_1");
			 Console.WriteLine("2. Ejercicio 3_2_6_2");
			 Console.WriteLine("3. Ejercicio 3_2_6_3");
			 Console.WriteLine("4. Ejercicio 3_2_6_4");
			 opcion = Console.ReadLine();
			 
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_2_6_1(); break;
				 case "2": Ejercicio3_2_6_2(); break;
				 case "3": Ejercicio3_2_6_3(); break;
				 case "4": Ejercicio3_2_6_4(); break;
				 case "0": break;
				 default: Console.WriteLine("Opcion incorrecta.");  break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while ( opcion != "0");
	 }
	 
	 public static void Ejercicio3_2_6_1()
	 {
		 /*(3.2.6.1) Crea un programa que pida números (en base 10) al usuario
		  * y muestre su equivalente en sistema binario y en hexadecimal.
		  * Debe repetirse hasta que el usuario introduzca el número 0.*/
		 int numUsuario = 1;
		 
		 do
		 {
			 try
			 {
					 Console.Write("Dime un número: ");
					 numUsuario = Convert.ToInt32(Console.ReadLine());
					 
				 if ( numUsuario != 0 )
				 {
					 Console.Write("El número {0} en binario es: ", numUsuario);
					 Console.WriteLine(Convert.ToString( numUsuario,2 ));
					 Console.Write("El número {0} en hexadecimal es: ", numUsuario);
					 Console.WriteLine( Convert.ToString( numUsuario,16 ));
				 }
			 }
			 catch( FormatException e )
			 {
				 Console.WriteLine("Dato erróneo" + e.Message );
			 }
		 }while( numUsuario != 0 );
	 }
	 
	 public static void Ejercicio3_2_6_2()
	 {
		 /*(3.2.6.2) Crea un programa que pida al usuario la cantidad de rojo
		  * (por ejemplo, 255), verde (por ejemplo, 160) y azul (por ejemplo, 0)
		  * que tiene un color, y que muestre ese color RGB en notación
		  * hexadecimal (por ejemplo, FFA000).*/
		  int rojo, verde, azul;
		  
		  try
		  {
			  Console.Write("Dime cuanto rojo quieres de 0 a 255: ");
			  rojo = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Dime cuanto verde quieres de 0 a 255: ");
			  verde = Convert.ToInt32(Console.ReadLine());
			  Console.Write("Dime cuanto azul quieres de 0 a 255: ");
			  azul = Convert.ToInt32(Console.ReadLine());
			  
			  Console.WriteLine("El color que me has pedido en hexadecimal es "
				+ Convert.ToString(rojo,16) + Convert.ToString(verde,16) 
				+ Convert.ToString(azul,16));
		  
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Formato erróneo" + e.Message);
		  }
	 }
	 public static void Ejercicio3_2_6_3()
	 {
		 /*(3.2.6.3) Crea un programa para mostrar los números del 0 a 255 en
		  * hexadecimal, en 16 filas de 16 columnas cada una (la primera fila
		  * contendrá los números del 0 al 15 –decimal-, la segunda del
		  * 16 al 31 –decimal- y así sucesivamente).*/
		  int num = 0;
		  for ( int i = 0 ; i < 16 ; i++ )
		  {
			  for ( int j = 0 ; j < 16 ; j ++ )
			  {
				  Console.Write(Convert.ToString(num,16));
				  num++;
			  }
			  Console.WriteLine();
		  }
	 }
	 public static void Ejercicio3_2_6_4()
	 {
		 /*(3.2.6.4) Crea un programa que pida números binarios al usuario y
		  * muestre su equivalente en sistema hexadecimal y en decimal. Debe
		  * repetirse hasta que el usuario introduzca la palabra "fin".*/
		  string numUsuario = "";
		  int dato;
		  do
		  {
			  try
			  {
				  Console.Write("Escribe un número binario" 
					+ " ( Pulsa \"fin\" para terminar): ");
				  numUsuario = Console.ReadLine();
				  if ( numUsuario != "fin" )
				  {
					  dato = Convert.ToInt32(numUsuario,2);
					  Console.WriteLine("El valor de {0} en hexadecimal es {1}"
						,numUsuario,  Convert.ToString(dato,16));
					  Console.WriteLine("El valor de {0} en decimal es {1}"
						,numUsuario, Convert.ToString(dato,10));
				  }
				  Console.WriteLine();
			  }
			  catch(FormatException e)
			  {
				  Console.WriteLine("Error. " + e.Message);
			  }
		  }while( numUsuario != "fin" );
	 }
 }
