using System;


namespace Servicios
{
    public class clsConsola
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
            EscribirSaltarLinea("----------------------------------------------------------------------");
            EscribirSaltarLinea(prmTexto);
            EscribirSaltarLinea("----------------------------------------------------------------------");
        }
        public static string Leer()
        {
            return Console.ReadLine();
        }

        public static void Pausa(string prmTexto)
        {
            EscribirEncabezado(prmTexto);
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
        public static Tipo Leer<Tipo>(string prmEtiqueta, ref Tipo prmDato)
        {

            int varValido = 0;
            do
            {
                Escribir(prmEtiqueta);
                varValido = 0;
                try
                {
                    prmDato = (Tipo)(Convert.ChangeType(Console.ReadLine(), typeof(Tipo)));
                }
                catch (Exception)
                {
                    EscribirSaltarLinea("Error");
                    varValido = 1;
                }

            } while (varValido == 1);

            return prmDato;

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
