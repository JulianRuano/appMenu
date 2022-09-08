using System;


namespace Servicios
{
    public class ClsConsola 
    {
        public static void EsperarTecla()
        {
            Console.ReadKey();
        }
        public static void Escribir<Tipo>(Tipo prmContenido) 
        {
            Console.Write(prmContenido);
        }
        public static void EscribirEncabezado(string prmTexto)
        {
            EscribirSaltarLinea("------------------------------");
            EscribirSaltarLinea(prmTexto);
            EscribirSaltarLinea("------------------------------");
        }
        public static string Leer()
        {
            return Console.ReadLine();
        }
       
        public static void Pausa(string prmTexto)
        {
            EscribirSaltarLinea(prmTexto);
            EsperarTecla();
        }
       
        public static void LimpiarPantalla()
        {
            Console.Clear();
        }
        public static void EscribirSaltarLinea<Tipo>(Tipo prmContenido)
        {
            Console.WriteLine(prmContenido);
        }

        public static Tipo Leer<Tipo>(string prmEtiqueta)
        {
            do
            {
                try
                {
                    Escribir(prmEtiqueta);
                    return (Tipo)Convert.ChangeType(Leer(), typeof(Tipo));
                }
                catch (Exception e)
                {
                    EscribirEncabezado("ERROR: " + e.Message);
                }
            } while (true);
   
        }
      
    }
}
