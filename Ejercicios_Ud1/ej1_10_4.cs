/* (1.10.4) Pide al usuario una cantidad de "millas náuticas" y muestra 
 * la equivalencia en metros, usando: 1 milla náutica = 1852 metros.
 * Por Jonathan Sirvent Pedreño
 */
 
 public class ej1_10_4
 {
     static void Main()
     {
         const int MILLA = 1852;
         int cantidadMillas, conversionaAMetros;
         
         System.Console.Write("Dime un numero de millas: ");
         cantidadMillas = System.Convert.ToInt32(System.Console.ReadLine());
         
         conversionaAMetros = MILLA * cantidadMillas;
         
         System.Console.WriteLine("{0} millas nauticas son {1} metros"
            , cantidadMillas, conversionaAMetros);    
     }
 }
