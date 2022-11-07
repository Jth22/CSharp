/* Ejercicios 3_2_3 Pedir números Reales
 * Por Jonathan Sirvent Pedreño
 */
 
using System;

class Ejercicios3_2_3
{
	static void Main()
	{
		string opcion;
		do
		{
			Console.WriteLine();
			Console.WriteLine("Ejercicios3_2_3 Pedir números reales.");
			Console.WriteLine("Elije una opción....");
			Console.WriteLine("1. Ejercicio 3_2_3_1");
			Console.WriteLine("2. Ejercicio 3_2_3_2");
			Console.WriteLine("3. Ejercicio 3_2_3_3");
			Console.WriteLine("4. Ejercicio 3_2_3_4");
			Console.WriteLine("5. Ejercicio 3_2_3_5");
			Console.WriteLine("6. Ejercicio 3_2_3_6");
			Console.WriteLine("7. Ejercicio 3_2_3_7");
			Console.WriteLine("0. Salir");
			opcion = Console.ReadLine();
			switch( opcion )
			{
				case "1": Ejercicio3_2_3_1(); break;
				case "2": Ejercicio3_2_3_2(); break;
				case "3": Ejercicio3_2_3_3(); break;
				case "4": Ejercicio3_2_3_4(); break;
				case "5": Ejercicio3_2_3_5(); break;
				case "6": Ejercicio3_2_3_6(); break;
				case "7": Ejercicio3_2_3_7(); break;
				case "0": break;
				default: Console.WriteLine("Opción incorrecta."); break;
			}
		}while( opcion != "0" );
	}
	public static void Ejercicio3_2_3_1()
	{
		/* (3.2.3.1) Calcula el volumen de una esfera, dado su
		 * radio, que será un número de doble precisión 
		 * (volumen = pi * radio al cubo * 4/3)*/
		double pi = 3.1416, volumen;
		float radio;
		try
		{
			Console.Write("Dime el radio? ");
			radio = Convert.ToSingle(Console.ReadLine());
		
			volumen = pi * ( radio * radio ) * 4/3;
		
			Console.WriteLine("El volumen de una esfera de radio {0} es {1}"
				, radio, volumen);
		}
		catch( FormatException e )
		{
			Console.WriteLine("Dato erróneo" + e. Message );
		}
	}
	public static void Ejercicio3_2_3_2()
	{
		/*(3.2.3.2) Crea un programa que pida al usuario a una
		 * distancia (en metros) y el tiempo necesario para
		 * recorrerla (como tres números: horas, minutos, segundos),
		 * y muestre la velocidad, en metros por segundo, en 
		 * kilómetros por hora y en millas por hora 
		 * (pista: 1 milla = 1.609 metros).*/
		int metros, horas, minutos, segundos;
		float tiempoEnHoras, tiempoEnSegundos, millas;
		try
		{
			Console.Write("Dime la distancia en metros? ");
			metros = Convert.ToInt32(Console.ReadLine());
			Console.Write("Dime el tiempo en horas? ");
			horas = Convert.ToInt32(Console.ReadLine());
			Console.Write("Dime el tiempo en minutos? ");
			minutos = Convert.ToInt32(Console.ReadLine());
			Console.Write("Dime el tiempo en segundos? ");
			segundos = Convert.ToInt32(Console.ReadLine());
			
			tiempoEnHoras = (float)((minutos/60)+(segundos/60)+horas);
			tiempoEnSegundos = (float)((horas*60)+(minutos*60)+segundos);
			millas = (float) metros/1609;
			
			Console.WriteLine("La velocidad en m/s es "
				+ (metros*tiempoEnSegundos) + " m/s");
			Console.WriteLine("La velocidad en km por hora es "
				+ ((metros*1000)*tiempoEnHoras) + " km/h");
			Console.WriteLine("La velocidad en millas por hora es "
				+ (millas*tiempoEnHoras) + " millas/horas");
		}
		catch( FormatException e )
		{
			Console.WriteLine("Formato erróneo."+e.Message);
		}
	}
	public static void Ejercicio3_2_3_3()
	{
		/* (3.2.3.3) Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2 + Bx + C. Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)*/
		float a=1, b=1, c=1, n, x1=1, x2=1;
		try
		{
			Console.WriteLine("Resolver la ecuación y = ax2 + bx + c");
			Console.WriteLine("Dame un valor para a: ");
			a = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("Dame un valor para b: ");
			b = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("Dame un valor para c: ");
			c = Convert.ToSingle(Console.ReadLine());		
			if ( ((b*b) >= (4*a*c) ) && a!=0 )
			{
				n = (float)Math.Sqrt((b*b)-(4*a*c));
				x1 = (-b - n)/(2*a);
				x2 = (-b + n)/(2/a);
			}
			Console.WriteLine("las soluciones para y = ax2 + bx + c con los" 
				+ "valores {0}, {1} y {2} es x es igual a {3} y {4}.", a, b
				,c, x1, x2);	
		}
		catch( FormatException e)
		{ 	
			Console.WriteLine("Formato erróneo." + e.Message );
		}
	}
	public static void Ejercicio3_2_3_4()
	{
		/*(3.2.3.4) Si se ingresan E euros en el banco a un cierto interés I
		 * durante N años, el dinero obtenido viene dado por la fórmula del
		 * interés compuesto: Resultado = e (1+ i)n Aplícalo para calcular en
		 * cuanto se convierten 1.000 euros al cabo de 10 años al 3%
		 * de interés anual.*/
		float dinero, interes, tiempo;
		double resultado;
		try
		{
			Console.Write("Dime el dinero a ingresar? ");
			dinero = Convert.ToSingle(Console.ReadLine());
			Console.Write("Dime el interés? ");
			interes = Convert.ToSingle(Console.ReadLine());
			Console.Write("Durante cuanto tiempo? ");
			tiempo = Convert.ToSingle(Console.ReadLine());
			
			interes /= 100;
			
			resultado = dinero * Math.Pow(( 1 + interes), tiempo);
			
			Console.WriteLine("Al final de {0} años con un {1}% de interes, "
				+ "ingresando {2} euros obtenemos {3}", tiempo, interes
				, dinero, resultado);
		}
		catch ( FormatException e )
		{
			Console.WriteLine("Dato erróneo" + e.Message);
		}
	}
	public static void Ejercicio3_2_3_5()
	{
		/* (3.2.3.5) Crea un programa que muestre los primeros 20 valores de
		 * la función y = x2 - 1 */
		 
		 double y = 0;
		 int x;
		 
		 Console.WriteLine("los primeros 20 valores de  la función y = x2-1 son: ");
		 for( x = 0 ; x < 20 ; x++ )
		 {
			 y = Math.Pow(x,2) -1;
			 Console.WriteLine("y = ({0})2 - 1 => {1}", x, y);
		 }
		 
	}
	public static void Ejercicio3_2_3_6()
	{
		/*(3.2.3.6) Crea un programa que "dibuje" la gráfica de y = (x-5)2 para 
		 * valores de x entre 1 y 10. Deberá hacerlo dibujando varios espacios
		 * en pantalla y luego un asterisco. La cantidad de espacios dependerá
		 * del valor obtenido para "y". Te será fácil si dibujas la
		 * gráfica "girada", de forma que los valores de "y" crezcan hacia
		 * la derecha, así:
					*
			*
		*
	 *
   *
     *
		*
			*
					*
							*
		*/ 
		double y;
		
		for ( int x = 1 ; x <=10 ; x++ )
		{
			y = Math.Pow((x-5), 2);
			for ( int j = 0 ; j < y ; j++ )
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
		}
	}
	public static void Ejercicio3_2_3_7()
	{
		/*(3.2.3.7) Escribe un programa que calcule una aproximación de PI
		 * mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13
		 * ... El usuario deberá indicar la cantidad de términos a utilizar,
		 * y el programa mostrará todos los resultados hasta esa cantidad de
		 * términos. Debes hacer todas las operaciones con "double". */
		 int numTerminos = 0;
		 double n1 = 0, n2 = 0, j = 1;
		 
		 do
		 {
			 try
			 {
				 Console.Write("Dime el número de términos a mostrar: ");
				 numTerminos = Convert.ToInt32(Console.ReadLine());
				 
				 for (int i=1; i <= numTerminos ; i++)
				 {
					 if ( i%2==1 )
					 {
						n1 = (n1 + (1/j));
					 }	
					 else
					 {
						n1 = (n1 - (1/j));
					 }
					 j+=2;
				 }
				 n2 = (double)n1*4;
				 Console.WriteLine("PI es igual a {0} y el valor de {1}" 
					+ " operaciones es {2}", Math.PI, numTerminos, n2);
			 }
			 catch( FormatException e)
			 {
				 Console.WriteLine("Dato erróneo." + e.Message);
			 }
		 }while( numTerminos <=0 );
	}
}
