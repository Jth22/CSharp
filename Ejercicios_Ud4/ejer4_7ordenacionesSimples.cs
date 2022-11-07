/* Ejercicios 4.7. Ordenaciones simples
 * Por Jonathan Sirvent Pedreño
 */
 
using System; 

class Ejercicios4_7
{
	static void Main()
	{
		string opcion;
		
		do
		{
			Console.WriteLine("Ejercicios 4.7. Ordenaciones simples");
			Console.WriteLine("Elije una opción..");
			Console.WriteLine("0. Salir");
			Console.WriteLine("1. Ejrcicio 4_7_1");
			Console.WriteLine("2. Ejrcicio 4_7_2");
			Console.WriteLine("3. Ejrcicio 4_7_3");
			Console.WriteLine("4. Ejrcicio 4_7_4");
			Console.WriteLine("5. Ejrcicio 4_7_5");
			Console.WriteLine("6. Ejrcicio 4_7_6");
			Console.Write("? ");
			opcion = Console.ReadLine();
			Console.WriteLine(new string('*', 20));
			switch(opcion)
			{
				case "0": break;
				case "1": Ejercicios4_7_1(); break;
				case "2": Ejercicios4_7_2(); break;
				case "3": Ejercicios4_7_3(); break;
				case "4": Ejercicios4_7_4(); break;
				case "5": Ejercicios4_7_5(); break;
				case "6": Ejercicios4_7_6(); break;
				default: Console.WriteLine("Opción incorrecta!"); break;
			}
			Console.WriteLine();
			Console.WriteLine("Pulsa \"Intro\" para seguir..");
			Console.ReadLine();
			Console.Clear();
		}while( opcion != "0" );
	}
	static void Ejercicios4_7_1()
	{
		/*((4.7.1) Un programa que pida al usuario 6 números en coma flotante
		 * y los muestre ordenados de menor a mayor. Escoge el método de
		 * ordenación que prefieras.*/
		 const int CAPACIDAD = 6;
		 float[] numeros = new float[CAPACIDAD];
		 
		 Console.WriteLine("Dime 6 números..");
		 try
		 {
			 for (int i = 0 ; i < CAPACIDAD ; i++)
			 {
				Console.Write("Número "+(i+1)+": ");
				numeros[i] = Convert.ToSingle(Console.ReadLine());
			 }
		 }
		 catch(FormatException e)
		 {
			 Console.WriteLine("Formato erróneo"+e.Message);
		 }
		 Console.WriteLine("El array ordenado es: ");
		 for (int i = 0 ; i < numeros.Length-1 ; i++)
		 {
			 for (int j = i+1 ; j < numeros.Length ; j++)
			 {
				 if (numeros[i] > numeros[j])
				 {
					float aux = numeros[i];
					numeros[i] = numeros[j];
					numeros[j] = aux;
				 }
			 }
		 }
		 foreach (float dato in numeros)
			Console.Write(dato+" ");
	}
	static void Ejercicios4_7_2()
	{
		/*4.7.2) Un programa que pida al usuario 5 nombres y los muestre
		 * ordenados alfabéticamente (recuerda que para comparar cadenas no
		 * podrás usar el símbolo ">", sino "CompareTo").*/ 
		 const int CAPACIDAD = 5;
		 string[] nombres = new string[CAPACIDAD];
		 
		 Console.WriteLine("Escribe {0} nombres..", CAPACIDAD);
		 for (int i = 0 ; i < nombres.Length ; i++)
		 {
			 Console.Write("Nombre "+(i+1)+": ");
			 nombres[i] = Console.ReadLine().ToLower();
		 }
		 for (int i = 0; i< nombres.Length-1 ; i++)
		 {
			 for (int j = i+1 ; j < nombres.Length ; j++)
			 {
				 if (nombres[i].CompareTo(nombres[j])> 0)
				 {
					 string aux = nombres[i];
					 nombres[i] = nombres[j];
					 nombres[j] = aux;
				 }
			 }
		 }
		 foreach(string dato in nombres)
		 {
			 Console.Write(dato+ " ");
		 }
	}
	static void Ejercicios4_7_3()
	{
		/*(4.7.3) Un programa que pida al usuario varios números, los vaya
		 * añadiendo a un array, mantenga el array ordenado continuamente y
		 * muestre el contenido tras añadir cada nuevo dato (todos los datos
		 * se mostrarán en la misma línea, separados por espacios en blanco).
		 * Terminará cuando el usuario teclee "fin" en vez de un numero.*/
		const int CAPACIDAD = 6;
		int[] numeros = new int[CAPACIDAD];
		int cantidad = 0;
		string numeroUsuario;
		do
		{
			Console.Write("Dime un número: ");
			numeroUsuario = Console.ReadLine();
			if (numeroUsuario != "fin" )
			{
				numeros[cantidad] = Convert.ToInt32(numeroUsuario);
				cantidad++;
			}
			if (cantidad >= 2)
			{
				for (int i = 0; i < cantidad -1 ; i++)
				{
					for (int j = i+1 ; j < cantidad ; j++)
					{
						if (numeros[i] > numeros[j])
						{
							int aux = numeros[i];
							numeros[i] = numeros[j];
							numeros[j] = aux;
						}
					}
				}
			}	
			for(int i = 0 ; i <= cantidad-1 ; i++)
			{
				Console.Write(numeros[i]+ " ");
			}
			Console.WriteLine();
		 }while(numeroUsuario != "fin" && cantidad < CAPACIDAD);
	}
	static void Ejercicios4_7_4()
	{
		/*(4.7.4) Amplía el ejercicio anterior, para añadir una segunda fase
		 * en la que el usuario pueda "preguntar" si un cierto valor está en
		 * el array. Como el array está ordenado, la búsqueda no se hará hasta
		 * el final de los datos, sino hasta que se encuentre el dato buscado
		 * o un dato mayor que él.
		 *(4.7.3) Un programa que pida al usuario varios números, los vaya
		 * añadiendo a un array, mantenga el array ordenado continuamente y
		 * muestre el contenido tras añadir cada nuevo dato (todos los datos
		 * se mostrarán en la misma línea, separados por espacios en blanco).
		 * Terminará cuando el usuario teclee "fin" en vez de un numero.*/
		 const int CAPACIDAD = 5;
		 int[] numeros = new int[CAPACIDAD];
		 int cantidad = 0, datoABuscar = 0;
		 string numeroUsuario;
		 bool encontrado;
		 do
		 {
			Console.Write("Dime un número: ");
			numeroUsuario = Console.ReadLine();
			if (numeroUsuario != "fin" )
			{
				numeros[cantidad] = Convert.ToInt32(numeroUsuario);
				cantidad++;
			}
			if (cantidad >= 2)
			{
				for (int i = 0; i < cantidad -1 ; i++)
				{
					for (int j = i+1 ; j < cantidad ; j++)
					{
						if (numeros[i] > numeros[j])
						{
							int aux = numeros[i];
							numeros[i] = numeros[j];
							numeros[j] = aux;
						}
					}
				}
			}
			for(int i = 0 ; i <= cantidad-1 ; i++)
			{
				Console.Write(numeros[i]+ " ");
			}
			try
			{
				Console.Write("Dato a buscar ");
				datoABuscar = Convert.ToInt32(Console.ReadLine());
			}
			catch(FormatException e)
			{
				Console.WriteLine("Formato erróneo"+e.Message);
			}
			encontrado = false;
			for (int i = 0 ; i < numeros.Length ; i++)
			{
				if (datoABuscar >= numeros[i])
				{
					encontrado = true;
				}
			}
			if (encontrado)
			{
				Console.WriteLine("El dato {0} si está o uno superior",datoABuscar);
			}
			else
			{
				Console.WriteLine("El dato {0} no está", datoABuscar);
			}
			Console.WriteLine();
		 }while(numeroUsuario != "fin" && cantidad < CAPACIDAD); 
	} 
	static void Ejercicios4_7_5()
	{
		/*(4.7.5) Realiza una variante del ejercicio 4.7.4, que en vez de
		 * hacer una búsqueda lineal (desde el principio), 
		 * use "búsqueda binaria": se comenzará a comparar con el punto medio
		 * del array; si nuestro dato es menor, se vuelve a probar en el punto
		 * medio de la mitad inferior del array, y así sucesivamente.*/
		 const int CAPACIDAD = 10;
		 int cantidad = 0;
		 string datoUsuario;
		 int[] nums = new int[CAPACIDAD];
		 int numeroABuscar;
		 Console.WriteLine("Dime un número: (Escribe \"fin\" para salir)");
		 do
		 {
			 Console.Write("Nùmero: ");
			 datoUsuario = Console.ReadLine();
			 
			 if (datoUsuario != "fin" && cantidad < CAPACIDAD)
			 {
				 nums[cantidad] = Convert.ToInt32(datoUsuario);
				 cantidad++;
			 }
		 }while (datoUsuario != "fin" && cantidad < CAPACIDAD);
		 for (int i = 0 ; i < nums.Length-1 ; i++)
		 {
			 for (int j = i+1 ; j < nums.Length ; j++)
			 {
				 if (nums[i] > nums[j])
				 {
					 int aux = nums[i];
					 nums[i] = nums[j];
					 nums[j] = aux;
				 }
			 }
		 }
		 Console.WriteLine("Dime un número a buscar: ");
		 numeroABuscar = Convert.ToInt32(Console.ReadLine());
		 int limiteInferior = nums[0];
		 int limiteSuperior = nums[nums.Length-1];
		 bool encontrado = false;
		 int aBuscar= 0;
		 
		 while (!encontrado)
		 {
			 aBuscar = (limiteInferior+limiteSuperior)/2;
			 
			 if (nums[aBuscar] > numeroABuscar)
				limiteSuperior = aBuscar -1;
			 else if (nums[aBuscar] < numeroABuscar)
			 	limiteInferior = aBuscar +1;
			 else
				encontrado = true;
		 }		 
		 if (encontrado)
			Console.WriteLine("Encontrado en posición"+ aBuscar);
		 else
			Console.WriteLine("No encontrado");
	}
	static void Ejercicios4_7_6()
	{
		/*((4.7.6) Crea una variante del ejercicio 4.7.3, pero usando esta
		 * vez Array.Sort para ordenar: un programa que pida al usuario varios
		 * números, los vaya añadiendo a un array, mantenga el array ordenado
		 * continuamente y muestre el resultado tras añadir cada nuevo
		 * dato (todos los datos se mostrarán en la misma línea, separados por
		 * espacios en blanco). Terminará cuando el usuario teclee "fin".*/
		 const int CAPACIDAD = 6;
		int[] numeros = new int[CAPACIDAD];
		int cantidad = 0;
		string numeroUsuario;
		do
		{
			Console.Write("Dime un número: ");
			numeroUsuario = Console.ReadLine();
			if (numeroUsuario != "fin" )
			{
				numeros[cantidad] = Convert.ToInt32(numeroUsuario);
				cantidad++;
			}
			Console.WriteLine();
		 }while(numeroUsuario != "fin" && cantidad < CAPACIDAD);
		 Array.Sort(numeros);	
		for(int i = 0 ; i < cantidad ; i++)
		{
			Console.Write(numeros[i]+ " ");
		}
	}
}

