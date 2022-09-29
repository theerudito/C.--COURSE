// VAMOS HACER UN EJEMPLO DE AVISOS

namespace AvisosVarios
{
  class Program
  {
    static void Main(string[] args)
    {
      // Aviso por defecto
      AvisosTrafico aviso1 = new AvisosTrafico();
      aviso1.mostrarAviso();


      // Aviso personalizado
      AvisosTrafico aviso2 = new AvisosTrafico("JPE", "SANCION VELOCIADA 300", "12/12/2012");
      aviso2.mostrarAviso();
      aviso2.getFecha();

    }
  }
}