using System;

class MainClass {
  public static void Main (string[] args) {
    int x;

    Console.WriteLine("Ingrese un numero a contar");

    x = int.Parse(Console.ReadLine());
    while (x <= 100){
      Console.Write(x);
      Console.Write(" - ");
      x = x+1;
    }
  }
}