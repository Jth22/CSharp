/* (3.1.1.1) Calcula el producto de 1.000.000 por 1.000.000, usando una
 * variable llamada "producto", de tipo "long". Prueba también a calcularlo
 * usando una variable de tipo "int".
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej3_1_1_1
 {
	 static void Main()
	 {
		 long producto = 1000000;
		 int producto2 = 1000000;
		 
		 Console.Write("El producto de 1.000.000 por 1.000.000 ");
		 Console.WriteLine (" con variable \"long\" es: {0} "
			, producto*producto);
		 Console.Write("El producto de 1.000.000 por 1.000.000 ");
		 Console.WriteLine (" con variable \"int\" es: {0} "
			, producto2*producto2); 
	 }
 }
