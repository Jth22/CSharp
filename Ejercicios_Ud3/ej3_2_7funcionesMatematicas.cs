/* Ejercicios 3_2_7 funcionesMatemáticas
 * Por Jonathan Sirvent Pedreño
 */
using System;
 
 class Ejercicios_3_2_7
 {
	 static void Main()
	 {
		 string opcion;
		 
		 do
		 {
			 Console.WriteLine("Ejercicios 3_2_7 funciones matemáticas..");
			 Console.WriteLine("Elije una opción..");
			 Console.WriteLine("0. Salir");
			 Console.WriteLine("1. Ejercicio 3_2_7_1");
			 Console.WriteLine("2. Ejercicio 3_2_7_2");
			 Console.WriteLine("3. Ejercicio 3_2_7_3");
			 Console.WriteLine("4. Ejercicio 3_2_7_4");
			
			 opcion = Console.ReadLine();
			 
			 switch ( opcion )
			 {
				 case "1": Ejercicio3_2_7_1(); break;
				 case "2": Ejercicio3_2_7_2(); break;
				 case "3": Ejercicio3_2_7_3(); break;
				 case "4": Ejercicio3_2_7_4(); break;
				 case "0": break;
				 default: Console.WriteLine("Opcion incorrecta.");  break;
			 }
			 Console.WriteLine("Pulsa intro para continuar");
			 Console.ReadLine();
			 Console.Clear();
		 }while ( opcion != "0");
	 }
	 public static void Ejercicio3_2_7_1()
	 {
		 /*(3.2.7.1) Crea un programa que halle (y muestre) la raíz cuadrada 
		  * del número que introduzca el usuario. Se repetirá hasta que
		  * introduzca 0.*/
		  
		  int numUsuario = 0 ;
		  double raizCuadrada;
		  do
		  {
			  try
			  {
				  Console.WriteLine();
				  Console.Write("Dime un número: ");
				  numUsuario = Convert.ToInt32(Console.ReadLine());
				  if ( numUsuario != 0 )
				  {
					  raizCuadrada = Math.Sqrt(numUsuario);
					  Console.WriteLine("La raíz cuadrada de {0} es {1}."
						,numUsuario, raizCuadrada.ToString("N4"));
				  }
			  }
			  catch( FormatException e )
			  {
				  Console.WriteLine("Formato erróneo" + e.Message);
			  }
		  }while( numUsuario != 0 );
	 }
	 public static void Ejercicio3_2_7_2()
	 {
		 /*(3.2.7.2) Diseña un programa que calcule cualquier raíz
		  * (de cualquier orden) de un número. El usuario deberá indicar el
		  * número (por ejemplo, 2) y el índice de la raíz (por ejemplo,
		  * 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo
		  * mismo que elevar 2 a 1/3.*/
		  float numUsuario;
		  double raiz, exponente;
		  
		  try
		  {
			  Console.Write("Dime un número: ");
			  numUsuario = Convert.ToSingle(Console.ReadLine());
			  Console.Write("Dime el exponente: ");
			  exponente = Convert.ToDouble(Console.ReadLine());
			  raiz = (double)Math.Pow(numUsuario, (1/exponente));
			  Console.WriteLine("La raiz {0} del número {1} es {2}"
				,exponente, numUsuario, raiz.ToString("N4"));
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Formato erróneo" + e.Message);
		  }
	 }
	 public static void Ejercicio3_2_7_3()
	 {
		 /*(3.2.7.3) Crea un programa que calcule la distancia entre
		  * dos puntos (x1,y1) y (x2,y2), usando la 
		  * expresión d = raíz [ (x1-x2)2 + (y1-y2)2 ].*/
		 float x1, x2, y1, y2;
		 double distancia;
		 
		 try
		 {
			 Console.Write("Dime el valor para x1: ");
			 x1 = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Dime el valor para y1: ");
			 y1 = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Dime el valor para x2: ");
			 x2 = Convert.ToSingle(Console.ReadLine());
			 Console.Write("Dime el valor para y2: ");
			 y2 = Convert.ToSingle(Console.ReadLine());
			 
			 distancia = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
			 Console.WriteLine("La distancia entre los puntos ({0},{1}) y " 
				+ "({2},{3}) es {4}", x1,x2,y1,y2,distancia.ToString("N4"));
		 }
		 catch( FormatException e )
		 {
			 Console.WriteLine("Error de Formato. " + e.Message);
		 }
	 }
	 public static void Ejercicio3_2_7_4()
	 {
		 /*(3.2.7.4) Crea un programa que pida al usuario un ángulo (en grados)
		  * y muestre su seno, coseno y tangente. Recuerda que las funciones
		  * trigonométricas esperan que el ángulo se indique en radianes, no
		  * en grados. La equivalencia es que 180 grados = PI radianes.*/
		  float anguloUsuario;
		  double anguloRadianes;
		  
		  try
		  {
			  Console.Write("Dime un ángulo: ");
			  anguloUsuario = Convert.ToInt32(Console.ReadLine());
			  
			  anguloRadianes = (anguloUsuario * Math.PI) / 180;
			  
			  Console.WriteLine("El seno de {0} grados es {1}", anguloUsuario
				,Math.Sin(anguloRadianes).ToString("N6"));
			  Console.WriteLine("El coseno de {0} grados es {1}", anguloUsuario
				,Math.Cos(anguloRadianes).ToString("N6"));
			  Console.WriteLine("La tangente de {0} grados es {1}", anguloUsuario
				,Math.Tan(anguloRadianes).ToString("N6"));
		  }
		  catch( FormatException e )
		  {
			  Console.WriteLine("Dato erróneo" + e.Message );
		  }
	 }
 }
