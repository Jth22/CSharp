/* Ejercicios 3_6 Constantes y enumeraciones
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios_3_6
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_6 Constantes y enumeraciones.");
			 Console.WriteLine("Elije una opcion..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_6_1");
			 Console.WriteLine("2. Ejercicio 3_6_2");
			 opcion = Console.ReadLine();
			 switch( opcion )
			 {
				 case "0": break;
				 case "1": Ejercicio3_6_1(); break;
				 case "2": Ejercicio3_6_2(); break;
				 default: Console.WriteLine("Opción incorrecta"); break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while( opcion != "0" );
	 }
	 public static void Ejercicio3_6_1()
	 {
		 /* (3.6.1) Crea un programa que permita convertir de millas a metros.
		  * El valor necesario para la conversión debe estar almacenado en una
		  * constante. */
		  const float MILLA = 1609.34f;
		  float metrosUsuario, metrosMilla;
		  
		  try
		  {
			  Console.Write("Dime los metros a convertir en millas: ");
			  metrosUsuario = Convert.ToSingle(Console.ReadLine());
			  
			  metrosMilla = metrosUsuario / MILLA;
			  Console.WriteLine("{0} metros son {1} millas", metrosUsuario
				,metrosMilla.ToString("N5"));
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo. " + e.Message);
		  }
	  }
	 enum meses { ENERO=1, FEFRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO,
			SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE};
	 public static void Ejercicio3_6_2()
	 {
		 /*(3.6.2) Crea una enumeración para los meses del año, desde
		  * ENERO (con valor 1) hasta DICIEMBRE (con valor 12).
		  * Muestra el valor numérico correspondiente a OCTUBRE.*/	 
		 
		 Console.WriteLine("El valor númerico de Octubre es {0}",(int)meses.OCTUBRE);
	 }
 }
