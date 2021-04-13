using System;


class ej10
{
  public static void Do ()
  {
    
	string entradaTeclado;
	float conDecimal;
	int sinDecimal;	
	  
	Console.WriteLine("\n[Ejercicio02.10] Pedir un valor decimal por consola e imprimirlo redondeado al entero.");

    Console.WriteLine("\nIntroduce un número con decimales");
	entradaTeclado = Console.ReadLine();
	// Convertimos el texto introducido a float
	conDecimal = float.Parse(entradaTeclado);
	// Redondeamos el valor
	conDecimal = conDecimal + 0.5f;
	// Convertimos ese float a entero para perder los decimales
	sinDecimal = (int)conDecimal;

	Console.WriteLine("\nEl valor introducido con decimales es : " + conDecimal);
	Console.WriteLine("\nEl valor introducido sin decimales es : " + sinDecimal);

    Console.Write("\n***************\n");
  }
}