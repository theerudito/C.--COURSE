// Array como parametro de um metodo -> 
// Array como devolucion de un metodo return -> devuelva un array
// los array son referencias de objetos


namespace Array2
{
  class Program
  {
    static void Main(string[] args)
    {

      // crear un array de tipo int
      int[] numeros = new int[4];
      // asignar valores
      numeros[0] = 1;
      numeros[1] = 2;
      numeros[2] = 3;
      numeros[3] = 4;

      // llamada al metodo y le pasamos el array
      ProcesarDatos(numeros);
      foreach (var item in numeros)
      {
        System.Console.WriteLine(item);
      }



      // llamada al metodo y le pasamos el array
      int[] numeros2 = DevolverArray();
      System.Console.WriteLine("Array devuelto");
      foreach (var item in numeros2)
      {
        System.Console.WriteLine(item);
      }
    }
    static void ProcesarDatos(int[] data)
    {
      // data es un array de enteros
      for (int i = 0; i < data.Length; i++)
      {
        // vamos a manipular los datos del array
        data[i] += 10;
      }
    }


    // crear un metodo para devolver un array
    static int[] DevolverArray()
    {
      System.Console.WriteLine("Cuanto elementos quieres en el array");
      // pedir al usuario el numero de elementos debe ser string porq nos devuelve un string

      string respuesta = System.Console.ReadLine();
      // convertir el string en un int
      int numElementos = int.Parse(respuesta);
      // crear un array de tipo int
      int[] data = new int[numElementos];
      // rellenar el array
      for (int i = 0; i < numElementos; i++)
      {
        System.Console.WriteLine($"Introduce el dato para la posicion {i}");
        respuesta = Console.ReadLine();
        int datoElement = int.Parse(respuesta);
        data[i] = datoElement;
      }
      return data;
    }
  }
}