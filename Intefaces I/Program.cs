// Interfases son un conjunto de metodos que se implementan en las clases
// y que se pueden usar en cualquier clase que implemente la interfase
// en este caso la interfase IAnimal tiene un metodo que se llama
// Comer y que se implementa en las clases Perro y Gato
// y se puede usar en cualquier clase que implemente la interfase
// RESTRICIONES EN LAS INTERFACES
// no se permite definir campos variables en las interfaces
// no se permite definir constructores en las interfaces
// no se permite definir metodos con modificador de acceso
// no se permite definir destrucctores en las interfaces
// no se puede anidar clases dentro de interfaces
namespace Interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Caballo miCaballo = new Caballo("Pegazo");
      miCaballo.getNombre();

      Ballena miBallena = new Ballena("Willy");
      miBallena.Nadar();

      // PRINCIPIO DE SUSTITUCION DE LISKOV
      IMamiferosTerrestres ImiCaballo = miCaballo;
      IAnimalSaltoConPatas ImiCaballo2 = miCaballo;

      System.Console.WriteLine("Numero de patas " + ImiCaballo.NumeroPatas());
      System.Console.WriteLine("Numero de dientes caballo " + ImiCaballo.NumeroDientes());
      System.Console.WriteLine("Numero de dientes ballena " + miBallena.NumeroDientes());

      System.Console.WriteLine("Salto con patas  " + ImiCaballo2.NumeroPatas());

    }
  }

  // interface comportamiento a seguir por las clases que implementen la interfase 
  // nosotros como programadores decidimos que comportamiento debe tener la interfase
  interface IMamiferosTerrestres
  {
    // en los metodos  de interfaces no llevan cuerpo
    // ademas pueden tener muchisimos metodos
    // adicional metodos que son iguales
    int NumeroPatas();
    int NumeroDientes();
  }

  interface IAnimalesDeportes
  {
    string tipoDeporte();
    Boolean esOlimpico();
  }
  interface IAnimalSaltoConPatas
  {
    int NumeroPatas();
  }


  // CLASE PRINCIPAL
  class Mamiferos
  {
    private String nombreSerVivo;

    // Constructor de la clase
    public Mamiferos(String nombre)
    {
      // lo que se almacene en nombreSerVivo se almacena en nombre
      nombreSerVivo = nombre;
    }
    // protected puede ser accedido de la clase base y de las clases que hereden de la clase base
    protected void Respirar()
    {
      System.Console.WriteLine("Respirar");
    }
    public void CiudadCrias()
    {
      System.Console.WriteLine("Ciudar Crias");
    }
    // virual permite que el metodo pueda ser sobreescrito
    public void Pensar()
    {
      System.Console.WriteLine("Pensamiento Basico");
    }

    // metodo get y set para 
    public void getNombre() => System.Console.WriteLine("Nombre del Ser vivo es: " + nombreSerVivo);

  }

  // CLASE HIJA CABALLO
  // para implementar la interface ponemos , y el nombre de la interfase
  class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportes, IAnimalSaltoConPatas

  {
    public Caballo(String nombreCaballo) : base(nombreCaballo)
    {

    }
    public void galopar()
    {
      System.Console.WriteLine("Soy Capaz de Galopar");
    }

    // metodo de la interfase
    // aqui tenemos un porblema de ambiguedad
    // tendremos que quitar el metodos de acceso
    // pero hay solucion con el principio de situcion de herencia ES UN
    int IMamiferosTerrestres.NumeroPatas()
    {
      return 4;
    }

    // solucionamos el problema de ambiguedad
    int IAnimalSaltoConPatas.NumeroPatas()
    {
      return 2;
    }

    public int NumeroDientes()
    {
      return 40;
    }

    public string tipoDeporte()
    {
      return "Jineteo";
    }

    public Boolean esOlimpico()
    {
      return false;
    }

  }

  // CLASE HIJA BALLENA 
  // para implementar la interface ponemos , y el nombre de la interfase
  // aqui no poneos nada porque el meotodo es patas y la ballena no tiene patas
  class Ballena : Mamiferos
  {
    public Ballena(String nombreBallena) : base(nombreBallena)
    {

    }
    public void Nadar()
    {
      System.Console.WriteLine("Soy Capaz de Nadar");
    }

    public int NumeroDientes()
    {
      return 100;
    }
  }
}
