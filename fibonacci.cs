using System;
namespace fibbo
{
  public class Fibbo
  {
      public static void Main(string[] args)
      {
        int n,r;
        Console.WriteLine("Ingrese indice para numero fibonacci: ");
        n= int.Parse(Console.ReadLine());
        r=Fibo(n);
        Console.WriteLine(r);
      }
      static int Fibo(int num)
      {
        if(num==1) return 0;
        else if(num==2) return 1;
        else return Fibo(num-1)+Fibo(num-2);
   
      }
  }

}
