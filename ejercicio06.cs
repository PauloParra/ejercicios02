using System;


class ej06
{
  public static void Do ()
  {
    
	string entradaTeclado;
	float num1;
	float num2;
		  
	Console.WriteLine("\n[Ejercicio02.6] Pide al usuario dos numeros por consola e imprime el resultado de la resta del primero con el segundo.");
	Console.WriteLine("\nIntroduce un número : ");
	entradaTeclado = Console.ReadLine();
	num1 = float.Parse(entradaTeclado);
	Console.WriteLine("\nIntroduce otro número : ");
	entradaTeclado = Console.ReadLine();
	num2 = float.Parse(entradaTeclado);
	Console.WriteLine("\nLa variable 1 vale : " + num1);
	Console.WriteLine("\nLa variable 2 vale : " + num2);

    Console.WriteLine("\nLa resta de los números da como resultado : " + (num1-num2)); 

    Console.Write("\n***************\n");
  }
}