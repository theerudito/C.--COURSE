

namespace FOR_FOREACH
{
  class Program
  {
    static void Main(string[] args)
    {

      Empleados[] arrayEmpleados = new Empleados[2];
      arrayEmpleados[0] = new Empleados("Jorge", 30);
      // BUCLE FOR
      for (int i = 0; i < arrayEmpleados.Length; i++)
      {
        System.Console.WriteLine(arrayEmpleados[i].getInfor());
      }


      // Array de tipo Anonimos con Clase Anonima
      var arrayEmpleado2 = new[]
      {
        new { Nombre = "Jorge", Edad = 20 },
        new { Nombre = "Ana", Edad = 30 },
        new { Nombre = "Loor", Edad = 40 }
      };

      // BUCLE FOREACH
      foreach (var item in arrayEmpleado2)
      {
        System.Console.WriteLine(item);
      }

    }
  }
  class Empleados
  {
    // VARIABLES
    private string nombre;
    private int edad;


    // CONSTRUCTOR
    public Empleados(string nombre, int edad)
    {
      this.nombre = nombre;
      this.edad = edad;
    }

    // METODO DE ACCESO
    public string getInfor() => "Nombre: " + nombre + " Edad: " + edad;

  }
}
