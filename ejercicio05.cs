using System;


class ej05
{
  public static void Do ()
  {
    
	float num1 = 2.4f;
	float num2 = 5f;
	float num3 = 8.8f;
	float suma = num1 + num2;
	float resultado = (num1 + num2) / num3;
	  
	Console.WriteLine("\n[Ejercicio02.5] Declara 3 variables de tipo numerico, asignales un valor e imprime la suma de las 2 primeras dividido por la tercera.");
	Console.WriteLine("\nLa variable 1 vale : " + num1);
	Console.WriteLine("\nLa variable 2 vale : " + num2);
	Console.WriteLine("\nLa variable 3 vale : " + num3);

    Console.WriteLine("\nLa suma de las dos primeras variables da como resultado : " + suma + " y la division por la tercera es : " + resultado);

    Console.Write("\n***************\n");
  }
}