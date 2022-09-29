// DESTRUCTORES garbaje collector => son recolectores de basura
// el lenguaje C# tiene un recolector de basura automatico
// el recolector de basura es un proceso que se ejecuta en segundo plano
// se encarga de liberar la memoria de los objetos que ya no se utilizan
// el recolector de basura se ejecuta cada cierto tiempo y no es inmediato
// el recolector de basura no se ejecuta inmediatamente cuando se destruye un objeto
// ejemplos en coneccion a la base de datos cierre de archivos objetos de colleciones
// tener cuenta q solo se usa solo en clases no en enum, struct, interfaces
// cada clase tiene un destructor
// los destructores no se heredan ni se sobrecargan
// no se llaman son llamados automaticamente por el recolector de basura
// no tiene modificador de acceso ni parametros

namespace DESTRUCTOR
{
  class Program
  {
    static void Main(string[] args)
    {
      // EJEMPLO 1
      ManejoDeArchivos archivo = new ManejoDeArchivos();
      archivo.mensaje();

    }
  }
  class ManejoDeArchivos
  {
    // crear un ojeto de tipo StremReader
    StreamReader archivo = null;

    // variales
    int contador = 0;
    string linea = null;

    // constructor
    public ManejoDeArchivos()
    {
      // abrir el archivo
      archivo = new StreamReader(@"C:\c#.txt");
      // leer el archivo
      while ((linea = archivo.ReadLine()) != null)
      {
        System.Console.WriteLine(linea);
        contador++;

      }
    }
    // metodo mensaje
    public void mensaje()
    {
      System.Console.WriteLine("El archivo tiene " + contador + " lineas");
    }

    // destructor debe llamarse igual que la clase
    ~ManejoDeArchivos()
    {
      // cerrar el archivo
      archivo.Close();
      System.Console.WriteLine("El archivo se cerro");
    }
  }
}