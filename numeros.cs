using System;

class numero
{

	public static void Main(string[] args)
	{
		Pdatos();
	}

	static void Pdatos()
	{
		int num;
		Console.Write("Ingrese un numero: ");
		num = int.Parse(Console.ReadLine());
		imprimir(num);
		Console.ReadKey();
	}

	static void imprimir(int x)
	{
		if(x > 0)
		{
			Console.WriteLine(x);
			imprimir(x-1);
		}	
	}
	
}