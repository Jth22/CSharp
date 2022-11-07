
using System;

class MenuEnBlanco
{
    static void Main()
    {
        string opcion;
	int ejers = 1;
        do
        {
            Console.WriteLine("......");
            Console.WriteLine("Elije una opción..");
            Console.WriteLine("0. Salir");
	    for (int i = 0 ; i < ejers ; i++)
		Console.WriteLine((i+1)+". Ejercicio ...."+(i+1));
	    Console.Write("? ");
            opcion = Console.ReadLine();
            Console.WriteLine(new string('*',20));
            switch(opcion)
            {
                case "0" : break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
            Console.WriteLine();
            Console.WriteLine("Pulsa \"Intro\" para seguir");
            Console.ReadLine();
            Console.Clear();
        }while(opcion != "0");
    }
}
