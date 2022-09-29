// genericos con restiscriones
// hay ocaciones que no queremos que maneje cualquier tipo de dato


namespace GENERICOS_DOS
{
  class Program
  {
    static void Main(string[] args)
    {
      // EJEMPLO 1
      AlmacenEmpelados<Director> empleado = new AlmacenEmpelados<Director>(2);
      empleado.addEmpleado(new Director(2000));
      empleado.addEmpleado(new Director(3000));
      System.Console.WriteLine(empleado.getEmpleado(1).getSalario());

      // EJEMPLO 2
      AlmacenEmpelados<Secretaria> empleado = new AlmacenEmpelados<Secretaria>(1);
      empleado.addEmpleado(new Secretaria(1000));
      System.Console.WriteLine(empleado.getEmpleado(0).getSalario());


      // EJEMPLO 3
      // no deja implemetar
      //AlmacenEmpelados<Estudiante> empleado = new AlmacenEmpelados<Estudiante>(1);
      //empleado.

    }
  }

  // esta es la forma de crear una clase generica con restricciones
  class AlmacenEmpelados<T> where T : IParaEmpleado
  {
    // variables
    private int i = 0;
    private T[] datosEmpleado;

    // constructor
    public AlmacenEmpelados(int z)
    {
      datosEmpleado = new T[z];
    }

    //metodos
    public void addEmpleado(T obj)
    {
      datosEmpleado[i] = obj;
      i++;
    }
    public T getEmpleado(int i) => datosEmpleado[i];

  }

  class Director : IParaEmpleado
  {
    // variables
    private double salario;

    // constructor  
    public Director(double salario)
    {
      this.salario = salario;
    }

    // metodos
    public double getSalario() => salario;

  }
  class Secretaria : IParaEmpleado
  {
    // variables
    private double salario;

    // constructor  
    public Secretaria(double salario)
    {
      this.salario = salario;
    }
    // metodos
    public double getSalario() => salario;

  }
  class Electricista : IParaEmpleado
  {
    // variables
    private double salario;

    // constructor  
    public Electricista(double salario)
    {
      this.salario = salario;
    }
    // metodos
    public double getSalario() => salario;
  }
  class Estudiante
  {
    // variables
    private double edad;

    // constructor  
    public Estudiante(double edad)
    {
      this.edad = edad;
    }
    // metodos
    public double getEdad() => edad;
  }

  // para que tenga todos los metoso creamos una interfaz
  interface IParaEmpleado
  {
    double getSalario();
  }
}