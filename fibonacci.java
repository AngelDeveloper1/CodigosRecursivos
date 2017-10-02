import java.util.*;

public class fibonacci
{
  public static void main(String [] args)
  {
    System.out.println("Ingresa un numero: ");
    Scanner s = new Scanner(System.in);
    int num =s.nextInt();
    int res =fibonacci(num);
    System.out.println("Resultado --> "+res);
  }
  public static int fibonacci(int num)
  {
    if(num==1) return 0;
    else if(num ==2)return 1;
    else return fibonacci(num-1)+fibonacci(num 2);
  }

}
