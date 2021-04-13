using System;


class ej08
{
  public static void Do ()
  {
    string entradaTeclado;

	char letra;

	int valorMinuscula;
		  
	Console.WriteLine("\n[Ejercicio02.8] Dada una letra mayuscula imprimir por consola la minúscula.");
	// Leemos el texto introducido
	Console.WriteLine("\nIntroduce un texto : ");
	entradaTeclado =  Console.ReadLine();
	// Convertimos el texto introducido a letra
	letra = char.Parse(entradaTeclado) ;
	Console.WriteLine("\nLa letra en mayuscula es : " + letra);
	// Sumamos al valor del caracter 32 para obtener la letra minúscula
	valorMinuscula = letra + 32;
	// Convertimos el valor obtenido de nuevo a caracter
	letra = (char)valorMinuscula; 
	

    Console.WriteLine("\nEl carácter convertido a minúscula es " + letra); 

    Console.Write("\n***************\n");
  }
}