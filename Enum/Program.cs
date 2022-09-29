// LOS ENUM  SON TIPOS DE ENUMERADOS
// son un conjunto de constante con nombre
// syntax enum nombre {lista de constantes}
// para que sirve un enum para represantar valores fijos constantes
namespace ENUM
{
  // los enum se declaran casi siempre en un namespace
  // son constante no van entre comillas
  enum Estaciones { Primavera, Verano, Otoño, Invierno }
  enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 2000 }
  class Program
  {
    static void Main(string[] args)
    {
      // EJEMPLO 1
      // para declarar una variable de tipo enum
      Estaciones estacion = Estaciones.Primavera;
      System.Console.WriteLine(estacion);

      // no confundir con el tipo de dato Ejemplo
      String estacion2 = estacion.ToString();
      System.Console.WriteLine(estacion2);

      // como guardar un dato tipo null en un enum
      Estaciones? estacion3 = null;
      System.Console.WriteLine(estacion3);

      // EJEMPLO 2
      Bonus Jorge = Bonus.bueno;
      double bonusJorge = (double)Jorge;
      double salarioJorge = 1000 + bonusJorge;
      System.Console.WriteLine(salarioJorge);

      // EJEMPLO 3
      Empleados Erudito = new Empleados(Bonus.extra, 1000);
      System.Console.WriteLine("El salario del empleado es " + Erudito.getSalario());

    }
  }
  class Empleados
  {
    // variables
    private double salario;
    private Bonus bonusEmpleado;
    // constructor que recibe el enum
    public Empleados(Bonus bonusEmpleado, double salario)
    {
      this.bonusEmpleado = bonusEmpleado;
      this.salario = salario;
    }
    // metodos get
    public double getSalario() => salario + (double)bonusEmpleado;
  }
}
