namespace oem.bootcamp_decola_tech.Metodos;
{
  public class Out
  {
    static void Dividir(int x, int y, out int resultado, out int resto)
    {
      resultado = x / y;
      resto = x % y;
    }

    public static void Dividir()
    {
      Dividir(10, 3, out resultado, out resto);
      System.Console.WriteLine($"{0} {1}", resultado, resto);
    }
  }
}