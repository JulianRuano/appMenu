using Servicios;


namespace appMenu
{
    class ClsMnuEvento1 : ClsMenu
    {
        private void Evento1()
        {
            ClsConsola.EscribirEncabezado("Estamos dentro del Evento 1.1");
            ClsConsola.EsperarTecla();
        }
        private void Evento2()
        {
            ClsConsola.EscribirEncabezado("Estamos dentro del Evento 1.2");
            ClsConsola.EsperarTecla();
        }
       
        protected override void Configurar()
        {
            atrItems.Add("**** Evento 1 ****");
            atrItems.Add("Evento 1.1");
            atrItems.Add("Evento 1.2");
            atrItems.Add("Salir");
        }

        protected override void procesarMenu()
        {
            ClsConsola.LimpiarPantalla();
            switch (atrOpcionElegida)
            {
                case 1: Evento1(); break;
                case 2: Evento2(); break;
                case 3: ClsConsola.EscribirEncabezado("Regresando..."); break;
                default:
                    ClsConsola.EscribirEncabezado("No existe está opción");
                    ClsConsola.EsperarTecla(); break;
            }
        }
    }
}
