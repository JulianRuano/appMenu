using System.Collections.Generic;
using Servicios;

namespace appMenu
{
    public class ClsMenu
    {      

            #region Atributos
            protected int atrOpcionElegida;
            protected int atrOpcionSalir = -1;
            protected List<string> atrItems = new List<string>();
            #endregion

            #region Metodos
            public ClsMenu()
            {
                Iterar();
            }
            private void Imprimir()
            {

                ClsConsola.LimpiarPantalla();
                ClsConsola.EscribirEncabezado(atrItems[0]);
                for (int varIndice = 1; varIndice < atrItems.Count; varIndice++)
                {
                    ClsConsola.EscribirSaltarLinea(varIndice + ": " + atrItems[varIndice]);

                }

            }

            private void Iterar()
            {
                Configurar();
                atrOpcionSalir = atrItems.Count - 1;
                do
                {

                    Imprimir();
                    atrOpcionElegida = ClsConsola.Leer<int>("Seleccione una Opción del Menu : ");
                    procesarMenu();

                } while (atrOpcionElegida != atrOpcionSalir);
            }
            protected virtual void Configurar() { }
            protected virtual void procesarMenu() { }           
            #endregion        
    }
}
