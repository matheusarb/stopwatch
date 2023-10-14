using System.ComponentModel;
using System.Threading;
internal class Program
{
    public char Type {get; set;} = new();
    private static void Main(string[] args)
    {
      Menu();
    }

    static void Menu() {
      System.Console.WriteLine("S = Segundo => 10s = 10 segundos");
      System.Console.WriteLine("M = Minuto => 1m = 1 minuto");
      System.Console.WriteLine("0 = Sair");
      System.Console.WriteLine("Quanto tempo deseja contar?");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 1;

      if(type == 'm')
        multiplier = 60;
      
      if(time == 0)
        // System.Console.WriteLine("Cronômetro não será iniciado");
        System.Environment.Exit(0);

      PreStart(time * multiplier);
    } 

  static void PreStart(int time){
    Console.Clear();
    System.Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Set...");
    Thread.Sleep(1000);
    System.Console.WriteLine("Go!");
    Thread.Sleep(1000);

    Start(time);
  }
    static void Start(int time, char type)
    {
      int currentTime = 0;

      while(currentTime != time){
        Console.Clear();
        currentTime++;
        System.Console.WriteLine($"O contador está no {currentTime}{type}");
        Thread.Sleep(1000);
      }

      Thread.Sleep(1000);
      Menu();
    }
}