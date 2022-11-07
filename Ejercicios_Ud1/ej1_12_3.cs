/* 1.12.3) Crea una variante del programa anterior, que pide al usuario un 
 * número y muestra su tabla de multiplicar. Esta vez no deberás utilizar {0}, 
 * {1}, {2}, sino "Write".
 * Por Jonathan Sirvent Pedreño
 */
  /*  (1.12.2) Pide al usuario un número y muestra su tabla de multiplicar, 
 * usando {0},{1} y {2}. Por ejemplo, si el número es el 3, debería escribirse 
 * algo como
 * 3 x 0 = 0
 * 3 x 1 = 3
 * 3 x 2 = 6
 * …
 * 3 x 10 = 30
 * Por Jonathan Sirvent Pedreño
 */
 
 using System;
 
 class ej1_12_3
 {
     static void Main()
     {
         int numeroUsuario;
         
         Console.Write("Dime un numero: ");
         numeroUsuario = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine(numeroUsuario + " * 0 = " + numeroUsuario*0);
         Console.WriteLine(numeroUsuario + " * 1 = " + numeroUsuario*1);
         Console.WriteLine(numeroUsuario + " * 2 = " + numeroUsuario*2);
         Console.WriteLine(numeroUsuario + " * 3 = " + numeroUsuario*3);
         Console.WriteLine(numeroUsuario + " * 4 = " + numeroUsuario*4);
         Console.WriteLine(numeroUsuario + " * 5 = " + numeroUsuario*5);
         Console.WriteLine(numeroUsuario + " * 6 = " + numeroUsuario*6);
         Console.WriteLine(numeroUsuario + " * 7 = " + numeroUsuario*7);
         Console.WriteLine(numeroUsuario + " * 8 = " + numeroUsuario*8);
         Console.WriteLine(numeroUsuario + " * 9 = " + numeroUsuario*9);
         Console.WriteLine(numeroUsuario + " * 10 = " + numeroUsuario*10);
        
     }
 }
 
