// LOS METODOS
namespace AvisosVarios
{
  class AvisosTrafico : IAvisos
  {
    // variables
    private string remitente;
    private string mensaje;
    private string fecha;


    // constuctores
    // constructor por defector
    public AvisosTrafico()
    {
      remitente = "DIRECCION GENERAL DE TRAFICO";
      mensaje = "SANCION DE 200 EUROS POR EXCESO DE VELOCIDAD";
      fecha = "";
    }
    // constructor con personalizado
    // usamos el this para q no se confunda con las variables con los parametros
    public AvisosTrafico(string remitente, string mensaje, string fecha)
    {
      this.remitente = remitente;
      this.mensaje = mensaje;
      this.fecha = fecha;
    }


    // metodos
    public string getFecha() => fecha;

    public void mostrarAviso()
    {
      // Console.WriteLine("REMITENTE: " + remitente);
      Console.WriteLine("Mensaje {0} ha sico enviado por {1} el {2}", mensaje, remitente, fecha);
    }
  }
}
