/* (3.3.2.1) Crea un programa que pida al usuario que teclee cuatro letras 
 * las muestre en pantalla juntas, pero en orden inverso, y entre comillas
 * dobles. Por ejemplo si las letras que se teclean son a, l, o, h
 *  ,escribiría "hola".
 * Por jonathan Sirvent Pedreño
 */
 using System;
 
 class Ej3_3_2secuenciasEscape
 {
	 static void Main()
	 {
		 char letra1,letra2,letra3,letra4;
		 
		 try
		 {
			 Console.WriteLine("Escribe 4 letras: ");
			 Console.Write("1ª letra: ");
			 letra1 = Convert.ToChar(Console.ReadLine());
			 Console.Write("2ª letra: ");
			 letra2 = Convert.ToChar(Console.ReadLine());
			 Console.Write("3 letra: ");
			 letra3 = Convert.ToChar(Console.ReadLine());
			 Console.Write("4ª letra: ");
			 letra4 = Convert.ToChar(Console.ReadLine());
			 
			 Console.WriteLine("Has escrito: ");
			 Console.WriteLine(letra1+ " "+ letra2 + " "+ letra3 +" "+ letra4);
			 Console.WriteLine("El resultado es: \"{0}{1}{2}{3}\""
				,letra4,letra3,letra2,letra1);
		 }
		 catch( Exception e )
		 {
			 Console.WriteLine("Dato erróneo" +  e.Message);
		 }
	 }
 }

