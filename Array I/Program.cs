// ARRAYS
// SYNTAX - type[] arrayName = new type[size];
namespace Array
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare an array of integers example 1
      int[] numbers = new int[5];
      numbers = new int[] { 1, 2, 3, 4, 5 };
      int length = numbers.Length;
      Console.WriteLine("Length of the array is: " + length);
      int a = numbers.Min();
      Console.WriteLine("Max value of the array is: " + a);
      Console.WriteLine(numbers);

      // Declare an array of integers example 2
      int[] numbers2 = { 1, 2, 3, 4, 5 };
      System.Console.WriteLine(numbers2[0]);

      // USAREMOS FOREACH PARA RECORRER EL ARRAY
      foreach (int i in numbers2)
      {
        System.Console.WriteLine(i);
      }
      // USAREMOS FOR PARA RECORRER EL ARRAY
      for (int i = 0; i < numbers2.Length; i++)
      {
        System.Console.WriteLine(numbers2[i]);
      }

      // EJEMPLO 3
      int[] par = { };
      int[] inpar = { };
      for (int i = 0; i < numbers2.Length; i++)
      {
        if (numbers2[i] % 2 == 0)
        {
          System.Console.WriteLine(numbers2[i] + " es par");
        }
        else
        {
          System.Console.WriteLine(numbers2[i] + " es inpar");
        }
      }

      // Array implicito - no se declara el tamaño
      var array = new[] { "Jorge", "Loor", "30" };
      System.Console.WriteLine(array[2]);

      // Array tenemos int y double pero lo hace double
      var valores = new[] { 1, 2, 2.5 };
      for (int i = 0; i < valores.Length; i++)
      {
        System.Console.WriteLine("Resultado " + valores[i]);
      }


      // Array de objetos
      Empleados[] arrayEmpleados = new Empleados[2];
      arrayEmpleados[0] = new Empleados("Jorge", 30);
      Empleados Ana = new Empleados("Ana", 30);
      arrayEmpleados[1] = Ana;


      // Array de tipo Anonimos con Clase Anonima
      var arrayEmpleado2 = new[]
      {
        new { Nombre = "Jorge", Edad = 20 },
        new { Nombre = "Ana", Edad = 30 },
        new { Nombre = "Loor", Edad = 40 }
      };
      System.Console.WriteLine(arrayEmpleado2[0]);

      // BUCLE FOR
      for (int i = 0; i < arrayEmpleado2.Length; i++)
      {
        System.Console.WriteLine(arrayEmpleado2[i]);
      }
      // BUCLE FOREACH
      foreach (var item in arrayEmpleados)
      {
        System.Console.WriteLine(item.getInfor());
      }
    }
  }
  class Empleados
  {
    // EL CONSTRUCTOR
    public Empleados(string nombre, int edad)
    {
      this.nombre = nombre;
      this.edad = edad;
    }

    // METODO DE ACCESO
    public string getInfor() => "Nombre: " + nombre + " Edad: " + edad;

    // VARIABLES PRIVADAS
    private string nombre;
    private int edad;

  }
}