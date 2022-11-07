/* Ejercicios 3_4 Toma contacto con las cadenas de texto
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios_3_4
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_4 cadena de textos.");
			 Console.WriteLine("Elije una opcion..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_4_1");
			 Console.WriteLine("2. Ejercicio 3_4_2");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio3_4_1(); break;
				 case "2": Ejercicio3_4_2(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio3_4_1()
	 {
		 /*(3.4.1) Crea un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Juan", o bien le diga "No te conozco" si teclea otro nombre.*/ 
		 string nombreUsuario;
		 
		 Console.Write("Dime tu nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
	 if ( nombreUsuario == "Juan" )
		Console.WriteLine("Hola {0}!", nombreUsuario);
	 else
		Console.WriteLine("No te conozco {0}", nombreUsuario);
	 }
	 public static void Ejercicio3_4_2()
	 {
		 /*(3.4.2) Crea un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como sea necesario hasta que coincidan.*/
		 string nombreUsuario, password1, password2;
		 
		 Console.Write("Dime tu nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
		 do
		 {
			 Console.Write("Dime la contraseña: ");
			 password1 = Console.ReadLine();
			 Console.Write("Repite la contraseña: ");
			 password2 = Console.ReadLine();
			 
			 if ( password1 != password2 )
			 {
				 Console.WriteLine("{0}, las contraseñas no son iguales!", nombreUsuario);
			 }
		 }while( password1 != password2 );
		 Console.WriteLine("Correcto!");
	 }
 }
