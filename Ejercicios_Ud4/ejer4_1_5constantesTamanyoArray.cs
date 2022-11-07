/* Ejercicios 4_1_5 Constantes y tamaño del array
 * Por jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejer4_1_5
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 4_1_5 Constatntes y tamaño del array");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio4_1_5_1");
			 Console.WriteLine("2. Ejercicio4_1_5_2");
			 Console.Write("? ");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio4_1_5_1(); break;
				 case "2": Ejercicio4_1_5_2(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa \"Intro\" para salir.");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio4_1_5_1()
	 {
		 /*(4.1.5.1) Crea un programa que contenga un array con los nombres de los meses del año. El usuario podrá elegir entre verlos en orden natural (de Enero a Diciembre) o en orden inverso (de Diciembre a Enero). Usa constantes para el valor máximo del array en ambos recorridos.*/
		 const int MAXIMO = 12;
		 string[] nombresMeses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		 string orden = " ";
		 Console.WriteLine("En qué orden quieres ver los meses? ");
		 Console.WriteLine("1. Orden natural");
		 Console.WriteLine("2. Orden inverso");
		 Console.Write("? ");
		 orden = Console.ReadLine();
		 switch( orden )
		 {
			 case "1":
				for ( int i = 0 ; i < MAXIMO ; i++ )
				{
					Console.WriteLine(nombresMeses[i]);
				}
				break;
			 case "2":
			 for ( int i = MAXIMO-1 ; i >= 0 ; i-- )
				{
					Console.WriteLine(nombresMeses[i]);
				}
				break;
			 default: Console.WriteLine("Opcion Incorrecta"); break;
		 }
	 }
	 public static void Ejercicio4_1_5_2()
	 {
		 /*(4.1.5.2) Crea una nueva versión del ejercicio 4.1.5.1, usando ".Length" en vez de una constante.*/
		 string[] nombresMeses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		 string orden = " ";
		 Console.WriteLine("En qué orden quieres ver los meses? ");
		 Console.WriteLine("1. Orden natural");
		 Console.WriteLine("2. Orden inverso");
		 Console.Write("? ");
		 orden = Console.ReadLine();
		 switch( orden )
		 {
			 case "1":
				for ( int i = 0 ; i < nombresMeses.Length ; i++ )
				{
					Console.WriteLine(nombresMeses[i]);
				}
				break;
			 case "2":
			 for ( int i = nombresMeses.Length-1 ; i >= 0 ; i-- )
				{
					Console.WriteLine(nombresMeses[i]);
				}
				break;
			 default: Console.WriteLine("Opcion Incorrecta"); break;
		 }
	 }
 }
