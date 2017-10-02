using System;

class factorial
{
    public static void Main(string []args)
    {
      int resultado,num;
      Console.WriteLine("Ingrese el numero para factorial: ");
      num=int.Parse(Console.ReadLine());
      resultado = Factorial(num);
      Console.WriteLine("El factorial del numero es:{0}",resultado);
    }
    static int Factorial(int n)
    {
      if(n<1)
      return 1;
      return n*Factorial(n-1);
    }

}
