/* Ejercicios 3_2_5 formatear números
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class Ejercicios_3_2_5
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_2_5 formatear números..");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_2_5_1");
			 Console.WriteLine("2. Ejercicio 3_2_5_2");
			 Console.WriteLine("3. Ejercicio 3_2_5_3");
			 Console.WriteLine("4. Ejercicio 3_2_5_4");
			 opcion = Console.ReadLine();
			 
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_2_5_1(); break;
				 case "2": Ejercicio3_2_5_2(); break;
				 case "3": Ejercicio3_2_5_3(); break;
				 case "4": Ejercicio3_2_5_4(); break;
				 case "0": break;
				 default: Console.WriteLine("Opcion incorrecta.");  break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while ( opcion != "0");
	 }
	 public static void Ejercicio3_2_5_1()
	 {
		 /*(3.2.5.1) El usuario de nuestro programa podrá teclear dos números
		  * de hasta 12 cifras significativas. El programa deberá mostrar el
		  * resultado de dividir el primer número entre el segundo, utilizando
		  * tres cifras decimales.*/
		 float primerNumero, segundoNumero, resultado;
		 try
		 {
			 Console.WriteLine("Escribe 2 números: ");
			 Console.Write("número 1: ");
			 primerNumero = Convert.ToInt64(Console.ReadLine());
			 Console.Write("número 2: ");
			 segundoNumero = Convert.ToInt64(Console.ReadLine());
			 
			 resultado = primerNumero / segundoNumero;
			 
			 Console.WriteLine("{0} / {1} = {2}", primerNumero
				,segundoNumero, resultado.ToString("N3"));
 		 }
		 catch ( FormatException e )
		 {
			 Console.WriteLine("Formato erróneo" + e. Message);
		 }
		 
	 }
	 public static void Ejercicio3_2_5_2()
	 {
		 /*(3.2.5.2) Crea un programa que use tres variables x,y,z. Las tres
		  * serán números reales, y nos bastará con datos de simple precisión.
		  * Se deberá pedir al usuario los valores para las tres variables y
		  * mostrar en pantalla el valor de x2 + y - z (con exactamente dos
		  * cifras decimales).*/
		 float x, y , z, resultado;
		 
		 try
		 {
			 Console.Write("Valor de x? ");
			 x = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Valor de y? ");
			 y = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Valor de z? ");
			 z = Convert.ToSingle(Console.ReadLine());
			 
			 resultado = (float)Math.Pow(x,2) + y - z;
			 
			 Console.WriteLine("El resultado de ({0})2 + {1} - {2} es: {3}"
				, x, y, z, resultado.ToString("#.##"));
		 }
		 catch( FormatException e)
		 {
			 Console.WriteLine("Dato erróneo"+ e.Message);
		 }
	 }
	 public static void Ejercicio3_2_5_3()
	 {
		 /*(3.2.5.3) Calcula el perímetro, área y diagonal de un rectángulo,
		  * a partir de su ancho y alto (perímetro = suma de los cuatro lados;
		  * área = base x altura; diagonal = hipotenusa, usando el teorema de
		  * Pitágoras). Muestra todos ellos con una cifra decimal.*/
		  double perimetro, area, diagonal;
		  float ancho, alto;
		  
		  try
		  {
			  Console.WriteLine("Dime el alto y al ancho..");
			  Console.Write("ancho? ");
			  ancho = Convert.ToSingle(Console.ReadLine());
			  Console.Write("alto? ");
			  alto = Convert.ToSingle(Console.ReadLine());
			  
			  perimetro = ( ancho * 2 ) + ( alto * 2 );
			  area = ancho * alto;
			  diagonal = Math.Pow(ancho,2) + Math.Pow(alto,2);
			  
			  Console.WriteLine("El perímetro de un rectangulo de "
				+ "ancho {0} y alto {1} es {2}", ancho, alto, perimetro.ToString("N1"));
			  Console.WriteLine("El área de un rectangulo de "
				+ "ancho {0} y alto {1} es {2}", ancho, alto, area.ToString("N1"));
			  Console.WriteLine("La diagonal de un rectangulo de "
				+ "ancho {0} y alto {1} es {2}", ancho, alto, diagonal.ToString("N1"));
			  
		  }
		  catch ( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo " + e.Message);
		  }
		  
	 }
	 public static void Ejercicio3_2_5_4()
	 {
		 /*(3.2.5.4) Calcula la superficie y el volumen de una esfera, a
		  * partir de su radio (superficie = 4 * pi * radio al cuadrado;
		  * volumen = 4/3 * pi * radio al cubo). Usa datos "doble" y muestra
		  * los resultados con 5 cifras decimales.*/
		  double superficie, volumen, radio;
		  
		  try
		  {
			  Console.Write("Dime el radio? ");
			  radio = Convert.ToDouble(Console.ReadLine());
			  
			  superficie = 4 * Math.PI * Math.Pow(radio, 2);
			  volumen = 4/3 * Math.PI * Math.Pow(radio, 3);
			  
			  Console.WriteLine("La superficie de una esfera de "
				+ "radio {0} es {1}", radio, superficie.ToString("N5"));
			  Console.WriteLine("El volumen de una esfera de "
				+ "radio {0} es {1}", radio, volumen.ToString("N5"));
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo" + e.Message);
		  }
	 }
 }
