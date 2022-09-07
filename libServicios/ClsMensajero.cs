namespace Servicios
{
    public class clsMensajero
    {
        public static string atrMensajero;
        protected static string auxMensaje;

        public static string darMensaje()
        {
            auxMensaje = atrMensajero;
            atrMensajero = null;
            return auxMensaje;

        }


    }
}
