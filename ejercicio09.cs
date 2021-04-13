using System;


class ej09
{
  public static void Do ()
  {
    
	string entradaTeclado;
	float conDecimal;
	int sinDecimal;	
	  
	Console.WriteLine("\n[Ejercicio02.9] Pedir un valor decimal por consola e imprimirlo sin decimales.");

    Console.WriteLine("\nIntroduce un número con decimales");
	entradaTeclado = Console.ReadLine();
	// Convertimos el texto introducido a float
	conDecimal = float.Parse(entradaTeclado);
	// Convertimos ese float a entero para perder los decimales
	sinDecimal = (int)conDecimal;

	Console.WriteLine("\nEl valor introducido con decimales es : " + conDecimal);
	Console.WriteLine("\nEl valor introducido sin decimales es : " + sinDecimal);

    Console.Write("\n***************\n");
  }
}