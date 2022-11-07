/*(1.9.1) Crea un programa que convierta una cantidad prefijada de metros (por 
ejemplo, 3000) a millas. La equivalencia es 1 milla = 1609 metros. Usa comentarios 
donde te parezca adecuado
* Por Jonathan Sirvent Pedreño
*/

public class ej1_9_1
{
    static void Main()
    {
        int milla = 1609, cantidadMetros = 3000, resultadoEnMillas;
        
        resultadoEnMillas = cantidadMetros / milla; 
        // el resultado al ser un entero perderá valor
        
        System.Console.WriteLine("{0} metros equivale a {1} millas"
            , cantidadMetros, resultadoEnMillas);
    }
}

