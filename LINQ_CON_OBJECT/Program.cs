using System.Linq;

namespace LINQ_CON_OBJECT
{
  class Program
  {
    static void Main(string[] args)
    {
      ControlEmpresaEmpleados control = new ControlEmpresaEmpleados();
      control.getCEO();
      control.getSalario();
      control.getEmpleadosOrdenados();
      control.getEmpleadosEmpresa();
    }
  }
  class ControlEmpresaEmpleados
  {
    public List<Empresa> ListaEmpresas;
    public List<Empleado> ListaEmpleados;

    // constructor
    public ControlEmpresaEmpleados()
    {
      ListaEmpresas = new List<Empresa>();
      ListaEmpleados = new List<Empleado>();

      // agregar objetos empresa
      ListaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
      ListaEmpresas.Add(new Empresa { Id = 2, Nombre = "Amazon" });

      // agregar objetos empleado
      ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "Juan", Cargo = "Programador", EmpresaId = 1, Salario = 1000 });
      ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "Jorge", Cargo = "CEO", EmpresaId = 1, Salario = 10000 });
      ListaEmpleados.Add(new Empleado { Id = 3, Nombre = "Erudito", Cargo = "CO-CEO", EmpresaId = 2, Salario = 9999 });
    }

    // metodo para obtener los empleados de una empresa
    public void getCEO()
    {
      IEnumerable<Empleado> CEOS = from empleado in ListaEmpleados
                                   where empleado.Cargo == "CEO"
                                   select empleado;

      foreach (Empleado empleado1 in CEOS)
      {
        empleado1.getDatosEmpleado();
      }
    }

    public void getSalario()
    {
      IEnumerable<Empleado> CEOS = from empleado in ListaEmpleados
                                   where empleado.Salario > 1000
                                   select empleado;

      foreach (Empleado empleado1 in CEOS)
      {
        empleado1.getDatosEmpleado();
      }
    }

    public void getEmpleadosOrdenados()
    {
      IEnumerable<Empleado> Empleado = from empleado in ListaEmpleados
                                       orderby empleado.Nombre descending
                                       select empleado;

      foreach (Empleado empleado2 in Empleado)
      {
        empleado2.getDatosEmpleado();
      }
    }
    // usando con clave foranea
    public void getEmpleadosEmpresa()
    {
      IEnumerable<Empleado> Empleados = from empleado in ListaEmpleados
                                        join empresa in ListaEmpresas on empleado.EmpresaId equals empresa.Id
                                        select empleado;

      foreach (Empleado empleado in Empleados)
      {
        empleado.getDatosEmpleado();
      }
    }

  }

  class Empresa
  {
    public int Id { get; set; }
    public string Nombre { get; set; }

    public void getDatosEmpresa() => System.Console.WriteLine($"Id: {this.Id} Nombre: {this.Nombre}");
  }

  class Empleado
  {
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    // clave foreana
    public int EmpresaId { get; set; }

    public void getDatosEmpleado()
    {
      System.Console.WriteLine("Empleado {0} con Id {1}, cargo {2} y salario {3} perteneciente a la empresa {4} ",
        Nombre, Id, Cargo, Salario, EmpresaId);
    }
  }
}
