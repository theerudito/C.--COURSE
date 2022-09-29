// LOS GENERICOS
// que programacion generica => reutilizar codigo 
// syntax => EjemploClase <String> nombre = new EjemploClase<String>();
// podemos hacer losmismo sin genericos
// utilizar la herencia para reutilizar codigo tiene sus limitaciones
// uso continuo de casting
// compilacion de codigo
// nos posibilitan de comrprobar errores en tiempo de ejecucion
// son una forma de crear clases, metodos, interfaces, delegados, etc
// porque es recomendable utilizar genericos
// para reutilizar codigo
// para reducir el codigo en diferentes escenarios
// compronar errores en tiempo de compilacion

namespace GENERICOS
{
  class Program
  {
    static void Main(string[] args)
    {
      // EJEMPLO 1
      // si vamos a manejar string
      AlmacenObjetos<String> almacen = new AlmacenObjetos<String>(4);

      almacen.addElemento("Hola");
      almacen.addElemento("Perro");

      // imprimir los elementos del almacen
      String nombrePersona = (String)almacen.getElemento(0);
      System.Console.WriteLine(nombrePersona);


      // EJEMPLO 2
      // si vamos a manejar cualquier dato
      AlmacenObjetos<Empleados> almacen2 = new AlmacenObjetos<Empleados>(4);

      // crear objeto tipo empleado
      almacen2.addElemento(new Empleados(1500));
      almacen2.addElemento(new Empleados(2000));

      // imprimir los elementos del almacen
      Empleados salarioEmpleado = (Empleados)almacen2.getElemento(1);
      System.Console.WriteLine(salarioEmpleado.getSalario());

    }
  }

  // primero usaremos la herencia  se indica con <T> el tipo de dato
  class AlmacenObjetos<T>
  {
    // variables
    private T[] datosElementos;
    private int i = 0;

    // constructor
    public AlmacenObjetos(int z)
    {
      datosElementos = new T[z];
    }

    // metodos add
    public void addElemento(T obj)
    {
      datosElementos[i] = obj;
      i++;
    }

    // metodo para obtener el elemento
    public T getElemento(int i)
    {
      return datosElementos[i];
    }
  }
  class Empleados
  {
    // variables
    private double salario;

    // constructor que recibe el enum
    public Empleados(double salario)
    {
      this.salario = salario;
    }
    // metodos get
    public double getSalario() => salario;
  }
}