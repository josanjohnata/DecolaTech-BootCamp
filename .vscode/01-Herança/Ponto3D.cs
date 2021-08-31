namespace DigitalInnovationOne.Herança
{
  public class Ponto3D : Ponto
  {
    public int z;
    public Ponto3D(int x, int y, int z) : base(x, y)
    {
      this.z = z;
      CalcularDistancia();
    }

    public static void Calcular()
    {

    }

    public override void CalcularDistancia3(){
      
    }
  }
}