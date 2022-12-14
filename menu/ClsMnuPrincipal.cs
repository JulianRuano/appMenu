using Servicios;


namespace appMenu
{
    class ClsMnuPrincipal : ClsMenu
    {

        private void Evento2()
        {
            ClsConsola.EscribirEncabezado("Estamos dentro del Evento 2");
            ClsConsola.EsperarTecla();
        }
        private void Evento3()
        {
            ClsConsola.EscribirEncabezado("Estamos dentro del Evento 3");
            ClsConsola.EsperarTecla();
        }
        protected override void Configurar()
        {
            atrItems.Add("**** Titulo ****");
            atrItems.Add("Evento 1");
            atrItems.Add("Evento 2");
            atrItems.Add("Evento 3");
            atrItems.Add("Salir");
        }

        protected override void procesarMenu()
        {
            ClsConsola.LimpiarPantalla();
            switch (atrOpcionElegida)
            {
                case 1: new ClsMnuEvento1(); break;
                case 2: Evento2(); break;
                case 3: Evento3(); break;
                case 4: ClsConsola.EscribirEncabezado("Regresando..."); break;
                default:
                    ClsConsola.EscribirEncabezado("No existe está opción");
                    ClsConsola.EsperarTecla(); break;
            }
        }

    }
}
