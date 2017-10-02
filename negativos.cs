using System;

class Negar
{

	public static void Main(string [] args)
	{
		Console.Write("Ingrese un numero para saber cadena de negativos: ");
		int z=int.Parse(Console.ReadLine());
		negativo(z);
		Console.ReadKey();
	}

	static void negativo(int a)
	{
		if(a>0)
		{
			 Console.WriteLine("el negativo de {0} es {1}",a,(a*-1));
			negativo(a-1);
		}
	}
}