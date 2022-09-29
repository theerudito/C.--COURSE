using System;
using System.Text.RegularExpressions;
// EXPRESIONES REGULARES
// clases utiles regex, match, MatchCollection, GroupCollection
// metodos utiles: matches
// propiedades utiles: groups
namespace EXP_REGULARES
{
  class Program
  {
    static void Main(string[] args)
    {
      string frase = "Hola, soy un texto de prueba de Hola";
      string patron = "[H]";
      Regex expresion = new Regex(patron);
      MatchCollection coincidencias = expresion.Matches(frase);


      // con foreach
      foreach (Match coincidencia in coincidencias)
      {
        Console.WriteLine(coincidencia.Value);
      }

      // con condiciones
      if (coincidencias.Count > 0) System.Console.WriteLine("Coincidencias de H");
      else System.Console.WriteLine("No hay coincidencias de H");


    }
  }
}