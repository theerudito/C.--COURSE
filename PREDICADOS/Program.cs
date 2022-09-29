// DELEGADOS PREDICADOS
// QUE SON LOS PREDICADOS? => son delegados que apuntan a metodos que devuelven un valor booleano
// syntax de un predicado es: Predicate<tipoDato> nombrePredicado = new Predicate<tipoDato>(metodo)
// para q sirven los predicados? => para filtrar datos, para validar datos que esta en una lista o array
namespace PREDICADOS
{
  class Program
  {
    static void Main(string[] args)
    {
      // EJEMPLO 1
      // crear un array de enteros
      int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      // crear un predicado
      Predicate<int> predicado = new Predicate<int>(EsPar);
      // filtrar los numeros pares
      int[] pares = Array.FindAll(numeros, predicado);
      // mostrar los numeros pares
      foreach (int numero in pares)
      {
        System.Console.WriteLine(numero);
      }

      // EJEMPLO 2

      List<Persona> personas = new List<Persona>();
      Persona p1 = new Persona();
      // crear tres persona
      p1.nombre = "Juan,";
      p1.edad = 20;
      Persona p2 = new Persona();
      p2.nombre = "Erudito";
      p2.edad = 25;
      // agregar las personas a la lista
      personas.AddRange(new Persona[] { p1, p2 });
      // crear un predicado
      Predicate<Persona> predicado2 = new Predicate<Persona>(ExisteJuan);
      // filtrar los nombres que contengan Juan
      List<Persona> personasConJuan = personas.FindAll(predicado2);
      // mostrar los nombres que contengan Juan
      bool existe = personas.Exists(predicado2);
      System.Console.WriteLine("Existe Juan? " + existe);


    }

    static bool EsPar(int numero)
    {
      return numero % 2 == 0;
    }

    // EJEMPLO 2
    static bool ExisteJuan(Persona persona)
    {
      return persona.Nombre == "Juan";
    }
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

