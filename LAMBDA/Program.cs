// EXPRESIONES LAMBDA
// que son las expresiones lambda son funciones anonimas
// sirven para ejecutar funciones que no necesitan ser nombradas
// ademas simplifican el codigo
// donde y cunado usar expresiones lambda?
// al crear un delegado sencillo  
// en expresiones LINQ query 
// syntax de una expresion lambda es: (parametros) => {codigo}
namespace LAMBDA
{
  class Program
  {
    static void Main(string[] args)
    {

      // EJEMPLO 1
      // uso del delegado con la expresion lambda
      OperacionesMatematicas operaciones = new OperacionesMatematicas(num => num * num);
      System.Console.WriteLine(operaciones(5));

      System.Console.WriteLine();

      // EJEMPLO 2
      OperacionesMatematicas1 operaciones1 = new OperacionesMatematicas1((num1, num2) => num1 + num2);
      System.Console.WriteLine(operaciones1(5, 5));

      System.Console.WriteLine();

      // EJEMPLO 3
      List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      List<int> pares = numeros.FindAll(num => num % 2 == 0);
      foreach (int numero in pares) System.Console.WriteLine(numero);

      System.Console.WriteLine();

      // EJEMPLO 3 con LAMBDA
      pares.ForEach(num =>
      {
        System.Console.WriteLine("El numero par es");
        System.Console.WriteLine(num);
      });

      // EJEMPLO 4
      Persona p1 = new Persona();
      // crear tres persona
      p1.nombre = "Juan,";
      p1.edad = 20;
      Persona p2 = new Persona();
      p2.nombre = "Erudito";
      p2.edad = 25;
      ComparaPersonas comparaEdad = ((p1, p2) => p1 != p2);
      System.Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));

      ComparaPersonas1 comparaEdad1 = ((p1, p2) => p1 == p2);
      System.Console.WriteLine(comparaEdad1(p1.Nombre, p2.Nombre));

    }

    // EJEMPLO 1
    // crear un delegado con la expresion lambda
    public delegate int OperacionesMatematicas(int numero);

    // EJEMPLO 2
    public delegate int OperacionesMatematicas1(int numero, int numero2);

    // EJEMPLO 4
    public delegate bool ComparaPersonas(int edad1, int edad2);
    public delegate bool ComparaPersonas1(string n1, string n2);

  }
  class Persona
  {
    // variables
    public string nombre;
    public int edad;

    // metodos
    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }

  }
}
