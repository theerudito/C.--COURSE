// bloqueos en threads
namespace BLOQUEOS_THEREADS
{
  class Program
  {
    static void Main(string[] args)
    {


      CuentaBancaria cuentaFamilia = new CuentaBancaria(2000);

      Thread[] Hilos_Pesonas = new Thread[10];

      for (int i = 0; i < 10; i++)
      {
        // creamos los tread
        Thread t = new Thread(cuentaFamilia.VamosRetirarEfectivo);

        // nombre del hilo
        t.Name = i.ToString();

        Hilos_Pesonas[i] = t;
      }

      for (int i = 0; i < 10; i++) Hilos_Pesonas[i].Start();

    }
  }
  class CuentaBancaria
  {

    private object bloqueoSaldoPositivo = new object();
    double saldo { set; get; }
    public CuentaBancaria(double saldo)
    {
      this.saldo = saldo;
    }
    public double RetirarEfectivo(double cantidad)
    {
      if ((saldo - cantidad) < 0)
      {
        System.Console.WriteLine($"Lo Siento queda ${saldo} Dolares en la cuenta, Hilo {Thread.CurrentThread.Name}");
        return saldo;
      }
      // bloqueamos el hilo

      lock (bloqueoSaldoPositivo)
      {
        if (saldo >= cantidad)
        {

          System.Console.WriteLine($"Retirando ${cantidad} Dolares de la cuenta, Hilo {Thread.CurrentThread.Name}");
          saldo -= cantidad;
        }
        return saldo;
      }
    }

    public void VamosRetirarEfectivo()
    {
      System.Console.WriteLine($"Estas sacando dinero, Hilo {Thread.CurrentThread.Name}");
      for (int i = 0; i < 4; i++)
      {
        RetirarEfectivo(100);
      }

    }

  }
}
