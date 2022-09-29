// HERENCIA en C# que es y como se usa es UN
// La herecia es una caracteristica de la POO que permite que una clase herede de otra clase
// La clase que hereda se llama clase derivada o clase hija
// La clase de la que hereda se llama clase base o clase padre
// La clase derivada hereda todos los miembros de la clase base
// La clase derivada puede añadir nuevos miembros
// La clase derivada puede sobreescribir los miembros de la clase base
// JEFE ES UN EMPLEADO (Jefe hereda de Empleado)
// DIRECTOR ES UN JEFE (Director hereda de Jefe)
// principio de sustitucion de Liskov (LSP)   es siempre UN
// si S es un subtipo de T, entonces los objetos de tipo T pueden ser reemplazados por objetos de tipo S

namespace Herencia
{
  class Program
  {
    static void Main(String[] args)
    {

      // Creamos un objeto de la clase Mamifero
      Caballo miCaballo = new Caballo("Pegazo");
      Humano miNombre = new Humano("Jorge");
      Perro miPerro = new Perro("Tabaco");
      Lagartija miLagartija = new Lagartija("Limber");

      miLagartija.getNombre();


      // Llamamos al metodo de la clase Mamifero
      miCaballo.getNombre();
      miNombre.getNombre();
      miPerro.getNombre();

      // Principio de sustitucion de Liskov (LSP)   es siempre UN
      // caballo y hombre son mamiferos pero no todos los mamiferos son caballos o hombres
      Mamiferos miCaballo2 = new Caballo("Pegazo");
      Mamiferos miNombre2 = new Humano("Jorge");

      // aqui no aplicamos principio de sustitucion de Liskov (LSP)   es siempre UN
      Mamiferos miPerro2 = new Mamiferos("Tabaco");
      Mamiferos Zeus = new Perro("Zeus");
      miPerro2 = Zeus;

      // Ejemplo 1
      Object miCaballo3 = new Mamiferos("Pegazo");
      Object miNombre3 = new Mamiferos("Jorge");

      // Ejemplo 2
      Mamiferos[] arrayMamiferos = new Mamiferos[3];
      arrayMamiferos[0] = miCaballo;
      arrayMamiferos[1] = miNombre;
      arrayMamiferos[2] = miPerro;

      // ver la informacion del array
      arrayMamiferos[0].getNombre();

      // en ocasiones se comporta como mamifero humano pero esto es polimorfismo
      for (int i = 0; i < arrayMamiferos.Length; i++)
      {
        arrayMamiferos[i].Pensar();

      }
    }

  }

  // CLASE ABSRACTA
  abstract class Animales
  {
    public void Respirar()
    {
      Console.WriteLine("Respirando");
    }
    public abstract void getNombre();
  }

  // LA CLASE BASE
  class Mamiferos : Animales
  {
    // dato tipo clase para dar nombre a cada clase
    // Campos de clase o variables de clase debe tener el mismo nombre que la clase
    private String nombreSerVivo;

    // Constructor de la clase
    public Mamiferos(String nombre)
    {
      // lo que se almacene en nombreSerVivo se almacena en nombre
      nombreSerVivo = nombre;
    }

    // protected puede ser accedido de la clase base y de las clases que hereden de la clase base

    public void CiudadCrias()
    {
      System.Console.WriteLine("Ciudar Crias");
    }
    // virual permite que el metodo pueda ser sobreescrito
    public virtual void Pensar()
    {
      System.Console.WriteLine("Pensamiento Basico");
    }

    // metodo get y set para 
    // implementar el metodo abstracto de la clase base ademas override permite que el metodo pueda ser sobreescrito
    public override void getNombre() => System.Console.WriteLine("El nombre del mamifero: " + nombreSerVivo);

  }
  // LA CLASE DERIVADA
  class Caballo : Mamiferos
  {

    // Constructor de la clase debe llamar al constructor de la clase base
    public Caballo(String nombreCaballo) : base(nombreCaballo)
    {
      // lo que se almacene en nombreSerVivo se almacena en nombre
      // nombreSerVivo = nombreCaballo;
      Mamiferos miCaballo = new Mamiferos(nombreCaballo);
    }
    public void Galopar()
    {
      System.Console.WriteLine("Galopar");
      Respirar();
    }

  }
  // LA CLASE DERIVADA
  class Perro : Mamiferos
  {

    // Constructor de la clase debe llamar al constructor de la clase base
    public Perro(String nombrePerro) : base(nombrePerro)
    {
      // lo que se almacene en nombreSerVivo se almacena en nombre

    }
    public void Ladrar()
    {
      System.Console.WriteLine("Ladrar");
    }
    public override void Pensar()
    {
      System.Console.WriteLine("Pensamiento Avanzado");
    }
  }
  // LA CLASE DERIVADA
  class Humano : Mamiferos
  {

    // Constructor de la clase debe llamar al constructor de la clase base
    public Humano(String nombreHumano) : base(nombreHumano)
    {
      // lo que se almacene en nombreSerVivo se almacena en nombre

    }
    // recordar que este metodo ya existe en la clase base es sobrecarga se oculta
    // tienen dos metedo del mismo porque esta en mamifrero y nombre
    // solucion es usar la palabra reservada new antes del metodo
    // override permite que el metodo pueda ser sobreescrito
    public override void Pensar()
    {
      System.Console.WriteLine("Pensar");
    }
  }
  class Lagartija : Animales
  {

    private String nombreReptil;

    public Lagartija(String nombre)
    {
      nombreReptil = nombre;
    }
    public override void getNombre()
    {
      System.Console.WriteLine("El nombre del reptil: " + nombreReptil);
    }
  }
}
