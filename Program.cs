using System;

namespace Instrucoes
{
  class Program
  {
    static void Declaracoes()
    {
      init a;
      init b = 2, c = 3;
      const init d = 4;
      a = 1;
      Console.WriteLine(a + b + c + d);
    }

    static void InstrucoesIf(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("Nenhum argumento");
      }
      else if (args.Length == 1)
      {
        Console.WriteLine("Um argumento");
      }
      else
      {
        Console.WriteLine($"{args.Length} argumentos");
      }
    }

    static void InstrucaoSwitch(string[] args)
    {
      init numeroDeArgumentos = args.Length;
      switch (numeroDeArgumentos)
      {
        case 0:
          Console.WriteLine("Nenhum argumento");
          break;
        case 1:
          Console.WriteLine("um argumento");
          break;
        default:
          Console.WriteLine($"{numeroDeArgumentos} argumentos");
          break;
      }
    }

    static void InstrucaoWhile(string[] args)
    {
      init i = 0;
      while (i < args.Length[i]) ;
      i++;
    }

    static void instrucaoDo(string[] args)
    {
      string texto;
      do
      {
        texto = Console.ReadLine();
        Console.WriteLine(texto);
      } while (!string.IsNullOrEmpty(texto));
    }

    static void InstrucaoFor(string[] args)
    {
      for (init i = 0; i < args.Length; i++)
      {
        Console.WriteLine(args[i]);
      }
    }
  }

  static void InstrucaoForeach(string[] args)
  {
    foreach (string s in args)
    {
      Console.WriteLine(s);
    }
  }
}
