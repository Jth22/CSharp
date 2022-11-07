/* Ejercicios 3_3_1 leer y mostrar caracteres
 * Por Jonathan Sirvent Pedreño
 */
using System;
 
 class Ejercicios_3_3_1
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_3_1 Leer y mostrar caracteres");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_3_1_1");
			 Console.WriteLine("2. Ejercicio 3_3_1_2");
			 Console.WriteLine("3. Ejercicio 3_3_1_3");
			 opcion = Console.ReadLine();
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_3_1_1(); break;
				 case "2": Ejercicio3_3_1_2(); break;
				 case "3": Ejercicio3_3_1_3(); break;
				 case "0": break;
				 default: Console.WriteLine("Opcion incorrecta.");  break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while ( opcion != "0");
	 }
	 public static void Ejercicio3_3_1_1()
	 {
		 /*(3.3.1.1) Crea un programa que pida una letra al usuario y diga si se trata de una vocal.*/
		 char letra;
		 
		 do
		 {
			 Console.Write("Escribe una letra..");
			 letra = Convert.ToChar(Console.ReadLine());
			 
			 if ( letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' )
			 {
				 Console.WriteLine("La letra {0} es una vocal", letra);
			 }
			 else
			 {
				 Console.WriteLine("La letra {0} no es una vocal.", letra);
			 }
		 }while(!( letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ));
	 }
	 public static void Ejercicio3_3_1_2()
	 {
		 /*(3.3.1.2) Crea un programa que muestre letras alternas (una sí y una no) entre la que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se escribirá "aceg...".*/
		 char letra;
		 
		 try
		 {
			 Console.Write("Dime una letra: ");
			 letra = Convert.ToChar(Console.ReadLine());
			 
			 for ( ; letra <='z' ; letra++ )
			 {
				 Console.Write(letra + " ");
				 letra++;
			 }
			 Console.WriteLine();
		 }
		 catch( Exception e )
		 {
			 Console.WriteLine("Dato Erróneo" + e.Message);
		 }
	 }
	 public static void Ejercicio3_3_1_3()
	 {
		 /* (3.3.1.3) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto (por ejemplo, 3) y una letra (por ejemplo, X) y escriba un rectángulo formado por esa cantidad de letras:
			XXXX
			XXXX
			XXXX
		 */
		 
		 int ancho, alto;
		 char letraUsuario;
		 try
		 {
			 Console.Write("Dime el ancho: ");
			 ancho = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Dime el alto: ");
			 alto = Convert.ToInt32(Console.ReadLine());
			 Console.Write("Dime una caracter: ");
			 letraUsuario = Convert.ToChar(Console.ReadLine());
			 
			 for ( int i = 0 ; i < ancho ; i++ )
			 {
				 for ( int j = 0 ; j < alto ; j++ )
				 {
					 Console.Write(letraUsuario);
				 }
				 Console.WriteLine();
			 }
		 }
		 catch( FormatException e)
		 {
			 Console.WriteLine("Formato erróneo" + e.Message);
		 }
		 catch( Exception e  )
		 {
			 Console.WriteLine("Dato no correcto" + e.Message);
		 }
	 }
 }

