using System;


class ej07
{
  public static void Do ()
  {
    string entradaTeclado;
	int num1;
		  
	Console.WriteLine("\n[Ejercicio02.7] Pide al usuario un número por consola e imprime el carácter asignado a ese número.");
	Console.WriteLine("\nIntroduce un número : ");
	entradaTeclado =  Console.ReadLine();

	num1 = int.Parse(entradaTeclado) ;

	char caracter = (char)num1;
	
	Console.WriteLine("\nLa variable 1 vale : " + num1);

    Console.WriteLine("\nEl carácter asignado a " + num1 + " es " + caracter); 

    Console.Write("\n***************\n");
  }
}