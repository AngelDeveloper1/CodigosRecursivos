using System;
class potencia
{
  public static void Main(string[] args)
  {
    int num,pot,res;
    Console.Write("Escriba numero: ");
    num=int.Parse(Console.ReadLine());
    Console.Write("Escriba potencia: ");
    pot=int.Parse(Console.ReadLine());
    res=Potencia(num,pot);
    Console.Write("La Potencia de {0} elevada a {1} es: {2}",num,pot,res);
  }

  static int Potencia( int num, int pot)
   {
    if(pot == 0)return 1;
    else
      return num * Potencia(num, pot -1);
  }
}
