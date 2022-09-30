// bloqueos en threads
namespace BLOQUEOS_THEREADS
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("'Hello World!'");
    }
  }
  class CuentaBancaria
  {

    double saldo { set; get; }
    public CuentaBancaria(double saldo)
    {
      this.saldo = saldo;
    }
    public double RetirarEfectivo(double cantidad)
    {
      if ((cantidad - saldo) < 0)
      {
        System.Console.WriteLine($"Lo Siento queda ${saldo} Dolares en la cuenta ");
        return saldo;
      }
      if (saldo => cantidad)
      {

        System.Console.WriteLine($"Retiro ${0} y queda {1} en la cuenta ", cantidad, (saldo - cantidad));
        saldo -= cantidad;
      }
      return saldo;
    }
  }
}
