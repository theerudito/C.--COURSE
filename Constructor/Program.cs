// LOS CONTRUCTORES SON METODOS QUE SE LLAMAN IGUAL QUE LA CLASE
// Y DAN VALORES INICIALES A LOS OBJETOS
// LOS CONTRUCTORES NO TIENEN TIPO DE RETORNO
// SI MI METODO LLEVA VOID NO HAY RETORNO SINO LLEVA VOID SI HAY RETORNO
// ES RECOMENDADO DIVIDIR LA CLASES EN TROZOS MAS PEQUEÑOS

using System;

namespace UsoCoches
{
  class Program
  {
    static void Main(string[] args)
    {
      // Crearemos Nuestro Objeto pero le pasamos valores
      Coche miCoche1 = new Coche(45.2, 1200.5);
      // Impriremos los valores de las propiedades
      Console.WriteLine(miCoche1.getInforCoche());

      Coche miCoche2 = new Coche();
      // Impriremos los valores de las propiedades
      Console.WriteLine(miCoche2.getInforCoche());
      // Impriremos los extras antes llamaremos al metodo
      miCoche2.setExtra(true, "Cuero");
      Console.WriteLine(miCoche2.getExtra());
    }
  }

  // PARA DIVIDIR LA CLASE PONDRIAMOS ANTES DE LA CLASE PARTIAL LUEGO CERRAMO LA LLAVE DONDE QUERAMOS
  partial class Coche
  {

    // CONSTRUCTOR TIENE EL MISMO NOMBRE QUE LA CLASE
    // NO PODRA TENER TIPO DE RETORNO
    // NO SERA VOID
    public Coche()
    {
      // VALORES INICIALES
      ruedas = 4;
      largo = 2000;
      ancho = 0.800;
      // si queremos dar por defecto un valor a un atributo
      tapiceria = "Tela";

    }
    // SI QUEREMOS CREAR OTRO CONSTRUCTOR CON DISTINTOS PARAMETROS 

    public Coche(double largoCoche, double anchoCoche)
    {
      ruedas = 4;
      largo = largoCoche;
      ancho = anchoCoche;
      // si queremos dar por defecto un valor a un atributo
      tapiceria = "Tela";
    }
  }
  // DIVISION DE LA CLASE 
  partial class Coche
  {
    // Metodos de acceso o getters 
    public string getInforCoche()
    {
      return "Informacion del Coche:\n" + " Tiene " + ruedas + " Largo " + largo + " Ancho " + ancho;
    }

    // Metodos de modificacion o setters no tienen retorno ellos solo dan valores
    // normalmente si usamos setters usamos getters
    public void setExtra(bool climatizador, string paramTapiceria)
    {
      // los parametos y las variables deben tener el mismo nombre hay un problema de ambiguidad
      // es recomendado un nombre diferente para usar el mismo usando this
      // this hace referencia a la clase
      //this.climatizador = paramClimatizador;
      this.climatizador = climatizador;
      tapiceria = paramTapiceria;
    }
    public String getExtra()
    {
      return "La Infor Extra del coche :\n" + " Climatizador: " + climatizador + " Tapiceria: " + tapiceria;
    }


    // Las Constante
    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private String tapiceria;
  }

}
